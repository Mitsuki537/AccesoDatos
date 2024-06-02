namespace ADO.UI
{
    partial class InventoryForm
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
            dgvInventory = new DataGridView();
            lblPetName = new Label();
            lblColor = new Label();
            lblMakeId = new Label();
            txtPetName = new TextBox();
            txtColor = new TextBox();
            cmbMakes = new ComboBox();
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblSearch = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvInventory
            // 
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(33, 241);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(556, 186);
            dgvInventory.TabIndex = 0;
            // 
            // lblPetName
            // 
            lblPetName.AutoSize = true;
            lblPetName.Font = new Font("Segoe UI", 9.75F);
            lblPetName.Location = new Point(36, 99);
            lblPetName.Name = "lblPetName";
            lblPetName.Size = new Size(72, 17);
            lblPetName.TabIndex = 1;
            lblPetName.Text = "Pet Name :";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 9.75F);
            lblColor.Location = new Point(36, 144);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(47, 17);
            lblColor.TabIndex = 2;
            lblColor.Text = "Color :";
            // 
            // lblMakeId
            // 
            lblMakeId.AutoSize = true;
            lblMakeId.Font = new Font("Segoe UI", 9.75F);
            lblMakeId.Location = new Point(36, 190);
            lblMakeId.Name = "lblMakeId";
            lblMakeId.Size = new Size(52, 17);
            lblMakeId.TabIndex = 3;
            lblMakeId.Text = "Maker :";
            // 
            // txtPetName
            // 
            txtPetName.Font = new Font("Segoe UI", 9.75F);
            txtPetName.Location = new Point(116, 96);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(199, 25);
            txtPetName.TabIndex = 4;
            // 
            // txtColor
            // 
            txtColor.Font = new Font("Segoe UI", 9.75F);
            txtColor.Location = new Point(116, 136);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(199, 25);
            txtColor.TabIndex = 5;
            // 
            // cmbMakes
            // 
            cmbMakes.Font = new Font("Segoe UI", 9.75F);
            cmbMakes.FormattingEnabled = true;
            cmbMakes.Location = new Point(116, 182);
            cmbMakes.Name = "cmbMakes";
            cmbMakes.Size = new Size(199, 25);
            cmbMakes.TabIndex = 6;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 9.75F);
            btnNew.Location = new Point(337, 95);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 26);
            btnNew.TabIndex = 7;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9.75F);
            btnUpdate.Location = new Point(337, 136);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 26);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.75F);
            btnDelete.Location = new Point(337, 184);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 26);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.75F);
            lblSearch.Location = new Point(512, 99);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(80, 17);
            lblSearch.TabIndex = 10;
            lblSearch.Text = "Search by Id";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9.75F);
            btnSearch.Location = new Point(512, 169);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 26);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9.75F);
            txtSearch.Location = new Point(512, 128);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(75, 25);
            txtSearch.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(619, 66);
            panel1.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(258, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 1;
            label1.Text = "Inventory";
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 450);
            Controls.Add(panel1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(lblSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(cmbMakes);
            Controls.Add(txtColor);
            Controls.Add(txtPetName);
            Controls.Add(lblMakeId);
            Controls.Add(lblColor);
            Controls.Add(lblPetName);
            Controls.Add(dgvInventory);
            Name = "InventoryForm";
            Text = "Inventory";
            Load += InventoryForm_Load;
            Click += InventoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInventory;
        private Label lblPetName;
        private Label lblColor;
        private Label lblMakeId;
        private TextBox txtPetName;
        private TextBox txtColor;
        private ComboBox cmbMakes;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblSearch;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel1;
        private Label label1;
    }
}