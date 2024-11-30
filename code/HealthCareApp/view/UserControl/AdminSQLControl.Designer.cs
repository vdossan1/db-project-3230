namespace HealthCareApp.view
{
	partial class AdminSQLControl
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
			sqlEntryTextBox = new TextBox();
			executeButton = new Button();
			button2 = new Button();
			dataGridView1 = new DataGridView();
			sqlEntryLabel = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// sqlEntryTextBox
			// 
			sqlEntryTextBox.Location = new Point(3, 33);
			sqlEntryTextBox.Multiline = true;
			sqlEntryTextBox.Name = "sqlEntryTextBox";
			sqlEntryTextBox.ScrollBars = ScrollBars.Both;
			sqlEntryTextBox.Size = new Size(400, 532);
			sqlEntryTextBox.TabIndex = 0;
			// 
			// executeButton
			// 
			executeButton.Location = new Point(3, 571);
			executeButton.Name = "executeButton";
			executeButton.Size = new Size(244, 44);
			executeButton.TabIndex = 1;
			executeButton.Text = "button1";
			executeButton.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(253, 571);
			button2.Name = "button2";
			button2.Size = new Size(150, 44);
			button2.TabIndex = 2;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(409, 3);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(647, 612);
			dataGridView1.TabIndex = 3;
			// 
			// sqlEntryLabel
			// 
			sqlEntryLabel.AutoSize = true;
			sqlEntryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			sqlEntryLabel.Location = new Point(111, 15);
			sqlEntryLabel.Name = "sqlEntryLabel";
			sqlEntryLabel.Size = new Size(136, 15);
			sqlEntryLabel.TabIndex = 4;
			sqlEntryLabel.Text = "Enter SQL Queries Below";
			// 
			// AdminSQLControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(sqlEntryLabel);
			Controls.Add(dataGridView1);
			Controls.Add(button2);
			Controls.Add(executeButton);
			Controls.Add(sqlEntryTextBox);
			Name = "AdminSQLControl";
			Size = new Size(1059, 618);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox sqlEntryTextBox;
		private Button executeButton;
		private Button button2;
		private DataGridView dataGridView1;
		private Label sqlEntryLabel;
	}
}
