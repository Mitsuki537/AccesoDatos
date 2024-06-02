namespace EntityFramework.UI

{
    partial class CreditRiskForm
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            cboCustomers = new ComboBox();
            txtCustomerId = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvCreditRisks = new DataGridView();
            btnSearch = new Button();
            txtSearchCreditRiskId = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCreditRisks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 66);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(238, 22);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 1;
            label1.Text = "CreditRisk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(26, 86);
            label2.Name = "label2";
            label2.Size = new Size(67, 16);
            label2.TabIndex = 1;
            label2.Text = "Customer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F);
            label3.Location = new Point(28, 176);
            label3.Name = "label3";
            label3.Size = new Size(72, 16);
            label3.TabIndex = 2;
            label3.Text = "FirstName:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F);
            label4.Location = new Point(28, 131);
            label4.Name = "label4";
            label4.Size = new Size(21, 16);
            label4.TabIndex = 3;
            label4.Text = "Id:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F);
            label6.Location = new Point(331, 88);
            label6.Name = "label6";
            label6.Size = new Size(72, 16);
            label6.TabIndex = 5;
            label6.Text = "LastName:";
            // 
            // cboCustomers
            // 
            cboCustomers.Font = new Font("Microsoft Sans Serif", 9.75F);
            cboCustomers.FormattingEnabled = true;
            cboCustomers.Location = new Point(110, 83);
            cboCustomers.Name = "cboCustomers";
            cboCustomers.Size = new Size(177, 24);
            cboCustomers.TabIndex = 6;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtCustomerId.Location = new Point(111, 128);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.ReadOnly = true;
            txtCustomerId.Size = new Size(177, 22);
            txtCustomerId.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtFirstName.Location = new Point(112, 173);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(177, 22);
            txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtLastName.Location = new Point(417, 85);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(177, 22);
            txtLastName.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnAdd.Location = new Point(29, 227);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 26);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnUpdate.Location = new Point(264, 227);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 26);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnDelete.Location = new Point(519, 227);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 26);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCreditRisks
            // 
            dgvCreditRisks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCreditRisks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCreditRisks.Location = new Point(26, 275);
            dgvCreditRisks.Name = "dgvCreditRisks";
            dgvCreditRisks.Size = new Size(568, 163);
            dgvCreditRisks.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnSearch.Location = new Point(433, 166);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(161, 26);
            btnSearch.TabIndex = 32;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchCreditRiskId
            // 
            txtSearchCreditRiskId.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtSearchCreditRiskId.Location = new Point(417, 131);
            txtSearchCreditRiskId.Name = "txtSearchCreditRiskId";
            txtSearchCreditRiskId.Size = new Size(177, 22);
            txtSearchCreditRiskId.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F);
            label5.Location = new Point(331, 134);
            label5.Name = "label5";
            label5.Size = new Size(80, 16);
            label5.TabIndex = 34;
            label5.Text = "SearchById:";
            // 
            // CreditRiskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 455);
            Controls.Add(label5);
            Controls.Add(txtSearchCreditRiskId);
            Controls.Add(btnSearch);
            Controls.Add(dgvCreditRisks);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtCustomerId);
            Controls.Add(cboCustomers);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "CreditRiskForm";
            Text = "CreditRisk";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCreditRisks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private ComboBox cboCustomers;
        private TextBox txtCustomerId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvCreditRisks;
        private Button btnSearch;
        private TextBox txtSearchCreditRiskId;
        private Label label5;
    }
}