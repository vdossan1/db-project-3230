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
            registerPatientBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerPatientBtn.Location = new Point(222, 40);
            registerPatientBtn.Name = "registerPatientBtn";
            registerPatientBtn.Size = new Size(286, 52);
            registerPatientBtn.TabIndex = 4;
            registerPatientBtn.Text = "Register Patient";
            registerPatientBtn.UseVisualStyleBackColor = true;
            registerPatientBtn.Click += registerPatientBtn_Click;
            // 
            // editPatientBtn
            // 
            editPatientBtn.Enabled = false;
            editPatientBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editPatientBtn.Location = new Point(513, 40);
            editPatientBtn.Name = "editPatientBtn";
            editPatientBtn.Size = new Size(286, 52);
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
            patientsDataGridView.Location = new Point(34, 277);
            patientsDataGridView.Margin = new Padding(4, 5, 4, 5);
            patientsDataGridView.MultiSelect = false;
            patientsDataGridView.Name = "patientsDataGridView";
            patientsDataGridView.ReadOnly = true;
            patientsDataGridView.RowHeadersVisible = false;
            patientsDataGridView.RowHeadersWidth = 62;
            patientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            patientsDataGridView.Size = new Size(1006, 802);
            patientsDataGridView.TabIndex = 8;
            // 
            // patientAdvancedSearchControl
            // 
            patientAdvancedSearchControl.Location = new Point(26, 97);
            patientAdvancedSearchControl.Margin = new Padding(1, 2, 1, 2);
            patientAdvancedSearchControl.Name = "patientAdvancedSearchControl";
            patientAdvancedSearchControl.Size = new Size(1029, 162);
            patientAdvancedSearchControl.TabIndex = 10;
            // 
            // PatientsControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(patientAdvancedSearchControl);
            Controls.Add(patientsDataGridView);
            Controls.Add(editPatientBtn);
            Controls.Add(registerPatientBtn);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PatientsControl";
            Size = new Size(1521, 1133);
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
