using HealthCareApp.viewmodel;

namespace HealthCareApp
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
            string username = this.usernameTextField.Text;
            string password = this.passwordTextField.Text;

            bool isValidLogin = this.loginViewModel.TryLogin(username, password);

            if (isValidLogin)
            {
                this.Hide();
                MainPage mainPage = new MainPage("dos Santos, Vitor");
                mainPage.ShowDialog();
                this.Close();
            }
            else
            {
                this.invalidLoginLabel.Visible = true;
            }
        }
    }
}
