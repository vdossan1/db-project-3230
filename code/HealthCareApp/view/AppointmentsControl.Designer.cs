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
            appointmentsSearchBar = new TextBox();
            advancedSearchControl1 = new AdvancedSearchControl();
            ((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // appointmentsDataGridView
            // 
            appointmentsDataGridView.AllowUserToAddRows = false;
            appointmentsDataGridView.AllowUserToDeleteRows = false;
            appointmentsDataGridView.AllowUserToResizeColumns = false;
            appointmentsDataGridView.AllowUserToResizeRows = false;
            appointmentsDataGridView.BackgroundColor = SystemColors.Control;
            appointmentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentsDataGridView.GridColor = SystemColors.Control;
            appointmentsDataGridView.Location = new Point(24, 288);
            appointmentsDataGridView.Margin = new Padding(4, 5, 4, 5);
            appointmentsDataGridView.MultiSelect = false;
            appointmentsDataGridView.Name = "appointmentsDataGridView";
            appointmentsDataGridView.ReadOnly = true;
            appointmentsDataGridView.RowHeadersWidth = 62;
            appointmentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentsDataGridView.Size = new Size(1006, 820);
            appointmentsDataGridView.TabIndex = 9;
            // 
            // createAppointmentBtn
            // 
            createAppointmentBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createAppointmentBtn.Location = new Point(453, 35);
            createAppointmentBtn.Name = "createAppointmentBtn";
            createAppointmentBtn.Size = new Size(286, 52);
            createAppointmentBtn.TabIndex = 10;
            createAppointmentBtn.Text = "Create Appointment";
            createAppointmentBtn.UseVisualStyleBackColor = true;
            // 
            // editAppointmentBtn
            // 
            editAppointmentBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editAppointmentBtn.Location = new Point(744, 35);
            editAppointmentBtn.Name = "editAppointmentBtn";
            editAppointmentBtn.Size = new Size(286, 52);
            editAppointmentBtn.TabIndex = 10;
            editAppointmentBtn.Text = "Edit Appointment";
            editAppointmentBtn.UseVisualStyleBackColor = true;
            // 
            // appointmentsSearchBar
            // 
            appointmentsSearchBar.BorderStyle = BorderStyle.FixedSingle;
            appointmentsSearchBar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointmentsSearchBar.ForeColor = SystemColors.ControlDarkDark;
            appointmentsSearchBar.Location = new Point(24, 37);
            appointmentsSearchBar.Margin = new Padding(4, 5, 4, 5);
            appointmentsSearchBar.Name = "appointmentsSearchBar";
            appointmentsSearchBar.Size = new Size(421, 39);
            appointmentsSearchBar.TabIndex = 11;
            appointmentsSearchBar.Text = "  Search";
            appointmentsSearchBar.TextChanged += appointmentsSearchBar_TextChanged;
            // 
            // advancedSearchControl1
            // 
            advancedSearchControl1.Location = new Point(24, 105);
            advancedSearchControl1.Name = "advancedSearchControl1";
            advancedSearchControl1.Size = new Size(1039, 158);
            advancedSearchControl1.TabIndex = 12;
            // 
            // AppointmentsControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(advancedSearchControl1);
            Controls.Add(appointmentsSearchBar);
            Controls.Add(editAppointmentBtn);
            Controls.Add(createAppointmentBtn);
            Controls.Add(appointmentsDataGridView);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AppointmentsControl";
            Size = new Size(1521, 1133);
            ((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView appointmentsDataGridView;
		private Button createAppointmentBtn;
		private Button editAppointmentBtn;
		private TextBox appointmentsSearchBar;
        private AdvancedSearchControl advancedSearchControl1;
    }
}
