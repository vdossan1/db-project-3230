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
			this.appointmentsDataGridView.DataSource = appointmentsControlViewModel.Appointments;

			this.apptAdvancedSearchControl.SearchBtnClick += RefreshAppointmentsList;
			this.apptAdvancedSearchControl.ClearBtnClick += RefreshAppointmentsList;
		}

		private void createAppointmentBtn_Click(object sender, EventArgs e)
		{
			var createAppointmentPage = new CreateAppointmentPage(null);
			addPatientPage.FormClosed += RefreshPatientList;
			addPatientPage.ShowDialog();
		}

		private void editPatientBtn_Click(object sender, EventArgs e)
		{
			if (this.patientsDataGridView.SelectedRows.Count > 0)
			{
				var selectedPatient = (Patient)this.patientsDataGridView.SelectedRows[0].DataBoundItem;
				var addPatientPage = new AddPatientPage(selectedPatient);
				addPatientPage.FormClosed += RefreshPatientList;
				addPatientPage.ShowDialog();
			}
		}

		private void RefreshPatientList(object sender, EventArgs e)
		{
			if (e is SearchEventArgs searchArgs)
			{
				this.patientsControlViewModel.PopulatePatients(searchArgs);
			}
			else
			{
				this.patientsControlViewModel.PopulatePatients();
			}
			this.patientsDataGridView.DataSource = patientsControlViewModel.Patients;
			this.patientsDataGridView.ClearSelection();
		}
	}
}
