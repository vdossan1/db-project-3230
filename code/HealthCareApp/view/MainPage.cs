using HealthCareApp.view;
using HealthCareApp.View;

namespace HealthCareApp.View
{
	public partial class MainPage : Form
	{
		private LoginPage loginPage;
		private AddPatientPage addPatientPage;
		private EditPatientPage editPatientPage;

		private string userfullname;
		public string UserFullName
		{
			get => userfullname;
			set
			{
				userfullname = value;
				this.userInfo.Text = userfullname;
			}
		}

		private string selectedPatient;
		public string SelectedPatient
		{
			get => selectedPatient;
			set
			{
				selectedPatient = value;
				//this.userInfo.Text = selectedPatient;
			}
		}

		public MainPage(LoginPage loginPage)
		{
			InitializeComponent();

			this.loginPage = loginPage;
			this.addPatientPage = new AddPatientPage(this);
		}

		private void logoutButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			this.loginPage.Show();
		}

		private void registerPatientBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			/*this.addPatientPage.Show();*/
			if (this.addPatientPage == null || this.addPatientPage.IsDisposed)
			{
				this.addPatientPage = new AddPatientPage(this);
			}
			else
			{
				this.addPatientPage.Show();
			}
		}

		private void editPatientBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			/*this.editPatientPage.Show();*/
			if (this.editPatientPage == null || this.editPatientPage.IsDisposed)
			{
				this.editPatientPage = new EditPatientPage(this, selectedPatient);
			}
			else
			{
				this.editPatientPage.Show();
			}
		}
	}
}
