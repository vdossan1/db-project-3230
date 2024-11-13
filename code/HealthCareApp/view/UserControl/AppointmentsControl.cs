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

    private AppointmentsControlViewModel appointmentsControlViewModel;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="AppointmentsControl" /> class and sets up the data grid and event
    ///     handlers.
    /// </summary>
    public AppointmentsControl()
    {
        this.InitializeComponent();
        this.SetUpPage();
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
        if (this.appointmentsDataGridView.SelectedRows.Count > 0)
        {
	        var selectedAppointment = (Appointment)this.appointmentsDataGridView.SelectedRows[0].DataBoundItem;
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

    private void AppointmentsDataGridView_SelectionChanged(object? sender, EventArgs e)
    {
		if (this.appointmentsDataGridView.SelectedRows.Count > 0)
	    {
		    if (this.appointmentsDataGridView.SelectedRows[0].DataBoundItem is Appointment selectedAppointment && selectedAppointment.AppointmentDate > DateTime.Today)
			{
				this.appointmentsControlViewModel.SelectedAppointment = selectedAppointment;
				this.editAppointmentBtn.Enabled = true;
			}
			else
			{
				this.appointmentsControlViewModel.SelectedAppointment = null;
				this.editAppointmentBtn.Enabled = false;
			}
		}
	    else
	    {
			this.appointmentsControlViewModel.SelectedAppointment = null;
            this.editAppointmentBtn.Enabled = false;
		}
    }

	private void SetUpPage()
    {
		// Set up the data grid view
		this.appointmentsControlViewModel = new AppointmentsControlViewModel();
		this.appointmentsDataGridView.DataSource = this.appointmentsControlViewModel.Appointments;
        this.appointmentsDataGridView.Columns["AppointmentId"].Visible = false;
        this.appointmentsDataGridView.Columns["PatientId"].Visible = false;
        this.appointmentsDataGridView.Columns["DoctorId"].Visible = false;
        this.appointmentsDataGridView.ClearSelection();

		// Bindings and events
		this.appointmentsDataGridView.SelectionChanged += this.AppointmentsDataGridView_SelectionChanged;
		this.apptAdvancedSearchControl.SearchBtnClick += this.RefreshAppointmentsList;
		this.apptAdvancedSearchControl.ClearBtnClick += this.RefreshAppointmentsList;
	}

	#endregion
}