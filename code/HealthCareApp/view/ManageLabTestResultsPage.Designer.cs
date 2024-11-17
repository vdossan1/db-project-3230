namespace HealthCareApp.view
{
	partial class ManageLabTestResultsPage
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			statusCheckBox = new CheckBox();
			cancelButton = new Button();
			actionButton = new Button();
			datePicker = new DateTimePicker();
			dateErrorLabel = new Label();
			dateLabel = new Label();
			reasonErrorLabel = new Label();
			reasonLabel = new Label();
			resultTextBox = new TextBox();
			normalityErrorLabel = new Label();
			label2 = new Label();
			normalityComboBox = new ComboBox();
			testInformationLabel = new Label();
			panel1 = new Panel();
			testCodeLabel = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label1 = new Label();
			testNameLabel = new Label();
			unitLabel = new Label();
			lowValueLabel = new Label();
			highValueLabel = new Label();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// statusCheckBox
			// 
			statusCheckBox.AutoSize = true;
			statusCheckBox.Location = new Point(312, 413);
			statusCheckBox.Name = "statusCheckBox";
			statusCheckBox.Size = new Size(155, 19);
			statusCheckBox.TabIndex = 0;
			statusCheckBox.Text = "Information is Complete";
			statusCheckBox.UseVisualStyleBackColor = true;
			// 
			// cancelButton
			// 
			cancelButton.Location = new Point(471, 441);
			cancelButton.Margin = new Padding(2);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(125, 33);
			cancelButton.TabIndex = 14;
			cancelButton.Text = "Cancel";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelBtn_Click;
			// 
			// actionButton
			// 
			actionButton.Enabled = false;
			actionButton.Location = new Point(311, 437);
			actionButton.Margin = new Padding(2);
			actionButton.Name = "actionButton";
			actionButton.Size = new Size(156, 41);
			actionButton.TabIndex = 13;
			actionButton.Text = "Save";
			actionButton.UseVisualStyleBackColor = true;
			actionButton.Click += actionButton_Click;
			// 
			// datePicker
			// 
			datePicker.Location = new Point(310, 327);
			datePicker.Name = "datePicker";
			datePicker.Size = new Size(200, 23);
			datePicker.TabIndex = 15;
			// 
			// dateErrorLabel
			// 
			dateErrorLabel.AutoSize = true;
			dateErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			dateErrorLabel.ForeColor = Color.Red;
			dateErrorLabel.Location = new Point(311, 353);
			dateErrorLabel.Margin = new Padding(2, 0, 2, 0);
			dateErrorLabel.Name = "dateErrorLabel";
			dateErrorLabel.Size = new Size(89, 15);
			dateErrorLabel.TabIndex = 44;
			dateErrorLabel.Text = "dateErrorLabel";
			// 
			// dateLabel
			// 
			dateLabel.AutoSize = true;
			dateLabel.Location = new Point(310, 309);
			dateLabel.Margin = new Padding(2, 0, 2, 0);
			dateLabel.Name = "dateLabel";
			dateLabel.Size = new Size(167, 15);
			dateLabel.TabIndex = 43;
			dateLabel.Text = "Date when test was performed";
			// 
			// reasonErrorLabel
			// 
			reasonErrorLabel.AutoSize = true;
			reasonErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			reasonErrorLabel.ForeColor = Color.Red;
			reasonErrorLabel.Location = new Point(355, 23);
			reasonErrorLabel.Margin = new Padding(2, 0, 2, 0);
			reasonErrorLabel.Name = "reasonErrorLabel";
			reasonErrorLabel.Size = new Size(96, 15);
			reasonErrorLabel.TabIndex = 47;
			reasonErrorLabel.Text = "resultErrorLabel";
			// 
			// reasonLabel
			// 
			reasonLabel.AutoSize = true;
			reasonLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			reasonLabel.Location = new Point(285, 23);
			reasonLabel.Name = "reasonLabel";
			reasonLabel.Size = new Size(65, 15);
			reasonLabel.TabIndex = 46;
			reasonLabel.Text = "Test Result:";
			// 
			// resultTextBox
			// 
			resultTextBox.Location = new Point(285, 42);
			resultTextBox.Multiline = true;
			resultTextBox.Name = "resultTextBox";
			resultTextBox.ScrollBars = ScrollBars.Vertical;
			resultTextBox.Size = new Size(347, 138);
			resultTextBox.TabIndex = 45;
			// 
			// normalityErrorLabel
			// 
			normalityErrorLabel.AutoSize = true;
			normalityErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			normalityErrorLabel.ForeColor = Color.Red;
			normalityErrorLabel.Location = new Point(413, 221);
			normalityErrorLabel.Margin = new Padding(2, 0, 2, 0);
			normalityErrorLabel.Name = "normalityErrorLabel";
			normalityErrorLabel.Size = new Size(117, 15);
			normalityErrorLabel.TabIndex = 50;
			normalityErrorLabel.Text = "normalityErrorLabel";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(310, 221);
			label2.Name = "label2";
			label2.Size = new Size(98, 15);
			label2.TabIndex = 49;
			label2.Text = "Result Normality:";
			// 
			// normalityComboBox
			// 
			normalityComboBox.FormattingEnabled = true;
			normalityComboBox.Location = new Point(311, 240);
			normalityComboBox.Name = "normalityComboBox";
			normalityComboBox.Size = new Size(121, 23);
			normalityComboBox.TabIndex = 51;
			normalityComboBox.Text = "Select one";
			// 
			// testInformationLabel
			// 
			testInformationLabel.AutoSize = true;
			testInformationLabel.Location = new Point(12, 23);
			testInformationLabel.Name = "testInformationLabel";
			testInformationLabel.Size = new Size(96, 15);
			testInformationLabel.TabIndex = 52;
			testInformationLabel.Text = "Test Information:";
			// 
			// panel1
			// 
			panel1.Controls.Add(testCodeLabel);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(testNameLabel);
			panel1.Controls.Add(unitLabel);
			panel1.Controls.Add(lowValueLabel);
			panel1.Controls.Add(highValueLabel);
			panel1.Location = new Point(12, 42);
			panel1.Name = "panel1";
			panel1.Size = new Size(267, 432);
			panel1.TabIndex = 58;
			// 
			// testCodeLabel
			// 
			testCodeLabel.AutoSize = true;
			testCodeLabel.ForeColor = SystemColors.MenuHighlight;
			testCodeLabel.Location = new Point(77, 17);
			testCodeLabel.Name = "testCodeLabel";
			testCodeLabel.Size = new Size(58, 15);
			testCodeLabel.TabIndex = 67;
			testCodeLabel.Text = "Test Code";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(3, 17);
			label6.Name = "label6";
			label6.Size = new Size(66, 15);
			label6.TabIndex = 66;
			label6.Text = "Test Code -";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(3, 177);
			label5.Name = "label5";
			label5.Size = new Size(99, 15);
			label5.TabIndex = 65;
			label5.Text = "Unit of Measure -";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(3, 137);
			label4.Name = "label4";
			label4.Size = new Size(68, 15);
			label4.TabIndex = 64;
			label4.Text = "Low Value -";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(3, 97);
			label3.Name = "label3";
			label3.Size = new Size(72, 15);
			label3.TabIndex = 63;
			label3.Text = "High Value -";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 57);
			label1.Name = "label1";
			label1.Size = new Size(70, 15);
			label1.TabIndex = 62;
			label1.Text = "Test Name -";
			// 
			// testNameLabel
			// 
			testNameLabel.AutoSize = true;
			testNameLabel.ForeColor = SystemColors.MenuHighlight;
			testNameLabel.Location = new Point(77, 57);
			testNameLabel.Name = "testNameLabel";
			testNameLabel.Size = new Size(62, 15);
			testNameLabel.TabIndex = 61;
			testNameLabel.Text = "Test Name";
			// 
			// unitLabel
			// 
			unitLabel.AutoSize = true;
			unitLabel.ForeColor = SystemColors.MenuHighlight;
			unitLabel.Location = new Point(108, 177);
			unitLabel.Name = "unitLabel";
			unitLabel.Size = new Size(91, 15);
			unitLabel.TabIndex = 60;
			unitLabel.Text = "Unit of Measure";
			// 
			// lowValueLabel
			// 
			lowValueLabel.AutoSize = true;
			lowValueLabel.ForeColor = SystemColors.MenuHighlight;
			lowValueLabel.Location = new Point(77, 137);
			lowValueLabel.Name = "lowValueLabel";
			lowValueLabel.Size = new Size(60, 15);
			lowValueLabel.TabIndex = 59;
			lowValueLabel.Text = "Low Value";
			// 
			// highValueLabel
			// 
			highValueLabel.AutoSize = true;
			highValueLabel.ForeColor = SystemColors.MenuHighlight;
			highValueLabel.Location = new Point(77, 97);
			highValueLabel.Name = "highValueLabel";
			highValueLabel.Size = new Size(64, 15);
			highValueLabel.TabIndex = 58;
			highValueLabel.Text = "High Value";
			// 
			// ManageLabTestResultsPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(649, 513);
			Controls.Add(panel1);
			Controls.Add(testInformationLabel);
			Controls.Add(normalityComboBox);
			Controls.Add(normalityErrorLabel);
			Controls.Add(label2);
			Controls.Add(reasonErrorLabel);
			Controls.Add(reasonLabel);
			Controls.Add(resultTextBox);
			Controls.Add(dateErrorLabel);
			Controls.Add(dateLabel);
			Controls.Add(datePicker);
			Controls.Add(cancelButton);
			Controls.Add(actionButton);
			Controls.Add(statusCheckBox);
			Name = "ManageLabTestResultsPage";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ManageLabTestResultsPage";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private CheckBox statusCheckBox;
		private Button cancelButton;
		private Button actionButton;
		private DateTimePicker datePicker;
		private Label dateErrorLabel;
		private Label dateLabel;
		private Label reasonErrorLabel;
		private Label reasonLabel;
		private TextBox resultTextBox;
		private Label normalityErrorLabel;
		private Label label2;
		private ComboBox normalityComboBox;
		private Label testInformationLabel;
		private Panel panel1;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label1;
		private Label testNameLabel;
		private Label unitLabel;
		private Label lowValueLabel;
		private Label highValueLabel;
		private Label testCodeLabel;
		private Label label6;
	}
}