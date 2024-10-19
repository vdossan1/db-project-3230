using System.Data;
using HealthCareApp.model;
using MySql.Data.MySqlClient;

namespace HealthCareApp.DAL
{
    public class PatientDal
    {
        public static void RegisterPatient(Patient newPatient)
        {
            throw new NotImplementedException();
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
                        row.Field<int>("patient_id"),
                        row.Field<string>("first_name"),
                        row.Field<string>("last_name"),
                        row.Field<DateTime>("date_of_birth"),
                        row.Field<string>("gender"),
                        row.Field<string>("address1"),
                        row.Field<string>("address2"),
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
