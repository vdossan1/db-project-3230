using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HealthCareApp.model;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HealthCareApp.DAL
{
    public class PatientDal
    {
        public List<Patient> GetPatients()
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
                        row.Field<string>("address1"),
                        row.Field<string>("address2"),
                        row.Field<string>("city"),
                        row.Field<string>("state"),
                        row.Field<string>("zip_code"),
                        row.Field<string>("phone_number"),
                        row.Field<bool>("status")
                    )).ToList();

            }

            return patientList;
        }
    }
}
