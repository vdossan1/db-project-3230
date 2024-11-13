// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024

using System.Diagnostics;
using System.Text;
using HealthCareApp.model;
using MySql.Data.MySqlClient;

namespace HealthCareApp.DAL;

/// <summary>
///     Provides data access methods for managing appointment records in the database.
/// </summary>
public class AppointmentDal
{
    #region Methods

    /// <summary>
    ///     Edits an existing appointment in the database.
    /// </summary>
    /// <param name="appointment">The appointment object containing updated information about the appointment.</param>
    public static void EditAppointment(Appointment appointment)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString());
        connection.Open();

        var query =
            "UPDATE appointment SET patient_id = @PatientId, doctor_id = @DoctorId, appointment_date = @AppointmentDate, reason = @Reason " +
            "WHERE appointment_id = @AppointmentId";

        using var command = new MySqlCommand(query, connection);

        AddAllAppointmentParamsToCommand(appointment, command);

        command.ExecuteNonQuery();
    }

    /// <summary>
    ///     Creates a new appointment in the database.
    /// </summary>
    /// <param name="newAppointment">The appointment object containing information about the appointment to be registered.</param>
    public static void CreateAppointment(Appointment newAppointment)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString());
        connection.Open();

        var query = "INSERT INTO appointment (patient_id, doctor_id, appointment_date, reason) " +
                    "VALUES (@PatientId, @DoctorId, @AppointmentDate, @Reason)";

        using var command = new MySqlCommand(query, connection);

        AddAllAppointmentParamsToCommand(newAppointment, command);

        command.ExecuteNonQuery();
    }

    /// <summary>
    ///     Retrieves a list of appointment IDs for appointments with no associated visits.
    /// </summary>
    /// <returns>A list of integers representing the IDs of appointments with no visits.</returns>
    public static List<int> GetAllAppointmentsIdsWithNoVisits()
    {
        var appointmentIdList = new List<int>();

        using var connection = new MySqlConnection(Connection.ConnectionString());
        connection.Open();

        var query =
            "SELECT appointment_id FROM appointment WHERE appointment_id NOT IN (SELECT appointment_id from visit);";

        using var command = new MySqlCommand(query, connection);

        using var reader = command.ExecuteReader();

        var apptIdOrdinal = reader.GetOrdinal("appointment_id");

        while (reader.Read())
        {
            appointmentIdList.Add(reader.GetInt32(apptIdOrdinal));
        }

        return appointmentIdList;
    }

    /// <summary>
    ///     Retrieves a list of all appointments from the database.
    /// </summary>
    /// <returns>A list of <see cref="Appointment" /> objects representing all appointments in the database.</returns>
    public static List<Appointment> GetAllAppointments()
    {
        var appointmentList = new List<Appointment>();

        using var connection = new MySqlConnection(Connection.ConnectionString());
        connection.Open();

        var query = "SELECT * FROM appointment";

        using var command = new MySqlCommand(query, connection);

        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            appointmentList.Add(
                CreateAppointment(reader));
        }

        return appointmentList;
    }

	/// <summary>
	///     Retrieves a list of all appointments that match the specified search criteria.
	/// </summary>
	/// <param name="firstName">The first name of the patient or doctor to search for.</param>
	/// <param name="lastName">The last name of the patient or doctor to search for.</param>
	/// <param name="appointmentDate">The date of the appointment to search for.</param>
	/// <returns>A list of <see cref="Appointment" /> objects representing the matching appointments.</returns>
	public static List<Appointment> GetAllAppointmentsWithParams(string firstName, string lastName, DateTime? appointmentDate)
	{
		var appointmentList = new List<Appointment>();
		var queryBuilder = new StringBuilder("SELECT appointment.* FROM appointment ");
		queryBuilder.Append("JOIN patient ON appointment.patient_id = patient.patient_id ");
		queryBuilder.Append("JOIN doctor ON appointment.doctor_id = doctor.doctor_id ");

		var parameters = new List<MySqlParameter>();
		var conditions = new List<string>();

		if (!string.IsNullOrWhiteSpace(firstName))
		{
			conditions.Add("(patient.first_name = @PatientFirstName OR doctor.first_name = @DoctorFirstName)");
			parameters.Add(new MySqlParameter("@PatientFirstName", firstName));
			parameters.Add(new MySqlParameter("@DoctorFirstName", firstName));
		}

		if (!string.IsNullOrWhiteSpace(lastName))
		{
			conditions.Add("(patient.last_name = @PatientLastName OR doctor.last_name = @DoctorLastName)");
			parameters.Add(new MySqlParameter("@PatientLastName", lastName));
			parameters.Add(new MySqlParameter("@DoctorLastName", lastName));
		}

		if (appointmentDate != null && appointmentDate != DateTime.Today)
		{
			conditions.Add("appointment.appointment_date = @AppointmentDate");
			parameters.Add(new MySqlParameter("@AppointmentDate", appointmentDate));
		}

		if (conditions.Count > 0)
		{
			queryBuilder.Append("WHERE ");
			queryBuilder.Append(string.Join(" AND ", conditions));
		}

		queryBuilder.Append(';');

		using var connection = new MySqlConnection(Connection.ConnectionString());
		connection.Open();

		using var command = new MySqlCommand(queryBuilder.ToString(), connection);
		command.Parameters.AddRange(parameters.ToArray());

		Debug.WriteLine($"Query: {queryBuilder} FirstName: {firstName} LastName: {lastName} Date: {appointmentDate}");
		using var reader = command.ExecuteReader();

		while (reader.Read())
		{
			appointmentList.Add(CreateAppointment(reader));
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
        command.Parameters.Add("@AppointmentId", MySqlDbType.Int32).Value = appointment.AppointmentId;
        command.Parameters.Add("@PatientId", MySqlDbType.Int32).Value = appointment.PatientId;
        command.Parameters.Add("@DoctorId", MySqlDbType.Int32).Value = appointment.DoctorId;
        command.Parameters.Add("@AppointmentDate", MySqlDbType.DateTime).Value = appointment.AppointmentDate;
        command.Parameters.Add("@Reason", MySqlDbType.VarChar).Value = appointment.Reason;
    }

    #endregion
}