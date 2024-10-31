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
			userFullNameLabel = new Label();
			logoutButton = new Button();
			sidebarPanel = new Panel();
			sidebarButtonPanel = new Panel();
			homeButton = new Button();
			visitsButton = new Button();
			patientsButton = new Button();
			appointmentsButton = new Button();
			usernameLabel = new Label();
			mainPanel = new Panel();
			sidebarPanel.SuspendLayout();
			sidebarButtonPanel.SuspendLayout();
			SuspendLayout();
			// 
			// userFullNameLabel
			// 
			userFullNameLabel.AutoSize = true;
			userFullNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			userFullNameLabel.ForeColor = SystemColors.Control;
			userFullNameLabel.Location = new Point(55, 588);
			userFullNameLabel.Margin = new Padding(2, 0, 2, 0);
			userFullNameLabel.Name = "userFullNameLabel";
			userFullNameLabel.Size = new Size(129, 17);
			userFullNameLabel.TabIndex = 1;
			userFullNameLabel.Text = "last name, first name";
			userFullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// logoutButton
			// 
			logoutButton.FlatAppearance.BorderSize = 0;
			logoutButton.FlatStyle = FlatStyle.Flat;
			logoutButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			logoutButton.ForeColor = SystemColors.Control;
			logoutButton.ImageAlign = ContentAlignment.MiddleLeft;
			logoutButton.Location = new Point(22, 622);
			logoutButton.Margin = new Padding(2);
			logoutButton.Name = "logoutButton";
			logoutButton.Size = new Size(150, 35);
			logoutButton.TabIndex = 2;
			logoutButton.Text = "Sign Out";
			logoutButton.UseVisualStyleBackColor = true;
			logoutButton.Click += logoutButton_Click;
			logoutButton.MouseEnter += logoutButton_MouseEnter;
			logoutButton.MouseLeave += logoutButton_MouseLeave;
			// 
			// sidebarPanel
			// 
			sidebarPanel.BackColor = Color.Transparent;
			sidebarPanel.Controls.Add(sidebarButtonPanel);
			sidebarPanel.Controls.Add(logoutButton);
			sidebarPanel.Controls.Add(usernameLabel);
			sidebarPanel.Controls.Add(userFullNameLabel);
			sidebarPanel.Location = new Point(0, 0);
			sidebarPanel.Name = "sidebarPanel";
			sidebarPanel.Size = new Size(200, 680);
			sidebarPanel.TabIndex = 6;
			// 
			// sidebarButtonPanel
			// 
			sidebarButtonPanel.BackColor = Color.Transparent;
			sidebarButtonPanel.Controls.Add(homeButton);
			sidebarButtonPanel.Controls.Add(visitsButton);
			sidebarButtonPanel.Controls.Add(patientsButton);
			sidebarButtonPanel.Controls.Add(appointmentsButton);
			sidebarButtonPanel.Location = new Point(22, 20);
			sidebarButtonPanel.Name = "sidebarButtonPanel";
			sidebarButtonPanel.Size = new Size(150, 420);
			sidebarButtonPanel.TabIndex = 11;
			// 
			// homeButton
			// 
			homeButton.BackColor = Color.Transparent;
			homeButton.FlatAppearance.BorderSize = 0;
			homeButton.FlatStyle = FlatStyle.Flat;
			homeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			homeButton.ForeColor = SystemColors.Control;
			homeButton.Location = new Point(0, 0);
			homeButton.Name = "homeButton";
			homeButton.Size = new Size(150, 35);
			homeButton.TabIndex = 0;
			homeButton.Text = "Home";
			homeButton.TextAlign = ContentAlignment.MiddleLeft;
			homeButton.UseVisualStyleBackColor = false;
			homeButton.Click += homeButton_Click;
			homeButton.MouseEnter += homeButton_MouseEnter;
			homeButton.MouseLeave += homeButton_MouseLeave;
			// 
			// visitsButton
			// 
			visitsButton.BackColor = Color.Transparent;
			visitsButton.FlatAppearance.BorderColor = Color.SlateGray;
			visitsButton.FlatAppearance.BorderSize = 0;
			visitsButton.FlatStyle = FlatStyle.Flat;
			visitsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			visitsButton.ForeColor = SystemColors.Control;
			visitsButton.Location = new Point(0, 165);
			visitsButton.Name = "visitsButton";
			visitsButton.Size = new Size(150, 35);
			visitsButton.TabIndex = 10;
			visitsButton.Text = "Visits";
			visitsButton.TextAlign = ContentAlignment.MiddleLeft;
			visitsButton.UseVisualStyleBackColor = false;
			visitsButton.MouseEnter += visitsButton_MouseEnter;
			visitsButton.MouseLeave += visitsButton_MouseLeave;
			// 
			// patientsButton
			// 
			patientsButton.BackColor = Color.Transparent;
			patientsButton.FlatAppearance.BorderSize = 0;
			patientsButton.FlatStyle = FlatStyle.Flat;
			patientsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			patientsButton.ForeColor = SystemColors.Control;
			patientsButton.Location = new Point(0, 55);
			patientsButton.Name = "patientsButton";
			patientsButton.Size = new Size(150, 35);
			patientsButton.TabIndex = 8;
			patientsButton.Text = "Patients";
			patientsButton.TextAlign = ContentAlignment.MiddleLeft;
			patientsButton.UseVisualStyleBackColor = false;
			patientsButton.Click += patientsControlButton_Click;
			patientsButton.MouseEnter += patientsButton_MouseEnter;
			patientsButton.MouseLeave += patientsButton_MouseLeave;
			// 
			// appointmentsButton
			// 
			appointmentsButton.BackColor = Color.Transparent;
			appointmentsButton.FlatAppearance.BorderColor = Color.SlateGray;
			appointmentsButton.FlatAppearance.BorderSize = 0;
			appointmentsButton.FlatStyle = FlatStyle.Flat;
			appointmentsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			appointmentsButton.ForeColor = SystemColors.Control;
			appointmentsButton.Location = new Point(0, 110);
			appointmentsButton.Name = "appointmentsButton";
			appointmentsButton.Size = new Size(150, 35);
			appointmentsButton.TabIndex = 9;
			appointmentsButton.Text = "Appointments";
			appointmentsButton.TextAlign = ContentAlignment.MiddleLeft;
			appointmentsButton.UseVisualStyleBackColor = false;
			appointmentsButton.MouseEnter += appointmentsButton_MouseEnter;
			appointmentsButton.MouseLeave += appointmentsButton_MouseLeave;
			// 
			// usernameLabel
			// 
			usernameLabel.AutoSize = true;
			usernameLabel.BackColor = Color.Transparent;
			usernameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			usernameLabel.ForeColor = SystemColors.Control;
			usernameLabel.Location = new Point(55, 605);
			usernameLabel.Name = "usernameLabel";
			usernameLabel.Size = new Size(65, 17);
			usernameLabel.TabIndex = 7;
			usernameLabel.Text = "username";
			usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// mainPanel
			// 
			mainPanel.Location = new Point(200, 0);
			mainPanel.Name = "mainPanel";
			mainPanel.Size = new Size(1065, 680);
			mainPanel.TabIndex = 8;
			// 
			// MainPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1264, 681);
			Controls.Add(mainPanel);
			Controls.Add(sidebarPanel);
			Margin = new Padding(2);
			Name = "MainPage";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Health Care App";
			sidebarPanel.ResumeLayout(false);
			sidebarPanel.PerformLayout();
			sidebarButtonPanel.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private Label userFullNameLabel;
        private Button logoutButton;
		private Panel sidebarPanel;
		private Label usernameLabel;
		private Panel mainPanel;
		private Button visitsButton;
		private Button appointmentsButton;
		private Button patientsButton;
		private Button homeButton;
		private Panel sidebarButtonPanel;
	}
}
