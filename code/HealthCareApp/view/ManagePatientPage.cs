using HealthCareApp.model;
using HealthCareApp.utils;
using HealthCareApp.viewmodel;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.view;

/// <summary>
///     Represents the interface for adding a new patient in the healthcare application.
/// </summary>
public partial class ManagePatientPage : Form
{
    #region Data members

    private const string REGISTER_ACTION = "Register";
    private const string EDIT_ACTION = "Update";

    private readonly ManagePatientViewModel managePatientViewModel;
    private PatientAction patientAction;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="ManagePatientPage" /> class.
    /// </summary>
    public ManagePatientPage(Patient? selectedPatient)
    {
        this.InitializeComponent();
        this.managePatientViewModel = new ManagePatientViewModel();
        this.managePatientViewModel.ErrorOccured += this.ErrorOccured;
        this.SetPageAction(selectedPatient);

        this.BindControls();
        this.BindValidationMessages();

        this.dateOfBirthPicker.MinDate = DateTime.Parse("1924-01-01");
        this.dateOfBirthPicker.MaxDate = DateTime.Today;
    }

    #endregion

    #region Methods

    private void SetPageAction(Patient? selectedPatient)
    {
        if (selectedPatient != null)
        {
            this.managePatientViewModel.PopulateFields(selectedPatient);
            Text = EDIT_ACTION + " Patient";
            this.actionButton.Text = EDIT_ACTION;
            this.patientAction = PatientAction.EDIT;
        }
        else
        {
            Text = REGISTER_ACTION + " Patient";
            this.actionButton.Text = REGISTER_ACTION;
            this.patientAction = PatientAction.REGISTER;
        }
    }

    private void OnActionButtonPressed()
    {
        var text = this.GetActionString();
        MessageBox.Show($"Patient {text} Successfully", "Confirmation", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private string GetActionString()
    {
        var actionString = "";
        switch (this.patientAction)
        {
            case PatientAction.REGISTER:
                actionString = REGISTER_ACTION + "ed";
                break;
            case PatientAction.EDIT:
                actionString = EDIT_ACTION + "d";
                break;
        }

        return actionString;
    }

    #endregion

    #region Events

    private void actionButton_Click(object? sender, EventArgs e)
    {
        this.managePatientViewModel.ValidateFields();

        if (this.managePatientViewModel.ManagePatient(this.patientAction))
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

    #endregion

    #region Bindings

    private void BindControls()
    {
        this.genderComboBox.DataSource = this.managePatientViewModel.SexArray;
        this.stateComboBox.DataSource = this.managePatientViewModel.StatesArray;

        // Data Bindings
        this.firstNameTextBox.DataBindings.Add(
            "Text", this.managePatientViewModel, nameof(this.managePatientViewModel.FirstName), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.lastNameTextBox.DataBindings.Add(
            "Text", this.managePatientViewModel, nameof(this.managePatientViewModel.LastName), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.dateOfBirthPicker.DataBindings.Add(
            "Value", this.managePatientViewModel, nameof(this.managePatientViewModel.DateOfBirth), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.genderComboBox.DataBindings.Add(
            "SelectedItem", this.managePatientViewModel, nameof(this.managePatientViewModel.Sex), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.addressOneTextBox.DataBindings.Add(
            "Text", this.managePatientViewModel, nameof(this.managePatientViewModel.Address1), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.addressTwoTextBox.DataBindings.Add(
            "Text", this.managePatientViewModel, nameof(this.managePatientViewModel.Address2), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.cityTextBox.DataBindings.Add(
            "Text", this.managePatientViewModel, nameof(this.managePatientViewModel.City), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.stateComboBox.DataBindings.Add(
            "SelectedItem", this.managePatientViewModel, nameof(this.managePatientViewModel.State), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.zipCodeTextBox.DataBindings.Add(
            "Text", this.managePatientViewModel, nameof(this.managePatientViewModel.ZipCode), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.phoneNumberTextBox.DataBindings.Add(
            "Text", this.managePatientViewModel, nameof(this.managePatientViewModel.PhoneNumber), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.ssnTextBox.DataBindings.Add(
            "Text", this.managePatientViewModel, nameof(this.managePatientViewModel.Ssn), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.actionButton.DataBindings.Add(
            "Enabled", this.managePatientViewModel, nameof(this.managePatientViewModel.IsValid), true,
            DataSourceUpdateMode.OnPropertyChanged);

        if (this.patientAction == PatientAction.REGISTER)
        {
            this.genderComboBox.SelectedItem = null;
            this.stateComboBox.SelectedItem = null;
        }
    }

    private void BindValidationMessages()
    {
        this.firstNameErrorLabel.DataBindings.Add(
            "Text", this.managePatientViewModel, nameof(this.managePatientViewModel.FirstNameValidationMessage));

        this.lastNameErrorLabel.DataBindings.Add(
            "Text", this.managePatientViewModel, nameof(this.managePatientViewModel.LastNameValidationMessage));

        this.sexErrorLabel.DataBindings.Add(
            "Text", this.managePatientViewModel, nameof(this.managePatientViewModel.SexValidationMessage));

        this.dateOfBirthErrorLabel.DataBindings.Add(
            "Text", this.managePatientViewModel, nameof(this.managePatientViewModel.DateOfBirthValidationMessage));

        this.phoneNumberErrorLabel.DataBindings.Add(
            "Text", this.managePatientViewModel, nameof(this.managePatientViewModel.PhoneNumberValidationMessage));

        this.ssnErrorLabel.DataBindings.Add(
            "Text", this.managePatientViewModel, nameof(this.managePatientViewModel.SsnValidationMessage));

        this.addressOneErrorLabel.DataBindings.Add(
            "Text", this.managePatientViewModel, nameof(this.managePatientViewModel.Address1ValidationMessage));

        this.cityErrorLabel.DataBindings.Add(
            "Text", this.managePatientViewModel, nameof(this.managePatientViewModel.CityValidationMessage));

        this.stateErrorLabel.DataBindings.Add(
            "Text", this.managePatientViewModel, nameof(this.managePatientViewModel.StateValidationMessage));

        this.zipCodeErrorLabel.DataBindings.Add(
            "Text", this.managePatientViewModel, nameof(this.managePatientViewModel.ZipCodeValidationMessage));
    }

    #endregion
}