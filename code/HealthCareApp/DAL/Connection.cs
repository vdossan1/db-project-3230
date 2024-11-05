using MySql.Data.MySqlClient;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.DAL;

/// <summary>
///     Provides methods for creating a connection string for a MySQL database.
/// </summary>
public static class Connection
{
    #region Methods

    /// <summary>
    ///     Builds and returns a MySQL connection string based on predefined parameters.
    /// </summary>
    /// <returns>A string representing the MySQL connection string.</returns>
    public static string ConnectionString()
    {
        var builder = new MySqlConnectionStringBuilder
        {
            Server = "cs-dblab01.uwg.westga.edu",
            Database = "cs3230f24f",
            UserID = "cs3230f24f",
            Password = "iJ0E*3y+],3-b;lmo5Lt",
            Port = 3306
        };

        return builder.ToString();
    }

    #endregion
}