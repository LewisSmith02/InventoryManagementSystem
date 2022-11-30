namespace InventoryManagementSystemPrototype
{
    public partial class HomePageIM : Form
    {
        public HomePageIM()
        {
            InitializeComponent();
        }

        private void IM_Btn_Products_Click(object sender, EventArgs e)
        {
            ManageProducts Prod = new ManageProducts();
            Prod.Show();
            //this.Hide();
        }

        private void IM_Btn_Orders_Click(object sender, EventArgs e)
        {
            ManageOrders Order = new ManageOrders();
            Order.Show();
            //this.Hide();
        }

        private void IM_Btn_Exit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
