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
			systemManagementButton = new Button();
			visitReportButton = new Button();
			sqlButton = new Button();
			adminContentPanel = new Panel();
			adminNavPanel.SuspendLayout();
			SuspendLayout();
			// 
			// adminNavPanel
			// 
			adminNavPanel.Controls.Add(visitReportButton);
			adminNavPanel.Controls.Add(systemManagementButton);
			adminNavPanel.Controls.Add(sqlButton);
			adminNavPanel.Location = new Point(3, 3);
			adminNavPanel.Name = "adminNavPanel";
			adminNavPanel.Size = new Size(1059, 50);
			adminNavPanel.TabIndex = 0;
			// 
			// systemManagementButton
			// 
			systemManagementButton.Location = new Point(315, 3);
			systemManagementButton.Name = "systemManagementButton";
			systemManagementButton.Size = new Size(150, 44);
			systemManagementButton.TabIndex = 3;
			systemManagementButton.Text = "System Management";
			systemManagementButton.UseVisualStyleBackColor = true;
			// 
			// visitReportButton
			// 
			visitReportButton.Location = new Point(3, 3);
			visitReportButton.Name = "visitReportButton";
			visitReportButton.Size = new Size(150, 44);
			visitReportButton.TabIndex = 2;
			visitReportButton.Text = "Visit Report";
			visitReportButton.UseVisualStyleBackColor = true;
			visitReportButton.Click += visitReportButton_Click;
			// 
			// sqlButton
			// 
			sqlButton.Location = new Point(159, 3);
			sqlButton.Name = "sqlButton";
			sqlButton.Size = new Size(150, 44);
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
		private Button systemManagementButton;
		private Button visitReportButton;
		private Button sqlButton;
	}
}
