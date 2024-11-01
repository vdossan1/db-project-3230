using HealthCareApp.model;
using HealthCareApp.viewmodel;

namespace HealthCareApp.view
{
	public partial class PatientsControl : UserControl
	{
		private PatientsControlViewModel patientsControlViewModel;

		public PatientsControl()
		{
			InitializeComponent();

			this.patientsControlViewModel = new PatientsControlViewModel();
			this.patientsControlViewModel.PopulatePatients();
			this.patientsDataGridView.DataSource = patientsControlViewModel.Patients;
		}

		private void registerPatientBtn_Click(object sender, EventArgs e)
		{
			var addPatientPage = new AddPatientPage();
			addPatientPage.FormClosed += RefreshPatientList;
			addPatientPage.ShowDialog();
		}

		private void editPatientBtn_Click(object sender, EventArgs e)
		{
			if (this.patientsDataGridView.SelectedRows.Count > 0)
			{
				var editPatientPage = new EditPatientPage();
				editPatientPage.PatientToEdit = this.patientsDataGridView.SelectedRows[0].D;
				editPatientPage.FormClosed += RefreshPatientList;
				editPatientPage.ShowDialog();
			}
		}

		private void RefreshPatientList(object sender, EventArgs e)
		{
			this.patientsControlViewModel.PopulatePatients();
			this.patientsDataGridView.DataSource = patientsControlViewModel.Patients;
		}
	}
}
