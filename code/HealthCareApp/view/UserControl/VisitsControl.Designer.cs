namespace HealthCareApp.view
{
    partial class VisitsControl
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
			visitAdvancedSearchControl = new AdvancedSearchControl();
			editVisitBtn = new Button();
			createVisitBtn = new Button();
			visitsDataGridView = new DataGridView();
			createVisitLabel = new Label();
			labTestResultsDataGridView = new DataGridView();
			enterTestResultsLabel = new Label();
			enterTestResultButton = new Button();
			((System.ComponentModel.ISupportInitialize)visitsDataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)labTestResultsDataGridView).BeginInit();
			SuspendLayout();
			// 
			// visitAdvancedSearchControl
			// 
			visitAdvancedSearchControl.Location = new Point(21, 65);
			visitAdvancedSearchControl.Margin = new Padding(1);
			visitAdvancedSearchControl.Name = "visitAdvancedSearchControl";
			visitAdvancedSearchControl.Size = new Size(727, 95);
			visitAdvancedSearchControl.TabIndex = 17;
			// 
			// editVisitBtn
			// 
			editVisitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			editVisitBtn.Location = new Point(278, 15);
			editVisitBtn.Margin = new Padding(2);
			editVisitBtn.Name = "editVisitBtn";
			editVisitBtn.Size = new Size(200, 31);
			editVisitBtn.TabIndex = 14;
			editVisitBtn.Text = "Edit Visit Info";
			editVisitBtn.UseVisualStyleBackColor = true;
			editVisitBtn.Click += editVisitBtn_Click;
			// 
			// createVisitBtn
			// 
			createVisitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			createVisitBtn.Location = new Point(74, 15);
			createVisitBtn.Margin = new Padding(2);
			createVisitBtn.Name = "createVisitBtn";
			createVisitBtn.Size = new Size(200, 31);
			createVisitBtn.TabIndex = 15;
			createVisitBtn.Text = "Create Visit";
			createVisitBtn.UseVisualStyleBackColor = true;
			createVisitBtn.Click += createVisitBtn_Click;
			// 
			// visitsDataGridView
			// 
			visitsDataGridView.AllowUserToAddRows = false;
			visitsDataGridView.AllowUserToDeleteRows = false;
			visitsDataGridView.AllowUserToResizeColumns = false;
			visitsDataGridView.AllowUserToResizeRows = false;
			visitsDataGridView.BackgroundColor = SystemColors.Control;
			visitsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			visitsDataGridView.GridColor = SystemColors.Control;
			visitsDataGridView.Location = new Point(21, 170);
			visitsDataGridView.MultiSelect = false;
			visitsDataGridView.Name = "visitsDataGridView";
			visitsDataGridView.ReadOnly = true;
			visitsDataGridView.RowHeadersVisible = false;
			visitsDataGridView.RowHeadersWidth = 62;
			visitsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			visitsDataGridView.Size = new Size(400, 500);
			visitsDataGridView.TabIndex = 13;
			// 
			// createVisitLabel
			// 
			createVisitLabel.AutoSize = true;
			createVisitLabel.ForeColor = Color.Red;
			createVisitLabel.Location = new Point(97, 48);
			createVisitLabel.Margin = new Padding(2, 0, 2, 0);
			createVisitLabel.Name = "createVisitLabel";
			createVisitLabel.Size = new Size(149, 15);
			createVisitLabel.TabIndex = 18;
			createVisitLabel.Text = "No available appointments";
			// 
			// labTestResultsDataGridView
			// 
			labTestResultsDataGridView.AllowUserToAddRows = false;
			labTestResultsDataGridView.AllowUserToDeleteRows = false;
			labTestResultsDataGridView.AllowUserToResizeColumns = false;
			labTestResultsDataGridView.AllowUserToResizeRows = false;
			labTestResultsDataGridView.BackgroundColor = SystemColors.Control;
			labTestResultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			labTestResultsDataGridView.GridColor = SystemColors.Control;
			labTestResultsDataGridView.Location = new Point(427, 170);
			labTestResultsDataGridView.MultiSelect = false;
			labTestResultsDataGridView.Name = "labTestResultsDataGridView";
			labTestResultsDataGridView.ReadOnly = true;
			labTestResultsDataGridView.RowHeadersVisible = false;
			labTestResultsDataGridView.RowHeadersWidth = 62;
			labTestResultsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			labTestResultsDataGridView.Size = new Size(614, 500);
			labTestResultsDataGridView.TabIndex = 19;
			// 
			// enterTestResultsLabel
			// 
			enterTestResultsLabel.AutoSize = true;
			enterTestResultsLabel.ForeColor = Color.Red;
			enterTestResultsLabel.Location = new Point(816, 48);
			enterTestResultsLabel.Margin = new Padding(2, 0, 2, 0);
			enterTestResultsLabel.Name = "enterTestResultsLabel";
			enterTestResultsLabel.Size = new Size(149, 15);
			enterTestResultsLabel.TabIndex = 22;
			enterTestResultsLabel.Text = "No tests found for this visit";
			// 
			// enterTestResultButton
			// 
			enterTestResultButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			enterTestResultButton.Location = new Point(793, 15);
			enterTestResultButton.Margin = new Padding(2);
			enterTestResultButton.Name = "enterTestResultButton";
			enterTestResultButton.Size = new Size(200, 31);
			enterTestResultButton.TabIndex = 21;
			enterTestResultButton.Text = "Enter Test Results";
			enterTestResultButton.UseVisualStyleBackColor = true;
			enterTestResultButton.Click += this.enterTestResultsBtn_Click;
			// 
			// VisitsControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(enterTestResultsLabel);
			Controls.Add(enterTestResultButton);
			Controls.Add(labTestResultsDataGridView);
			Controls.Add(createVisitLabel);
			Controls.Add(visitAdvancedSearchControl);
			Controls.Add(editVisitBtn);
			Controls.Add(createVisitBtn);
			Controls.Add(visitsDataGridView);
			Margin = new Padding(2);
			Name = "VisitsControl";
			Size = new Size(1065, 680);
			((System.ComponentModel.ISupportInitialize)visitsDataGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)labTestResultsDataGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private AdvancedSearchControl visitAdvancedSearchControl;
        private Button editVisitBtn;
        private Button createVisitBtn;
        private DataGridView visitsDataGridView;
        private Label createVisitLabel;
		private DataGridView labTestResultsDataGridView;
		private Label enterTestResultsLabel;
		private Button enterTestResultButton;
	}
}
