using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystemPrototype
{
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }
        //Initialises DataTables and establishes database connection
        DataTable OrdersTable = new DataTable();
        DataTable OrdersHistoryTable = new DataTable();
        DataTable ProductsTable = new DataTable();
        DataTable ReOrderProductsTable = new DataTable();
        DataTable SuppliersTable = new DataTable();
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\IMS.mdf" + ";Integrated Security=True;Connect Timeout=30");

        //Initialising order details variables
        int ProductId, OrderId;
        int UnitPrice, TotalPrice, Qty;
        string OrderedProduct = "";
        string SupplierName = "";
        string ProductCategory = "";
        int flag = 0;
        int OrderSum = 0;

        void PopulateLowStockProducts()
        {
            //Populates low stock products in respective data grid view
            string SelectProductQtyQuery = "select Product_ReOrderQtyLimit from ProductQtyLimitTbl";
            SqlCommand cmdSelect = new SqlCommand(SelectProductQtyQuery, Con);
            Con.Open();
            int ReOrderQtyLimit = (int)cmdSelect.ExecuteScalar();
            Con.Close();

            try
            {
                string SelectQuery = "select * from ProductTbl where Product_Qty<='" + ReOrderQtyLimit + "'";
                SqlDataAdapter da = new SqlDataAdapter(SelectQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds_ReOrderProducts = new DataSet();
                Con.Open();
                da.Fill(ds_ReOrderProducts);
                ReOrderProductsGV.DataSource = ds_ReOrderProducts.Tables[0];
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Error populating ReOrderProduct table");
            }
        }
        void PopulateSuppliers()
        {
            //Populates suppliers in respective data grid view table
            try
            {
                Con.Open();
                string SelectQuery = "select * from SupplierTbl";
                SqlDataAdapter da = new SqlDataAdapter(SelectQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds_Suppliers = new DataSet();
                da.Fill(ds_Suppliers);
                SuppliersGV.DataSource = ds_Suppliers.Tables[0];
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Error populating Supplier table");
            }
        }
        void PopulateProducts()
        {
            //Populates products in respective data grid view table
            try
            {
                Con.Open();
                string SelectQuery = "select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(SelectQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds_Products = new DataSet();
                da.Fill(ds_Products);
                ProductsGV.DataSource = ds_Products.Tables[0];
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Error populating Products table");
            }
        }
        void FillCategoryDropdown()
        {
            //Populates category drop down tab with data from database table
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
                Cb_Cat_Search.ValueMember = "Category_Name";
                Cb_Cat_Search.DataSource = DataTable;
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Error populating category drop down");
            }
        }

        private void SuppliersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Populating textboxes when rows/columns are selected
            Tb_Product_Id.Text = ProductsGV.SelectedRows[0].Cells[0].Value.ToString();
            Tb_Product_Name.Text = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            Tb_Product_Qty.Text = ProductsGV.SelectedRows[0].Cells[2].Value.ToString();
            Tb_Product_Price.Text = ProductsGV.SelectedRows[0].Cells[3].Value.ToString();
            Tb_Product_Desc.Text = ProductsGV.SelectedRows[0].Cells[4].Value.ToString();
            Tb_Product_Categ.Text = ProductsGV.SelectedRows[0].Cells[5].Value.ToString();
            Tb_Supplier_Name.Text = ProductsGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Populating textboxes when rows/columns are selected
            Tb_Product_Id.Text = ProductsGV.SelectedRows[0].Cells[0].Value.ToString();
            Tb_Product_Name.Text = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            Tb_Product_Qty.Text = ProductsGV.SelectedRows[0].Cells[2].Value.ToString();
            Tb_Product_Price.Text = ProductsGV.SelectedRows[0].Cells[3].Value.ToString();
            Tb_Product_Desc.Text = ProductsGV.SelectedRows[0].Cells[4].Value.ToString();
            Tb_Product_Categ.Text = ProductsGV.SelectedRows[0].Cells[5].Value.ToString();
            Tb_Supplier_Name.Text = ProductsGV.SelectedRows[0].Cells[6].Value.ToString();

            OrderedProduct = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            SupplierName = SuppliersGV.SelectedRows[0].Cells[0].Value.ToString();
            UnitPrice = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;
        }

        private void Btn_Order_Add_Click(object sender, EventArgs e)
        {
            if ((Tb_Quantity_Id.Text == "") && (Tb_Order_Id.Text == ""))
            {
                MessageBox.Show("Enter product quantity and order ID");
            }
            else if (Tb_Quantity_Id.Text == "")
            {
                MessageBox.Show("Enter product quantity");
            }
            else if (Tb_Order_Id.Text == "")
            {
                MessageBox.Show("Enter order ID");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select a product to add to order");
            }
            else
            {
                //Gets Product_OrderQtyLimit from ProductQtyLimitTbl and assigns to 'UnitQtyLimit' int variable
                string SelectProductQtyQuery = "select Product_OrderQtyLimit from ProductQtyLimitTbl where Product_Id ='" + Tb_Product_Id.Text + "'";
                SqlCommand cmdSelect = new SqlCommand(SelectProductQtyQuery, Con);
                Con.Open();
                int UnitQtyLimit = (int)cmdSelect.ExecuteScalar();
                Con.Close();

                //Setting order details variables using product details
                OrderId = Convert.ToInt32(Tb_Order_Id.Text);
                ProductId = Convert.ToInt32(Tb_Product_Id.Text);
                SupplierName = Tb_Supplier_Name.Text;
                ProductCategory = Tb_Product_Categ.Text;
                Qty = Convert.ToInt32(Tb_Quantity_Id.Text);
                TotalPrice = UnitPrice * Qty;

                //Adds product to OrdersGV if condition is met
                if ((OrdersTable.Rows.Count < 1) && (Qty <= UnitQtyLimit))
                {
                    OrdersTable.Rows.Add(OrderId, ProductId, OrderedProduct, ProductCategory, UnitPrice, Qty, TotalPrice, SupplierName);
                    OrdersGV.DataSource = OrdersTable;

                    OrdersHistoryTable.Rows.Add(OrderId, ProductId, OrderedProduct, ProductCategory, UnitPrice, Qty, TotalPrice, SupplierName);
                    OrdersHistoryGV.DataSource = OrdersHistoryTable;
                    flag = 0;
                    PopulateProducts();
                }
                else
                {
                    MessageBox.Show("Item limit exceeded. Limit: 1 product & less than 100 units per order");
                }
            }
            //Sets total order price
            OrderSum = OrderSum + TotalPrice;
            Lb_TotalAmount.Text = "£" + OrderSum.ToString();
        }

        private void Btn_Insert_Orders_Click(object sender, EventArgs e)
        {
            //Inserting selected order data into OrdersTbl & OrdersHistoryTbl
            if (Tb_Product_Id.Text == "" || Tb_Product_Name.Text == "" || Tb_Product_Qty.Text == "" || Tb_Product_Price.Text == "" || Tb_Product_Desc.Text == "" || Tb_Product_Categ.Text == "" || Tb_Supplier_Name.Text == "" || Lb_TotalAmount.Text == "")
            {
                MessageBox.Show("Error, no selected data to enter");
            }
            else
            {
                Con.Open();
                string OrderInsertQuery = "insert into OrdersTbl values('" + OrderId + "', '" + ProductId + "','" + OrderedProduct + "','" + ProductCategory + "','" + UnitPrice + "','" + Qty + "','" + TotalPrice + "','" + SupplierName + "','" + Dtp_Orders.Text + "')";
                SqlCommand cmd_1 = new SqlCommand(OrderInsertQuery, Con);

                string OrderHistoryInsertQuery = "insert into OrdersHistoryTbl values('" + OrderId + "', '" + ProductId + "','" + OrderedProduct + "','" + ProductCategory + "','" + UnitPrice + "','" + Qty + "','" + TotalPrice + "','" + SupplierName + "','" + Dtp_Orders.Text + "')";
                SqlCommand cmd_2 = new SqlCommand(OrderHistoryInsertQuery, Con);

                cmd_1.ExecuteNonQuery();
                cmd_2.ExecuteNonQuery();
                MessageBox.Show("Order Product Successfully Added");
                Con.Close();
                OrdersGV.Columns.Clear();
            }
        }

        private void Btn_View_Orders_Click(object sender, EventArgs e)
        {
            ViewOrders View = new ViewOrders();
            View.Show();
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            //SuppliersGV/Table naming
            SuppliersTable.Columns.Add("Company Name", typeof(string));
            SuppliersTable.Columns.Add("Contact Number", typeof(int));
            SuppliersGV.DataSource = SuppliersTable;

            //ReOrderProductsGV/Table naming
            ReOrderProductsTable.Columns.Add("ID", typeof(int));
            ReOrderProductsTable.Columns.Add("Name", typeof(string));
            ReOrderProductsTable.Columns.Add("Quantity", typeof(int));
            ReOrderProductsTable.Columns.Add("Price", typeof(int));
            ReOrderProductsTable.Columns.Add("Description", typeof(string));
            ReOrderProductsTable.Columns.Add("Category", typeof(string));
            ReOrderProductsTable.Columns.Add("Supplier", typeof(string));
            ReOrderProductsGV.DataSource = ReOrderProductsTable;

            //ProductsGV/Table naming
            ProductsTable.Columns.Add("ID", typeof(int));
            ProductsTable.Columns.Add("Name", typeof(string));
            ProductsTable.Columns.Add("Quantity", typeof(int));
            ProductsTable.Columns.Add("Price", typeof(int));
            ProductsTable.Columns.Add("Description", typeof(string));
            ProductsTable.Columns.Add("Category", typeof(string));
            ProductsTable.Columns.Add("Supplier", typeof(string));
            ProductsGV.DataSource = ProductsTable;

            //OrdersGV/Table naming
            OrdersTable.Columns.Add("Order ID", typeof(int));
            OrdersTable.Columns.Add("Product ID", typeof(int));
            OrdersTable.Columns.Add("Name", typeof(string));
            OrdersTable.Columns.Add("Category", typeof(string));
            OrdersTable.Columns.Add("Price", typeof(int));
            OrdersTable.Columns.Add("Quantity", typeof(int));
            OrdersTable.Columns.Add("Total Price", typeof(int));
            OrdersTable.Columns.Add("Supplier", typeof(string));
            OrdersGV.DataSource = OrdersTable;

            //OrdersHistoryGV/Table naming
            OrdersHistoryTable.Columns.Add("Order ID", typeof(int));
            OrdersHistoryTable.Columns.Add("Product ID", typeof(int));
            OrdersHistoryTable.Columns.Add("Name", typeof(string));
            OrdersHistoryTable.Columns.Add("Category", typeof(string));
            OrdersHistoryTable.Columns.Add("Price", typeof(int));
            OrdersHistoryTable.Columns.Add("Quantity", typeof(int));
            OrdersHistoryTable.Columns.Add("Total Price", typeof(int));
            OrdersHistoryTable.Columns.Add("Supplier", typeof(string));
            OrdersHistoryGV.DataSource = OrdersHistoryTable;

            //Populating all DataGridViews and table columns
            PopulateSuppliers();
            PopulateProducts();
            FillCategoryDropdown();
            PopulateLowStockProducts();
        }

        private void Cb_Cat_Search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //Filtering products in ProductsGV by chosen Product_Category
                Con.Open();
                string SelectQuery = "select * from ProductTbl where Product_Category='" + Cb_Cat_Search.SelectedValue.ToString() + "'";
                SqlDataAdapter DataAdapter = new SqlDataAdapter(SelectQuery, Con);
                SqlCommandBuilder Builder = new SqlCommandBuilder(DataAdapter);
                var ds_CategSearch = new DataSet();
                DataAdapter.Fill(ds_CategSearch);
                ProductsGV.DataSource = ds_CategSearch.Tables[0];
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Error selecting product category");
            }
        }
    }
}
