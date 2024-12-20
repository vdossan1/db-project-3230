﻿namespace HealthCareApp.View
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
			adminButton = new Button();
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
			userFullNameLabel.BackColor = Color.Transparent;
			userFullNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			userFullNameLabel.ForeColor = SystemColors.Control;
			userFullNameLabel.Location = new Point(22, 759);
			userFullNameLabel.Margin = new Padding(2, 0, 2, 0);
			userFullNameLabel.Name = "userFullNameLabel";
			userFullNameLabel.Size = new Size(129, 17);
			userFullNameLabel.TabIndex = 1;
			userFullNameLabel.Text = "last name, first name";
			// 
			// logoutButton
			// 
			logoutButton.BackColor = Color.Transparent;
			logoutButton.FlatAppearance.BorderSize = 0;
			logoutButton.FlatStyle = FlatStyle.Flat;
			logoutButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			logoutButton.ForeColor = SystemColors.Control;
			logoutButton.Image = Properties.Resources.logout_white;
			logoutButton.ImageAlign = ContentAlignment.MiddleLeft;
			logoutButton.Location = new Point(22, 790);
			logoutButton.Margin = new Padding(2);
			logoutButton.Name = "logoutButton";
			logoutButton.Size = new Size(150, 35);
			logoutButton.TabIndex = 2;
			logoutButton.Text = "Sign Out";
			logoutButton.UseVisualStyleBackColor = false;
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
			sidebarPanel.Size = new Size(200, 835);
			sidebarPanel.TabIndex = 6;
			// 
			// sidebarButtonPanel
			// 
			sidebarButtonPanel.BackColor = Color.Transparent;
			sidebarButtonPanel.Controls.Add(adminButton);
			sidebarButtonPanel.Controls.Add(patientsButton);
			sidebarButtonPanel.Controls.Add(appointmentsButton);
			sidebarButtonPanel.Location = new Point(22, 20);
			sidebarButtonPanel.Name = "sidebarButtonPanel";
			sidebarButtonPanel.Size = new Size(150, 486);
			sidebarButtonPanel.TabIndex = 11;
			// 
			// adminButton
			// 
			adminButton.BackColor = Color.Transparent;
			adminButton.FlatAppearance.BorderColor = Color.SlateGray;
			adminButton.FlatAppearance.BorderSize = 0;
			adminButton.FlatStyle = FlatStyle.Flat;
			adminButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			adminButton.ForeColor = SystemColors.Control;
			adminButton.ImageAlign = ContentAlignment.MiddleLeft;
			adminButton.Location = new Point(0, 110);
			adminButton.Name = "adminButton";
			adminButton.Size = new Size(150, 35);
			adminButton.TabIndex = 11;
			adminButton.Text = "Admin";
			adminButton.UseVisualStyleBackColor = false;
			adminButton.Click += adminControlButton_Click;
			adminButton.MouseEnter += adminButton_MouseEnter;
			adminButton.MouseLeave += adminButton_MouseLeave;
			// 
			// patientsButton
			// 
			patientsButton.BackColor = Color.Transparent;
			patientsButton.FlatAppearance.BorderSize = 0;
			patientsButton.FlatStyle = FlatStyle.Flat;
			patientsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			patientsButton.ForeColor = SystemColors.Control;
			patientsButton.Image = Properties.Resources.patients_white;
			patientsButton.ImageAlign = ContentAlignment.MiddleLeft;
			patientsButton.Location = new Point(0, 55);
			patientsButton.Name = "patientsButton";
			patientsButton.Size = new Size(150, 35);
			patientsButton.TabIndex = 8;
			patientsButton.Text = "Patients";
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
			appointmentsButton.Image = Properties.Resources.appointment_white;
			appointmentsButton.ImageAlign = ContentAlignment.MiddleLeft;
			appointmentsButton.Location = new Point(0, 0);
			appointmentsButton.Name = "appointmentsButton";
			appointmentsButton.Size = new Size(150, 35);
			appointmentsButton.TabIndex = 9;
			appointmentsButton.Text = "Dashboard";
			appointmentsButton.UseVisualStyleBackColor = false;
			appointmentsButton.Click += appointmentsControlButton_Click;
			appointmentsButton.MouseEnter += appointmentsButton_MouseEnter;
			appointmentsButton.MouseLeave += appointmentsButton_MouseLeave;
			// 
			// usernameLabel
			// 
			usernameLabel.AutoSize = true;
			usernameLabel.BackColor = Color.Transparent;
			usernameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			usernameLabel.ForeColor = SystemColors.Control;
			usernameLabel.Location = new Point(22, 735);
			usernameLabel.Name = "usernameLabel";
			usernameLabel.Size = new Size(65, 17);
			usernameLabel.TabIndex = 7;
			usernameLabel.Text = "username";
			// 
			// mainPanel
			// 
			mainPanel.Location = new Point(200, 0);
			mainPanel.Name = "mainPanel";
			mainPanel.Size = new Size(1380, 835);
			mainPanel.TabIndex = 8;
			// 
			// MainPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1582, 836);
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
		private Button appointmentsButton;
		private Button patientsButton;
		private Panel sidebarButtonPanel;
		private Button adminButton;
	}
}
