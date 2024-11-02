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
			timePicker = new DateTimePicker();
			reasonLabel = new Label();
			dateLabel = new Label();
			timeLabel = new Label();
			searchPatientTextBox = new TextBox();
			searchDoctorTextBox = new TextBox();
			patientsDataGridView = new DataGridView();
			doctorsDataGridView = new DataGridView();
			searchPatientButton = new Button();
			searchDoctorButton = new Button();
			searchPatientLabel = new Label();
			searchDoctorLabel = new Label();
			dateErrorLabel = new Label();
			timeErrorLabel = new Label();
			reasonErrorLabel = new Label();
			doctorErrorLabel = new Label();
			patientErrorLabel = new Label();
			((System.ComponentModel.ISupportInitialize)patientsDataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)doctorsDataGridView).BeginInit();
			SuspendLayout();
			// 
			// reasonTextBox
			// 
			reasonTextBox.Location = new Point(367, 36);
			reasonTextBox.Multiline = true;
			reasonTextBox.Name = "reasonTextBox";
			reasonTextBox.Size = new Size(340, 166);
			reasonTextBox.TabIndex = 5;
			// 
			// datePicker
			// 
			datePicker.Checked = false;
			datePicker.Location = new Point(367, 247);
			datePicker.Margin = new Padding(2);
			datePicker.Name = "datePicker";
			datePicker.Size = new Size(211, 23);
			datePicker.TabIndex = 6;
			// 
			// actionButton
			// 
			actionButton.Enabled = false;
			actionButton.Location = new Point(195, 332);
			actionButton.Margin = new Padding(2);
			actionButton.Name = "actionButton";
			actionButton.Size = new Size(156, 41);
			actionButton.TabIndex = 12;
			actionButton.Text = "Appointment";
			actionButton.UseVisualStyleBackColor = true;
			// 
			// cancelButton
			// 
			cancelButton.Location = new Point(355, 336);
			cancelButton.Margin = new Padding(2);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(125, 33);
			cancelButton.TabIndex = 13;
			cancelButton.Text = "Cancel";
			cancelButton.UseVisualStyleBackColor = true;
			// 
			// timePicker
			// 
			timePicker.Checked = false;
			timePicker.Format = DateTimePickerFormat.Time;
			timePicker.Location = new Point(581, 247);
			timePicker.Margin = new Padding(2);
			timePicker.Name = "timePicker";
			timePicker.Size = new Size(125, 23);
			timePicker.TabIndex = 14;
			// 
			// reasonLabel
			// 
			reasonLabel.AutoSize = true;
			reasonLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			reasonLabel.Location = new Point(367, 17);
			reasonLabel.Name = "reasonLabel";
			reasonLabel.Size = new Size(138, 15);
			reasonLabel.TabIndex = 15;
			reasonLabel.Text = "Reason for appointment:";
			// 
			// dateLabel
			// 
			dateLabel.AutoSize = true;
			dateLabel.Location = new Point(367, 230);
			dateLabel.Margin = new Padding(2, 0, 2, 0);
			dateLabel.Name = "dateLabel";
			dateLabel.Size = new Size(123, 15);
			dateLabel.TabIndex = 18;
			dateLabel.Text = "Date for Appointment";
			// 
			// timeLabel
			// 
			timeLabel.AutoSize = true;
			timeLabel.Location = new Point(581, 230);
			timeLabel.Margin = new Padding(2, 0, 2, 0);
			timeLabel.Name = "timeLabel";
			timeLabel.Size = new Size(125, 15);
			timeLabel.TabIndex = 19;
			timeLabel.Text = "Time for Appointment";
			// 
			// searchPatientTextBox
			// 
			searchPatientTextBox.Location = new Point(12, 35);
			searchPatientTextBox.Name = "searchPatientTextBox";
			searchPatientTextBox.Size = new Size(163, 23);
			searchPatientTextBox.TabIndex = 20;
			// 
			// searchDoctorTextBox
			// 
			searchDoctorTextBox.Location = new Point(12, 194);
			searchDoctorTextBox.Name = "searchDoctorTextBox";
			searchDoctorTextBox.Size = new Size(163, 23);
			searchDoctorTextBox.TabIndex = 21;
			// 
			// patientsDataGridView
			// 
			patientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			patientsDataGridView.Location = new Point(12, 64);
			patientsDataGridView.MultiSelect = false;
			patientsDataGridView.Name = "patientsDataGridView";
			patientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			patientsDataGridView.Size = new Size(339, 87);
			patientsDataGridView.TabIndex = 22;
			// 
			// doctorsDataGridView
			// 
			doctorsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			doctorsDataGridView.Location = new Point(11, 223);
			doctorsDataGridView.MultiSelect = false;
			doctorsDataGridView.Name = "doctorsDataGridView";
			doctorsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			doctorsDataGridView.Size = new Size(340, 87);
			doctorsDataGridView.TabIndex = 23;
			// 
			// searchPatientButton
			// 
			searchPatientButton.Location = new Point(181, 35);
			searchPatientButton.Name = "searchPatientButton";
			searchPatientButton.Size = new Size(75, 23);
			searchPatientButton.TabIndex = 24;
			searchPatientButton.Text = "Search";
			searchPatientButton.UseVisualStyleBackColor = true;
			// 
			// searchDoctorButton
			// 
			searchDoctorButton.Location = new Point(181, 194);
			searchDoctorButton.Name = "searchDoctorButton";
			searchDoctorButton.Size = new Size(75, 23);
			searchDoctorButton.TabIndex = 25;
			searchDoctorButton.Text = "Search";
			searchDoctorButton.UseVisualStyleBackColor = true;
			// 
			// searchPatientLabel
			// 
			searchPatientLabel.AutoSize = true;
			searchPatientLabel.Location = new Point(12, 17);
			searchPatientLabel.Name = "searchPatientLabel";
			searchPatientLabel.Size = new Size(117, 15);
			searchPatientLabel.TabIndex = 26;
			searchPatientLabel.Text = "Search Patient Name";
			// 
			// searchDoctorLabel
			// 
			searchDoctorLabel.AutoSize = true;
			searchDoctorLabel.Location = new Point(11, 176);
			searchDoctorLabel.Name = "searchDoctorLabel";
			searchDoctorLabel.Size = new Size(116, 15);
			searchDoctorLabel.TabIndex = 27;
			searchDoctorLabel.Text = "Search Doctor Name";
			// 
			// dateErrorLabel
			// 
			dateErrorLabel.AutoSize = true;
			dateErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			dateErrorLabel.ForeColor = Color.Red;
			dateErrorLabel.Location = new Point(399, 272);
			dateErrorLabel.Margin = new Padding(2, 0, 2, 0);
			dateErrorLabel.Name = "dateErrorLabel";
			dateErrorLabel.Size = new Size(89, 15);
			dateErrorLabel.TabIndex = 36;
			dateErrorLabel.Text = "dateErrorLabel";
			// 
			// timeErrorLabel
			// 
			timeErrorLabel.AutoSize = true;
			timeErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			timeErrorLabel.ForeColor = Color.Red;
			timeErrorLabel.Location = new Point(598, 272);
			timeErrorLabel.Margin = new Padding(2, 0, 2, 0);
			timeErrorLabel.Name = "timeErrorLabel";
			timeErrorLabel.Size = new Size(90, 15);
			timeErrorLabel.TabIndex = 37;
			timeErrorLabel.Text = "timeErrorLabel";
			// 
			// reasonErrorLabel
			// 
			reasonErrorLabel.AutoSize = true;
			reasonErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			reasonErrorLabel.ForeColor = Color.Red;
			reasonErrorLabel.Location = new Point(510, 17);
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
			doctorErrorLabel.Location = new Point(132, 176);
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
			patientErrorLabel.Location = new Point(134, 17);
			patientErrorLabel.Margin = new Padding(2, 0, 2, 0);
			patientErrorLabel.Name = "patientErrorLabel";
			patientErrorLabel.Size = new Size(104, 15);
			patientErrorLabel.TabIndex = 40;
			patientErrorLabel.Text = "patientErrorLabel";
			// 
			// ManageAppointmentPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(719, 395);
			Controls.Add(patientErrorLabel);
			Controls.Add(doctorErrorLabel);
			Controls.Add(reasonErrorLabel);
			Controls.Add(timeErrorLabel);
			Controls.Add(dateErrorLabel);
			Controls.Add(searchDoctorLabel);
			Controls.Add(searchPatientLabel);
			Controls.Add(searchDoctorButton);
			Controls.Add(searchPatientButton);
			Controls.Add(doctorsDataGridView);
			Controls.Add(patientsDataGridView);
			Controls.Add(searchDoctorTextBox);
			Controls.Add(searchPatientTextBox);
			Controls.Add(timeLabel);
			Controls.Add(dateLabel);
			Controls.Add(reasonLabel);
			Controls.Add(timePicker);
			Controls.Add(cancelButton);
			Controls.Add(actionButton);
			Controls.Add(datePicker);
			Controls.Add(reasonTextBox);
			Name = "ManageAppointmentPage";
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
		private DateTimePicker timePicker;
		private Label reasonLabel;
		private Label dateLabel;
		private Label timeLabel;
		private TextBox searchPatientTextBox;
		private TextBox searchDoctorTextBox;
		private DataGridView patientsDataGridView;
		private DataGridView doctorsDataGridView;
		private Button searchPatientButton;
		private Button searchDoctorButton;
		private Label searchPatientLabel;
		private Label searchDoctorLabel;
		private Label dateErrorLabel;
		private Label timeErrorLabel;
		private Label reasonErrorLabel;
		private Label doctorErrorLabel;
		private Label patientErrorLabel;
	}
}