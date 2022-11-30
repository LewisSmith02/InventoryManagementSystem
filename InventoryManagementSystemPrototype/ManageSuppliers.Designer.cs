namespace InventoryManagementSystemPrototype
{
    partial class ManageSuppliers
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
            this.Tb_Supplier_Number = new System.Windows.Forms.TextBox();
            this.Lb_Categories_List = new System.Windows.Forms.Label();
            this.SuppliersGV = new System.Windows.Forms.DataGridView();
            this.Btn_Supplier_Delete = new System.Windows.Forms.Button();
            this.Btn_Supplier_Edit = new System.Windows.Forms.Button();
            this.Btn_Supplier_Add = new System.Windows.Forms.Button();
            this.Lbl_ManageCategs = new System.Windows.Forms.Label();
            this.Tb_Supplier_Name = new System.Windows.Forms.TextBox();
            this.Lbl_SupplierName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Tb_Supplier_Number
            // 
            this.Tb_Supplier_Number.Location = new System.Drawing.Point(17, 124);
            this.Tb_Supplier_Number.Name = "Tb_Supplier_Number";
            this.Tb_Supplier_Number.PlaceholderText = "SupplierNumber";
            this.Tb_Supplier_Number.Size = new System.Drawing.Size(149, 27);
            this.Tb_Supplier_Number.TabIndex = 30;
            // 
            // Lb_Categories_List
            // 
            this.Lb_Categories_List.AutoSize = true;
            this.Lb_Categories_List.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_Categories_List.Location = new System.Drawing.Point(209, 15);
            this.Lb_Categories_List.Name = "Lb_Categories_List";
            this.Lb_Categories_List.Size = new System.Drawing.Size(138, 28);
            this.Lb_Categories_List.TabIndex = 29;
            this.Lb_Categories_List.Text = "Suppliers List";
            // 
            // SuppliersGV
            // 
            this.SuppliersGV.AllowUserToAddRows = false;
            this.SuppliersGV.AllowUserToDeleteRows = false;
            this.SuppliersGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SuppliersGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SuppliersGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SuppliersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SuppliersGV.Location = new System.Drawing.Point(209, 46);
            this.SuppliersGV.MultiSelect = false;
            this.SuppliersGV.Name = "SuppliersGV";
            this.SuppliersGV.RowHeadersVisible = false;
            this.SuppliersGV.RowHeadersWidth = 51;
            this.SuppliersGV.RowTemplate.Height = 29;
            this.SuppliersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SuppliersGV.ShowEditingIcon = false;
            this.SuppliersGV.Size = new System.Drawing.Size(428, 221);
            this.SuppliersGV.TabIndex = 28;
            this.SuppliersGV.VirtualMode = true;
            this.SuppliersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SuppliersGV_CellContentClick);
            // 
            // Btn_Supplier_Delete
            // 
            this.Btn_Supplier_Delete.Location = new System.Drawing.Point(16, 238);
            this.Btn_Supplier_Delete.Name = "Btn_Supplier_Delete";
            this.Btn_Supplier_Delete.Size = new System.Drawing.Size(94, 29);
            this.Btn_Supplier_Delete.TabIndex = 26;
            this.Btn_Supplier_Delete.Text = "Delete";
            this.Btn_Supplier_Delete.UseVisualStyleBackColor = true;
            this.Btn_Supplier_Delete.Click += new System.EventHandler(this.Btn_Supplier_Delete_Click);
            // 
            // Btn_Supplier_Edit
            // 
            this.Btn_Supplier_Edit.Location = new System.Drawing.Point(17, 203);
            this.Btn_Supplier_Edit.Name = "Btn_Supplier_Edit";
            this.Btn_Supplier_Edit.Size = new System.Drawing.Size(94, 29);
            this.Btn_Supplier_Edit.TabIndex = 25;
            this.Btn_Supplier_Edit.Text = "Update";
            this.Btn_Supplier_Edit.UseVisualStyleBackColor = true;
            this.Btn_Supplier_Edit.Click += new System.EventHandler(this.Btn_Supplier_Edit_Click);
            // 
            // Btn_Supplier_Add
            // 
            this.Btn_Supplier_Add.Location = new System.Drawing.Point(17, 168);
            this.Btn_Supplier_Add.Name = "Btn_Supplier_Add";
            this.Btn_Supplier_Add.Size = new System.Drawing.Size(94, 29);
            this.Btn_Supplier_Add.TabIndex = 24;
            this.Btn_Supplier_Add.Text = "Add";
            this.Btn_Supplier_Add.UseVisualStyleBackColor = true;
            this.Btn_Supplier_Add.Click += new System.EventHandler(this.Btn_Supplier_Add_Click);
            // 
            // Lbl_ManageCategs
            // 
            this.Lbl_ManageCategs.AutoSize = true;
            this.Lbl_ManageCategs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ManageCategs.Location = new System.Drawing.Point(17, 9);
            this.Lbl_ManageCategs.Name = "Lbl_ManageCategs";
            this.Lbl_ManageCategs.Size = new System.Drawing.Size(181, 28);
            this.Lbl_ManageCategs.TabIndex = 23;
            this.Lbl_ManageCategs.Text = "Manage Suppliers";
            // 
            // Tb_Supplier_Name
            // 
            this.Tb_Supplier_Name.Location = new System.Drawing.Point(17, 70);
            this.Tb_Supplier_Name.Name = "Tb_Supplier_Name";
            this.Tb_Supplier_Name.PlaceholderText = "SupplierName";
            this.Tb_Supplier_Name.Size = new System.Drawing.Size(149, 27);
            this.Tb_Supplier_Name.TabIndex = 22;
            // 
            // Lbl_SupplierName
            // 
            this.Lbl_SupplierName.AutoSize = true;
            this.Lbl_SupplierName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lbl_SupplierName.Location = new System.Drawing.Point(17, 48);
            this.Lbl_SupplierName.Name = "Lbl_SupplierName";
            this.Lbl_SupplierName.Size = new System.Drawing.Size(93, 17);
            this.Lbl_SupplierName.TabIndex = 31;
            this.Lbl_SupplierName.Text = "Supplier Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Supplier Number:";
            // 
            // ManageSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_SupplierName);
            this.Controls.Add(this.Tb_Supplier_Number);
            this.Controls.Add(this.Lb_Categories_List);
            this.Controls.Add(this.SuppliersGV);
            this.Controls.Add(this.Btn_Supplier_Delete);
            this.Controls.Add(this.Btn_Supplier_Edit);
            this.Controls.Add(this.Btn_Supplier_Add);
            this.Controls.Add(this.Lbl_ManageCategs);
            this.Controls.Add(this.Tb_Supplier_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ManageSuppliers";
            this.Text = "ManageSuppliers";
            this.Load += new System.EventHandler(this.ManageSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Tb_Supplier_Number;
        private Label Lb_Categories_List;
        private DataGridView SuppliersGV;
        private Button Btn_Supplier_Delete;
        private Button Btn_Supplier_Edit;
        private Button Btn_Supplier_Add;
        private Label Lbl_ManageCategs;
        private TextBox Tb_Supplier_Name;
        private Label Lbl_SupplierName;
        private Label label1;
    }
}