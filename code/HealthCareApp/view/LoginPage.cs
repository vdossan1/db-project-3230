using HealthCareApp.viewmodel;

namespace HealthCareApp.View
{
    public partial class LoginPage : Form
    {
        private LoginPageViewModel loginViewModel;
        private MainPage mainPage;


        public LoginPage()
        {
            InitializeComponent();

            this.loginViewModel = new LoginPageViewModel();
            this.mainPage = new MainPage(this);
        }

        private void ProcessValidLogin(string username)
        {
            this.Hide();

            this.usernameTextField.Clear();
            this.passwordTextField.Clear();

            string userFullName = this.loginViewModel.GetUserFullName(username);

            this.mainPage.UserFullName = userFullName;
            mainPage.ShowDialog();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = this.usernameTextField.Text;
            string password = this.passwordTextField.Text;

            bool isValidLogin = this.loginViewModel.TryLogin(username, password);

            if (isValidLogin)
            {
                this.ProcessValidLogin(username);
            }
            else
            {
                this.invalidLoginLabel.Visible = true;
            }
        }
    }
}
