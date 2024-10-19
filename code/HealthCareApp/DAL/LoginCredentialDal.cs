﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareApp.model;
using MySql.Data.MySqlClient;

namespace HealthCareApp.DAL
{
    public class LoginCredentialDal
    {
        public static bool AuthenticateUser(string username, string password)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            var query = "select count(*) from login_credential where username = @username and password = @password";

            using MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.Add("@username", MySqlDbType.VarChar);
            command.Parameters["@username"].Value = username;

            command.Parameters.Add("@password", MySqlDbType.VarChar);
            command.Parameters["@password"].Value = password;

            var count = Convert.ToInt32(command.ExecuteScalar());

            return count == 1;
        }

        public static string GetFullName(string username)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            //TODO query both nurse and admin tables
            var query = "select CONCAT(first_name, ' ' ,last_name) from nurse where username = @username";

            using MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.Add("@username", MySqlDbType.VarChar);
            command.Parameters["@username"].Value = username;

            string fullName = command.ExecuteScalar() as string;

            return fullName;
        }
    }
}
