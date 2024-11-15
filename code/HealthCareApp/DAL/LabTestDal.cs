using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using HealthCareApp.model;
using MySql.Data.MySqlClient;

namespace HealthCareApp.DAL
{
    public class LabTestDal
    {
	    public static List<string> GetAllLabTestsForVisit(int visitId)
	    {
		    var labTestList = new List<string>();

		    using var connection = new MySqlConnection(Connection.ConnectionString());
		    connection.Open();

		    var query = "SELECT lab_test.test_name FROM lab_test JOIN lab_test_result ON lab_test.test_code = lab_test_result.test_code " +
		                "WHERE lab_test_result.visit_id = @VisitId";

		    using var command = new MySqlCommand(query, connection);
		    command.Parameters.AddWithValue("@VisitId", visitId);

		    using var reader = command.ExecuteReader();

		    var testNameOrdinal = reader.GetOrdinal("test_name");

			while (reader.Read())
			{
				labTestList.Add(reader.GetString(testNameOrdinal));

			}

		    return labTestList;
	    }

		public static BindingList<string> GetAllTestsName()
        {
            var labTestList = new BindingList<string>();

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            var query = "SELECT test_name FROM lab_test";

            using var command = new MySqlCommand(query, connection);

            using var reader = command.ExecuteReader();

            var testNameOrdinal = reader.GetOrdinal("test_name");

            while (reader.Read())
            {
                labTestList.Add(reader.GetString(testNameOrdinal));
            }

            return labTestList;
        }

		public static int GetLabTestCodeByTestName(string testName)
		{
			using var connection = new MySqlConnection(Connection.ConnectionString());
			connection.Open();

			var query = "SELECT test_code FROM lab_test WHERE test_name = @TestName";

			using var command = new MySqlCommand(query, connection);
			command.Parameters.AddWithValue("@TestName", testName);

			using var reader = command.ExecuteReader();

			var testCodeOrdinal = reader.GetOrdinal("test_code");

			while (reader.Read())
			{
				return reader.GetInt32(testCodeOrdinal);
			}

			return 0;
		}

		public static LabTest GetLabTestByTestCode(int testCode)
		{
			using var connection = new MySqlConnection(Connection.ConnectionString());
			connection.Open();

			var query = "SELECT * FROM lab_test WHERE test_code = @TestCode";

			using var command = new MySqlCommand(query, connection);
			command.Parameters.AddWithValue("@TestCode", testCode);

			using var reader = command.ExecuteReader();

			while (reader.Read())
			{
				return CreateLabTestObj(reader);
			}

			return null;
		}

		private static LabTest CreateLabTestObj(MySqlDataReader reader)
        {
            var testCodeOrdinal = reader.GetOrdinal("test_code");
            var testNameOrdinal = reader.GetOrdinal("test_name");
            var highValueOrdinal = reader.GetOrdinal("high_value");
            var lowValueOrdinal = reader.GetOrdinal("low_value");
            var unitOrdinal= reader.GetOrdinal("unit_of_measure");

            var newLabTest = new LabTest
            (
                reader.GetInt32(testCodeOrdinal),
                reader.GetString(testNameOrdinal),
                reader.IsDBNull(highValueOrdinal) ? 0 : reader.GetDecimal(highValueOrdinal),
                reader.IsDBNull(lowValueOrdinal) ? 0 : reader.GetDecimal(lowValueOrdinal),
                reader.GetString(unitOrdinal)
            );
            
            return newLabTest;
        }

        private static void AddAllLabTestParamsToCommand(LabTest lasTest, MySqlCommand command)
        {
            command.Parameters.Add("@TestCode", MySqlDbType.VarChar).Value = lasTest.TestCode;
            command.Parameters.Add("@TestName", MySqlDbType.VarChar).Value = lasTest.TestName;
            command.Parameters.Add("@HighValue", MySqlDbType.Date).Value = lasTest.HighValue;
            command.Parameters.Add("@LowValue", MySqlDbType.VarChar).Value = lasTest.LowValue;
            command.Parameters.Add("@UnitOfMeasure", MySqlDbType.VarChar).Value = lasTest.Unit;
        }
    }
}
