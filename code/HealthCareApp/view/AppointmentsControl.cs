using HealthCareApp.DAL;
using HealthCareApp.model;
using HealthCareApp.viewmodel;
using static HealthCareApp.view.AdvancedSearchControl;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.view
{
    public partial class AppointmentsControl : UserControl
    {
		private AppointmentsControlViewModel appointmentsControlViewModel;

		public AppointmentsControl()
        {
            InitializeComponent();

            this.appointmentsControlViewModel = new AppointmentsControlViewModel();
            this.SetUpDataGrid();
            
			this.apptAdvancedSearchControl.SearchBtnClick += RefreshAppointmentsList;
			this.apptAdvancedSearchControl.ClearBtnClick += RefreshAppointmentsList;
		}

		private void createAppointmentBtn_Click(object sender, EventArgs e)
		{
			var createAppointmentPage = new ManageAppointmentPage(null);
			createAppointmentPage.FormClosed += RefreshAppointmentsList;
			createAppointmentPage.ShowDialog();
		}

		private void editAppointmentBtn_Click(object sender, EventArgs e)
		{
			if (this.appointmentsDataGridView.SelectedRows.Count > 0)
			{
				var selectedAppointment = (Appointment)this.appointmentsDataGridView.SelectedRows[0].DataBoundItem;
				var editAppointmentPage = new ManageAppointmentPage(selectedAppointment);
				editAppointmentPage.FormClosed += RefreshAppointmentsList;
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
			this.appointmentsDataGridView.DataSource = appointmentsControlViewModel.Appointments;
			this.appointmentsDataGridView.ClearSelection();
		}

		private void SetUpDataGrid()
		{
			this.appointmentsDataGridView.DataSource = appointmentsControlViewModel.Appointments;
			this.appointmentsDataGridView.Columns["AppointmentId"].Visible = false;
			this.appointmentsDataGridView.Columns["PatientId"].Visible = false;
			this.appointmentsDataGridView.Columns["DoctorId"].Visible = false;
			this.appointmentsDataGridView.Columns["AppointmentDate"].Width = 150;
			this.appointmentsDataGridView.Columns["Reason"].Width = 150;
		}
	}
}
