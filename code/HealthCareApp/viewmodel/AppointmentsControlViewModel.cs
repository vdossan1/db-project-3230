// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
using HealthCareApp.DAL;
using HealthCareApp.model;

namespace HealthCareApp.viewmodel
{
	public class AppointmentsControlViewModel
	{
		public List<Appointment> Appointments { get; set; }

		public AppointmentsControlViewModel()
		{
			Appointments = new List<Appointment>();
			this.PopulateAppointments();
		}

		public void PopulateAppointments()
		{
			Appointments = AppointmentDal.GetAllAppointments();
		}
	}
}
