namespace InventoryManagementSystemPrototype
{
    partial class ManageUsers
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
            this.Btn_User_Delete = new System.Windows.Forms.Button();
            this.Btn_User_Edit = new System.Windows.Forms.Button();
            this.Btn_User_Add = new System.Windows.Forms.Button();
            this.Lbl_ManageUsers = new System.Windows.Forms.Label();
            this.Tb_User_Name = new System.Windows.Forms.TextBox();
            this.Tb_User_Id = new System.Windows.Forms.TextBox();
            this.Tb_User_Password = new System.Windows.Forms.TextBox();
            this.UsersGV = new System.Windows.Forms.DataGridView();
            this.Lb_Users_List = new System.Windows.Forms.Label();
            this.Cb_User_Role = new System.Windows.Forms.ComboBox();
            this.Lb_UserId = new System.Windows.Forms.Label();
            this.Lb_Username = new System.Windows.Forms.Label();
            this.Lb_Password = new System.Windows.Forms.Label();
            this.Lb_Role = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_User_Delete
            // 
            this.Btn_User_Delete.Location = new System.Drawing.Point(189, 111);
            this.Btn_User_Delete.Name = "Btn_User_Delete";
            this.Btn_User_Delete.Size = new System.Drawing.Size(94, 29);
            this.Btn_User_Delete.TabIndex = 13;
            this.Btn_User_Delete.Text = "Delete";
            this.Btn_User_Delete.UseVisualStyleBackColor = true;
            this.Btn_User_Delete.Click += new System.EventHandler(this.Btn_User_Delete_Click);
            // 
            // Btn_User_Edit
            // 
            this.Btn_User_Edit.Location = new System.Drawing.Point(189, 157);
            this.Btn_User_Edit.Name = "Btn_User_Edit";
            this.Btn_User_Edit.Size = new System.Drawing.Size(94, 29);
            this.Btn_User_Edit.TabIndex = 12;
            this.Btn_User_Edit.Text = "Update";
            this.Btn_User_Edit.UseVisualStyleBackColor = true;
            this.Btn_User_Edit.Click += new System.EventHandler(this.Btn_User_Edit_Click);
            // 
            // Btn_User_Add
            // 
            this.Btn_User_Add.Location = new System.Drawing.Point(189, 65);
            this.Btn_User_Add.Name = "Btn_User_Add";
            this.Btn_User_Add.Size = new System.Drawing.Size(94, 29);
            this.Btn_User_Add.TabIndex = 11;
            this.Btn_User_Add.Text = "Add";
            this.Btn_User_Add.UseVisualStyleBackColor = true;
            this.Btn_User_Add.Click += new System.EventHandler(this.Btn_User_Add_Click);
            // 
            // Lbl_ManageUsers
            // 
            this.Lbl_ManageUsers.AutoSize = true;
            this.Lbl_ManageUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ManageUsers.Location = new System.Drawing.Point(12, 9);
            this.Lbl_ManageUsers.Name = "Lbl_ManageUsers";
            this.Lbl_ManageUsers.Size = new System.Drawing.Size(145, 28);
            this.Lbl_ManageUsers.TabIndex = 10;
            this.Lbl_ManageUsers.Text = "Manage Users";
            // 
            // Tb_User_Name
            // 
            this.Tb_User_Name.Location = new System.Drawing.Point(12, 112);
            this.Tb_User_Name.Name = "Tb_User_Name";
            this.Tb_User_Name.PlaceholderText = "Username";
            this.Tb_User_Name.Size = new System.Drawing.Size(149, 27);
            this.Tb_User_Name.TabIndex = 9;
            // 
            // Tb_User_Id
            // 
            this.Tb_User_Id.Location = new System.Drawing.Point(12, 64);
            this.Tb_User_Id.Name = "Tb_User_Id";
            this.Tb_User_Id.PlaceholderText = "User ID";
            this.Tb_User_Id.Size = new System.Drawing.Size(149, 27);
            this.Tb_User_Id.TabIndex = 8;
            // 
            // Tb_User_Password
            // 
            this.Tb_User_Password.Location = new System.Drawing.Point(12, 160);
            this.Tb_User_Password.Name = "Tb_User_Password";
            this.Tb_User_Password.PlaceholderText = "Password";
            this.Tb_User_Password.Size = new System.Drawing.Size(151, 27);
            this.Tb_User_Password.TabIndex = 16;
            // 
            // UsersGV
            // 
            this.UsersGV.AllowUserToAddRows = false;
            this.UsersGV.AllowUserToDeleteRows = false;
            this.UsersGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsersGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UsersGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGV.Location = new System.Drawing.Point(312, 65);
            this.UsersGV.MultiSelect = false;
            this.UsersGV.Name = "UsersGV";
            this.UsersGV.RowHeadersVisible = false;
            this.UsersGV.RowHeadersWidth = 51;
            this.UsersGV.RowTemplate.Height = 29;
            this.UsersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersGV.ShowEditingIcon = false;
            this.UsersGV.Size = new System.Drawing.Size(508, 173);
            this.UsersGV.TabIndex = 17;
            this.UsersGV.VirtualMode = true;
            this.UsersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGV_CellContentClick);
            // 
            // Lb_Users_List
            // 
            this.Lb_Users_List.AutoSize = true;
            this.Lb_Users_List.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_Users_List.Location = new System.Drawing.Point(312, 34);
            this.Lb_Users_List.Name = "Lb_Users_List";
            this.Lb_Users_List.Size = new System.Drawing.Size(102, 28);
            this.Lb_Users_List.TabIndex = 18;
            this.Lb_Users_List.Text = "Users List";
            // 
            // Cb_User_Role
            // 
            this.Cb_User_Role.FormattingEnabled = true;
            this.Cb_User_Role.Items.AddRange(new object[] {
            "Senior Inventory Manager (Admin)",
            "Inventory Manager",
            "Employee"});
            this.Cb_User_Role.Location = new System.Drawing.Point(12, 208);
            this.Cb_User_Role.Name = "Cb_User_Role";
            this.Cb_User_Role.Size = new System.Drawing.Size(153, 28);
            this.Cb_User_Role.TabIndex = 19;
            this.Cb_User_Role.Text = "Select Role";
            // 
            // Lb_UserId
            // 
            this.Lb_UserId.AutoSize = true;
            this.Lb_UserId.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lb_UserId.Location = new System.Drawing.Point(12, 45);
            this.Lb_UserId.Name = "Lb_UserId";
            this.Lb_UserId.Size = new System.Drawing.Size(52, 17);
            this.Lb_UserId.TabIndex = 20;
            this.Lb_UserId.Text = "User ID:";
            // 
            // Lb_Username
            // 
            this.Lb_Username.AutoSize = true;
            this.Lb_Username.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lb_Username.Location = new System.Drawing.Point(12, 93);
            this.Lb_Username.Name = "Lb_Username";
            this.Lb_Username.Size = new System.Drawing.Size(67, 17);
            this.Lb_Username.TabIndex = 21;
            this.Lb_Username.Text = "Username:";
            // 
            // Lb_Password
            // 
            this.Lb_Password.AutoSize = true;
            this.Lb_Password.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lb_Password.Location = new System.Drawing.Point(12, 141);
            this.Lb_Password.Name = "Lb_Password";
            this.Lb_Password.Size = new System.Drawing.Size(63, 17);
            this.Lb_Password.TabIndex = 22;
            this.Lb_Password.Text = "Password:";
            // 
            // Lb_Role
            // 
            this.Lb_Role.AutoSize = true;
            this.Lb_Role.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Lb_Role.Location = new System.Drawing.Point(14, 189);
            this.Lb_Role.Name = "Lb_Role";
            this.Lb_Role.Size = new System.Drawing.Size(35, 17);
            this.Lb_Role.TabIndex = 23;
            this.Lb_Role.Text = "Role:";
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 258);
            this.Controls.Add(this.Lb_Role);
            this.Controls.Add(this.Lb_Password);
            this.Controls.Add(this.Lb_Username);
            this.Controls.Add(this.Lb_UserId);
            this.Controls.Add(this.Cb_User_Role);
            this.Controls.Add(this.Lb_Users_List);
            this.Controls.Add(this.UsersGV);
            this.Controls.Add(this.Tb_User_Password);
            this.Controls.Add(this.Btn_User_Delete);
            this.Controls.Add(this.Btn_User_Edit);
            this.Controls.Add(this.Btn_User_Add);
            this.Controls.Add(this.Lbl_ManageUsers);
            this.Controls.Add(this.Tb_User_Name);
            this.Controls.Add(this.Tb_User_Id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Btn_User_Delete;
        private Button Btn_User_Edit;
        private Button Btn_User_Add;
        private Label Lbl_ManageUsers;
        private TextBox Tb_User_Name;
        private TextBox Tb_User_Id;
        private TextBox Tb_User_Password;
        private DataGridView UsersGV;
        private Label Lb_Users_List;
        private ComboBox Cb_User_Role;
        private Label Lb_UserId;
        private Label Lb_Username;
        private Label Lb_Password;
        private Label Lb_Role;
    }
}