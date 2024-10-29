namespace HealthCareApp.View
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            helloLabel = new Label();
            userFullNameLabel = new Label();
            logoutButton = new Button();
            registerPatientBtn = new Button();
            editPatientBtn = new Button();
            sidebarPanel = new Panel();
            usernameLabel = new Label();
            headerPanel = new Panel();
            mainPanel = new Panel();
            patientsDataGridView = new DataGridView();
            sidebarPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)patientsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // helloLabel
            // 
            helloLabel.AutoSize = true;
            helloLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            helloLabel.ForeColor = SystemColors.Control;
            helloLabel.Location = new Point(7, 8);
            helloLabel.Name = "helloLabel";
            helloLabel.Size = new Size(62, 28);
            helloLabel.TabIndex = 0;
            helloLabel.Text = "Hello,";
            // 
            // userFullNameLabel
            // 
            userFullNameLabel.AutoSize = true;
            userFullNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userFullNameLabel.ForeColor = SystemColors.Control;
            userFullNameLabel.Location = new Point(71, 8);
            userFullNameLabel.Name = "userFullNameLabel";
            userFullNameLabel.Size = new Size(190, 28);
            userFullNameLabel.TabIndex = 1;
            userFullNameLabel.Text = "last name, first name";
            // 
            // logoutButton
            // 
            logoutButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.LightSlateGray;
            logoutButton.Location = new Point(50, 867);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(114, 50);
            logoutButton.TabIndex = 2;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // registerPatientBtn
            // 
            registerPatientBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerPatientBtn.Location = new Point(40, 48);
            registerPatientBtn.Name = "registerPatientBtn";
            registerPatientBtn.Size = new Size(286, 50);
            registerPatientBtn.TabIndex = 3;
            registerPatientBtn.Text = "Register Patient";
            registerPatientBtn.UseVisualStyleBackColor = true;
            registerPatientBtn.Click += registerPatientBtn_Click;
            // 
            // editPatientBtn
            // 
            editPatientBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editPatientBtn.Location = new Point(331, 48);
            editPatientBtn.Name = "editPatientBtn";
            editPatientBtn.Size = new Size(286, 50);
            editPatientBtn.TabIndex = 4;
            editPatientBtn.Text = "Edit Patient";
            editPatientBtn.UseVisualStyleBackColor = true;
            editPatientBtn.Click += editPatientBtn_Click;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.LightSlateGray;
            sidebarPanel.Controls.Add(usernameLabel);
            sidebarPanel.Controls.Add(logoutButton);
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Margin = new Padding(4, 5, 4, 5);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(214, 933);
            sidebarPanel.TabIndex = 6;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = SystemColors.HighlightText;
            usernameLabel.Location = new Point(79, 825);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(96, 28);
            usernameLabel.TabIndex = 7;
            usernameLabel.Text = "username";
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.LightSlateGray;
            headerPanel.Controls.Add(userFullNameLabel);
            headerPanel.Controls.Add(helloLabel);
            headerPanel.Location = new Point(214, 0);
            headerPanel.Margin = new Padding(4, 5, 4, 5);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1226, 50);
            headerPanel.TabIndex = 7;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(patientsDataGridView);
            mainPanel.Controls.Add(registerPatientBtn);
            mainPanel.Controls.Add(editPatientBtn);
            mainPanel.Location = new Point(214, 50);
            mainPanel.Margin = new Padding(4, 5, 4, 5);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1226, 883);
            mainPanel.TabIndex = 8;
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
            patientsDataGridView.Location = new Point(40, 107);
            patientsDataGridView.Margin = new Padding(4, 5, 4, 5);
            patientsDataGridView.MultiSelect = false;
            patientsDataGridView.Name = "patientsDataGridView";
            patientsDataGridView.ReadOnly = true;
            patientsDataGridView.RowHeadersWidth = 62;
            patientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            patientsDataGridView.Size = new Size(1143, 717);
            patientsDataGridView.TabIndex = 7;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 935);
            Controls.Add(mainPanel);
            Controls.Add(headerPanel);
            Controls.Add(sidebarPanel);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Health Care App";
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)patientsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label helloLabel;
        private Label userFullNameLabel;
        private Button logoutButton;
        private Button registerPatientBtn;
		private Button editPatientBtn;
		private Panel sidebarPanel;
		private Label usernameLabel;
		private Panel headerPanel;
		private Panel mainPanel;
		private DataGridView patientsDataGridView;
	}
}
