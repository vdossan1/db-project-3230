using System.ComponentModel;
using HealthCareApp.DAL;
using HealthCareApp.model;
using static HealthCareApp.view.AdvancedSearchControl;

namespace HealthCareApp.viewmodel.UserControlVM;

public class VisitsControlViewModel : INotifyPropertyChanged
{
    #region Properties

    /// <summary>
    ///     Gets the list of visits.
    /// </summary>
    public List<Visit> Visits { get; private set; }

    /// <summary>
    ///     Gets a value indicating whether there are any appointments with no associated visit.
    /// </summary>
    public bool IsValid => this.GetCountOfAppointmentsWithNoVisit() > 0;

    /// <summary>
    ///     Gets a value indicating whether the label should be shown based on validation status.
    /// </summary>
    public bool ShowLabel => !this.IsValid;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="VisitsControlViewModel" /> class.
    /// </summary>
    public VisitsControlViewModel()
    {
        this.Visits = new List<Visit>();
        this.PopulateVisits();
        ManageAppointmentViewModel.AddAppointment += this.OnAppointmentAdded;
    }

    #endregion

    #region Methods

    /// <summary>
    ///     Occurs when a property value changes.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    ///     Handles the event triggered when a new appointment is added to refresh the count of appointments with no visit.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event arguments.</param>
    private void OnAppointmentAdded(object? sender, EventArgs e)
    {
        this.GetCountOfAppointmentsWithNoVisit();
    }

    /// <summary>
    ///     Populates the Visits list with all visits from the database.
    /// </summary>
    public void PopulateVisits(SearchEventArgs? eventArgs = null)
    {
        if (eventArgs == null)
        {
            this.Visits = VisitDal.GetAllVisits();
        }
        else
        {
            var firstName = eventArgs.FirstName;
            var lastName = eventArgs.LastName;
            var dateOfBirth = eventArgs.DateOfBirth;

            this.Visits = VisitDal.GetAllVisitsWithParams(firstName, lastName, dateOfBirth);
        }
    }

    /// <summary>
    ///     Retrieves the count of appointments that do not have an associated visit and updates related properties.
    /// </summary>
    /// <returns>The count of appointments without an associated visit.</returns>
    public int GetCountOfAppointmentsWithNoVisit()
    {
        var count = AppointmentDal.GetAllAppointmentsIdsWithNoVisits().Count;
        this.OnPropertyChanged(nameof(this.IsValid));
        this.OnPropertyChanged(nameof(this.ShowLabel));

        return count;
    }

    /// <summary>
    ///     Raises the <see cref="PropertyChanged" /> event for a property.
    /// </summary>
    /// <param name="propertyName">The name of the property that changed.</param>
    protected virtual void OnPropertyChanged(string propertyName)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}