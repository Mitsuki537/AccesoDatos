namespace ADO.UI
{
    partial class AutoLotForm
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
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            btnInventoryForm = new Button();
            btnMakesForm = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumBlue;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.MediumBlue;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(719, 43);
            panel2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(5, 15);
            label1.Name = "label1";
            label1.Size = new Size(106, 17);
            label1.TabIndex = 0;
            label1.Text = "AutoLot System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(btnInventoryForm);
            panel1.Controls.Add(btnMakesForm);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(116, 447);
            panel1.TabIndex = 13;
            // 
            // btnInventoryForm
            // 
            btnInventoryForm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventoryForm.Location = new Point(19, 66);
            btnInventoryForm.Name = "btnInventoryForm";
            btnInventoryForm.Size = new Size(75, 23);
            btnInventoryForm.TabIndex = 13;
            btnInventoryForm.Text = "Inventory";
            btnInventoryForm.UseVisualStyleBackColor = true;
            btnInventoryForm.Click += btnInventoryForm_Click;
            // 
            // btnMakesForm
            // 
            btnMakesForm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMakesForm.Location = new Point(19, 22);
            btnMakesForm.Name = "btnMakesForm";
            btnMakesForm.Size = new Size(75, 23);
            btnMakesForm.TabIndex = 12;
            btnMakesForm.Text = "Makes";
            btnMakesForm.UseVisualStyleBackColor = true;
            btnMakesForm.Click += btnMakesForm_Click;
            // 
            // AutoLotFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 490);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AutoLotFrm";
            Text = "Main";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button btnInventoryForm;
        private Button btnMakesForm;
        private Label label1;
    }
}