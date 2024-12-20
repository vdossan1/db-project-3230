﻿namespace HealthCareApp.view
{
	partial class AdminVisitReportControl
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
			startDatePicker = new DateTimePicker();
			endDatePicker = new DateTimePicker();
			startDateLabel = new Label();
			endDateLabel = new Label();
			generateReportButton = new Button();
			panel1 = new Panel();
			clearReportButton = new Button();
			instructionLabel = new Label();
			reportStatsPanel = new Panel();
			rowsLabel = new Label();
			timeSpanLabel = new Label();
			label1 = new Label();
			reportDataGridView = new DataGridView();
			labTestResultsDataGridView = new DataGridView();
			panel1.SuspendLayout();
			reportStatsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)reportDataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)labTestResultsDataGridView).BeginInit();
			SuspendLayout();
			// 
			// startDatePicker
			// 
			startDatePicker.Location = new Point(67, 33);
			startDatePicker.Name = "startDatePicker";
			startDatePicker.Size = new Size(200, 23);
			startDatePicker.TabIndex = 0;
			// 
			// endDatePicker
			// 
			endDatePicker.Location = new Point(67, 68);
			endDatePicker.Name = "endDatePicker";
			endDatePicker.Size = new Size(200, 23);
			endDatePicker.TabIndex = 1;
			// 
			// startDateLabel
			// 
			startDateLabel.AutoSize = true;
			startDateLabel.Location = new Point(1, 33);
			startDateLabel.Name = "startDateLabel";
			startDateLabel.Size = new Size(58, 15);
			startDateLabel.TabIndex = 2;
			startDateLabel.Text = "Start Date";
			// 
			// endDateLabel
			// 
			endDateLabel.AutoSize = true;
			endDateLabel.Location = new Point(1, 68);
			endDateLabel.Name = "endDateLabel";
			endDateLabel.Size = new Size(54, 15);
			endDateLabel.TabIndex = 3;
			endDateLabel.Text = "End Date";
			// 
			// generateReportButton
			// 
			generateReportButton.Location = new Point(314, 68);
			generateReportButton.Name = "generateReportButton";
			generateReportButton.Size = new Size(110, 23);
			generateReportButton.TabIndex = 4;
			generateReportButton.Text = "Generate Report";
			generateReportButton.UseVisualStyleBackColor = true;
			generateReportButton.Click += GenerateReportButton_Click;
			// 
			// panel1
			// 
			panel1.Controls.Add(clearReportButton);
			panel1.Controls.Add(startDateLabel);
			panel1.Controls.Add(instructionLabel);
			panel1.Controls.Add(generateReportButton);
			panel1.Controls.Add(startDatePicker);
			panel1.Controls.Add(endDatePicker);
			panel1.Controls.Add(endDateLabel);
			panel1.Location = new Point(3, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(477, 100);
			panel1.TabIndex = 6;
			// 
			// clearReportButton
			// 
			clearReportButton.Location = new Point(314, 33);
			clearReportButton.Name = "clearReportButton";
			clearReportButton.Size = new Size(110, 23);
			clearReportButton.TabIndex = 21;
			clearReportButton.Text = "Clear Report";
			clearReportButton.UseVisualStyleBackColor = true;
			clearReportButton.Click += ClearReportButton_Click;
			// 
			// instructionLabel
			// 
			instructionLabel.AutoSize = true;
			instructionLabel.Location = new Point(1, 0);
			instructionLabel.Name = "instructionLabel";
			instructionLabel.Size = new Size(400, 15);
			instructionLabel.TabIndex = 7;
			instructionLabel.Text = "Select a start and end date to generate a report for the selected time frame.";
			// 
			// reportStatsPanel
			// 
			reportStatsPanel.Controls.Add(rowsLabel);
			reportStatsPanel.Controls.Add(timeSpanLabel);
			reportStatsPanel.Controls.Add(label1);
			reportStatsPanel.Location = new Point(486, 3);
			reportStatsPanel.Name = "reportStatsPanel";
			reportStatsPanel.Size = new Size(570, 100);
			reportStatsPanel.TabIndex = 8;
			// 
			// rowsLabel
			// 
			rowsLabel.AutoSize = true;
			rowsLabel.Location = new Point(3, 68);
			rowsLabel.Name = "rowsLabel";
			rowsLabel.Size = new Size(104, 15);
			rowsLabel.TabIndex = 2;
			rowsLabel.Text = "Result Row Count:";
			// 
			// timeSpanLabel
			// 
			timeSpanLabel.AutoSize = true;
			timeSpanLabel.Location = new Point(3, 33);
			timeSpanLabel.Name = "timeSpanLabel";
			timeSpanLabel.Size = new Size(61, 15);
			timeSpanLabel.TabIndex = 1;
			timeSpanLabel.Text = "Timespan:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(91, 15);
			label1.TabIndex = 0;
			label1.Text = "Report Statistics";
			// 
			// reportDataGridView
			// 
			reportDataGridView.AllowUserToAddRows = false;
			reportDataGridView.AllowUserToDeleteRows = false;
			reportDataGridView.AllowUserToResizeColumns = false;
			reportDataGridView.AllowUserToResizeRows = false;
			reportDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			reportDataGridView.BackgroundColor = SystemColors.Control;
			reportDataGridView.BorderStyle = BorderStyle.Fixed3D;
			reportDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			reportDataGridView.GridColor = SystemColors.Control;
			reportDataGridView.Location = new Point(3, 109);
			reportDataGridView.MultiSelect = false;
			reportDataGridView.Name = "reportDataGridView";
			reportDataGridView.ReadOnly = true;
			reportDataGridView.RowHeadersVisible = false;
			reportDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			reportDataGridView.Size = new Size(1053, 250);
			reportDataGridView.TabIndex = 9;
			// 
			// labTestResultsDataGridView
			// 
			labTestResultsDataGridView.AllowUserToAddRows = false;
			labTestResultsDataGridView.AllowUserToDeleteRows = false;
			labTestResultsDataGridView.AllowUserToResizeColumns = false;
			labTestResultsDataGridView.AllowUserToResizeRows = false;
			labTestResultsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			labTestResultsDataGridView.BackgroundColor = SystemColors.Control;
			labTestResultsDataGridView.BorderStyle = BorderStyle.Fixed3D;
			labTestResultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			labTestResultsDataGridView.GridColor = SystemColors.Control;
			labTestResultsDataGridView.Location = new Point(4, 365);
			labTestResultsDataGridView.MultiSelect = false;
			labTestResultsDataGridView.Name = "labTestResultsDataGridView";
			labTestResultsDataGridView.ReadOnly = true;
			labTestResultsDataGridView.RowHeadersVisible = false;
			labTestResultsDataGridView.RowHeadersWidth = 62;
			labTestResultsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			labTestResultsDataGridView.Size = new Size(1052, 250);
			labTestResultsDataGridView.TabIndex = 20;
			// 
			// AdminVisitReportControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(labTestResultsDataGridView);
			Controls.Add(reportDataGridView);
			Controls.Add(reportStatsPanel);
			Controls.Add(panel1);
			Name = "AdminVisitReportControl";
			Size = new Size(1059, 618);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			reportStatsPanel.ResumeLayout(false);
			reportStatsPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)reportDataGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)labTestResultsDataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DateTimePicker startDatePicker;
		private DateTimePicker endDatePicker;
		private Label startDateLabel;
		private Label endDateLabel;
		private Button generateReportButton;
		private Panel panel1;
		private Label instructionLabel;
		private Panel reportStatsPanel;
		private Label label1;
		private Label rowsLabel;
		private Label timeSpanLabel;
		private DataGridView reportDataGridView;
		private DataGridView labTestResultsDataGridView;
		private Button clearReportButton;
	}
}
