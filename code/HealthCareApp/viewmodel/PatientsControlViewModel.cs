using HealthCareApp.DAL;
using HealthCareApp.model;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.viewmodel
{
	public class PatientsControlViewModel
	{
		public List<Patient> Patients { get; set; }

		public PatientsControlViewModel() {
			Patients = new List<Patient>();
			this.PopulatePatients();
		}

		public void PopulatePatients()
		{
			Patients = PatientDal.GetAllPatients();
		}
	}
}
