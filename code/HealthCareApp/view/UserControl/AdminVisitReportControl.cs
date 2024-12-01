using HealthCareApp.model;
using HealthCareApp.viewmodel.UserControlVM;

namespace HealthCareApp.view
{
	public partial class AdminVisitReportControl : UserControl
	{
		private AdminVisitReportControlViewModel adminVisitReportControlViewModel;

		public AdminVisitReportControl()
		{
			this.InitializeComponent();
			this.SetUpPage();
		}

		private void GenerateReportButton_Click(object sender, EventArgs e)
		{
			var startDate = this.startDatePicker.Value.Date;
			var endDate = this.endDatePicker.Value.Date;
			this.setTimeSpanLabel(startDate, endDate);
			this.adminVisitReportControlViewModel.GenerateReport(startDate, endDate);
			this.reportDataGridView.DataSource = this.adminVisitReportControlViewModel.Reports;
			this.setRowCountLabel();
		}

		private void ClearReportButton_Click(object sender, EventArgs e)
		{
			this.startDatePicker.ResetText();
			this.endDatePicker.ResetText();
			this.reportDataGridView.DataSource = null;
			this.labTestResultsDataGridView.DataSource = null;
			this.adminVisitReportControlViewModel.ClearReport();
			this.clearTimeSpanLabel();
			this.clearRowCountLabel();
		}

		private void ReportDataGridView_SelectionChanged(object? sender, EventArgs e)
		{
			if (this.reportDataGridView.SelectedRows.Count > 0)
			{
				var selectedReport = (Report)this.reportDataGridView.SelectedRows[0].DataBoundItem;
				this.adminVisitReportControlViewModel.SelectedReport = selectedReport;
				this.adminVisitReportControlViewModel.PopulateTestResults();
				this.labTestResultsDataGridView.DataSource = this.adminVisitReportControlViewModel.LabTestResults;
				this.setupLabTestResultsGridView();
			}
			else
			{
				this.adminVisitReportControlViewModel.SelectedReport = null;
				this.labTestResultsDataGridView.DataSource = null;
			}
		}

		private void setRowCountLabel()
		{
			var rowCount = this.adminVisitReportControlViewModel.QueryResult.RowCount;
			this.rowsLabel.Text = $"Result Row Count: {rowCount}";
		}

		private void clearRowCountLabel()
		{
			this.rowsLabel.Text = $"Result Row Count:";
		}

		private void setTimeSpanLabel(DateTime startDate, DateTime endDate)
		{
			this.timeSpanLabel.Text = $"Time Span: {startDate.ToShortDateString()} - {endDate.ToShortDateString()}";
		}

		private void clearTimeSpanLabel()
		{
			this.timeSpanLabel.Text = $"Time Span:";
		}

		private void SetUpPage()
		{
			// Set up the data grid view
			this.adminVisitReportControlViewModel = new AdminVisitReportControlViewModel();
			this.reportDataGridView.DataSource = this.adminVisitReportControlViewModel.Reports;
			this.reportDataGridView.SelectionChanged += this.ReportDataGridView_SelectionChanged;
		}

		private void setupLabTestResultsGridView()
		{
			this.labTestResultsDataGridView.Columns["ResultId"].Visible = false;
			this.labTestResultsDataGridView.Columns["VisitId"].Visible = false;
			this.labTestResultsDataGridView.Columns["TestCode"].Visible = false;

			this.labTestResultsDataGridView.Columns["TestName"].DisplayIndex = 0;
		}
	}
}
