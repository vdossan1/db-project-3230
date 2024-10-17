using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareApp.DAL
{
    public static class Connection
    {
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
    }
}
