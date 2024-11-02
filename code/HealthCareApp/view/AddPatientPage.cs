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
		private AddPatientPageViewModel addPatientViewModel;
		private PatientAction patientAction;

		private const string REGISTER_ACTION = "Register";
		private const string EDIT_ACTION = "Update";

		/// <summary>
		/// Initializes a new instance of the <see cref="AddPatientPage"/> class.
		/// </summary>
		public AddPatientPage(Patient? selectedPatient)
        {
            InitializeComponent();
            this.addPatientViewModel = new AddPatientPageViewModel();
            this.addPatientViewModel.ErrorOccured += ErrorOccured;
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
				this.addPatientViewModel.PopulateFields(selectedPatient);
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
			this.addPatientViewModel.ValidateFields();

			if (this.addPatientViewModel.ManagePatient(this.patientAction))
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
			this.genderComboBox.DataSource = addPatientViewModel.SexArray;
			this.stateComboBox.DataSource = addPatientViewModel.StatesArray;

			// Data Bindings
			this.firstNameTextBox.DataBindings.Add(
				"Text", addPatientViewModel, nameof(addPatientViewModel.FirstName), true, DataSourceUpdateMode.OnPropertyChanged);

			this.lastNameTextBox.DataBindings.Add(
				"Text", addPatientViewModel, nameof(addPatientViewModel.LastName), true, DataSourceUpdateMode.OnPropertyChanged);

			this.dateOfBirthPicker.DataBindings.Add(
				"Value", addPatientViewModel, nameof(addPatientViewModel.DateOfBirth), true, DataSourceUpdateMode.OnPropertyChanged);

			this.genderComboBox.DataBindings.Add(
				"SelectedItem", addPatientViewModel, nameof(addPatientViewModel.Sex), true, DataSourceUpdateMode.OnPropertyChanged);

			this.addressOneTextBox.DataBindings.Add(
				"Text", addPatientViewModel, nameof(addPatientViewModel.Address1), true, DataSourceUpdateMode.OnPropertyChanged);

			this.addressTwoTextBox.DataBindings.Add(
				"Text", addPatientViewModel, nameof(addPatientViewModel.Address2), true, DataSourceUpdateMode.OnPropertyChanged);

			this.cityTextBox.DataBindings.Add(
				"Text", addPatientViewModel, nameof(addPatientViewModel.City), true, DataSourceUpdateMode.OnPropertyChanged);

			this.stateComboBox.DataBindings.Add(
				"SelectedItem", addPatientViewModel, nameof(addPatientViewModel.State), true, DataSourceUpdateMode.OnPropertyChanged);

			this.zipCodeTextBox.DataBindings.Add(
				"Text", addPatientViewModel, nameof(addPatientViewModel.ZipCode), true, DataSourceUpdateMode.OnPropertyChanged);

			this.phoneNumberTextBox.DataBindings.Add(
				"Text", addPatientViewModel, nameof(addPatientViewModel.PhoneNumber), true, DataSourceUpdateMode.OnPropertyChanged);

			this.ssnTextBox.DataBindings.Add(
				"Text", addPatientViewModel, nameof(addPatientViewModel.Ssn), true, DataSourceUpdateMode.OnPropertyChanged);

			this.actionButton.DataBindings.Add(
				"Enabled", addPatientViewModel, nameof(addPatientViewModel.IsValid), true, DataSourceUpdateMode.OnPropertyChanged);
		}

		private void BindValidationMessages()
		{
			this.firstNameErrorLabel.DataBindings.Add(
				"Text", addPatientViewModel, nameof(addPatientViewModel.FirstNameValidationMessage));

			this.lastNameErrorLabel.DataBindings.Add(
				"Text", addPatientViewModel, nameof(addPatientViewModel.LastNameValidationMessage));

			this.sexErrorLabel.DataBindings.Add(
				"Text", addPatientViewModel, nameof(addPatientViewModel.SexValidationMessage));

			this.dateOfBirthErrorLabel.DataBindings.Add(
				"Text", addPatientViewModel, nameof(addPatientViewModel.DateOfBirthValidationMessage));

			this.phoneNumberErrorLabel.DataBindings.Add(
				"Text", addPatientViewModel, nameof(addPatientViewModel.PhoneNumberValidationMessage));

			this.ssnErrorLabel.DataBindings.Add(
				"Text", addPatientViewModel, nameof(addPatientViewModel.SsnValidationMessage));

			this.addressOneErrorLabel.DataBindings.Add(
				"Text", addPatientViewModel, nameof(addPatientViewModel.Address1ValidationMessage));

			this.cityErrorLabel.DataBindings.Add(
				"Text", addPatientViewModel, nameof(addPatientViewModel.CityValidationMessage));

			this.stateErrorLabel.DataBindings.Add(
				"Text", addPatientViewModel, nameof(addPatientViewModel.StateValidationMessage));

			this.zipCodeErrorLabel.DataBindings.Add(
				"Text", addPatientViewModel, nameof(addPatientViewModel.ZipCodeValidationMessage));
		}

		#endregion
	}
}
