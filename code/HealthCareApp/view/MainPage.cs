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
	private readonly AdminControl adminControl;

	private readonly MainPageViewModel mainPageViewModel;
    private UserControl? activeControl;
    private Button? selectedButton;

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
		this.adminControl = new AdminControl();

        this.adminButton.Visible = false;
		this.DisplayUserInformation();
        this.initializeMainPageDesign();
        this.setApptControlActive();
    }

    private void setApptControlActive()
    {
        this.HighlightButton(this.appointmentsButton);
        this.activeControl = this.appointmentsControl;
        this.mainPanel.Controls.Clear();
        this.mainPanel.Controls.Add(this.appointmentsControl);
    }

    #endregion

    #region Methods

    public void ShowAdminFeatures()
    {
        this.adminButton.Visible = true;
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
        this.HighlightButton(this.patientsButton);
        this.activeControl = this.patientsControl;
        this.mainPanel.Controls.Clear();
        this.mainPanel.Controls.Add(this.patientsControl);
    }

    private void appointmentsControlButton_Click(object sender, EventArgs e)
    {
        this.HighlightButton(this.appointmentsButton);
        this.activeControl = this.appointmentsControl;
        this.mainPanel.Controls.Clear();
        this.mainPanel.Controls.Add(this.appointmentsControl);
    }

    private void adminControlButton_Click(object sender, EventArgs e)
	{
		this.HighlightButton(this.adminButton);
		this.activeControl = this.adminControl;
		this.mainPanel.Controls.Clear();
		this.mainPanel.Controls.Add(this.adminControl);
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

    private void patientsButton_MouseEnter(object sender, EventArgs e)
    {
        if (this.selectedButton != this.patientsButton)
        {
            this.patientsButton.BackColor = Color.White;
            this.patientsButton.ForeColor = Settings.AccentColor;
            this.patientsButton.Image = Resources.patients_accent;
        }
    }

    private void patientsButton_MouseLeave(object sender, EventArgs e)
    {
        if (this.selectedButton != this.patientsButton)
        {
            this.patientsButton.Image = Resources.patients_white;
            this.patientsButton.BackColor = Settings.AccentColor;
            this.patientsButton.ForeColor = Color.White;
        }
    }

    private void appointmentsButton_MouseEnter(object sender, EventArgs e)
    {
        if (this.selectedButton != this.appointmentsButton)
        {
            this.appointmentsButton.BackColor = Color.White;
            this.appointmentsButton.ForeColor = Settings.AccentColor;
            this.appointmentsButton.Image = Resources.appointment_accent;
        }
    }

    private void appointmentsButton_MouseLeave(object sender, EventArgs e)
    {
        if (this.selectedButton != this.appointmentsButton)
        {
            this.appointmentsButton.Image = Resources.appointment_white;
            this.appointmentsButton.BackColor = Settings.AccentColor;
            this.appointmentsButton.ForeColor = Color.White;
        }
    }

    private void adminButton_MouseEnter(object sender, EventArgs e)
    {
	    if (this.selectedButton != this.adminButton)
	    {
		    this.adminButton.BackColor = Color.White;
		    this.adminButton.ForeColor = Settings.AccentColor;
			//this.adminButton.Image = Resources.checkup_accent;
		}
	}

    private void adminButton_MouseLeave(object sender, EventArgs e)
    {
	    if (this.selectedButton != this.adminButton)
	    {
			//this.adminButton.Image = Resources.checkup_white;
			this.adminButton.BackColor = Settings.AccentColor;
		    this.adminButton.ForeColor = Color.White;
	    }
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

    private void HighlightButton(Button button)
    {
        if (this.selectedButton != null)
        {
            this.selectedButton.BackColor = Settings.AccentColor;
            this.selectedButton.ForeColor = Color.White;

	        if (this.selectedButton == this.patientsButton)
                this.selectedButton.Image = Resources.patients_white;
            else if (this.selectedButton == this.appointmentsButton)
                this.selectedButton.Image = Resources.appointment_white;
        }

        button.BackColor = Color.White;
        button.ForeColor = Settings.AccentColor;

        if (button == this.patientsButton)
            button.Image = Resources.patients_accent;
        else if (button == this.appointmentsButton)
            button.Image = Resources.appointment_accent;

        this.selectedButton = button;
    }

    #endregion
}