namespace HealthCareApp.view
{
	partial class PatientsControl
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
			registerPatientBtn = new Button();
			editPatientBtn = new Button();
			patientsDataGridView = new DataGridView();
			patientAdvancedSearchControl = new AdvancedSearchControl();
			((System.ComponentModel.ISupportInitialize)patientsDataGridView).BeginInit();
			SuspendLayout();
			// 
			// registerPatientBtn
			// 
			registerPatientBtn.Font = new Font("Segoe UI", 9F);
			registerPatientBtn.Location = new Point(735, 3);
			registerPatientBtn.Margin = new Padding(2);
			registerPatientBtn.Name = "registerPatientBtn";
			registerPatientBtn.Size = new Size(150, 35);
			registerPatientBtn.TabIndex = 4;
			registerPatientBtn.Text = "Register Patient";
			registerPatientBtn.UseVisualStyleBackColor = true;
			registerPatientBtn.Click += registerPatientBtn_Click;
			// 
			// editPatientBtn
			// 
			editPatientBtn.Enabled = false;
			editPatientBtn.Font = new Font("Segoe UI", 9F);
			editPatientBtn.Location = new Point(889, 3);
			editPatientBtn.Margin = new Padding(2);
			editPatientBtn.Name = "editPatientBtn";
			editPatientBtn.Size = new Size(150, 35);
			editPatientBtn.TabIndex = 5;
			editPatientBtn.Text = "Edit Patient";
			editPatientBtn.UseVisualStyleBackColor = true;
			editPatientBtn.Click += editPatientBtn_Click;
			// 
			// patientsDataGridView
			// 
			patientsDataGridView.AllowUserToAddRows = false;
			patientsDataGridView.AllowUserToDeleteRows = false;
			patientsDataGridView.AllowUserToResizeColumns = false;
			patientsDataGridView.AllowUserToResizeRows = false;
			patientsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			patientsDataGridView.BackgroundColor = SystemColors.Control;
			patientsDataGridView.BorderStyle = BorderStyle.Fixed3D;
			patientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			patientsDataGridView.GridColor = SystemColors.Control;
			patientsDataGridView.Location = new Point(10, 105);
			patientsDataGridView.MultiSelect = false;
			patientsDataGridView.Name = "patientsDataGridView";
			patientsDataGridView.RowHeadersVisible = false;
			patientsDataGridView.RowHeadersWidth = 62;
			patientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			patientsDataGridView.Size = new Size(1222, 631);
			patientsDataGridView.TabIndex = 8;
			// 
			// patientAdvancedSearchControl
			// 
			patientAdvancedSearchControl.Location = new Point(10, 0);
			patientAdvancedSearchControl.Margin = new Padding(1);
			patientAdvancedSearchControl.Name = "patientAdvancedSearchControl";
			patientAdvancedSearchControl.Size = new Size(700, 80);
			patientAdvancedSearchControl.TabIndex = 10;
			// 
			// PatientsControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(patientAdvancedSearchControl);
			Controls.Add(patientsDataGridView);
			Controls.Add(editPatientBtn);
			Controls.Add(registerPatientBtn);
			Name = "PatientsControl";
			Size = new Size(1370, 750);
			((System.ComponentModel.ISupportInitialize)patientsDataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button registerPatientBtn;
		private Button editPatientBtn;
		private DataGridView patientsDataGridView;
        private AdvancedSearchControl patientAdvancedSearchControl;
    }
}
