namespace InventoryManagementSystemPrototype
{
    partial class HomePageSIM
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
            this.Btn_Products = new System.Windows.Forms.Button();
            this.Lb_AppName = new System.Windows.Forms.Label();
            this.Btn_Categories = new System.Windows.Forms.Button();
            this.Btn_Users = new System.Windows.Forms.Button();
            this.Btn_Orders = new System.Windows.Forms.Button();
            this.Btn_Suppliers = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Products
            // 
            this.Btn_Products.Location = new System.Drawing.Point(75, 215);
            this.Btn_Products.Name = "Btn_Products";
            this.Btn_Products.Size = new System.Drawing.Size(154, 72);
            this.Btn_Products.TabIndex = 0;
            this.Btn_Products.Text = "Manage Products";
            this.Btn_Products.UseVisualStyleBackColor = true;
            this.Btn_Products.Click += new System.EventHandler(this.Btn_Products_Click);
            // 
            // Lb_AppName
            // 
            this.Lb_AppName.AutoSize = true;
            this.Lb_AppName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_AppName.Location = new System.Drawing.Point(21, 34);
            this.Lb_AppName.Name = "Lb_AppName";
            this.Lb_AppName.Size = new System.Drawing.Size(447, 41);
            this.Lb_AppName.TabIndex = 1;
            this.Lb_AppName.Text = "Inventory Management System";
            // 
            // Btn_Categories
            // 
            this.Btn_Categories.Location = new System.Drawing.Point(262, 117);
            this.Btn_Categories.Name = "Btn_Categories";
            this.Btn_Categories.Size = new System.Drawing.Size(151, 72);
            this.Btn_Categories.TabIndex = 2;
            this.Btn_Categories.Text = "Manage Categories/Order Limit";
            this.Btn_Categories.UseVisualStyleBackColor = true;
            this.Btn_Categories.Click += new System.EventHandler(this.Btn_Categories_Click);
            // 
            // Btn_Users
            // 
            this.Btn_Users.Location = new System.Drawing.Point(262, 215);
            this.Btn_Users.Name = "Btn_Users";
            this.Btn_Users.Size = new System.Drawing.Size(151, 72);
            this.Btn_Users.TabIndex = 3;
            this.Btn_Users.Text = "Manage Users";
            this.Btn_Users.UseVisualStyleBackColor = true;
            this.Btn_Users.Click += new System.EventHandler(this.Btn_Users_Click);
            // 
            // Btn_Orders
            // 
            this.Btn_Orders.Location = new System.Drawing.Point(75, 313);
            this.Btn_Orders.Name = "Btn_Orders";
            this.Btn_Orders.Size = new System.Drawing.Size(338, 76);
            this.Btn_Orders.TabIndex = 4;
            this.Btn_Orders.Text = "Create/View Orders";
            this.Btn_Orders.UseVisualStyleBackColor = true;
            this.Btn_Orders.Click += new System.EventHandler(this.Btn_Orders_Click);
            // 
            // Btn_Suppliers
            // 
            this.Btn_Suppliers.Location = new System.Drawing.Point(75, 117);
            this.Btn_Suppliers.Name = "Btn_Suppliers";
            this.Btn_Suppliers.Size = new System.Drawing.Size(154, 72);
            this.Btn_Suppliers.TabIndex = 5;
            this.Btn_Suppliers.Text = "Manage Suppliers";
            this.Btn_Suppliers.UseVisualStyleBackColor = true;
            this.Btn_Suppliers.Click += new System.EventHandler(this.Btn_Suppliers_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(190, 408);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(109, 40);
            this.Btn_Exit.TabIndex = 6;
            this.Btn_Exit.Text = "Logout";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // HomePageSIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 473);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Suppliers);
            this.Controls.Add(this.Btn_Orders);
            this.Controls.Add(this.Btn_Users);
            this.Controls.Add(this.Btn_Categories);
            this.Controls.Add(this.Lb_AppName);
            this.Controls.Add(this.Btn_Products);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "HomePageSIM";
            this.Text = "HomePage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePageSIM_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_Products;
        private Label Lb_AppName;
        private Button Btn_Categories;
        private Button Btn_Users;
        private Button Btn_Orders;
        private Button Btn_Suppliers;
        private Button Btn_Exit;
    }
}