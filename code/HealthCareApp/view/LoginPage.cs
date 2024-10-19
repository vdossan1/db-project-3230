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

        private void processValidLogin(string username)
        {
            this.Hide();

            string userFullName = this.loginViewModel.GetUserFullName(username);
            MainPage mainPage = new MainPage(userFullName);
            mainPage.ShowDialog();

            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = this.usernameTextField.Text;
            string password = this.passwordTextField.Text;

            bool isValidLogin = this.loginViewModel.TryLogin(username, password);

            if (isValidLogin)
            {
                this.processValidLogin(username);
            }
            else
            {
                this.invalidLoginLabel.Visible = true;
            }
        }
    }
}
