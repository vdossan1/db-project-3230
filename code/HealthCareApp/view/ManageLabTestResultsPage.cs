using HealthCareApp.model;
using HealthCareApp.viewmodel;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.view
{
    /// <summary>
    ///     Represents the interface for entering in information for a test result in the healthcare application.
    /// </summary>
    public partial class ManageLabTestResultsPage : Form
    {
        #region Constructors

        private readonly ManageLabTestResultViewModel manageLabTestResultViewModel;

        public ManageLabTestResultsPage(LabTestResult? selectedLabTestResult = null)
        {
            this.InitializeComponent();

            this.manageLabTestResultViewModel = selectedLabTestResult == null ? new ManageLabTestResultViewModel() : new ManageLabTestResultViewModel(selectedLabTestResult);
            this.manageLabTestResultViewModel.ErrorOccured += this.ErrorOccured;

            this.manageLabTestResultViewModel.PopulateFields();

            this.BindControls();
            this.BindValidationMessages();

            this.datePicker.MinDate = DateTime.Parse("1924-01-01");
            this.datePicker.MaxDate = DateTime.Today;
        }

        #endregion

        #region Events

        private void actionButton_Click(object? sender, EventArgs e)
        {
            this.manageLabTestResultViewModel.ValidateFields();

            if (this.manageLabTestResultViewModel.ManageLabTestResult())
            {
                this.OnActionButtonPressed();
                Hide();
                Dispose();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Dispose();
        }

        private void ErrorOccured(object? sender, string e)
        {
            MessageBox.Show(e, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnActionButtonPressed()
        {
            MessageBox.Show($"{Text} Complete", "Confirmation", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        #endregion

        #region Bindings

        private void BindControls()
        {
            this.normalityComboBox.DataSource = this.manageLabTestResultViewModel.NormalityArray;
            this.normalityComboBox.SelectedItem = null;

            this.testCodeLabel.Text = this.manageLabTestResultViewModel.SelectedLabTest.TestCode.ToString();
            this.testNameLabel.Text = this.manageLabTestResultViewModel.SelectedLabTest.TestName;
            this.highValueLabel.Text = this.manageLabTestResultViewModel.SelectedLabTest.HighValue.ToString();
            this.lowValueLabel.Text = this.manageLabTestResultViewModel.SelectedLabTest.LowValue.ToString();
            this.unitLabel.Text = this.manageLabTestResultViewModel.SelectedLabTest.Unit;

            // Data Bindings
            this.resultTextBox.DataBindings.Add(
                "Text", this.manageLabTestResultViewModel, nameof(this.manageLabTestResultViewModel.TestResult), true,
                DataSourceUpdateMode.OnPropertyChanged);

            this.normalityComboBox.DataBindings.Add(
                "SelectedItem", this.manageLabTestResultViewModel,
                nameof(this.manageLabTestResultViewModel.ResultNormality), true,
                DataSourceUpdateMode.OnPropertyChanged);

            this.datePicker.DataBindings.Add(
                "Value", this.manageLabTestResultViewModel, nameof(this.manageLabTestResultViewModel.DatePerformed),
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            this.statusCheckBox.DataBindings.Add(
                "Checked", this.manageLabTestResultViewModel, nameof(this.manageLabTestResultViewModel.Status), true,
                DataSourceUpdateMode.OnPropertyChanged);

            this.actionButton.DataBindings.Add(
                "Enabled", this.manageLabTestResultViewModel, nameof(this.manageLabTestResultViewModel.IsValid), true,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BindValidationMessages()
        {
            this.reasonErrorLabel.DataBindings.Add(
                "Text", this.manageLabTestResultViewModel,
                nameof(this.manageLabTestResultViewModel.TestResultValidationMessage));

            this.normalityErrorLabel.DataBindings.Add(
                "Text", this.manageLabTestResultViewModel,
                nameof(this.manageLabTestResultViewModel.ResultNormalityValidationMessage));

            this.dateErrorLabel.DataBindings.Add(
                "Text", this.manageLabTestResultViewModel,
                nameof(this.manageLabTestResultViewModel.DatePerformedValidationMessage));
        }

        #endregion
    }
}