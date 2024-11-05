using System.ComponentModel;
using System.Diagnostics;
using HealthCareApp.DAL;
using HealthCareApp.model;
using HealthCareApp.utils;
using MySql.Data.MySqlClient;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.viewmodel;

/// <summary>
///     ViewModel for managing patient information in the application.
///     Responsible for editing and registering patients,
///     and populating fields with patient data.
/// </summary>
public class ManagePatientViewModel : INotifyPropertyChanged
{
    #region Data members

    private string firstName;

    private string lastName;

    private DateTime? dateOfBirth;

    private string sex;

    private string address1;

    private string? address2;

    private string city;

    private string state;

    private string zipCode;

    private string phoneNumber;

    private string ssn;

    private bool status;

    #endregion

    #region Properties

    /// <summary>
    ///     Gets an array of all possible states as defined in the <see cref="State" /> enumeration.
    /// </summary>
    public string[] StatesArray => Enum.GetNames(typeof(State));

    /// <summary>
    ///     Gets an array of all possible sexes as defined in the <see cref="Sex" /> enumeration.
    /// </summary>
    public string[] SexArray => Enum.GetNames(typeof(Gender));

    /// <summary>
    ///     Gets or sets the first name of the patient.
    ///     Raises the <see cref="PropertyChanged" /> event when changed.
    /// </summary>
    public string FirstName
    {
        get => this.firstName;
        set
        {
            if (this.firstName != value)
            {
                this.firstName = value;
                this.OnPropertyChanged(nameof(this.FirstName));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the last name of the patient.
    ///     Raises the <see cref="PropertyChanged" /> event when changed.
    /// </summary>
    public string LastName
    {
        get => this.lastName;
        set
        {
            if (this.lastName != value)
            {
                this.lastName = value;
                this.OnPropertyChanged(nameof(this.LastName));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the date of birth of the patient.
    ///     Raises the <see cref="PropertyChanged" /> event when changed.
    /// </summary>
    public DateTime? DateOfBirth
    {
        get => this.dateOfBirth;
        set
        {
            if (this.dateOfBirth != value)
            {
                this.dateOfBirth = value;
                this.OnPropertyChanged(nameof(this.DateOfBirth));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the sex of the patient.
    ///     Raises the <see cref="PropertyChanged" /> event when changed.
    /// </summary>
    public string Sex
    {
        get => this.sex;
        set
        {
            if (this.sex != value)
            {
                this.sex = value == Gender.M.ToString() ? "M" : "F";
                this.OnPropertyChanged(nameof(this.Sex));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the first line of the patient's address.
    ///     Raises the <see cref="PropertyChanged" /> event when changed.
    /// </summary>
    public string Address1
    {
        get => this.address1;
        set
        {
            if (this.address1 != value)
            {
                this.address1 = value;
                this.OnPropertyChanged(nameof(this.Address1));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the second line of the patient's address.
    ///     Raises the <see cref="PropertyChanged" /> event when changed.
    /// </summary>
    public string? Address2
    {
        get => this.address2;
        set
        {
            if (this.address2 != value)
            {
                this.address2 = value;
                this.OnPropertyChanged(nameof(this.Address2));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the city of the patient's address.
    ///     Raises the <see cref="PropertyChanged" /> event when changed.
    /// </summary>
    public string City
    {
        get => this.city;
        set
        {
            if (this.city != value)
            {
                this.city = value;
                this.OnPropertyChanged(nameof(this.City));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the state of the patient's address.
    ///     Raises the <see cref="PropertyChanged" /> event when changed.
    /// </summary>
    public string State
    {
        get => this.state;
        set
        {
            if (this.state != value)
            {
                this.state = value;
                this.OnPropertyChanged(nameof(this.State));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the ZIP code of the patient's address.
    ///     Raises the <see cref="PropertyChanged" /> event when changed.
    /// </summary>
    public string ZipCode
    {
        get => this.zipCode;
        set
        {
            if (this.zipCode != value)
            {
                this.zipCode = value;
                this.OnPropertyChanged(nameof(this.ZipCode));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the patient's phone number.
    ///     Raises the <see cref="PropertyChanged" /> event when changed.
    /// </summary>
    public string PhoneNumber
    {
        get => this.phoneNumber;
        set
        {
            if (this.phoneNumber != value)
            {
                this.phoneNumber = value;
                this.OnPropertyChanged(nameof(this.PhoneNumber));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the social security number of the patient.
    ///     Raises the <see cref="PropertyChanged" /> event when changed.
    /// </summary>
    public string Ssn
    {
        get => this.ssn;
        set
        {
            if (this.ssn != value)
            {
                this.ssn = value;
                this.OnPropertyChanged(nameof(this.Ssn));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the status of the patient (active/inactive).
    ///     Raises the <see cref="PropertyChanged" /> event when changed.
    /// </summary>
    public bool Status
    {
        get => this.status;
        set
        {
            if (this.status != value)
            {
                this.status = value;
                this.OnPropertyChanged(nameof(this.Status));
            }
        }
    }

    /// <summary>
    ///     Gets the validation message for the First Name field.
    /// </summary>
    public string FirstNameValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.FirstName))
        ? this.ValidationErrors[nameof(this.FirstName)]
        : string.Empty;

    /// <summary>
    ///     Gets the validation message for the Last Name field.
    /// </summary>
    public string LastNameValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.LastName))
        ? this.ValidationErrors[nameof(this.LastName)]
        : string.Empty;

    /// <summary>
    ///     Gets the validation message for the Sex field.
    /// </summary>
    public string SexValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.Sex))
        ? this.ValidationErrors[nameof(this.Sex)]
        : string.Empty;

    /// <summary>
    ///     Gets the validation message for the Date of Birth field.
    /// </summary>
    public string DateOfBirthValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.DateOfBirth))
        ? this.ValidationErrors[nameof(this.DateOfBirth)]
        : string.Empty;

    /// <summary>
    ///     Gets the validation message for the Phone Number field.
    /// </summary>
    public string PhoneNumberValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.PhoneNumber))
        ? this.ValidationErrors[nameof(this.PhoneNumber)]
        : string.Empty;

    /// <summary>
    ///     Gets the validation message for the SSN field.
    /// </summary>
    public string SsnValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.Ssn))
        ? this.ValidationErrors[nameof(this.Ssn)]
        : string.Empty;

    /// <summary>
    ///     Gets the validation message for the Address Line 1 field.
    /// </summary>
    public string Address1ValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.Address1))
        ? this.ValidationErrors[nameof(this.Address1)]
        : string.Empty;

    /// <summary>
    ///     Gets the validation message for the City field.
    /// </summary>
    public string CityValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.City))
        ? this.ValidationErrors[nameof(this.City)]
        : string.Empty;

    /// <summary>
    ///     Gets the validation message for the State field.
    /// </summary>
    public string StateValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.State))
        ? this.ValidationErrors[nameof(this.State)]
        : string.Empty;

    /// <summary>
    ///     Gets the validation message for the Zip Code field.
    /// </summary>
    public string ZipCodeValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.ZipCode))
        ? this.ValidationErrors[nameof(this.ZipCode)]
        : string.Empty;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="ManagePatientViewModel" /> class.
    /// </summary>
    public ManagePatientViewModel()
    {
        this.ValidationErrors = new Dictionary<string, string>();
    }

    #endregion

    #region Methods

    /// <summary>
    ///     Handles the management of patient information in the application based on the specified action.
    /// </summary>
    /// <param name="action">The PatientAction which determines the action to be taken by this method.</param>
    public bool ManagePatient(PatientAction action)
    {
        var result = false;
        try
        {
            if (this.IsValid)
            {
                this.ExecutePatientAction(action);
                result = true;
                Debug.WriteLine(
                    $"Patient Registered: {this.FirstName} {this.LastName} {this.DateOfBirth.ToString()} {this.Sex}");
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
    ///     Populates the ViewModel's fields with the data from the specified patient.
    /// </summary>
    /// <param name="patient">The patient object whose data will be used to populate the fields.</param>
    public void PopulateFields(Patient patient)
    {
        this.FirstName = patient.FirstName;
        this.LastName = patient.LastName;
        this.DateOfBirth = patient.DateOfBirth;
        this.Sex = patient.Sex;
        this.Address1 = patient.Address1;
        this.Address2 = patient.Address2;
        this.City = patient.City;
        this.State = patient.State;
        this.ZipCode = patient.ZipCode;
        this.PhoneNumber = patient.PhoneNumber;
        this.Ssn = patient.Ssn;
        this.Status = patient.Status;
    }

    private void ExecutePatientAction(PatientAction action)
    {
        var newPatient = new Patient(this.FirstName, this.LastName, this.DateOfBirth, this.Sex, this.Address1,
            this.Address2, this.City, this.State, this.ZipCode, this.PhoneNumber, this.Ssn, true);

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

    #endregion

    #region Constants

    private const string SSN_INVALID_SIZE = "This field needs 9 digits";
    private const string ZIP_CODE_INVALID_SIZE = "This field need 5 digits";
    private const string PHONE_NUMBER_INVALID_SIZE = "This field needs 10 digits";

    private const string INVALID_FIELD_INPUT = "Required field";
    private const string INVALID_DATE = "Invalid AppointmentDate";
    private const string INVALID_COMBO_BOX_SELECTION = "Please select valid option";

    #endregion

    #region Events

    /// <summary>
    ///     Occurs when a property value changes.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    ///     Occurs when an error message needs to be displayed.
    /// </summary>
    public EventHandler<string> ErrorOccured;

    protected virtual void OnErrorOccured(string message)
    {
        this.ErrorOccured?.Invoke(this, message);
    }

    /// <summary>
    ///     Raises the <see cref="PropertyChanged" /> event for a property.
    /// </summary>
    /// <param name="propertyName">The name of the property that changed.</param>
    protected void OnPropertyChanged(string propertyName)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        this.ValidateFields();
    }

    #endregion

    #region FieldValidation

    private bool IsValidPhoneNumber(string phoneNumberParam)
    {
        return phoneNumberParam?.All(char.IsDigit) == true && phoneNumberParam.Length == 10;
    }

    private bool IsValidZipCode(string zipCodeParam)
    {
        return zipCodeParam?.All(char.IsDigit) == true && zipCodeParam.Length == 5;
    }

    private bool IsValidSSN(string ssnParam)
    {
        return ssnParam?.All(char.IsDigit) == true && ssnParam.Length == 9;
    }

    /// <summary>
    ///     Determines if the data enter by the user is valid
    /// </summary>
    public bool IsValid { get; private set; }

    /// <summary>
    ///     Gets the dictionary of validation error messages for form fields.
    /// </summary>
    public Dictionary<string, string> ValidationErrors { get; }

    /// <summary>
    ///     Validates the fields and updates the <see cref="ValidationErrors" /> dictionary with any validation errors.
    /// </summary>
    public void ValidateFields()
    {
        this.ValidationErrors.Clear();
        this.IsValid = true;

        if (string.IsNullOrWhiteSpace(this.FirstName))
        {
            this.ValidationErrors[nameof(this.FirstName)] = INVALID_FIELD_INPUT;
            this.IsValid = false;
        }

        if (string.IsNullOrWhiteSpace(this.LastName))
        {
            this.ValidationErrors[nameof(this.LastName)] = INVALID_FIELD_INPUT;
            this.IsValid = false;
        }

        if (string.IsNullOrWhiteSpace(this.Sex))
        {
            this.ValidationErrors[nameof(this.Sex)] = INVALID_COMBO_BOX_SELECTION;
            this.IsValid = false;
        }

        if (this.DateOfBirth >= DateTime.Now)
        {
            this.ValidationErrors[nameof(this.DateOfBirth)] = INVALID_DATE;
            this.IsValid = false;
        }

        if (!this.IsValidPhoneNumber(this.PhoneNumber))
        {
            this.ValidationErrors[nameof(this.PhoneNumber)] = PHONE_NUMBER_INVALID_SIZE;
            this.IsValid = false;
        }

        if (!this.IsValidSSN(this.Ssn))
        {
            this.ValidationErrors[nameof(this.Ssn)] = SSN_INVALID_SIZE;
            this.IsValid = false;
        }

        if (string.IsNullOrWhiteSpace(this.Address1))
        {
            this.ValidationErrors[nameof(this.Address1)] = INVALID_FIELD_INPUT;
            this.IsValid = false;
        }

        if (string.IsNullOrWhiteSpace(this.City))
        {
            this.ValidationErrors[nameof(this.City)] = INVALID_FIELD_INPUT;
            this.IsValid = false;
        }

        if (string.IsNullOrWhiteSpace(this.State))
        {
            this.ValidationErrors[nameof(this.State)] = INVALID_COMBO_BOX_SELECTION;
            this.IsValid = false;
        }

        if (!this.IsValidZipCode(this.ZipCode))
        {
            this.ValidationErrors[nameof(this.ZipCode)] = ZIP_CODE_INVALID_SIZE;
            this.IsValid = false;
        }
    }

    #endregion
}