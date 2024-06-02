namespace ADO.UI
{
    partial class MakesForm
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
            dgvMakes = new DataGridView();
            lblName = new Label();
            txtName = new TextBox();
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblSearch = new Label();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMakes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMakes
            // 
            dgvMakes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMakes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMakes.Location = new Point(26, 213);
            dgvMakes.Name = "dgvMakes";
            dgvMakes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMakes.Size = new Size(568, 221);
            dgvMakes.TabIndex = 0;
            dgvMakes.Click += dgvMakes_SelectionChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.75F);
            lblName.Location = new Point(26, 99);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 17);
            lblName.TabIndex = 1;
            lblName.Text = "Name :";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9.75F);
            txtName.Location = new Point(87, 96);
            txtName.Name = "txtName";
            txtName.Size = new Size(278, 25);
            txtName.TabIndex = 2;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 9.75F);
            btnNew.Location = new Point(26, 153);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 26);
            btnNew.TabIndex = 3;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9.75F);
            btnUpdate.Location = new Point(158, 153);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 26);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.75F);
            btnDelete.Location = new Point(290, 153);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 26);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9.75F);
            txtSearch.Location = new Point(519, 96);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(75, 25);
            txtSearch.TabIndex = 15;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9.75F);
            btnSearch.Location = new Point(433, 154);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(161, 26);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.75F);
            lblSearch.Location = new Point(433, 101);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(80, 17);
            lblSearch.TabIndex = 13;
            lblSearch.Text = "Search by Id";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 66);
            panel1.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(265, 21);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 1;
            label1.Text = "Makes";
            // 
            // MakesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 455);
            Controls.Add(panel1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(lblSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(dgvMakes);
            Name = "MakesForm";
            Text = "Makes";
            ((System.ComponentModel.ISupportInitialize)dgvMakes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMakes;
        private Label lblName;
        private TextBox txtName;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblSearch;
        private Panel panel1;
        private Label label1;
    }
}