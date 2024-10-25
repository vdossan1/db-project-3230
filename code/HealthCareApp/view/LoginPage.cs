using HealthCareApp.viewmodel;

namespace HealthCareApp.View
{
    public partial class LoginPage : Form
    {
        private LoginPageViewModel loginViewModel;

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
