using System.Data;

namespace HealthCareApp.model
{
	public class QueryResult
	{
		#region Properties

		public int RowCount { get; set; }
		public DataTable QueryData { get; set; }
		public List<Report> Reports { get; set; }

		#endregion

		#region Constructors

		public QueryResult(int rowCount, DataTable queryData)
		{
			this.RowCount = rowCount;
			this.QueryData = queryData;
		}

		#endregion
	}
}
