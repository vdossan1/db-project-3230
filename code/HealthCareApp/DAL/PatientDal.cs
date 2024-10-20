using System.Data;
using HealthCareApp.model;
using MySql.Data.MySqlClient;

namespace HealthCareApp.DAL
{
    public class PatientDal
    {
	    public static void EditPatient(Patient patient)
	    {
			using var connection = new MySqlConnection(Connection.ConnectionString());
			connection.Open();

			string query = "UPDATE patient SET first_name = @FirstName, last_name = @LastName, date_of_birth = @DateOfBirth, " +
			               "sex = @Sex, address_line1 = @Address1, address_line2 = @Address2, city = @City, state = @State, " +
			               "zip_code = @ZipCode, phone_number = @PhoneNumber, status = @Status " +
			               "WHERE ssn = @Ssn";

			using MySqlCommand command = new MySqlCommand(query, connection);

			command.Parameters.AddWithValue("@FirstName", patient.FirstName);
			command.Parameters.AddWithValue("@LastName", patient.LastName);
			command.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
			command.Parameters.AddWithValue("@Sex", patient.Sex.Substring(0, 1));
			command.Parameters.AddWithValue("@Address1", patient.Address1);
			command.Parameters.AddWithValue("@Address2", patient.Address2 ?? (object)DBNull.Value);
			command.Parameters.AddWithValue("@City", patient.City);
			command.Parameters.AddWithValue("@State", patient.State);
			command.Parameters.AddWithValue("@ZipCode", patient.ZipCode);
			command.Parameters.AddWithValue("@PhoneNumber", patient.PhoneNumber);
			command.Parameters.AddWithValue("@Ssn", patient.Ssn);
			command.Parameters.AddWithValue("@Status", patient.Status ? 1 : 0);

			command.ExecuteNonQuery();
		}

		public static void RegisterPatient(Patient newPatient)
        {
			using var connection = new MySqlConnection(Connection.ConnectionString());
			connection.Open();

			string query = "INSERT INTO patient (first_name, last_name, date_of_birth, sex, address_line1, address_line2, city, state, zip_code, phone_number, ssn, status) " +
			               "VALUES (@FirstName, @LastName, @DateOfBirth, @Sex, @Address1, @Address2, @City, @State, @ZipCode, @PhoneNumber, @Ssn, @Status)";

			using MySqlCommand command = new MySqlCommand(query, connection);

			command.Parameters.AddWithValue("@FirstName", newPatient.FirstName);
			command.Parameters.AddWithValue("@LastName", newPatient.LastName);
			command.Parameters.AddWithValue("@DateOfBirth", newPatient.DateOfBirth);
			command.Parameters.AddWithValue("@Sex", newPatient.Sex.Substring(0, 1));
			command.Parameters.AddWithValue("@Address1", newPatient.Address1);
			command.Parameters.AddWithValue("@Address2", newPatient.Address2 ?? (object)DBNull.Value);
			command.Parameters.AddWithValue("@City", newPatient.City);
			command.Parameters.AddWithValue("@State", newPatient.State);
			command.Parameters.AddWithValue("@ZipCode", newPatient.ZipCode);
			command.Parameters.AddWithValue("@PhoneNumber", newPatient.PhoneNumber);
			command.Parameters.AddWithValue("@Ssn", newPatient.Ssn);
			command.Parameters.AddWithValue("@Status", newPatient.Status ? 1 : 0);

			command.ExecuteNonQuery();
        }

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
