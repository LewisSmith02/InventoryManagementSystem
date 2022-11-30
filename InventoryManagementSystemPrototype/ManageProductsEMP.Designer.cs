namespace InventoryManagementSystemPrototype
{
    partial class ManageProductsEMP
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
            this.Lbl_ManageUsers = new System.Windows.Forms.Label();
            this.Btn_Prod_Edit = new System.Windows.Forms.Button();
            this.ProductsGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Cat_Search = new System.Windows.Forms.Button();
            this.Btn_Cat_Refresh = new System.Windows.Forms.Button();
            this.Cb_Cat_Search = new System.Windows.Forms.ComboBox();
            this.Lbl_ProductQty = new System.Windows.Forms.Label();
            this.Tb_Prod_Id = new System.Windows.Forms.TextBox();
            this.Lb_ProductId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Tb_Prod_Qty
            // 
            this.Tb_Prod_Qty.Location = new System.Drawing.Point(12, 135);
            this.Tb_Prod_Qty.Name = "Tb_Prod_Qty";
            this.Tb_Prod_Qty.PlaceholderText = "ProductQty";
            this.Tb_Prod_Qty.Size = new System.Drawing.Size(149, 27);
            this.Tb_Prod_Qty.TabIndex = 23;
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
            // Btn_Prod_Edit
            // 
            this.Btn_Prod_Edit.Location = new System.Drawing.Point(177, 82);
            this.Btn_Prod_Edit.Name = "Btn_Prod_Edit";
            this.Btn_Prod_Edit.Size = new System.Drawing.Size(94, 29);
            this.Btn_Prod_Edit.TabIndex = 28;
            this.Btn_Prod_Edit.Text = "Update";
            this.Btn_Prod_Edit.UseVisualStyleBackColor = true;
            this.Btn_Prod_Edit.Click += new System.EventHandler(this.Btn_Prod_Edit_Click);
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
            // Lbl_ProductQty
            // 
            this.Lbl_ProductQty.AutoSize = true;
            this.Lbl_ProductQty.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ProductQty.Location = new System.Drawing.Point(12, 114);
            this.Lbl_ProductQty.Name = "Lbl_ProductQty";
            this.Lbl_ProductQty.Size = new System.Drawing.Size(106, 17);
            this.Lbl_ProductQty.TabIndex = 40;
            this.Lbl_ProductQty.Text = "Product Quantity:";
            // 
            // Tb_Prod_Id
            // 
            this.Tb_Prod_Id.Location = new System.Drawing.Point(12, 84);
            this.Tb_Prod_Id.Name = "Tb_Prod_Id";
            this.Tb_Prod_Id.PlaceholderText = "ProductId";
            this.Tb_Prod_Id.Size = new System.Drawing.Size(149, 27);
            this.Tb_Prod_Id.TabIndex = 41;
            // 
            // Lb_ProductId
            // 
            this.Lb_ProductId.AutoSize = true;
            this.Lb_ProductId.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lb_ProductId.Location = new System.Drawing.Point(12, 64);
            this.Lb_ProductId.Name = "Lb_ProductId";
            this.Lb_ProductId.Size = new System.Drawing.Size(70, 17);
            this.Lb_ProductId.TabIndex = 42;
            this.Lb_ProductId.Text = "Product ID:";
            // 
            // ManageProductsEMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 425);
            this.Controls.Add(this.Lb_ProductId);
            this.Controls.Add(this.Tb_Prod_Id);
            this.Controls.Add(this.Lbl_ProductQty);
            this.Controls.Add(this.Cb_Cat_Search);
            this.Controls.Add(this.Btn_Cat_Refresh);
            this.Controls.Add(this.Btn_Cat_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductsGV);
            this.Controls.Add(this.Btn_Prod_Edit);
            this.Controls.Add(this.Lbl_ManageUsers);
            this.Controls.Add(this.Tb_Prod_Qty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ManageProductsEMP";
            this.Text = "Products List";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Tb_Prod_Qty;
        private Label Lbl_ManageUsers;
        private Button Btn_Prod_Edit;
        private DataGridView ProductsGV;
        private Label label1;
        private Button Btn_Cat_Search;
        private Button Btn_Cat_Refresh;
        private ComboBox Cb_Cat_Search;
        private Label Lbl_ProductQty;
        private TextBox Tb_Prod_Id;
        private Label Lb_ProductId;
    }
}