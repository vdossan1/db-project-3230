using System.ComponentModel;
using HealthCareApp.DAL;
using HealthCareApp.model;
using static HealthCareApp.view.AdvancedSearchControl;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.viewmodel
{
	public class PatientsControlViewModel : INotifyPropertyChanged
	{
		public List<Patient> Patients { get; private set; }

		public PatientsControlViewModel() {
			Patients = new List<Patient>();
			this.PopulatePatients();
		}

        public event PropertyChangedEventHandler? PropertyChanged;

        public void PopulatePatients(SearchEventArgs eventArgs = null)
		{
            if (eventArgs == null)
            {
                Patients = PatientDal.GetAllPatients();
            }
            else
            {
                var firstName = eventArgs.FirstName;
                var lastName = eventArgs.LastName;
                var dateOfBirth = eventArgs.DateOfBirth;

                Patients = PatientDal.GetAllPatientsWithParams(firstName, lastName, dateOfBirth);
            }
		}
    }
}
