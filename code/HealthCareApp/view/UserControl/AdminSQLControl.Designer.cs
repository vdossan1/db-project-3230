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
			queryResultGridView = new DataGridView();
			sqlEntryLabel = new Label();
			((System.ComponentModel.ISupportInitialize)queryResultGridView).BeginInit();
			SuspendLayout();
			// 
			// sqlEntryTextBox
			// 
			sqlEntryTextBox.Location = new Point(4, 55);
			sqlEntryTextBox.Margin = new Padding(4, 5, 4, 5);
			sqlEntryTextBox.Multiline = true;
			sqlEntryTextBox.Name = "sqlEntryTextBox";
			sqlEntryTextBox.ScrollBars = ScrollBars.Both;
			sqlEntryTextBox.Size = new Size(570, 884);
			sqlEntryTextBox.TabIndex = 0;
			// 
			// executeButton
			// 
			executeButton.Location = new Point(4, 952);
			executeButton.Margin = new Padding(4, 5, 4, 5);
			executeButton.Name = "executeButton";
			executeButton.Size = new Size(349, 73);
			executeButton.TabIndex = 1;
			executeButton.Text = "Execute Query";
			executeButton.UseVisualStyleBackColor = true;
			executeButton.Click += executeQueryButton_Click;
			// 
			// button2
			// 
			button2.Location = new Point(361, 952);
			button2.Margin = new Padding(4, 5, 4, 5);
			button2.Name = "button2";
			button2.Size = new Size(214, 73);
			button2.TabIndex = 2;
			button2.Text = "Clear Query and Result";
			button2.UseVisualStyleBackColor = true;
			button2.Click += clearButton_Click;
			// 
			// queryResultGridView
			// 
			queryResultGridView.AllowUserToAddRows = false;
			queryResultGridView.AllowUserToDeleteRows = false;
			queryResultGridView.AllowUserToResizeColumns = false;
			queryResultGridView.AllowUserToResizeRows = false;
			queryResultGridView.BackgroundColor = SystemColors.Control;
			queryResultGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			queryResultGridView.Enabled = false;
			queryResultGridView.GridColor = SystemColors.Control;
			queryResultGridView.Location = new Point(584, 5);
			queryResultGridView.Margin = new Padding(4, 5, 4, 5);
			queryResultGridView.MultiSelect = false;
			queryResultGridView.Name = "queryResultGridView";
			queryResultGridView.ReadOnly = true;
			queryResultGridView.RowHeadersWidth = 62;
			queryResultGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			queryResultGridView.Size = new Size(924, 1020);
			queryResultGridView.TabIndex = 3;
			// 
			// sqlEntryLabel
			// 
			sqlEntryLabel.AutoSize = true;
			sqlEntryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			sqlEntryLabel.Location = new Point(159, 25);
			sqlEntryLabel.Margin = new Padding(4, 0, 4, 0);
			sqlEntryLabel.Name = "sqlEntryLabel";
			sqlEntryLabel.Size = new Size(206, 25);
			sqlEntryLabel.TabIndex = 4;
			sqlEntryLabel.Text = "Enter SQL Queries Below";
			// 
			// AdminSQLControl
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(sqlEntryLabel);
			Controls.Add(queryResultGridView);
			Controls.Add(button2);
			Controls.Add(executeButton);
			Controls.Add(sqlEntryTextBox);
			Margin = new Padding(4, 5, 4, 5);
			Name = "AdminSQLControl";
			Size = new Size(1513, 1030);
			((System.ComponentModel.ISupportInitialize)queryResultGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox sqlEntryTextBox;
		private Button executeButton;
		private Button button2;
		private DataGridView queryResultGridView;
		private Label sqlEntryLabel;
	}
}
