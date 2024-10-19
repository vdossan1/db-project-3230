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
            SuspendLayout();
            // 
            // helloLabel
            // 
            helloLabel.AutoSize = true;
            helloLabel.Location = new Point(84, 44);
            helloLabel.Name = "helloLabel";
            helloLabel.Size = new Size(53, 25);
            helloLabel.TabIndex = 0;
            helloLabel.Text = "Hello";
            // 
            // userInfo
            // 
            userInfo.AutoSize = true;
            userInfo.Location = new Point(146, 48);
            userInfo.Name = "userInfo";
            userInfo.Size = new Size(176, 25);
            userInfo.TabIndex = 1;
            userInfo.Text = "last name, first name";
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(62, 353);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(112, 34);
            logoutButton.TabIndex = 2;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logoutButton);
            Controls.Add(userInfo);
            Controls.Add(helloLabel);
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
    }
}
