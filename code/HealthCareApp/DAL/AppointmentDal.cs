// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
using HealthCareApp.model;
using MySql.Data.MySqlClient;

namespace HealthCareApp.DAL
{
	/// <summary>
	/// Provides data access methods for managing appointment records in the database.
	/// </summary>
	public class AppointmentDal
	{
		/// <summary>
		/// Edits an existing appointment in the database.
		/// </summary>
		/// <param name="appointment">The appointment object containing updated information about the appointment.</param>
		public static void EditAppointment(Appointment appointment)
		{
			using var connection = new MySqlConnection(Connection.ConnectionString());
			connection.Open();

			string query = "UPDATE appointment SET patient_id = @PatientId, doctor_id = @DoctorId, appointment_date = @AppointmentDate, " +
						   "WHERE appointment_id = @AppointmentId";

			using MySqlCommand command = new MySqlCommand(query, connection);

			AddAllAppointmentParamsToCommand(appointment, command);

			command.ExecuteNonQuery();
		}

		/// <summary>
		/// Creates a new appointment in the database.
		/// </summary>
		/// <param name="newAppointment">The appointment object containing information about the appointment to be registered.</param>
		public static void CreateAppointment(Appointment newAppointment)
		{
			using var connection = new MySqlConnection(Connection.ConnectionString());
			connection.Open();

			string query = "INSERT INTO appointment (patient_id, doctor_id, appointment_date, reason) " +
						   "VALUES (@PatientId, @DoctorId, @AppointmentDate, @Reason)";

			using MySqlCommand command = new MySqlCommand(query, connection);

			AddAllAppointmentParamsToCommand(newAppointment, command);

			command.ExecuteNonQuery();
		}

		/// <summary>
		/// Retrieves a list of all appointments from the database.
		/// </summary>
		/// <returns>A list of <see cref="Appointment"/> objects representing all appointments in the database.</returns>
		public static List<Appointment> GetAllAppointments()
		{
			var appointmentList = new List<Appointment>();

			using var connection = new MySqlConnection(Connection.ConnectionString());
			connection.Open();

			string query = "SELECT * FROM appointment";

			using MySqlCommand command = new MySqlCommand(query, connection);

			using MySqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				appointmentList.Add(
					CreateAppointment(reader));
			}

			return appointmentList;
		}

		private static Appointment CreateAppointment(MySqlDataReader reader)
		{
			var idOrdinal = reader.GetOrdinal("appointment_id");
			var patientIdOrdinal = reader.GetOrdinal("patient_id");
			var doctorIdOrdinal = reader.GetOrdinal("doctor_id");
			var dateOrdinal = reader.GetOrdinal("appointment_date");
			var reasonOrdinal = reader.GetOrdinal("reason");

			var newAppointment = new Appointment
			(
				reader.GetInt32(patientIdOrdinal),
				reader.GetInt32(doctorIdOrdinal),
				reader.GetDateTime(dateOrdinal),
				reader.GetString(reasonOrdinal)
			);

			newAppointment.AppointmentId = reader.GetInt32(idOrdinal);
			return newAppointment;
		}

		private static void AddAllAppointmentParamsToCommand(Appointment appointment, MySqlCommand command)
		{
			command.Parameters.AddWithValue("@PatientId", appointment.PatientId);
			command.Parameters.AddWithValue("@DoctorId", appointment.DoctorId);
			command.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
			command.Parameters.AddWithValue("@Reason", appointment.Reason);
		}
	}
}
