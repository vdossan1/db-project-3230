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
			userInfo = new Label();
			logoutButton = new Button();
			registerPatientBtn = new Button();
			editPatientBtn = new Button();
			SuspendLayout();
			// 
			// helloLabel
			// 
			helloLabel.AutoSize = true;
			helloLabel.Location = new Point(59, 26);
			helloLabel.Margin = new Padding(2, 0, 2, 0);
			helloLabel.Name = "helloLabel";
			helloLabel.Size = new Size(35, 15);
			helloLabel.TabIndex = 0;
			helloLabel.Text = "Hello";
			// 
			// userInfo
			// 
			userInfo.AutoSize = true;
			userInfo.Location = new Point(100, 26);
			userInfo.Margin = new Padding(2, 0, 2, 0);
			userInfo.Name = "userInfo";
			userInfo.Size = new Size(117, 15);
			userInfo.TabIndex = 1;
			userInfo.Text = "last name, first name";
			// 
			// logoutButton
			// 
			logoutButton.Location = new Point(43, 212);
			logoutButton.Margin = new Padding(2, 2, 2, 2);
			logoutButton.Name = "logoutButton";
			logoutButton.Size = new Size(78, 20);
			logoutButton.TabIndex = 2;
			logoutButton.Text = "Logout";
			logoutButton.UseVisualStyleBackColor = true;
			logoutButton.Click += logoutButton_Click;
			// 
			// registerPatientBtn
			// 
			registerPatientBtn.Location = new Point(59, 100);
			registerPatientBtn.Margin = new Padding(2, 2, 2, 2);
			registerPatientBtn.Name = "registerPatientBtn";
			registerPatientBtn.Size = new Size(113, 20);
			registerPatientBtn.TabIndex = 3;
			registerPatientBtn.Text = "Register Patient";
			registerPatientBtn.UseVisualStyleBackColor = true;
			registerPatientBtn.Click += registerPatientBtn_Click;
			// 
			// editPatientBtn
			// 
			editPatientBtn.Location = new Point(222, 100);
			editPatientBtn.Margin = new Padding(2);
			editPatientBtn.Name = "editPatientBtn";
			editPatientBtn.Size = new Size(113, 20);
			editPatientBtn.TabIndex = 4;
			editPatientBtn.Text = "Edit Patient";
			editPatientBtn.UseVisualStyleBackColor = true;
			editPatientBtn.Click += editPatientBtn_Click;
			// 
			// MainPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(560, 270);
			Controls.Add(editPatientBtn);
			Controls.Add(registerPatientBtn);
			Controls.Add(logoutButton);
			Controls.Add(userInfo);
			Controls.Add(helloLabel);
			Margin = new Padding(2, 2, 2, 2);
			Name = "MainPage";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Health Care App";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label helloLabel;
        private Label userInfo;
        private Button logoutButton;
        private Button registerPatientBtn;
		private Button editPatientBtn;
	}
}
