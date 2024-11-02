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
		/// Gets or sets the Patient for the appointment.
		/// </summary>
		public Patient Patient { get; }

		/// <summary>
		/// Gets or sets the Doctor for the appointment.
		/// </summary>
		public Doctor Doctor { get; }

		/// <summary>
		/// Gets or sets the reason for the appointment.
		/// </summary>
		public string Reason { get; }

		/// <summary>
		/// Gets or sets the date of the appointment.
		/// </summary>
		public DateTime? Date { get; }

		/// <summary>
		/// Gets or sets the time of the appointment.
		/// </summary>
		public DateTime? Time { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Appointment"/> class with the specified details.
		/// </summary>
		public Appointment(Patient patient, Doctor doctor, string reason, DateTime? date, DateTime? time)
		{
			Patient = patient ?? throw new ArgumentNullException(nameof(patient));
			Doctor = doctor ?? throw new ArgumentNullException(nameof(doctor));
			Reason = reason ?? throw new ArgumentNullException(nameof(reason));
			Date = date ?? throw new ArgumentNullException(nameof(date));
			Time = time ?? throw new ArgumentNullException(nameof(time));
		}
	}
}

