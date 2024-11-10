using HealthCareApp.Properties;
using HealthCareApp.view;
using HealthCareApp.viewmodel;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.View;

/// <summary>
///     Represents the main user interface for the healthcare application,
///     providing access to patient and appointment management features.
/// </summary>
public partial class MainPage : Form
{
    #region Data members

    private readonly PatientsControl patientsControl;
    private readonly AppointmentsControl appointmentsControl;
    private readonly VisitsControl visitsControl;

    private readonly MainPageViewModel mainPageViewModel;
    private UserControl? activeControl;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="MainPage" /> class.
    /// </summary>
    /// <param name="mainPageViewModel">
    ///     The <see cref="MainPageViewModel" /> instance that contains the data and logic for the
    ///     main page.
    /// </param>
    public MainPage(MainPageViewModel mainPageViewModel)
    {
        this.InitializeComponent();
        FormClosing += this.mainPage_FormClosing;
        this.activeControl = null;

        this.mainPageViewModel = mainPageViewModel;
        this.patientsControl = new PatientsControl();
        this.appointmentsControl = new AppointmentsControl();
        this.visitsControl = new VisitsControl(this.mainPageViewModel.UserFullName, this.mainPageViewModel.Username);

        this.DisplayUserInformation();
        this.initializeMainPageDesign();
    }

    #endregion

    #region Methods

    private void mainPage_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    private void logoutButton_Click(object sender, EventArgs e)
    {
        Hide();
        Dispose();
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
        this.activeControl = this.visitsControl;
        this.mainPanel.Controls.Clear();
        this.mainPanel.Controls.Add(this.visitsControl);
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
        this.homeButton.BackColor = Color.White;
        this.homeButton.ForeColor = Settings.AccentColor;
        this.homeButton.Image = Resources.home_accent;
    }

    private void homeButton_MouseLeave(object sender, EventArgs e)
    {
        this.homeButton.Image = Resources.home_white;
        this.homeButton.BackColor = Settings.AccentColor;
        this.homeButton.ForeColor = Color.White;
    }

    private void patientsButton_MouseEnter(object sender, EventArgs e)
    {
        this.patientsButton.BackColor = Color.White;
        this.patientsButton.ForeColor = Settings.AccentColor;
        this.patientsButton.Image = Resources.patients_accent;
    }

    private void patientsButton_MouseLeave(object sender, EventArgs e)
    {
        this.patientsButton.Image = Resources.patients_white;
        this.patientsButton.BackColor = Settings.AccentColor;
        this.patientsButton.ForeColor = Color.White;
    }

    private void appointmentsButton_MouseEnter(object sender, EventArgs e)
    {
        this.appointmentsButton.BackColor = Color.White;
        this.appointmentsButton.ForeColor = Settings.AccentColor;
        this.appointmentsButton.Image = Resources.appointment_accent;
    }

    private void appointmentsButton_MouseLeave(object sender, EventArgs e)
    {
        this.appointmentsButton.Image = Resources.appointment_white;
        this.appointmentsButton.BackColor = Settings.AccentColor;
        this.appointmentsButton.ForeColor = Color.White;
    }

    private void visitsButton_MouseEnter(object sender, EventArgs e)
    {
        this.visitsButton.BackColor = Color.White;
        this.visitsButton.ForeColor = Settings.AccentColor;
        this.visitsButton.Image = Resources.checkup_accent;
    }

    private void visitsButton_MouseLeave(object sender, EventArgs e)
    {
        this.visitsButton.Image = Resources.checkup_white;
        this.visitsButton.BackColor = Settings.AccentColor;
        this.visitsButton.ForeColor = Color.White;
    }

    private void logoutButton_MouseEnter(object sender, EventArgs e)
    {
        this.logoutButton.BackColor = Color.White;
        this.logoutButton.ForeColor = Settings.AccentColor;
        this.logoutButton.Image = Resources.logout_accent;
    }

    private void logoutButton_MouseLeave(object sender, EventArgs e)
    {
        this.logoutButton.Image = Resources.logout_white;
        this.logoutButton.BackColor = Settings.AccentColor;
        this.logoutButton.ForeColor = Color.White;
    }

    #endregion
}