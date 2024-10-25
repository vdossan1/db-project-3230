using System.Data;
using HealthCareApp.model;
using MySql.Data.MySqlClient;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.DAL
{
	/// <summary>
	/// Provides data access methods for managing nurse records in the database.
	/// </summary>
	public class NurseDal
	{
		/// <summary>
		/// Registers a new nurse in the database.
		/// </summary>
		/// <param name="newNurse">The nurse object containing information about the nurse to be registered.</param>
		/// <exception cref="NotImplementedException">Thrown when the method is not implemented.</exception>
		public static void RegisterNurse(Nurse newNurse)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Retrieves a list of all nurses from the database.
		/// </summary>
		/// <returns>A list of <see cref="Nurse"/> objects representing all nurses in the database.</returns>
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
