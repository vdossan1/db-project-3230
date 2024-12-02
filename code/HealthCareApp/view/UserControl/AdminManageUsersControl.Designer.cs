namespace HealthCareApp.view
{
	partial class AdminManageUsersControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			usersDataGridView = new DataGridView();
			editUserBtn = new Button();
			registerUserBtn = new Button();
			userAdvancedSearchControl = new AdvancedSearchControl();
			((System.ComponentModel.ISupportInitialize)usersDataGridView).BeginInit();
			SuspendLayout();
			// 
			// usersDataGridView
			// 
			usersDataGridView.AllowUserToAddRows = false;
			usersDataGridView.AllowUserToDeleteRows = false;
			usersDataGridView.AllowUserToResizeColumns = false;
			usersDataGridView.AllowUserToResizeRows = false;
			usersDataGridView.BackgroundColor = SystemColors.Control;
			usersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			usersDataGridView.GridColor = SystemColors.Control;
			usersDataGridView.Location = new Point(14, 216);
			usersDataGridView.MultiSelect = false;
			usersDataGridView.Name = "usersDataGridView";
			usersDataGridView.RowHeadersVisible = false;
			usersDataGridView.RowHeadersWidth = 62;
			usersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			usersDataGridView.Size = new Size(704, 390);
			usersDataGridView.TabIndex = 9;
			// 
			// editUserBtn
			// 
			editUserBtn.Enabled = false;
			editUserBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			editUserBtn.Location = new Point(218, 75);
			editUserBtn.Margin = new Padding(2);
			editUserBtn.Name = "editUserBtn";
			editUserBtn.Size = new Size(200, 31);
			editUserBtn.TabIndex = 11;
			editUserBtn.Text = "Edit Nurse";
			editUserBtn.UseVisualStyleBackColor = true;
			editUserBtn.Click += editUserBtn_Click;
			// 
			// registerUserBtn
			// 
			registerUserBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			registerUserBtn.Location = new Point(14, 75);
			registerUserBtn.Margin = new Padding(2);
			registerUserBtn.Name = "registerUserBtn";
			registerUserBtn.Size = new Size(200, 31);
			registerUserBtn.TabIndex = 10;
			registerUserBtn.Text = "Register Nurse";
			registerUserBtn.UseVisualStyleBackColor = true;
			registerUserBtn.Click += registerUserBtn_Click;
			// 
			// userAdvancedSearchControl
			// 
			userAdvancedSearchControl.Location = new Point(14, 110);
			userAdvancedSearchControl.Margin = new Padding(2);
			userAdvancedSearchControl.Name = "userAdvancedSearchControl";
			userAdvancedSearchControl.Size = new Size(729, 101);
			userAdvancedSearchControl.TabIndex = 12;
			// 
			// AdminManageUsersControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(userAdvancedSearchControl);
			Controls.Add(editUserBtn);
			Controls.Add(registerUserBtn);
			Controls.Add(usersDataGridView);
			Name = "AdminManageUsersControl";
			Size = new Size(1059, 618);
			((System.ComponentModel.ISupportInitialize)usersDataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView usersDataGridView;
		private Button editUserBtn;
		private Button registerUserBtn;
		private AdvancedSearchControl userAdvancedSearchControl;
	}
}
