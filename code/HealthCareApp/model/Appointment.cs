// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.model
{
	/// <summary>
	/// The Appointment Class.
	/// </summary>
	public class Appointment
	{
		/// <summary>
		/// Gets or sets the Appointment Id for the appointment.
		/// </summary>
		public int AppointmentId { get; set; }

		/// <summary>
		/// Gets or sets the Patient Id for the appointment.
		/// </summary>
		public int PatientId { get; }

		/// <summary>
		/// Gets or sets the Doctor Id for the appointment.
		/// </summary>
		public int DoctorId { get; }

		/// <summary>
		/// Gets or sets the date of the appointment.
		/// </summary>
		public DateTime? AppointmentDate { get; }

		/// <summary>
		/// Gets or sets the reason for the appointment.
		/// </summary>
		public string Reason { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Appointment"/> class with the specified details.
		/// </summary>
		public Appointment(int patientId, int doctorId, DateTime? date, string reason)
		{
			PatientId = patientId;
			DoctorId = doctorId;
			AppointmentDate = date ?? throw new ArgumentNullException(nameof(date));
			Reason = reason ?? throw new ArgumentNullException(nameof(reason));
		}
	}
}

