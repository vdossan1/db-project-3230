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
            advancedSearchGroupBox = new GroupBox();
            clearAdvSrcButton = new Button();
            advanSearchButton = new Button();
            dateOfBirthLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            dateOfBirthPicker = new DateTimePicker();
            lastNameTxtBox = new TextBox();
            firstNameTxtBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).BeginInit();
            advancedSearchGroupBox.SuspendLayout();
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
            appointmentsDataGridView.Location = new Point(24, 234);
            appointmentsDataGridView.Margin = new Padding(4, 5, 4, 5);
            appointmentsDataGridView.MultiSelect = false;
            appointmentsDataGridView.Name = "appointmentsDataGridView";
            appointmentsDataGridView.ReadOnly = true;
            appointmentsDataGridView.RowHeadersWidth = 62;
            appointmentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentsDataGridView.Size = new Size(1006, 874);
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
            // advancedSearchGroupBox
            // 
            advancedSearchGroupBox.Controls.Add(clearAdvSrcButton);
            advancedSearchGroupBox.Controls.Add(advanSearchButton);
            advancedSearchGroupBox.Controls.Add(dateOfBirthLabel);
            advancedSearchGroupBox.Controls.Add(lastNameLabel);
            advancedSearchGroupBox.Controls.Add(firstNameLabel);
            advancedSearchGroupBox.Controls.Add(dateOfBirthPicker);
            advancedSearchGroupBox.Controls.Add(lastNameTxtBox);
            advancedSearchGroupBox.Controls.Add(firstNameTxtBox);
            advancedSearchGroupBox.Location = new Point(24, 93);
            advancedSearchGroupBox.Name = "advancedSearchGroupBox";
            advancedSearchGroupBox.Size = new Size(1006, 133);
            advancedSearchGroupBox.TabIndex = 12;
            advancedSearchGroupBox.TabStop = false;
            advancedSearchGroupBox.Text = "Advanced Search";
            // 
            // clearAdvSrcButton
            // 
            clearAdvSrcButton.Location = new Point(832, 28);
            clearAdvSrcButton.Name = "clearAdvSrcButton";
            clearAdvSrcButton.Size = new Size(135, 34);
            clearAdvSrcButton.TabIndex = 7;
            clearAdvSrcButton.Text = "Clear";
            clearAdvSrcButton.UseVisualStyleBackColor = true;
            clearAdvSrcButton.Click += clearAdvSrcButton_Click;
            // 
            // advanSearchButton
            // 
            advanSearchButton.Location = new Point(832, 73);
            advanSearchButton.Name = "advanSearchButton";
            advanSearchButton.Size = new Size(135, 34);
            advanSearchButton.TabIndex = 6;
            advanSearchButton.Text = "Search";
            advanSearchButton.UseVisualStyleBackColor = true;
            advanSearchButton.Click += advanSearchButton_Click;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new Point(508, 34);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(112, 25);
            dateOfBirthLabel.TabIndex = 5;
            dateOfBirthLabel.Text = "Date of Birth";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(284, 38);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(95, 25);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(55, 37);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(97, 25);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name";
            // 
            // dateOfBirthPicker
            // 
            dateOfBirthPicker.Location = new Point(506, 73);
            dateOfBirthPicker.Name = "dateOfBirthPicker";
            dateOfBirthPicker.Size = new Size(300, 31);
            dateOfBirthPicker.TabIndex = 2;
            // 
            // lastNameTxtBox
            // 
            lastNameTxtBox.Location = new Point(279, 75);
            lastNameTxtBox.Name = "lastNameTxtBox";
            lastNameTxtBox.Size = new Size(184, 31);
            lastNameTxtBox.TabIndex = 1;
            // 
            // firstNameTxtBox
            // 
            firstNameTxtBox.Location = new Point(48, 75);
            firstNameTxtBox.Name = "firstNameTxtBox";
            firstNameTxtBox.Size = new Size(184, 31);
            firstNameTxtBox.TabIndex = 0;
            // 
            // AppointmentsControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(advancedSearchGroupBox);
            Controls.Add(appointmentsSearchBar);
            Controls.Add(editAppointmentBtn);
            Controls.Add(createAppointmentBtn);
            Controls.Add(appointmentsDataGridView);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AppointmentsControl";
            Size = new Size(1521, 1133);
            ((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).EndInit();
            advancedSearchGroupBox.ResumeLayout(false);
            advancedSearchGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView appointmentsDataGridView;
		private Button createAppointmentBtn;
		private Button editAppointmentBtn;
		private TextBox appointmentsSearchBar;
        private GroupBox advancedSearchGroupBox;
        private Button advanSearchButton;
        private Label dateOfBirthLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private DateTimePicker dateOfBirthPicker;
        private TextBox lastNameTxtBox;
        private TextBox firstNameTxtBox;
        private Button clearAdvSrcButton;
    }
}
