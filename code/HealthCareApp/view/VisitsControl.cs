﻿using HealthCareApp.DAL;
using HealthCareApp.viewmodel;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.view
{
	/// <summary>
	/// Represents a user control for managing appointments, allowing users to create, edit, and search for appointments.
	/// </summary>
	public partial class VisitsControl : UserControl
    {
        private VisitsControlViewModel visitsControlViewModel;
        private int nurseId;

		/// <summary>
		/// Initializes a new instance of the <see cref="VisitsControl"/> class and sets up the data grid and event handlers.
		/// </summary>
		public VisitsControl(string nurseUsername)
        {
            InitializeComponent();

            this.nurseId = NurseDal.GetIdFromUsername(nurseUsername);
            this.visitsControlViewModel = new VisitsControlViewModel();

            this.visitsDataGridView.DataSource = visitsControlViewModel.Visits;

            this.createVisitBtn.DataBindings.Add(
                "Enabled", visitsControlViewModel, nameof(visitsControlViewModel.IsValid), true, DataSourceUpdateMode.OnPropertyChanged);

            this.createVisitLabel.DataBindings.Add(
                "Visible", visitsControlViewModel, nameof(visitsControlViewModel.ShowLabel), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void editVisitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not implemented yet", "TODO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void RefreshVisitsList(object? sender, FormClosedEventArgs e)
        {
            this.visitsControlViewModel.PopulateVisits();
            this.visitsDataGridView.DataSource = this.visitsControlViewModel.Visits;
            this.visitsDataGridView.ClearSelection();
        }

        private void createVisitBtn_Click(object sender, EventArgs e)
        {
            var createVisitPage = new VisitDetailsPage(this.nurseId);
            createVisitPage.FormClosed += RefreshVisitsList;
            createVisitPage.ShowDialog();
        }
    }
}

