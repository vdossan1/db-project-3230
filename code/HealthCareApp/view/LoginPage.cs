using HealthCareApp.model;
using HealthCareApp.viewmodel;
using MySql.Data.MySqlClient;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.View;

/// <summary>
///     Represents the login interface for the healthcare application,
///     allowing users to authenticate and access the main application features.
/// </summary>
public partial class LoginPage : Form
{
    #region Data members

    private readonly LoginPageViewModel loginViewModel;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="LoginPage" /> class.
    /// </summary>
    public LoginPage()
    {
        this.InitializeComponent();
        this.loginViewModel = new LoginPageViewModel();
        this.usernameTextField.Text = "ab001";
        this.passwordTextField.Text = "pass";
    }

    #endregion

    #region Methods

    private void loginBtn_Click(object sender, EventArgs e)
    {
        try
        {
            var username = this.usernameTextField.Text;
            var password = this.passwordTextField.Text;

            var isValidLogin = this.loginViewModel.AuthenticateUser(username, password);

            if (isValidLogin)
            {
                this.ProcessValidLogin(username);
            }
            else
            {
                this.invalidLoginLabel.Visible = true;
            }
        }
        catch (MySqlException exception)
        {
            MessageBox.Show("Check your VPN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ProcessValidLogin(string username)
    {
        this.loginViewModel.StoreLoginCredentials(username);
        var mainPageViewModel = new MainPageViewModel
        {
            Username = this.loginViewModel.Username,
            UserFullName = this.loginViewModel.UserFullName
        };

        Hide();
        var mainPage = new MainPage(mainPageViewModel);

        if (LoggedUser.IsAdmin)
		{
			mainPage.ShowAdminFeatures();
		}

		mainPage.Show();

        this.usernameTextField.Clear();
        this.passwordTextField.Clear();
    }

    #endregion
}