using System.Data;
using System.Diagnostics;
using HealthCareApp.model;
using MySql.Data.MySqlClient;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.DAL;

public class VisitDal
{
    #region Methods

    /// <summary>
    ///     Creates a new visit record in the database.
    /// </summary>
    /// <param name="newVisit">The <see cref="Visit" /> object containing details about the visit to be created.</param>
    public static void CreateVisit(Visit newVisit)
    {
        var query =
            "INSERT INTO visit (appointment_id, nurse_id, bp_systolic, bp_diastolic, body_temperature, weight, height, pulse_rate, symptoms, initial_diagnosis, final_diagnosis) " +
            "VALUES (@AppointmentId, @NurseId, @BloodPressureSys, @BloodPressureDias, @BodyTemp, @Weight, @Height, @PulseRate, @Symptoms, @InitialDiag, @FinalDiag)";

        using var connection = new MySqlConnection(Connection.ConnectionString());
        connection.Open();
        using var command = new MySqlCommand(query, connection);

        AddAllVisitParamsToCommand(newVisit, command);

        command.ExecuteNonQuery();
    }

    public static int EditVisit(Visit newVisit)
    {
        var query =
            "UPDATE visit SET bp_systolic = @BloodPressureSys, bp_diastolic = @BloodPressureDias, body_temperature = @BodyTemp, " +
            "weight = @Weight, height = @Height, pulse_rate = @PulseRate, symptoms = @Symptoms, initial_diagnosis = @InitialDiag, " +
            "final_diagnosis = @FinalDiag " +
            "WHERE visit_id = @VisitId";

        using var connection = new MySqlConnection(Connection.ConnectionString());
        connection.Open();

        using var command = new MySqlCommand(query, connection);
        AddAllVisitParamsToCommand(newVisit, command);
        command.Parameters.Add("@VisitId", MySqlDbType.Int32).Value = newVisit.VisitId;

        return command.ExecuteNonQuery();
    }

    /// <summary>
    ///     Retrieves a list of all visits from the database.
    /// </summary>
    /// <returns>A list of <see cref="Visit" /> objects representing all visits in the database.</returns>
    public static List<Visit> GetAllVisits()
    {
        var query = "SELECT * FROM visit";

        using var connection = new MySqlConnection(Connection.ConnectionString());
        connection.Open();

        using var command = new MySqlCommand(query, connection);
        using var reader = command.ExecuteReader();

        var visitList = new List<Visit>();
        while (reader.Read())
        {
            visitList.Add(
                CreateVisitObj(reader));
        }

        return visitList;
    }

    public static List<Visit> GetAllVisitsWithParams(string? firstName, string? lastName, DateTime? dateOfBirth)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString());
        connection.Open();

        using var command = new MySqlCommand("getVisitsWithPatientParams", connection);
        command.CommandType = CommandType.StoredProcedure;

        firstName = firstName.Equals("") ? null : firstName;
        lastName = lastName.Equals("") ? null : lastName;
        dateOfBirth = dateOfBirth == DateTime.Today ? null : dateOfBirth.Value.Date;


        command.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = firstName;
        command.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = lastName;
        command.Parameters.Add("@dateOfBirth", MySqlDbType.Date).Value = dateOfBirth;

        using var reader = command.ExecuteReader();
        Debug.WriteLine(dateOfBirth);
        var visitList = new List<Visit>();
        while (reader.Read())
        {
            visitList.Add(
                CreateVisitObj(reader));
        }

        return visitList;
    }

	private static Visit CreateVisitObj(MySqlDataReader reader)
    {
        var visitIdOrdinal = reader.GetOrdinal("visit_id");
        var appointmentIdOrdinal = reader.GetOrdinal("appointment_id");
        var nurseIdOrdinal = reader.GetOrdinal("nurse_id");
        var bloodPressureSysOrdinal = reader.GetOrdinal("bp_systolic");
        var bloodPressureDiasOrdinal = reader.GetOrdinal("bp_diastolic");
        var bodyTempOrdinal = reader.GetOrdinal("body_temperature");
        var weightOrdinal = reader.GetOrdinal("weight");
        var heightOrdinal = reader.GetOrdinal("height");
        var pulseRateOrdinal = reader.GetOrdinal("pulse_rate");
        var symptomsOrdinal = reader.GetOrdinal("symptoms");
        var initialDiagOrdinal = reader.GetOrdinal("initial_diagnosis");
        var finalDiagOrdinal = reader.GetOrdinal("final_diagnosis");

        var newVisit = new Visit
        (
            reader.GetInt32(visitIdOrdinal),
            reader.GetInt32(appointmentIdOrdinal),
            reader.GetInt32(nurseIdOrdinal),
            reader.GetInt32(bloodPressureSysOrdinal),
            reader.GetInt32(bloodPressureDiasOrdinal),
            reader.GetDecimal(bodyTempOrdinal),
            reader.GetDecimal(weightOrdinal),
            reader.GetDecimal(heightOrdinal),
            reader.GetInt32(pulseRateOrdinal),
            reader.GetString(symptomsOrdinal),
            reader.GetString(initialDiagOrdinal),
            reader.IsDBNull(finalDiagOrdinal) ? null : reader.GetString(finalDiagOrdinal)
        );

        return newVisit;
    }

    private static void AddAllVisitParamsToCommand(Visit newVisit, MySqlCommand command)
    {
        command.Parameters.Add("@AppointmentId", MySqlDbType.Int32).Value = newVisit.AppointmentId;
        command.Parameters.Add("@NurseId", MySqlDbType.Int32).Value = newVisit.NurseId;
        command.Parameters.Add("@BloodPressureSys", MySqlDbType.Int32).Value = newVisit.BloodPressureSystolic;
        command.Parameters.Add("@BloodPressureDias", MySqlDbType.Int32).Value = newVisit.BloodPressureDiastolic;
        command.Parameters.Add("@BodyTemp", MySqlDbType.Decimal).Value = newVisit.BodyTemp;
        command.Parameters.Add("@Weight", MySqlDbType.Decimal).Value = newVisit.Weight;
        command.Parameters.Add("@Height", MySqlDbType.Decimal).Value = newVisit.Height;
        command.Parameters.Add("@PulseRate", MySqlDbType.Int32).Value = newVisit.PulseRate;
        command.Parameters.Add("@Symptoms", MySqlDbType.VarChar).Value = newVisit.Symptoms;
        command.Parameters.Add("@InitialDiag", MySqlDbType.VarChar).Value = newVisit.InitialDiagnoses;
        command.Parameters.Add("@FinalDiag", MySqlDbType.VarChar).Value = newVisit.FinalDiagnoses;
    }

    #endregion
}