namespace HealthCareApp.view
{
    partial class AddPatientPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            addressOneTxtBox = new TextBox();
            ssnTxtBox = new TextBox();
            zipCodeTxtBox = new TextBox();
            addressTwoTxtBox = new TextBox();
            phoneNumberTxtBox = new TextBox();
            cityTxtBox = new TextBox();
            dateOfBirthPicker = new DateTimePicker();
            genderCmbBox = new ComboBox();
            stateCmbBox = new ComboBox();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            dateOfBirthLabel = new Label();
            genderLabel = new Label();
            addressOneLabel = new Label();
            addressTwoLabel = new Label();
            cityLabel = new Label();
            stateLabel = new Label();
            zipCodeLabel = new Label();
            phoneNumberLabel = new Label();
            ssnLabel = new Label();
            registerPatientBtn = new Button();
            cancelBtn = new Button();
            phoneNumberErrorLabel = new Label();
            ssnErrorLabel = new Label();
            zipCodeErrorLabel = new Label();
            firstNameErrorLabel = new Label();
            lastNameErrorLabel = new Label();
            addressOneErrorLabel = new Label();
            cityErrorLabel = new Label();
            stateErrorLabel = new Label();
            sexErrorLabel = new Label();
            dateOfBirthErrorLabel = new Label();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(89, 82);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(283, 31);
            firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(441, 82);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(305, 31);
            lastNameTextBox.TabIndex = 1;
            // 
            // addressOneTxtBox
            // 
            addressOneTxtBox.Location = new Point(89, 472);
            addressOneTxtBox.Name = "addressOneTxtBox";
            addressOneTxtBox.Size = new Size(408, 31);
            addressOneTxtBox.TabIndex = 6;
            // 
            // ssnTxtBox
            // 
            ssnTxtBox.Location = new Point(379, 327);
            ssnTxtBox.MaxLength = 9;
            ssnTxtBox.Name = "ssnTxtBox";
            ssnTxtBox.Size = new Size(150, 31);
            ssnTxtBox.TabIndex = 5;
            // 
            // zipCodeTxtBox
            // 
            zipCodeTxtBox.Location = new Point(540, 707);
            zipCodeTxtBox.MaxLength = 5;
            zipCodeTxtBox.Name = "zipCodeTxtBox";
            zipCodeTxtBox.Size = new Size(201, 31);
            zipCodeTxtBox.TabIndex = 10;
            // 
            // addressTwoTxtBox
            // 
            addressTwoTxtBox.Location = new Point(89, 602);
            addressTwoTxtBox.Name = "addressTwoTxtBox";
            addressTwoTxtBox.Size = new Size(408, 31);
            addressTwoTxtBox.TabIndex = 7;
            // 
            // phoneNumberTxtBox
            // 
            phoneNumberTxtBox.Location = new Point(89, 327);
            phoneNumberTxtBox.MaxLength = 10;
            phoneNumberTxtBox.Name = "phoneNumberTxtBox";
            phoneNumberTxtBox.Size = new Size(150, 31);
            phoneNumberTxtBox.TabIndex = 4;
            // 
            // cityTxtBox
            // 
            cityTxtBox.Location = new Point(94, 707);
            cityTxtBox.Name = "cityTxtBox";
            cityTxtBox.Size = new Size(150, 31);
            cityTxtBox.TabIndex = 8;
            // 
            // dateOfBirthPicker
            // 
            dateOfBirthPicker.Location = new Point(337, 188);
            dateOfBirthPicker.Name = "dateOfBirthPicker";
            dateOfBirthPicker.Size = new Size(300, 31);
            dateOfBirthPicker.TabIndex = 3;
            // 
            // genderCmbBox
            // 
            genderCmbBox.FormattingEnabled = true;
            genderCmbBox.Location = new Point(89, 188);
            genderCmbBox.Name = "genderCmbBox";
            genderCmbBox.Size = new Size(183, 33);
            genderCmbBox.TabIndex = 2;
            // 
            // stateCmbBox
            // 
            stateCmbBox.FormattingEnabled = true;
            stateCmbBox.Location = new Point(304, 705);
            stateCmbBox.Name = "stateCmbBox";
            stateCmbBox.Size = new Size(183, 33);
            stateCmbBox.TabIndex = 9;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(89, 54);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(97, 25);
            firstNameLabel.TabIndex = 15;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(443, 54);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(95, 25);
            lastNameLabel.TabIndex = 16;
            lastNameLabel.Text = "Last Name";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new Point(337, 155);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(112, 25);
            dateOfBirthLabel.TabIndex = 17;
            dateOfBirthLabel.Text = "Date of Birth";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(89, 155);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(39, 25);
            genderLabel.TabIndex = 18;
            genderLabel.Text = "Sex";
            // 
            // addressOneLabel
            // 
            addressOneLabel.AutoSize = true;
            addressOneLabel.Location = new Point(89, 444);
            addressOneLabel.Name = "addressOneLabel";
            addressOneLabel.Size = new Size(92, 25);
            addressOneLabel.TabIndex = 19;
            addressOneLabel.Text = "Address 1";
            // 
            // addressTwoLabel
            // 
            addressTwoLabel.AutoSize = true;
            addressTwoLabel.Location = new Point(89, 574);
            addressTwoLabel.Name = "addressTwoLabel";
            addressTwoLabel.Size = new Size(92, 25);
            addressTwoLabel.TabIndex = 20;
            addressTwoLabel.Text = "Address 2";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(101, 672);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(42, 25);
            cityLabel.TabIndex = 21;
            cityLabel.Text = "City";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new Point(309, 667);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(51, 25);
            stateLabel.TabIndex = 22;
            stateLabel.Text = "State";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new Point(549, 667);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new Size(84, 25);
            zipCodeLabel.TabIndex = 23;
            zipCodeLabel.Text = "ZIP Code";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(88, 299);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(132, 25);
            phoneNumberLabel.TabIndex = 24;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // ssnLabel
            // 
            ssnLabel.AutoSize = true;
            ssnLabel.Location = new Point(379, 299);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new Size(45, 25);
            ssnLabel.TabIndex = 25;
            ssnLabel.Text = "SSN";
            // 
            // registerPatientBtn
            // 
            registerPatientBtn.Enabled = false;
            registerPatientBtn.Location = new Point(137, 813);
            registerPatientBtn.Name = "registerPatientBtn";
            registerPatientBtn.Size = new Size(223, 68);
            registerPatientBtn.TabIndex = 11;
            registerPatientBtn.Text = "Register Patient";
            registerPatientBtn.UseVisualStyleBackColor = true;
            registerPatientBtn.Click += registerPatientBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(489, 820);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(179, 55);
            cancelBtn.TabIndex = 12;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // phoneNumberErrorLabel
            // 
            phoneNumberErrorLabel.AutoSize = true;
            phoneNumberErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            phoneNumberErrorLabel.ForeColor = Color.Red;
            phoneNumberErrorLabel.Location = new Point(89, 361);
            phoneNumberErrorLabel.Name = "phoneNumberErrorLabel";
            phoneNumberErrorLabel.Size = new Size(222, 25);
            phoneNumberErrorLabel.TabIndex = 26;
            phoneNumberErrorLabel.Text = "phoneNumberErrorLabel";
            // 
            // ssnErrorLabel
            // 
            ssnErrorLabel.AutoSize = true;
            ssnErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ssnErrorLabel.ForeColor = Color.Red;
            ssnErrorLabel.Location = new Point(379, 361);
            ssnErrorLabel.Name = "ssnErrorLabel";
            ssnErrorLabel.Size = new Size(126, 25);
            ssnErrorLabel.TabIndex = 27;
            ssnErrorLabel.Text = "ssnErrorLabel";
            // 
            // zipCodeErrorLabel
            // 
            zipCodeErrorLabel.AutoSize = true;
            zipCodeErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            zipCodeErrorLabel.ForeColor = Color.Red;
            zipCodeErrorLabel.Location = new Point(540, 750);
            zipCodeErrorLabel.Name = "zipCodeErrorLabel";
            zipCodeErrorLabel.Size = new Size(167, 25);
            zipCodeErrorLabel.TabIndex = 28;
            zipCodeErrorLabel.Text = "zipCodeErrorLabel";
            // 
            // firstNameErrorLabel
            // 
            firstNameErrorLabel.AutoSize = true;
            firstNameErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            firstNameErrorLabel.ForeColor = Color.Red;
            firstNameErrorLabel.Location = new Point(89, 116);
            firstNameErrorLabel.Name = "firstNameErrorLabel";
            firstNameErrorLabel.Size = new Size(183, 25);
            firstNameErrorLabel.TabIndex = 29;
            firstNameErrorLabel.Text = "firstNameErrorLabel";
            // 
            // lastNameErrorLabel
            // 
            lastNameErrorLabel.AutoSize = true;
            lastNameErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lastNameErrorLabel.ForeColor = Color.Red;
            lastNameErrorLabel.Location = new Point(441, 116);
            lastNameErrorLabel.Name = "lastNameErrorLabel";
            lastNameErrorLabel.Size = new Size(179, 25);
            lastNameErrorLabel.TabIndex = 30;
            lastNameErrorLabel.Text = "lastNameErrorLabel";
            // 
            // addressOneErrorLabel
            // 
            addressOneErrorLabel.AutoSize = true;
            addressOneErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addressOneErrorLabel.ForeColor = Color.Red;
            addressOneErrorLabel.Location = new Point(89, 517);
            addressOneErrorLabel.Name = "addressOneErrorLabel";
            addressOneErrorLabel.Size = new Size(199, 25);
            addressOneErrorLabel.TabIndex = 31;
            addressOneErrorLabel.Text = "addressOneErrorLabel";
            // 
            // cityErrorLabel
            // 
            cityErrorLabel.AutoSize = true;
            cityErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cityErrorLabel.ForeColor = Color.Red;
            cityErrorLabel.Location = new Point(96, 750);
            cityErrorLabel.Name = "cityErrorLabel";
            cityErrorLabel.Size = new Size(130, 25);
            cityErrorLabel.TabIndex = 32;
            cityErrorLabel.Text = "cityErrorLabel";
            // 
            // stateErrorLabel
            // 
            stateErrorLabel.AutoSize = true;
            stateErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            stateErrorLabel.ForeColor = Color.Red;
            stateErrorLabel.Location = new Point(304, 750);
            stateErrorLabel.Name = "stateErrorLabel";
            stateErrorLabel.Size = new Size(141, 25);
            stateErrorLabel.TabIndex = 33;
            stateErrorLabel.Text = "stateErrorLabel";
            // 
            // sexErrorLabel
            // 
            sexErrorLabel.AutoSize = true;
            sexErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            sexErrorLabel.ForeColor = Color.Red;
            sexErrorLabel.Location = new Point(93, 228);
            sexErrorLabel.Name = "sexErrorLabel";
            sexErrorLabel.Size = new Size(127, 25);
            sexErrorLabel.TabIndex = 34;
            sexErrorLabel.Text = "sexErrorLabel";
            // 
            // dateOfBirthErrorLabel
            // 
            dateOfBirthErrorLabel.AutoSize = true;
            dateOfBirthErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dateOfBirthErrorLabel.ForeColor = Color.Red;
            dateOfBirthErrorLabel.Location = new Point(337, 228);
            dateOfBirthErrorLabel.Name = "dateOfBirthErrorLabel";
            dateOfBirthErrorLabel.Size = new Size(201, 25);
            dateOfBirthErrorLabel.TabIndex = 35;
            dateOfBirthErrorLabel.Text = "dateOfBirthErrorLabel";
            // 
            // AddPatientPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 938);
            Controls.Add(dateOfBirthErrorLabel);
            Controls.Add(sexErrorLabel);
            Controls.Add(stateErrorLabel);
            Controls.Add(cityErrorLabel);
            Controls.Add(addressOneErrorLabel);
            Controls.Add(lastNameErrorLabel);
            Controls.Add(firstNameErrorLabel);
            Controls.Add(zipCodeErrorLabel);
            Controls.Add(ssnErrorLabel);
            Controls.Add(phoneNumberErrorLabel);
            Controls.Add(cancelBtn);
            Controls.Add(registerPatientBtn);
            Controls.Add(ssnLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(zipCodeLabel);
            Controls.Add(stateLabel);
            Controls.Add(cityLabel);
            Controls.Add(addressTwoLabel);
            Controls.Add(addressOneLabel);
            Controls.Add(genderLabel);
            Controls.Add(dateOfBirthLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(stateCmbBox);
            Controls.Add(genderCmbBox);
            Controls.Add(dateOfBirthPicker);
            Controls.Add(cityTxtBox);
            Controls.Add(phoneNumberTxtBox);
            Controls.Add(addressTwoTxtBox);
            Controls.Add(zipCodeTxtBox);
            Controls.Add(ssnTxtBox);
            Controls.Add(addressOneTxtBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Name = "AddPatientPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Patient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox addressOneTxtBox;
        private TextBox ssnTxtBox;
        private TextBox zipCodeTxtBox;
        private TextBox addressTwoTxtBox;
        private TextBox phoneNumberTxtBox;
        private TextBox cityTxtBox;
        private DateTimePicker dateOfBirthPicker;
        private ComboBox genderCmbBox;
        private ComboBox stateCmbBox;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label dateOfBirthLabel;
        private Label genderLabel;
        private Label addressOneLabel;
        private Label addressTwoLabel;
        private Label cityLabel;
        private Label stateLabel;
        private Label zipCodeLabel;
        private Label phoneNumberLabel;
        private Label ssnLabel;
        private Button registerPatientBtn;
        private Button cancelBtn;
        private Label phoneNumberErrorLabel;
        private Label ssnErrorLabel;
        private Label zipCodeErrorLabel;
        private Label firstNameErrorLabel;
        private Label lastNameErrorLabel;
        private Label addressOneErrorLabel;
        private Label cityErrorLabel;
        private Label stateErrorLabel;
        private Label sexErrorLabel;
        private Label dateOfBirthErrorLabel;
    }
}