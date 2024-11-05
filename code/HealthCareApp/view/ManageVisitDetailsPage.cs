using HealthCareApp.viewmodel;
using MySql.Data.MySqlClient;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.view;

/// <summary>
///     Represents the interface for adding a new visit in the healthcare application.
/// </summary>
public partial class ManageVisitDetailsPage : Form
{
    #region Data members

    private readonly VisitDetailsPageViewModel visitDetailsPageViewModel;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="ManageVisitDetailsPage" /> class and sets up the data grid and event
    ///     handlers.
    /// </summary>
    public ManageVisitDetailsPage(int nurseId)
    {
        this.InitializeComponent();
        this.visitDetailsPageViewModel = new VisitDetailsPageViewModel();

        this.nurseIdTextLabel.Text = nurseId.ToString();
        this.visitDetailsPageViewModel.NurseId = nurseId;

        this.BindControls();
        this.BindValidationMessages();
    }

    #endregion

    #region Methods

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
        Hide();
        this.Dispose(true);
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Hide();
        Dispose();
    }

    #endregion

    #region Bindings

    private void BindControls()
    {
        this.apptIdCmbBox.DataSource = this.visitDetailsPageViewModel.ApptIdsArray;

        this.apptIdCmbBox.DataBindings.Add(
            "SelectedItem", this.visitDetailsPageViewModel, nameof(this.visitDetailsPageViewModel.AppointmentId), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.bloodPressureSysTxtField.DataBindings.Add(
            "Text", this.visitDetailsPageViewModel, nameof(this.visitDetailsPageViewModel.BloodPressureSystolic), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.bloodPressureDiasTxtField.DataBindings.Add(
            "Text", this.visitDetailsPageViewModel, nameof(this.visitDetailsPageViewModel.BloodPressureDiastolic), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.weightTxtField.DataBindings.Add(
            "Text", this.visitDetailsPageViewModel, nameof(this.visitDetailsPageViewModel.Weight), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.heightTxtField.DataBindings.Add(
            "Text", this.visitDetailsPageViewModel, nameof(this.visitDetailsPageViewModel.Height), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.pulseTxtField.DataBindings.Add(
            "Text", this.visitDetailsPageViewModel, nameof(this.visitDetailsPageViewModel.PulseRate), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.bodyTempTxtField.DataBindings.Add(
            "Text", this.visitDetailsPageViewModel, nameof(this.visitDetailsPageViewModel.BodyTemp), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.symptomsTxtBox.DataBindings.Add(
            "Text", this.visitDetailsPageViewModel, nameof(this.visitDetailsPageViewModel.Symptoms), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.initDiagnosesTxtBox.DataBindings.Add(
            "Text", this.visitDetailsPageViewModel, nameof(this.visitDetailsPageViewModel.InitialDiagnoses), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.finalDiagnosesTxtBox.DataBindings.Add(
            "Text", this.visitDetailsPageViewModel, nameof(this.visitDetailsPageViewModel.FinalDiagnoses), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.saveButton.DataBindings.Add(
            "Enabled", this.visitDetailsPageViewModel, nameof(this.visitDetailsPageViewModel.IsValid), true,
            DataSourceUpdateMode.OnPropertyChanged);
    }

    private void BindValidationMessages()
    {
        this.apptIdErrorLabel.DataBindings.Add(
            "Text", this.visitDetailsPageViewModel,
            nameof(this.visitDetailsPageViewModel.AppointmentIdValidationMessage));

        this.bloodPressSysErrorLabel.DataBindings.Add(
            "Text", this.visitDetailsPageViewModel,
            nameof(this.visitDetailsPageViewModel.BloodPressureSysValidationMessage));

        this.bloodPressDiasErrorLabel.DataBindings.Add(
            "Text", this.visitDetailsPageViewModel,
            nameof(this.visitDetailsPageViewModel.BloodPressureDiasValidationMessage));

        this.weightErrorLabel.DataBindings.Add(
            "Text", this.visitDetailsPageViewModel, nameof(this.visitDetailsPageViewModel.WeightValidationMessage));

        this.heightErrorLabel.DataBindings.Add(
            "Text", this.visitDetailsPageViewModel, nameof(this.visitDetailsPageViewModel.HeightValidationMessage));

        this.pulseErrorLabel.DataBindings.Add(
            "Text", this.visitDetailsPageViewModel, nameof(this.visitDetailsPageViewModel.PulseValidationMessage));

        this.bodyTempErrorLabel.DataBindings.Add(
            "Text", this.visitDetailsPageViewModel, nameof(this.visitDetailsPageViewModel.BodyTempValidationMessage));

        this.symptomsErrorLabel.DataBindings.Add(
            "Text", this.visitDetailsPageViewModel, nameof(this.visitDetailsPageViewModel.SymptomsValidationMessage));

        this.initialDiagErrorLabel.DataBindings.Add(
            "Text", this.visitDetailsPageViewModel,
            nameof(this.visitDetailsPageViewModel.InitialDiagValidationMessage));
    }

    #endregion
}