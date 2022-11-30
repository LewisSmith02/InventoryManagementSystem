namespace InventoryManagementSystemPrototype
{
    partial class HomePageEMP
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
            this.EMP_Btn_Products = new System.Windows.Forms.Button();
            this.EMP_Lb_AppName = new System.Windows.Forms.Label();
            this.EMP_Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EMP_Btn_Products
            // 
            this.EMP_Btn_Products.Location = new System.Drawing.Point(92, 145);
            this.EMP_Btn_Products.Name = "EMP_Btn_Products";
            this.EMP_Btn_Products.Size = new System.Drawing.Size(304, 72);
            this.EMP_Btn_Products.TabIndex = 0;
            this.EMP_Btn_Products.Text = "Manage Products";
            this.EMP_Btn_Products.UseVisualStyleBackColor = true;
            this.EMP_Btn_Products.Click += new System.EventHandler(this.EMP_Btn_Products_Click);
            // 
            // EMP_Lb_AppName
            // 
            this.EMP_Lb_AppName.AutoSize = true;
            this.EMP_Lb_AppName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EMP_Lb_AppName.Location = new System.Drawing.Point(21, 34);
            this.EMP_Lb_AppName.Name = "EMP_Lb_AppName";
            this.EMP_Lb_AppName.Size = new System.Drawing.Size(447, 41);
            this.EMP_Lb_AppName.TabIndex = 1;
            this.EMP_Lb_AppName.Text = "Inventory Management System";
            // 
            // EMP_Btn_Exit
            // 
            this.EMP_Btn_Exit.Location = new System.Drawing.Point(190, 269);
            this.EMP_Btn_Exit.Name = "EMP_Btn_Exit";
            this.EMP_Btn_Exit.Size = new System.Drawing.Size(109, 40);
            this.EMP_Btn_Exit.TabIndex = 6;
            this.EMP_Btn_Exit.Text = "Logout";
            this.EMP_Btn_Exit.UseVisualStyleBackColor = true;
            this.EMP_Btn_Exit.Click += new System.EventHandler(this.EMP_Btn_Exit_Click);
            // 
            // HomePageEMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 350);
            this.Controls.Add(this.EMP_Btn_Exit);
            this.Controls.Add(this.EMP_Lb_AppName);
            this.Controls.Add(this.EMP_Btn_Products);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "HomePageEMP";
            this.Text = "EMP_HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EMP_Btn_Products;
        private Label EMP_Lb_AppName;
        private Button EMP_Btn_Exit;
    }
}