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
			label4 = new Label();
			label5 = new Label();
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
			appointmentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			appointmentsDataGridView.BackgroundColor = SystemColors.Control;
			appointmentsDataGridView.BorderStyle = BorderStyle.Fixed3D;
			appointmentsDataGridView.ColumnHeadersHeight = 30;
			appointmentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			appointmentsDataGridView.GridColor = SystemColors.Control;
			appointmentsDataGridView.Location = new Point(10, 105);
			appointmentsDataGridView.Margin = new Padding(2);
			appointmentsDataGridView.MultiSelect = false;
			appointmentsDataGridView.Name = "appointmentsDataGridView";
			appointmentsDataGridView.ReadOnly = true;
			appointmentsDataGridView.RowHeadersVisible = false;
			appointmentsDataGridView.RowHeadersWidth = 62;
			appointmentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			appointmentsDataGridView.Size = new Size(700, 300);
			appointmentsDataGridView.TabIndex = 9;
			// 
			// createAppointmentBtn
			// 
			createAppointmentBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			createAppointmentBtn.Location = new Point(735, 3);
			createAppointmentBtn.Margin = new Padding(2);
			createAppointmentBtn.Name = "createAppointmentBtn";
			createAppointmentBtn.Size = new Size(150, 35);
			createAppointmentBtn.TabIndex = 10;
			createAppointmentBtn.Text = "Create Appointment";
			createAppointmentBtn.UseVisualStyleBackColor = true;
			createAppointmentBtn.Click += createAppointmentBtn_Click;
			// 
			// editAppointmentBtn
			// 
			editAppointmentBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			editAppointmentBtn.Location = new Point(889, 3);
			editAppointmentBtn.Margin = new Padding(2);
			editAppointmentBtn.Name = "editAppointmentBtn";
			editAppointmentBtn.Size = new Size(150, 35);
			editAppointmentBtn.TabIndex = 10;
			editAppointmentBtn.Text = "Edit Appointment";
			editAppointmentBtn.UseVisualStyleBackColor = true;
			editAppointmentBtn.Click += editAppointmentBtn_Click;
			// 
			// apptAdvancedSearchControl
			// 
			apptAdvancedSearchControl.Location = new Point(10, 0);
			apptAdvancedSearchControl.Margin = new Padding(1);
			apptAdvancedSearchControl.Name = "apptAdvancedSearchControl";
			apptAdvancedSearchControl.Size = new Size(700, 80);
			apptAdvancedSearchControl.TabIndex = 12;
			// 
			// upcomingApptLabel
			// 
			upcomingApptLabel.AutoSize = true;
			upcomingApptLabel.Location = new Point(10, 85);
			upcomingApptLabel.Margin = new Padding(2, 0, 2, 0);
			upcomingApptLabel.Name = "upcomingApptLabel";
			upcomingApptLabel.Size = new Size(207, 15);
			upcomingApptLabel.TabIndex = 13;
			upcomingApptLabel.Text = "Today's and Upcoming Appointments";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(10, 415);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(155, 15);
			label1.TabIndex = 14;
			label1.Text = "Past / Closed Appointments";
			// 
			// closedApptDataGrid
			// 
			closedApptDataGrid.AllowUserToAddRows = false;
			closedApptDataGrid.AllowUserToDeleteRows = false;
			closedApptDataGrid.AllowUserToResizeColumns = false;
			closedApptDataGrid.AllowUserToResizeRows = false;
			closedApptDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			closedApptDataGrid.BackgroundColor = SystemColors.Control;
			closedApptDataGrid.BorderStyle = BorderStyle.Fixed3D;
			closedApptDataGrid.ColumnHeadersHeight = 30;
			closedApptDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			closedApptDataGrid.GridColor = SystemColors.Control;
			closedApptDataGrid.Location = new Point(10, 435);
			closedApptDataGrid.Margin = new Padding(2);
			closedApptDataGrid.MultiSelect = false;
			closedApptDataGrid.Name = "closedApptDataGrid";
			closedApptDataGrid.ReadOnly = true;
			closedApptDataGrid.RowHeadersVisible = false;
			closedApptDataGrid.RowHeadersWidth = 62;
			closedApptDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			closedApptDataGrid.Size = new Size(700, 300);
			closedApptDataGrid.TabIndex = 15;
			closedApptDataGrid.SelectionChanged += closedApptDataGrid_SelectionChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(959, 165);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(48, 15);
			label2.TabIndex = 84;
			label2.Text = "mm Hg";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(959, 125);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(48, 15);
			label3.TabIndex = 83;
			label3.Text = "mm Hg";
			// 
			// farenheitLabel
			// 
			farenheitLabel.AutoSize = true;
			farenheitLabel.Location = new Point(959, 285);
			farenheitLabel.Margin = new Padding(2, 0, 2, 0);
			farenheitLabel.Name = "farenheitLabel";
			farenheitLabel.Size = new Size(13, 15);
			farenheitLabel.TabIndex = 82;
			farenheitLabel.Text = "F";
			// 
			// bpmLabel
			// 
			bpmLabel.AutoSize = true;
			bpmLabel.Location = new Point(959, 325);
			bpmLabel.Margin = new Padding(2, 0, 2, 0);
			bpmLabel.Name = "bpmLabel";
			bpmLabel.Size = new Size(32, 15);
			bpmLabel.TabIndex = 81;
			bpmLabel.Text = "BPM";
			// 
			// feetLabel
			// 
			feetLabel.AutoSize = true;
			feetLabel.Location = new Point(959, 245);
			feetLabel.Margin = new Padding(2, 0, 2, 0);
			feetLabel.Name = "feetLabel";
			feetLabel.Size = new Size(41, 15);
			feetLabel.TabIndex = 80;
			feetLabel.Text = "inches";
			// 
			// lbsLabel
			// 
			lbsLabel.AutoSize = true;
			lbsLabel.Location = new Point(959, 205);
			lbsLabel.Margin = new Padding(2, 0, 2, 0);
			lbsLabel.Name = "lbsLabel";
			lbsLabel.Size = new Size(22, 15);
			lbsLabel.TabIndex = 79;
			lbsLabel.Text = "lbs";
			// 
			// apptTextLabel
			// 
			apptTextLabel.AutoSize = true;
			apptTextLabel.Location = new Point(819, 1);
			apptTextLabel.Margin = new Padding(2, 0, 2, 0);
			apptTextLabel.Name = "apptTextLabel";
			apptTextLabel.Size = new Size(0, 15);
			apptTextLabel.TabIndex = 68;
			// 
			// finalDiagnosesTxtBox
			// 
			finalDiagnosesTxtBox.BorderStyle = BorderStyle.None;
			finalDiagnosesTxtBox.Enabled = false;
			finalDiagnosesTxtBox.Location = new Point(1060, 407);
			finalDiagnosesTxtBox.Margin = new Padding(2);
			finalDiagnosesTxtBox.MaxLength = 200;
			finalDiagnosesTxtBox.Name = "finalDiagnosesTxtBox";
			finalDiagnosesTxtBox.Size = new Size(300, 100);
			finalDiagnosesTxtBox.TabIndex = 66;
			finalDiagnosesTxtBox.Text = "";
			// 
			// initDiagnosesTxtBox
			// 
			initDiagnosesTxtBox.BorderStyle = BorderStyle.None;
			initDiagnosesTxtBox.Enabled = false;
			initDiagnosesTxtBox.Location = new Point(735, 407);
			initDiagnosesTxtBox.Margin = new Padding(2);
			initDiagnosesTxtBox.MaxLength = 200;
			initDiagnosesTxtBox.Name = "initDiagnosesTxtBox";
			initDiagnosesTxtBox.Size = new Size(300, 100);
			initDiagnosesTxtBox.TabIndex = 64;
			initDiagnosesTxtBox.Text = "";
			// 
			// symptomsTxtBox
			// 
			symptomsTxtBox.BorderStyle = BorderStyle.None;
			symptomsTxtBox.Enabled = false;
			symptomsTxtBox.Location = new Point(1060, 142);
			symptomsTxtBox.Margin = new Padding(2);
			symptomsTxtBox.MaxLength = 200;
			symptomsTxtBox.Name = "symptomsTxtBox";
			symptomsTxtBox.Size = new Size(300, 200);
			symptomsTxtBox.TabIndex = 62;
			symptomsTxtBox.Text = "";
			// 
			// pulseTxtField
			// 
			pulseTxtField.BackColor = SystemColors.Control;
			pulseTxtField.BorderStyle = BorderStyle.None;
			pulseTxtField.Enabled = false;
			pulseTxtField.Location = new Point(883, 319);
			pulseTxtField.Margin = new Padding(2);
			pulseTxtField.MaxLength = 4;
			pulseTxtField.Name = "pulseTxtField";
			pulseTxtField.Size = new Size(70, 16);
			pulseTxtField.TabIndex = 57;
			// 
			// bodyTempTxtField
			// 
			bodyTempTxtField.BackColor = SystemColors.Control;
			bodyTempTxtField.BorderStyle = BorderStyle.None;
			bodyTempTxtField.Enabled = false;
			bodyTempTxtField.Location = new Point(883, 282);
			bodyTempTxtField.Margin = new Padding(2);
			bodyTempTxtField.MaxLength = 5;
			bodyTempTxtField.Name = "bodyTempTxtField";
			bodyTempTxtField.Size = new Size(70, 16);
			bodyTempTxtField.TabIndex = 60;
			// 
			// heightTxtField
			// 
			heightTxtField.BackColor = SystemColors.Control;
			heightTxtField.BorderStyle = BorderStyle.None;
			heightTxtField.Enabled = false;
			heightTxtField.Location = new Point(883, 240);
			heightTxtField.Margin = new Padding(2);
			heightTxtField.MaxLength = 6;
			heightTxtField.Name = "heightTxtField";
			heightTxtField.Size = new Size(70, 16);
			heightTxtField.TabIndex = 56;
			// 
			// weightTxtField
			// 
			weightTxtField.BackColor = SystemColors.Control;
			weightTxtField.BorderStyle = BorderStyle.None;
			weightTxtField.Enabled = false;
			weightTxtField.Location = new Point(883, 202);
			weightTxtField.Margin = new Padding(2);
			weightTxtField.MaxLength = 6;
			weightTxtField.Name = "weightTxtField";
			weightTxtField.Size = new Size(70, 16);
			weightTxtField.TabIndex = 53;
			// 
			// bloodPressureDiasTxtField
			// 
			bloodPressureDiasTxtField.BackColor = SystemColors.Control;
			bloodPressureDiasTxtField.BorderStyle = BorderStyle.None;
			bloodPressureDiasTxtField.Enabled = false;
			bloodPressureDiasTxtField.Location = new Point(883, 162);
			bloodPressureDiasTxtField.Margin = new Padding(2);
			bloodPressureDiasTxtField.MaxLength = 3;
			bloodPressureDiasTxtField.Name = "bloodPressureDiasTxtField";
			bloodPressureDiasTxtField.Size = new Size(70, 16);
			bloodPressureDiasTxtField.TabIndex = 51;
			// 
			// bloodPressureSysTxtField
			// 
			bloodPressureSysTxtField.BackColor = SystemColors.Control;
			bloodPressureSysTxtField.BorderStyle = BorderStyle.None;
			bloodPressureSysTxtField.Enabled = false;
			bloodPressureSysTxtField.Location = new Point(884, 119);
			bloodPressureSysTxtField.Margin = new Padding(2);
			bloodPressureSysTxtField.MaxLength = 3;
			bloodPressureSysTxtField.Name = "bloodPressureSysTxtField";
			bloodPressureSysTxtField.Size = new Size(70, 16);
			bloodPressureSysTxtField.TabIndex = 49;
			// 
			// finalDiagnosesLabel
			// 
			finalDiagnosesLabel.AutoSize = true;
			finalDiagnosesLabel.Location = new Point(1060, 390);
			finalDiagnosesLabel.Margin = new Padding(2, 0, 2, 0);
			finalDiagnosesLabel.Name = "finalDiagnosesLabel";
			finalDiagnosesLabel.Size = new Size(89, 15);
			finalDiagnosesLabel.TabIndex = 67;
			finalDiagnosesLabel.Text = "Final Diagnoses";
			// 
			// initialDiagnosesLabel
			// 
			initialDiagnosesLabel.AutoSize = true;
			initialDiagnosesLabel.Location = new Point(735, 390);
			initialDiagnosesLabel.Margin = new Padding(2, 0, 2, 0);
			initialDiagnosesLabel.Name = "initialDiagnosesLabel";
			initialDiagnosesLabel.Size = new Size(93, 15);
			initialDiagnosesLabel.TabIndex = 65;
			initialDiagnosesLabel.Text = "Initial Diagnoses";
			// 
			// symptomsLabel
			// 
			symptomsLabel.AutoSize = true;
			symptomsLabel.Location = new Point(1060, 125);
			symptomsLabel.Margin = new Padding(2, 0, 2, 0);
			symptomsLabel.Name = "symptomsLabel";
			symptomsLabel.Size = new Size(64, 15);
			symptomsLabel.TabIndex = 63;
			symptomsLabel.Text = "Symptoms";
			// 
			// pulseLabel
			// 
			pulseLabel.AutoSize = true;
			pulseLabel.Location = new Point(735, 325);
			pulseLabel.Margin = new Padding(2, 0, 2, 0);
			pulseLabel.Name = "pulseLabel";
			pulseLabel.Size = new Size(35, 15);
			pulseLabel.TabIndex = 61;
			pulseLabel.Text = "Pulse";
			// 
			// heightLabel
			// 
			heightLabel.AutoSize = true;
			heightLabel.Location = new Point(735, 245);
			heightLabel.Margin = new Padding(2, 0, 2, 0);
			heightLabel.Name = "heightLabel";
			heightLabel.Size = new Size(43, 15);
			heightLabel.TabIndex = 59;
			heightLabel.Text = "Height";
			// 
			// weightLabel
			// 
			weightLabel.AutoSize = true;
			weightLabel.Location = new Point(735, 205);
			weightLabel.Margin = new Padding(2, 0, 2, 0);
			weightLabel.Name = "weightLabel";
			weightLabel.Size = new Size(45, 15);
			weightLabel.TabIndex = 58;
			weightLabel.Text = "Weight";
			// 
			// bodyTempLabel
			// 
			bodyTempLabel.AutoSize = true;
			bodyTempLabel.Location = new Point(735, 285);
			bodyTempLabel.Margin = new Padding(2, 0, 2, 0);
			bodyTempLabel.Name = "bodyTempLabel";
			bodyTempLabel.Size = new Size(103, 15);
			bodyTempLabel.TabIndex = 55;
			bodyTempLabel.Text = "Body Temperature";
			// 
			// bloodPressureDiasLabel
			// 
			bloodPressureDiasLabel.AutoSize = true;
			bloodPressureDiasLabel.Location = new Point(735, 165);
			bloodPressureDiasLabel.Margin = new Padding(2, 0, 2, 0);
			bloodPressureDiasLabel.Name = "bloodPressureDiasLabel";
			bloodPressureDiasLabel.Size = new Size(133, 15);
			bloodPressureDiasLabel.TabIndex = 54;
			bloodPressureDiasLabel.Text = "Blood Pressure Diastolic";
			// 
			// bloodPressureSysLabel
			// 
			bloodPressureSysLabel.AutoSize = true;
			bloodPressureSysLabel.Location = new Point(735, 125);
			bloodPressureSysLabel.Margin = new Padding(2, 0, 2, 0);
			bloodPressureSysLabel.Name = "bloodPressureSysLabel";
			bloodPressureSysLabel.Size = new Size(128, 15);
			bloodPressureSysLabel.TabIndex = 52;
			bloodPressureSysLabel.Text = "Blood Pressure Systolic";
			// 
			// testResultDataGrid
			// 
			testResultDataGrid.AllowUserToAddRows = false;
			testResultDataGrid.AllowUserToDeleteRows = false;
			testResultDataGrid.AllowUserToResizeColumns = false;
			testResultDataGrid.AllowUserToResizeRows = false;
			testResultDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			testResultDataGrid.BackgroundColor = SystemColors.Control;
			testResultDataGrid.BorderStyle = BorderStyle.Fixed3D;
			testResultDataGrid.ColumnHeadersHeight = 30;
			testResultDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			testResultDataGrid.GridColor = SystemColors.Control;
			testResultDataGrid.Location = new Point(735, 549);
			testResultDataGrid.Margin = new Padding(2);
			testResultDataGrid.MultiSelect = false;
			testResultDataGrid.Name = "testResultDataGrid";
			testResultDataGrid.ReadOnly = true;
			testResultDataGrid.RowHeadersVisible = false;
			testResultDataGrid.RowHeadersWidth = 62;
			testResultDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			testResultDataGrid.Size = new Size(625, 186);
			testResultDataGrid.TabIndex = 89;
			// 
			// enterTestResultButton
			// 
			enterTestResultButton.Location = new Point(1197, 3);
			enterTestResultButton.Margin = new Padding(2);
			enterTestResultButton.Name = "enterTestResultButton";
			enterTestResultButton.Size = new Size(150, 35);
			enterTestResultButton.TabIndex = 90;
			enterTestResultButton.Text = "Enter Test Result";
			enterTestResultButton.UseVisualStyleBackColor = true;
			enterTestResultButton.Click += enterTestResultButton_Click;
			// 
			// editVisitButton
			// 
			editVisitButton.Location = new Point(1043, 3);
			editVisitButton.Margin = new Padding(2);
			editVisitButton.Name = "editVisitButton";
			editVisitButton.Size = new Size(150, 35);
			editVisitButton.TabIndex = 91;
			editVisitButton.Text = "Edit Visit";
			editVisitButton.UseVisualStyleBackColor = true;
			editVisitButton.Click += editVisitButton_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(735, 85);
			label4.Name = "label4";
			label4.Size = new Size(70, 15);
			label4.TabIndex = 92;
			label4.Text = "Visit Details:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(735, 532);
			label5.Name = "label5";
			label5.Size = new Size(124, 15);
			label5.TabIndex = 93;
			label5.Text = "Tests Ordered for Visit:";
			// 
			// AppointmentsControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(label5);
			Controls.Add(label4);
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
			Name = "AppointmentsControl";
			Size = new Size(1370, 750);
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
		private Label label4;
		private Label label5;
	}
}
