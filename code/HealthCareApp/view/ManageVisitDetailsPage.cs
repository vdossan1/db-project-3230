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

    private const string CREATE_VISIT = "Create";
    private const string EDIT_VISIT = "Edit";

    private PageAction pageAction;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="ManageVisitDetailsPage" /> class and sets up the data grid and event
    ///     handlers.
    /// </summary>
    public ManageVisitDetailsPage(string nurseFullName, string username, Visit? selectedVisit = null)
    {
        this.InitializeComponent();
        this.manageVisitDetailsPageViewModel = selectedVisit == null
            ? new ManageVisitDetailsPageViewModel()
            : new ManageVisitDetailsPageViewModel(selectedVisit);

        this.nurseIdTextLabel.Text = nurseFullName;
        this.manageVisitDetailsPageViewModel.NurseId = NurseDal.GetIdFromUsername(username);

        this.pageAction = selectedVisit == null ? PageAction.REGISTER : PageAction.EDIT;
        this.SetEditPageAttributes();

        this.BindControls();
        this.BindValidationMessages();

        this.availableTestListBox.DataSource = this.manageVisitDetailsPageViewModel.LabTests;
        this.selectedTestListBox.DataSource = this.manageVisitDetailsPageViewModel.SelectedTests;

        this.apptIdCmbBox.SelectedIndexChanged += this.apptIdCmbBox_SelectedIndexChanged;
    }

    private void SetEditPageAttributes()
    {
        if (this.pageAction == PageAction.EDIT)
        {
            this.manageVisitDetailsPageViewModel.PopulateFields();
            Text = EDIT_VISIT + " Visit Info";
            this.saveButton.Text = EDIT_VISIT;
            this.apptIdCmbBox.Enabled = false;

            this.patientFnameLnameLabel.Text = this.manageVisitDetailsPageViewModel.PatientFullName;
            this.drFnameLnameLabel.Text = this.manageVisitDetailsPageViewModel.DoctorFullName;
        }
    }

    #endregion

    #region Methods

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
        this.Dispose(true);
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
            testsToRemove.Add((string)selectedItem);
        }

        testsToRemove.ForEach(item => this.manageVisitDetailsPageViewModel.LabTests.Remove(item));

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

        testsToRemove.ForEach(item => this.manageVisitDetailsPageViewModel.SelectedTests.Remove(item));

        this.availableTestListBox.ClearSelected();
        this.selectedTestListBox.ClearSelected();

        SortBindingList(this.manageVisitDetailsPageViewModel.LabTests);

        this.availableTestListBox.ClearSelected();
        this.selectedTestListBox.ClearSelected();
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
        this.apptIdCmbBox.DataSource = this.manageVisitDetailsPageViewModel.ApptIdsArray;
        this.apptIdCmbBox.SelectedItem = null;

        this.apptIdCmbBox.DataBindings.Add(
            "SelectedItem", this.manageVisitDetailsPageViewModel,
            nameof(this.manageVisitDetailsPageViewModel.AppointmentId), true,
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

        this.saveButton.DataBindings.Add(
            "Enabled", this.manageVisitDetailsPageViewModel, nameof(this.manageVisitDetailsPageViewModel.IsValid), true,
            DataSourceUpdateMode.OnPropertyChanged);

        /*this.patientFnameLnameLabel.DataBindings.Add("Text", this.manageVisitDetailsPageViewModel,
            nameof(this.manageVisitDetailsPageViewModel.PatientFullName));

        this.patientFnameLnameLabel.DataBindings.Add("Text", this.manageVisitDetailsPageViewModel,
            nameof(this.manageVisitDetailsPageViewModel.DoctorFullName));*/
    }

    private void BindValidationMessages()
    {
        this.apptIdErrorLabel.DataBindings.Add(
            "Text", this.manageVisitDetailsPageViewModel,
            nameof(this.manageVisitDetailsPageViewModel.AppointmentIdValidationMessage));

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

    private void apptIdCmbBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Update the ViewModel's AppointmentId property when combo box selection changes
        if (this.apptIdCmbBox.SelectedItem is int selectedAppointmentId)
        {
            this.manageVisitDetailsPageViewModel.AppointmentId = selectedAppointmentId;
            this.patientFnameLnameLabel.Text = this.manageVisitDetailsPageViewModel.PatientFullName;
            this.drFnameLnameLabel.Text = this.manageVisitDetailsPageViewModel.DoctorFullName;
        }
    }
}