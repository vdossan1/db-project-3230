using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCareApp.viewmodel;
using static System.Net.Mime.MediaTypeNames;

namespace HealthCareApp.view
{
    public partial class VisitDetailsPage : Form
    {
        private VisitDetailsPageViewModel visitDetailsPageViewModel;
        public VisitDetailsPage(int nurseId)
        {
            InitializeComponent();
            this.visitDetailsPageViewModel = new VisitDetailsPageViewModel();

            this.nurseIdTextLabel.Text = nurseId.ToString();
            this.visitDetailsPageViewModel.NurseId = nurseId;

            BindControls();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.visitDetailsPageViewModel.SaveVisitDetails();
            MessageBox.Show($"Visit Details Saved Successfully", "Visit Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            this.Dispose(true);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void BindControls()
        {
            this.apptIdCmbBox.DataSource = this.visitDetailsPageViewModel.ApptIdsArray;

            this.apptIdCmbBox.DataBindings.Add(
                "SelectedItem", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.AppointmentId), true, DataSourceUpdateMode.OnPropertyChanged);

            this.bloodPressureSysTxtField.DataBindings.Add(
                "Text", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.BloodPressureSystolic), true, DataSourceUpdateMode.OnPropertyChanged);

            this.bloodPressureDiasTxtField.DataBindings.Add(
                "Text", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.BloodPressureDiastolic), true, DataSourceUpdateMode.OnPropertyChanged);

            this.weightTxtField.DataBindings.Add(
                "Text", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.Weight), true, DataSourceUpdateMode.OnPropertyChanged);

            this.heightTxtField.DataBindings.Add(
                "Text", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.Height), true, DataSourceUpdateMode.OnPropertyChanged);

            this.pulseTxtField.DataBindings.Add(
                "Text", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.PulseRate), true, DataSourceUpdateMode.OnPropertyChanged);

            this.bodyTempTxtField.DataBindings.Add(
                "Text", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.BodyTemp), true, DataSourceUpdateMode.OnPropertyChanged);

            this.symptomsTxtBox.DataBindings.Add(
                "Text", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.Symptoms), true, DataSourceUpdateMode.OnPropertyChanged);

            this.initDiagnosesTxtBox.DataBindings.Add(
                "Text", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.InitialDiagnoses), true, DataSourceUpdateMode.OnPropertyChanged);

            this.finalDiagnosesTxtBox.DataBindings.Add(
                "Text", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.FinalDiagnoses), true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
