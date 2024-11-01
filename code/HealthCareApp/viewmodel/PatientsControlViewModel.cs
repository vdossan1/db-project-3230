using HealthCareApp.DAL;
using HealthCareApp.model;

namespace HealthCareApp.viewmodel
{
	public class PatientsControlViewModel
	{
		public List<Patient> Patients { get; set; }

		public PatientsControlViewModel() {
			Patients = new List<Patient>();
			//PopulatePatients();
		}

		public void PopulatePatients()
		{
			Patients = PatientDal.GetAllPatients();
		}
	}
}
