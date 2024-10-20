using HealthCareApp.DAL;
using HealthCareApp.model;

namespace HealthCareApp.viewmodel
{
    public class MainPageViewModel
    {
	    public List<Patient> Patients { get; set; }

	    public void PopulatePatients()
	    {
		    Patients = PatientDal.GetAllPatients();
	    }
    }
}
