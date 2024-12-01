using HealthCareApp.DAL;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System;
using System.Data;

namespace HealthCareApp.viewmodel.UserControlVM
{
	public class AdminSQLControlViewModel
	{
		public DataTable QueryResults { get; set; }

		public AdminSQLControlViewModel()
		{
			this.QueryResults = new DataTable();
		}

		/// <summary>
		///     Generates the Reports list with all reports from the database.
		/// </summary>
		public void ExecuteQuery(string query)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(query))
				{
					MessageBox.Show("Please enter a valid SQL query.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				var dataTable = AdminDal.ExecuteQuery(query, null);
				this.QueryResults = dataTable;

				MessageBox.Show($"Query executed successfully. {dataTable.Rows.Count} rows returned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
