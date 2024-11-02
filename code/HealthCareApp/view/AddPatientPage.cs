using HealthCareApp.model;
using HealthCareApp.utils;
using HealthCareApp.viewmodel;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.view
{
	/// <summary>
	/// Represents the interface for adding a new patient in the healthcare application.
	/// </summary>
	public partial class AddPatientPage : Form
    {
		private ManagePatientViewModel managePatientViewModel;
		private PatientAction patientAction;

		private const string REGISTER_ACTION = "Register";
		private const string EDIT_ACTION = "Update";

		/// <summary>
		/// Initializes a new instance of the <see cref="AddPatientPage"/> class.
		/// </summary>
		public AddPatientPage(Patient? selectedPatient)
        {
            InitializeComponent();
            this.managePatientViewModel = new ManagePatientViewModel();
            this.managePatientViewModel.ErrorOccured += ErrorOccured;
			this.SetPageAction(selectedPatient);

			this.BindControls();
            this.BindValidationMessages();

            this.dateOfBirthPicker.MinDate = DateTime.Parse("1924-01-01");
            this.dateOfBirthPicker.MaxDate = DateTime.Today;
        }

		#region Methods

		private void SetPageAction(Patient? selectedPatient)
		{
			if (selectedPatient != null)
			{
				this.managePatientViewModel.PopulateFields(selectedPatient);
				this.Text = EDIT_ACTION + " Patient";
				this.actionButton.Text = EDIT_ACTION;
				this.patientAction = PatientAction.EDIT;
			}
			else
			{
				this.Text = REGISTER_ACTION + " Patient";
				this.actionButton.Text = REGISTER_ACTION;
				this.patientAction = PatientAction.REGISTER;
			}
		}

		private void OnActionButtonPressed()
		{
			var text = this.GetActionString();
			MessageBox.Show($"Patient {text} Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
				OnActionButtonPressed();
				this.Hide();
				this.Dispose();
			}
		}

		private void cancelBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			this.Dispose();
		}

		private void ErrorOccured(object? sender, string e)
		{
			MessageBox.Show(e, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		#endregion

		#region Bindings

		private void BindControls()
		{
			this.genderComboBox.DataSource = managePatientViewModel.SexArray;
			this.stateComboBox.DataSource = managePatientViewModel.StatesArray;

			// Data Bindings
			this.firstNameTextBox.DataBindings.Add(
				"Text", managePatientViewModel, nameof(managePatientViewModel.FirstName), true, DataSourceUpdateMode.OnPropertyChanged);

			this.lastNameTextBox.DataBindings.Add(
				"Text", managePatientViewModel, nameof(managePatientViewModel.LastName), true, DataSourceUpdateMode.OnPropertyChanged);

			this.dateOfBirthPicker.DataBindings.Add(
				"Value", managePatientViewModel, nameof(managePatientViewModel.DateOfBirth), true, DataSourceUpdateMode.OnPropertyChanged);

			this.genderComboBox.DataBindings.Add(
				"SelectedItem", managePatientViewModel, nameof(managePatientViewModel.Sex), true, DataSourceUpdateMode.OnPropertyChanged);

			this.addressOneTextBox.DataBindings.Add(
				"Text", managePatientViewModel, nameof(managePatientViewModel.Address1), true, DataSourceUpdateMode.OnPropertyChanged);

			this.addressTwoTextBox.DataBindings.Add(
				"Text", managePatientViewModel, nameof(managePatientViewModel.Address2), true, DataSourceUpdateMode.OnPropertyChanged);

			this.cityTextBox.DataBindings.Add(
				"Text", managePatientViewModel, nameof(managePatientViewModel.City), true, DataSourceUpdateMode.OnPropertyChanged);

			this.stateComboBox.DataBindings.Add(
				"SelectedItem", managePatientViewModel, nameof(managePatientViewModel.State), true, DataSourceUpdateMode.OnPropertyChanged);

			this.zipCodeTextBox.DataBindings.Add(
				"Text", managePatientViewModel, nameof(managePatientViewModel.ZipCode), true, DataSourceUpdateMode.OnPropertyChanged);

			this.phoneNumberTextBox.DataBindings.Add(
				"Text", managePatientViewModel, nameof(managePatientViewModel.PhoneNumber), true, DataSourceUpdateMode.OnPropertyChanged);

			this.ssnTextBox.DataBindings.Add(
				"Text", managePatientViewModel, nameof(managePatientViewModel.Ssn), true, DataSourceUpdateMode.OnPropertyChanged);

			this.actionButton.DataBindings.Add(
				"Enabled", managePatientViewModel, nameof(managePatientViewModel.IsValid), true, DataSourceUpdateMode.OnPropertyChanged);

            if (this.patientAction == PatientAction.REGISTER)
            {
                this.genderComboBox.SelectedItem = null;
                this.stateComboBox.SelectedItem = null;
            }
        }

		private void BindValidationMessages()
		{
			this.firstNameErrorLabel.DataBindings.Add(
				"Text", managePatientViewModel, nameof(managePatientViewModel.FirstNameValidationMessage));

			this.lastNameErrorLabel.DataBindings.Add(
				"Text", managePatientViewModel, nameof(managePatientViewModel.LastNameValidationMessage));

			this.sexErrorLabel.DataBindings.Add(
				"Text", managePatientViewModel, nameof(managePatientViewModel.SexValidationMessage));

			this.dateOfBirthErrorLabel.DataBindings.Add(
				"Text", managePatientViewModel, nameof(managePatientViewModel.DateOfBirthValidationMessage));

			this.phoneNumberErrorLabel.DataBindings.Add(
				"Text", managePatientViewModel, nameof(managePatientViewModel.PhoneNumberValidationMessage));

			this.ssnErrorLabel.DataBindings.Add(
				"Text", managePatientViewModel, nameof(managePatientViewModel.SsnValidationMessage));

			this.addressOneErrorLabel.DataBindings.Add(
				"Text", managePatientViewModel, nameof(managePatientViewModel.Address1ValidationMessage));

			this.cityErrorLabel.DataBindings.Add(
				"Text", managePatientViewModel, nameof(managePatientViewModel.CityValidationMessage));

			this.stateErrorLabel.DataBindings.Add(
				"Text", managePatientViewModel, nameof(managePatientViewModel.StateValidationMessage));

			this.zipCodeErrorLabel.DataBindings.Add(
				"Text", managePatientViewModel, nameof(managePatientViewModel.ZipCodeValidationMessage));
		}

		#endregion
	}
}
