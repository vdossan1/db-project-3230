using System.ComponentModel;
using HealthCareApp.DAL;
using HealthCareApp.model;
using static HealthCareApp.view.AdvancedSearchControl;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.viewmodel.UserControlVM;

public class AppointmentsControlViewModel
{
    #region Properties

    /// <summary>
    ///     Gets the list of appointments.
    /// </summary>
    public List<Appointment> Appointments { get; private set; }

    private Appointment? selectedAppointment;

    public Appointment? SelectedAppointment
    {
        get => this.selectedAppointment;
        set
        {
            if (this.selectedAppointment != value)
            {
                this.selectedAppointment = value;
                this.OnPropertyChanged(nameof(this.SelectedAppointment));

                this.IsValid = this.selectedAppointment != null;
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
    ///     Initializes a new instance of the <see cref="AppointmentsControlViewModel" /> class.
    /// </summary>
    public AppointmentsControlViewModel()
    {
        this.Appointments = new List<Appointment>();
        this.PopulateAppointments();
        this.IsValid = false;
    }

    #endregion

    #region Methods

    /// <summary>
    ///     Occurs when a property value changes.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    ///     Populates the Appointments list with either all appointments or filtered appointments based on the provided search
    ///     criteria.
    /// </summary>
    /// <param name="eventArgs">
    ///     Optional. The <see cref="SearchEventArgs" /> containing the search criteria. If null, all
    ///     appointments are retrieved.
    /// </param>
    public void PopulateAppointments(SearchEventArgs? eventArgs = null)
    {
        if (eventArgs == null)
        {
            Appointments = AppointmentDal.GetAllAppointments();
        }
        else
        {
            var firstName = eventArgs.FirstName;
            var lastName = eventArgs.LastName;
            var dateOfBirth = eventArgs.DateOfBirth;

            Appointments = AppointmentDal.GetAllAppointmentsWithParams(firstName, lastName, dateOfBirth);
        }
    }

    #endregion
}