namespace HealthCareApp.view
{
	public partial class AdminControl : UserControl
	{
		private AdminDashboardControl adminDashboardControl;
		private AdminSQLControl adminSQLControl;
		private AdminVisitReportControl adminVisitReportControl;

		private UserControl activeControl;

		public AdminControl()
		{
			this.InitializeComponent();
			this.adminDashboardControl = new AdminDashboardControl();
			this.adminSQLControl = new AdminSQLControl();
			this.adminVisitReportControl = new AdminVisitReportControl();
			this.adminContentPanel.Controls.Add(this.adminDashboardControl);
			this.activeControl = this.adminDashboardControl;
		}

		private void dashboardButton_Click(object sender, EventArgs e)
		{
			this.adminContentPanel.Controls.Clear();
			this.adminContentPanel.Controls.Add(this.adminDashboardControl);
			this.activeControl = this.adminDashboardControl;
		}

		private void sqlButton_Click(object sender, EventArgs e)
		{
			this.adminContentPanel.Controls.Clear();
			this.adminContentPanel.Controls.Add(this.adminSQLControl);
			this.activeControl = this.adminSQLControl;
		}

		private void visitReportButton_Click(object sender, EventArgs e)
		{
			this.adminContentPanel.Controls.Clear();
			this.adminContentPanel.Controls.Add(this.adminVisitReportControl);
			this.activeControl = this.adminVisitReportControl;
		}
	}
}
