using HealthCareApp.viewmodel;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.View
{
	/// <summary>
	/// Represents the login interface for the healthcare application, 
	/// allowing users to authenticate and access the main application features.
	/// </summary>
	public partial class LoginPage : Form
    {
        private LoginPageViewModel loginViewModel;

		/// <summary>
		/// Initializes a new instance of the <see cref="LoginPage"/> class.
		/// </summary>
		public LoginPage()
        {
            InitializeComponent();
			this.loginViewModel = new LoginPageViewModel();
		}

        private void loginBtn_Click(object sender, EventArgs e)
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

        private void ProcessValidLogin(string username)
        {
	        this.loginViewModel.StoreLoginCredentials(username);
	        var mainPageViewModel = new MainPageViewModel
	        {
		        Username = loginViewModel.Username,
		        UserFullName = loginViewModel.UserFullName
	        };

			this.Hide();
			MainPage mainPage = new MainPage(mainPageViewModel);
	        mainPage.Show();

			this.usernameTextField.Clear();
	        this.passwordTextField.Clear();
		}
	}
}
