﻿namespace HealthCareApp.view
{
	partial class AppointmentsControl
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
			appointmentsDataGridView = new DataGridView();
			createAppointmentBtn = new Button();
			editAppointmentBtn = new Button();
			appointmentsSearchBar = new TextBox();
			((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).BeginInit();
			SuspendLayout();
			// 
			// appointmentsDataGridView
			// 
			appointmentsDataGridView.AllowUserToAddRows = false;
			appointmentsDataGridView.AllowUserToDeleteRows = false;
			appointmentsDataGridView.AllowUserToResizeColumns = false;
			appointmentsDataGridView.AllowUserToResizeRows = false;
			appointmentsDataGridView.BackgroundColor = SystemColors.Control;
			appointmentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			appointmentsDataGridView.GridColor = SystemColors.Control;
			appointmentsDataGridView.Location = new Point(17, 57);
			appointmentsDataGridView.MultiSelect = false;
			appointmentsDataGridView.Name = "appointmentsDataGridView";
			appointmentsDataGridView.ReadOnly = true;
			appointmentsDataGridView.RowHeadersWidth = 62;
			appointmentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			appointmentsDataGridView.Size = new Size(704, 608);
			appointmentsDataGridView.TabIndex = 9;
			// 
			// createAppointmentBtn
			// 
			createAppointmentBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			createAppointmentBtn.Location = new Point(317, 21);
			createAppointmentBtn.Margin = new Padding(2);
			createAppointmentBtn.Name = "createAppointmentBtn";
			createAppointmentBtn.Size = new Size(200, 31);
			createAppointmentBtn.TabIndex = 10;
			createAppointmentBtn.Text = "Create Appointment";
			createAppointmentBtn.UseVisualStyleBackColor = true;
			// 
			// editAppointmentBtn
			// 
			editAppointmentBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			editAppointmentBtn.Location = new Point(521, 21);
			editAppointmentBtn.Margin = new Padding(2);
			editAppointmentBtn.Name = "editAppointmentBtn";
			editAppointmentBtn.Size = new Size(200, 31);
			editAppointmentBtn.TabIndex = 10;
			editAppointmentBtn.Text = "Edit Appointment";
			editAppointmentBtn.UseVisualStyleBackColor = true;
			// 
			// appointmentsSearchBar
			// 
			appointmentsSearchBar.BorderStyle = BorderStyle.FixedSingle;
			appointmentsSearchBar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			appointmentsSearchBar.ForeColor = SystemColors.ControlDarkDark;
			appointmentsSearchBar.Location = new Point(17, 22);
			appointmentsSearchBar.Name = "appointmentsSearchBar";
			appointmentsSearchBar.Size = new Size(295, 29);
			appointmentsSearchBar.TabIndex = 11;
			appointmentsSearchBar.Text = "  Search";
			appointmentsSearchBar.TextChanged += appointmentsSearchBar_TextChanged;
			// 
			// AppointmentsControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(appointmentsSearchBar);
			Controls.Add(editAppointmentBtn);
			Controls.Add(createAppointmentBtn);
			Controls.Add(appointmentsDataGridView);
			Name = "AppointmentsControl";
			Size = new Size(1065, 680);
			((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView appointmentsDataGridView;
		private Button createAppointmentBtn;
		private Button editAppointmentBtn;
		private TextBox appointmentsSearchBar;
	}
}