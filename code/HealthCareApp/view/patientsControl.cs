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
			this.patientsDataGridView.DataSource = patientsControlViewModel.Patients;
		}

		private void registerPatientBtn_Click(object sender, EventArgs e)
		{
			var addPatientPage = new AddPatientPage();
			addPatientPage.ShowDialog();
		}

		private void editPatientBtn_Click(object sender, EventArgs e)
		{
			if (this.patientsDataGridView.SelectedRows.Count > 0)
			{
				var editPatientPage = new EditPatientPage();
				editPatientPage.ShowDialog();
			}
		}
	}
}
