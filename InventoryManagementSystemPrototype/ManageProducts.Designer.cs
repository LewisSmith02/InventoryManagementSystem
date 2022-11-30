namespace InventoryManagementSystemPrototype
{
    partial class ManageProducts
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
            this.Tb_Prod_Qty = new System.Windows.Forms.TextBox();
            this.Tb_Prod_Name = new System.Windows.Forms.TextBox();
            this.Tb_Prod_Id = new System.Windows.Forms.TextBox();
            this.Tb_Prod_Desc = new System.Windows.Forms.TextBox();
            this.Tb_Prod_Price = new System.Windows.Forms.TextBox();
            this.Lbl_ManageUsers = new System.Windows.Forms.Label();
            this.Btn_Prod_Delete = new System.Windows.Forms.Button();
            this.Btn_Prod_Edit = new System.Windows.Forms.Button();
            this.Btn_Prod_Add = new System.Windows.Forms.Button();
            this.Cb_Prod_Categ = new System.Windows.Forms.ComboBox();
            this.ProductsGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Cat_Search = new System.Windows.Forms.Button();
            this.Btn_Cat_Refresh = new System.Windows.Forms.Button();
            this.Cb_Cat_Search = new System.Windows.Forms.ComboBox();
            this.Lbl_ProductID = new System.Windows.Forms.Label();
            this.Lbl_ProdName = new System.Windows.Forms.Label();
            this.Lbl_ProductQty = new System.Windows.Forms.Label();
            this.Lbl_ProductPrice = new System.Windows.Forms.Label();
            this.Lbl_ProductDesc = new System.Windows.Forms.Label();
            this.Lbl_ProductCateg = new System.Windows.Forms.Label();
            this.Lb_Prod_Supplier = new System.Windows.Forms.Label();
            this.Cb_Prod_Supplier = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Tb_Prod_Qty
            // 
            this.Tb_Prod_Qty.Location = new System.Drawing.Point(12, 176);
            this.Tb_Prod_Qty.Name = "Tb_Prod_Qty";
            this.Tb_Prod_Qty.PlaceholderText = "ProductQty";
            this.Tb_Prod_Qty.Size = new System.Drawing.Size(149, 27);
            this.Tb_Prod_Qty.TabIndex = 23;
            // 
            // Tb_Prod_Name
            // 
            this.Tb_Prod_Name.Location = new System.Drawing.Point(12, 124);
            this.Tb_Prod_Name.Name = "Tb_Prod_Name";
            this.Tb_Prod_Name.PlaceholderText = "ProductName";
            this.Tb_Prod_Name.Size = new System.Drawing.Size(149, 27);
            this.Tb_Prod_Name.TabIndex = 22;
            // 
            // Tb_Prod_Id
            // 
            this.Tb_Prod_Id.Location = new System.Drawing.Point(12, 72);
            this.Tb_Prod_Id.Name = "Tb_Prod_Id";
            this.Tb_Prod_Id.PlaceholderText = "ProductId";
            this.Tb_Prod_Id.Size = new System.Drawing.Size(149, 27);
            this.Tb_Prod_Id.TabIndex = 21;
            // 
            // Tb_Prod_Desc
            // 
            this.Tb_Prod_Desc.Location = new System.Drawing.Point(12, 280);
            this.Tb_Prod_Desc.Name = "Tb_Prod_Desc";
            this.Tb_Prod_Desc.PlaceholderText = "ProductDescription";
            this.Tb_Prod_Desc.Size = new System.Drawing.Size(149, 27);
            this.Tb_Prod_Desc.TabIndex = 25;
            // 
            // Tb_Prod_Price
            // 
            this.Tb_Prod_Price.Location = new System.Drawing.Point(12, 228);
            this.Tb_Prod_Price.Name = "Tb_Prod_Price";
            this.Tb_Prod_Price.PlaceholderText = "ProductPrice";
            this.Tb_Prod_Price.Size = new System.Drawing.Size(149, 27);
            this.Tb_Prod_Price.TabIndex = 24;
            // 
            // Lbl_ManageUsers
            // 
            this.Lbl_ManageUsers.AutoSize = true;
            this.Lbl_ManageUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ManageUsers.Location = new System.Drawing.Point(12, 9);
            this.Lbl_ManageUsers.Name = "Lbl_ManageUsers";
            this.Lbl_ManageUsers.Size = new System.Drawing.Size(177, 28);
            this.Lbl_ManageUsers.TabIndex = 26;
            this.Lbl_ManageUsers.Text = "Manage Products";
            // 
            // Btn_Prod_Delete
            // 
            this.Btn_Prod_Delete.Location = new System.Drawing.Point(181, 174);
            this.Btn_Prod_Delete.Name = "Btn_Prod_Delete";
            this.Btn_Prod_Delete.Size = new System.Drawing.Size(94, 29);
            this.Btn_Prod_Delete.TabIndex = 29;
            this.Btn_Prod_Delete.Text = "Delete";
            this.Btn_Prod_Delete.UseVisualStyleBackColor = true;
            this.Btn_Prod_Delete.Click += new System.EventHandler(this.Btn_Prod_Delete_Click);
            // 
            // Btn_Prod_Edit
            // 
            this.Btn_Prod_Edit.Location = new System.Drawing.Point(181, 122);
            this.Btn_Prod_Edit.Name = "Btn_Prod_Edit";
            this.Btn_Prod_Edit.Size = new System.Drawing.Size(94, 29);
            this.Btn_Prod_Edit.TabIndex = 28;
            this.Btn_Prod_Edit.Text = "Update";
            this.Btn_Prod_Edit.UseVisualStyleBackColor = true;
            this.Btn_Prod_Edit.Click += new System.EventHandler(this.Btn_Prod_Edit_Click);
            // 
            // Btn_Prod_Add
            // 
            this.Btn_Prod_Add.Location = new System.Drawing.Point(181, 71);
            this.Btn_Prod_Add.Name = "Btn_Prod_Add";
            this.Btn_Prod_Add.Size = new System.Drawing.Size(94, 29);
            this.Btn_Prod_Add.TabIndex = 27;
            this.Btn_Prod_Add.Text = "Add";
            this.Btn_Prod_Add.UseVisualStyleBackColor = true;
            this.Btn_Prod_Add.Click += new System.EventHandler(this.Btn_Product_Add_Click);
            // 
            // Cb_Prod_Categ
            // 
            this.Cb_Prod_Categ.FormattingEnabled = true;
            this.Cb_Prod_Categ.Location = new System.Drawing.Point(12, 332);
            this.Cb_Prod_Categ.Name = "Cb_Prod_Categ";
            this.Cb_Prod_Categ.Size = new System.Drawing.Size(151, 28);
            this.Cb_Prod_Categ.TabIndex = 31;
            this.Cb_Prod_Categ.Text = "Product Category";
            // 
            // ProductsGV
            // 
            this.ProductsGV.AllowUserToAddRows = false;
            this.ProductsGV.AllowUserToDeleteRows = false;
            this.ProductsGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductsGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductsGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGV.Location = new System.Drawing.Point(301, 71);
            this.ProductsGV.MultiSelect = false;
            this.ProductsGV.Name = "ProductsGV";
            this.ProductsGV.RowHeadersVisible = false;
            this.ProductsGV.RowHeadersWidth = 51;
            this.ProductsGV.RowTemplate.Height = 29;
            this.ProductsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsGV.ShowEditingIcon = false;
            this.ProductsGV.Size = new System.Drawing.Size(857, 319);
            this.ProductsGV.TabIndex = 32;
            this.ProductsGV.VirtualMode = true;
            this.ProductsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(301, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 33;
            this.label1.Text = "Products List";
            // 
            // Btn_Cat_Search
            // 
            this.Btn_Cat_Search.Location = new System.Drawing.Point(964, 36);
            this.Btn_Cat_Search.Name = "Btn_Cat_Search";
            this.Btn_Cat_Search.Size = new System.Drawing.Size(94, 28);
            this.Btn_Cat_Search.TabIndex = 35;
            this.Btn_Cat_Search.Text = "Search";
            this.Btn_Cat_Search.UseVisualStyleBackColor = true;
            this.Btn_Cat_Search.Click += new System.EventHandler(this.Btn_Cat_Search_Click);
            // 
            // Btn_Cat_Refresh
            // 
            this.Btn_Cat_Refresh.Location = new System.Drawing.Point(1064, 36);
            this.Btn_Cat_Refresh.Name = "Btn_Cat_Refresh";
            this.Btn_Cat_Refresh.Size = new System.Drawing.Size(94, 28);
            this.Btn_Cat_Refresh.TabIndex = 36;
            this.Btn_Cat_Refresh.Text = "Refresh";
            this.Btn_Cat_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Cat_Refresh.Click += new System.EventHandler(this.Btn_Cat_Refresh_Click);
            // 
            // Cb_Cat_Search
            // 
            this.Cb_Cat_Search.FormattingEnabled = true;
            this.Cb_Cat_Search.Location = new System.Drawing.Point(807, 36);
            this.Cb_Cat_Search.Name = "Cb_Cat_Search";
            this.Cb_Cat_Search.Size = new System.Drawing.Size(151, 28);
            this.Cb_Cat_Search.TabIndex = 37;
            this.Cb_Cat_Search.Text = "Product Category";
            // 
            // Lbl_ProductID
            // 
            this.Lbl_ProductID.AutoSize = true;
            this.Lbl_ProductID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ProductID.Location = new System.Drawing.Point(12, 51);
            this.Lbl_ProductID.Name = "Lbl_ProductID";
            this.Lbl_ProductID.Size = new System.Drawing.Size(70, 17);
            this.Lbl_ProductID.TabIndex = 38;
            this.Lbl_ProductID.Text = "Product ID:";
            // 
            // Lbl_ProdName
            // 
            this.Lbl_ProdName.AutoSize = true;
            this.Lbl_ProdName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ProdName.Location = new System.Drawing.Point(12, 103);
            this.Lbl_ProdName.Name = "Lbl_ProdName";
            this.Lbl_ProdName.Size = new System.Drawing.Size(92, 17);
            this.Lbl_ProdName.TabIndex = 39;
            this.Lbl_ProdName.Text = "Product Name:";
            // 
            // Lbl_ProductQty
            // 
            this.Lbl_ProductQty.AutoSize = true;
            this.Lbl_ProductQty.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ProductQty.Location = new System.Drawing.Point(12, 155);
            this.Lbl_ProductQty.Name = "Lbl_ProductQty";
            this.Lbl_ProductQty.Size = new System.Drawing.Size(106, 17);
            this.Lbl_ProductQty.TabIndex = 40;
            this.Lbl_ProductQty.Text = "Product Quantity:";
            // 
            // Lbl_ProductPrice
            // 
            this.Lbl_ProductPrice.AutoSize = true;
            this.Lbl_ProductPrice.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ProductPrice.Location = new System.Drawing.Point(12, 207);
            this.Lbl_ProductPrice.Name = "Lbl_ProductPrice";
            this.Lbl_ProductPrice.Size = new System.Drawing.Size(85, 17);
            this.Lbl_ProductPrice.TabIndex = 41;
            this.Lbl_ProductPrice.Text = "Product Price:";
            // 
            // Lbl_ProductDesc
            // 
            this.Lbl_ProductDesc.AutoSize = true;
            this.Lbl_ProductDesc.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ProductDesc.Location = new System.Drawing.Point(12, 259);
            this.Lbl_ProductDesc.Name = "Lbl_ProductDesc";
            this.Lbl_ProductDesc.Size = new System.Drawing.Size(120, 17);
            this.Lbl_ProductDesc.TabIndex = 42;
            this.Lbl_ProductDesc.Text = "Product Description:";
            // 
            // Lbl_ProductCateg
            // 
            this.Lbl_ProductCateg.AutoSize = true;
            this.Lbl_ProductCateg.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ProductCateg.Location = new System.Drawing.Point(12, 311);
            this.Lbl_ProductCateg.Name = "Lbl_ProductCateg";
            this.Lbl_ProductCateg.Size = new System.Drawing.Size(108, 17);
            this.Lbl_ProductCateg.TabIndex = 43;
            this.Lbl_ProductCateg.Text = "Product Category:";
            // 
            // Lb_Prod_Supplier
            // 
            this.Lb_Prod_Supplier.AutoSize = true;
            this.Lb_Prod_Supplier.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lb_Prod_Supplier.Location = new System.Drawing.Point(14, 364);
            this.Lb_Prod_Supplier.Name = "Lb_Prod_Supplier";
            this.Lb_Prod_Supplier.Size = new System.Drawing.Size(102, 17);
            this.Lb_Prod_Supplier.TabIndex = 45;
            this.Lb_Prod_Supplier.Tag = "";
            this.Lb_Prod_Supplier.Text = "Product Supplier:";
            // 
            // Cb_Prod_Supplier
            // 
            this.Cb_Prod_Supplier.FormattingEnabled = true;
            this.Cb_Prod_Supplier.Location = new System.Drawing.Point(14, 384);
            this.Cb_Prod_Supplier.Name = "Cb_Prod_Supplier";
            this.Cb_Prod_Supplier.Size = new System.Drawing.Size(151, 28);
            this.Cb_Prod_Supplier.TabIndex = 46;
            this.Cb_Prod_Supplier.Text = "Product Supplier";
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 445);
            this.Controls.Add(this.Cb_Prod_Supplier);
            this.Controls.Add(this.Lb_Prod_Supplier);
            this.Controls.Add(this.Lbl_ProductCateg);
            this.Controls.Add(this.Lbl_ProductDesc);
            this.Controls.Add(this.Lbl_ProductPrice);
            this.Controls.Add(this.Lbl_ProductQty);
            this.Controls.Add(this.Lbl_ProdName);
            this.Controls.Add(this.Lbl_ProductID);
            this.Controls.Add(this.Cb_Cat_Search);
            this.Controls.Add(this.Btn_Cat_Refresh);
            this.Controls.Add(this.Btn_Cat_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductsGV);
            this.Controls.Add(this.Cb_Prod_Categ);
            this.Controls.Add(this.Btn_Prod_Delete);
            this.Controls.Add(this.Btn_Prod_Edit);
            this.Controls.Add(this.Btn_Prod_Add);
            this.Controls.Add(this.Lbl_ManageUsers);
            this.Controls.Add(this.Tb_Prod_Desc);
            this.Controls.Add(this.Tb_Prod_Price);
            this.Controls.Add(this.Tb_Prod_Qty);
            this.Controls.Add(this.Tb_Prod_Name);
            this.Controls.Add(this.Tb_Prod_Id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ManageProducts";
            this.Text = "Products List";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Tb_Prod_Qty;
        private TextBox Tb_Prod_Name;
        private TextBox Tb_Prod_Id;
        private TextBox Tb_Prod_Desc;
        private TextBox Tb_Prod_Price;
        private Label Lbl_ManageUsers;
        private Button Btn_Prod_Delete;
        private Button Btn_Prod_Edit;
        private Button Btn_Prod_Add;
        private ComboBox Cb_Prod_Categ;
        private DataGridView ProductsGV;
        private Label label1;
        private Button Btn_Cat_Search;
        private Button Btn_Cat_Refresh;
        private ComboBox Cb_Cat_Search;
        private Label Lbl_ProductID;
        private Label Lbl_ProdName;
        private Label Lbl_ProductQty;
        private Label Lbl_ProductPrice;
        private Label Lbl_ProductDesc;
        private Label Lbl_ProductCateg;
        private Label Lb_Prod_Supplier;
        private ComboBox Cb_Prod_Supplier;
    }
}