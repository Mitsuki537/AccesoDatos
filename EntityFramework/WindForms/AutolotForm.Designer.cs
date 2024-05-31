namespace EntityFramework
{
    partial class AutolotForm
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
            label1 = new Label();
            panel1 = new Panel();
            btnCreditRisk = new Button();
            btnCustomerForm = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(7, 18);
            label1.Name = "label1";
            label1.Size = new Size(106, 17);
            label1.TabIndex = 0;
            label1.Text = "AutoLot System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(btnCreditRisk);
            panel1.Controls.Add(btnCustomerForm);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(116, 490);
            panel1.TabIndex = 10;
            // 
            // btnCreditRisk
            // 
            btnCreditRisk.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreditRisk.Location = new Point(19, 113);
            btnCreditRisk.Name = "btnCreditRisk";
            btnCreditRisk.Size = new Size(75, 23);
            btnCreditRisk.TabIndex = 13;
            btnCreditRisk.Text = "CreditRisk";
            btnCreditRisk.UseVisualStyleBackColor = true;
            btnCreditRisk.Click += btnCreditRisk_Click;
            // 
            // btnCustomerForm
            // 
            btnCustomerForm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomerForm.Location = new Point(19, 69);
            btnCustomerForm.Name = "btnCustomerForm";
            btnCustomerForm.Size = new Size(75, 23);
            btnCustomerForm.TabIndex = 12;
            btnCustomerForm.Text = "Customer";
            btnCustomerForm.UseVisualStyleBackColor = true;
            btnCustomerForm.Click += btnCustomerForm_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumBlue;
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.MediumBlue;
            panel2.Location = new Point(116, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(603, 43);
            panel2.TabIndex = 11;
            // 
            // AutolotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 490);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AutolotForm";
            Text = "Main";
            Load += AutolotForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox4;
        private Panel panel1;
        private Panel panel2;
        private Button btnCustomerForm;
        private Button btnCreditRisk;
    }
}