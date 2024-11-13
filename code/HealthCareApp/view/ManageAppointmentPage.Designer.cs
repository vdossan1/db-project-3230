namespace HealthCareApp.view
{
    partial class ManageAppointmentPage
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
			reasonTextBox = new TextBox();
			datePicker = new DateTimePicker();
			actionButton = new Button();
			cancelButton = new Button();
			reasonLabel = new Label();
			dateLabel = new Label();
			patientsDataGridView = new DataGridView();
			doctorsDataGridView = new DataGridView();
			dateErrorLabel = new Label();
			reasonErrorLabel = new Label();
			doctorErrorLabel = new Label();
			patientErrorLabel = new Label();
			label1 = new Label();
			advancedSearchControlDoctor = new AdvancedSearchControl();
			advancedSearchControlPatient = new AdvancedSearchControl();
			((System.ComponentModel.ISupportInitialize)patientsDataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)doctorsDataGridView).BeginInit();
			SuspendLayout();
			// 
			// reasonTextBox
			// 
			reasonTextBox.Location = new Point(801, 74);
			reasonTextBox.Multiline = true;
			reasonTextBox.Name = "reasonTextBox";
			reasonTextBox.Size = new Size(340, 292);
			reasonTextBox.TabIndex = 6;
			// 
			// datePicker
			// 
			datePicker.Checked = false;
			datePicker.Format = DateTimePickerFormat.Custom;
			datePicker.Location = new Point(801, 477);
			datePicker.Margin = new Padding(2);
			datePicker.Name = "datePicker";
			datePicker.Size = new Size(211, 23);
			datePicker.TabIndex = 7;
			// 
			// actionButton
			// 
			actionButton.Enabled = false;
			actionButton.Location = new Point(802, 673);
			actionButton.Margin = new Padding(2);
			actionButton.Name = "actionButton";
			actionButton.Size = new Size(156, 41);
			actionButton.TabIndex = 9;
			actionButton.Text = "Appointment";
			actionButton.UseVisualStyleBackColor = true;
			actionButton.Click += createAppointmentButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Location = new Point(962, 677);
			cancelButton.Margin = new Padding(2);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(125, 33);
			cancelButton.TabIndex = 10;
			cancelButton.Text = "Cancel";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelBtn_Click;
			// 
			// reasonLabel
			// 
			reasonLabel.AutoSize = true;
			reasonLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			reasonLabel.Location = new Point(801, 55);
			reasonLabel.Name = "reasonLabel";
			reasonLabel.Size = new Size(138, 15);
			reasonLabel.TabIndex = 15;
			reasonLabel.Text = "Reason for appointment:";
			// 
			// dateLabel
			// 
			dateLabel.AutoSize = true;
			dateLabel.Location = new Point(801, 430);
			dateLabel.Margin = new Padding(2, 0, 2, 0);
			dateLabel.Name = "dateLabel";
			dateLabel.Size = new Size(175, 15);
			dateLabel.TabIndex = 18;
			dateLabel.Text = "Date and Time for Appointment";
			// 
			// patientsDataGridView
			// 
			patientsDataGridView.AllowUserToAddRows = false;
			patientsDataGridView.AllowUserToDeleteRows = false;
			patientsDataGridView.AllowUserToResizeColumns = false;
			patientsDataGridView.AllowUserToResizeRows = false;
			patientsDataGridView.BackgroundColor = SystemColors.Control;
			patientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			patientsDataGridView.GridColor = SystemColors.Control;
			patientsDataGridView.Location = new Point(23, 131);
			patientsDataGridView.MultiSelect = false;
			patientsDataGridView.Name = "patientsDataGridView";
			patientsDataGridView.RowHeadersVisible = false;
			patientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			patientsDataGridView.Size = new Size(300, 200);
			patientsDataGridView.StandardTab = true;
			patientsDataGridView.TabIndex = 2;
			patientsDataGridView.SelectionChanged += patientsDataGridView_SelectionChanged;
			// 
			// doctorsDataGridView
			// 
			doctorsDataGridView.AllowUserToAddRows = false;
			doctorsDataGridView.AllowUserToDeleteRows = false;
			doctorsDataGridView.AllowUserToResizeColumns = false;
			doctorsDataGridView.AllowUserToResizeRows = false;
			doctorsDataGridView.BackgroundColor = SystemColors.Control;
			doctorsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			doctorsDataGridView.GridColor = SystemColors.Control;
			doctorsDataGridView.Location = new Point(23, 514);
			doctorsDataGridView.MultiSelect = false;
			doctorsDataGridView.Name = "doctorsDataGridView";
			doctorsDataGridView.RowHeadersVisible = false;
			doctorsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			doctorsDataGridView.Size = new Size(300, 200);
			doctorsDataGridView.StandardTab = true;
			doctorsDataGridView.TabIndex = 4;
			doctorsDataGridView.SelectionChanged += doctorsDataGridView_SelectionChanged;
			// 
			// dateErrorLabel
			// 
			dateErrorLabel.AutoSize = true;
			dateErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			dateErrorLabel.ForeColor = Color.Red;
			dateErrorLabel.Location = new Point(802, 502);
			dateErrorLabel.Margin = new Padding(2, 0, 2, 0);
			dateErrorLabel.Name = "dateErrorLabel";
			dateErrorLabel.Size = new Size(89, 15);
			dateErrorLabel.TabIndex = 36;
			dateErrorLabel.Text = "dateErrorLabel";
			// 
			// reasonErrorLabel
			// 
			reasonErrorLabel.AutoSize = true;
			reasonErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			reasonErrorLabel.ForeColor = Color.Red;
			reasonErrorLabel.Location = new Point(944, 55);
			reasonErrorLabel.Margin = new Padding(2, 0, 2, 0);
			reasonErrorLabel.Name = "reasonErrorLabel";
			reasonErrorLabel.Size = new Size(101, 15);
			reasonErrorLabel.TabIndex = 38;
			reasonErrorLabel.Text = "reasonErrorLabel";
			// 
			// doctorErrorLabel
			// 
			doctorErrorLabel.AutoSize = true;
			doctorErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			doctorErrorLabel.ForeColor = Color.Red;
			doctorErrorLabel.Location = new Point(328, 511);
			doctorErrorLabel.Margin = new Padding(2, 0, 2, 0);
			doctorErrorLabel.Name = "doctorErrorLabel";
			doctorErrorLabel.Size = new Size(101, 15);
			doctorErrorLabel.TabIndex = 39;
			doctorErrorLabel.Text = "doctorErrorLabel";
			// 
			// patientErrorLabel
			// 
			patientErrorLabel.AutoSize = true;
			patientErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			patientErrorLabel.ForeColor = Color.Red;
			patientErrorLabel.Location = new Point(328, 128);
			patientErrorLabel.Margin = new Padding(2, 0, 2, 0);
			patientErrorLabel.Name = "patientErrorLabel";
			patientErrorLabel.Size = new Size(104, 15);
			patientErrorLabel.TabIndex = 40;
			patientErrorLabel.Text = "patientErrorLabel";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label1.Location = new Point(801, 451);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(194, 15);
			label1.TabIndex = 41;
			label1.Text = "Must be after current date and time";
			// 
			// advancedSearchControlDoctor
			// 
			advancedSearchControlDoctor.Location = new Point(12, 418);
			advancedSearchControlDoctor.Margin = new Padding(2);
			advancedSearchControlDoctor.Name = "advancedSearchControlDoctor";
			advancedSearchControlDoctor.Size = new Size(729, 91);
			advancedSearchControlDoctor.TabIndex = 43;
			// 
			// advancedSearchControlPatient
			// 
			advancedSearchControlPatient.Location = new Point(12, 35);
			advancedSearchControlPatient.Margin = new Padding(2);
			advancedSearchControlPatient.Name = "advancedSearchControlPatient";
			advancedSearchControlPatient.Size = new Size(729, 91);
			advancedSearchControlPatient.TabIndex = 44;
			// 
			// ManageAppointmentPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1184, 761);
			Controls.Add(advancedSearchControlPatient);
			Controls.Add(advancedSearchControlDoctor);
			Controls.Add(label1);
			Controls.Add(patientErrorLabel);
			Controls.Add(doctorErrorLabel);
			Controls.Add(reasonErrorLabel);
			Controls.Add(dateErrorLabel);
			Controls.Add(doctorsDataGridView);
			Controls.Add(patientsDataGridView);
			Controls.Add(dateLabel);
			Controls.Add(reasonLabel);
			Controls.Add(cancelButton);
			Controls.Add(actionButton);
			Controls.Add(datePicker);
			Controls.Add(reasonTextBox);
			Name = "ManageAppointmentPage";
			StartPosition = FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)patientsDataGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)doctorsDataGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox reasonTextBox;
        private DateTimePicker datePicker;
        private Button actionButton;
        private Button cancelButton;
        private Label reasonLabel;
        private Label dateLabel;
        private DataGridView patientsDataGridView;
        private DataGridView doctorsDataGridView;
        private Label searchPatientLabel;
        private Label searchDoctorLabel;
        private Label dateErrorLabel;
        private Label reasonErrorLabel;
        private Label doctorErrorLabel;
        private Label patientErrorLabel;
        private Label label1;
		private AdvancedSearchControl advancedSearchControl1;
		private AdvancedSearchControl advancedSearchControlDoctor;
		private AdvancedSearchControl advancedSearchControlPatient;
	}
}