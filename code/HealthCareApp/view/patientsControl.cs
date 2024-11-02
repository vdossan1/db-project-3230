﻿using HealthCareApp.model;
using HealthCareApp.viewmodel;
using static HealthCareApp.view.AdvancedSearchControl;

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

            this.advancedSearchControl1.SearchBtnClick += RefreshPatientList;
            this.advancedSearchControl1.ClearBtnClick += RefreshPatientList;
        }

		private void registerPatientBtn_Click(object sender, EventArgs e)
		{
			var addPatientPage = new AddPatientPage(null);
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
