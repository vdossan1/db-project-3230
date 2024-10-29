using HealthCareApp.view;
using HealthCareApp.viewmodel;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.View
{
    /// <summary>
    /// Represents the main user interface for the healthcare application, 
    /// providing access to patient and appointment management features.
    /// </summary>
    public partial class MainPage : Form
    {
        //private PatientsControl patientsControl;
        //private AppointmentsControl appointmentsControl;

        private MainPageViewModel mainPageViewModel;
        private UserControl? activePage;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
        /// <param name="mainPageViewModel">The <see cref="MainPageViewModel"/> instance that contains the data and logic for the main page.</param>
        public MainPage(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();
            this.FormClosing += mainPage_FormClosing;
            this.activePage = null;

            this.mainPageViewModel = mainPageViewModel;
            //this.PatientsControl = new PatientsControl();
            //this.AppointmentsControl = new AppointmentsControl();

            this.DisplayUserInformation();
        }

        private void mainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            var loginPage = new LoginPage();
            loginPage.Show();
        }

        private void patientsControlButton_Click(object sender, EventArgs e)
        {
            //this.activePage = this.patientsControl;
            //this.patientsPage.Show();
        }

        private void appointmentsControlButton_Click(object sender, EventArgs e)
        {
            //this.activePage = this.appointmentsControl;
            //this.appointmentsPage.Show();
        }

        private void DisplayUserInformation()
        {
            this.usernameLabel.Text = this.mainPageViewModel.Username;
            this.userFullNameLabel.Text = this.mainPageViewModel.UserFullName;
        }

        private void registerPatientBtn_Click(object sender, EventArgs e)
        {
            var addPatientPage = new AddPatientPage(this);
            addPatientPage.ShowDialog(); //ShowDialog blocks the MainPage while new page is active
        }

        private void editPatientBtn_Click(object sender, EventArgs e)
        {
            if (this.patientsDataGridView.SelectedRows.Count > 0)
            {
                var editPatientPage = new EditPatientPage(this);
                editPatientPage.ShowDialog();
            }
        }
    }
}
