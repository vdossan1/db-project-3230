using HealthCareApp.DAL;
using System.Data;

namespace HealthCareApp.viewmodel.UserControlVM
{
	public class AdminSQLControlViewModel
	{
		public DataTable QueryResults { get; set; } = new();

		/// <summary>
		/// Generates the Reports list with all reports from the database.
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

				var queryResult = AdminDal.ExecuteQuery(query);

				if (queryResult.QueryData != null)
				{
					this.QueryResults = queryResult.QueryData;
					MessageBox.Show($"Query executed successfully. {queryResult.RowCount} rows returned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					this.QueryResults = null;
					MessageBox.Show($"Query executed successfully. {queryResult.RowCount} rows affected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


	}
}
