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
			label2 = new Label();
			label3 = new Label();
			((System.ComponentModel.ISupportInitialize)patientsDataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)doctorsDataGridView).BeginInit();
			SuspendLayout();
			// 
			// reasonTextBox
			// 
			reasonTextBox.Location = new Point(747, 38);
			reasonTextBox.Multiline = true;
			reasonTextBox.Name = "reasonTextBox";
			reasonTextBox.ScrollBars = ScrollBars.Vertical;
			reasonTextBox.Size = new Size(340, 292);
			reasonTextBox.TabIndex = 6;
			// 
			// datePicker
			// 
			datePicker.Checked = false;
			datePicker.Format = DateTimePickerFormat.Custom;
			datePicker.Location = new Point(747, 439);
			datePicker.Margin = new Padding(2);
			datePicker.Name = "datePicker";
			datePicker.Size = new Size(211, 23);
			datePicker.TabIndex = 7;
			// 
			// actionButton
			// 
			actionButton.Enabled = false;
			actionButton.Location = new Point(748, 673);
			actionButton.Margin = new Padding(2);
			actionButton.Name = "actionButton";
			actionButton.Size = new Size(150, 40);
			actionButton.TabIndex = 9;
			actionButton.Text = "Appointment";
			actionButton.UseVisualStyleBackColor = true;
			actionButton.Click += createAppointmentButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Location = new Point(902, 674);
			cancelButton.Margin = new Padding(2);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(150, 40);
			cancelButton.TabIndex = 10;
			cancelButton.Text = "Cancel";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelBtn_Click;
			// 
			// reasonLabel
			// 
			reasonLabel.AutoSize = true;
			reasonLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			reasonLabel.Location = new Point(747, 19);
			reasonLabel.Name = "reasonLabel";
			reasonLabel.Size = new Size(138, 15);
			reasonLabel.TabIndex = 15;
			reasonLabel.Text = "Reason for appointment:";
			// 
			// dateLabel
			// 
			dateLabel.AutoSize = true;
			dateLabel.Location = new Point(747, 392);
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
			patientsDataGridView.BorderStyle = BorderStyle.Fixed3D;
			patientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			patientsDataGridView.GridColor = SystemColors.Control;
			patientsDataGridView.Location = new Point(12, 130);
			patientsDataGridView.MultiSelect = false;
			patientsDataGridView.Name = "patientsDataGridView";
			patientsDataGridView.RowHeadersVisible = false;
			patientsDataGridView.RowHeadersWidth = 62;
			patientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			patientsDataGridView.Size = new Size(700, 200);
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
			doctorsDataGridView.BorderStyle = BorderStyle.Fixed3D;
			doctorsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			doctorsDataGridView.GridColor = SystemColors.Control;
			doctorsDataGridView.Location = new Point(12, 514);
			doctorsDataGridView.MultiSelect = false;
			doctorsDataGridView.Name = "doctorsDataGridView";
			doctorsDataGridView.RowHeadersVisible = false;
			doctorsDataGridView.RowHeadersWidth = 62;
			doctorsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			doctorsDataGridView.Size = new Size(700, 200);
			doctorsDataGridView.StandardTab = true;
			doctorsDataGridView.TabIndex = 4;
			doctorsDataGridView.SelectionChanged += doctorsDataGridView_SelectionChanged;
			// 
			// dateErrorLabel
			// 
			dateErrorLabel.AutoSize = true;
			dateErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			dateErrorLabel.ForeColor = Color.Red;
			dateErrorLabel.Location = new Point(748, 464);
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
			reasonErrorLabel.Location = new Point(890, 19);
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
			doctorErrorLabel.Location = new Point(95, 392);
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
			patientErrorLabel.Location = new Point(95, 9);
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
			label1.Location = new Point(747, 413);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(194, 15);
			label1.TabIndex = 41;
			label1.Text = "Must be after current date and time";
			// 
			// advancedSearchControlDoctor
			// 
			advancedSearchControlDoctor.Location = new Point(12, 418);
			advancedSearchControlDoctor.Margin = new Padding(1);
			advancedSearchControlDoctor.Name = "advancedSearchControlDoctor";
			advancedSearchControlDoctor.Size = new Size(700, 80);
			advancedSearchControlDoctor.TabIndex = 43;
			// 
			// advancedSearchControlPatient
			// 
			advancedSearchControlPatient.Location = new Point(12, 35);
			advancedSearchControlPatient.Margin = new Padding(1);
			advancedSearchControlPatient.Name = "advancedSearchControlPatient";
			advancedSearchControlPatient.Size = new Size(700, 80);
			advancedSearchControlPatient.TabIndex = 44;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 9);
			label2.Name = "label2";
			label2.Size = new Size(78, 15);
			label2.TabIndex = 45;
			label2.Text = "Select Patient";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(13, 392);
			label3.Name = "label3";
			label3.Size = new Size(77, 15);
			label3.TabIndex = 46;
			label3.Text = "Select Doctor";
			// 
			// ManageAppointmentPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			ClientSize = new Size(1184, 761);
			Controls.Add(label3);
			Controls.Add(label2);
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
		private Label label2;
		private Label label3;
	}
}