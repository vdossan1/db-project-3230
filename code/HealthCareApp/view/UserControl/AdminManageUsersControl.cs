// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
using HealthCareApp.model;
using HealthCareApp.viewmodel.UserControlVM;
using static HealthCareApp.view.AdvancedSearchControl;

namespace HealthCareApp.view
{
	/// <summary>
	///     Represents a user control for managing users, allowing users to create, edit, and search for users.
	/// </summary>
	public partial class AdminManageUsersControl : UserControl
	{
		#region Data members

		private UsersControlViewModel usersControlViewModel;

		#endregion

		#region Constructors

		/// <summary>
		///     Initializes a new instance of the <see cref="AdminManageUsersControl" /> class and sets up the data grid and event
		///     handlers.
		/// </summary>
		public AdminManageUsersControl()
		{
			this.InitializeComponent();
			this.SetupPage();
		}

		#endregion

		#region Methods

		private void registerUserBtn_Click(object sender, EventArgs e)
		{
			var manageUserPage = new ManageUserPage();
			manageUserPage.FormClosed += this.RefreshUserList;
			manageUserPage.ShowDialog();
		}

		private void editUserBtn_Click(object sender, EventArgs e)
		{
			if (this.usersDataGridView.SelectedRows.Count > 0)
			{
				var selectedUser = (User)this.usersDataGridView.SelectedRows[0].DataBoundItem;
				var manageUserPage = new ManageUserPage(selectedUser);
				manageUserPage.FormClosed += this.RefreshUserList;
				manageUserPage.ShowDialog();
			}
		}

		private void RefreshUserList(object sender, EventArgs e)
		{
			if (e is SearchEventArgs searchArgs)
			{
				this.usersControlViewModel.PopulateUsers(searchArgs);
			}
			else
			{
				this.usersControlViewModel.PopulateUsers();
			}

			this.usersDataGridView.DataSource = this.usersControlViewModel.Users;
			this.usersDataGridView.ClearSelection();
		}

		private void UsersDataGridView_SelectionChanged(object? sender, EventArgs e)
		{
			if (this.usersDataGridView.SelectedRows.Count > 0)
			{
				this.usersControlViewModel.SelectedUser =
					(User)this.usersDataGridView.SelectedRows[0].DataBoundItem;
			}
			else
			{
				this.usersControlViewModel.SelectedUser = null;
			}
		}

		private void SetupPage()
		{
			// Set up the data grid view
			this.usersControlViewModel = new UsersControlViewModel();
			this.usersDataGridView.DataSource = this.usersControlViewModel.Users;
			this.SetUpDataGridViewColumns();
			this.usersDataGridView.ClearSelection();

			// Bindings and events
			this.editUserBtn.DataBindings.Add("Enabled", this.usersControlViewModel,
				nameof(this.usersControlViewModel.IsValid), true, DataSourceUpdateMode.OnPropertyChanged);

			this.usersDataGridView.SelectionChanged += this.UsersDataGridView_SelectionChanged;
			this.userAdvancedSearchControl.SearchBtnClick += this.RefreshUserList;
			this.userAdvancedSearchControl.ClearBtnClick += this.RefreshUserList;
		}

		private void SetUpDataGridViewColumns()
		{
			// Hide the columns that are not needed
			this.usersDataGridView.Columns["UserId"].Visible = false;
			this.usersDataGridView.Columns["Sex"].Visible = false;
			this.usersDataGridView.Columns["Address1"].Visible = false;
			this.usersDataGridView.Columns["Address2"].Visible = false;
			this.usersDataGridView.Columns["City"].Visible = false;
			this.usersDataGridView.Columns["State"].Visible = false;
			this.usersDataGridView.Columns["ZipCode"].Visible = false;
			this.usersDataGridView.Columns["PhoneNumber"].Visible = false;
			this.usersDataGridView.Columns["Ssn"].Visible = false;

			// Rename main columns
			this.usersDataGridView.Columns["FirstName"].HeaderText = "First Name";
			this.usersDataGridView.Columns["LastName"].HeaderText = "Last Name";
			this.usersDataGridView.Columns["DateOfBirth"].HeaderText = "Date of Birth";


			this.usersDataGridView.Columns["FirstName"].ReadOnly = true;
			this.usersDataGridView.Columns["LastName"].ReadOnly = true;
			this.usersDataGridView.Columns["DateOfBirth"].ReadOnly = true;
		}

		#endregion
	}
}
