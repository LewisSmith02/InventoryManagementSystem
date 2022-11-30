namespace InventoryManagementSystemPrototype
{
    partial class ManageCategories
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
            this.components = new System.ComponentModel.Container();
            this.Tb_Categ_Desc = new System.Windows.Forms.TextBox();
            this.Tb_Categ_Name = new System.Windows.Forms.TextBox();
            this.Lbl_ManageCategs = new System.Windows.Forms.Label();
            this.Btn_Categ_Add = new System.Windows.Forms.Button();
            this.Btn_Categ_Edit = new System.Windows.Forms.Button();
            this.Btn_Categ_Delete = new System.Windows.Forms.Button();
            this.manageCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Lb_Categories_List = new System.Windows.Forms.Label();
            this.Lbl_CategDesc = new System.Windows.Forms.Label();
            this.Lbl_CategName = new System.Windows.Forms.Label();
            this.Lb_ProductQtyLimit = new System.Windows.Forms.Label();
            this.Lb_ProductId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductOrderLimitGV = new System.Windows.Forms.DataGridView();
            this.Btn_ProdQtyLimitUpdate = new System.Windows.Forms.Button();
            this.Lb_ManageOrderLimit = new System.Windows.Forms.Label();
            this.Tb_ProdQtyLimit = new System.Windows.Forms.TextBox();
            this.Tb_ProductId = new System.Windows.Forms.TextBox();
            this.Lb_Prod_Name = new System.Windows.Forms.Label();
            this.Tb_Prod_Name = new System.Windows.Forms.TextBox();
            this.Lb_ProductReOrderQtyLimit = new System.Windows.Forms.Label();
            this.Tb_ProdReOrderQtyLimit = new System.Windows.Forms.TextBox();
            this.Btn_CategoryGV_Refresh = new System.Windows.Forms.Button();
            this.Btn_ProductOrderLimitGV_Refresh = new System.Windows.Forms.Button();
            this.CategoriesGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.manageCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductOrderLimitGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Tb_Categ_Desc
            // 
            this.Tb_Categ_Desc.Location = new System.Drawing.Point(12, 129);
            this.Tb_Categ_Desc.Name = "Tb_Categ_Desc";
            this.Tb_Categ_Desc.PlaceholderText = "CategoryDesc";
            this.Tb_Categ_Desc.Size = new System.Drawing.Size(149, 27);
            this.Tb_Categ_Desc.TabIndex = 0;
            // 
            // Tb_Categ_Name
            // 
            this.Tb_Categ_Name.Location = new System.Drawing.Point(12, 75);
            this.Tb_Categ_Name.Name = "Tb_Categ_Name";
            this.Tb_Categ_Name.PlaceholderText = "CategoryName";
            this.Tb_Categ_Name.Size = new System.Drawing.Size(149, 27);
            this.Tb_Categ_Name.TabIndex = 1;
            // 
            // Lbl_ManageCategs
            // 
            this.Lbl_ManageCategs.AutoSize = true;
            this.Lbl_ManageCategs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ManageCategs.Location = new System.Drawing.Point(12, 9);
            this.Lbl_ManageCategs.Name = "Lbl_ManageCategs";
            this.Lbl_ManageCategs.Size = new System.Drawing.Size(194, 28);
            this.Lbl_ManageCategs.TabIndex = 2;
            this.Lbl_ManageCategs.Text = "Manage Categories";
            // 
            // Btn_Categ_Add
            // 
            this.Btn_Categ_Add.Location = new System.Drawing.Point(12, 162);
            this.Btn_Categ_Add.Name = "Btn_Categ_Add";
            this.Btn_Categ_Add.Size = new System.Drawing.Size(94, 29);
            this.Btn_Categ_Add.TabIndex = 3;
            this.Btn_Categ_Add.Text = "Add";
            this.Btn_Categ_Add.UseVisualStyleBackColor = true;
            this.Btn_Categ_Add.Click += new System.EventHandler(this.Btn_Categ_Add_Click);
            // 
            // Btn_Categ_Edit
            // 
            this.Btn_Categ_Edit.Location = new System.Drawing.Point(12, 197);
            this.Btn_Categ_Edit.Name = "Btn_Categ_Edit";
            this.Btn_Categ_Edit.Size = new System.Drawing.Size(94, 29);
            this.Btn_Categ_Edit.TabIndex = 4;
            this.Btn_Categ_Edit.Text = "Update";
            this.Btn_Categ_Edit.UseVisualStyleBackColor = true;
            this.Btn_Categ_Edit.Click += new System.EventHandler(this.Btn_Categ_Edit_Click);
            // 
            // Btn_Categ_Delete
            // 
            this.Btn_Categ_Delete.Location = new System.Drawing.Point(12, 232);
            this.Btn_Categ_Delete.Name = "Btn_Categ_Delete";
            this.Btn_Categ_Delete.Size = new System.Drawing.Size(94, 29);
            this.Btn_Categ_Delete.TabIndex = 5;
            this.Btn_Categ_Delete.Text = "Delete";
            this.Btn_Categ_Delete.UseVisualStyleBackColor = true;
            this.Btn_Categ_Delete.Click += new System.EventHandler(this.Btn_Categ_Delete_Click);
            // 
            // manageCategoriesBindingSource
            // 
            this.manageCategoriesBindingSource.DataSource = typeof(InventoryManagementSystemPrototype.ManageCategories);
            // 
            // Lb_Categories_List
            // 
            this.Lb_Categories_List.AutoSize = true;
            this.Lb_Categories_List.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_Categories_List.Location = new System.Drawing.Point(223, 42);
            this.Lb_Categories_List.Name = "Lb_Categories_List";
            this.Lb_Categories_List.Size = new System.Drawing.Size(151, 28);
            this.Lb_Categories_List.TabIndex = 19;
            this.Lb_Categories_List.Text = "Categories List";
            // 
            // Lbl_CategDesc
            // 
            this.Lbl_CategDesc.AutoSize = true;
            this.Lbl_CategDesc.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lbl_CategDesc.Location = new System.Drawing.Point(12, 107);
            this.Lbl_CategDesc.Name = "Lbl_CategDesc";
            this.Lbl_CategDesc.Size = new System.Drawing.Size(91, 17);
            this.Lbl_CategDesc.TabIndex = 20;
            this.Lbl_CategDesc.Text = "Category Desc:";
            // 
            // Lbl_CategName
            // 
            this.Lbl_CategName.AutoSize = true;
            this.Lbl_CategName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lbl_CategName.Location = new System.Drawing.Point(12, 53);
            this.Lbl_CategName.Name = "Lbl_CategName";
            this.Lbl_CategName.Size = new System.Drawing.Size(99, 17);
            this.Lbl_CategName.TabIndex = 21;
            this.Lbl_CategName.Text = "Category Name:";
            // 
            // Lb_ProductQtyLimit
            // 
            this.Lb_ProductQtyLimit.AutoSize = true;
            this.Lb_ProductQtyLimit.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lb_ProductQtyLimit.Location = new System.Drawing.Point(12, 429);
            this.Lb_ProductQtyLimit.Name = "Lb_ProductQtyLimit";
            this.Lb_ProductQtyLimit.Size = new System.Drawing.Size(109, 17);
            this.Lb_ProductQtyLimit.TabIndex = 31;
            this.Lb_ProductQtyLimit.Text = "Product Qty Limit:";
            // 
            // Lb_ProductId
            // 
            this.Lb_ProductId.AutoSize = true;
            this.Lb_ProductId.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lb_ProductId.Location = new System.Drawing.Point(12, 325);
            this.Lb_ProductId.Name = "Lb_ProductId";
            this.Lb_ProductId.Size = new System.Drawing.Size(70, 17);
            this.Lb_ProductId.TabIndex = 30;
            this.Lb_ProductId.Text = "Product ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(223, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "Product List";
            // 
            // ProductOrderLimitGV
            // 
            this.ProductOrderLimitGV.AllowUserToAddRows = false;
            this.ProductOrderLimitGV.AllowUserToDeleteRows = false;
            this.ProductOrderLimitGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductOrderLimitGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductOrderLimitGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductOrderLimitGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductOrderLimitGV.Location = new System.Drawing.Point(223, 347);
            this.ProductOrderLimitGV.MultiSelect = false;
            this.ProductOrderLimitGV.Name = "ProductOrderLimitGV";
            this.ProductOrderLimitGV.RowHeadersVisible = false;
            this.ProductOrderLimitGV.RowHeadersWidth = 51;
            this.ProductOrderLimitGV.RowTemplate.Height = 29;
            this.ProductOrderLimitGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductOrderLimitGV.ShowEditingIcon = false;
            this.ProductOrderLimitGV.Size = new System.Drawing.Size(555, 176);
            this.ProductOrderLimitGV.TabIndex = 28;
            this.ProductOrderLimitGV.VirtualMode = true;
            this.ProductOrderLimitGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductOrderLimitGV_CellContentClick);
            // 
            // Btn_ProdQtyLimitUpdate
            // 
            this.Btn_ProdQtyLimitUpdate.Location = new System.Drawing.Point(10, 533);
            this.Btn_ProdQtyLimitUpdate.Name = "Btn_ProdQtyLimitUpdate";
            this.Btn_ProdQtyLimitUpdate.Size = new System.Drawing.Size(94, 29);
            this.Btn_ProdQtyLimitUpdate.TabIndex = 26;
            this.Btn_ProdQtyLimitUpdate.Text = "Update";
            this.Btn_ProdQtyLimitUpdate.UseVisualStyleBackColor = true;
            this.Btn_ProdQtyLimitUpdate.Click += new System.EventHandler(this.Btn_ProdQtyLimitUpdate_Click);
            // 
            // Lb_ManageOrderLimit
            // 
            this.Lb_ManageOrderLimit.AutoSize = true;
            this.Lb_ManageOrderLimit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_ManageOrderLimit.Location = new System.Drawing.Point(12, 281);
            this.Lb_ManageOrderLimit.Name = "Lb_ManageOrderLimit";
            this.Lb_ManageOrderLimit.Size = new System.Drawing.Size(202, 28);
            this.Lb_ManageOrderLimit.TabIndex = 24;
            this.Lb_ManageOrderLimit.Text = "Manage Order Limit";
            // 
            // Tb_ProdQtyLimit
            // 
            this.Tb_ProdQtyLimit.Location = new System.Drawing.Point(12, 450);
            this.Tb_ProdQtyLimit.Name = "Tb_ProdQtyLimit";
            this.Tb_ProdQtyLimit.PlaceholderText = "QuantityLimit";
            this.Tb_ProdQtyLimit.Size = new System.Drawing.Size(149, 27);
            this.Tb_ProdQtyLimit.TabIndex = 23;
            // 
            // Tb_ProductId
            // 
            this.Tb_ProductId.Location = new System.Drawing.Point(12, 346);
            this.Tb_ProductId.Name = "Tb_ProductId";
            this.Tb_ProductId.PlaceholderText = "ProductId";
            this.Tb_ProductId.Size = new System.Drawing.Size(149, 27);
            this.Tb_ProductId.TabIndex = 22;
            // 
            // Lb_Prod_Name
            // 
            this.Lb_Prod_Name.AutoSize = true;
            this.Lb_Prod_Name.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lb_Prod_Name.Location = new System.Drawing.Point(12, 377);
            this.Lb_Prod_Name.Name = "Lb_Prod_Name";
            this.Lb_Prod_Name.Size = new System.Drawing.Size(92, 17);
            this.Lb_Prod_Name.TabIndex = 33;
            this.Lb_Prod_Name.Text = "Product Name:";
            // 
            // Tb_Prod_Name
            // 
            this.Tb_Prod_Name.Location = new System.Drawing.Point(12, 398);
            this.Tb_Prod_Name.Name = "Tb_Prod_Name";
            this.Tb_Prod_Name.PlaceholderText = "ProductName";
            this.Tb_Prod_Name.Size = new System.Drawing.Size(149, 27);
            this.Tb_Prod_Name.TabIndex = 32;
            // 
            // Lb_ProductReOrderQtyLimit
            // 
            this.Lb_ProductReOrderQtyLimit.AutoSize = true;
            this.Lb_ProductReOrderQtyLimit.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lb_ProductReOrderQtyLimit.Location = new System.Drawing.Point(12, 481);
            this.Lb_ProductReOrderQtyLimit.Name = "Lb_ProductReOrderQtyLimit";
            this.Lb_ProductReOrderQtyLimit.Size = new System.Drawing.Size(141, 17);
            this.Lb_ProductReOrderQtyLimit.TabIndex = 35;
            this.Lb_ProductReOrderQtyLimit.Text = "Product Re-Order Limit:";
            // 
            // Tb_ProdReOrderQtyLimit
            // 
            this.Tb_ProdReOrderQtyLimit.Location = new System.Drawing.Point(12, 502);
            this.Tb_ProdReOrderQtyLimit.Name = "Tb_ProdReOrderQtyLimit";
            this.Tb_ProdReOrderQtyLimit.PlaceholderText = "ReOrderLimit";
            this.Tb_ProdReOrderQtyLimit.Size = new System.Drawing.Size(149, 27);
            this.Tb_ProdReOrderQtyLimit.TabIndex = 34;
            // 
            // Btn_CategoryGV_Refresh
            // 
            this.Btn_CategoryGV_Refresh.Location = new System.Drawing.Point(684, 40);
            this.Btn_CategoryGV_Refresh.Name = "Btn_CategoryGV_Refresh";
            this.Btn_CategoryGV_Refresh.Size = new System.Drawing.Size(94, 29);
            this.Btn_CategoryGV_Refresh.TabIndex = 37;
            this.Btn_CategoryGV_Refresh.Text = "Refresh";
            this.Btn_CategoryGV_Refresh.UseVisualStyleBackColor = true;
            this.Btn_CategoryGV_Refresh.Click += new System.EventHandler(this.Btn_CategoryGV_Refresh_Click);
            // 
            // Btn_ProductOrderLimitGV_Refresh
            // 
            this.Btn_ProductOrderLimitGV_Refresh.Location = new System.Drawing.Point(684, 312);
            this.Btn_ProductOrderLimitGV_Refresh.Name = "Btn_ProductOrderLimitGV_Refresh";
            this.Btn_ProductOrderLimitGV_Refresh.Size = new System.Drawing.Size(94, 29);
            this.Btn_ProductOrderLimitGV_Refresh.TabIndex = 38;
            this.Btn_ProductOrderLimitGV_Refresh.Text = "Refresh";
            this.Btn_ProductOrderLimitGV_Refresh.UseVisualStyleBackColor = true;
            // 
            // CategoriesGV
            // 
            this.CategoriesGV.AllowUserToAddRows = false;
            this.CategoriesGV.AllowUserToDeleteRows = false;
            this.CategoriesGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CategoriesGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CategoriesGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoriesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesGV.Location = new System.Drawing.Point(223, 75);
            this.CategoriesGV.MultiSelect = false;
            this.CategoriesGV.Name = "CategoriesGV";
            this.CategoriesGV.RowHeadersVisible = false;
            this.CategoriesGV.RowHeadersWidth = 51;
            this.CategoriesGV.RowTemplate.Height = 29;
            this.CategoriesGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoriesGV.ShowEditingIcon = false;
            this.CategoriesGV.Size = new System.Drawing.Size(555, 176);
            this.CategoriesGV.TabIndex = 39;
            this.CategoriesGV.VirtualMode = true;
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 606);
            this.Controls.Add(this.CategoriesGV);
            this.Controls.Add(this.Btn_ProductOrderLimitGV_Refresh);
            this.Controls.Add(this.Btn_CategoryGV_Refresh);
            this.Controls.Add(this.Lb_ProductReOrderQtyLimit);
            this.Controls.Add(this.Tb_ProdReOrderQtyLimit);
            this.Controls.Add(this.Lb_Prod_Name);
            this.Controls.Add(this.Tb_Prod_Name);
            this.Controls.Add(this.Lb_ProductQtyLimit);
            this.Controls.Add(this.Lb_ProductId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductOrderLimitGV);
            this.Controls.Add(this.Btn_ProdQtyLimitUpdate);
            this.Controls.Add(this.Lb_ManageOrderLimit);
            this.Controls.Add(this.Tb_ProdQtyLimit);
            this.Controls.Add(this.Tb_ProductId);
            this.Controls.Add(this.Lbl_CategName);
            this.Controls.Add(this.Lbl_CategDesc);
            this.Controls.Add(this.Lb_Categories_List);
            this.Controls.Add(this.Btn_Categ_Delete);
            this.Controls.Add(this.Btn_Categ_Edit);
            this.Controls.Add(this.Btn_Categ_Add);
            this.Controls.Add(this.Lbl_ManageCategs);
            this.Controls.Add(this.Tb_Categ_Name);
            this.Controls.Add(this.Tb_Categ_Desc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ManageCategories";
            this.Text = "ManageCategories&OrderLimit";
            this.Load += new System.EventHandler(this.ManageCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manageCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductOrderLimitGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Tb_Categ_Desc;
        private TextBox Tb_Categ_Name;
        private Label Lbl_ManageCategs;
        private Button Btn_Categ_Add;
        private Button Btn_Categ_Edit;
        private Button Btn_Categ_Delete;
        private BindingSource manageCategoriesBindingSource;
        private Label Lb_Categories_List;
        private Label Lbl_CategDesc;
        private Label Lbl_CategName;
        private Label Lb_ProductQtyLimit;
        private Label Lb_ProductId;
        private Label label3;
        private DataGridView ProductOrderLimitGV;
        private Button Btn_ProdQtyLimitUpdate;
        private Label Lb_ManageOrderLimit;
        private TextBox Tb_ProdQtyLimit;
        private TextBox Tb_ProductId;
        private Label Lb_Prod_Name;
        private TextBox Tb_Prod_Name;
        private Label Lb_ProductReOrderQtyLimit;
        private TextBox Tb_ProdReOrderQtyLimit;
        private Button Btn_CategoryGV_Refresh;
        private Button Btn_ProductOrderLimitGV_Refresh;
        private DataGridView CategoriesGV;
    }
}