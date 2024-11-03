using HealthCareApp.model;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Text;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.DAL
{
	/// <summary>
	/// Provides data access methods for managing patient records in the database.
	/// </summary>
	public class PatientDal
	{
		/// <summary>
		/// Finds a patient by their ID in the database.
		/// </summary>
		/// <param name="patientId">The ID of the patient to find.</param>
		public static Patient GetPatientById(int patientId)
		{
			using var connection = new MySqlConnection(Connection.ConnectionString());
			connection.Open();

			string query = "SELECT * FROM patient WHERE patient_id = @PatientId";

			using MySqlCommand command = new MySqlCommand(query, connection);
			command.Parameters.AddWithValue("@PatientId", patientId);

			using var reader = command.ExecuteReader();

			if (reader.Read())
			{
				return CreatePatientObj(reader);
			}
			return null;
		}

		/// <summary>
		/// Edits an existing patient's information in the database.
		/// </summary>
		/// <param name="patient">The patient object containing updated information about the patient.</param>
		public static void EditPatient(Patient patient)
		{
			using var connection = new MySqlConnection(Connection.ConnectionString());
			connection.Open();

			string query = "UPDATE patient SET first_name = @FirstName, last_name = @LastName, date_of_birth = @DateOfBirth, " +
						   "sex = @Sex, address_line1 = @Address1, address_line2 = @Address2, city = @City, state = @State, " +
						   "zip_code = @ZipCode, phone_number = @PhoneNumber, status = @Status " +
						   "WHERE ssn = @Ssn";

			using MySqlCommand command = new MySqlCommand(query, connection);

			AddAllPatientParamsToCommand(patient, command);

            command.ExecuteNonQuery();
		}

        /// <summary>
		/// Registers a new patient in the database.
		/// </summary>
		/// <param name="newPatient">The patient object containing information about the patient to be registered.</param>
		public static void RegisterPatient(Patient newPatient)
		{
			using var connection = new MySqlConnection(Connection.ConnectionString());
			connection.Open();

			string query = "INSERT INTO patient (first_name, last_name, date_of_birth, sex, address_line1, address_line2, city, state, zip_code, phone_number, ssn, status) " +
						   "VALUES (@FirstName, @LastName, @DateOfBirth, @Sex, @Address1, @Address2, @City, @State, @ZipCode, @PhoneNumber, @Ssn, @Status)";

			using MySqlCommand command = new MySqlCommand(query, connection);

            AddAllPatientParamsToCommand(newPatient, command);

            command.ExecuteNonQuery();
		}

        /// <summary>
        /// Retrieves a list of all patients from the database.
        /// </summary>
        /// <returns>A list of <see cref="Patient"/> objects representing all patients in the database.</returns>
        public static List<Patient> GetAllPatients()
		{
			var patientList = new List<Patient>();

			using var connection = new MySqlConnection(Connection.ConnectionString());
			connection.Open();

			var query = "select * from patient";

			using MySqlCommand command = new MySqlCommand(query, connection);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
				patientList.Add(
                    CreatePatientObj(reader));
            }

			return patientList;
		}

        public static List<Patient> GetAllPatientsWithParams(string firstName, string lastName, DateTime? dateOfBirth)
        {
            var patientList = new List<Patient>();
            var paramsCount = 0;
            var queryBuilder = new StringBuilder("select * from patient WHERE");
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

            if (queryBuilder.Equals("select * from patient WHERE;"))
            {
                queryBuilder = new StringBuilder("select * from patient;");
            }

            using MySqlCommand command = new MySqlCommand(queryBuilder.ToString(), connection);
            command.Parameters.AddRange(parameters.ToArray());

            Debug.WriteLine($"Query: {queryBuilder} FirstName: {firstName} LastName: {lastName} DoB{dateOfBirth}");
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                patientList.Add(
                    CreatePatientObj(reader));
            }

            return patientList;
        }

        private static Patient CreatePatientObj(MySqlDataReader reader)
        {
	        var idOrdinal = reader.GetOrdinal("patient_id");
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
            var statusOrdinal = reader.GetOrdinal("status");

            var newPatient = new Patient
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
				reader.GetString(ssnOrdinal),
				reader.GetBoolean(statusOrdinal)
            );

            newPatient.PatientId = reader.GetInt32(idOrdinal);
			return newPatient;
		}

        private static void AddAllPatientParamsToCommand(Patient patient, MySqlCommand command)
        {
            command.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = patient.FirstName;
            command.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = patient.LastName;
            command.Parameters.Add("@DateOfBirth", MySqlDbType.Date).Value = patient.DateOfBirth;
            command.Parameters.Add("@Sex", MySqlDbType.VarChar).Value = patient.Sex;
            command.Parameters.Add("@Address1", MySqlDbType.VarChar).Value = patient.Address1;
            command.Parameters.Add("@Address2", MySqlDbType.VarChar).Value = patient.Address2;
            command.Parameters.Add("@City", MySqlDbType.VarChar).Value = patient.City;
            command.Parameters.Add("@State", MySqlDbType.VarChar).Value = patient.State;
            command.Parameters.Add("@ZipCode", MySqlDbType.VarChar).Value = patient.ZipCode;
            command.Parameters.Add("@PhoneNumber", MySqlDbType.VarChar).Value = patient.PhoneNumber;
            command.Parameters.Add("@Ssn", MySqlDbType.VarChar).Value = patient.Ssn;
            command.Parameters.Add("@Status", MySqlDbType.Bit).Value = patient.Status;
        }
    }
    
}
