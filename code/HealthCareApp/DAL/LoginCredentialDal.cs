using MySql.Data.MySqlClient;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.DAL
{
	/// <summary>
	/// Provides data access methods for user authentication and retrieval of user full names.
	/// </summary>
	public class LoginCredentialDal
	{
		/// <summary>
		/// Authenticates a user based on the provided username and password.
		/// </summary>
		/// <param name="username">The username of the user attempting to log in.</param>
		/// <param name="password">The password of the user attempting to log in.</param>
		/// <returns><c>true</c> if the user is successfully authenticated; otherwise, <c>false</c>.</returns>
		public static bool AuthenticateUser(string username, string password)
		{
			using var connection = new MySqlConnection(Connection.ConnectionString());
			connection.Open();

			var query = "select count(*) from login_credential where username = @username and password = @password " +
						"and username in (select username from nurse union select username from administrator)";

			using MySqlCommand command = new MySqlCommand(query, connection);

			command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
			command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

			var count = Convert.ToInt32(command.ExecuteScalar());

			return count == 1;
		}

		/// <summary>
		/// Retrieves the full name of a user based on their username.
		/// </summary>
		/// <param name="username">The username of the user whose full name is to be retrieved.</param>
		/// <returns>The full name of the user, or <c>null</c> if no user is found.</returns>
		public static string GetFullName(string username)
		{
			using var connection = new MySqlConnection(Connection.ConnectionString());
			connection.Open();

			var query = "select CONCAT(first_name, ' ' ,last_name) from nurse where username = @username " +
						"union select CONCAT(first_name, ' ' ,last_name) from administrator where username = @username";

			using MySqlCommand command = new MySqlCommand(query, connection);

			command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;

			string fullName = command.ExecuteScalar() as string ?? string.Empty;

			return fullName;
		}
	}

}
