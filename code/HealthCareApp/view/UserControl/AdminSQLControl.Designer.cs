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
			clearButton = new Button();
			queryResultGridView = new DataGridView();
			sqlEntryLabel = new Label();
			((System.ComponentModel.ISupportInitialize)queryResultGridView).BeginInit();
			SuspendLayout();
			// 
			// sqlEntryTextBox
			// 
			sqlEntryTextBox.Location = new Point(3, 33);
			sqlEntryTextBox.Multiline = true;
			sqlEntryTextBox.Name = "sqlEntryTextBox";
			sqlEntryTextBox.ScrollBars = ScrollBars.Both;
			sqlEntryTextBox.Size = new Size(847, 258);
			sqlEntryTextBox.TabIndex = 0;
			// 
			// executeButton
			// 
			executeButton.Location = new Point(859, 33);
			executeButton.Name = "executeButton";
			executeButton.Size = new Size(200, 40);
			executeButton.TabIndex = 1;
			executeButton.Text = "Execute Query";
			executeButton.UseVisualStyleBackColor = true;
			executeButton.Click += executeQueryButton_Click;
			// 
			// clearButton
			// 
			clearButton.Location = new Point(859, 79);
			clearButton.Name = "clearButton";
			clearButton.Size = new Size(200, 40);
			clearButton.TabIndex = 2;
			clearButton.Text = "Clear Query and Result";
			clearButton.UseVisualStyleBackColor = true;
			clearButton.Click += clearButton_Click;
			// 
			// queryResultGridView
			// 
			queryResultGridView.AllowUserToAddRows = false;
			queryResultGridView.AllowUserToDeleteRows = false;
			queryResultGridView.AllowUserToResizeColumns = false;
			queryResultGridView.AllowUserToResizeRows = false;
			queryResultGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			queryResultGridView.BackgroundColor = SystemColors.Control;
			queryResultGridView.BorderStyle = BorderStyle.Fixed3D;
			queryResultGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			queryResultGridView.GridColor = SystemColors.Control;
			queryResultGridView.Location = new Point(3, 297);
			queryResultGridView.MultiSelect = false;
			queryResultGridView.Name = "queryResultGridView";
			queryResultGridView.ReadOnly = true;
			queryResultGridView.RowHeadersVisible = false;
			queryResultGridView.RowHeadersWidth = 62;
			queryResultGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			queryResultGridView.Size = new Size(1053, 318);
			queryResultGridView.TabIndex = 3;
			// 
			// sqlEntryLabel
			// 
			sqlEntryLabel.AutoSize = true;
			sqlEntryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			sqlEntryLabel.Location = new Point(3, 15);
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
			Controls.Add(queryResultGridView);
			Controls.Add(clearButton);
			Controls.Add(executeButton);
			Controls.Add(sqlEntryTextBox);
			Name = "AdminSQLControl";
			Size = new Size(1059, 618);
			((System.ComponentModel.ISupportInitialize)queryResultGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox sqlEntryTextBox;
		private Button executeButton;
		private Button clearButton;
		private DataGridView queryResultGridView;
		private Label sqlEntryLabel;
	}
}
