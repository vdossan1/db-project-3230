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
///     ViewModel for managing user (nurse/admin) information in the application.
///     Responsible for editing and registering patients,
///     and populating fields with patient data.
/// </summary>
public class ManageUserViewModel : INotifyPropertyChanged
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

    public User? SelectedUser { get; set; }

    public int UserId { get; set; }

    /// <summary>
    ///     Gets or sets the first name of the user.
    ///     Raises the <see cref="PropertyChanged" /> event when changed.
    /// </summary>
    /// 
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
    ///     Gets or sets the last name of the user.
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
    ///     Gets or sets the date of birth of the user.
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
    ///     Gets or sets the sex of the user.
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
    ///     Gets or sets the first line of the user's address.
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
    ///     Gets or sets the second line of the user's address.
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
    ///     Gets or sets the city of the user's address.
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
    ///     Gets or sets the state of the user's address.
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
	///     Gets or sets the ZIP code of the user's address.
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
	///     Gets or sets the user's phone number.
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
	///     Gets or sets the social security number of the user.
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
	///     Initializes a new instance of the <see cref="ManageUserViewModel" /> class.
	/// </summary>
	public ManageUserViewModel(User? selectedUser = null)
    {
        this.SelectedUser = selectedUser;
        this.ValidationErrors = new Dictionary<string, string>();
    }

    #endregion

    #region Methods

    /// <summary>
    ///     Handles the (Register or Edit user) management of user information in the application based on the specified action.
    /// </summary>
    public bool ManageUser()
    {
        bool result = false;
        try
        {
            result = this.ExecuteUserAction() != 0;
        }
        catch (MySqlException sqlException)
        {
            Debug.WriteLine(sqlException);
            this.OnErrorOccured($"{sqlException.Message}");
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            this.OnErrorOccured($"Error \n {e.Message}");
        }

        return result;
    }

    private int ExecuteUserAction()
    {
        var trimmedDateOfBirth = this.DateOfBirth.Value.Date;
        var newUser = new User(this.FirstName, this.LastName, trimmedDateOfBirth, this.Sex, this.Address1,
            this.Address2, this.City, this.State, this.ZipCode, this.PhoneNumber, this.Ssn);

        switch (this.SelectedUser == null)
        {
	        case true:

		        var username = NurseDal.GenerateUsername(this.FirstName, this.LastName);
		        newUser.Username = username;
				
		        var salt = CredentialHelper.GenerateSalt();
		        var password = CredentialHelper.HashPassword("pass", salt);

		        LoginCredentialDal.CreateLoginCredential(username, password, salt);
		        return NurseDal.RegisterNurse(newUser);
            
	        case false:

		        newUser.UserId = this.UserId;
		        return NurseDal.EditNurse(newUser);
        }
    }

	/// <summary>
	///     Populates the ViewModel's fields with the data from the specified user.
	/// </summary>
	/// <param name="user">The user object whose data will be used to populate the fields.</param>
	public void PopulateFields(User user)
    {
        this.UserId = user.UserId;
        this.FirstName = user.FirstName;
        this.LastName = user.LastName;
        this.DateOfBirth = user.DateOfBirth;
        this.Sex = user.Sex;
        this.Address1 = user.Address1;
        this.Address2 = user.Address2;
        this.City = user.City;
        this.State = user.State;
        this.ZipCode = user.ZipCode;
        this.PhoneNumber = user.PhoneNumber;
        this.Ssn = user.Ssn;
    }

    #endregion

    #region Constants

    private const string SSN_INVALID_SIZE = "This field needs 9 digits";
    private const string ZIP_CODE_INVALID_SIZE = "This field need 5 digits";
    private const string PHONE_NUMBER_INVALID_SIZE = "This field needs 10 digits";

    private const string INVALID_FIELD_INPUT = "Required field";
    private const string INVALID_DATE = "Invalid Date";
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