using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCareApp.DAL;

namespace HealthCareApp.view
{
    public partial class AppointmentsControl : UserControl
    {
        public AppointmentsControl()
        {
            InitializeComponent();
        }

        private void appointmentsSearchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearAdvSrcButton_Click(object sender, EventArgs e)
        {

        }

        private void advanSearchButton_Click(object sender, EventArgs e)
        {
            var firstName = this.firstNameTxtBox.Text;
            var lastName = this.lastNameTxtBox.Text;
            var dateOfBirth = this.dateOfBirthPicker.Value.Date;
            var patientsWithCritetia = PatientDal.GetAllPatientsWithParams(firstName, lastName, dateOfBirth);

            this.appointmentsDataGridView.DataSource = patientsWithCritetia;
        }
    }
}
