using System.Data;
using HealthCareApp.model;
using MySql.Data.MySqlClient;

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
			using var adapter = new MySqlDataAdapter(query, connection);
			var table = new DataTable();
			adapter.Fill(table);
			if (table.Rows.Count > 0)
			{
				patientList = (from row in table.AsEnumerable()
					select new Patient(
						row.Field<string>("first_name"),
						row.Field<string>("last_name"),
						row.Field<DateTime>("date_of_birth"),
						row.Field<string>("sex"),
						row.Field<string>("address_line1"),
						row.Field<string>("address_line2"),
						row.Field<string>("city"),
						row.Field<string>("state"),
						row.Field<string>("zip_code"),
						row.Field<string>("phone_number"),
						row.Field<string>("ssn"),
						row.Field<bool>("status")
					)).ToList();
			}
			return patientList;
		}
	}

}
