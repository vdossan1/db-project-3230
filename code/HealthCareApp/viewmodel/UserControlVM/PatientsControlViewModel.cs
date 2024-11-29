using System.ComponentModel;
using HealthCareApp.DAL;
using HealthCareApp.model;
using static HealthCareApp.view.AdvancedSearchControl;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.viewmodel.UserControlVM;

public class PatientsControlViewModel : INotifyPropertyChanged
{
    #region Properties

    /// <summary>
    ///     Gets the list of patients.
    /// </summary>
    public List<Patient> Patients { get; private set; }

    private Patient? selectedPatient;

    public Patient? SelectedPatient
    {
        get => this.selectedPatient;
        set
        {
            if (this.selectedPatient != value)
            {
                this.selectedPatient = value;
                this.OnPropertyChanged(nameof(this.SelectedPatient));

                this.IsValid = this.selectedPatient != null;
                this.OnPropertyChanged(nameof(this.IsValid));
            }
        }
    }

    private bool isValid;

    public bool IsValid
    {
        get => this.isValid;
        private set
        {
            if (this.isValid != value)
            {
                this.isValid = value;
                this.OnPropertyChanged(nameof(this.IsValid));
            }
        }
    }

    /// <summary>
    ///     Raises the <see cref="PropertyChanged" /> event for a property.
    /// </summary>
    /// <param name="propertyName">The name of the property that changed.</param>
    protected void OnPropertyChanged(string propertyName)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="PatientsControlViewModel" /> class.
    /// </summary>
    public PatientsControlViewModel()
    {
        this.Patients = new List<Patient>();
        this.PopulatePatients();
        this.IsValid = false;
    }

    #endregion

    #region Methods

    /// <summary>
    ///     Occurs when a property value changes.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    ///     Populates the Patients list with either all patients or filtered patients based on the provided search criteria.
    /// </summary>
    /// <param name="eventArgs">
    ///     Optional. The <see cref="SearchEventArgs" /> containing the search criteria. If null, all
    ///     patients are retrieved.
    /// </param>
    public void PopulatePatients(SearchEventArgs? eventArgs = null)
    {
        if (eventArgs == null)
        {
            this.Patients = PatientDal.GetAllPatients();
        }
        else
        {
            var firstName = eventArgs.FirstName;
            var lastName = eventArgs.LastName;
            var dateOfBirth = eventArgs.DateOfBirth;

            this.Patients = PatientDal.GetAllPatientsWithParams(firstName, lastName, dateOfBirth);
        }
    }

    #endregion

    public void changePatientStatus(bool newPatientStatus)
    {
        this.SelectedPatient.Status = newPatientStatus;
        PatientDal.ChangeStatus(newPatientStatus, this.SelectedPatient.PatientId);
    }
}