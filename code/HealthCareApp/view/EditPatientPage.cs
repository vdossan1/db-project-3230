using HealthCareApp.model;
using HealthCareApp.View;
using HealthCareApp.viewmodel;

namespace HealthCareApp.view
{
    public partial class EditPatientPage : Form
    {
        private MainPage activeMainPage;
        private ManagePatientPageViewModel managePatientViewModel;
        public event EventHandler PatientUpdated;

        public Patient PatientToEdit { get; set; }

		public EditPatientPage(MainPage mainPage)
        {
            InitializeComponent();

            this.managePatientViewModel = new ManagePatientPageViewModel();
			this.activeMainPage = mainPage;

			this.BindControls();
        }

        public void PopulateFields()
        {
            managePatientViewModel.PopulateFields(PatientToEdit);
        }

        private void OnPatientUpdated()
        {
            PatientUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void BindControls()
        {
            this.stateCmbBox.DataSource = managePatientViewModel.StatesArray;
            this.genderCmbBox.DataSource = managePatientViewModel.SexArray;

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
		}

        private void editPatientBtn_Click(object sender, EventArgs e)
        {
	        this.managePatientViewModel.EditPatient();
            this.OnPatientUpdated();
            this.Hide();
            this.activeMainPage.Show();
        }

		private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.activeMainPage.Show();
        }
    }
}
