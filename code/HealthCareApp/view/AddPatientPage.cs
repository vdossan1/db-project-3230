using HealthCareApp.View;
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
        public event EventHandler PatientAdded;

        private ManagePatientPageViewModel managePatientViewModel;

		/// <summary>
		/// Initializes a new instance of the <see cref="AddPatientPage"/> class.
		/// </summary>
		public AddPatientPage()
        {
            InitializeComponent();
            this.dateOfBirthPicker.MinDate = DateTime.Parse("1924-01-01");
            this.dateOfBirthPicker.MaxDate = DateTime.Today;

            this.managePatientViewModel = new ManagePatientPageViewModel();

            this.BindControls();
            this.BindValidationMessages();

            this.managePatientViewModel.ErrorOccured += ErrorOccured;
        }

        private void ErrorOccured(object? sender, string e)
        {
            MessageBox.Show(e, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BindControls()
        {
            this.genderCmbBox.DataSource = managePatientViewModel.SexArray;
            this.stateCmbBox.DataSource = managePatientViewModel.StatesArray;

            // Data Bindings
            this.firstNameTextBox.DataBindings.Add(
                "Text", managePatientViewModel, nameof(managePatientViewModel.FirstName), true, DataSourceUpdateMode.OnPropertyChanged);

            this.lastNameTextBox.DataBindings.Add(
                "Text", managePatientViewModel, nameof(managePatientViewModel.LastName), true, DataSourceUpdateMode.OnPropertyChanged);

            this.dateOfBirthPicker.DataBindings.Add(
	            "Value", managePatientViewModel, nameof(managePatientViewModel.DateOfBirth), true, DataSourceUpdateMode.OnPropertyChanged);

            this.genderCmbBox.DataBindings.Add(
	            "SelectedItem", managePatientViewModel, nameof(managePatientViewModel.Sex), true, DataSourceUpdateMode.OnPropertyChanged);

            this.addressOneTxtBox.DataBindings.Add(
	            "Text", managePatientViewModel, nameof(managePatientViewModel.Address1), true, DataSourceUpdateMode.OnPropertyChanged);

            this.addressTwoTxtBox.DataBindings.Add(
	            "Text", managePatientViewModel, nameof(managePatientViewModel.Address2), true, DataSourceUpdateMode.OnPropertyChanged);

            this.cityTxtBox.DataBindings.Add(
	            "Text", managePatientViewModel, nameof(managePatientViewModel.City), true, DataSourceUpdateMode.OnPropertyChanged);

            this.stateCmbBox.DataBindings.Add(
	            "SelectedItem", managePatientViewModel, nameof(managePatientViewModel.State), true, DataSourceUpdateMode.OnPropertyChanged);

            this.zipCodeTxtBox.DataBindings.Add(
	            "Text", managePatientViewModel, nameof(managePatientViewModel.ZipCode), true, DataSourceUpdateMode.OnPropertyChanged);

            this.phoneNumberTxtBox.DataBindings.Add(
	            "Text", managePatientViewModel, nameof(managePatientViewModel.PhoneNumber), true, DataSourceUpdateMode.OnPropertyChanged);

            this.ssnTxtBox.DataBindings.Add(
	            "Text", managePatientViewModel, nameof(managePatientViewModel.Ssn), true, DataSourceUpdateMode.OnPropertyChanged);

            this.registerPatientBtn.DataBindings.Add(
                "Enabled", managePatientViewModel, nameof(managePatientViewModel.IsValid), true, DataSourceUpdateMode.OnPropertyChanged);
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

        private void OnPatientAdded()
        {
            PatientAdded?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Patient registered successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void registerPatientBtn_Click(object sender, EventArgs e)
        {
            this.managePatientViewModel.ValidateFields();

            if (this.managePatientViewModel.RegisterPatient())
            {
                
                OnPatientAdded();
                this.Hide();
                this.Dispose();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}
