using HealthCareApp.viewmodel;
using MySql.Data.MySqlClient;

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
            BindValidationMessages();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.visitDetailsPageViewModel.ValidateFields();

            string messageText;
            string messageCaption;
            MessageBoxIcon messageIcon;

            try
            {
                this.visitDetailsPageViewModel.SaveVisitDetails();

                messageText = "Visit Details Saved Successfully";
                messageCaption = "Visit Confirmation";
                messageIcon = MessageBoxIcon.Information;
            }
            catch (MySqlException sqlError)
            {
                messageText = sqlError.Message;
                messageCaption = "Database error";
                messageIcon = MessageBoxIcon.Error;
            }

            MessageBox.Show(messageText, messageCaption, MessageBoxButtons.OK, messageIcon);
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

            this.saveButton.DataBindings.Add(
                "Enabled", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.IsValid), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BindValidationMessages()
        {
            this.apptIdErrorLabel.DataBindings.Add(
                "Text", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.AppointmentIdValidationMessage));

            this.bloodPressSysErrorLabel.DataBindings.Add(
                "Text", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.BloodPressureSysValidationMessage));

            this.bloodPressDiasErrorLabel.DataBindings.Add(
                "Text", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.BloodPressureDiasValidationMessage));

            this.weightErrorLabel.DataBindings.Add(
                "Text", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.WeightValidationMessage));

            this.heightErrorLabel.DataBindings.Add(
                "Text", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.HeightValidationMessage));

            this.pulseErrorLabel.DataBindings.Add(
                "Text", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.PulseValidationMessage));

            this.bodyTempErrorLabel.DataBindings.Add(
                "Text", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.BodyTempValidationMessage));

            this.symptomsErrorLabel.DataBindings.Add(
                "Text", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.SymptomsValidationMessage));

            this.initialDiagErrorLabel.DataBindings.Add(
                "Text", visitDetailsPageViewModel, nameof(visitDetailsPageViewModel.InitialDiagValidationMessage));
        }
    }
}
