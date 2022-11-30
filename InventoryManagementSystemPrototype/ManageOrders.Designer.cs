namespace InventoryManagementSystemPrototype
{
    partial class ManageOrders
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
            this.Lb_Categories_List = new System.Windows.Forms.Label();
            this.SuppliersGV = new System.Windows.Forms.DataGridView();
            this.Tb_Product_Id = new System.Windows.Forms.TextBox();
            this.Dtp_Orders = new System.Windows.Forms.DateTimePicker();
            this.Lb_OrderDate = new System.Windows.Forms.Label();
            this.Cb_Cat_Search = new System.Windows.Forms.ComboBox();
            this.ProductsGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Quantity_Id = new System.Windows.Forms.TextBox();
            this.Btn_Order_Add = new System.Windows.Forms.Button();
            this.Tb_Supplier_Name = new System.Windows.Forms.TextBox();
            this.OrdersGV = new System.Windows.Forms.DataGridView();
            this.Tb_Product_Name = new System.Windows.Forms.TextBox();
            this.Tb_Product_Qty = new System.Windows.Forms.TextBox();
            this.Tb_Product_Price = new System.Windows.Forms.TextBox();
            this.Tb_Product_Categ = new System.Windows.Forms.TextBox();
            this.Tb_Product_Desc = new System.Windows.Forms.TextBox();
            this.Lb_Supplier_Name = new System.Windows.Forms.Label();
            this.Lb_Prod_Id = new System.Windows.Forms.Label();
            this.Lb_Prod_Name = new System.Windows.Forms.Label();
            this.Lb_Prod_Qty = new System.Windows.Forms.Label();
            this.Lb_Prod_Price = new System.Windows.Forms.Label();
            this.Lb_Prod_Categ = new System.Windows.Forms.Label();
            this.Lb_Prod_Desc = new System.Windows.Forms.Label();
            this.Lb_Selected_OrderData = new System.Windows.Forms.Label();
            this.Lb_Prod_List = new System.Windows.Forms.Label();
            this.Lb_Orders_List = new System.Windows.Forms.Label();
            this.Lb_TotalAmount_Text = new System.Windows.Forms.Label();
            this.Lb_TotalAmount = new System.Windows.Forms.Label();
            this.Btn_Insert_Orders = new System.Windows.Forms.Button();
            this.Btn_View_Orders = new System.Windows.Forms.Button();
            this.Tb_Order_Id = new System.Windows.Forms.TextBox();
            this.Lb_Order_Id = new System.Windows.Forms.Label();
            this.OrdersHistoryGV = new System.Windows.Forms.DataGridView();
            this.ReOrderProductsGV = new System.Windows.Forms.DataGridView();
            this.Lb_ReOrderProducts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersHistoryGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReOrderProductsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_Categories_List
            // 
            this.Lb_Categories_List.AutoSize = true;
            this.Lb_Categories_List.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_Categories_List.Location = new System.Drawing.Point(12, 16);
            this.Lb_Categories_List.Name = "Lb_Categories_List";
            this.Lb_Categories_List.Size = new System.Drawing.Size(138, 28);
            this.Lb_Categories_List.TabIndex = 31;
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
            this.SuppliersGV.Location = new System.Drawing.Point(14, 47);
            this.SuppliersGV.MultiSelect = false;
            this.SuppliersGV.Name = "SuppliersGV";
            this.SuppliersGV.RowHeadersVisible = false;
            this.SuppliersGV.RowHeadersWidth = 51;
            this.SuppliersGV.RowTemplate.Height = 29;
            this.SuppliersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SuppliersGV.ShowEditingIcon = false;
            this.SuppliersGV.Size = new System.Drawing.Size(233, 221);
            this.SuppliersGV.TabIndex = 30;
            this.SuppliersGV.VirtualMode = true;
            this.SuppliersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SuppliersGV_CellContentClick);
            // 
            // Tb_Product_Id
            // 
            this.Tb_Product_Id.Location = new System.Drawing.Point(12, 460);
            this.Tb_Product_Id.Name = "Tb_Product_Id";
            this.Tb_Product_Id.PlaceholderText = "ProductId";
            this.Tb_Product_Id.Size = new System.Drawing.Size(189, 27);
            this.Tb_Product_Id.TabIndex = 32;
            // 
            // Dtp_Orders
            // 
            this.Dtp_Orders.Location = new System.Drawing.Point(14, 315);
            this.Dtp_Orders.Name = "Dtp_Orders";
            this.Dtp_Orders.Size = new System.Drawing.Size(250, 27);
            this.Dtp_Orders.TabIndex = 34;
            // 
            // Lb_OrderDate
            // 
            this.Lb_OrderDate.AutoSize = true;
            this.Lb_OrderDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_OrderDate.Location = new System.Drawing.Point(10, 289);
            this.Lb_OrderDate.Name = "Lb_OrderDate";
            this.Lb_OrderDate.Size = new System.Drawing.Size(99, 23);
            this.Lb_OrderDate.TabIndex = 35;
            this.Lb_OrderDate.Text = "Order Date:";
            // 
            // Cb_Cat_Search
            // 
            this.Cb_Cat_Search.FormattingEnabled = true;
            this.Cb_Cat_Search.Location = new System.Drawing.Point(1032, 16);
            this.Cb_Cat_Search.Name = "Cb_Cat_Search";
            this.Cb_Cat_Search.Size = new System.Drawing.Size(157, 28);
            this.Cb_Cat_Search.TabIndex = 39;
            this.Cb_Cat_Search.Text = "Product Category";
            this.Cb_Cat_Search.SelectionChangeCommitted += new System.EventHandler(this.Cb_Cat_Search_SelectionChangeCommitted);
            // 
            // ProductsGV
            // 
            this.ProductsGV.AllowUserToAddRows = false;
            this.ProductsGV.AllowUserToDeleteRows = false;
            this.ProductsGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductsGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductsGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ProductsGV.Location = new System.Drawing.Point(290, 47);
            this.ProductsGV.MultiSelect = false;
            this.ProductsGV.Name = "ProductsGV";
            this.ProductsGV.RowHeadersVisible = false;
            this.ProductsGV.RowHeadersWidth = 51;
            this.ProductsGV.RowTemplate.Height = 29;
            this.ProductsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsGV.ShowEditingIcon = false;
            this.ProductsGV.Size = new System.Drawing.Size(899, 221);
            this.ProductsGV.TabIndex = 38;
            this.ProductsGV.VirtualMode = true;
            this.ProductsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(564, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Quantity:";
            // 
            // Tb_Quantity_Id
            // 
            this.Tb_Quantity_Id.Location = new System.Drawing.Point(640, 314);
            this.Tb_Quantity_Id.Name = "Tb_Quantity_Id";
            this.Tb_Quantity_Id.Size = new System.Drawing.Size(189, 27);
            this.Tb_Quantity_Id.TabIndex = 41;
            // 
            // Btn_Order_Add
            // 
            this.Btn_Order_Add.Location = new System.Drawing.Point(835, 312);
            this.Btn_Order_Add.Name = "Btn_Order_Add";
            this.Btn_Order_Add.Size = new System.Drawing.Size(114, 31);
            this.Btn_Order_Add.TabIndex = 42;
            this.Btn_Order_Add.Text = "Add to Order";
            this.Btn_Order_Add.UseVisualStyleBackColor = true;
            this.Btn_Order_Add.Click += new System.EventHandler(this.Btn_Order_Add_Click);
            // 
            // Tb_Supplier_Name
            // 
            this.Tb_Supplier_Name.Location = new System.Drawing.Point(10, 760);
            this.Tb_Supplier_Name.Name = "Tb_Supplier_Name";
            this.Tb_Supplier_Name.PlaceholderText = "SupplierName";
            this.Tb_Supplier_Name.Size = new System.Drawing.Size(189, 27);
            this.Tb_Supplier_Name.TabIndex = 43;
            // 
            // OrdersGV
            // 
            this.OrdersGV.AllowUserToAddRows = false;
            this.OrdersGV.AllowUserToDeleteRows = false;
            this.OrdersGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrdersGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrdersGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrdersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGV.Location = new System.Drawing.Point(290, 346);
            this.OrdersGV.MultiSelect = false;
            this.OrdersGV.Name = "OrdersGV";
            this.OrdersGV.RowHeadersVisible = false;
            this.OrdersGV.RowHeadersWidth = 51;
            this.OrdersGV.RowTemplate.Height = 29;
            this.OrdersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersGV.ShowEditingIcon = false;
            this.OrdersGV.Size = new System.Drawing.Size(899, 241);
            this.OrdersGV.TabIndex = 44;
            // 
            // Tb_Product_Name
            // 
            this.Tb_Product_Name.Location = new System.Drawing.Point(10, 510);
            this.Tb_Product_Name.Name = "Tb_Product_Name";
            this.Tb_Product_Name.PlaceholderText = "ProductName";
            this.Tb_Product_Name.Size = new System.Drawing.Size(189, 27);
            this.Tb_Product_Name.TabIndex = 46;
            // 
            // Tb_Product_Qty
            // 
            this.Tb_Product_Qty.Location = new System.Drawing.Point(10, 560);
            this.Tb_Product_Qty.Name = "Tb_Product_Qty";
            this.Tb_Product_Qty.PlaceholderText = "ProductQuantity";
            this.Tb_Product_Qty.Size = new System.Drawing.Size(189, 27);
            this.Tb_Product_Qty.TabIndex = 47;
            // 
            // Tb_Product_Price
            // 
            this.Tb_Product_Price.Location = new System.Drawing.Point(13, 610);
            this.Tb_Product_Price.Name = "Tb_Product_Price";
            this.Tb_Product_Price.PlaceholderText = "ProductPrice";
            this.Tb_Product_Price.Size = new System.Drawing.Size(189, 27);
            this.Tb_Product_Price.TabIndex = 48;
            // 
            // Tb_Product_Categ
            // 
            this.Tb_Product_Categ.Location = new System.Drawing.Point(10, 710);
            this.Tb_Product_Categ.Name = "Tb_Product_Categ";
            this.Tb_Product_Categ.PlaceholderText = "ProductCategory";
            this.Tb_Product_Categ.Size = new System.Drawing.Size(189, 27);
            this.Tb_Product_Categ.TabIndex = 50;
            // 
            // Tb_Product_Desc
            // 
            this.Tb_Product_Desc.Location = new System.Drawing.Point(13, 660);
            this.Tb_Product_Desc.Name = "Tb_Product_Desc";
            this.Tb_Product_Desc.PlaceholderText = "ProductDesc";
            this.Tb_Product_Desc.Size = new System.Drawing.Size(189, 27);
            this.Tb_Product_Desc.TabIndex = 49;
            // 
            // Lb_Supplier_Name
            // 
            this.Lb_Supplier_Name.AutoSize = true;
            this.Lb_Supplier_Name.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lb_Supplier_Name.Location = new System.Drawing.Point(10, 740);
            this.Lb_Supplier_Name.Name = "Lb_Supplier_Name";
            this.Lb_Supplier_Name.Size = new System.Drawing.Size(89, 17);
            this.Lb_Supplier_Name.TabIndex = 52;
            this.Lb_Supplier_Name.Text = "SupplierName:";
            // 
            // Lb_Prod_Id
            // 
            this.Lb_Prod_Id.AutoSize = true;
            this.Lb_Prod_Id.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lb_Prod_Id.Location = new System.Drawing.Point(13, 440);
            this.Lb_Prod_Id.Name = "Lb_Prod_Id";
            this.Lb_Prod_Id.Size = new System.Drawing.Size(64, 17);
            this.Lb_Prod_Id.TabIndex = 53;
            this.Lb_Prod_Id.Text = "ProductId:";
            // 
            // Lb_Prod_Name
            // 
            this.Lb_Prod_Name.AutoSize = true;
            this.Lb_Prod_Name.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lb_Prod_Name.Location = new System.Drawing.Point(10, 490);
            this.Lb_Prod_Name.Name = "Lb_Prod_Name";
            this.Lb_Prod_Name.Size = new System.Drawing.Size(88, 17);
            this.Lb_Prod_Name.TabIndex = 54;
            this.Lb_Prod_Name.Text = "ProductName:";
            // 
            // Lb_Prod_Qty
            // 
            this.Lb_Prod_Qty.AutoSize = true;
            this.Lb_Prod_Qty.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lb_Prod_Qty.Location = new System.Drawing.Point(11, 540);
            this.Lb_Prod_Qty.Name = "Lb_Prod_Qty";
            this.Lb_Prod_Qty.Size = new System.Drawing.Size(102, 17);
            this.Lb_Prod_Qty.TabIndex = 55;
            this.Lb_Prod_Qty.Text = "ProductQuantity:";
            // 
            // Lb_Prod_Price
            // 
            this.Lb_Prod_Price.AutoSize = true;
            this.Lb_Prod_Price.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lb_Prod_Price.Location = new System.Drawing.Point(14, 590);
            this.Lb_Prod_Price.Name = "Lb_Prod_Price";
            this.Lb_Prod_Price.Size = new System.Drawing.Size(81, 17);
            this.Lb_Prod_Price.TabIndex = 56;
            this.Lb_Prod_Price.Text = "ProductPrice:";
            // 
            // Lb_Prod_Categ
            // 
            this.Lb_Prod_Categ.AutoSize = true;
            this.Lb_Prod_Categ.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lb_Prod_Categ.Location = new System.Drawing.Point(10, 690);
            this.Lb_Prod_Categ.Name = "Lb_Prod_Categ";
            this.Lb_Prod_Categ.Size = new System.Drawing.Size(104, 17);
            this.Lb_Prod_Categ.TabIndex = 57;
            this.Lb_Prod_Categ.Text = "ProductCategory:";
            // 
            // Lb_Prod_Desc
            // 
            this.Lb_Prod_Desc.AutoSize = true;
            this.Lb_Prod_Desc.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lb_Prod_Desc.Location = new System.Drawing.Point(12, 640);
            this.Lb_Prod_Desc.Name = "Lb_Prod_Desc";
            this.Lb_Prod_Desc.Size = new System.Drawing.Size(80, 17);
            this.Lb_Prod_Desc.TabIndex = 58;
            this.Lb_Prod_Desc.Text = "ProductDesc:";
            // 
            // Lb_Selected_OrderData
            // 
            this.Lb_Selected_OrderData.AutoSize = true;
            this.Lb_Selected_OrderData.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_Selected_OrderData.Location = new System.Drawing.Point(12, 364);
            this.Lb_Selected_OrderData.Name = "Lb_Selected_OrderData";
            this.Lb_Selected_OrderData.Size = new System.Drawing.Size(253, 23);
            this.Lb_Selected_OrderData.TabIndex = 59;
            this.Lb_Selected_OrderData.Text = "Selected Supplier/Product Data:";
            // 
            // Lb_Prod_List
            // 
            this.Lb_Prod_List.AutoSize = true;
            this.Lb_Prod_List.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_Prod_List.Location = new System.Drawing.Point(290, 16);
            this.Lb_Prod_List.Name = "Lb_Prod_List";
            this.Lb_Prod_List.Size = new System.Drawing.Size(134, 28);
            this.Lb_Prod_List.TabIndex = 60;
            this.Lb_Prod_List.Text = "Products List";
            // 
            // Lb_Orders_List
            // 
            this.Lb_Orders_List.AutoSize = true;
            this.Lb_Orders_List.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_Orders_List.Location = new System.Drawing.Point(290, 315);
            this.Lb_Orders_List.Name = "Lb_Orders_List";
            this.Lb_Orders_List.Size = new System.Drawing.Size(114, 28);
            this.Lb_Orders_List.TabIndex = 61;
            this.Lb_Orders_List.Text = "Orders List";
            // 
            // Lb_TotalAmount_Text
            // 
            this.Lb_TotalAmount_Text.AutoSize = true;
            this.Lb_TotalAmount_Text.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_TotalAmount_Text.Location = new System.Drawing.Point(640, 592);
            this.Lb_TotalAmount_Text.Name = "Lb_TotalAmount_Text";
            this.Lb_TotalAmount_Text.Size = new System.Drawing.Size(105, 20);
            this.Lb_TotalAmount_Text.TabIndex = 63;
            this.Lb_TotalAmount_Text.Text = "Total Amount:";
            // 
            // Lb_TotalAmount
            // 
            this.Lb_TotalAmount.AutoSize = true;
            this.Lb_TotalAmount.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_TotalAmount.Location = new System.Drawing.Point(741, 592);
            this.Lb_TotalAmount.Name = "Lb_TotalAmount";
            this.Lb_TotalAmount.Size = new System.Drawing.Size(19, 21);
            this.Lb_TotalAmount.TabIndex = 64;
            this.Lb_TotalAmount.Text = "£";
            // 
            // Btn_Insert_Orders
            // 
            this.Btn_Insert_Orders.Location = new System.Drawing.Point(955, 312);
            this.Btn_Insert_Orders.Name = "Btn_Insert_Orders";
            this.Btn_Insert_Orders.Size = new System.Drawing.Size(114, 31);
            this.Btn_Insert_Orders.TabIndex = 65;
            this.Btn_Insert_Orders.Text = "Insert Order";
            this.Btn_Insert_Orders.UseVisualStyleBackColor = true;
            this.Btn_Insert_Orders.Click += new System.EventHandler(this.Btn_Insert_Orders_Click);
            // 
            // Btn_View_Orders
            // 
            this.Btn_View_Orders.Location = new System.Drawing.Point(1075, 312);
            this.Btn_View_Orders.Name = "Btn_View_Orders";
            this.Btn_View_Orders.Size = new System.Drawing.Size(114, 31);
            this.Btn_View_Orders.TabIndex = 66;
            this.Btn_View_Orders.Text = "View Orders";
            this.Btn_View_Orders.UseVisualStyleBackColor = true;
            this.Btn_View_Orders.Click += new System.EventHandler(this.Btn_View_Orders_Click);
            // 
            // Tb_Order_Id
            // 
            this.Tb_Order_Id.Location = new System.Drawing.Point(12, 410);
            this.Tb_Order_Id.Name = "Tb_Order_Id";
            this.Tb_Order_Id.PlaceholderText = "OrderId";
            this.Tb_Order_Id.Size = new System.Drawing.Size(189, 27);
            this.Tb_Order_Id.TabIndex = 67;
            // 
            // Lb_Order_Id
            // 
            this.Lb_Order_Id.AutoSize = true;
            this.Lb_Order_Id.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lb_Order_Id.Location = new System.Drawing.Point(13, 390);
            this.Lb_Order_Id.Name = "Lb_Order_Id";
            this.Lb_Order_Id.Size = new System.Drawing.Size(54, 17);
            this.Lb_Order_Id.TabIndex = 68;
            this.Lb_Order_Id.Text = "OrderId:";
            // 
            // OrdersHistoryGV
            // 
            this.OrdersHistoryGV.AllowUserToAddRows = false;
            this.OrdersHistoryGV.AllowUserToDeleteRows = false;
            this.OrdersHistoryGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrdersHistoryGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrdersHistoryGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrdersHistoryGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersHistoryGV.Location = new System.Drawing.Point(290, 291);
            this.OrdersHistoryGV.MultiSelect = false;
            this.OrdersHistoryGV.Name = "OrdersHistoryGV";
            this.OrdersHistoryGV.RowHeadersVisible = false;
            this.OrdersHistoryGV.RowHeadersWidth = 51;
            this.OrdersHistoryGV.RowTemplate.Height = 29;
            this.OrdersHistoryGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersHistoryGV.ShowEditingIcon = false;
            this.OrdersHistoryGV.Size = new System.Drawing.Size(54, 26);
            this.OrdersHistoryGV.TabIndex = 69;
            this.OrdersHistoryGV.Visible = false;
            // 
            // ReOrderProductsGV
            // 
            this.ReOrderProductsGV.AllowUserToAddRows = false;
            this.ReOrderProductsGV.AllowUserToDeleteRows = false;
            this.ReOrderProductsGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReOrderProductsGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ReOrderProductsGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReOrderProductsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReOrderProductsGV.Location = new System.Drawing.Point(290, 654);
            this.ReOrderProductsGV.MultiSelect = false;
            this.ReOrderProductsGV.Name = "ReOrderProductsGV";
            this.ReOrderProductsGV.RowHeadersVisible = false;
            this.ReOrderProductsGV.RowHeadersWidth = 51;
            this.ReOrderProductsGV.RowTemplate.Height = 29;
            this.ReOrderProductsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReOrderProductsGV.ShowEditingIcon = false;
            this.ReOrderProductsGV.Size = new System.Drawing.Size(899, 227);
            this.ReOrderProductsGV.TabIndex = 70;
            // 
            // Lb_ReOrderProducts
            // 
            this.Lb_ReOrderProducts.AutoSize = true;
            this.Lb_ReOrderProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_ReOrderProducts.Location = new System.Drawing.Point(290, 623);
            this.Lb_ReOrderProducts.Name = "Lb_ReOrderProducts";
            this.Lb_ReOrderProducts.Size = new System.Drawing.Size(221, 28);
            this.Lb_ReOrderProducts.TabIndex = 71;
            this.Lb_ReOrderProducts.Text = "Products in Low Stock";
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 898);
            this.Controls.Add(this.Lb_ReOrderProducts);
            this.Controls.Add(this.ReOrderProductsGV);
            this.Controls.Add(this.OrdersHistoryGV);
            this.Controls.Add(this.Lb_Order_Id);
            this.Controls.Add(this.Tb_Order_Id);
            this.Controls.Add(this.Btn_View_Orders);
            this.Controls.Add(this.Btn_Insert_Orders);
            this.Controls.Add(this.Lb_TotalAmount);
            this.Controls.Add(this.Lb_TotalAmount_Text);
            this.Controls.Add(this.Lb_Orders_List);
            this.Controls.Add(this.Lb_Prod_List);
            this.Controls.Add(this.Lb_Selected_OrderData);
            this.Controls.Add(this.Lb_Prod_Desc);
            this.Controls.Add(this.Lb_Prod_Categ);
            this.Controls.Add(this.Lb_Prod_Price);
            this.Controls.Add(this.Lb_Prod_Qty);
            this.Controls.Add(this.Lb_Prod_Name);
            this.Controls.Add(this.Lb_Prod_Id);
            this.Controls.Add(this.Lb_Supplier_Name);
            this.Controls.Add(this.Tb_Product_Categ);
            this.Controls.Add(this.Tb_Product_Desc);
            this.Controls.Add(this.Tb_Product_Price);
            this.Controls.Add(this.Tb_Product_Qty);
            this.Controls.Add(this.Tb_Product_Name);
            this.Controls.Add(this.OrdersGV);
            this.Controls.Add(this.Tb_Supplier_Name);
            this.Controls.Add(this.Btn_Order_Add);
            this.Controls.Add(this.Tb_Quantity_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cb_Cat_Search);
            this.Controls.Add(this.ProductsGV);
            this.Controls.Add(this.Lb_OrderDate);
            this.Controls.Add(this.Dtp_Orders);
            this.Controls.Add(this.Tb_Product_Id);
            this.Controls.Add(this.Lb_Categories_List);
            this.Controls.Add(this.SuppliersGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ManageOrders";
            this.Text = "v";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersHistoryGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReOrderProductsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lb_Categories_List;
        private DataGridView SuppliersGV;
        private TextBox Tb_Product_Id;
        private DateTimePicker Dtp_Orders;
        private Label Lb_OrderDate;
        private ComboBox Cb_Cat_Search;
        private DataGridView ProductsGV;
        private Label label1;
        private TextBox Tb_Quantity_Id;
        private Button Btn_Order_Add;
        private TextBox Tb_Supplier_Name;
        private DataGridView OrdersGV;
        private TextBox Tb_Product_Name;
        private TextBox Tb_Product_Qty;
        private TextBox Tb_Product_Price;
        private TextBox Tb_Product_Categ;
        private TextBox Tb_Product_Desc;
        private Label Lb_Supplier_Name;
        private Label Lb_Prod_Id;
        private Label Lb_Prod_Name;
        private Label Lb_Prod_Qty;
        private Label Lb_Prod_Price;
        private Label Lb_Prod_Categ;
        private Label Lb_Prod_Desc;
        private Label Lb_Selected_OrderData;
        private Label Lb_Prod_List;
        private Label Lb_Orders_List;
        private Label Lb_TotalAmount_Text;
        private Label Lb_TotalAmount;
        private Button Btn_Insert_Orders;
        private Button Btn_View_Orders;
        private TextBox Tb_Order_Id;
        private Label Lb_Order_Id;
        private DataGridView OrdersHistoryGV;
        private DataGridView ReOrderProductsGV;
        private Label Lb_ReOrderProducts;
    }
}