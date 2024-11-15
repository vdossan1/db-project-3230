using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareApp.model;
using MySql.Data.MySqlClient;

namespace HealthCareApp.DAL
{
    public class LabTestDal
    {
        public static List<string> GetAllTestsName()
        {
            var labTestList = new List<string>();

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            var query = "select test_name from lab_test";

            using var command = new MySqlCommand(query, connection);

            using var reader = command.ExecuteReader();

            var testNameOrdinal = reader.GetOrdinal("test_name");

            while (reader.Read())
            {
                labTestList.Add(reader.GetString(testNameOrdinal));
            }

            return labTestList;
        }

        private static LabTest CreateLabTestObj(MySqlDataReader reader)
        {
            var testCodeOrdinal = reader.GetOrdinal("test_code");
            var testNameOrdinal = reader.GetOrdinal("test_name");
            var highValueOrdinal = reader.GetOrdinal("high_value");
            var lowValueOrdinal = reader.GetOrdinal("low_value");
            var unitOfMeasureOrdinal= reader.GetOrdinal("unit_of_measure");

            var newLabTest = new LabTest
            (
                reader.GetInt32(testCodeOrdinal),
                reader.GetString(testNameOrdinal),
                reader.IsDBNull(highValueOrdinal) ? 0 : reader.GetDecimal(highValueOrdinal),
                reader.IsDBNull(lowValueOrdinal) ? 0 : reader.GetDecimal(lowValueOrdinal),
                reader.GetString(unitOfMeasureOrdinal)
            );
            
            return newLabTest;
        }

        private static void AddAllPatientParamsToCommand(LabTest lasTest, MySqlCommand command)
        {
            command.Parameters.Add("@TestCode", MySqlDbType.VarChar).Value = lasTest.TestCode;
            command.Parameters.Add("@TestName", MySqlDbType.VarChar).Value = lasTest.TestName;
            command.Parameters.Add("@HighValue", MySqlDbType.Date).Value = lasTest.HighValue;
            command.Parameters.Add("@LowValue", MySqlDbType.VarChar).Value = lasTest.LowValue;
            command.Parameters.Add("@UnitOfMeasure", MySqlDbType.VarChar).Value = lasTest.Unit;
        }
    }
}
