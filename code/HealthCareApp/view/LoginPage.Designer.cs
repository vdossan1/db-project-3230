namespace HealthCareApp
{
    partial class LoginPage
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
            usernameTextField = new TextBox();
            passwordTextField = new TextBox();
            loginBtn = new Button();
            passwordLogin = new Label();
            passwordLabel = new Label();
            invalidLoginLabel = new Label();
            SuspendLayout();
            // 
            // usernameTextField
            // 
            usernameTextField.Location = new Point(298, 108);
            usernameTextField.Name = "usernameTextField";
            usernameTextField.Size = new Size(150, 31);
            usernameTextField.TabIndex = 0;
            // 
            // passwordTextField
            // 
            passwordTextField.Location = new Point(298, 195);
            passwordTextField.Name = "passwordTextField";
            passwordTextField.Size = new Size(150, 31);
            passwordTextField.TabIndex = 1;
            passwordTextField.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(327, 339);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(112, 34);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // passwordLogin
            // 
            passwordLogin.AutoSize = true;
            passwordLogin.Location = new Point(327, 66);
            passwordLogin.Name = "passwordLogin";
            passwordLogin.Size = new Size(91, 25);
            passwordLogin.TabIndex = 3;
            passwordLogin.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(331, 167);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 25);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // invalidLoginLabel
            // 
            invalidLoginLabel.AutoSize = true;
            invalidLoginLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            invalidLoginLabel.ForeColor = Color.Red;
            invalidLoginLabel.Location = new Point(248, 273);
            invalidLoginLabel.Name = "invalidLoginLabel";
            invalidLoginLabel.Size = new Size(257, 25);
            invalidLoginLabel.TabIndex = 5;
            invalidLoginLabel.Text = "Invalid Credentials, try again";
            invalidLoginLabel.Visible = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(invalidLoginLabel);
            Controls.Add(passwordLabel);
            Controls.Add(passwordLogin);
            Controls.Add(loginBtn);
            Controls.Add(passwordTextField);
            Controls.Add(usernameTextField);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextField;
        private TextBox passwordTextField;
        private Button loginBtn;
        private Label passwordLogin;
        private Label passwordLabel;
        private Label invalidLoginLabel;
    }
}
