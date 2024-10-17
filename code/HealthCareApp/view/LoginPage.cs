namespace HealthCareApp
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage("dos Santos, Vitor");
            mainPage.ShowDialog();
            this.Close();
        }
    }
}
