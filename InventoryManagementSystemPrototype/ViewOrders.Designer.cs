namespace InventoryManagementSystemPrototype
{
    partial class ViewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrders));
            this.OrdersGV = new System.Windows.Forms.DataGridView();
            this.Lb_ViewOrders = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Btn_CompleteOrder = new System.Windows.Forms.Button();
            this.Lb_SelectedOrderId = new System.Windows.Forms.Label();
            this.Tb_PendingOrderId = new System.Windows.Forms.TextBox();
            this.Lb_OrderHistory = new System.Windows.Forms.Label();
            this.OrderHistoryGV = new System.Windows.Forms.DataGridView();
            this.Btn_CancelOrder = new System.Windows.Forms.Button();
            this.Btn_RemoveOrderHistory = new System.Windows.Forms.Button();
            this.Tb_OrderHistoryID = new System.Windows.Forms.TextBox();
            this.Lb_OrderHistoryID = new System.Windows.Forms.Label();
            this.Btn_SearchOrderHistory = new System.Windows.Forms.Button();
            this.Btn_OrderIDSearchRefresh = new System.Windows.Forms.Button();
            this.Btn_RefreshPendingOrders = new System.Windows.Forms.Button();
            this.Btn_SearchPendingOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderHistoryGV)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersGV
            // 
            this.OrdersGV.AllowUserToAddRows = false;
            this.OrdersGV.AllowUserToDeleteRows = false;
            this.OrdersGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrdersGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrdersGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrdersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGV.Location = new System.Drawing.Point(35, 75);
            this.OrdersGV.MultiSelect = false;
            this.OrdersGV.Name = "OrdersGV";
            this.OrdersGV.RowHeadersVisible = false;
            this.OrdersGV.RowHeadersWidth = 51;
            this.OrdersGV.RowTemplate.Height = 29;
            this.OrdersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersGV.ShowEditingIcon = false;
            this.OrdersGV.Size = new System.Drawing.Size(1103, 301);
            this.OrdersGV.TabIndex = 33;
            this.OrdersGV.VirtualMode = true;
            this.OrdersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersGV_CellContentClick);
            // 
            // Lb_ViewOrders
            // 
            this.Lb_ViewOrders.AutoSize = true;
            this.Lb_ViewOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_ViewOrders.Location = new System.Drawing.Point(35, 26);
            this.Lb_ViewOrders.Name = "Lb_ViewOrders";
            this.Lb_ViewOrders.Size = new System.Drawing.Size(213, 38);
            this.Lb_ViewOrders.TabIndex = 34;
            this.Lb_ViewOrders.Text = "Pending Orders";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Btn_CompleteOrder
            // 
            this.Btn_CompleteOrder.Location = new System.Drawing.Point(869, 40);
            this.Btn_CompleteOrder.Name = "Btn_CompleteOrder";
            this.Btn_CompleteOrder.Size = new System.Drawing.Size(149, 29);
            this.Btn_CompleteOrder.TabIndex = 35;
            this.Btn_CompleteOrder.Text = "Complete Order";
            this.Btn_CompleteOrder.UseVisualStyleBackColor = true;
            this.Btn_CompleteOrder.Click += new System.EventHandler(this.Btn_CompleteOrder_Click);
            // 
            // Lb_SelectedOrderId
            // 
            this.Lb_SelectedOrderId.AutoSize = true;
            this.Lb_SelectedOrderId.Location = new System.Drawing.Point(419, 43);
            this.Lb_SelectedOrderId.Name = "Lb_SelectedOrderId";
            this.Lb_SelectedOrderId.Size = new System.Drawing.Size(69, 20);
            this.Lb_SelectedOrderId.TabIndex = 36;
            this.Lb_SelectedOrderId.Text = "Order ID:";
            // 
            // Tb_PendingOrderId
            // 
            this.Tb_PendingOrderId.Location = new System.Drawing.Point(492, 40);
            this.Tb_PendingOrderId.Name = "Tb_PendingOrderId";
            this.Tb_PendingOrderId.Size = new System.Drawing.Size(125, 27);
            this.Tb_PendingOrderId.TabIndex = 37;
            // 
            // Lb_OrderHistory
            // 
            this.Lb_OrderHistory.AutoSize = true;
            this.Lb_OrderHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_OrderHistory.Location = new System.Drawing.Point(35, 401);
            this.Lb_OrderHistory.Name = "Lb_OrderHistory";
            this.Lb_OrderHistory.Size = new System.Drawing.Size(190, 38);
            this.Lb_OrderHistory.TabIndex = 38;
            this.Lb_OrderHistory.Text = "Order History";
            // 
            // OrderHistoryGV
            // 
            this.OrderHistoryGV.AllowUserToAddRows = false;
            this.OrderHistoryGV.AllowUserToDeleteRows = false;
            this.OrderHistoryGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderHistoryGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrderHistoryGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderHistoryGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderHistoryGV.Location = new System.Drawing.Point(35, 442);
            this.OrderHistoryGV.MultiSelect = false;
            this.OrderHistoryGV.Name = "OrderHistoryGV";
            this.OrderHistoryGV.RowHeadersVisible = false;
            this.OrderHistoryGV.RowHeadersWidth = 51;
            this.OrderHistoryGV.RowTemplate.Height = 29;
            this.OrderHistoryGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderHistoryGV.ShowEditingIcon = false;
            this.OrderHistoryGV.Size = new System.Drawing.Size(1103, 301);
            this.OrderHistoryGV.TabIndex = 39;
            this.OrderHistoryGV.VirtualMode = true;
            this.OrderHistoryGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderHistoryGV_CellContentClick);
            // 
            // Btn_CancelOrder
            // 
            this.Btn_CancelOrder.Location = new System.Drawing.Point(1022, 40);
            this.Btn_CancelOrder.Name = "Btn_CancelOrder";
            this.Btn_CancelOrder.Size = new System.Drawing.Size(116, 29);
            this.Btn_CancelOrder.TabIndex = 40;
            this.Btn_CancelOrder.Text = "Cancel Order";
            this.Btn_CancelOrder.UseVisualStyleBackColor = true;
            this.Btn_CancelOrder.Click += new System.EventHandler(this.Btn_CancelOrder_Click);
            // 
            // Btn_RemoveOrderHistory
            // 
            this.Btn_RemoveOrderHistory.Location = new System.Drawing.Point(973, 410);
            this.Btn_RemoveOrderHistory.Name = "Btn_RemoveOrderHistory";
            this.Btn_RemoveOrderHistory.Size = new System.Drawing.Size(149, 29);
            this.Btn_RemoveOrderHistory.TabIndex = 41;
            this.Btn_RemoveOrderHistory.Text = "Remove Order";
            this.Btn_RemoveOrderHistory.UseVisualStyleBackColor = true;
            this.Btn_RemoveOrderHistory.Click += new System.EventHandler(this.Btn_RemoveOrderHistory_Click);
            // 
            // Tb_OrderHistoryID
            // 
            this.Tb_OrderHistoryID.Location = new System.Drawing.Point(590, 411);
            this.Tb_OrderHistoryID.Name = "Tb_OrderHistoryID";
            this.Tb_OrderHistoryID.Size = new System.Drawing.Size(125, 27);
            this.Tb_OrderHistoryID.TabIndex = 43;
            // 
            // Lb_OrderHistoryID
            // 
            this.Lb_OrderHistoryID.AutoSize = true;
            this.Lb_OrderHistoryID.Location = new System.Drawing.Point(515, 414);
            this.Lb_OrderHistoryID.Name = "Lb_OrderHistoryID";
            this.Lb_OrderHistoryID.Size = new System.Drawing.Size(69, 20);
            this.Lb_OrderHistoryID.TabIndex = 42;
            this.Lb_OrderHistoryID.Text = "Order ID:";
            // 
            // Btn_SearchOrderHistory
            // 
            this.Btn_SearchOrderHistory.Location = new System.Drawing.Point(721, 410);
            this.Btn_SearchOrderHistory.Name = "Btn_SearchOrderHistory";
            this.Btn_SearchOrderHistory.Size = new System.Drawing.Size(120, 29);
            this.Btn_SearchOrderHistory.TabIndex = 44;
            this.Btn_SearchOrderHistory.Text = "Search";
            this.Btn_SearchOrderHistory.UseVisualStyleBackColor = true;
            this.Btn_SearchOrderHistory.Click += new System.EventHandler(this.Btn_SearchOrderHistory_Click);
            // 
            // Btn_OrderIDSearchRefresh
            // 
            this.Btn_OrderIDSearchRefresh.Location = new System.Drawing.Point(847, 410);
            this.Btn_OrderIDSearchRefresh.Name = "Btn_OrderIDSearchRefresh";
            this.Btn_OrderIDSearchRefresh.Size = new System.Drawing.Size(120, 29);
            this.Btn_OrderIDSearchRefresh.TabIndex = 45;
            this.Btn_OrderIDSearchRefresh.Text = "Refresh";
            this.Btn_OrderIDSearchRefresh.UseVisualStyleBackColor = true;
            this.Btn_OrderIDSearchRefresh.Click += new System.EventHandler(this.Btn_OrderIDSearchRefresh_Click);
            // 
            // Btn_RefreshPendingOrders
            // 
            this.Btn_RefreshPendingOrders.Location = new System.Drawing.Point(745, 40);
            this.Btn_RefreshPendingOrders.Name = "Btn_RefreshPendingOrders";
            this.Btn_RefreshPendingOrders.Size = new System.Drawing.Size(120, 29);
            this.Btn_RefreshPendingOrders.TabIndex = 47;
            this.Btn_RefreshPendingOrders.Text = "Refresh";
            this.Btn_RefreshPendingOrders.UseVisualStyleBackColor = true;
            this.Btn_RefreshPendingOrders.Click += new System.EventHandler(this.Btn_RefreshPendingOrders_Click);
            // 
            // Btn_SearchPendingOrders
            // 
            this.Btn_SearchPendingOrders.Location = new System.Drawing.Point(621, 40);
            this.Btn_SearchPendingOrders.Name = "Btn_SearchPendingOrders";
            this.Btn_SearchPendingOrders.Size = new System.Drawing.Size(120, 29);
            this.Btn_SearchPendingOrders.TabIndex = 46;
            this.Btn_SearchPendingOrders.Text = "Search";
            this.Btn_SearchPendingOrders.UseVisualStyleBackColor = true;
            this.Btn_SearchPendingOrders.Click += new System.EventHandler(this.Btn_SearchPendingOrders_Click);
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 776);
            this.Controls.Add(this.Btn_RefreshPendingOrders);
            this.Controls.Add(this.Btn_SearchPendingOrders);
            this.Controls.Add(this.Btn_OrderIDSearchRefresh);
            this.Controls.Add(this.Btn_SearchOrderHistory);
            this.Controls.Add(this.Tb_OrderHistoryID);
            this.Controls.Add(this.Lb_OrderHistoryID);
            this.Controls.Add(this.Btn_RemoveOrderHistory);
            this.Controls.Add(this.Btn_CancelOrder);
            this.Controls.Add(this.OrderHistoryGV);
            this.Controls.Add(this.Lb_OrderHistory);
            this.Controls.Add(this.Tb_PendingOrderId);
            this.Controls.Add(this.Lb_SelectedOrderId);
            this.Controls.Add(this.Btn_CompleteOrder);
            this.Controls.Add(this.Lb_ViewOrders);
            this.Controls.Add(this.OrdersGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewOrders";
            this.Text = "ViewOrders";
            this.Load += new System.EventHandler(this.ViewOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderHistoryGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView OrdersGV;
        private Label Lb_ViewOrders;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button Btn_CompleteOrder;
        private Label Lb_SelectedOrderId;
        private TextBox Tb_PendingOrderId;
        private Label Lb_OrderHistory;
        private DataGridView OrderHistoryGV;
        private Button Btn_CancelOrder;
        private Button Btn_RemoveOrderHistory;
        private TextBox Tb_OrderHistoryID;
        private Label Lb_OrderHistoryID;
        private Button Btn_SearchOrderHistory;
        private Button Btn_OrderIDSearchRefresh;
        private Button Btn_RefreshPendingOrders;
        private Button Btn_SearchPendingOrders;
    }
}