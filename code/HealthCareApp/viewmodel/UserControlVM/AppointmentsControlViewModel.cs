using System.ComponentModel;
using System.Diagnostics;
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
    public BindingList<Appointment> Appointments { get; private set; }

    public BindingList<Appointment> ClosedAppointments { get; private set; }

    public BindingList<string> SelectedTests { get; private set; }

    private Visit? selectedVisit;

    public Visit? SelectedVisit {
        get => this.selectedVisit;
        set
        {
            if (this.selectedVisit != value)
            {
                this.selectedVisit = value;
                this.OnPropertyChanged(nameof(this.SelectedVisit));
            }
        }
    }

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

                this.tryToGetVisit();
            }
        }
    }

    private void tryToGetVisit()
    {
        if (this.SelectedAppointment != null)
        {
            this.SelectedVisit = new Visit(VisitDal.GetVisitByApptId(this.SelectedAppointment.AppointmentId));
        }
    }

    public void PopulateVisitFields()
    {
        if (this.SelectedVisit.VisitId == 0)
        {
            this.BloodPressureSystolic = 0;
            this.BloodPressureDiastolic = 0;
            this.Weight = 0;
            this.Height = 0;
            this.PulseRate = 0;
            this.BodyTemp = 0;
            this.Symptoms = "";
            this.InitialDiagnoses = "";
            this.FinalDiagnoses = "";
            this.SelectedTests = new BindingList<string>();
        }
        else if (this.SelectedVisit.VisitId > 0)
        {
            this.BloodPressureSystolic = this.SelectedVisit.BloodPressureSystolic;
            this.BloodPressureDiastolic = this.SelectedVisit.BloodPressureDiastolic;
            this.Weight = this.SelectedVisit.Weight;
            this.Height = this.SelectedVisit.Height;
            this.PulseRate = this.SelectedVisit.PulseRate;
            this.BodyTemp = this.SelectedVisit.BodyTemp;
            this.Symptoms = this.SelectedVisit.Symptoms;
            this.InitialDiagnoses = this.SelectedVisit.InitialDiagnoses;
            this.FinalDiagnoses = this.SelectedVisit.FinalDiagnoses;
            this.populateSelectedTests();
        }
    }

    private void populateSelectedTests()
    {
        var labTestsForVisit = LabTestDal.GetAllLabTestsForVisit(this.SelectedVisit.VisitId);
        this.SelectedTests = new BindingList<string>(labTestsForVisit);
    }

    private bool isValid;
    private int bloodPressureSystolic;
    private int bloodPressureDiastolic;
    private decimal bodyTemp;
    private decimal weight;
    private string finalDiagnoses;
    private string initialDiagnoses;
    private string symptoms;
    private int pulseRate;
    private decimal height;

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

    #region VisitProperties

    /// <summary>
    ///     Gets or sets the systolic blood pressure for the visit.
    /// </summary>
    public int BloodPressureSystolic
    {
        get => this.bloodPressureSystolic;
        set
        {
            if (this.bloodPressureSystolic != value)
            {
                this.bloodPressureSystolic = value;
                this.OnPropertyChanged(nameof(this.BloodPressureSystolic));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the diastolic blood pressure for the visit.
    /// </summary>
    public int BloodPressureDiastolic
    {
        get => this.bloodPressureDiastolic;
        set
        {
            if (this.bloodPressureDiastolic != value)
            {
                this.bloodPressureDiastolic = value;
                this.OnPropertyChanged(nameof(this.BloodPressureDiastolic));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the body temperature for the visit.
    /// </summary>
    public decimal BodyTemp
    {
        get => this.bodyTemp;
        set
        {
            if (this.bodyTemp != value)
            {
                this.bodyTemp = value;
                this.OnPropertyChanged(nameof(this.BodyTemp));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the weight for the visit.
    /// </summary>
    public decimal Weight
    {
        get => this.weight;
        set
        {
            if (this.weight != value)
            {
                this.weight = value;
                this.OnPropertyChanged(nameof(this.Weight));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the height for the visit.
    /// </summary>
    public decimal Height
    {
        get => this.height;
        set
        {
            if (this.height != value)
            {
                this.height = value;
                this.OnPropertyChanged(nameof(this.Height));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the pulse rate for the visit.
    /// </summary>
    public int PulseRate
    {
        get => this.pulseRate;
        set
        {
            if (this.pulseRate != value)
            {
                this.pulseRate = value;
                this.OnPropertyChanged(nameof(this.PulseRate));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the symptoms for the visit.
    /// </summary>
    public string Symptoms
    {
        get => this.symptoms;
        set
        {
            if (this.symptoms != value)
            {
                this.symptoms = value;
                this.OnPropertyChanged(nameof(this.Symptoms));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the initial diagnosis for the visit.
    /// </summary>
    public string InitialDiagnoses
    {
        get => this.initialDiagnoses;
        set
        {
            if (this.initialDiagnoses != value)
            {
                this.initialDiagnoses = value;
                this.OnPropertyChanged(nameof(this.InitialDiagnoses));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the final diagnosis for the visit.
    /// </summary>
    public string FinalDiagnoses
    {
        get => this.finalDiagnoses;
        set
        {
            if (this.finalDiagnoses != value)
            {
                this.finalDiagnoses = value;
                this.OnPropertyChanged(nameof(this.FinalDiagnoses));
            }
        }
    }

    #endregion

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="AppointmentsControlViewModel" /> class.
    /// </summary>
    public AppointmentsControlViewModel()
    {
        this.Appointments = new BindingList<Appointment>();
        this.ClosedAppointments = new BindingList<Appointment>();
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
            this.Appointments = AppointmentDal.GetAllOpenAppointments();
            this.ClosedAppointments = AppointmentDal.GetAllPastAndClosedAppointments();
        }
        else
        {
            var firstName = eventArgs.FirstName;
            var lastName = eventArgs.LastName;
            var dateOfBirth = eventArgs.DateOfBirth;

            this.Appointments = AppointmentDal.GetAllAppointmentsWithParams(firstName, lastName, dateOfBirth);
            this.ClosedAppointments = AppointmentDal.GetAllClosedAppointmentsWithParams(firstName, lastName, dateOfBirth);
        }
    }

    #endregion
}