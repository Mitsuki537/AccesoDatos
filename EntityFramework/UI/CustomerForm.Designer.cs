namespace EntityFramework.UI
{
    partial class CustomerForm
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
            dgvCustomers = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtCustomerId = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            btnSearch = new Button();
            txtSearchCustomerId = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(27, 274);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.Size = new Size(568, 163);
            dgvCustomers.TabIndex = 28;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnDelete.Location = new Point(518, 229);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 26);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnUpdate.Location = new Point(273, 229);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 26);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnAdd.Location = new Point(29, 229);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 26);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtLastName.Location = new Point(112, 179);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(190, 22);
            txtLastName.TabIndex = 24;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtFirstName.Location = new Point(112, 131);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(190, 22);
            txtFirstName.TabIndex = 23;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtCustomerId.Location = new Point(112, 89);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.ReadOnly = true;
            txtCustomerId.Size = new Size(190, 22);
            txtCustomerId.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F);
            label6.Location = new Point(28, 182);
            label6.Name = "label6";
            label6.Size = new Size(72, 16);
            label6.TabIndex = 20;
            label6.Text = "LastName:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F);
            label4.Location = new Point(29, 89);
            label4.Name = "label4";
            label4.Size = new Size(21, 16);
            label4.TabIndex = 18;
            label4.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F);
            label3.Location = new Point(28, 134);
            label3.Name = "label3";
            label3.Size = new Size(72, 16);
            label3.TabIndex = 17;
            label3.Text = "FirstName:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 66);
            panel1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(241, 21);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 1;
            label1.Text = "Customer";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnSearch.Location = new Point(432, 129);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(161, 26);
            btnSearch.TabIndex = 31;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchCustomerId
            // 
            txtSearchCustomerId.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtSearchCustomerId.Location = new Point(403, 89);
            txtSearchCustomerId.Name = "txtSearchCustomerId";
            txtSearchCustomerId.Size = new Size(190, 22);
            txtSearchCustomerId.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(323, 92);
            label2.Name = "label2";
            label2.Size = new Size(80, 16);
            label2.TabIndex = 33;
            label2.Text = "SearchById:";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 455);
            Controls.Add(label2);
            Controls.Add(txtSearchCustomerId);
            Controls.Add(btnSearch);
            Controls.Add(panel1);
            Controls.Add(dgvCustomers);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtCustomerId);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "CustomerForm";
            Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvCustomers;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtCustomerId;
        private Label label6;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Button btnSearch;
        private TextBox txtSearchCustomerId;
        private Label label2;
    }
}