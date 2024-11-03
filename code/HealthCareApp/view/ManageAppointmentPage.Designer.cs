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
            reasonTextBox.Location = new Point(524, 60);
            reasonTextBox.Margin = new Padding(4, 5, 4, 5);
            reasonTextBox.Multiline = true;
            reasonTextBox.Name = "reasonTextBox";
            reasonTextBox.Size = new Size(484, 274);
            reasonTextBox.TabIndex = 6;
            // 
            // datePicker
            // 
            datePicker.Checked = false;
            datePicker.Location = new Point(524, 412);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(300, 31);
            datePicker.TabIndex = 7;
            // 
            // actionButton
            // 
            actionButton.Enabled = false;
            actionButton.Location = new Point(279, 553);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(223, 68);
            actionButton.TabIndex = 9;
            actionButton.Text = "Appointment";
            actionButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(507, 560);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(179, 55);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelBtn_Click;
            // 
            // timePicker
            // 
            timePicker.Checked = false;
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(830, 412);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(177, 31);
            timePicker.TabIndex = 8;
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reasonLabel.Location = new Point(524, 28);
            reasonLabel.Margin = new Padding(4, 0, 4, 0);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new Size(209, 25);
            reasonLabel.TabIndex = 15;
            reasonLabel.Text = "Reason for appointment:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(524, 383);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(294, 25);
            dateLabel.TabIndex = 18;
            dateLabel.Text = "AppointmentDate for Appointment";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(830, 383);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(295, 25);
            timeLabel.TabIndex = 19;
            timeLabel.Text = "AppointmentTime for Appointment";
            // 
            // searchPatientTextBox
            // 
            searchPatientTextBox.Location = new Point(17, 58);
            searchPatientTextBox.Margin = new Padding(4, 5, 4, 5);
            searchPatientTextBox.Name = "searchPatientTextBox";
            searchPatientTextBox.Size = new Size(231, 31);
            searchPatientTextBox.TabIndex = 0;
            // 
            // searchDoctorTextBox
            // 
            searchDoctorTextBox.Location = new Point(17, 323);
            searchDoctorTextBox.Margin = new Padding(4, 5, 4, 5);
            searchDoctorTextBox.Name = "searchDoctorTextBox";
            searchDoctorTextBox.Size = new Size(231, 31);
            searchDoctorTextBox.TabIndex = 3;
            // 
            // patientsDataGridView
            // 
            patientsDataGridView.BackgroundColor = SystemColors.Control;
            patientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientsDataGridView.GridColor = SystemColors.Control;
            patientsDataGridView.Location = new Point(17, 107);
            patientsDataGridView.Margin = new Padding(4, 5, 4, 5);
            patientsDataGridView.MultiSelect = false;
            patientsDataGridView.Name = "patientsDataGridView";
            patientsDataGridView.RowHeadersVisible = false;
            patientsDataGridView.RowHeadersWidth = 62;
            patientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            patientsDataGridView.Size = new Size(484, 145);
            patientsDataGridView.StandardTab = true;
            patientsDataGridView.TabIndex = 2;
            // 
            // doctorsDataGridView
            // 
            doctorsDataGridView.BackgroundColor = SystemColors.Control;
            doctorsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorsDataGridView.GridColor = SystemColors.Control;
            doctorsDataGridView.Location = new Point(16, 372);
            doctorsDataGridView.Margin = new Padding(4, 5, 4, 5);
            doctorsDataGridView.MultiSelect = false;
            doctorsDataGridView.Name = "doctorsDataGridView";
            doctorsDataGridView.RowHeadersVisible = false;
            doctorsDataGridView.RowHeadersWidth = 62;
            doctorsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            doctorsDataGridView.Size = new Size(486, 145);
            doctorsDataGridView.StandardTab = true;
            doctorsDataGridView.TabIndex = 4;
            // 
            // searchPatientButton
            // 
            searchPatientButton.Location = new Point(259, 58);
            searchPatientButton.Margin = new Padding(4, 5, 4, 5);
            searchPatientButton.Name = "searchPatientButton";
            searchPatientButton.Size = new Size(107, 38);
            searchPatientButton.TabIndex = 2;
            searchPatientButton.Text = "Search";
            searchPatientButton.UseVisualStyleBackColor = true;
            // 
            // searchDoctorButton
            // 
            searchDoctorButton.Location = new Point(259, 323);
            searchDoctorButton.Margin = new Padding(4, 5, 4, 5);
            searchDoctorButton.Name = "searchDoctorButton";
            searchDoctorButton.Size = new Size(107, 38);
            searchDoctorButton.TabIndex = 5;
            searchDoctorButton.Text = "Search";
            searchDoctorButton.UseVisualStyleBackColor = true;
            // 
            // searchPatientLabel
            // 
            searchPatientLabel.AutoSize = true;
            searchPatientLabel.Location = new Point(17, 28);
            searchPatientLabel.Margin = new Padding(4, 0, 4, 0);
            searchPatientLabel.Name = "searchPatientLabel";
            searchPatientLabel.Size = new Size(174, 25);
            searchPatientLabel.TabIndex = 26;
            searchPatientLabel.Text = "Search Patient Name";
            // 
            // searchDoctorLabel
            // 
            searchDoctorLabel.AutoSize = true;
            searchDoctorLabel.Location = new Point(16, 293);
            searchDoctorLabel.Margin = new Padding(4, 0, 4, 0);
            searchDoctorLabel.Name = "searchDoctorLabel";
            searchDoctorLabel.Size = new Size(176, 25);
            searchDoctorLabel.TabIndex = 27;
            searchDoctorLabel.Text = "Search Doctor Name";
            // 
            // dateErrorLabel
            // 
            dateErrorLabel.AutoSize = true;
            dateErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dateErrorLabel.ForeColor = Color.Red;
            dateErrorLabel.Location = new Point(570, 453);
            dateErrorLabel.Name = "dateErrorLabel";
            dateErrorLabel.Size = new Size(137, 25);
            dateErrorLabel.TabIndex = 36;
            dateErrorLabel.Text = "dateErrorLabel";
            // 
            // timeErrorLabel
            // 
            timeErrorLabel.AutoSize = true;
            timeErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            timeErrorLabel.ForeColor = Color.Red;
            timeErrorLabel.Location = new Point(854, 453);
            timeErrorLabel.Name = "timeErrorLabel";
            timeErrorLabel.Size = new Size(137, 25);
            timeErrorLabel.TabIndex = 37;
            timeErrorLabel.Text = "timeErrorLabel";
            // 
            // reasonErrorLabel
            // 
            reasonErrorLabel.AutoSize = true;
            reasonErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            reasonErrorLabel.ForeColor = Color.Red;
            reasonErrorLabel.Location = new Point(729, 28);
            reasonErrorLabel.Name = "reasonErrorLabel";
            reasonErrorLabel.Size = new Size(156, 25);
            reasonErrorLabel.TabIndex = 38;
            reasonErrorLabel.Text = "reasonErrorLabel";
            // 
            // doctorErrorLabel
            // 
            doctorErrorLabel.AutoSize = true;
            doctorErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            doctorErrorLabel.ForeColor = Color.Red;
            doctorErrorLabel.Location = new Point(189, 293);
            doctorErrorLabel.Name = "doctorErrorLabel";
            doctorErrorLabel.Size = new Size(155, 25);
            doctorErrorLabel.TabIndex = 39;
            doctorErrorLabel.Text = "doctorErrorLabel";
            // 
            // patientErrorLabel
            // 
            patientErrorLabel.AutoSize = true;
            patientErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            patientErrorLabel.ForeColor = Color.Red;
            patientErrorLabel.Location = new Point(191, 28);
            patientErrorLabel.Name = "patientErrorLabel";
            patientErrorLabel.Size = new Size(160, 25);
            patientErrorLabel.TabIndex = 40;
            patientErrorLabel.Text = "patientErrorLabel";
            // 
            // ManageAppointmentPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 658);
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
            Margin = new Padding(4, 5, 4, 5);
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