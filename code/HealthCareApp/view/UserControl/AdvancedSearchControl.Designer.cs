namespace HealthCareApp.view
{
    partial class AdvancedSearchControl
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
			advancedSearchGroupBox = new GroupBox();
			clearAdvSrcButton = new Button();
			advancedSearchButton = new Button();
			dateOfBirthLabel = new Label();
			lastNameLabel = new Label();
			firstNameLabel = new Label();
			datePicker = new DateTimePicker();
			lastNameTxtBox = new TextBox();
			firstNameTxtBox = new TextBox();
			advancedSearchGroupBox.SuspendLayout();
			SuspendLayout();
			// 
			// advancedSearchGroupBox
			// 
			advancedSearchGroupBox.Controls.Add(clearAdvSrcButton);
			advancedSearchGroupBox.Controls.Add(advancedSearchButton);
			advancedSearchGroupBox.Controls.Add(dateOfBirthLabel);
			advancedSearchGroupBox.Controls.Add(lastNameLabel);
			advancedSearchGroupBox.Controls.Add(firstNameLabel);
			advancedSearchGroupBox.Controls.Add(datePicker);
			advancedSearchGroupBox.Controls.Add(lastNameTxtBox);
			advancedSearchGroupBox.Controls.Add(firstNameTxtBox);
			advancedSearchGroupBox.Location = new Point(10, 8);
			advancedSearchGroupBox.Margin = new Padding(2);
			advancedSearchGroupBox.Name = "advancedSearchGroupBox";
			advancedSearchGroupBox.Padding = new Padding(2);
			advancedSearchGroupBox.Size = new Size(704, 80);
			advancedSearchGroupBox.TabIndex = 13;
			advancedSearchGroupBox.TabStop = false;
			advancedSearchGroupBox.Text = "Advanced Search";
			// 
			// clearAdvSrcButton
			// 
			clearAdvSrcButton.Location = new Point(582, 17);
			clearAdvSrcButton.Margin = new Padding(2);
			clearAdvSrcButton.Name = "clearAdvSrcButton";
			clearAdvSrcButton.Size = new Size(94, 20);
			clearAdvSrcButton.TabIndex = 7;
			clearAdvSrcButton.Text = "Clear";
			clearAdvSrcButton.UseVisualStyleBackColor = true;
			clearAdvSrcButton.Click += clearAdvSrcButton_Click;
			// 
			// advancedSearchButton
			// 
			advancedSearchButton.Location = new Point(582, 44);
			advancedSearchButton.Margin = new Padding(2);
			advancedSearchButton.Name = "advancedSearchButton";
			advancedSearchButton.Size = new Size(94, 20);
			advancedSearchButton.TabIndex = 6;
			advancedSearchButton.Text = "Search";
			advancedSearchButton.UseVisualStyleBackColor = true;
			advancedSearchButton.Click += advancedSearchDateOfBirthButton_Click;
			// 
			// dateOfBirthLabel
			// 
			dateOfBirthLabel.AutoSize = true;
			dateOfBirthLabel.Location = new Point(356, 20);
			dateOfBirthLabel.Margin = new Padding(2, 0, 2, 0);
			dateOfBirthLabel.Name = "dateOfBirthLabel";
			dateOfBirthLabel.Size = new Size(62, 15);
			dateOfBirthLabel.TabIndex = 5;
			dateOfBirthLabel.Text = "datePicker";
			// 
			// lastNameLabel
			// 
			lastNameLabel.AutoSize = true;
			lastNameLabel.Location = new Point(195, 22);
			lastNameLabel.Margin = new Padding(2, 0, 2, 0);
			lastNameLabel.Name = "lastNameLabel";
			lastNameLabel.Size = new Size(63, 15);
			lastNameLabel.TabIndex = 4;
			lastNameLabel.Text = "Last Name";
			// 
			// firstNameLabel
			// 
			firstNameLabel.AutoSize = true;
			firstNameLabel.Location = new Point(38, 22);
			firstNameLabel.Margin = new Padding(2, 0, 2, 0);
			firstNameLabel.Name = "firstNameLabel";
			firstNameLabel.Size = new Size(64, 15);
			firstNameLabel.TabIndex = 3;
			firstNameLabel.Text = "First Name";
			// 
			// datePicker
			// 
			datePicker.Location = new Point(354, 44);
			datePicker.Margin = new Padding(2);
			datePicker.Name = "datePicker";
			datePicker.Size = new Size(211, 23);
			datePicker.TabIndex = 2;
			// 
			// lastNameTxtBox
			// 
			lastNameTxtBox.Location = new Point(195, 45);
			lastNameTxtBox.Margin = new Padding(2);
			lastNameTxtBox.Name = "lastNameTxtBox";
			lastNameTxtBox.Size = new Size(130, 23);
			lastNameTxtBox.TabIndex = 1;
			// 
			// firstNameTxtBox
			// 
			firstNameTxtBox.Location = new Point(34, 45);
			firstNameTxtBox.Margin = new Padding(2);
			firstNameTxtBox.Name = "firstNameTxtBox";
			firstNameTxtBox.Size = new Size(130, 23);
			firstNameTxtBox.TabIndex = 0;
			// 
			// AdvancedSearchControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(advancedSearchGroupBox);
			Margin = new Padding(2);
			Name = "AdvancedSearchControl";
			Size = new Size(729, 101);
			advancedSearchGroupBox.ResumeLayout(false);
			advancedSearchGroupBox.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox advancedSearchGroupBox;
        private Button clearAdvSrcButton;
        private Button advancedSearchButton;
        private Label dateOfBirthLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private DateTimePicker datePicker;
        private TextBox lastNameTxtBox;
        private TextBox firstNameTxtBox;
    }
}
