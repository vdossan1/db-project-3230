using HealthCareApp.view;
using HealthCareApp.View;

namespace HealthCareApp.View
{
    public partial class MainPage : Form
    {

        public MainPage(String name)
        {
            InitializeComponent();

            this.userInfo.Text = name;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
            this.Close();
        }

        private void registerPatientBtn_Click(object sender, EventArgs e)
        {
            AddPatientPage addPatientPage = new AddPatientPage();
            addPatientPage.ShowDialog();
        }
    }
}
