namespace TareaADO
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
            ((System.ComponentModel.ISupportInitialize)dgvMakes).BeginInit();
            SuspendLayout();
            // 
            // dgvMakes
            // 
            dgvMakes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMakes.Location = new Point(28, 120);
            dgvMakes.Name = "dgvMakes";
            dgvMakes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMakes.Size = new Size(751, 301);
            dgvMakes.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(28, 43);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name :";
            // 
            // txtName
            // 
            txtName.Location = new Point(89, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(263, 23);
            txtName.TabIndex = 2;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(405, 41);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 3;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(536, 41);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(672, 42);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // MakesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(dgvMakes);
            Name = "MakesForm";
            Text = "MakesForm";
            ((System.ComponentModel.ISupportInitialize)dgvMakes).EndInit();
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
    }
}