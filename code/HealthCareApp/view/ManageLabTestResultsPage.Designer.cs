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
            normalityText = new Label();
            label2 = new Label();
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
            statusCheckBox.Location = new Point(446, 688);
            statusCheckBox.Margin = new Padding(4, 5, 4, 5);
            statusCheckBox.Name = "statusCheckBox";
            statusCheckBox.Size = new Size(231, 29);
            statusCheckBox.TabIndex = 0;
            statusCheckBox.Text = "Information is Complete";
            statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(673, 735);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(179, 55);
            cancelButton.TabIndex = 14;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelBtn_Click;
            // 
            // actionButton
            // 
            actionButton.Enabled = false;
            actionButton.Location = new Point(444, 728);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(223, 68);
            actionButton.TabIndex = 13;
            actionButton.Text = "Save";
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(443, 545);
            datePicker.Margin = new Padding(4, 5, 4, 5);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(284, 31);
            datePicker.TabIndex = 15;
            // 
            // dateErrorLabel
            // 
            dateErrorLabel.AutoSize = true;
            dateErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dateErrorLabel.ForeColor = Color.Red;
            dateErrorLabel.Location = new Point(444, 588);
            dateErrorLabel.Name = "dateErrorLabel";
            dateErrorLabel.Size = new Size(137, 25);
            dateErrorLabel.TabIndex = 44;
            dateErrorLabel.Text = "dateErrorLabel";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(443, 515);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(255, 25);
            dateLabel.TabIndex = 43;
            dateLabel.Text = "Date when test was performed";
            // 
            // reasonErrorLabel
            // 
            reasonErrorLabel.AutoSize = true;
            reasonErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            reasonErrorLabel.ForeColor = Color.Red;
            reasonErrorLabel.Location = new Point(507, 38);
            reasonErrorLabel.Name = "reasonErrorLabel";
            reasonErrorLabel.Size = new Size(147, 25);
            reasonErrorLabel.TabIndex = 47;
            reasonErrorLabel.Text = "resultErrorLabel";
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reasonLabel.Location = new Point(407, 38);
            reasonLabel.Margin = new Padding(4, 0, 4, 0);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new Size(98, 25);
            reasonLabel.TabIndex = 46;
            reasonLabel.Text = "Test Result:";
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(407, 70);
            resultTextBox.Margin = new Padding(4, 5, 4, 5);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ScrollBars = ScrollBars.Vertical;
            resultTextBox.Size = new Size(494, 227);
            resultTextBox.TabIndex = 45;
            resultTextBox.Leave += resultTextBox_Leave;
            // 
            // normalityText
            // 
            normalityText.AutoSize = true;
            normalityText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            normalityText.ForeColor = SystemColors.ControlText;
            normalityText.Location = new Point(593, 429);
            normalityText.Name = "normalityText";
            normalityText.Size = new Size(145, 25);
            normalityText.TabIndex = 50;
            normalityText.Text = "resultNormality";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(446, 429);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 49;
            label2.Text = "Result Normality:";
            // 
            // testInformationLabel
            // 
            testInformationLabel.AutoSize = true;
            testInformationLabel.Location = new Point(17, 38);
            testInformationLabel.Margin = new Padding(4, 0, 4, 0);
            testInformationLabel.Name = "testInformationLabel";
            testInformationLabel.Size = new Size(145, 25);
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
            panel1.Location = new Point(17, 70);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 720);
            panel1.TabIndex = 58;
            // 
            // testCodeLabel
            // 
            testCodeLabel.AutoSize = true;
            testCodeLabel.ForeColor = SystemColors.MenuHighlight;
            testCodeLabel.Location = new Point(110, 28);
            testCodeLabel.Margin = new Padding(4, 0, 4, 0);
            testCodeLabel.Name = "testCodeLabel";
            testCodeLabel.Size = new Size(89, 25);
            testCodeLabel.TabIndex = 67;
            testCodeLabel.Text = "Test Code";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 28);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(101, 25);
            label6.TabIndex = 66;
            label6.Text = "Test Code -";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 295);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(150, 25);
            label5.TabIndex = 65;
            label5.Text = "Unit of Measure -";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 228);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 64;
            label4.Text = "Low Value -";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 162);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 63;
            label3.Text = "High Value -";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 95);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 62;
            label1.Text = "Test Name -";
            // 
            // testNameLabel
            // 
            testNameLabel.AutoSize = true;
            testNameLabel.ForeColor = SystemColors.MenuHighlight;
            testNameLabel.Location = new Point(110, 95);
            testNameLabel.Margin = new Padding(4, 0, 4, 0);
            testNameLabel.Name = "testNameLabel";
            testNameLabel.Size = new Size(94, 25);
            testNameLabel.TabIndex = 61;
            testNameLabel.Text = "Test Name";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.ForeColor = SystemColors.MenuHighlight;
            unitLabel.Location = new Point(154, 295);
            unitLabel.Margin = new Padding(4, 0, 4, 0);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new Size(138, 25);
            unitLabel.TabIndex = 60;
            unitLabel.Text = "Unit of Measure";
            // 
            // lowValueLabel
            // 
            lowValueLabel.AutoSize = true;
            lowValueLabel.ForeColor = SystemColors.MenuHighlight;
            lowValueLabel.Location = new Point(110, 228);
            lowValueLabel.Margin = new Padding(4, 0, 4, 0);
            lowValueLabel.Name = "lowValueLabel";
            lowValueLabel.Size = new Size(91, 25);
            lowValueLabel.TabIndex = 59;
            lowValueLabel.Text = "Low Value";
            // 
            // highValueLabel
            // 
            highValueLabel.AutoSize = true;
            highValueLabel.ForeColor = SystemColors.MenuHighlight;
            highValueLabel.Location = new Point(110, 162);
            highValueLabel.Margin = new Padding(4, 0, 4, 0);
            highValueLabel.Name = "highValueLabel";
            highValueLabel.Size = new Size(97, 25);
            highValueLabel.TabIndex = 58;
            highValueLabel.Text = "High Value";
            // 
            // ManageLabTestResultsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(927, 855);
            Controls.Add(panel1);
            Controls.Add(testInformationLabel);
            Controls.Add(normalityText);
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
            Margin = new Padding(4, 5, 4, 5);
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
		private Label normalityText;
		private Label label2;
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