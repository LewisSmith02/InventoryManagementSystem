namespace InventoryManagementSystemPrototype
{
    public partial class HomePageSIM : Form
    {
        public HomePageSIM()
        {
            InitializeComponent();

            this.FormClosing += HomePageSIM_FormClosing;
        }

        private void Btn_Products_Click(object sender, EventArgs e)
        {
            ManageProducts Prod = new ManageProducts();
            Prod.Show();
            //this.Hide();
        }

        private void Btn_Categories_Click(object sender, EventArgs e)
        {
            ManageCategories Categ = new ManageCategories();
            Categ.Show();
            //this.Hide();
        }

        private void Btn_Users_Click(object sender, EventArgs e)
        {
            ManageUsers Users = new ManageUsers();
            Users.Show();
            //this.Hide();
        }

        private void Btn_Suppliers_Click(object sender, EventArgs e)
        {
            ManageSuppliers Sup = new ManageSuppliers();
            Sup.Show();
            //this.Hide();
        }

        private void Btn_Orders_Click(object sender, EventArgs e)
        {
            ManageOrders Order = new ManageOrders();
            Order.Show();
            //this.Hide();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void HomePageSIM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (e.CloseReason == CloseReason.UserClosing)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to logout?",
                    "Exit?",
                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Error exiting program.");
                }
            }
        }
    }
}
