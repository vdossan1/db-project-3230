namespace HealthCareApp.view
{
    partial class ManagePatientPage
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
            addressOneTextBox = new TextBox();
            ssnTextBox = new TextBox();
            zipCodeTextBox = new TextBox();
            addressTwoTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            cityTextBox = new TextBox();
            dateOfBirthPicker = new DateTimePicker();
            genderComboBox = new ComboBox();
            stateComboBox = new ComboBox();
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
            actionButton = new Button();
            cancelButton = new Button();
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
            // addressOneTextBox
            // 
            addressOneTextBox.Location = new Point(89, 472);
            addressOneTextBox.Name = "addressOneTextBox";
            addressOneTextBox.Size = new Size(408, 31);
            addressOneTextBox.TabIndex = 6;
            // 
            // ssnTextBox
            // 
            ssnTextBox.Location = new Point(379, 327);
            ssnTextBox.MaxLength = 9;
            ssnTextBox.Name = "ssnTextBox";
            ssnTextBox.Size = new Size(150, 31);
            ssnTextBox.TabIndex = 5;
            // 
            // zipCodeTextBox
            // 
            zipCodeTextBox.Location = new Point(540, 707);
            zipCodeTextBox.MaxLength = 5;
            zipCodeTextBox.Name = "zipCodeTextBox";
            zipCodeTextBox.Size = new Size(201, 31);
            zipCodeTextBox.TabIndex = 10;
            // 
            // addressTwoTextBox
            // 
            addressTwoTextBox.Location = new Point(89, 602);
            addressTwoTextBox.Name = "addressTwoTextBox";
            addressTwoTextBox.Size = new Size(408, 31);
            addressTwoTextBox.TabIndex = 7;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(89, 327);
            phoneNumberTextBox.MaxLength = 10;
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(150, 31);
            phoneNumberTextBox.TabIndex = 4;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(94, 707);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(150, 31);
            cityTextBox.TabIndex = 8;
            // 
            // dateOfBirthPicker
            // 
            dateOfBirthPicker.Location = new Point(337, 188);
            dateOfBirthPicker.Name = "dateOfBirthPicker";
            dateOfBirthPicker.Size = new Size(300, 31);
            dateOfBirthPicker.TabIndex = 3;
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(89, 188);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(183, 33);
            genderComboBox.TabIndex = 2;
            // 
            // stateComboBox
            // 
            stateComboBox.FormattingEnabled = true;
            stateComboBox.Location = new Point(304, 705);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new Size(183, 33);
            stateComboBox.TabIndex = 9;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(89, 53);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(97, 25);
            firstNameLabel.TabIndex = 15;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(443, 53);
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
            dateOfBirthLabel.Size = new Size(218, 25);
            dateOfBirthLabel.TabIndex = 17;
            dateOfBirthLabel.Text = "AppointmentDate of Birth";
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
            addressOneLabel.Location = new Point(89, 443);
            addressOneLabel.Name = "addressOneLabel";
            addressOneLabel.Size = new Size(92, 25);
            addressOneLabel.TabIndex = 19;
            addressOneLabel.Text = "Address 1";
            // 
            // addressTwoLabel
            // 
            addressTwoLabel.AutoSize = true;
            addressTwoLabel.Location = new Point(89, 573);
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
            phoneNumberLabel.Location = new Point(89, 298);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(132, 25);
            phoneNumberLabel.TabIndex = 24;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // ssnLabel
            // 
            ssnLabel.AutoSize = true;
            ssnLabel.Location = new Point(379, 298);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new Size(45, 25);
            ssnLabel.TabIndex = 25;
            ssnLabel.Text = "SSN";
            // 
            // actionButton
            // 
            actionButton.Enabled = false;
            actionButton.Location = new Point(137, 813);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(223, 68);
            actionButton.TabIndex = 11;
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(489, 820);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(179, 55);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelBtn_Click;
            // 
            // phoneNumberErrorLabel
            // 
            phoneNumberErrorLabel.AutoSize = true;
            phoneNumberErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            phoneNumberErrorLabel.ForeColor = Color.Red;
            phoneNumberErrorLabel.Location = new Point(89, 362);
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
            ssnErrorLabel.Location = new Point(379, 362);
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
            firstNameErrorLabel.Location = new Point(89, 117);
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
            lastNameErrorLabel.Location = new Point(441, 117);
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
            // ManagePatientPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
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
            Controls.Add(cancelButton);
            Controls.Add(actionButton);
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
            Controls.Add(stateComboBox);
            Controls.Add(genderComboBox);
            Controls.Add(dateOfBirthPicker);
            Controls.Add(cityTextBox);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(addressTwoTextBox);
            Controls.Add(zipCodeTextBox);
            Controls.Add(ssnTextBox);
            Controls.Add(addressOneTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Name = "ManagePatientPage";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox addressOneTextBox;
        private TextBox ssnTextBox;
        private TextBox zipCodeTextBox;
        private TextBox addressTwoTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox cityTextBox;
        private DateTimePicker dateOfBirthPicker;
        private ComboBox genderComboBox;
        private ComboBox stateComboBox;
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
        private Button actionButton;
        private Button cancelButton;
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