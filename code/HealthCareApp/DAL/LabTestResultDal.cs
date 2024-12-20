﻿using HealthCareApp.model;
using MySql.Data.MySqlClient;
using System.ComponentModel;

namespace HealthCareApp.DAL
{
    internal class LabTestResultDal
    {
        /// <summary>
        ///     Edits an existing lab test result in the database.
        /// </summary>
        /// <param name="labTestResult">The lab test result object containing updated information about the test result.</param>
        public static int EditLabTestResult(LabTestResult labTestResult)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            var query =
                "UPDATE lab_test_result SET test_result = @TestResult, result_normality = @ResultNormality, " +
                "date_performed = @DatePerformed, status = @Status " +
                "WHERE result_id = @ResultId";

            using var command = new MySqlCommand(query, connection);

            AddAllLabTestResultParamsToCommand(labTestResult, command);
            command.Parameters.Add("@ResultId", MySqlDbType.Int32).Value = labTestResult.ResultId;

            return command.ExecuteNonQuery();
        }

        /// <summary>
        ///     Creates a new lab test result in the database.
        /// </summary>
        /// <param name="newLabTestResult">The lab test result object containing information about the test result to be registered.</param>
        public static int CreateLabTestResult(LabTestResult newLabTestResult)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            var query =
                "INSERT INTO lab_test_result (visit_id, test_code, test_result, result_normality, date_performed, status) " +
                "VALUES (@VisitId, @TestCode, @TestResult, @ResultNormality, @DatePerformed, @Status)";

            using var command = new MySqlCommand(query, connection);

            AddAllLabTestResultParamsToCommand(newLabTestResult, command);

            return command.ExecuteNonQuery();
        }

        public static BindingList<LabTestResult> GetAllLabTestResultsForVisit(int visitId)
        {
            var labTestResultList = new BindingList<LabTestResult>();

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            var query = "SELECT * FROM lab_test_result WHERE visit_id = @VisitId";

            using var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@VisitId", visitId);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                labTestResultList.Add(
                    CreateLabTestResultObj(reader));
            }

            return labTestResultList;
        }

        private static LabTestResult CreateLabTestResultObj(MySqlDataReader reader)
        {
            var resultIdOrdinal = reader.GetOrdinal("result_id");
            var visitIdOrdinal = reader.GetOrdinal("visit_id");
            var testCodeOrdinal = reader.GetOrdinal("test_code");
            var testResultOrdinal = reader.GetOrdinal("test_result");
            var resultNormalityOrdinal = reader.GetOrdinal("result_normality");
            var datePerformedOrdinal = reader.GetOrdinal("date_performed");
            var statusOrdinal = reader.GetOrdinal("status");

            var newLabTestResult = new LabTestResult
            (
                reader.GetInt32(visitIdOrdinal),
                reader.GetInt32(testCodeOrdinal),
                reader.IsDBNull(testResultOrdinal) ? null : reader.GetString(testResultOrdinal),
                reader.IsDBNull(resultNormalityOrdinal) ? null : reader.GetString(resultNormalityOrdinal),
                reader.IsDBNull(datePerformedOrdinal) ? null : reader.GetDateTime(datePerformedOrdinal),
                reader.GetBoolean(statusOrdinal)
            );

            newLabTestResult.ResultId = reader.GetInt32(resultIdOrdinal);
            return newLabTestResult;
        }

        private static void AddAllLabTestResultParamsToCommand(LabTestResult labTestResult, MySqlCommand command)
        {
            command.Parameters.Add("@VisitId", MySqlDbType.Int32).Value = labTestResult.VisitId;
            command.Parameters.Add("@TestCode", MySqlDbType.Int32).Value = labTestResult.TestCode;
            command.Parameters.Add("@TestResult", MySqlDbType.VarChar).Value = labTestResult.TestResult;
            command.Parameters.Add("@ResultNormality", MySqlDbType.VarChar).Value = labTestResult.ResultNormality;
            command.Parameters.Add("@DatePerformed", MySqlDbType.DateTime).Value = labTestResult.DatePerformed;
            command.Parameters.Add("@Status", MySqlDbType.Bit).Value = labTestResult.Status;
        }
    }
}