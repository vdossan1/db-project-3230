using HealthCareApp.DAL;
using HealthCareApp.model;
using System.ComponentModel;

namespace HealthCareApp.viewmodel.UserControlVM
{
	public class AdminVisitReportControlViewModel
	{
		/// <summary>
		///     Gets the list of reports.
		/// </summary>
		public List<Report> Reports { get; set; }

		/// <summary>
		///     Gets the list of test results for a selected report.
		/// </summary>
		public BindingList<LabTestResult> LabTestResults { get; set; }

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
			this.LabTestResults = new BindingList<LabTestResult>();
		}

		/// <summary>
		///     Generates the Reports list with all reports from the database.
		/// </summary>
		public void GenerateReport(DateTime startDate, DateTime endDate)
		{
			this.Reports = AdminDal.GenerateReport(startDate, endDate);
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
