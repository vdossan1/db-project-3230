namespace HealthCareApp.view
{
	partial class AppointmentsControl
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
            appointmentsDataGridView = new DataGridView();
            createAppointmentBtn = new Button();
            editAppointmentBtn = new Button();
            apptAdvancedSearchControl = new AdvancedSearchControl();
            upcomingApptLabel = new Label();
            label1 = new Label();
            closedApptDataGrid = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            farenheitLabel = new Label();
            bpmLabel = new Label();
            feetLabel = new Label();
            lbsLabel = new Label();
            apptTextLabel = new Label();
            finalDiagnosesTxtBox = new RichTextBox();
            initDiagnosesTxtBox = new RichTextBox();
            symptomsTxtBox = new RichTextBox();
            pulseTxtField = new TextBox();
            bodyTempTxtField = new TextBox();
            heightTxtField = new TextBox();
            weightTxtField = new TextBox();
            bloodPressureDiasTxtField = new TextBox();
            bloodPressureSysTxtField = new TextBox();
            finalDiagnosesLabel = new Label();
            initialDiagnosesLabel = new Label();
            symptomsLabel = new Label();
            pulseLabel = new Label();
            heightLabel = new Label();
            weightLabel = new Label();
            bodyTempLabel = new Label();
            bloodPressureDiasLabel = new Label();
            bloodPressureSysLabel = new Label();
            testResultDataGrid = new DataGridView();
            enterTestResultButton = new Button();
            editVisitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closedApptDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)testResultDataGrid).BeginInit();
            SuspendLayout();
            // 
            // appointmentsDataGridView
            // 
            appointmentsDataGridView.AllowUserToAddRows = false;
            appointmentsDataGridView.AllowUserToDeleteRows = false;
            appointmentsDataGridView.AllowUserToResizeColumns = false;
            appointmentsDataGridView.AllowUserToResizeRows = false;
            appointmentsDataGridView.BackgroundColor = SystemColors.Control;
            appointmentsDataGridView.ColumnHeadersHeight = 34;
            appointmentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            appointmentsDataGridView.GridColor = SystemColors.Control;
            appointmentsDataGridView.Location = new Point(24, 337);
            appointmentsDataGridView.Margin = new Padding(4, 5, 4, 5);
            appointmentsDataGridView.MultiSelect = false;
            appointmentsDataGridView.Name = "appointmentsDataGridView";
            appointmentsDataGridView.ReadOnly = true;
            appointmentsDataGridView.RowHeadersVisible = false;
            appointmentsDataGridView.RowHeadersWidth = 62;
            appointmentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentsDataGridView.Size = new Size(913, 391);
            appointmentsDataGridView.TabIndex = 9;
            // 
            // createAppointmentBtn
            // 
            createAppointmentBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createAppointmentBtn.Location = new Point(135, 26);
            createAppointmentBtn.Name = "createAppointmentBtn";
            createAppointmentBtn.Size = new Size(286, 52);
            createAppointmentBtn.TabIndex = 10;
            createAppointmentBtn.Text = "Create Appointment";
            createAppointmentBtn.UseVisualStyleBackColor = true;
            createAppointmentBtn.Click += createAppointmentBtn_Click;
            // 
            // editAppointmentBtn
            // 
            editAppointmentBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editAppointmentBtn.Location = new Point(427, 26);
            editAppointmentBtn.Name = "editAppointmentBtn";
            editAppointmentBtn.Size = new Size(286, 52);
            editAppointmentBtn.TabIndex = 10;
            editAppointmentBtn.Text = "Edit Appointment";
            editAppointmentBtn.UseVisualStyleBackColor = true;
            editAppointmentBtn.Click += editAppointmentBtn_Click;
            // 
            // apptAdvancedSearchControl
            // 
            apptAdvancedSearchControl.Location = new Point(24, 105);
            apptAdvancedSearchControl.Margin = new Padding(1, 2, 1, 2);
            apptAdvancedSearchControl.Name = "apptAdvancedSearchControl";
            apptAdvancedSearchControl.Size = new Size(1034, 158);
            apptAdvancedSearchControl.TabIndex = 12;
            // 
            // upcomingApptLabel
            // 
            upcomingApptLabel.AutoSize = true;
            upcomingApptLabel.Location = new Point(30, 297);
            upcomingApptLabel.Name = "upcomingApptLabel";
            upcomingApptLabel.Size = new Size(313, 25);
            upcomingApptLabel.TabIndex = 13;
            upcomingApptLabel.Text = "Today's and Upcoming Appointments";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 849);
            label1.Name = "label1";
            label1.Size = new Size(234, 25);
            label1.TabIndex = 14;
            label1.Text = "Past / Closed Appointments";
            // 
            // closedApptDataGrid
            // 
            closedApptDataGrid.AllowUserToAddRows = false;
            closedApptDataGrid.AllowUserToDeleteRows = false;
            closedApptDataGrid.AllowUserToResizeColumns = false;
            closedApptDataGrid.AllowUserToResizeRows = false;
            closedApptDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            closedApptDataGrid.Location = new Point(30, 916);
            closedApptDataGrid.MultiSelect = false;
            closedApptDataGrid.Name = "closedApptDataGrid";
            closedApptDataGrid.RowHeadersVisible = false;
            closedApptDataGrid.RowHeadersWidth = 62;
            closedApptDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            closedApptDataGrid.Size = new Size(907, 390);
            closedApptDataGrid.TabIndex = 15;
            closedApptDataGrid.SelectionChanged += closedApptDataGrid_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1405, 232);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 84;
            label2.Text = "mm Hg";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1405, 154);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 83;
            label3.Text = "mm Hg";
            // 
            // farenheitLabel
            // 
            farenheitLabel.AutoSize = true;
            farenheitLabel.Location = new Point(1613, 384);
            farenheitLabel.Name = "farenheitLabel";
            farenheitLabel.Size = new Size(21, 25);
            farenheitLabel.TabIndex = 82;
            farenheitLabel.Text = "F";
            // 
            // bpmLabel
            // 
            bpmLabel.AutoSize = true;
            bpmLabel.Location = new Point(1496, 314);
            bpmLabel.Name = "bpmLabel";
            bpmLabel.Size = new Size(48, 25);
            bpmLabel.TabIndex = 81;
            bpmLabel.Text = "BPM";
            // 
            // feetLabel
            // 
            feetLabel.AutoSize = true;
            feetLabel.Location = new Point(1278, 384);
            feetLabel.Name = "feetLabel";
            feetLabel.Size = new Size(61, 25);
            feetLabel.TabIndex = 80;
            feetLabel.Text = "inches";
            // 
            // lbsLabel
            // 
            lbsLabel.AutoSize = true;
            lbsLabel.Location = new Point(1291, 313);
            lbsLabel.Name = "lbsLabel";
            lbsLabel.Size = new Size(35, 25);
            lbsLabel.TabIndex = 79;
            lbsLabel.Text = "lbs";
            // 
            // apptTextLabel
            // 
            apptTextLabel.AutoSize = true;
            apptTextLabel.Location = new Point(1156, 1);
            apptTextLabel.Name = "apptTextLabel";
            apptTextLabel.Size = new Size(0, 25);
            apptTextLabel.TabIndex = 68;
            // 
            // finalDiagnosesTxtBox
            // 
            finalDiagnosesTxtBox.Enabled = false;
            finalDiagnosesTxtBox.Location = new Point(1098, 731);
            finalDiagnosesTxtBox.MaxLength = 200;
            finalDiagnosesTxtBox.Name = "finalDiagnosesTxtBox";
            finalDiagnosesTxtBox.Size = new Size(984, 165);
            finalDiagnosesTxtBox.TabIndex = 66;
            finalDiagnosesTxtBox.Text = "";
            // 
            // initDiagnosesTxtBox
            // 
            initDiagnosesTxtBox.Enabled = false;
            initDiagnosesTxtBox.Location = new Point(1098, 504);
            initDiagnosesTxtBox.MaxLength = 200;
            initDiagnosesTxtBox.Name = "initDiagnosesTxtBox";
            initDiagnosesTxtBox.Size = new Size(984, 158);
            initDiagnosesTxtBox.TabIndex = 64;
            initDiagnosesTxtBox.Text = "";
            // 
            // symptomsTxtBox
            // 
            symptomsTxtBox.Enabled = false;
            symptomsTxtBox.Location = new Point(1624, 125);
            symptomsTxtBox.MaxLength = 200;
            symptomsTxtBox.Name = "symptomsTxtBox";
            symptomsTxtBox.Size = new Size(458, 233);
            symptomsTxtBox.TabIndex = 62;
            symptomsTxtBox.Text = "";
            // 
            // pulseTxtField
            // 
            pulseTxtField.Enabled = false;
            pulseTxtField.Location = new Point(1405, 310);
            pulseTxtField.MaxLength = 4;
            pulseTxtField.Name = "pulseTxtField";
            pulseTxtField.Size = new Size(85, 31);
            pulseTxtField.TabIndex = 57;
            // 
            // bodyTempTxtField
            // 
            bodyTempTxtField.Enabled = false;
            bodyTempTxtField.Location = new Point(1512, 379);
            bodyTempTxtField.MaxLength = 5;
            bodyTempTxtField.Name = "bodyTempTxtField";
            bodyTempTxtField.Size = new Size(95, 31);
            bodyTempTxtField.TabIndex = 60;
            // 
            // heightTxtField
            // 
            heightTxtField.Enabled = false;
            heightTxtField.Location = new Point(1170, 384);
            heightTxtField.MaxLength = 6;
            heightTxtField.Name = "heightTxtField";
            heightTxtField.Size = new Size(100, 31);
            heightTxtField.TabIndex = 56;
            // 
            // weightTxtField
            // 
            weightTxtField.Enabled = false;
            weightTxtField.Location = new Point(1170, 313);
            weightTxtField.MaxLength = 6;
            weightTxtField.Name = "weightTxtField";
            weightTxtField.Size = new Size(101, 31);
            weightTxtField.TabIndex = 53;
            // 
            // bloodPressureDiasTxtField
            // 
            bloodPressureDiasTxtField.Enabled = false;
            bloodPressureDiasTxtField.Location = new Point(1299, 232);
            bloodPressureDiasTxtField.MaxLength = 3;
            bloodPressureDiasTxtField.Name = "bloodPressureDiasTxtField";
            bloodPressureDiasTxtField.Size = new Size(100, 31);
            bloodPressureDiasTxtField.TabIndex = 51;
            // 
            // bloodPressureSysTxtField
            // 
            bloodPressureSysTxtField.Enabled = false;
            bloodPressureSysTxtField.Location = new Point(1299, 151);
            bloodPressureSysTxtField.MaxLength = 3;
            bloodPressureSysTxtField.Name = "bloodPressureSysTxtField";
            bloodPressureSysTxtField.Size = new Size(100, 31);
            bloodPressureSysTxtField.TabIndex = 49;
            // 
            // finalDiagnosesLabel
            // 
            finalDiagnosesLabel.AutoSize = true;
            finalDiagnosesLabel.Location = new Point(1099, 702);
            finalDiagnosesLabel.Name = "finalDiagnosesLabel";
            finalDiagnosesLabel.Size = new Size(136, 25);
            finalDiagnosesLabel.TabIndex = 67;
            finalDiagnosesLabel.Text = "Final Diagnoses";
            // 
            // initialDiagnosesLabel
            // 
            initialDiagnosesLabel.AutoSize = true;
            initialDiagnosesLabel.Location = new Point(1099, 476);
            initialDiagnosesLabel.Name = "initialDiagnosesLabel";
            initialDiagnosesLabel.Size = new Size(142, 25);
            initialDiagnosesLabel.TabIndex = 65;
            initialDiagnosesLabel.Text = "Initial Diagnoses";
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new Point(1624, 78);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new Size(98, 25);
            symptomsLabel.TabIndex = 63;
            symptomsLabel.Text = "Symptoms";
            // 
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Location = new Point(1346, 314);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new Size(53, 25);
            pulseLabel.TabIndex = 61;
            pulseLabel.Text = "Pulse";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(1098, 380);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(65, 25);
            heightLabel.TabIndex = 59;
            heightLabel.Text = "Height";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new Point(1093, 313);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(68, 25);
            weightLabel.TabIndex = 58;
            weightLabel.Text = "Weight";
            // 
            // bodyTempLabel
            // 
            bodyTempLabel.AutoSize = true;
            bodyTempLabel.Location = new Point(1351, 384);
            bodyTempLabel.Name = "bodyTempLabel";
            bodyTempLabel.Size = new Size(156, 25);
            bodyTempLabel.TabIndex = 55;
            bodyTempLabel.Text = "Body Temperature";
            // 
            // bloodPressureDiasLabel
            // 
            bloodPressureDiasLabel.AutoSize = true;
            bloodPressureDiasLabel.Location = new Point(1085, 232);
            bloodPressureDiasLabel.Name = "bloodPressureDiasLabel";
            bloodPressureDiasLabel.Size = new Size(202, 25);
            bloodPressureDiasLabel.TabIndex = 54;
            bloodPressureDiasLabel.Text = "Blood Pressure Diastolic";
            // 
            // bloodPressureSysLabel
            // 
            bloodPressureSysLabel.AutoSize = true;
            bloodPressureSysLabel.Location = new Point(1085, 151);
            bloodPressureSysLabel.Name = "bloodPressureSysLabel";
            bloodPressureSysLabel.Size = new Size(194, 25);
            bloodPressureSysLabel.TabIndex = 52;
            bloodPressureSysLabel.Text = "Blood Pressure Systolic";
            // 
            // testResultDataGrid
            // 
            testResultDataGrid.AllowUserToAddRows = false;
            testResultDataGrid.AllowUserToDeleteRows = false;
            testResultDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            testResultDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            testResultDataGrid.Location = new Point(1099, 936);
            testResultDataGrid.MultiSelect = false;
            testResultDataGrid.Name = "testResultDataGrid";
            testResultDataGrid.RowHeadersVisible = false;
            testResultDataGrid.RowHeadersWidth = 62;
            testResultDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            testResultDataGrid.Size = new Size(983, 198);
            testResultDataGrid.TabIndex = 89;
            // 
            // enterTestResultButton
            // 
            enterTestResultButton.Location = new Point(1695, 1175);
            enterTestResultButton.Name = "enterTestResultButton";
            enterTestResultButton.Size = new Size(217, 58);
            enterTestResultButton.TabIndex = 90;
            enterTestResultButton.Text = "Enter Test Result";
            enterTestResultButton.UseVisualStyleBackColor = true;
            enterTestResultButton.Click += enterTestResultButton_Click;
            // 
            // editVisitButton
            // 
            editVisitButton.Location = new Point(1287, 1175);
            editVisitButton.Name = "editVisitButton";
            editVisitButton.Size = new Size(203, 58);
            editVisitButton.TabIndex = 91;
            editVisitButton.Text = "Edit Visit";
            editVisitButton.UseVisualStyleBackColor = true;
            editVisitButton.Click += editVisitButton_Click;
            // 
            // AppointmentsControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(editVisitButton);
            Controls.Add(enterTestResultButton);
            Controls.Add(testResultDataGrid);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(farenheitLabel);
            Controls.Add(bpmLabel);
            Controls.Add(feetLabel);
            Controls.Add(lbsLabel);
            Controls.Add(apptTextLabel);
            Controls.Add(finalDiagnosesTxtBox);
            Controls.Add(initDiagnosesTxtBox);
            Controls.Add(symptomsTxtBox);
            Controls.Add(pulseTxtField);
            Controls.Add(bodyTempTxtField);
            Controls.Add(heightTxtField);
            Controls.Add(weightTxtField);
            Controls.Add(bloodPressureDiasTxtField);
            Controls.Add(bloodPressureSysTxtField);
            Controls.Add(finalDiagnosesLabel);
            Controls.Add(initialDiagnosesLabel);
            Controls.Add(symptomsLabel);
            Controls.Add(pulseLabel);
            Controls.Add(heightLabel);
            Controls.Add(weightLabel);
            Controls.Add(bodyTempLabel);
            Controls.Add(bloodPressureDiasLabel);
            Controls.Add(bloodPressureSysLabel);
            Controls.Add(closedApptDataGrid);
            Controls.Add(label1);
            Controls.Add(upcomingApptLabel);
            Controls.Add(apptAdvancedSearchControl);
            Controls.Add(editAppointmentBtn);
            Controls.Add(createAppointmentBtn);
            Controls.Add(appointmentsDataGridView);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AppointmentsControl";
            Size = new Size(2500, 1391);
            ((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)closedApptDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)testResultDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView appointmentsDataGridView;
		private Button createAppointmentBtn;
		private Button editAppointmentBtn;
        private AdvancedSearchControl apptAdvancedSearchControl;
        private Label upcomingApptLabel;
        private Label label1;
        private DataGridView closedApptDataGrid;
        private Label label2;
        private Label label3;
        private Label farenheitLabel;
        private Label bpmLabel;
        private Label feetLabel;
        private Label lbsLabel;
        private Label apptTextLabel;
        private RichTextBox finalDiagnosesTxtBox;
        private RichTextBox initDiagnosesTxtBox;
        private RichTextBox symptomsTxtBox;
        private TextBox pulseTxtField;
        private TextBox bodyTempTxtField;
        private TextBox heightTxtField;
        private TextBox weightTxtField;
        private TextBox bloodPressureDiasTxtField;
        private TextBox bloodPressureSysTxtField;
        private Label finalDiagnosesLabel;
        private Label initialDiagnosesLabel;
        private Label symptomsLabel;
        private Label pulseLabel;
        private Label heightLabel;
        private Label weightLabel;
        private Label bodyTempLabel;
        private Label bloodPressureDiasLabel;
        private Label bloodPressureSysLabel;
        private DataGridView testResultDataGrid;
        private Button enterTestResultButton;
        private Button editVisitButton;
    }
}
