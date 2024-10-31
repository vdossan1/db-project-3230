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
        private PatientsControl patientsControl;
        private AppointmentsControl appointmentsControl;

        private MainPageViewModel mainPageViewModel;
        private UserControl? activeControl;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
        /// <param name="mainPageViewModel">The <see cref="MainPageViewModel"/> instance that contains the data and logic for the main page.</param>
        public MainPage(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();
            this.FormClosing += mainPage_FormClosing;
            this.activeControl = null;

            this.mainPageViewModel = mainPageViewModel;
            this.patientsControl = new PatientsControl();
            this.appointmentsControl = new AppointmentsControl();

            this.DisplayUserInformation();
            this.initializeMainPageDesign();
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

        private void homeButton_Click(object sender, EventArgs e)
        {
	        this.activeControl = null;
	        this.mainPanel.Controls.Clear();
        }

		private void patientsControlButton_Click(object sender, EventArgs e)
        {
            this.activeControl = this.patientsControl;
            this.mainPanel.Controls.Clear();
			this.mainPanel.Controls.Add(this.patientsControl);
        }

        private void appointmentsControlButton_Click(object sender, EventArgs e)
        {
            this.activeControl = this.appointmentsControl;
            this.mainPanel.Controls.Clear();
			this.mainPanel.Controls.Add(this.appointmentsControl);
		}

        private void visitsControlButton_Click(object sender, EventArgs e)
        {
	        this.activeControl = null;
	        this.mainPanel.Controls.Clear();
        }

		private void DisplayUserInformation()
        {
            this.usernameLabel.Text = this.mainPageViewModel.Username;
            this.userFullNameLabel.Text = this.mainPageViewModel.UserFullName;
        }

        private void initializeMainPageDesign()
        {
			this.sidebarPanel.BackColor = Settings.AccentColor;
		}

        private void homeButton_MouseEnter(object sender, EventArgs e)
        {
	        homeButton.BackColor = Color.White;
	        homeButton.ForeColor = Settings.AccentColor;
        }

        private void homeButton_MouseLeave(object sender, EventArgs e)
        {
	        homeButton.BackColor = Settings.AccentColor;
	        homeButton.ForeColor = Color.White;
        }

        private void patientsButton_MouseEnter(object sender, EventArgs e)
        {
	        patientsButton.BackColor = Color.White;
	        patientsButton.ForeColor = Settings.AccentColor;
        }

        private void patientsButton_MouseLeave(object sender, EventArgs e)
        {
	        patientsButton.BackColor = Settings.AccentColor;
	        patientsButton.ForeColor = Color.White;
        }

        private void appointmentsButton_MouseEnter(object sender, EventArgs e)
        {
	        appointmentsButton.BackColor = Color.White;
	        appointmentsButton.ForeColor = Settings.AccentColor;
        }

        private void appointmentsButton_MouseLeave(object sender, EventArgs e)
        {
	        appointmentsButton.BackColor = Settings.AccentColor;
	        appointmentsButton.ForeColor = Color.White;
        }

        private void visitsButton_MouseEnter(object sender, EventArgs e)
        {
	        visitsButton.BackColor = Color.White;
	        visitsButton.ForeColor = Settings.AccentColor;
        }

        private void visitsButton_MouseLeave(object sender, EventArgs e)
        {
	        visitsButton.BackColor = Settings.AccentColor;
	        visitsButton.ForeColor = Color.White;
        }

        private void logoutButton_MouseEnter(object sender, EventArgs e)
        {
	        logoutButton.BackColor = Color.White;
	        logoutButton.ForeColor = Settings.AccentColor;
        }

        private void logoutButton_MouseLeave(object sender, EventArgs e)
        {
	        logoutButton.BackColor = Settings.AccentColor;
	        logoutButton.ForeColor = Color.White;
        }
	}
}
