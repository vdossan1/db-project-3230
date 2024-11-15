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
			SuspendLayout();
			// 
			// statusCheckBox
			// 
			statusCheckBox.AutoSize = true;
			statusCheckBox.Location = new Point(60, 423);
			statusCheckBox.Name = "statusCheckBox";
			statusCheckBox.Size = new Size(155, 19);
			statusCheckBox.TabIndex = 0;
			statusCheckBox.Text = "Information is Complete";
			statusCheckBox.UseVisualStyleBackColor = true;
			// 
			// cancelButton
			// 
			cancelButton.Location = new Point(221, 451);
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
			actionButton.Location = new Point(59, 447);
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
			datePicker.Location = new Point(59, 337);
			datePicker.Name = "datePicker";
			datePicker.Size = new Size(200, 23);
			datePicker.TabIndex = 15;
			// 
			// dateErrorLabel
			// 
			dateErrorLabel.AutoSize = true;
			dateErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			dateErrorLabel.ForeColor = Color.Red;
			dateErrorLabel.Location = new Point(60, 363);
			dateErrorLabel.Margin = new Padding(2, 0, 2, 0);
			dateErrorLabel.Name = "dateErrorLabel";
			dateErrorLabel.Size = new Size(89, 15);
			dateErrorLabel.TabIndex = 44;
			dateErrorLabel.Text = "dateErrorLabel";
			// 
			// dateLabel
			// 
			dateLabel.AutoSize = true;
			dateLabel.Location = new Point(59, 319);
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
			reasonErrorLabel.Location = new Point(114, 33);
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
			reasonLabel.Location = new Point(44, 33);
			reasonLabel.Name = "reasonLabel";
			reasonLabel.Size = new Size(65, 15);
			reasonLabel.TabIndex = 46;
			reasonLabel.Text = "Test Result:";
			// 
			// resultTextBox
			// 
			resultTextBox.Location = new Point(44, 52);
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
			normalityErrorLabel.Location = new Point(162, 239);
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
			label2.Location = new Point(59, 239);
			label2.Name = "label2";
			label2.Size = new Size(98, 15);
			label2.TabIndex = 49;
			label2.Text = "Result Normality:";
			// 
			// normalityComboBox
			// 
			normalityComboBox.FormattingEnabled = true;
			normalityComboBox.Location = new Point(60, 258);
			normalityComboBox.Name = "normalityComboBox";
			normalityComboBox.Size = new Size(121, 23);
			normalityComboBox.TabIndex = 51;
			normalityComboBox.Text = "Select one";
			// 
			// ManageLabTestResultsPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(440, 513);
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
	}
}