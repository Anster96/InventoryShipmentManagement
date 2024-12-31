namespace InventoryShipmentManagement
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            txtName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            dataGridInventory = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnCancel = new Button();
            btnExportToExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridInventory).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 26);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(12, 53);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 81);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(72, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // txtQuantity
            // 
            txtQuantity.Enabled = false;
            txtQuantity.Location = new Point(72, 50);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Enabled = false;
            txtPrice.Location = new Point(72, 78);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 130);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(188, 130);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(97, 130);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridInventory
            // 
            dataGridInventory.AllowUserToAddRows = false;
            dataGridInventory.AllowUserToDeleteRows = false;
            dataGridInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInventory.Location = new Point(27, 159);
            dataGridInventory.MultiSelect = false;
            dataGridInventory.Name = "dataGridInventory";
            dataGridInventory.ReadOnly = true;
            dataGridInventory.Size = new Size(748, 268);
            dataGridInventory.TabIndex = 9;
            dataGridInventory.SelectionChanged += dataGridInventory_SelectionChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(280, 130);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(188, 78);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(697, 26);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.Location = new Point(370, 130);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(111, 23);
            btnExportToExcel.TabIndex = 13;
            btnExportToExcel.Text = "Export to Excel";
            btnExportToExcel.UseVisualStyleBackColor = true;
            btnExportToExcel.Click += btnExportToExcel_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExportToExcel);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(dataGridInventory);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtName);
            Controls.Add(lblPrice);
            Controls.Add(lblQuantity);
            Controls.Add(lblName);
            Name = "MainForm";
            Text = "Inventory and Shipment Management";
            ((System.ComponentModel.ISupportInitialize)dataGridInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblQuantity;
        private Label lblPrice;
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnSave;
        private DataGridView dataGridInventory;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnCancel;
        private Button btnExportToExcel;
    }
}
