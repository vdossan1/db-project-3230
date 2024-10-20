using HealthCareApp.model;
using HealthCareApp.View;
using HealthCareApp.viewmodel;

namespace HealthCareApp.view
{
    public partial class EditPatientPage : Form
    {
	    public Patient PatientToEdit { get; set; }

		private AddPatientPageViewModel addPatientViewModel;
        private MainPage activeMainPage;

		public EditPatientPage(MainPage mainPage)
        {
            InitializeComponent();

            this.addPatientViewModel = new AddPatientPageViewModel();
            addPatientViewModel.PopulateFields(PatientToEdit);
			this.activeMainPage = mainPage;

			this.BindControls();
        }

		private void BindControls()
        {
            this.stateCmbBox.DataSource = addPatientViewModel.StatesArray;
            this.genderCmbBox.DataSource = addPatientViewModel.SexArray;

            // Data Bindings
            this.firstNameTextBox.DataBindings.Add(
                "Text", addPatientViewModel, nameof(addPatientViewModel.FirstName), true, DataSourceUpdateMode.OnPropertyChanged);

            this.lastNameTextBox.DataBindings.Add(
                "Text", addPatientViewModel, nameof(addPatientViewModel.LastName), true, DataSourceUpdateMode.OnPropertyChanged);

            this.dateOfBirthPicker.DataBindings.Add(
	            "Value", addPatientViewModel, nameof(addPatientViewModel.DateOfBirth), true, DataSourceUpdateMode.OnPropertyChanged);

            this.genderCmbBox.DataBindings.Add(
	            "SelectedItem", addPatientViewModel, nameof(addPatientViewModel.Sex), true, DataSourceUpdateMode.OnPropertyChanged);

            this.addressOneTxtBox.DataBindings.Add(
	            "Text", addPatientViewModel, nameof(addPatientViewModel.Address1), true, DataSourceUpdateMode.OnPropertyChanged);

            this.addressTwoTxtBox.DataBindings.Add(
	            "Text", addPatientViewModel, nameof(addPatientViewModel.Address2), true, DataSourceUpdateMode.OnPropertyChanged);

            this.cityTxtBox.DataBindings.Add(
	            "Text", addPatientViewModel, nameof(addPatientViewModel.City), true, DataSourceUpdateMode.OnPropertyChanged);

            this.stateCmbBox.DataBindings.Add(
	            "SelectedItem", addPatientViewModel, nameof(addPatientViewModel.State), true, DataSourceUpdateMode.OnPropertyChanged);

            this.zipCodeTxtBox.DataBindings.Add(
	            "Text", addPatientViewModel, nameof(addPatientViewModel.ZipCode), true, DataSourceUpdateMode.OnPropertyChanged);

            this.phoneNumberTxtBox.DataBindings.Add(
	            "Text", addPatientViewModel, nameof(addPatientViewModel.PhoneNumber), true, DataSourceUpdateMode.OnPropertyChanged);

            this.ssnTxtBox.DataBindings.Add(
	            "Text", addPatientViewModel, nameof(addPatientViewModel.Ssn), true, DataSourceUpdateMode.OnPropertyChanged);
		}

        private void editPatientBtn_Click(object sender, EventArgs e)
        {
	        this.addPatientViewModel.EditPatient();
        }

		private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.activeMainPage.Show();
        }
    }
}
