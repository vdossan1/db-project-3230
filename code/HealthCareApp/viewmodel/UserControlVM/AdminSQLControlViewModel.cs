using HealthCareApp.DAL;
using System.Data;

namespace HealthCareApp.viewmodel.UserControlVM
{
	public class AdminSQLControlViewModel
	{
		public DataTable QueryResults { get; set; } = new();

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

				string queryType = query.Trim().Split(' ')[0].ToUpperInvariant();
				if (queryType == "UPDATE" || queryType == "INSERT" || queryType == "DELETE")
				{
					int rowsAffected = AdminDal.ExecuteNonQuery(query, null);
					MessageBox.Show($"Query executed successfully. {rowsAffected} rows affected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.QueryResults = null;
				}
				else
				{
					var dataTable = AdminDal.ExecuteQuery(query, null);
					this.QueryResults = dataTable;

					MessageBox.Show($"Query executed successfully. {dataTable.Rows.Count} rows returned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
}
