namespace InventoryManagementSystemPrototype
{
    partial class HomePageIM
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
            this.IM_Btn_Products = new System.Windows.Forms.Button();
            this.IM_Lb_AppName = new System.Windows.Forms.Label();
            this.IM_Btn_Orders = new System.Windows.Forms.Button();
            this.IM_Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IM_Btn_Products
            // 
            this.IM_Btn_Products.Location = new System.Drawing.Point(87, 144);
            this.IM_Btn_Products.Name = "IM_Btn_Products";
            this.IM_Btn_Products.Size = new System.Drawing.Size(154, 72);
            this.IM_Btn_Products.TabIndex = 0;
            this.IM_Btn_Products.Text = "Manage Products";
            this.IM_Btn_Products.UseVisualStyleBackColor = true;
            this.IM_Btn_Products.Click += new System.EventHandler(this.IM_Btn_Products_Click);
            // 
            // IM_Lb_AppName
            // 
            this.IM_Lb_AppName.AutoSize = true;
            this.IM_Lb_AppName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IM_Lb_AppName.Location = new System.Drawing.Point(21, 34);
            this.IM_Lb_AppName.Name = "IM_Lb_AppName";
            this.IM_Lb_AppName.Size = new System.Drawing.Size(447, 41);
            this.IM_Lb_AppName.TabIndex = 1;
            this.IM_Lb_AppName.Text = "Inventory Management System";
            // 
            // IM_Btn_Orders
            // 
            this.IM_Btn_Orders.Location = new System.Drawing.Point(247, 144);
            this.IM_Btn_Orders.Name = "IM_Btn_Orders";
            this.IM_Btn_Orders.Size = new System.Drawing.Size(154, 72);
            this.IM_Btn_Orders.TabIndex = 4;
            this.IM_Btn_Orders.Text = "Create/View Orders";
            this.IM_Btn_Orders.UseVisualStyleBackColor = true;
            this.IM_Btn_Orders.Click += new System.EventHandler(this.IM_Btn_Orders_Click);
            // 
            // IM_Btn_Exit
            // 
            this.IM_Btn_Exit.Location = new System.Drawing.Point(190, 269);
            this.IM_Btn_Exit.Name = "IM_Btn_Exit";
            this.IM_Btn_Exit.Size = new System.Drawing.Size(109, 40);
            this.IM_Btn_Exit.TabIndex = 6;
            this.IM_Btn_Exit.Text = "Logout";
            this.IM_Btn_Exit.UseVisualStyleBackColor = true;
            this.IM_Btn_Exit.Click += new System.EventHandler(this.IM_Btn_Exit_Click);
            // 
            // HomePageIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 350);
            this.Controls.Add(this.IM_Btn_Exit);
            this.Controls.Add(this.IM_Btn_Orders);
            this.Controls.Add(this.IM_Lb_AppName);
            this.Controls.Add(this.IM_Btn_Products);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "HomePageIM";
            this.Text = "IM_HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button IM_Btn_Products;
        private Label IM_Lb_AppName;
        private Button IM_Btn_Orders;
        private Button IM_Btn_Exit;
    }
}