using HealthCareApp.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace HealthCareApp.DAL
{
	public class AdminDal
	{
		#region Methods

		/// <summary>
		///     Generates a report of visits within a specific date range.
		/// </summary>
		/// <param name="startDate">The start date of the range for the report.</param>
		/// <param name="endDate">The end date of the range for the report.</param>
		/// <returns>A list of reports containing visit details and related lab test results.</returns>
		public static List<Report> GenerateReport(DateTime startDate, DateTime endDate)
		{
			var reports = new List<Report>();

			// Query to get visits with relevant details from patient, doctor, and nurse
			var query = @"
            SELECT v.visit_id, a.appointment_date, a.patient_id, a.doctor_id, v.nurse_id, 
                   p.first_name AS patient_first_name, p.last_name AS patient_last_name, 
                   d.first_name AS doctor_first_name, d.last_name AS doctor_last_name, 
                   n.first_name AS nurse_first_name, n.last_name AS nurse_last_name
            FROM visit v
            JOIN appointment a ON v.appointment_id = a.appointment_id
            JOIN patient p ON a.patient_id = p.patient_id
            JOIN doctor d ON a.doctor_id = d.doctor_id
            JOIN nurse n ON v.nurse_id = n.nurse_id
            WHERE a.appointment_date BETWEEN @StartDate AND @EndDate
            ORDER BY a.appointment_date, p.last_name;
            ";

			using var connection = new MySqlConnection(Connection.ConnectionString());
			connection.Open();

			using var command = new MySqlCommand(query, connection);
			command.Parameters.AddWithValue("@StartDate", startDate);
			command.Parameters.AddWithValue("@EndDate", endDate);

			using var reader = command.ExecuteReader();

			while (reader.Read())
			{
				var report = CreateReportObj(reader);
				reports.Add(report);
			}

			return reports;
		}

		/// <summary>
		/// Executes a SQL query with parameters and returns the result as a DataTable.
		/// </summary>
		/// <param name="query">The SQL query string.</param>
		/// <param name="parameters">A dictionary of parameter names and their values.</param>
		/// <returns>A DataTable containing the result set.</returns>
		public static DataTable ExecuteQuery(string query, Dictionary<string, object> parameters)
		{
			var resultTable = new DataTable();

			using var connection = new MySqlConnection(Connection.ConnectionString());
			connection.Open();

			using var command = new MySqlCommand(query, connection);

			if (parameters != null)
			{
				foreach (var param in parameters)
				{
					command.Parameters.AddWithValue(param.Key, param.Value);
				}
			}

			using var adapter = new MySqlDataAdapter(command);
			adapter.Fill(resultTable);

			return resultTable;
		}

		private static Report CreateReportObj(MySqlDataReader reader)
		{
			var visitIdOrdinal = reader.GetOrdinal("visit_id");
			var visitDateOrdinal = reader.GetOrdinal("appointment_date");
			var patientIdOrdinal = reader.GetOrdinal("patient_id");
			var doctorIdOrdinal = reader.GetOrdinal("doctor_id");
			var nurseIdOrdinal = reader.GetOrdinal("nurse_id");

			var newReport = new Report(
				reader.GetInt32(visitIdOrdinal),
				reader.GetDateTime(visitDateOrdinal),
				reader.GetInt32(patientIdOrdinal),
				reader.GetInt32(nurseIdOrdinal),
				reader.GetInt32(doctorIdOrdinal));

			newReport.PatientName = $"{reader.GetString("patient_first_name")} {reader.GetString("patient_last_name")}";
			newReport.DoctorName = $"{reader.GetString("doctor_first_name")} {reader.GetString("doctor_last_name")}";
			newReport.NurseName = $"{reader.GetString("nurse_first_name")} {reader.GetString("nurse_last_name")}";

			newReport.LabTests = LabTestDal.GetAllLabTestsForVisit(newReport.VisitId);
			newReport.LabTestResults = new List<LabTestResult>(LabTestResultDal.GetAllLabTestResultsForVisit(newReport.VisitId));

			return newReport;
		}

		#endregion
	}
}
