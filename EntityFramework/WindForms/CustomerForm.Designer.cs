namespace EntityFramework.WindForms
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
            dtpTimeStamp = new DateTimePicker();
            dgvCustomers = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtCustomerId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtpTimeStamp
            // 
            dtpTimeStamp.Font = new Font("Microsoft Sans Serif", 9.75F);
            dtpTimeStamp.Format = DateTimePickerFormat.Short;
            dtpTimeStamp.Location = new Point(390, 134);
            dtpTimeStamp.Name = "dtpTimeStamp";
            dtpTimeStamp.Size = new Size(167, 22);
            dtpTimeStamp.TabIndex = 29;
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(28, 234);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.Size = new Size(529, 154);
            dgvCustomers.TabIndex = 28;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnDelete.Location = new Point(482, 185);
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
            btnUpdate.Location = new Point(254, 185);
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
            btnAdd.Location = new Point(25, 185);
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
            txtLastName.Location = new Point(390, 92);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(167, 22);
            txtLastName.TabIndex = 24;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtFirstName.Location = new Point(112, 134);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(167, 22);
            txtFirstName.TabIndex = 23;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtCustomerId.Location = new Point(112, 92);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.ReadOnly = true;
            txtCustomerId.Size = new Size(167, 22);
            txtCustomerId.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F);
            label6.Location = new Point(301, 98);
            label6.Name = "label6";
            label6.Size = new Size(72, 16);
            label6.TabIndex = 20;
            label6.Text = "LastName:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F);
            label5.Location = new Point(301, 137);
            label5.Name = "label5";
            label5.Size = new Size(80, 16);
            label5.TabIndex = 19;
            label5.Text = "TimeStamp:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F);
            label4.Location = new Point(29, 95);
            label4.Name = "label4";
            label4.Size = new Size(21, 16);
            label4.TabIndex = 18;
            label4.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F);
            label3.Location = new Point(28, 137);
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
            panel1.Size = new Size(587, 66);
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
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 411);
            Controls.Add(panel1);
            Controls.Add(dtpTimeStamp);
            Controls.Add(dgvCustomers);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtCustomerId);
            Controls.Add(label6);
            Controls.Add(label5);
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

        private DateTimePicker dtpTimeStamp;
        private DataGridView dgvCustomers;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtCustomerId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Label label1;
    }
}