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
            visitAdvancedSearchControl.Location = new Point(30, 108);
            visitAdvancedSearchControl.Margin = new Padding(1, 2, 1, 2);
            visitAdvancedSearchControl.Name = "visitAdvancedSearchControl";
            visitAdvancedSearchControl.Size = new Size(1039, 158);
            visitAdvancedSearchControl.TabIndex = 17;
            // 
            // editVisitBtn
            // 
            editVisitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editVisitBtn.Location = new Point(397, 25);
            editVisitBtn.Name = "editVisitBtn";
            editVisitBtn.Size = new Size(286, 52);
            editVisitBtn.TabIndex = 14;
            editVisitBtn.Text = "Edit Visit Info";
            editVisitBtn.UseVisualStyleBackColor = true;
            editVisitBtn.Click += editVisitBtn_Click;
            // 
            // createVisitBtn
            // 
            createVisitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createVisitBtn.Location = new Point(106, 25);
            createVisitBtn.Name = "createVisitBtn";
            createVisitBtn.Size = new Size(286, 52);
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
            visitsDataGridView.Location = new Point(30, 283);
            visitsDataGridView.Margin = new Padding(4, 5, 4, 5);
            visitsDataGridView.MultiSelect = false;
            visitsDataGridView.Name = "visitsDataGridView";
            visitsDataGridView.ReadOnly = true;
            visitsDataGridView.RowHeadersVisible = false;
            visitsDataGridView.RowHeadersWidth = 62;
            visitsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            visitsDataGridView.Size = new Size(444, 833);
            visitsDataGridView.TabIndex = 13;
            // 
            // createVisitLabel
            // 
            createVisitLabel.AutoSize = true;
            createVisitLabel.ForeColor = Color.Red;
            createVisitLabel.Location = new Point(139, 80);
            createVisitLabel.Name = "createVisitLabel";
            createVisitLabel.Size = new Size(225, 25);
            createVisitLabel.TabIndex = 18;
            createVisitLabel.Text = "No available appointments";
            // 
            // labTestResultsDataGridView
            // 
            labTestResultsDataGridView.AllowUserToAddRows = false;
            labTestResultsDataGridView.AllowUserToDeleteRows = false;
            labTestResultsDataGridView.AllowUserToResizeColumns = false;
            labTestResultsDataGridView.AllowUserToResizeRows = false;
            labTestResultsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            labTestResultsDataGridView.BackgroundColor = SystemColors.Control;
            labTestResultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            labTestResultsDataGridView.GridColor = SystemColors.Control;
            labTestResultsDataGridView.Location = new Point(483, 283);
            labTestResultsDataGridView.Margin = new Padding(4, 5, 4, 5);
            labTestResultsDataGridView.MultiSelect = false;
            labTestResultsDataGridView.Name = "labTestResultsDataGridView";
            labTestResultsDataGridView.ReadOnly = true;
            labTestResultsDataGridView.RowHeadersVisible = false;
            labTestResultsDataGridView.RowHeadersWidth = 62;
            labTestResultsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            labTestResultsDataGridView.Size = new Size(1004, 833);
            labTestResultsDataGridView.TabIndex = 19;
            // 
            // enterTestResultsLabel
            // 
            enterTestResultsLabel.AutoSize = true;
            enterTestResultsLabel.ForeColor = Color.Red;
            enterTestResultsLabel.Location = new Point(1166, 80);
            enterTestResultsLabel.Name = "enterTestResultsLabel";
            enterTestResultsLabel.Size = new Size(228, 25);
            enterTestResultsLabel.TabIndex = 22;
            enterTestResultsLabel.Text = "No tests found for this visit";
            // 
            // enterTestResultButton
            // 
            enterTestResultButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enterTestResultButton.Location = new Point(1133, 25);
            enterTestResultButton.Name = "enterTestResultButton";
            enterTestResultButton.Size = new Size(286, 52);
            enterTestResultButton.TabIndex = 21;
            enterTestResultButton.Text = "Enter Test Results";
            enterTestResultButton.UseVisualStyleBackColor = true;
            enterTestResultButton.Click += enterTestResultsBtn_Click;
            // 
            // VisitsControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(enterTestResultsLabel);
            Controls.Add(enterTestResultButton);
            Controls.Add(labTestResultsDataGridView);
            Controls.Add(createVisitLabel);
            Controls.Add(visitAdvancedSearchControl);
            Controls.Add(editVisitBtn);
            Controls.Add(createVisitBtn);
            Controls.Add(visitsDataGridView);
            Name = "VisitsControl";
            Size = new Size(1521, 1133);
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
