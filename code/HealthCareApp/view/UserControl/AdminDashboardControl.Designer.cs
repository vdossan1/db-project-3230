﻿namespace HealthCareApp.view
{
	partial class AdminDashboardControl
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
			monthCalendar1 = new MonthCalendar();
			SuspendLayout();
			// 
			// monthCalendar1
			// 
			monthCalendar1.Location = new Point(9, 9);
			monthCalendar1.Name = "monthCalendar1";
			monthCalendar1.TabIndex = 0;
			// 
			// AdminDashboardControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(monthCalendar1);
			Name = "AdminDashboardControl";
			Size = new Size(1059, 618);
			ResumeLayout(false);
		}

		#endregion

		private MonthCalendar monthCalendar1;
	}
}
