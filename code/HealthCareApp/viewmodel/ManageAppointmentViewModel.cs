using HealthCareApp.DAL;
using HealthCareApp.model;
using HealthCareApp.utils;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Encoders;
using System.ComponentModel;
using System.Diagnostics;

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

		private const string SSN_INVALID_SIZE = "This field needs 9 digits";
		private const string ZIP_CODE_INVALID_SIZE = "This field need 5 digits";
		private const string PHONE_NUMBER_INVALID_SIZE = "This field needs 10 digits";

		private const string INVALID_FIELD_INPUT = "Required field";
		private const string INVALID_DATE = "Invalid AppointmentDate";
		private const string INVALID_COMBO_BOX_SELECTION = "Please select valid option";

		#endregion

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
					Debug.WriteLine($"Appointment Created: {Patient.FirstName} {Doctor.FirstName} {Reason} {Date.ToString()} {Time.ToString()}");
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
			this.SetIdToObjects(appointment);
			Reason = appointment.Reason;
			Date = appointment.AppointmentDate;
			Time = appointment.AppointmentDate.Value.TimeOfDay;
		}

		private void SetIdToObjects(Appointment appointment)
		{
			Patient = Patients.Find(p => p.PatientId == appointment.PatientId);
			Doctor = Doctors.Find(d => d.DoctorId == appointment.DoctorId);
		}

		private void PopulateDataGrids()
		{
			Patients = PatientDal.GetAllPatients();
			Doctors = DoctorDal.GetAllDoctors();
		}

		private void ExecuteAppointmentAction(AppointmentAction action)
		{
			Appointment newAppointment = new Appointment(Patient.PatientId, Doctor.DoctorId, Date, Reason);

			switch (action)
			{
				case AppointmentAction.CREATE:
					AppointmentDal.CreateAppointment(newAppointment);
					break;
				case AppointmentAction.EDIT:
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

		private TimeSpan? time;
		/// <summary>
		/// Gets or sets the time of the appointment. 
		/// Raises the <see cref="PropertyChanged"/> event when changed.
		/// </summary>
		public TimeSpan? Time
		{
			get => time;
			set
			{
				if (time != value)
				{
					time = value;
					OnPropertyChanged(nameof(Time));
				}
			}
		}

		#endregion

		#region ValidationMessageProperties

		public string ReasonValidationMessage =>
			ValidationErrors.ContainsKey(nameof(Reason)) ? ValidationErrors[nameof(Reason)] : string.Empty;

		public string DateValidationMessage =>
			ValidationErrors.ContainsKey(nameof(Date)) ? ValidationErrors[nameof(Date)] : string.Empty;

		public string TimeValidationMessage =>
			ValidationErrors.ContainsKey(nameof(Time)) ? ValidationErrors[nameof(Time)] : string.Empty;

		#endregion

		#region FieldValidation

		/// <summary>
		/// Determines if the data enter by the user is valid
		/// </summary>
		public bool IsValid { get; private set; }

		public Dictionary<string, string> ValidationErrors { get; private set; }

		public void ValidateFields()
		{
			ValidationErrors.Clear();
			IsValid = true;

			if (string.IsNullOrWhiteSpace(Reason))
			{
				ValidationErrors[nameof(Reason)] = INVALID_FIELD_INPUT;
				IsValid = false;
			}

			if (Date >= DateTime.Now)
			{
				ValidationErrors[nameof(Date)] = INVALID_DATE;
				IsValid = false;
			}
		}

		#endregion
	}
}
