namespace HealthCareApp.view
{
	partial class AdminControl
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
			adminNavPanel = new Panel();
			visitReportButton = new Button();
			registerUserButton = new Button();
			sqlButton = new Button();
			adminContentPanel = new Panel();
			adminNavPanel.SuspendLayout();
			SuspendLayout();
			// 
			// adminNavPanel
			// 
			adminNavPanel.Controls.Add(visitReportButton);
			adminNavPanel.Controls.Add(registerUserButton);
			adminNavPanel.Controls.Add(sqlButton);
			adminNavPanel.Location = new Point(3, 3);
			adminNavPanel.Name = "adminNavPanel";
			adminNavPanel.Size = new Size(1059, 50);
			adminNavPanel.TabIndex = 0;
			// 
			// visitReportButton
			// 
			visitReportButton.Location = new Point(3, 7);
			visitReportButton.Name = "visitReportButton";
			visitReportButton.Size = new Size(300, 40);
			visitReportButton.TabIndex = 2;
			visitReportButton.Text = "Visit Report";
			visitReportButton.UseVisualStyleBackColor = true;
			visitReportButton.Click += visitReportButton_Click;
			// 
			// registerUserButton
			// 
			registerUserButton.Location = new Point(615, 7);
			registerUserButton.Name = "registerUserButton";
			registerUserButton.Size = new Size(300, 40);
			registerUserButton.TabIndex = 3;
			registerUserButton.Text = "Register New User";
			registerUserButton.UseVisualStyleBackColor = true;
			registerUserButton.Click += registerUserButton_Click;
			// 
			// sqlButton
			// 
			sqlButton.Location = new Point(309, 7);
			sqlButton.Name = "sqlButton";
			sqlButton.Size = new Size(300, 40);
			sqlButton.TabIndex = 1;
			sqlButton.Text = "SQL Queries";
			sqlButton.UseVisualStyleBackColor = true;
			sqlButton.Click += sqlButton_Click;
			// 
			// adminContentPanel
			// 
			adminContentPanel.Location = new Point(3, 59);
			adminContentPanel.Name = "adminContentPanel";
			adminContentPanel.Size = new Size(1059, 618);
			adminContentPanel.TabIndex = 1;
			// 
			// AdminControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(adminContentPanel);
			Controls.Add(adminNavPanel);
			Name = "AdminControl";
			Size = new Size(1065, 680);
			adminNavPanel.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel adminNavPanel;
		private Panel adminContentPanel;
		private Button registerUserButton;
		private Button visitReportButton;
		private Button sqlButton;
	}
}
