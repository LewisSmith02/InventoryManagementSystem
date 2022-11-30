namespace InventoryManagementSystemPrototype
{
    public partial class HomePageEMP : Form
    {
        public HomePageEMP()
        {
            InitializeComponent();
        }

        private void EMP_Btn_Products_Click(object sender, EventArgs e)
        {
            ManageProductsEMP Prod = new ManageProductsEMP();
            Prod.Show();
            //this.Hide();
        }

        private void EMP_Btn_Exit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
