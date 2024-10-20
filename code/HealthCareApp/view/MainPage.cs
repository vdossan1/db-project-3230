using System.Diagnostics;
using HealthCareApp.model;
using HealthCareApp.view;
using HealthCareApp.View;
using HealthCareApp.viewmodel;

namespace HealthCareApp.View
{
	public partial class MainPage : Form
	{
		private LoginPage loginPage;
		private AddPatientPage addPatientPage;
		private EditPatientPage editPatientPage;

		private MainPageViewModel mainPageViewModel;

        #region Properties

		private string username;
        public string Username
        {
            get => username;
            set
            {
                username = value;
                this.usernameLabel.Text = Username;
            }
        }

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

        #endregion

        public MainPage(LoginPage loginPage)
		{
			InitializeComponent();
			
			this.loginPage = loginPage;
			this.addPatientPage = new AddPatientPage(this);
			this.editPatientPage = new EditPatientPage(this);
			this.editPatientPage.PatientUpdated += RefreshPatientListOnPatientUpdated;

            this.mainPageViewModel = new MainPageViewModel();

			this.mainPageViewModel.PopulatePatients();
			this.patientsDataGridView.DataSource = mainPageViewModel.Patients;
        }

        void RefreshPatientListOnPatientUpdated(object? sender, EventArgs e)
        {
            this.mainPageViewModel.PopulatePatients();
            this.patientsDataGridView.DataSource = mainPageViewModel.Patients;
        }

        private void logoutButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			this.loginPage.Show();
		}

		private void registerPatientBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
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
			if (patientsDataGridView.SelectedRows.Count > 0)
			{
				var selectedRow = patientsDataGridView.SelectedRows[0];
				var selectedPatient = selectedRow.DataBoundItem as Patient;
				this.editPatientPage.PatientToEdit = selectedPatient;
				this.editPatientPage.PopulateFields();
				
				if (this.editPatientPage == null || this.editPatientPage.IsDisposed)
				{
					this.editPatientPage = new EditPatientPage(this);
				}
				else
				{
                    this.Hide();
                    this.editPatientPage.Show();
				}
			}
			else
			{
				// TODO
				// Notify user that a patient must be selected
			}
		}
	}
}
