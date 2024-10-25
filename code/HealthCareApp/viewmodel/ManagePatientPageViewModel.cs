using System.ComponentModel;
using System.Diagnostics;
using HealthCareApp.DAL;
using HealthCareApp.model;
using HealthCareApp.utils;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.viewmodel
{
	/// <summary>
	/// ViewModel for managing patient information in the application. 
	/// Responsible for editing and registering patients, 
	/// and populating fields with patient data.
	/// </summary>
	public class ManagePatientPageViewModel : INotifyPropertyChanged
	{
		/// <summary>
		/// Occurs when a property value changes.
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;


		/// <summary>
		/// Gets an array of all possible states as defined in the <see cref="State"/> enumeration.
		/// </summary>
		public Array StatesArray => Enum.GetValues(typeof(State));


		/// <summary>
		/// Gets an array of all possible sexes as defined in the <see cref="Sex"/> enumeration.
		/// </summary>
		public Array SexArray => Enum.GetValues(typeof(Sex));


		/// <summary>
		/// Edits an existing patient in the database using the current property values.
		/// </summary>
		public void EditPatient()
		{
			Patient patientToEdit = new Patient(FirstName, LastName, DateOfBirth, Sex,
				Address1, Address2, City, State, ZipCode, PhoneNumber, Ssn, true);

			PatientDal.EditPatient(patientToEdit);
			Debug.WriteLine($"{FirstName} {LastName} {DateOfBirth.ToShortDateString()} {Sex}");
		}

		/// <summary>
		/// Registers a new patient in the database using the current property values.
		/// </summary>
		public void RegisterPatient()
		{
			Patient newPatient = new Patient(FirstName, LastName, DateOfBirth, Sex,
				Address1, Address2, City, State, ZipCode, PhoneNumber, Ssn, true);

			PatientDal.RegisterPatient(newPatient);
			Debug.WriteLine($"{FirstName} {LastName} {DateOfBirth.ToShortDateString()} {Sex}");
		}

		/// <summary>
		/// Populates the ViewModel's fields with the data from the specified patient.
		/// </summary>
		/// <param name="patient">The patient object whose data will be used to populate the fields.</param>
		public void PopulateFields(Patient patient)
		{
			FirstName = patient.FirstName;
			LastName = patient.LastName;
			DateOfBirth = patient.DateOfBirth;
			Sex = patient.Sex;
			Address1 = patient.Address1;
			Address2 = patient.Address2;
			City = patient.City;
			State = patient.State;
			ZipCode = patient.ZipCode;
			PhoneNumber = patient.PhoneNumber;
			Ssn = patient.Ssn;
			Status = patient.Status;
		}

		/// <summary>
		/// Raises the <see cref="PropertyChanged"/> event for a property.
		/// </summary>
		/// <param name="propertyName">The name of the property that changed.</param>
		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		#region Properties

		private string firstName;
		/// <summary>
		/// Gets or sets the first name of the patient. 
		/// Raises the <see cref="PropertyChanged"/> event when changed.
		/// </summary>
		public string FirstName
		{
			get => firstName;
			set
			{
				if (firstName != value)
				{
					firstName = value;
					OnPropertyChanged(nameof(FirstName));
				}
			}
		}

		private string lastName;
		/// <summary>
		/// Gets or sets the last name of the patient. 
		/// Raises the <see cref="PropertyChanged"/> event when changed.
		/// </summary>
		public string LastName
		{
			get => lastName;
			set
			{
				if (lastName != value)
				{
					lastName = value;
					OnPropertyChanged(nameof(LastName));
				}
			}
		}

		private DateTime dateOfBirth;
		/// <summary>
		/// Gets or sets the date of birth of the patient. 
		/// Raises the <see cref="PropertyChanged"/> event when changed.
		/// </summary>
		public DateTime DateOfBirth
		{
			get => dateOfBirth;
			set
			{
				if (dateOfBirth != value)
				{
					dateOfBirth = value;
					OnPropertyChanged(nameof(DateOfBirth));
				}
			}
		}

		private string sex;
		/// <summary>
		/// Gets or sets the sex of the patient. 
		/// Raises the <see cref="PropertyChanged"/> event when changed.
		/// </summary>
		public string Sex
		{
			get => sex;
			set
			{
				if (sex != value)
				{
					sex = value;
					OnPropertyChanged(nameof(Sex));
				}
			}
		}

		private string address1;
		/// <summary>
		/// Gets or sets the first line of the patient's address. 
		/// Raises the <see cref="PropertyChanged"/> event when changed.
		/// </summary>
		public string Address1
		{
			get => address1;
			set
			{
				if (address1 != value)
				{
					address1 = value;
					OnPropertyChanged(nameof(Address1));
				}
			}
		}

		private string? address2;
		/// <summary>
		/// Gets or sets the second line of the patient's address. 
		/// Raises the <see cref="PropertyChanged"/> event when changed.
		/// </summary>
		public string? Address2
		{
			get => address2;
			set
			{
				if (address2 != value)
				{
					address2 = value;
					OnPropertyChanged(nameof(Address2));
				}
			}
		}

		private string city;
		/// <summary>
		/// Gets or sets the city of the patient's address. 
		/// Raises the <see cref="PropertyChanged"/> event when changed.
		/// </summary>
		public string City
		{
			get => city;
			set
			{
				if (city != value)
				{
					city = value;
					OnPropertyChanged(nameof(City));
				}
			}
		}

		private string state;
		/// <summary>
		/// Gets or sets the state of the patient's address. 
		/// Raises the <see cref="PropertyChanged"/> event when changed.
		/// </summary>
		public string State
		{
			get => state;
			set
			{
				if (state != value)
				{
					state = value;
					OnPropertyChanged(nameof(State));
				}
			}
		}

		private string zipCode;
		/// <summary>
		/// Gets or sets the ZIP code of the patient's address. 
		/// Raises the <see cref="PropertyChanged"/> event when changed.
		/// </summary>
		public string ZipCode
		{
			get => zipCode;
			set
			{
				if (zipCode != value)
				{
					zipCode = value;
					OnPropertyChanged(nameof(ZipCode));
				}
			}
		}

		private string phoneNumber;
		/// <summary>
		/// Gets or sets the patient's phone number. 
		/// Raises the <see cref="PropertyChanged"/> event when changed.
		/// </summary>
		public string PhoneNumber
		{
			get => phoneNumber;
			set
			{
				if (phoneNumber != value)
				{
					phoneNumber = value;
					OnPropertyChanged(nameof(PhoneNumber));
				}
			}
		}

		private string ssn;
		/// <summary>
		/// Gets or sets the social security number of the patient. 
		/// Raises the <see cref="PropertyChanged"/> event when changed.
		/// </summary>
		public string Ssn
		{
			get => ssn;
			set
			{
				if (ssn != value)
				{
					ssn = value;
					OnPropertyChanged(nameof(Ssn));
				}
			}
		}

		private bool status;
		/// <summary>
		/// Gets or sets the status of the patient (active/inactive). 
		/// Raises the <see cref="PropertyChanged"/> event when changed.
		/// </summary>
		public bool Status
		{
			get => status;
			set
			{
				if (status != value)
				{
					status = value;
					OnPropertyChanged(nameof(Status));
				}
			}
		}

		#endregion
	}
}
