using HealthCareApp.model;
using HealthCareApp.viewmodel;
using static HealthCareApp.view.AdvancedSearchControl;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
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

            this.patientAdvancedSearchControl.SearchBtnClick += RefreshPatientList;
            this.patientAdvancedSearchControl.ClearBtnClick += RefreshPatientList;
        }

		private void registerPatientBtn_Click(object sender, EventArgs e)
		{
			var addPatientPage = new ManagePatientPage(null);
			addPatientPage.FormClosed += RefreshPatientList;
			addPatientPage.ShowDialog();
		}

		private void editPatientBtn_Click(object sender, EventArgs e)
		{
			if (this.patientsDataGridView.SelectedRows.Count > 0)
			{
				var selectedPatient = (Patient)this.patientsDataGridView.SelectedRows[0].DataBoundItem;
				var editPatientPage = new ManagePatientPage(selectedPatient);
				editPatientPage.FormClosed += RefreshPatientList;
				editPatientPage.ShowDialog();
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
