using HealthCareApp.viewmodel.UserControlVM;

namespace HealthCareApp.view
{
	public partial class AdminSQLControl : UserControl
	{
		private readonly AdminSQLControlViewModel adminSQLControlViewModel;

		public AdminSQLControl()
		{
			this.InitializeComponent();
			this.adminSQLControlViewModel = new AdminSQLControlViewModel();
		}

		private void executeQueryButton_Click(object sender, EventArgs e)
		{
			this.adminSQLControlViewModel.ExecuteQuery(this.sqlEntryTextBox.Text);
			this.queryResultGridView.DataSource = this.adminSQLControlViewModel.QueryResults;
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			this.sqlEntryTextBox.Text = "";
			this.queryResultGridView.DataSource = null;
		}
	}
}
