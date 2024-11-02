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
            advancedSearchControl1 = new AdvancedSearchControl();
            ((System.ComponentModel.ISupportInitialize)patientsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // registerPatientBtn
            // 
            registerPatientBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerPatientBtn.Location = new Point(463, 38);
            registerPatientBtn.Name = "registerPatientBtn";
            registerPatientBtn.Size = new Size(286, 52);
            registerPatientBtn.TabIndex = 4;
            registerPatientBtn.Text = "Register Patient";
            registerPatientBtn.UseVisualStyleBackColor = true;
            registerPatientBtn.Click += registerPatientBtn_Click;
            // 
            // editPatientBtn
            // 
            editPatientBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editPatientBtn.Location = new Point(755, 38);
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
            patientsDataGridView.Location = new Point(35, 277);
            patientsDataGridView.Margin = new Padding(4, 5, 4, 5);
            patientsDataGridView.MultiSelect = false;
            patientsDataGridView.Name = "patientsDataGridView";
            patientsDataGridView.ReadOnly = true;
            patientsDataGridView.RowHeadersWidth = 62;
            patientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            patientsDataGridView.Size = new Size(1006, 801);
            patientsDataGridView.TabIndex = 8;
            // 
            // patientsSearchBar
            // 
            patientsSearchBar.BorderStyle = BorderStyle.FixedSingle;
            patientsSearchBar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientsSearchBar.ForeColor = SystemColors.ControlDarkDark;
            patientsSearchBar.Location = new Point(35, 46);
            patientsSearchBar.Margin = new Padding(4, 5, 4, 5);
            patientsSearchBar.Name = "patientsSearchBar";
            patientsSearchBar.Size = new Size(421, 39);
            patientsSearchBar.TabIndex = 9;
            patientsSearchBar.Text = "  Search";
            // 
            // advancedSearchControl1
            // 
            advancedSearchControl1.Location = new Point(25, 96);
            advancedSearchControl1.Name = "advancedSearchControl1";
            advancedSearchControl1.Size = new Size(1028, 162);
            advancedSearchControl1.TabIndex = 10;
            // 
            // PatientsControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(advancedSearchControl1);
            Controls.Add(patientsSearchBar);
            Controls.Add(patientsDataGridView);
            Controls.Add(editPatientBtn);
            Controls.Add(registerPatientBtn);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PatientsControl";
            Size = new Size(1521, 1133);
            ((System.ComponentModel.ISupportInitialize)patientsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerPatientBtn;
		private Button editPatientBtn;
		private DataGridView patientsDataGridView;
		private TextBox patientsSearchBar;
        private AdvancedSearchControl advancedSearchControl1;
    }
}
