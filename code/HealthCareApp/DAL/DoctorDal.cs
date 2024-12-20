﻿using System.Diagnostics;
using System.Text;
using HealthCareApp.model;
using MySql.Data.MySqlClient;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.DAL;

/// <summary>
///     Provides data access methods for the Doctor entity.
/// </summary>
public class DoctorDal
{
    #region Methods

    /// <summary>
    ///     Finds a doctor by their ID in the database.
    /// </summary>
    /// <param name="doctorId">The ID of the doctor to find.</param>
    public static Doctor GetDoctorById(int doctorId)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString());
        connection.Open();

        var query = "SELECT * FROM doctor WHERE doctor_id = @DoctorId";

        using var command = new MySqlCommand(query, connection);
        command.Parameters.AddWithValue("@DoctorId", doctorId);

        using var reader = command.ExecuteReader();

        if (reader.Read())
        {
            return CreateDoctor(reader);
        }

        return null;
    }

	/// <summary>
	///     Finds a doctor's full name by their ID in the database.
	/// </summary>
	/// <param name="doctorId">The ID of the doctor full name to find.</param>
	public static string GetNurseFullNameById(int doctorId)
    {
	    using var connection = new MySqlConnection(Connection.ConnectionString());
	    connection.Open();

	    var query = "SELECT CONCAT(first_name, ' ', last_name) AS full_name FROM doctor WHERE doctor_id = @DoctorId";

	    using var command = new MySqlCommand(query, connection);
	    command.Parameters.AddWithValue("@DoctorId", doctorId);

	    using var reader = command.ExecuteReader();

	    if (reader.Read())
	    {
		    return reader["full_name"].ToString();
	    }

	    return null;
    }

	/// <summary>
	///     Registers a new doctor in the database.
	/// </summary>
	/// <param name="newDoctor">The <see cref="Doctor" /> object containing the doctor's details.</param>
	/// <exception cref="NotImplementedException">This method is not implemented yet.</exception>
	public static void RegisterDoctor(Doctor newDoctor)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString());
        connection.Open();

        var query =
            "INSERT INTO doctor (first_name, last_name, date_of_birth, sex, address_line1, address_line2, city, state, zip_code, phone_number, ssn) " +
            "VALUES (@FirstName, @LastName, @DateOfBirth, @Sex, @Address1, @Address2, @City, @State, @ZipCode, @PhoneNumber, @Ssn)";

        using var command = new MySqlCommand(query, connection);

        AddAllDoctorParamsToCommand(newDoctor, command);

        command.ExecuteNonQuery();
    }

    /// <summary>
    ///     Retrieves all doctors from the database.
    /// </summary>
    /// <returns>A list of <see cref="Doctor" /> objects representing all doctors in the database.</returns>
    public static List<Doctor> GetAllDoctors()
    {
        var doctorList = new List<Doctor>();

        using var connection = new MySqlConnection(Connection.ConnectionString());
        connection.Open();

        var query = "select * from doctor";

        using var command = new MySqlCommand(query, connection);

        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            doctorList.Add(
                CreateDoctor(reader));
        }

        return doctorList;
    }

    /// <summary>
    ///     Retrieves all doctors that match the specified search criteria.
    /// </summary>
    /// <param name="firstName">The first name of the doctor to search for.</param>
    /// <param name="lastName">The last name of the doctor to search for.</param>
    /// <param name="dateOfBirth">The date of birth of the doctor to search for.</param>
    /// <returns>A list of <see cref="Doctor" /> objects representing the matching doctors.</returns>
    public static List<Doctor> GetAllDoctorsWithParams(string firstName, string lastName, DateTime? dateOfBirth)
    {
        var doctorList = new List<Doctor>();
        var paramsCount = 0;
        var queryBuilder = new StringBuilder("select * from doctor WHERE");
        var parameters = new List<MySqlParameter>();

        var firstNameWhere = "first_name = @FirstName";
        var lastNameWhere = "last_name = @LastName";
        var birthDateWhere = "date_of_birth = @DateOfBirth";

        if (!string.IsNullOrWhiteSpace(firstName))
        {
            queryBuilder.Append($" {firstNameWhere}");
            parameters.Add(new MySqlParameter("@FirstName", firstName));
            ++paramsCount;
        }

        if (!string.IsNullOrWhiteSpace(lastName))
        {
            if (paramsCount == 0)
            {
                queryBuilder.Append($" {lastNameWhere}");
                ++paramsCount;
            }
            else
            {
                queryBuilder.Append($" AND {lastNameWhere}");
            }

            parameters.Add(new MySqlParameter("@LastName", lastName));
        }

        if (dateOfBirth != DateTime.Today)
        {
            if (paramsCount == 0)
            {
                queryBuilder.Append($" {birthDateWhere}");
            }
            else
            {
                queryBuilder.Append($" AND {birthDateWhere}");
            }

            parameters.Add(new MySqlParameter("@DateOfBirth", dateOfBirth));
        }

        queryBuilder.Append(';');

        using var connection = new MySqlConnection(Connection.ConnectionString());
        connection.Open();

        if (queryBuilder.Equals("select * from doctor WHERE;"))
        {
            queryBuilder = new StringBuilder("select * from doctor;");
        }

        using var command = new MySqlCommand(queryBuilder.ToString(), connection);
        command.Parameters.AddRange(parameters.ToArray());

        Debug.WriteLine($"Query: {queryBuilder} FirstName: {firstName} LastName: {lastName} DoB{dateOfBirth}");
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            doctorList.Add(
                CreateDoctor(reader));
        }

        return doctorList;
    }

    public static string GetDoctorNameWithApptId(int appointmentId)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString());
        connection.Open();

        var query = "SELECT first_name, last_name " +
                    "FROM doctor AS d JOIN appointment AS a ON d.doctor_id = a.doctor_id " +
                    "WHERE a.appointment_id = @AppointmentId " +
                    "LIMIT 1";

        using var command = new MySqlCommand(query, connection);
        command.Parameters.AddWithValue("@AppointmentId", appointmentId);

        using var reader = command.ExecuteReader();

        string fullName = "";

        if (reader.Read()) // Ensure there's data to read
        {
            var firstName = reader.GetString(reader.GetOrdinal("first_name"));
            var lastName = reader.GetString(reader.GetOrdinal("last_name"));
            fullName = $"{firstName} {lastName}";
        }

        return fullName;
    }

    private static Doctor CreateDoctor(MySqlDataReader reader)
    {
        var idOrdinal = reader.GetOrdinal("doctor_id");
        var firstNameOrdinal = reader.GetOrdinal("first_name");
        var lastNameOrdinal = reader.GetOrdinal("last_name");
        var dateOfBirthOrdinal = reader.GetOrdinal("date_of_birth");
        var gender = reader.GetOrdinal("sex");
        var addressOneOrdinal = reader.GetOrdinal("address_line1");
        var addressTwoOrdinal = reader.GetOrdinal("address_line2");
        var cityOrdinal = reader.GetOrdinal("city");
        var stateOrdinal = reader.GetOrdinal("state");
        var zipCodeOrdinal = reader.GetOrdinal("zip_code");
        var phoneNumberOrdinal = reader.GetOrdinal("phone_number");
        var ssnOrdinal = reader.GetOrdinal("ssn");

        var newDoctor = new Doctor
        (
            reader.GetString(firstNameOrdinal),
            reader.GetString(lastNameOrdinal),
            reader.GetDateTime(dateOfBirthOrdinal),
            reader.GetString(gender),
            reader.GetString(addressOneOrdinal),
            reader.IsDBNull(addressTwoOrdinal) ? null : reader.GetString(addressTwoOrdinal),
            reader.GetString(cityOrdinal),
            reader.GetString(stateOrdinal),
            reader.GetString(zipCodeOrdinal),
            reader.GetString(phoneNumberOrdinal),
            reader.GetString(ssnOrdinal)
        );

        newDoctor.DoctorId = reader.GetInt32(idOrdinal);
        return newDoctor;
    }

    private static void AddAllDoctorParamsToCommand(Doctor doctor, MySqlCommand command)
    {
        command.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = doctor.FirstName;
        command.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = doctor.LastName;
        command.Parameters.Add("@DateOfBirth", MySqlDbType.Date).Value = doctor.DateOfBirth;
        command.Parameters.Add("@Sex", MySqlDbType.VarChar).Value = doctor.Sex;
        command.Parameters.Add("@Address1", MySqlDbType.VarChar).Value = doctor.Address1;
        command.Parameters.Add("@Address2", MySqlDbType.VarChar).Value = doctor.Address2;
        command.Parameters.Add("@City", MySqlDbType.VarChar).Value = doctor.City;
        command.Parameters.Add("@State", MySqlDbType.VarChar).Value = doctor.State;
        command.Parameters.Add("@ZipCode", MySqlDbType.VarChar).Value = doctor.ZipCode;
        command.Parameters.Add("@PhoneNumber", MySqlDbType.VarChar).Value = doctor.PhoneNumber;
        command.Parameters.Add("@Ssn", MySqlDbType.VarChar).Value = doctor.Ssn;
    }

    #endregion
}