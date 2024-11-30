namespace HealthCareApp.view
{
	partial class AdminVisitReportUserControl
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
			clearButton = new Button();
			panel1 = new Panel();
			instructionLabel = new Label();
			reportStatsPanel = new Panel();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			dataGridView1 = new DataGridView();
			panel1.SuspendLayout();
			reportStatsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
			generateReportButton.Location = new Point(286, 68);
			generateReportButton.Name = "generateReportButton";
			generateReportButton.Size = new Size(110, 23);
			generateReportButton.TabIndex = 4;
			generateReportButton.Text = "Generate Report";
			generateReportButton.UseVisualStyleBackColor = true;
			// 
			// clearButton
			// 
			clearButton.Location = new Point(286, 33);
			clearButton.Name = "clearButton";
			clearButton.Size = new Size(110, 23);
			clearButton.TabIndex = 5;
			clearButton.Text = "Clear Dates";
			clearButton.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			panel1.Controls.Add(startDateLabel);
			panel1.Controls.Add(instructionLabel);
			panel1.Controls.Add(generateReportButton);
			panel1.Controls.Add(clearButton);
			panel1.Controls.Add(startDatePicker);
			panel1.Controls.Add(endDatePicker);
			panel1.Controls.Add(endDateLabel);
			panel1.Location = new Point(3, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(404, 100);
			panel1.TabIndex = 6;
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
			reportStatsPanel.Controls.Add(label3);
			reportStatsPanel.Controls.Add(label2);
			reportStatsPanel.Controls.Add(label1);
			reportStatsPanel.Location = new Point(456, 3);
			reportStatsPanel.Name = "reportStatsPanel";
			reportStatsPanel.Size = new Size(600, 100);
			reportStatsPanel.TabIndex = 8;
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
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(3, 33);
			label2.Name = "label2";
			label2.Size = new Size(61, 15);
			label2.TabIndex = 1;
			label2.Text = "Timespan:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(3, 68);
			label3.Name = "label3";
			label3.Size = new Size(104, 15);
			label3.TabIndex = 2;
			label3.Text = "Result Row Count:";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(3, 109);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(1053, 506);
			dataGridView1.TabIndex = 9;
			// 
			// AdminVisitReportUserControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(dataGridView1);
			Controls.Add(reportStatsPanel);
			Controls.Add(panel1);
			Name = "AdminVisitReportUserControl";
			Size = new Size(1059, 618);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			reportStatsPanel.ResumeLayout(false);
			reportStatsPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DateTimePicker startDatePicker;
		private DateTimePicker endDatePicker;
		private Label startDateLabel;
		private Label endDateLabel;
		private Button generateReportButton;
		private Button clearButton;
		private Panel panel1;
		private Label instructionLabel;
		private Panel reportStatsPanel;
		private Label label1;
		private Label label3;
		private Label label2;
		private DataGridView dataGridView1;
	}
}
