using HealthCareApp.view;
using HealthCareApp.viewmodel;

namespace HealthCareApp.View
{
	public partial class MainPage : Form
	{
		private AddPatientPage addPatientPage;
		private EditPatientPage editPatientPage;
		//private PatientsControl patientsControl;
		//private AppointmentsControl appointmentsControl;

		private MainPageViewModel mainPageViewModel;
		private UserControl activePage;

		public MainPage(MainPageViewModel mainPageViewModel)
		{
			InitializeComponent();

			this.mainPageViewModel = mainPageViewModel;
			this.addPatientPage = new AddPatientPage(this);
			this.editPatientPage = new EditPatientPage(this);
			//this.PatientsControl = new PatientsControl();
			//this.AppointmentsControl = new AppointmentsControl();
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
			//this.activePage = this.patientsControl;
			//this.patientsPage.Show();
		}

        private void appointmentsControlButton_Click(object sender, EventArgs e)
        {
			//this.activePage = this.appointmentsControl;
			//this.appointmentsPage.Show();
		}
	}
}
