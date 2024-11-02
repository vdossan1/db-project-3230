using System.ComponentModel;
using System.Diagnostics;
using HealthCareApp.DAL;
using HealthCareApp.model;
using HealthCareApp.utils;
using MySql.Data.MySqlClient;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.viewmodel
{
	/// <summary>
	/// ViewModel for managing patient information in the application. 
	/// Responsible for editing and registering patients, 
	/// and populating fields with patient data.
	/// </summary>
	public class AddPatientPageViewModel : INotifyPropertyChanged
    {
        #region Constants

		private const string SSN_INVALID_SIZE = "This field needs 9 digits";
        private const string ZIP_CODE_INVALID_SIZE = "This field need 5 digits";
        private const string PHONE_NUMBER_INVALID_SIZE = "This field needs 10 digits";

        private const string INVALID_FIELD_INPUT = "Required field";
        private const string INVALID_DATE = "Invalid Date";
        private const string INVALID_COMBO_BOX_SELECTION = "Please select valid option";

		#endregion

		public AddPatientPageViewModel()
		{
			this.ValidationErrors = new Dictionary<string, string>();
		}

		/// <summary>
		/// Handles the management of patient information in the application based on the specified action.
		/// </summary>
		/// <param name="action">The PatientAction which determines the action to be taken by this method.</param>
		public bool ManagePatient(PatientAction action)
        {
            var result = false;
            try
            {
                if (IsValid)
                {
                    this.ExecutePatientAction(action);
					result = true;
                    Debug.WriteLine($"Patient Registered: {FirstName} {LastName} {DateOfBirth.ToString()} {Sex}");
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

		private void ExecutePatientAction(PatientAction action)
		{
			Patient newPatient = new Patient(FirstName, LastName, DateOfBirth, Sex,
				Address1, Address2, City, State, ZipCode, PhoneNumber, Ssn, true);

			switch (action)
			{
				case PatientAction.REGISTER:
					PatientDal.RegisterPatient(newPatient);
					break;
				case PatientAction.EDIT:
					PatientDal.EditPatient(newPatient);
					break;
			}
		}

		private bool IsValidPhoneNumber(string phoneNumberParam) =>
			phoneNumberParam?.All(char.IsDigit) == true && phoneNumberParam.Length == 10;

		private bool IsValidZipCode(string zipCodeParam) =>
			zipCodeParam?.All(char.IsDigit) == true && zipCodeParam.Length == 5;

		private bool IsValidSSN(string ssnParam) =>
			ssnParam?.All(char.IsDigit) == true && ssnParam.Length == 9;

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

		/// <summary>
		/// Gets an array of all possible states as defined in the <see cref="State"/> enumeration.
		/// </summary>
		public Array StatesArray => Enum.GetValues(typeof(State));


        /// <summary>
        /// Gets an array of all possible sexes as defined in the <see cref="Sex"/> enumeration.
        /// </summary>
        public Array SexArray => Enum.GetValues(typeof(Gender));

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

		private DateTime? dateOfBirth;
		/// <summary>
		/// Gets or sets the date of birth of the patient. 
		/// Raises the <see cref="PropertyChanged"/> event when changed.
		/// </summary>
		public DateTime? DateOfBirth
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
                    sex = value == Gender.MALE.ToString() ? "M" : "F";
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

		#region ValidationMessageProperties

		public string FirstNameValidationMessage =>
			ValidationErrors.ContainsKey(nameof(FirstName)) ? ValidationErrors[nameof(FirstName)] : string.Empty;

		public string LastNameValidationMessage =>
			ValidationErrors.ContainsKey(nameof(LastName)) ? ValidationErrors[nameof(LastName)] : string.Empty;

		public string SexValidationMessage =>
			ValidationErrors.ContainsKey(nameof(Sex)) ? ValidationErrors[nameof(Sex)] : string.Empty;

		public string DateOfBirthValidationMessage =>
			ValidationErrors.ContainsKey(nameof(DateOfBirth)) ? ValidationErrors[nameof(DateOfBirth)] : string.Empty;

		public string PhoneNumberValidationMessage =>
			ValidationErrors.ContainsKey(nameof(PhoneNumber)) ? ValidationErrors[nameof(PhoneNumber)] : string.Empty;

		public string SsnValidationMessage =>
			ValidationErrors.ContainsKey(nameof(Ssn)) ? ValidationErrors[nameof(Ssn)] : string.Empty;

		public string Address1ValidationMessage =>
			ValidationErrors.ContainsKey(nameof(Address1)) ? ValidationErrors[nameof(Address1)] : string.Empty;

		public string CityValidationMessage =>
			ValidationErrors.ContainsKey(nameof(City)) ? ValidationErrors[nameof(City)] : string.Empty;

		public string StateValidationMessage =>
			ValidationErrors.ContainsKey(nameof(State)) ? ValidationErrors[nameof(State)] : string.Empty;

		public string ZipCodeValidationMessage =>
			ValidationErrors.ContainsKey(nameof(ZipCode)) ? ValidationErrors[nameof(ZipCode)] : string.Empty;

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

			if (string.IsNullOrWhiteSpace(FirstName))
			{
				ValidationErrors[nameof(FirstName)] = INVALID_FIELD_INPUT;
				IsValid = false;
			}

			if (string.IsNullOrWhiteSpace(LastName))
			{
				ValidationErrors[nameof(LastName)] = INVALID_FIELD_INPUT;
				IsValid = false;
			}

			if (string.IsNullOrWhiteSpace(Sex))
			{
				ValidationErrors[nameof(Sex)] = INVALID_COMBO_BOX_SELECTION;
				IsValid = false;
			}

			if (DateOfBirth >= DateTime.Now)
			{
				ValidationErrors[nameof(DateOfBirth)] = INVALID_DATE;
				IsValid = false;
			}

			if (!IsValidPhoneNumber(PhoneNumber))
			{
				ValidationErrors[nameof(PhoneNumber)] = PHONE_NUMBER_INVALID_SIZE;
				IsValid = false;
			}

			if (!IsValidSSN(Ssn))
			{
				ValidationErrors[nameof(Ssn)] = SSN_INVALID_SIZE;
				IsValid = false;
			}

			if (string.IsNullOrWhiteSpace(Address1))
			{
				ValidationErrors[nameof(Address1)] = INVALID_FIELD_INPUT;
				IsValid = false;
			}

			if (string.IsNullOrWhiteSpace(City))
			{
				ValidationErrors[nameof(City)] = INVALID_FIELD_INPUT;
				IsValid = false;
			}

			if (string.IsNullOrWhiteSpace(State))
			{
				ValidationErrors[nameof(State)] = INVALID_COMBO_BOX_SELECTION;
				IsValid = false;
			}

			if (!IsValidZipCode(ZipCode))
			{
				ValidationErrors[nameof(ZipCode)] = ZIP_CODE_INVALID_SIZE;
				IsValid = false;
			}
		}

		#endregion
	}
}
