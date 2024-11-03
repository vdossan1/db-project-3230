using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using HealthCareApp.DAL;
using HealthCareApp.viewmodel;

namespace HealthCareApp.view
{
    public partial class VisitsControl : UserControl
    {
        private VisitsControlViewModel visitsControlViewModel;
        private int nurseId;

        public VisitsControl(string nurseUsername)
        {
            InitializeComponent();

            this.nurseId = NurseDal.GetIdFromUsername(nurseUsername);
            this.visitsControlViewModel = new VisitsControlViewModel();

            this.visitsDataGridView.DataSource = visitsControlViewModel.Visits;
        }

        private void editVisitBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void RefreshVisitsList(object? sender, FormClosedEventArgs e)
        {
            this.visitsControlViewModel.PopulateVisits();
        }

        private void createVisitBtn_Click(object sender, EventArgs e)
        {
            var createVisitPage = new VisitDetailsPage(this.nurseId);
            createVisitPage.FormClosed += RefreshVisitsList;
            createVisitPage.ShowDialog();
        }
    }
}

