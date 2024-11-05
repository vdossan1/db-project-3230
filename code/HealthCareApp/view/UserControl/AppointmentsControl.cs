using HealthCareApp.model;
using HealthCareApp.viewmodel.UserControlVM;
using static HealthCareApp.view.AdvancedSearchControl;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.view;

/// <summary>
///     Represents a user control for managing appointments, allowing users to create, edit, and search for appointments.
/// </summary>
public partial class AppointmentsControl : UserControl
{
    #region Data members

    private readonly AppointmentsControlViewModel appointmentsControlViewModel;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="AppointmentsControl" /> class and sets up the data grid and event
    ///     handlers.
    /// </summary>
    public AppointmentsControl()
    {
        this.InitializeComponent();

        this.appointmentsControlViewModel = new AppointmentsControlViewModel();
        this.SetUpDataGrid();

        this.apptAdvancedSearchControl.SearchBtnClick += this.RefreshAppointmentsList;
        this.apptAdvancedSearchControl.ClearBtnClick += this.RefreshAppointmentsList;
    }

    #endregion

    #region Methods

    private void createAppointmentBtn_Click(object sender, EventArgs e)
    {
        var createAppointmentPage = new ManageAppointmentPage(null);
        createAppointmentPage.FormClosed += this.RefreshAppointmentsList;
        createAppointmentPage.ShowDialog();
    }

    private void editAppointmentBtn_Click(object sender, EventArgs e)
    {
        var selectedAppointment = (Appointment)this.appointmentsDataGridView.SelectedRows[0].DataBoundItem;

        if (this.appointmentsDataGridView.SelectedRows.Count > 0 &&
            selectedAppointment.AppointmentDate > DateTime.Today)
        {
            var editAppointmentPage = new ManageAppointmentPage(selectedAppointment);
            editAppointmentPage.FormClosed += this.RefreshAppointmentsList;
            editAppointmentPage.ShowDialog();
        }
    }

    private void RefreshAppointmentsList(object sender, EventArgs e)
    {
        if (e is SearchEventArgs searchArgs)
        {
            this.appointmentsControlViewModel.PopulateAppointments(searchArgs);
        }
        else
        {
            this.appointmentsControlViewModel.PopulateAppointments();
        }

        this.appointmentsDataGridView.DataSource = this.appointmentsControlViewModel.Appointments;
        this.appointmentsDataGridView.ClearSelection();
    }

    private void SetUpDataGrid()
    {
        this.appointmentsDataGridView.DataSource = this.appointmentsControlViewModel.Appointments;
        this.appointmentsDataGridView.Columns["AppointmentId"].Visible = false;
        this.appointmentsDataGridView.Columns["PatientId"].Visible = false;
        this.appointmentsDataGridView.Columns["DoctorId"].Visible = false;
        this.appointmentsDataGridView.Columns["AppointmentDate"].Width = 150;
        this.appointmentsDataGridView.Columns["Reason"].Width = 150;
    }

    #endregion
}