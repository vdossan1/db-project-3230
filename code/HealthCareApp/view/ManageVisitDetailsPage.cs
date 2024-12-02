using HealthCareApp.DAL;
using HealthCareApp.model;
using HealthCareApp.utils;
using HealthCareApp.viewmodel;
using MySql.Data.MySqlClient;
using System.ComponentModel;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.view;

/// <summary>
///     Represents the interface for adding a new visit in the healthcare application.
/// </summary>
public partial class ManageVisitDetailsPage : Form
{
    #region Data members

    private readonly ManageVisitDetailsPageViewModel manageVisitDetailsPageViewModel;

    private const string EDIT_VISIT = "Edit";

    private PageAction pageAction;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="ManageVisitDetailsPage" /> class and sets up the data grid and event
    ///     handlers.
    /// </summary>
    public ManageVisitDetailsPage(int? appointmentId = null)
    {
        this.InitializeComponent();

        var selectedVisit = appointmentId == null ? null : VisitDal.GetVisitByApptId(appointmentId.Value);
        this.manageVisitDetailsPageViewModel = new ManageVisitDetailsPageViewModel(selectedVisit, appointmentId.Value);

        this.pageAction = selectedVisit == null ? PageAction.REGISTER : PageAction.EDIT;
        this.SetEditPageAttributes();

        this.BindControls();
        this.BindValidationMessages();

        this.availableTestListBox.DataSource = this.manageVisitDetailsPageViewModel.LabTests;
        this.selectedTestListBox.DataSource = this.manageVisitDetailsPageViewModel.SelectedTests;

        this.appointmentIdText.Text = appointmentId.ToString();
        this.nurseIdTextLabel.Text = LoggedUser.FullName;

        this.disableAllControlsIfVisitClosed();
    }

    private void disableAllControlsIfVisitClosed()
    {
        if (this.manageVisitDetailsPageViewModel.IsVisitClosed)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = false;
            }

            this.cancelButton.Enabled = true;
            this.saveButton.Enabled = false;
        }
    }

    #endregion

    #region Controls

    private void saveButton_Click(object sender, EventArgs e)
    {
        this.manageVisitDetailsPageViewModel.ValidateFields();

        string messageText;
        string messageCaption;
        MessageBoxIcon messageIcon;

        try
        {
            this.manageVisitDetailsPageViewModel.SaveVisitDetails();
            this.manageVisitDetailsPageViewModel.CreateLabTestResults();

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
        this.Dispose();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Hide();
        Dispose();
    }

    private void addTestBtn_Click(object sender, EventArgs e)
    {
        var testsToRemove = new List<string>();

        foreach (var selectedItem in this.availableTestListBox.SelectedItems)
        {
            this.manageVisitDetailsPageViewModel.SelectedTests.Add((string)selectedItem);
            this.manageVisitDetailsPageViewModel.AddNewTest((string)selectedItem);
            testsToRemove.Add((string)selectedItem);
        }

        testsToRemove.ForEach(item => this.manageVisitDetailsPageViewModel.LabTests.Remove(item));

        this.manageVisitDetailsPageViewModel.AllowFinalDiag = false;

        this.availableTestListBox.ClearSelected();
        this.selectedTestListBox.ClearSelected();
    }

    private void removeTestBtn_Click(object sender, EventArgs e)
    {
        var testsToRemove = new List<string>();

        foreach (var selectedItem in this.selectedTestListBox.SelectedItems)
        {
            this.manageVisitDetailsPageViewModel.LabTests.Add((string)selectedItem);
            testsToRemove.Add((string)selectedItem);
        }

        testsToRemove.ForEach(item =>
        {
            this.manageVisitDetailsPageViewModel.SelectedTests.Remove(item);
            this.manageVisitDetailsPageViewModel.RemoveNewTest(item);
        });

        this.availableTestListBox.ClearSelected();
        this.selectedTestListBox.ClearSelected();

        SortBindingList(this.manageVisitDetailsPageViewModel.LabTests);

        this.manageVisitDetailsPageViewModel.disableFinalDiagIfTestSelected();

        this.availableTestListBox.ClearSelected();
        this.selectedTestListBox.ClearSelected();
    }

    #endregion

    #region Methods

    private void SetEditPageAttributes()
    {
        if (this.pageAction == PageAction.EDIT)
        {
            this.manageVisitDetailsPageViewModel.PopulateFields();
            Text = EDIT_VISIT + " Visit Info";
            this.saveButton.Text = EDIT_VISIT;

            this.patientFnameLnameLabel.Text = this.manageVisitDetailsPageViewModel.PatientFullName;
            this.drFnameLnameLabel.Text = this.manageVisitDetailsPageViewModel.DoctorFullName;
        }
    }

    private void SortBindingList(BindingList<string> bindingList)
    {
        // Copy the items into a List<string>
        var sortedList = new List<string>(bindingList);

        // Sort the List<string> alphabetically
        sortedList.Sort();

        // Clear and repopulate the BindingList
        bindingList.Clear();
        foreach (var item in sortedList)
        {
            bindingList.Add(item);
        }
    }

    #endregion

    #region Bindings

    private void BindControls()
    {
        this.patientFnameLnameLabel.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel,
            nameof(this.manageVisitDetailsPageViewModel.PatientFullName), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.drFnameLnameLabel.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel,
            nameof(this.manageVisitDetailsPageViewModel.DoctorFullName), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.bloodPressureSysTxtField.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel,
            nameof(this.manageVisitDetailsPageViewModel.BloodPressureSystolic), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.bloodPressureDiasTxtField.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel,
            nameof(this.manageVisitDetailsPageViewModel.BloodPressureDiastolic), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.weightTxtField.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel, nameof(this.manageVisitDetailsPageViewModel.Weight), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.heightTxtField.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel, nameof(this.manageVisitDetailsPageViewModel.Height), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.pulseTxtField.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel, nameof(this.manageVisitDetailsPageViewModel.PulseRate), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.bodyTempTxtField.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel, nameof(this.manageVisitDetailsPageViewModel.BodyTemp), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.symptomsTxtBox.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel, nameof(this.manageVisitDetailsPageViewModel.Symptoms), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.initDiagnosesTxtBox.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel, nameof(this.manageVisitDetailsPageViewModel.InitialDiagnoses),
            true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.finalDiagnosesTxtBox.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel, nameof(this.manageVisitDetailsPageViewModel.FinalDiagnoses),
            true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.finalDiagnosesTxtBox.DataBindings.Add(
            "Enabled", this.manageVisitDetailsPageViewModel, nameof(this.manageVisitDetailsPageViewModel.AllowFinalDiag),
            true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.saveButton.DataBindings.Add(
            "Enabled", this.manageVisitDetailsPageViewModel, nameof(this.manageVisitDetailsPageViewModel.AllowSave), true,
            DataSourceUpdateMode.OnPropertyChanged);
    }

    private void BindValidationMessages()
    {
        this.bloodPressSysErrorLabel.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel,
            nameof(this.manageVisitDetailsPageViewModel.BloodPressureSysValidationMessage));

        this.bloodPressDiasErrorLabel.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel,
            nameof(this.manageVisitDetailsPageViewModel.BloodPressureDiasValidationMessage));

        this.weightErrorLabel.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel,
            nameof(this.manageVisitDetailsPageViewModel.WeightValidationMessage));

        this.heightErrorLabel.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel,
            nameof(this.manageVisitDetailsPageViewModel.HeightValidationMessage));

        this.pulseErrorLabel.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel,
            nameof(this.manageVisitDetailsPageViewModel.PulseValidationMessage));

        this.bodyTempErrorLabel.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel,
            nameof(this.manageVisitDetailsPageViewModel.BodyTempValidationMessage));

        this.symptomsErrorLabel.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel,
            nameof(this.manageVisitDetailsPageViewModel.SymptomsValidationMessage));

        this.initialDiagErrorLabel.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel,
            nameof(this.manageVisitDetailsPageViewModel.InitialDiagValidationMessage));
    }

    #endregion
}