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
			textBox1 = new TextBox();
			((System.ComponentModel.ISupportInitialize)patientsDataGridView).BeginInit();
			SuspendLayout();
			// 
			// registerPatientBtn
			// 
			registerPatientBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			registerPatientBtn.Location = new Point(317, 21);
			registerPatientBtn.Margin = new Padding(2);
			registerPatientBtn.Name = "registerPatientBtn";
			registerPatientBtn.Size = new Size(200, 31);
			registerPatientBtn.TabIndex = 4;
			registerPatientBtn.Text = "Register Patient";
			registerPatientBtn.UseVisualStyleBackColor = true;
			// 
			// editPatientBtn
			// 
			editPatientBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			editPatientBtn.Location = new Point(521, 21);
			editPatientBtn.Margin = new Padding(2);
			editPatientBtn.Name = "editPatientBtn";
			editPatientBtn.Size = new Size(200, 31);
			editPatientBtn.TabIndex = 5;
			editPatientBtn.Text = "Edit Patient";
			editPatientBtn.UseVisualStyleBackColor = true;
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
			patientsDataGridView.Location = new Point(17, 57);
			patientsDataGridView.MultiSelect = false;
			patientsDataGridView.Name = "patientsDataGridView";
			patientsDataGridView.ReadOnly = true;
			patientsDataGridView.RowHeadersWidth = 62;
			patientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			patientsDataGridView.Size = new Size(704, 608);
			patientsDataGridView.TabIndex = 8;
			// 
			// textBox1
			// 
			textBox1.BorderStyle = BorderStyle.FixedSingle;
			textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox1.ForeColor = SystemColors.ControlDarkDark;
			textBox1.Location = new Point(17, 22);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(295, 29);
			textBox1.TabIndex = 9;
			textBox1.Text = "  Search";
			// 
			// PatientsControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(textBox1);
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
		private TextBox textBox1;
	}
}
