using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCareApp.View;
using HealthCareApp.viewmodel;

namespace HealthCareApp.view
{
    public partial class AddPatientPage : Form
    {
        private AddPatientPageViewModel addPatientViewModel;
        private MainPage activeMainPage;
        public AddPatientPage(MainPage mainPage)
        {
            InitializeComponent();

            this.addPatientViewModel = new AddPatientPageViewModel();
            this.activeMainPage = mainPage;
        }

        private void registerPatientBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.activeMainPage.Show();
        }
    }
}
