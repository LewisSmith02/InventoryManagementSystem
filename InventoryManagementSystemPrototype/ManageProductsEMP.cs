using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystemPrototype
{
    public partial class ManageProductsEMP : Form
    {
        public ManageProductsEMP()
        {
            InitializeComponent();
        }

        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\UniversityWork\year1\software-systems\Prototype\IMS.mdf;Integrated Security=True;Connect Timeout=30");

        //Populates ProductsGV categories using data pulled from CategoryTbl
        void PopulateCategories()
        {
            string SelectQuery = "select * from CategoryTbl";
            SqlCommand cmd = new SqlCommand(SelectQuery, Con);
            SqlDataReader SqlDataReader;
            try
            {
                Con.Open();
                DataTable DataTable = new DataTable();
                DataTable.Columns.Add("Category_Name", typeof(string));
                SqlDataReader = cmd.ExecuteReader();
                DataTable.Load(SqlDataReader);
                //Cb_Prod_Categ.ValueMember = "Category_Name";
                //Cb_Prod_Categ.DataSource = DataTable;
                Cb_Cat_Search.ValueMember = "Category_Name";
                Cb_Cat_Search.DataSource = DataTable;
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Please ensure you have entered the required details correctly.");
            }
        }

        //Filters products by category by populating ProductsGV with products from a selected category
        void FilterByCategory()
        {
            try
            {
                Con.Open();
                string SelectQuery = "select * from ProductTbl where Product_Category='" + Cb_Cat_Search.SelectedValue.ToString() + "'";
                SqlDataAdapter DataAdapter = new SqlDataAdapter(SelectQuery, Con);
                SqlCommandBuilder Builder = new SqlCommandBuilder(DataAdapter);
                var DataSet = new DataSet();
                DataAdapter.Fill(DataSet);
                ProductsGV.DataSource = DataSet.Tables[0];
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Please ensure you have entered the required details correctly.");
            }
        }

        //Populates ProductsGV with all products from ProductTbl
        void PopulateProducts()
        {
            try
            {
                Con.Open();
                string PopulateSelectQuery = "select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(PopulateSelectQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Please ensure you have entered the required details correctly.");
            }
        }

        //Populates product text boxes with corresponding selected data from ProductsGV
        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow SelectedRow = ProductsGV.Rows[e.RowIndex];

            Tb_Prod_Id.Text = SelectedRow.Cells[0].Value.ToString();
            Tb_Prod_Qty.Text = SelectedRow.Cells[2].Value.ToString();
        }

        //Updates product in ProductTbl via ProductID, using data from product text boxes
        private void Btn_Prod_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string EditQuery = "update ProductTbl set Product_Qty='" + Tb_Prod_Qty.Text + "' where Product_Id='" + Tb_Prod_Id.Text + "'";
                SqlCommand cmd = new SqlCommand(EditQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Updated");
                Con.Close();
                PopulateProducts();
            }
            catch
            {
                MessageBox.Show("Please ensure you have entered the required details correctly.");
            }
        }

        //Runs PopulateCategories(), PopulateProducts(), & PopulateSuppliers() functions when the ManageProducts form loads
        //Populates ProductsGV with categories, products and suppliers pulled from ProductTbl & SupplierTbl
        private void ManageProducts_Load(object sender, EventArgs e)
        {
            PopulateCategories();
            PopulateProducts();
        }

        //Runs PopulateProducts() function when clicked
        //Refreshes the ProductsGV, populates with all data from ProductTbl
        private void Btn_Cat_Refresh_Click(object sender, EventArgs e)
        {
            PopulateProducts();
        }

        //Runs FilterByCategory() function when clicked
        //Filters products from ProductTbl by desired category
        private void Btn_Cat_Search_Click(object sender, EventArgs e)
        {
            FilterByCategory();
        }
    }
}
