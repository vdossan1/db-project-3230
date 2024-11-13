using System.ComponentModel;
using System.Diagnostics;
using HealthCareApp.DAL;
using HealthCareApp.model;
using HealthCareApp.utils;
using MySql.Data.MySqlClient;
using static HealthCareApp.view.AdvancedSearchControl;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.viewmodel;

/// <summary>
///     ViewModel for managing appointment information in the application.
///     Responsible for editing and creating appointments,
///     and populating fields with appointment data.
/// </summary>
public class ManageAppointmentViewModel : INotifyPropertyChanged
{
    #region Data members

    private Patient patient;

    private Doctor doctor;

    private string reason;

    private DateTime date;

    #endregion

    #region Properties

    public Appointment? SelectedAppointment { get; set; }

    public List<Patient> Patients { get; set; }
    public List<Doctor> Doctors { get; set; }

    /// <summary>
    ///     Gets or sets the Patient for the appointment.
    ///     Raises the <see cref="PropertyChanged" /> event when changed.
    /// </summary>
    public Patient Patient
    {
        get => this.patient;
        set
        {
            if (this.patient != value)
            {
                this.patient = value;
                this.OnPropertyChanged(nameof(this.Patient));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the Doctor for the appointment.
    ///     Raises the <see cref="PropertyChanged" /> event when changed.
    /// </summary>
    public Doctor Doctor
    {
        get => this.doctor;
        set
        {
            if (this.doctor != value)
            {
                this.doctor = value;
                this.OnPropertyChanged(nameof(this.Doctor));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the reason for the appointment.
    ///     Raises the <see cref="PropertyChanged" /> event when changed.
    /// </summary>
    public string Reason
    {
        get => this.reason;
        set
        {
            if (this.reason != value)
            {
                this.reason = value;
                this.OnPropertyChanged(nameof(this.Reason));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the date of the appointment.
    ///     Raises the <see cref="PropertyChanged" /> event when changed.
    /// </summary>
    public DateTime Date
    {
        get => this.date;
        set
        {
            if (this.date != value)
            {
                this.date = value;
                this.OnPropertyChanged(nameof(this.Date));
            }
        }
    }

    /// <summary>
    ///     Gets the validation message for the Patient field.
    /// </summary>
    public string PatientValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.Patient))
        ? this.ValidationErrors[nameof(this.Patient)]
        : string.Empty;

    /// <summary>
    ///     Gets the validation message for the Doctor field.
    /// </summary>
    public string DoctorValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.Doctor))
        ? this.ValidationErrors[nameof(this.Doctor)]
        : string.Empty;

    /// <summary>
    ///     Gets the validation message for the Reason field.
    /// </summary>
    public string ReasonValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.Reason))
        ? this.ValidationErrors[nameof(this.Reason)]
        : string.Empty;

    /// <summary>
    ///     Gets the validation message for the Date field.
    /// </summary>
    public string DateValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.Date))
        ? this.ValidationErrors[nameof(this.Date)]
        : string.Empty;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="ManageAppointmentViewModel" /> class.
    /// </summary>
    public ManageAppointmentViewModel(Appointment? selectedAppointment = null)
    {
        this.SelectedAppointment = selectedAppointment;
		this.ValidationErrors = new Dictionary<string, string>();
        this.Patients = new List<Patient>();
        this.Doctors = new List<Doctor>();
        this.PopulateDataGrids();
    }

    #endregion

    #region Methods

    /// <summary>
    ///     Handles the management of appointment information in the application based on the specified action.
    /// </summary>
    /// <param name="action">The AppointmentAction which determines the action to be taken by this method.</param>
    public bool ManageAppointment(AppointmentAction action)
    {
        var result = false;
        try
        {
            if (this.IsValid)
            {
                this.ExecuteAppointmentAction(action);
                result = true;
                Debug.WriteLine(
                    $"Appointment Created: {this.Patient.FirstName} {this.Doctor.FirstName} {this.Reason} {this.Date.ToString()}");
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
    ///     Populates the ViewModel's fields with the data from the specified appointment.
    /// </summary>
    /// <param name="appointment">The appointment object whose data will be used to populate the fields.</param>
    public void PopulateFields(Appointment appointment)
    {
        this.Patient = this.Patients.Find(p => p.PatientId == appointment.PatientId);
        this.Doctor = this.Doctors.Find(d => d.DoctorId == appointment.DoctorId);
        this.Reason = appointment.Reason;
        this.Date = appointment.AppointmentDate;
    }

    /// <summary>
    ///     Populates the data grids with a list of patients and doctors, optionally filtered by search criteria.
    /// </summary>
    /// <param name="eventArgs">
    ///     Optional. The <see cref="SearchEventArgs" /> containing the search criteria. If null, all
    ///     patients and doctors are retrieved.
    /// </param>
    public void PopulateDataGrids(SearchEventArgs? eventArgs = null)
    {
        if (eventArgs == null)
        {
            this.Patients = PatientDal.GetAllPatients();
            this.Doctors = DoctorDal.GetAllDoctors();
        }
        else
        {
            var firstName = eventArgs.FirstName;
            var lastName = eventArgs.LastName;
            var dateOfBirth = eventArgs.DateOfBirth;

            this.Patients = PatientDal.GetAllPatientsWithParams(firstName, lastName, dateOfBirth);
            this.Doctors = DoctorDal.GetAllDoctorsWithParams(firstName, lastName, dateOfBirth);
        }
    }

    private void ExecuteAppointmentAction(AppointmentAction action)
    {
	    var trimmedDate = new DateTime(this.Date.Year, this.Date.Month, this.Date.Day, this.Date.Hour, this.Date.Minute, 0, 0, 0);
		var newAppointment = new Appointment(this.Patient.PatientId, this.Doctor.DoctorId, trimmedDate, this.Reason);

        switch (action)
        {
            case AppointmentAction.CREATE:
                AppointmentDal.CreateAppointment(newAppointment);
                this.OnAddAppointment();
                break;
            case AppointmentAction.EDIT:
                newAppointment.AppointmentId = this.SelectedAppointment.AppointmentId;
                AppointmentDal.EditAppointment(newAppointment);
                break;
        }
    }

    #endregion

    #region Constants

    private const string INVALID_FIELD_INPUT = "Required field";
    private const string INVALID_DATE = "Invalid Appointment Date";
    private const string INVALID_PATIENT_SELECTION = "Please select a Patient";
    private const string INVALID_DOCTOR_SELECTION = "Please select a Doctor";

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

    /// <summary>
    ///     Occurs when a new appointment is added.
    /// </summary>
    public static event EventHandler AddAppointment;

    private void OnAddAppointment()
    {
        AddAppointment?.Invoke(this, EventArgs.Empty);
    }

    #endregion

    #region FieldValidation

    /// <summary>
    ///     Determines if the data entered by the user is valid
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

        if (this.Patient == null)
        {
            this.ValidationErrors[nameof(this.Patient)] = INVALID_PATIENT_SELECTION;
            this.IsValid = false;
        }

        if (this.Doctor == null)
        {
            this.ValidationErrors[nameof(this.Doctor)] = INVALID_DOCTOR_SELECTION;
            this.IsValid = false;
        }

        if (string.IsNullOrWhiteSpace(this.Reason))
        {
            this.ValidationErrors[nameof(this.Reason)] = INVALID_FIELD_INPUT;
            this.IsValid = false;
        }

        if (this.Date <= DateTime.Now)
        {
            this.ValidationErrors[nameof(this.Date)] = INVALID_DATE;
            this.IsValid = false;
        }
    }

    #endregion
}