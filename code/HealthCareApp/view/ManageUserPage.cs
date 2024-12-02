using HealthCareApp.model;
using HealthCareApp.utils;
using HealthCareApp.viewmodel;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.view;

/// <summary>
///     Represents the interface for adding a new user (nurse/admin) in the healthcare application.
/// </summary>
public partial class ManageUserPage : Form
{
    #region Data members

    private const string REGISTER_ACTION = "Register";
    private const string EDIT_ACTION = "Update";

    private readonly ManageUserViewModel manageUserViewModel;
    private PageAction pageAction;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="ManageUserPage" /> class.
    /// </summary>
    public ManageUserPage(User? selectedUser = null)
    {
        this.InitializeComponent();

        this.manageUserViewModel = selectedUser == null
            ? new ManageUserViewModel()
            : new ManageUserViewModel(selectedUser);
        this.manageUserViewModel.ErrorOccured += this.ErrorOccured;

        this.SetPageAction(selectedUser);

        this.BindControls();
        this.BindValidationMessages();

        this.dateOfBirthPicker.MinDate = DateTime.Parse("1924-01-01");
        this.dateOfBirthPicker.MaxDate = DateTime.Today;
    }

    #endregion

    #region Methods

    private void SetPageAction(User? selectedUser)
    {
        if (selectedUser != null)
        {
            this.manageUserViewModel.PopulateFields(selectedUser);
            Text = EDIT_ACTION + " User";
            this.actionButton.Text = EDIT_ACTION;
            this.pageAction = PageAction.EDIT;
        }
        else
        {
            Text = REGISTER_ACTION + " User";
            this.actionButton.Text = REGISTER_ACTION;
            this.pageAction = PageAction.REGISTER;
        }
    }

    private void OnActionButtonPressed()
    {
        MessageBox.Show($"{Text} Complete", "Confirmation", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    #endregion

    #region Events

    private void actionButton_Click(object? sender, EventArgs e)
    {
        this.manageUserViewModel.ValidateFields();

        if (this.manageUserViewModel.ManageUser())
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
        this.genderComboBox.DataSource = this.manageUserViewModel.SexArray;
        this.stateComboBox.DataSource = this.manageUserViewModel.StatesArray;

        // Data Bindings
        this.firstNameTextBox.DataBindings.Add(
            "Text", this.manageUserViewModel, nameof(this.manageUserViewModel.FirstName), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.lastNameTextBox.DataBindings.Add(
            "Text", this.manageUserViewModel, nameof(this.manageUserViewModel.LastName), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.dateOfBirthPicker.DataBindings.Add(
            "Value", this.manageUserViewModel, nameof(this.manageUserViewModel.DateOfBirth), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.genderComboBox.DataBindings.Add(
            "SelectedItem", this.manageUserViewModel, nameof(this.manageUserViewModel.Sex), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.addressOneTextBox.DataBindings.Add(
            "Text", this.manageUserViewModel, nameof(this.manageUserViewModel.Address1), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.addressTwoTextBox.DataBindings.Add(
            "Text", this.manageUserViewModel, nameof(this.manageUserViewModel.Address2), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.cityTextBox.DataBindings.Add(
            "Text", this.manageUserViewModel, nameof(this.manageUserViewModel.City), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.stateComboBox.DataBindings.Add(
            "SelectedItem", this.manageUserViewModel, nameof(this.manageUserViewModel.State), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.zipCodeTextBox.DataBindings.Add(
            "Text", this.manageUserViewModel, nameof(this.manageUserViewModel.ZipCode), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.phoneNumberTextBox.DataBindings.Add(
            "Text", this.manageUserViewModel, nameof(this.manageUserViewModel.PhoneNumber), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.ssnTextBox.DataBindings.Add(
            "Text", this.manageUserViewModel, nameof(this.manageUserViewModel.Ssn), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.actionButton.DataBindings.Add(
            "Enabled", this.manageUserViewModel, nameof(this.manageUserViewModel.IsValid), true,
            DataSourceUpdateMode.OnPropertyChanged);

        if (this.pageAction == PageAction.REGISTER)
        {
            this.genderComboBox.SelectedItem = null;
            this.stateComboBox.SelectedItem = null;
        }
    }

    private void BindValidationMessages()
    {
        this.firstNameErrorLabel.DataBindings.Add(
            "Text", this.manageUserViewModel, nameof(this.manageUserViewModel.FirstNameValidationMessage));

        this.lastNameErrorLabel.DataBindings.Add(
            "Text", this.manageUserViewModel, nameof(this.manageUserViewModel.LastNameValidationMessage));

        this.sexErrorLabel.DataBindings.Add(
            "Text", this.manageUserViewModel, nameof(this.manageUserViewModel.SexValidationMessage));

        this.dateOfBirthErrorLabel.DataBindings.Add(
            "Text", this.manageUserViewModel, nameof(this.manageUserViewModel.DateOfBirthValidationMessage));

        this.phoneNumberErrorLabel.DataBindings.Add(
            "Text", this.manageUserViewModel, nameof(this.manageUserViewModel.PhoneNumberValidationMessage));

        this.ssnErrorLabel.DataBindings.Add(
            "Text", this.manageUserViewModel, nameof(this.manageUserViewModel.SsnValidationMessage));

        this.addressOneErrorLabel.DataBindings.Add(
            "Text", this.manageUserViewModel, nameof(this.manageUserViewModel.Address1ValidationMessage));

        this.cityErrorLabel.DataBindings.Add(
            "Text", this.manageUserViewModel, nameof(this.manageUserViewModel.CityValidationMessage));

        this.stateErrorLabel.DataBindings.Add(
            "Text", this.manageUserViewModel, nameof(this.manageUserViewModel.StateValidationMessage));

        this.zipCodeErrorLabel.DataBindings.Add(
            "Text", this.manageUserViewModel, nameof(this.manageUserViewModel.ZipCodeValidationMessage));
    }

    #endregion
}