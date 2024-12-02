using System.Diagnostics;
using System.Text;
using HealthCareApp.model;
using MySql.Data.MySqlClient;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.DAL;

/// <summary>
///     Provides data access methods for managing user records in the database.
/// </summary>
public class NurseDal
{
	#region Methods

	/// <summary>
	///     Registers a new nurse in the database.
	/// </summary>
	/// <param name="newNurse">The nurse object containing information about the nurse to be registered.</param>
	public static int RegisterNurse(User newNurse)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString());
        connection.Open();

        var query =
			"INSERT INTO nurse (first_name, last_name, date_of_birth, sex, address_line1, address_line2, city, state, zip_code, phone_number, ssn, username) " +
            "VALUES (@FirstName, @LastName, @DateOfBirth, @Sex, @Address1, @Address2, @City, @State, @ZipCode, @PhoneNumber, @Ssn, @Username)";

        using var command = new MySqlCommand(query, connection);

        AddAllNurseParamsToCommand(newNurse, command);

        return command.ExecuteNonQuery();
    }

	/// <summary>
	///     Edits an existing nurse's information in the database.
	/// </summary>
	/// <param name="nurse">The nurse object containing updated information about the nurse.</param>
	public static int EditNurse(User nurse)
    {
	    using var connection = new MySqlConnection(Connection.ConnectionString());
	    connection.Open();

	    var query =
		    "UPDATE patient SET first_name = @FirstName, last_name = @LastName, date_of_birth = @DateOfBirth, " +
		    "sex = @Sex, address_line1 = @Address1, address_line2 = @Address2, city = @City, state = @State, " +
		    "zip_code = @ZipCode, phone_number = @PhoneNumber, status = @Status " +
		    "WHERE patient_id = @NurseId";

	    using var command = new MySqlCommand(query, connection);

	    AddAllNurseParamsToCommand(nurse, command);
	    command.Parameters.Add("@NurseId", MySqlDbType.Int32).Value = nurse.UserId;

	    return command.ExecuteNonQuery();
    }

	/// <summary>
	///     Generates a new username for a user in the database.
	/// </summary>
	/// <param name="firstName">The user's first name.</param>
	/// <param name="lastName">The user's last name.</param>
	public static string GenerateUsername(string firstName, string lastName)
    {
	    using var connection = new MySqlConnection(Connection.ConnectionString());
	    connection.Open();

	    var query =
		    "SELECT MAX(CAST(SUBSTRING(username, LENGTH(@Prefix) + 1) AS UNSIGNED)) " +
		    "FROM login_credential WHERE first_name = @FirstName AND last_name = @LastName AND username LIKE @UsernamePrefix";

	    using var command = new MySqlCommand(query, connection);

	    string usernamePrefix = firstName.Substring(0, 2).ToLower() + lastName.ToLower();

	    command.Parameters.AddWithValue("@FirstName", firstName);
	    command.Parameters.AddWithValue("@LastName", lastName);
	    command.Parameters.AddWithValue("@Prefix", usernamePrefix);
	    command.Parameters.AddWithValue("@UsernamePrefix", usernamePrefix + "%");

	    var result = command.ExecuteScalar();

	    int nextNumber = 1;
	    if (result != DBNull.Value)
	    {
		    nextNumber = Convert.ToInt32(result) + 1;
	    }

	    string newUsername = usernamePrefix + nextNumber.ToString("D3");

	    return newUsername;
    }


	/// <summary>
	///     Retrieves the ID of a user based on their username.
	/// </summary>
	/// <param name="nurseUsername">The username of the user.</param>
	/// <returns>The ID of the user if found, otherwise 0.</returns>
	public static int GetIdFromUsername(string nurseUsername)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString());
        connection.Open();

        var query = "select nurse_id from user where username = @Username";

        using var command = new MySqlCommand(query, connection);
        command.Parameters.Add("@Username", MySqlDbType.VarChar).Value = nurseUsername;

        using var reader = command.ExecuteReader();

        var nurseId = 0;

        if (reader.Read())
        {
            var idOrdinal = reader.GetOrdinal("nurse_id");
            nurseId = reader.GetInt32(idOrdinal);
        }

        return nurseId;
    }

    /// <summary>
    ///     Finds a user's full name by their ID in the database.
    /// </summary>
    /// <param name="nurseId">The ID of the user full name to find.</param>
    public static string GetNurseFullNameById(int nurseId)
    {
	    using var connection = new MySqlConnection(Connection.ConnectionString());
	    connection.Open();

	    var query = "SELECT CONCAT(first_name, ' ', last_name) AS full_name FROM user WHERE nurse_id = @UserId";

	    using var command = new MySqlCommand(query, connection);
	    command.Parameters.AddWithValue("@UserId", nurseId);

	    using var reader = command.ExecuteReader();

	    if (reader.Read())
	    {
		    return reader["full_name"].ToString();
	    }

	    return null;
    }

	/// <summary>
	///     Retrieves a list of all nurses from the database.
	/// </summary>
	/// <returns>A list of <see cref="User" /> objects representing all nurses in the database.</returns>
	public static List<User> GetAllNurses()
    {
        var nurseList = new List<User>();

        using var connection = new MySqlConnection(Connection.ConnectionString());
        connection.Open();

        var query = "select * from nurse";

        using var command = new MySqlCommand(query, connection);

        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            nurseList.Add(
	            CreateNurse(reader));
        }

        return nurseList;
    }

    /// <summary>
    ///     Retrieves all nurses that match the specified search criteria.
    /// </summary>
    /// <param name="firstName">The first name of the user to search for.</param>
    /// <param name="lastName">The last name of the user to search for.</param>
    /// <param name="dateOfBirth">The date of birth of the user to search for.</param>
    /// <returns>A list of <see cref="User" /> objects representing the matching nurses.</returns>
    public static List<User> GetAllNurseWithParams(string firstName, string lastName, DateTime? dateOfBirth)
    {
        var nurseList = new List<User>();
        var paramsCount = 0;
        var queryBuilder = new StringBuilder("select * from user WHERE");
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

        if (queryBuilder.Equals("select * from user WHERE;"))
        {
            queryBuilder = new StringBuilder("select * from user;");
        }

        using var command = new MySqlCommand(queryBuilder.ToString(), connection);
        command.Parameters.AddRange(parameters.ToArray());

        Debug.WriteLine($"Query: {queryBuilder} FirstName: {firstName} LastName: {lastName} DoB{dateOfBirth}");
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            nurseList.Add(
                CreateNurse(reader));
        }

        return nurseList;
    }

    private static User CreateNurse(MySqlDataReader reader)
    {
        var idOrdinal = reader.GetOrdinal("nurse_id");
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
        var usernameOrdinal = reader.GetOrdinal("username");

        var newNurse = new User
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

        newNurse.UserId = reader.GetInt32(idOrdinal);
		newNurse.Username = reader.GetString(usernameOrdinal);
		return newNurse;
    }

    private static void AddAllNurseParamsToCommand(User user, MySqlCommand command)
    {
        command.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = user.FirstName;
        command.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = user.LastName;
        command.Parameters.Add("@DateOfBirth", MySqlDbType.Date).Value = user.DateOfBirth;
        command.Parameters.Add("@Sex", MySqlDbType.VarChar).Value = user.Sex;
        command.Parameters.Add("@Address1", MySqlDbType.VarChar).Value = user.Address1;
        command.Parameters.Add("@Address2", MySqlDbType.VarChar).Value = user.Address2;
        command.Parameters.Add("@City", MySqlDbType.VarChar).Value = user.City;
        command.Parameters.Add("@State", MySqlDbType.VarChar).Value = user.State;
        command.Parameters.Add("@ZipCode", MySqlDbType.VarChar).Value = user.ZipCode;
        command.Parameters.Add("@PhoneNumber", MySqlDbType.VarChar).Value = user.PhoneNumber;
        command.Parameters.Add("@Ssn", MySqlDbType.VarChar).Value = user.Ssn;
        command.Parameters.Add("@Username", MySqlDbType.VarChar).Value = user.Username;
    }

    #endregion
}