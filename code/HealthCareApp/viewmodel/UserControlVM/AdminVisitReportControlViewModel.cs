using HealthCareApp.DAL;
using HealthCareApp.model;

namespace HealthCareApp.viewmodel.UserControlVM
{
	public class AdminVisitReportControlViewModel
	{
		/// <summary>
		///     Gets the Query Result.
		/// </summary>
		public QueryResult QueryResult { get; set; }

		/// <summary>
		///     Gets the list of reports.
		/// </summary>
		public List<Report> Reports { get; set; }

		/// <summary>
		///     Gets the list of test results for a selected report.
		/// </summary>
		public List<LabTestResult> LabTestResults { get; set; }

		/// <summary>
		///     Gets the selected report.
		/// </summary>
		public Report SelectedReport { get; set; }

		/// <summary>
		///     Initializes a new instance of the <see cref="AdminVisitReportControlViewModel" /> class.
		/// </summary>
		public AdminVisitReportControlViewModel()
		{
			this.Reports = new List<Report>();
			this.LabTestResults = new List<LabTestResult>();
		}

		/// <summary>
		///     Generates the Reports list with all reports from the database.
		/// </summary>
		public void GenerateReport(DateTime startDate, DateTime endDate)
		{
			var queryResult = AdminDal.GenerateReport(startDate, endDate);
			this.Reports = queryResult.Reports;
			this.QueryResult = queryResult;
		}

		/// <summary>
		///     Populates the test result view with the test results linked to the report from the database.
		/// </summary>
		public void PopulateTestResults()
		{
			this.LabTestResults = LabTestResultDal.GetAllLabTestResultsForVisit(this.SelectedReport.VisitId);
		}

		/// <summary>
		///     Clears the Reports list.
		/// </summary>
		public void ClearReport()
		{
			this.LabTestResults.Clear();
			this.Reports.Clear();
			this.SelectedReport = null;
		}
	}
}
