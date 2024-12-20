﻿using HealthCareApp.model;
using MySql.Data.MySqlClient;
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
		public static QueryResult GenerateReport(DateTime startDate, DateTime endDate)
		{
			var reports = new List<Report>();

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

			var queryResult = new QueryResult(reports.Count, null)
			{
				Reports = reports
			};

			return queryResult;
		}

		/// <summary>
		/// Executes a SQL query with parameters and returns the result as a QueryResult object.
		/// </summary>
		/// <param name="query">The SQL query string.</param>
		/// <returns>A QueryResult object containing the row count and the result set as a DataTable.</returns>
		public static QueryResult ExecuteQuery(string query)
		{
			var resultTable = new DataTable();
			int rowCount = 0;

			using var connection = new MySqlConnection(Connection.ConnectionString());
			connection.Open();

			using var command = new MySqlCommand(query, connection);

			string queryType = query.Trim().Split(' ')[0].ToUpperInvariant();
			if (queryType == "SELECT")
			{
				using var adapter = new MySqlDataAdapter(command);
				rowCount = adapter.Fill(resultTable);
			}
			else
			{
				rowCount = command.ExecuteNonQuery();
			}

			return new QueryResult(rowCount, queryType == "SELECT" ? resultTable : null);
		}

		/// <summary>
		///     Retrieves a list of all admins from the database.
		/// </summary>
		/// <returns>A list of <see cref="User" /> objects representing all admins in the database.</returns>
		public static List<User> GetAllAdmins()
		{
			var adminList = new List<User>();

			using var connection = new MySqlConnection(Connection.ConnectionString());
			connection.Open();

			var query = "select * from administrator";

			using var command = new MySqlCommand(query, connection);

			using var reader = command.ExecuteReader();

			while (reader.Read())
			{
				adminList.Add(
					CreateAdmin(reader));
			}

			return adminList;
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

		private static User CreateAdmin(MySqlDataReader reader)
		{
			var idOrdinal = reader.GetOrdinal("administrator_id");
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

			var newAdmin = new User
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

			newAdmin.UserId = reader.GetInt32(idOrdinal);
			newAdmin.Username = reader.GetString(usernameOrdinal);
			return newAdmin;
		}

		#endregion
	}
}
