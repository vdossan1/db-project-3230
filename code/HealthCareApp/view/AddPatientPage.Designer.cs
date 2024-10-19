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
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(89, 81);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(283, 31);
            firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(442, 81);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(306, 31);
            lastNameTextBox.TabIndex = 1;
            // 
            // addressOneTxtBox
            // 
            addressOneTxtBox.Location = new Point(89, 471);
            addressOneTxtBox.Name = "addressOneTxtBox";
            addressOneTxtBox.Size = new Size(408, 31);
            addressOneTxtBox.TabIndex = 4;
            // 
            // ssnTxtBox
            // 
            ssnTxtBox.Location = new Point(291, 326);
            ssnTxtBox.Name = "ssnTxtBox";
            ssnTxtBox.Size = new Size(150, 31);
            ssnTxtBox.TabIndex = 5;
            // 
            // zipCodeTxtBox
            // 
            zipCodeTxtBox.Location = new Point(540, 707);
            zipCodeTxtBox.Name = "zipCodeTxtBox";
            zipCodeTxtBox.Size = new Size(201, 31);
            zipCodeTxtBox.TabIndex = 6;
            // 
            // addressTwoTxtBox
            // 
            addressTwoTxtBox.Location = new Point(89, 583);
            addressTwoTxtBox.Name = "addressTwoTxtBox";
            addressTwoTxtBox.Size = new Size(408, 31);
            addressTwoTxtBox.TabIndex = 7;
            // 
            // phoneNumberTxtBox
            // 
            phoneNumberTxtBox.Location = new Point(89, 326);
            phoneNumberTxtBox.Name = "phoneNumberTxtBox";
            phoneNumberTxtBox.Size = new Size(150, 31);
            phoneNumberTxtBox.TabIndex = 8;
            // 
            // cityTxtBox
            // 
            cityTxtBox.Location = new Point(94, 707);
            cityTxtBox.Name = "cityTxtBox";
            cityTxtBox.Size = new Size(150, 31);
            cityTxtBox.TabIndex = 11;
            // 
            // dateOfBirthPicker
            // 
            dateOfBirthPicker.Location = new Point(337, 188);
            dateOfBirthPicker.Name = "dateOfBirthPicker";
            dateOfBirthPicker.Size = new Size(300, 31);
            dateOfBirthPicker.TabIndex = 12;
            // 
            // genderCmbBox
            // 
            genderCmbBox.FormattingEnabled = true;
            genderCmbBox.Location = new Point(89, 188);
            genderCmbBox.Name = "genderCmbBox";
            genderCmbBox.Size = new Size(182, 33);
            genderCmbBox.TabIndex = 13;
            // 
            // stateCmbBox
            // 
            stateCmbBox.FormattingEnabled = true;
            stateCmbBox.Location = new Point(304, 705);
            stateCmbBox.Name = "stateCmbBox";
            stateCmbBox.Size = new Size(182, 33);
            stateCmbBox.TabIndex = 14;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(96, 34);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(97, 25);
            firstNameLabel.TabIndex = 15;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(451, 33);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(95, 25);
            lastNameLabel.TabIndex = 16;
            lastNameLabel.Text = "Last Name";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new Point(362, 144);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(112, 25);
            dateOfBirthLabel.TabIndex = 17;
            dateOfBirthLabel.Text = "Date of Birth";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(93, 155);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(69, 25);
            genderLabel.TabIndex = 18;
            genderLabel.Text = "Gender";
            // 
            // addressOneLabel
            // 
            addressOneLabel.AutoSize = true;
            addressOneLabel.Location = new Point(89, 428);
            addressOneLabel.Name = "addressOneLabel";
            addressOneLabel.Size = new Size(92, 25);
            addressOneLabel.TabIndex = 19;
            addressOneLabel.Text = "Address 1";
            // 
            // addressTwoLabel
            // 
            addressTwoLabel.AutoSize = true;
            addressTwoLabel.Location = new Point(94, 542);
            addressTwoLabel.Name = "addressTwoLabel";
            addressTwoLabel.Size = new Size(92, 25);
            addressTwoLabel.TabIndex = 20;
            addressTwoLabel.Text = "Address 2";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(101, 671);
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
            zipCodeLabel.Location = new Point(548, 667);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new Size(84, 25);
            zipCodeLabel.TabIndex = 23;
            zipCodeLabel.Text = "ZIP Code";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(92, 287);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(132, 25);
            phoneNumberLabel.TabIndex = 24;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // ssnLabel
            // 
            ssnLabel.AutoSize = true;
            ssnLabel.Location = new Point(296, 289);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new Size(45, 25);
            ssnLabel.TabIndex = 25;
            ssnLabel.Text = "SSN";
            // 
            // registerPatientBtn
            // 
            registerPatientBtn.Location = new Point(137, 813);
            registerPatientBtn.Name = "registerPatientBtn";
            registerPatientBtn.Size = new Size(223, 69);
            registerPatientBtn.TabIndex = 26;
            registerPatientBtn.Text = "Register Patient";
            registerPatientBtn.UseVisualStyleBackColor = true;
            registerPatientBtn.Click += registerPatientBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(489, 820);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(179, 55);
            cancelBtn.TabIndex = 27;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // AddPatientPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 938);
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
            Text = "AddPatientPage";
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
    }
}