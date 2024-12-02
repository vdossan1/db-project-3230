namespace HealthCareApp.view
{
	public partial class AdminControl : UserControl
	{
		private AdminSQLControl adminSQLControl;
		private AdminVisitReportControl adminVisitReportControl;

		private UserControl activeControl;

		public AdminControl()
		{
			this.InitializeComponent();
			this.adminVisitReportControl = new AdminVisitReportControl();
			this.adminSQLControl = new AdminSQLControl();
			this.adminContentPanel.Controls.Add(this.adminVisitReportControl);
			this.activeControl = this.adminVisitReportControl;
		}

		private void visitReportButton_Click(object sender, EventArgs e)
		{
			this.adminContentPanel.Controls.Clear();
			this.adminContentPanel.Controls.Add(this.adminVisitReportControl);
			this.activeControl = this.adminVisitReportControl;
		}

		private void sqlButton_Click(object sender, EventArgs e)
		{
			this.adminContentPanel.Controls.Clear();
			this.adminContentPanel.Controls.Add(this.adminSQLControl);
			this.activeControl = this.adminSQLControl;
		}

		private void registerUserButton_Click(object sender, EventArgs e)
		{
			
		}
	}
}
