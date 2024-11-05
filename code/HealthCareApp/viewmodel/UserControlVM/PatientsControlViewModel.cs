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

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="PatientsControlViewModel" /> class.
    /// </summary>
    public PatientsControlViewModel()
    {
        Patients = new List<Patient>();
        PopulatePatients();
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
    public void PopulatePatients(SearchEventArgs eventArgs = null)
    {
        if (eventArgs == null)
        {
            Patients = PatientDal.GetAllPatients();
        }
        else
        {
            var firstName = eventArgs.FirstName;
            var lastName = eventArgs.LastName;
            var dateOfBirth = eventArgs.DateOfBirth;

            Patients = PatientDal.GetAllPatientsWithParams(firstName, lastName, dateOfBirth);
        }
    }

    #endregion
}