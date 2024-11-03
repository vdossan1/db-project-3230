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
			patientsSearchBar = new TextBox();
			patientAdvancedSearchControl = new AdvancedSearchControl();
			((System.ComponentModel.ISupportInitialize)patientsDataGridView).BeginInit();
			SuspendLayout();
			// 
			// registerPatientBtn
			// 
			registerPatientBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			registerPatientBtn.Location = new Point(324, 23);
			registerPatientBtn.Margin = new Padding(2);
			registerPatientBtn.Name = "registerPatientBtn";
			registerPatientBtn.Size = new Size(200, 31);
			registerPatientBtn.TabIndex = 4;
			registerPatientBtn.Text = "Register Patient";
			registerPatientBtn.UseVisualStyleBackColor = true;
			registerPatientBtn.Click += registerPatientBtn_Click;
			// 
			// editPatientBtn
			// 
			editPatientBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			editPatientBtn.Location = new Point(528, 23);
			editPatientBtn.Margin = new Padding(2);
			editPatientBtn.Name = "editPatientBtn";
			editPatientBtn.Size = new Size(200, 31);
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
			patientsDataGridView.BackgroundColor = SystemColors.Control;
			patientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			patientsDataGridView.GridColor = SystemColors.Control;
			patientsDataGridView.Location = new Point(24, 166);
			patientsDataGridView.MultiSelect = false;
			patientsDataGridView.Name = "patientsDataGridView";
			patientsDataGridView.ReadOnly = true;
			patientsDataGridView.RowHeadersVisible = false;
			patientsDataGridView.RowHeadersWidth = 62;
			patientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			patientsDataGridView.Size = new Size(704, 481);
			patientsDataGridView.TabIndex = 8;
			// 
			// patientsSearchBar
			// 
			patientsSearchBar.BorderStyle = BorderStyle.FixedSingle;
			patientsSearchBar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			patientsSearchBar.ForeColor = SystemColors.ControlDarkDark;
			patientsSearchBar.Location = new Point(24, 28);
			patientsSearchBar.Name = "patientsSearchBar";
			patientsSearchBar.Size = new Size(295, 29);
			patientsSearchBar.TabIndex = 9;
			patientsSearchBar.Text = "  Search";
			// 
			// patientAdvancedSearchControl
			// 
			patientAdvancedSearchControl.Location = new Point(18, 58);
			patientAdvancedSearchControl.Margin = new Padding(1);
			patientAdvancedSearchControl.Name = "patientAdvancedSearchControl";
			patientAdvancedSearchControl.Size = new Size(720, 97);
			patientAdvancedSearchControl.TabIndex = 10;
			// 
			// PatientsControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(patientAdvancedSearchControl);
			Controls.Add(patientsSearchBar);
			Controls.Add(patientsDataGridView);
			Controls.Add(editPatientBtn);
			Controls.Add(registerPatientBtn);
			Name = "PatientsControl";
			Size = new Size(1065, 680);
			((System.ComponentModel.ISupportInitialize)patientsDataGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button registerPatientBtn;
		private Button editPatientBtn;
		private DataGridView patientsDataGridView;
		private TextBox patientsSearchBar;
        private AdvancedSearchControl patientAdvancedSearchControl;
    }
}
