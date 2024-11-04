using HealthCareApp.DAL;
using HealthCareApp.model;
using HealthCareApp.utils;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Diagnostics;
using static HealthCareApp.view.AdvancedSearchControl;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.viewmodel
{
	/// <summary>
	/// ViewModel for managing appointment information in the application. 
	/// Responsible for editing and creating appointments, 
	/// and populating fields with appointment data.
	/// </summary>
	public class ManageAppointmentViewModel : INotifyPropertyChanged
	{
		#region Constants

		private const string INVALID_FIELD_INPUT = "Required field";
		private const string INVALID_DATE = "Invalid Appointment Date";
		private const string INVALID_PATIENT_SELECTION = "Please select a Patient";
		private const string INVALID_DOCTOR_SELECTION = "Please select a Doctor";

		#endregion

		public Appointment SelectedAppointment { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ManageAppointmentViewModel"/> class.
		/// </summary>
		public ManageAppointmentViewModel()
		{
			this.ValidationErrors = new Dictionary<string, string>();
			Patients = new List<Patient>();
			Doctors = new List<Doctor>();
			this.PopulateDataGrids();
		}

		/// <summary>
		/// Handles the management of appointment information in the application based on the specified action.
		/// </summary>
		/// <param name="action">The AppointmentAction which determines the action to be taken by this method.</param>
		public bool ManageAppointment(AppointmentAction action)
		{
			var result = false;
			try
			{
				if (IsValid)
				{
					this.ExecuteAppointmentAction(action);
					result = true;
					Debug.WriteLine($"Appointment Created: {Patient.FirstName} {Doctor.FirstName} {Reason} {Date.ToString()}");
				}
			}
			catch (MySqlException sqlException)
			{
				Debug.WriteLine(sqlException);
				this.OnErrorOccured($"{sqlException.Message}");
			}
			catch (Exception e)
			{
				Debug.WriteLine(e);
				this.OnErrorOccured($"Exception \n {e.Message}");
			}
			return result;
		}

		/// <summary>
		/// Populates the ViewModel's fields with the data from the specified appointment.
		/// </summary>
		/// <param name="appointment">The appointment object whose data will be used to populate the fields.</param>
		public void PopulateFields(Appointment appointment)
		{
			Patient = Patients.Find(p => p.PatientId == appointment.PatientId);
			Doctor = Doctors.Find(d => d.DoctorId == appointment.DoctorId);
			Reason = appointment.Reason;
			Date = appointment.AppointmentDate;
		}

		public void PopulateDataGrids(SearchEventArgs eventArgs = null)
		{
			if (eventArgs == null)
			{
				Patients = PatientDal.GetAllPatients();
				Doctors = DoctorDal.GetAllDoctors();
			}
			else
			{
				var firstName = eventArgs.FirstName;
				var lastName = eventArgs.LastName;
				var dateOfBirth = eventArgs.DateOfBirth;

				Patients = PatientDal.GetAllPatientsWithParams(firstName, lastName, dateOfBirth);
				Doctors = DoctorDal.GetAllDoctorsWithParams(firstName, lastName, dateOfBirth);
			}
		}

		private void ExecuteAppointmentAction(AppointmentAction action)
		{
			Appointment newAppointment = new Appointment(Patient.PatientId, Doctor.DoctorId, Date, Reason);

			switch (action)
			{
				case AppointmentAction.CREATE:
					AppointmentDal.CreateAppointment(newAppointment);
                    OnAddAppointment();
                    break;
				case AppointmentAction.EDIT:
					newAppointment.AppointmentId = SelectedAppointment.AppointmentId;
					AppointmentDal.EditAppointment(newAppointment);
					break;
			}
		}

		#region Events

		/// <summary>
		/// Occurs when a property value changes.
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		public EventHandler<string> ErrorOccured;

		protected virtual void OnErrorOccured(string message)
		{
			this.ErrorOccured?.Invoke(this, message);
		}

		/// <summary>
		/// Raises the <see cref="PropertyChanged"/> event for a property.
		/// </summary>
		/// <param name="propertyName">The name of the property that changed.</param>
		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
			ValidateFields();
		}

        public static event EventHandler AddAppointment;

        private void OnAddAppointment()
        {
            AddAppointment?.Invoke(this, EventArgs.Empty);
        }

        #endregion

        #region Properties

        public List<Patient> Patients { get; set; }
		public List<Doctor> Doctors { get; set; }

		private Patient patient;
		/// <summary>
		/// Gets or sets the Patient for the appointment. 
		/// Raises the <see cref="PropertyChanged"/> event when changed.
		/// </summary>
		public Patient Patient
		{
			get => patient;
			set
			{
				if (patient != value)
				{
					patient = value;
					OnPropertyChanged(nameof(Patient));
				}
			}
		}

		private Doctor doctor;
		/// <summary>
		/// Gets or sets the Doctor for the appointment. 
		/// Raises the <see cref="PropertyChanged"/> event when changed.
		/// </summary>
		public Doctor Doctor
		{
			get => doctor;
			set
			{
				if (doctor != value)
				{
					doctor = value;
					OnPropertyChanged(nameof(Doctor));
				}
			}
		}

		private string reason;
		/// <summary>
		/// Gets or sets the reason for the appointment. 
		/// Raises the <see cref="PropertyChanged"/> event when changed.
		/// </summary>
		public string Reason
		{
			get => reason;
			set
			{
				if (reason != value)
				{
					reason = value;
					OnPropertyChanged(nameof(Reason));
				}
			}
		}

		private DateTime? date;
		/// <summary>
		/// Gets or sets the date of the appointment. 
		/// Raises the <see cref="PropertyChanged"/> event when changed.
		/// </summary>
		public DateTime? Date
		{
			get => date;
			set
			{
				if (date != value)
				{
					date = value;
					OnPropertyChanged(nameof(Date));
				}
			}
		}

		#endregion

		#region ValidationMessageProperties

		public string PatientValidationMessage =>
			ValidationErrors.ContainsKey(nameof(Patient)) ? ValidationErrors[nameof(Patient)] : string.Empty;

		public string DoctorValidationMessage =>
			ValidationErrors.ContainsKey(nameof(Doctor)) ? ValidationErrors[nameof(Doctor)] : string.Empty;

		public string ReasonValidationMessage =>
			ValidationErrors.ContainsKey(nameof(Reason)) ? ValidationErrors[nameof(Reason)] : string.Empty;

		public string DateValidationMessage =>
			ValidationErrors.ContainsKey(nameof(Date)) ? ValidationErrors[nameof(Date)] : string.Empty;

		#endregion

		#region FieldValidation

		/// <summary>
		/// Determines if the data entered by the user is valid
		/// </summary>
		public bool IsValid { get; private set; }

		public Dictionary<string, string> ValidationErrors { get; private set; }

		public void ValidateFields()
		{
			ValidationErrors.Clear();
			IsValid = true;

			if (Patient == null)
			{
				ValidationErrors[nameof(Patient)] = INVALID_PATIENT_SELECTION;
				IsValid = false;
			}

			if (Doctor == null)
			{
				ValidationErrors[nameof(Doctor)] = INVALID_DOCTOR_SELECTION;
				IsValid = false;
			}

			if (string.IsNullOrWhiteSpace(Reason))
			{
				ValidationErrors[nameof(Reason)] = INVALID_FIELD_INPUT;
				IsValid = false;
			}

			if (Date <= DateTime.Now)
			{
				ValidationErrors[nameof(Date)] = INVALID_DATE;
				IsValid = false;
			}
		}

		#endregion
	}
}
