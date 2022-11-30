using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystemPrototype
{
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\IMS.mdf" + ";Integrated Security=True;Connect Timeout=30");

        //Runs both PopulateCategoryList() & PopulateOrderQtyandReOrderLimitList() function when ManageCategories form loads
        //PopulateCategoryList() function populates the CategoryGV
        //PopulateOrderQtyandReOrderLimitList() function populates the ProductOrderLimitGV
        private void ManageCategories_Load(object sender, EventArgs e)
        {
            PopulateCategoryList();
            PopulateOrderQtyandReOrderLimitList();
        }

        //----------CATEGORY----------

        //Populates CategoryGV using data pulled from CategoryTbl
        void PopulateCategoryList()
        {
            try
            {
                Con.Open();
                string SelectQuery = "select * from CategoryTbl";
                SqlDataAdapter da = new SqlDataAdapter(SelectQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CategoriesGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Error retrieving category data.");
            }
        }

        //Inserts new category into CategoryTbl, CategoryDesc & CategoryName required
        private void Btn_Categ_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string InsertQuery = "insert into CategoryTbl values('" + Tb_Categ_Name.Text + "','" + Tb_Categ_Desc.Text + "'";
                SqlCommand cmd = new SqlCommand(InsertQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Added");
                Con.Close();
                PopulateCategoryList();
            }
            catch
            {
                MessageBox.Show("Please ensure you have entered the required details correctly.");
            }
        }

        //Deletes category from CategoryTbl using CategoryName
        private void Btn_Categ_Delete_Click(object sender, EventArgs e)
        {
            if (Tb_Categ_Name.Text == "")
            {
                MessageBox.Show("Enter the Category Name");
            }
            else
            {
                Con.Open();
                string DeleteQuery = "delete from CategoryTbl where Category_Name='" + Tb_Categ_Name.Text + "'";
                SqlCommand cmd = new SqlCommand(DeleteQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Deleted");
                Con.Close();
                PopulateCategoryList();
            }
        }

        //Updates categories in CategoryTbl using CategoryID
        private void Btn_Categ_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string EditQuery = "update CategoryTbl set Category_Desc='" + Tb_Categ_Desc.Text + "' where Category_Name='" + Tb_Categ_Name.Text + "'";
                SqlCommand cmd = new SqlCommand(EditQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Updated");
                Con.Close();
                PopulateCategoryList();
            }
            catch
            {
                MessageBox.Show("Please ensure you have entered the required details correctly.");
            }
        }

        //Populates category name and id text boxes using data from the CategoryGV when rows are selected
        private void CategoryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Tb_Categ_Name.Text = CategoriesGV.SelectedRows[0].Cells[0].Value.ToString();
            Tb_Categ_Desc.Text = CategoriesGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Btn_CategoryGV_Refresh_Click(object sender, EventArgs e)
        {
            PopulateCategoryList();
            MessageBox.Show("CategoryGV Refreshed");
        }

        //----------REORDERQTY----------

        //Populates ProductOrderLimitGV using data from ProductQtyLimitTbl
        void PopulateOrderQtyandReOrderLimitList()
        {
            try
            {
                Con.Open();
                string SelectQuery = "select * from ProductQtyLimitTbl";
                SqlDataAdapter da = new SqlDataAdapter(SelectQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductOrderLimitGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Error retrieving qtylimit data.");
            }
        }

        //Populates ProductName, ProductID, ProductQtyLimit, & ProductReOrderQtyLimit using data from ProductOrderLimitGV when rows are selected
        private void ProductOrderLimitGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Tb_ProductId.Text = ProductOrderLimitGV.SelectedRows[0].Cells[0].Value.ToString();
            Tb_Prod_Name.Text = ProductOrderLimitGV.SelectedRows[0].Cells[2].Value.ToString();
            Tb_ProdQtyLimit.Text = ProductOrderLimitGV.SelectedRows[0].Cells[1].Value.ToString();
            Tb_ProdReOrderQtyLimit.Text = ProductOrderLimitGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        //Updates Product_OrderQtyLimit & Product_ReOrderQtyLimit in ProductQtyLimitTbl using ProductID
        private void Btn_ProdQtyLimitUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string EditQuery = "update ProductQtyLimitTbl set Product_OrderQtyLimit='" + Tb_ProdQtyLimit.Text + "', Product_ReOrderQtyLimit='" + Tb_ProdReOrderQtyLimit.Text + "' where Product_Id='" + Tb_ProductId.Text + "'";
                SqlCommand cmd = new SqlCommand(EditQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Order Quantity Limit Successfully Updated");
                Con.Close();
                PopulateOrderQtyandReOrderLimitList();
            }
            catch
            {
                MessageBox.Show("Error updating data.");
            }
        }
        private void Btn_ProductOrderLimitGV_Refresh_Click(object sender, EventArgs e)
        {
            PopulateOrderQtyandReOrderLimitList();
            MessageBox.Show("QtyLimitGV Refreshed");
        }
    }
}
