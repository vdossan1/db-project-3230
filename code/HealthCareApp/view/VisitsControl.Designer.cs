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
            visitsSearchBar = new TextBox();
            editVisitBtn = new Button();
            createVisitBtn = new Button();
            visitsDataGridView = new DataGridView();
            createVisitLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)visitsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // visitAdvancedSearchControl
            // 
            visitAdvancedSearchControl.Location = new Point(30, 94);
            visitAdvancedSearchControl.Margin = new Padding(1, 2, 1, 2);
            visitAdvancedSearchControl.Name = "visitAdvancedSearchControl";
            visitAdvancedSearchControl.Size = new Size(1039, 158);
            visitAdvancedSearchControl.TabIndex = 17;
            // 
            // visitsSearchBar
            // 
            visitsSearchBar.BorderStyle = BorderStyle.FixedSingle;
            visitsSearchBar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            visitsSearchBar.ForeColor = SystemColors.ControlDarkDark;
            visitsSearchBar.Location = new Point(30, 26);
            visitsSearchBar.Margin = new Padding(4, 5, 4, 5);
            visitsSearchBar.Name = "visitsSearchBar";
            visitsSearchBar.Size = new Size(421, 39);
            visitsSearchBar.TabIndex = 16;
            visitsSearchBar.Text = "  Search";
            // 
            // editVisitBtn
            // 
            editVisitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editVisitBtn.Location = new Point(750, 24);
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
            createVisitBtn.Location = new Point(459, 24);
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
            visitsDataGridView.Location = new Point(30, 277);
            visitsDataGridView.Margin = new Padding(4, 5, 4, 5);
            visitsDataGridView.MultiSelect = false;
            visitsDataGridView.Name = "visitsDataGridView";
            visitsDataGridView.ReadOnly = true;
            visitsDataGridView.RowHeadersVisible = false;
            visitsDataGridView.RowHeadersWidth = 62;
            visitsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            visitsDataGridView.Size = new Size(1006, 820);
            visitsDataGridView.TabIndex = 13;
            // 
            // createVisitLabel
            // 
            createVisitLabel.AutoSize = true;
            createVisitLabel.ForeColor = Color.Red;
            createVisitLabel.Location = new Point(492, 79);
            createVisitLabel.Name = "createVisitLabel";
            createVisitLabel.Size = new Size(225, 25);
            createVisitLabel.TabIndex = 18;
            createVisitLabel.Text = "No available appointments";
            // 
            // VisitsControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(createVisitLabel);
            Controls.Add(visitAdvancedSearchControl);
            Controls.Add(visitsSearchBar);
            Controls.Add(editVisitBtn);
            Controls.Add(createVisitBtn);
            Controls.Add(visitsDataGridView);
            Name = "VisitsControl";
            Size = new Size(1521, 1133);
            ((System.ComponentModel.ISupportInitialize)visitsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AdvancedSearchControl visitAdvancedSearchControl;
        private TextBox visitsSearchBar;
        private Button editVisitBtn;
        private Button createVisitBtn;
        private DataGridView visitsDataGridView;
        private Label createVisitLabel;
    }
}
