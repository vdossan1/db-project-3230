﻿using System.Data;
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
            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            string query = "INSERT INTO nurse (first_name, last_name, date_of_birth, sex, address_line1, address_line2, city, state, zip_code, phone_number, ssn, username) " +
                           "VALUES (@FirstName, @LastName, @DateOfBirth, @Sex, @Address1, @Address2, @City, @State, @ZipCode, @PhoneNumber, @Ssn, @Username)";

            using MySqlCommand command = new MySqlCommand(query, connection);

            AddAllNurseParamsToCommand(newNurse, command);

            command.ExecuteNonQuery();
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

            using var reader = command.ExecuteReader();

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

            while (reader.Read())
            {
                nurseList.Add(
                    CreateNurse(
                        reader, firstNameOrdinal, lastNameOrdinal, dateOfBirthOrdinal, gender,
                        addressOneOrdinal, addressTwoOrdinal, cityOrdinal, stateOrdinal, zipCodeOrdinal,
                        phoneNumberOrdinal, ssnOrdinal, usernameOrdinal
                    ));
            }

            return nurseList;
		}

        private static void AddAllNurseParamsToCommand(Nurse nurse, MySqlCommand command)
        {
            command.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = nurse.FirstName;
            command.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = nurse.LastName;
            command.Parameters.Add("@DateOfBirth", MySqlDbType.Date).Value = nurse.DateOfBirth;
            command.Parameters.Add("@Sex", MySqlDbType.VarChar).Value = nurse.Sex;
            command.Parameters.Add("@Address1", MySqlDbType.VarChar).Value = nurse.Address1;
            command.Parameters.Add("@Address2", MySqlDbType.VarChar).Value = nurse.Address2;
            command.Parameters.Add("@City", MySqlDbType.VarChar).Value = nurse.City;
            command.Parameters.Add("@State", MySqlDbType.VarChar).Value = nurse.State;
            command.Parameters.Add("@ZipCode", MySqlDbType.VarChar).Value = nurse.ZipCode;
            command.Parameters.Add("@PhoneNumber", MySqlDbType.VarChar).Value = nurse.PhoneNumber;
            command.Parameters.Add("@Ssn", MySqlDbType.VarChar).Value = nurse.Ssn;
            command.Parameters.Add("@Username", MySqlDbType.VarChar).Value = nurse.Username;
        }

        private static Nurse CreateNurse(MySqlDataReader reader, int firstNameOrdinal, int lastNameOrdinal,
            int dateOfBirthOrdinal, int gender, int addressOneOrdinal, int addressTwoOrdinal, int cityOrdinal,
            int stateOrdinal, int zipCodeOrdinal, int phoneNumberOrdinal, int ssnOrdinal, int usernameOrdinal)
        {
            return new Nurse
            (
                reader.GetFieldValue<string>(firstNameOrdinal),
                reader.GetFieldValue<string>(lastNameOrdinal),
                reader.GetDateTime(dateOfBirthOrdinal),
                reader.GetFieldValue<string>(gender),
                reader.GetFieldValue<string>(addressOneOrdinal),
                reader.GetFieldValue<string>(addressTwoOrdinal),
                reader.GetFieldValue<string>(cityOrdinal),
                reader.GetFieldValue<string>(stateOrdinal),
                reader.GetFieldValue<string>(zipCodeOrdinal),
                reader.GetFieldValue<string>(phoneNumberOrdinal),
                reader.GetFieldValue<string>(ssnOrdinal),
                reader.GetFieldValue<string>(usernameOrdinal)
            );
        }
    }
}
