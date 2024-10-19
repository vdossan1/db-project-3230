using System.Data;
using HealthCareApp.model;
using MySql.Data.MySqlClient;

namespace HealthCareApp.DAL
{
    public class NurseDal
    {
	    public static void RegisterNurse(Nurse newNurse)
	    {
		    throw new NotImplementedException();
	    }

	    public static List<Nurse> GetAllNurses()
	    {
		    var nurseList = new List<Nurse>();

		    using var connection = new MySqlConnection(Connection.ConnectionString());
		    connection.Open();

		    var query = "select * from nurse";

		    using MySqlCommand command = new MySqlCommand(query, connection);

		    using var adapter = new MySqlDataAdapter(query, connection);

		    var table = new DataTable();
		    adapter.Fill(table);

		    if (table.Rows.Count > 0)
		    {
			    nurseList = (from row in table.AsEnumerable()

				    select new Nurse(
					    row.Field<int>("nurse_id"),
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
					    row.Field<string>("username")
				    )).ToList();

		    }

		    return nurseList;
	    }
	}
}
