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
            appointmentsDataGridView.RowHeadersVisible = false;
            appointmentsDataGridView.RowHeadersWidth = 62;
            appointmentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentsDataGridView.Size = new Size(1006, 820);
            appointmentsDataGridView.TabIndex = 9;
            // 
            // createAppointmentBtn
            // 
            createAppointmentBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createAppointmentBtn.Location = new Point(212, 48);
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
            editAppointmentBtn.Location = new Point(503, 48);
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
            apptAdvancedSearchControl.Size = new Size(1039, 158);
            apptAdvancedSearchControl.TabIndex = 12;
            // 
            // AppointmentsControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(apptAdvancedSearchControl);
            Controls.Add(editAppointmentBtn);
            Controls.Add(createAppointmentBtn);
            Controls.Add(appointmentsDataGridView);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AppointmentsControl";
            Size = new Size(1521, 1133);
            ((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView appointmentsDataGridView;
		private Button createAppointmentBtn;
		private Button editAppointmentBtn;
        private AdvancedSearchControl apptAdvancedSearchControl;
    }
}
