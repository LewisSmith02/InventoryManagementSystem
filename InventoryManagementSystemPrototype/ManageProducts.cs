using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystemPrototype
{
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\IMS.mdf" + ";Integrated Security=True;Connect Timeout=30");

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
                Cb_Prod_Categ.ValueMember = "Category_Name";
                Cb_Prod_Categ.DataSource = DataTable;
                Cb_Cat_Search.ValueMember = "Category_Name";
                Cb_Cat_Search.DataSource = DataTable;
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Please ensure you have entered the required details correctly.");
            }
        }

        //Populates SuppliersGV using data pulled from SupplierTbl
        void PopulateSuppliers()
        {
            string SelectQuery = "select * from SupplierTbl";
            SqlCommand cmd = new SqlCommand(SelectQuery, Con);
            SqlDataReader SqlDataReader;
            try
            {
                Con.Open();
                DataTable DataTable = new DataTable();
                DataTable.Columns.Add("Supplier_Name", typeof(string));
                SqlDataReader = cmd.ExecuteReader();
                DataTable.Load(SqlDataReader);
                Cb_Prod_Supplier.ValueMember = "Supplier_Name";
                Cb_Prod_Supplier.DataSource = DataTable;
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

        //Adds selected product to ProductsGV using data from text boxes
        private void Btn_Product_Add_Click(object sender, EventArgs e)
        {
            try
            {
                //Setting order & re-order limits
                int ProdQtyLimit = 100;
                int ProdReOrderQtyLimit = 50;

                //Inserts new product into ProductTbl
                Con.Open();
                string ProductTblInsertQuery = "insert into ProductTbl values('" + Tb_Prod_Id.Text + "','" + Tb_Prod_Name.Text + "','" + Tb_Prod_Qty.Text + "','" + Tb_Prod_Price.Text + "','" + Tb_Prod_Desc.Text + "','" + Cb_Prod_Categ.SelectedValue.ToString() + "','" + Cb_Prod_Supplier.SelectedValue.ToString() + "')";
                SqlCommand cmd_1 = new SqlCommand(ProductTblInsertQuery, Con);
                cmd_1.ExecuteNonQuery();

                //Inserts new ProductQtyLimit into ProductQtyLimitTbl
                string ProductQtyLimitTblInsertQuery = "insert into ProductQtyLimitTbl values('" + Tb_Prod_Id.Text + "','" + ProdQtyLimit.ToString() + "','" + Tb_Prod_Name.Text + "', '" + ProdReOrderQtyLimit.ToString() + "')";
                SqlCommand cmd_2 = new SqlCommand(ProductQtyLimitTblInsertQuery, Con);
                cmd_2.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added");
                Con.Close();
                PopulateProducts();
            }
            catch
            {
                MessageBox.Show("Please ensure you have entered the required details correctly. Characters and integers only, any special character(s) will prevent your input from being processed.");
            }
        }

        //Deletes product from ProductTbl & ProductQtyLimitTbl via Product ID
        private void Btn_Prod_Delete_Click(object sender, EventArgs e)
        {
            if (Tb_Prod_Id.Text == "")
            {
                MessageBox.Show("Enter the Product ID");
            }
            else
            {
                Con.Open();
                string ProductTblDeleteQuery = "delete from ProductTbl where Product_Id='" + Tb_Prod_Id.Text + "'";
                SqlCommand cmd_1 = new SqlCommand(ProductTblDeleteQuery, Con);
                cmd_1.ExecuteNonQuery();
                string ProductQtyLimitTblDeleteQuery = "delete from ProductQtyLimitTbl where Product_Id='" + Tb_Prod_Id.Text + "'";
                SqlCommand cmd_2 = new SqlCommand(ProductQtyLimitTblDeleteQuery, Con);
                cmd_2.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Deleted");
                Con.Close();
                PopulateProducts();
            }
        }

        //Populates product text boxes with corresponding selected data from ProductsGV
        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Tb_Prod_Id.Text = ProductsGV.SelectedRows[0].Cells[0].Value.ToString();
            Tb_Prod_Name.Text = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            Tb_Prod_Qty.Text = ProductsGV.SelectedRows[0].Cells[2].Value.ToString();
            Tb_Prod_Price.Text = ProductsGV.SelectedRows[0].Cells[3].Value.ToString();
            Tb_Prod_Desc.Text = ProductsGV.SelectedRows[0].Cells[4].Value.ToString();
            Cb_Prod_Categ.SelectedValue = ProductsGV.SelectedRows[0].Cells[5].Value.ToString();
            Cb_Prod_Supplier.SelectedValue = ProductsGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        //Updates product in ProductTbl via ProductID, using data from product text boxes
        private void Btn_Prod_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string EditQuery = "update ProductTbl set Product_Name='" + Tb_Prod_Name.Text + "',Product_Qty='" + Tb_Prod_Qty.Text + "',Product_Price='" + Tb_Prod_Price.Text + "',Product_Desc='" + Tb_Prod_Desc.Text + "',Product_Category='" + Cb_Prod_Categ.SelectedValue.ToString() + "',Product_SupplierName='" + Cb_Prod_Supplier.SelectedValue.ToString() + "' where Product_Id='" + Tb_Prod_Id.Text + "'";
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
            PopulateSuppliers();
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
