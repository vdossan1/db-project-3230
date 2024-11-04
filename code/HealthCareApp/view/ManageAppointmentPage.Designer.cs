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
            searchPatientTextBox = new TextBox();
            searchDoctorTextBox = new TextBox();
            patientsDataGridView = new DataGridView();
            doctorsDataGridView = new DataGridView();
            searchPatientButton = new Button();
            searchDoctorButton = new Button();
            searchPatientLabel = new Label();
            searchDoctorLabel = new Label();
            dateErrorLabel = new Label();
            reasonErrorLabel = new Label();
            doctorErrorLabel = new Label();
            patientErrorLabel = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)patientsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doctorsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // reasonTextBox
            // 
            reasonTextBox.Location = new Point(391, 35);
            reasonTextBox.Multiline = true;
            reasonTextBox.Name = "reasonTextBox";
            reasonTextBox.Size = new Size(340, 229);
            reasonTextBox.TabIndex = 6;
            // 
            // datePicker
            // 
            datePicker.Checked = false;
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.Location = new Point(391, 352);
            datePicker.Margin = new Padding(2);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(211, 23);
            datePicker.TabIndex = 7;
            // 
            // actionButton
            // 
            actionButton.Enabled = false;
            actionButton.Location = new Point(391, 511);
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
            cancelButton.Location = new Point(551, 515);
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
            reasonLabel.Location = new Point(391, 16);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new Size(138, 15);
            reasonLabel.TabIndex = 15;
            reasonLabel.Text = "Reason for appointment:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(391, 305);
            dateLabel.Margin = new Padding(2, 0, 2, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(175, 15);
            dateLabel.TabIndex = 18;
            dateLabel.Text = "Date and Time for Appointment";
            // 
            // searchPatientTextBox
            // 
            searchPatientTextBox.Location = new Point(12, 35);
            searchPatientTextBox.Name = "searchPatientTextBox";
            searchPatientTextBox.Size = new Size(163, 23);
            searchPatientTextBox.TabIndex = 0;
            // 
            // searchDoctorTextBox
            // 
            searchDoctorTextBox.Location = new Point(13, 323);
            searchDoctorTextBox.Name = "searchDoctorTextBox";
            searchDoctorTextBox.Size = new Size(163, 23);
            searchDoctorTextBox.TabIndex = 3;
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
            patientsDataGridView.Location = new Point(12, 64);
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
            doctorsDataGridView.Location = new Point(12, 352);
            doctorsDataGridView.MultiSelect = false;
            doctorsDataGridView.Name = "doctorsDataGridView";
            doctorsDataGridView.RowHeadersVisible = false;
            doctorsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            doctorsDataGridView.Size = new Size(300, 200);
            doctorsDataGridView.StandardTab = true;
            doctorsDataGridView.TabIndex = 4;
            doctorsDataGridView.SelectionChanged += doctorsDataGridView_SelectionChanged;
            // 
            // searchPatientButton
            // 
            searchPatientButton.Location = new Point(181, 35);
            searchPatientButton.Name = "searchPatientButton";
            searchPatientButton.Size = new Size(75, 23);
            searchPatientButton.TabIndex = 2;
            searchPatientButton.Text = "Search";
            searchPatientButton.UseVisualStyleBackColor = true;
            // 
            // searchDoctorButton
            // 
            searchDoctorButton.Location = new Point(182, 323);
            searchDoctorButton.Name = "searchDoctorButton";
            searchDoctorButton.Size = new Size(75, 23);
            searchDoctorButton.TabIndex = 5;
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
            searchDoctorLabel.Location = new Point(12, 305);
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
            dateErrorLabel.Location = new Point(392, 377);
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
            reasonErrorLabel.Location = new Point(534, 16);
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
            doctorErrorLabel.Location = new Point(133, 305);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(391, 326);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 15);
            label1.TabIndex = 41;
            label1.Text = "Must be after current date and time";
            // 
            // ManageAppointmentPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 577);
            Controls.Add(label1);
            Controls.Add(patientErrorLabel);
            Controls.Add(doctorErrorLabel);
            Controls.Add(reasonErrorLabel);
            Controls.Add(dateErrorLabel);
            Controls.Add(searchDoctorLabel);
            Controls.Add(searchPatientLabel);
            Controls.Add(searchDoctorButton);
            Controls.Add(searchPatientButton);
            Controls.Add(doctorsDataGridView);
            Controls.Add(patientsDataGridView);
            Controls.Add(searchDoctorTextBox);
            Controls.Add(searchPatientTextBox);
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
        private TextBox searchPatientTextBox;
        private TextBox searchDoctorTextBox;
        private DataGridView patientsDataGridView;
        private DataGridView doctorsDataGridView;
        private Button searchPatientButton;
        private Button searchDoctorButton;
        private Label searchPatientLabel;
        private Label searchDoctorLabel;
        private Label dateErrorLabel;
        private Label reasonErrorLabel;
        private Label doctorErrorLabel;
        private Label patientErrorLabel;
        private Label label1;
    }
}