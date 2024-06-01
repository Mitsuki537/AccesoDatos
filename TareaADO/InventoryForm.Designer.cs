namespace TareaADO
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
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(39, 199);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(549, 223);
            dgvInventory.TabIndex = 0;
            // 
            // lblPetName
            // 
            lblPetName.AutoSize = true;
            lblPetName.Location = new Point(39, 25);
            lblPetName.Name = "lblPetName";
            lblPetName.Size = new Size(65, 15);
            lblPetName.TabIndex = 1;
            lblPetName.Text = "Pet Name :";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(39, 70);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(42, 15);
            lblColor.TabIndex = 2;
            lblColor.Text = "Color :";
            // 
            // lblMakeId
            // 
            lblMakeId.AutoSize = true;
            lblMakeId.Location = new Point(39, 116);
            lblMakeId.Name = "lblMakeId";
            lblMakeId.Size = new Size(46, 15);
            lblMakeId.TabIndex = 3;
            lblMakeId.Text = "Maker :";
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(119, 22);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(171, 23);
            txtPetName.TabIndex = 4;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(119, 62);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(171, 23);
            txtColor.TabIndex = 5;
            // 
            // cmbMakes
            // 
            cmbMakes.FormattingEnabled = true;
            cmbMakes.Location = new Point(119, 108);
            cmbMakes.Name = "cmbMakes";
            cmbMakes.Size = new Size(171, 23);
            cmbMakes.TabIndex = 6;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(340, 21);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 7;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(340, 62);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(340, 107);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(476, 23);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(71, 15);
            lblSearch.TabIndex = 10;
            lblSearch.Text = "Search by Id";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(476, 93);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 37);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(476, 52);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(75, 23);
            txtSearch.TabIndex = 12;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 450);
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
            Text = "InventoryForm";
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
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
    }
}