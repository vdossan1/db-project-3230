// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
using HealthCareApp.DAL;
using HealthCareApp.model;
using System.ComponentModel;
using static HealthCareApp.view.AdvancedSearchControl;

namespace HealthCareApp.viewmodel
{
	public class AppointmentsControlViewModel
	{
		public List<Appointment> Appointments { get; private set; }

		public AppointmentsControlViewModel()
		{
			Appointments = new List<Appointment>();
			this.PopulateAppointments();
		}

		public event PropertyChangedEventHandler? PropertyChanged;

		public void PopulateAppointments(SearchEventArgs eventArgs = null)
		{
			if (eventArgs == null)
			{
				Appointments = AppointmentDal.GetAllAppointments();
			}
			else
			{
				var firstName = eventArgs.FirstName;
				var lastName = eventArgs.LastName;
				var dateOfBirth = eventArgs.DateOfBirth;

				//Appointments = AppointmentDal.GetAllAppointmentsWithParams(firstName, lastName, dateOfBirth);
			}
		}
	}
}
