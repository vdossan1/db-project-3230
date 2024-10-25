using System.Data;
using HealthCareApp.model;
using MySql.Data.MySqlClient;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.DAL
{
	/// <summary>
	/// Provides data access methods for the Doctor entity.
	/// </summary>
	public class DoctorDal
	{
		/// <summary>
		/// Registers a new doctor in the database.
		/// </summary>
		/// <param name="newDoctor">The <see cref="Doctor"/> object containing the doctor's details.</param>
		/// <exception cref="NotImplementedException">This method is not implemented yet.</exception>
		public static void RegisterDoctor(Doctor newDoctor)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Retrieves all doctors from the database.
		/// </summary>
		/// <returns>A list of <see cref="Doctor"/> objects representing all doctors in the database.</returns>
		public static List<Doctor> GetAllDoctors()
		{
			var doctorList = new List<Doctor>();

			using var connection = new MySqlConnection(Connection.ConnectionString());
			connection.Open();

			var query = "select * from doctor";

			using MySqlCommand command = new MySqlCommand(query, connection);

			using var adapter = new MySqlDataAdapter(query, connection);

			var table = new DataTable();
			adapter.Fill(table);

			if (table.Rows.Count > 0)
			{
				doctorList = (from row in table.AsEnumerable()
					select new Doctor(
						row.Field<int>("doctor_id"),
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
						row.Field<string>("ssn")
					)).ToList();
			}

			return doctorList;
		}
	}

}
