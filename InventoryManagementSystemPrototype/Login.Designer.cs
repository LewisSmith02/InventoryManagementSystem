namespace InventoryManagementSystemPrototype
{
    partial class Login
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
            this.Lbl_AppName = new System.Windows.Forms.Label();
            this.Tb_Username = new System.Windows.Forms.TextBox();
            this.Tb_Password = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Cb_ShowPass = new System.Windows.Forms.CheckBox();
            this.Cb_SelectRole = new System.Windows.Forms.ComboBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_AppName
            // 
            this.Lbl_AppName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_AppName.AutoSize = true;
            this.Lbl_AppName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_AppName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_AppName.Location = new System.Drawing.Point(35, 40);
            this.Lbl_AppName.Name = "Lbl_AppName";
            this.Lbl_AppName.Size = new System.Drawing.Size(309, 28);
            this.Lbl_AppName.TabIndex = 0;
            this.Lbl_AppName.Text = "Inventory Management System";
            this.Lbl_AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tb_Username
            // 
            this.Tb_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tb_Username.Location = new System.Drawing.Point(74, 145);
            this.Tb_Username.Name = "Tb_Username";
            this.Tb_Username.PlaceholderText = "Username";
            this.Tb_Username.Size = new System.Drawing.Size(219, 27);
            this.Tb_Username.TabIndex = 1;
            // 
            // Tb_Password
            // 
            this.Tb_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tb_Password.Location = new System.Drawing.Point(74, 192);
            this.Tb_Password.Name = "Tb_Password";
            this.Tb_Password.PlaceholderText = "Password";
            this.Tb_Password.Size = new System.Drawing.Size(219, 27);
            this.Tb_Password.TabIndex = 2;
            this.Tb_Password.UseSystemPasswordChar = true;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Login.Location = new System.Drawing.Point(74, 246);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(100, 29);
            this.Btn_Login.TabIndex = 3;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Cb_ShowPass
            // 
            this.Cb_ShowPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cb_ShowPass.AutoSize = true;
            this.Cb_ShowPass.Location = new System.Drawing.Point(117, 293);
            this.Cb_ShowPass.Name = "Cb_ShowPass";
            this.Cb_ShowPass.Size = new System.Drawing.Size(132, 24);
            this.Cb_ShowPass.TabIndex = 4;
            this.Cb_ShowPass.Text = "Show Password";
            this.Cb_ShowPass.UseVisualStyleBackColor = true;
            this.Cb_ShowPass.CheckedChanged += new System.EventHandler(this.Cb_ShowPass_CheckedChanged);
            // 
            // Cb_SelectRole
            // 
            this.Cb_SelectRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cb_SelectRole.DisplayMember = "Select Role";
            this.Cb_SelectRole.FormattingEnabled = true;
            this.Cb_SelectRole.Items.AddRange(new object[] {
            "Senior Inventory Manager (Admin)",
            "Inventory Manager",
            "Employee"});
            this.Cb_SelectRole.Location = new System.Drawing.Point(74, 97);
            this.Cb_SelectRole.Name = "Cb_SelectRole";
            this.Cb_SelectRole.Size = new System.Drawing.Size(219, 28);
            this.Cb_SelectRole.TabIndex = 5;
            this.Cb_SelectRole.Text = "Select Role";
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Clear.Location = new System.Drawing.Point(193, 246);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(100, 29);
            this.Btn_Clear.TabIndex = 6;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 393);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Cb_SelectRole);
            this.Controls.Add(this.Cb_ShowPass);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Tb_Password);
            this.Controls.Add(this.Tb_Username);
            this.Controls.Add(this.Lbl_AppName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lbl_AppName;
        private TextBox Tb_Username;
        private TextBox Tb_Password;
        private Button Btn_Login;
        private CheckBox Cb_ShowPass;
        private ComboBox Cb_SelectRole;
        private Button Btn_Clear;
    }
}