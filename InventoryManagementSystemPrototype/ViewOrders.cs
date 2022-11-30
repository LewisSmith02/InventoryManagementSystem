using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystemPrototype
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\IMS.mdf" + ";Integrated Security=True;Connect Timeout=30");

        //Populates the PendingOrdersTable, OrdersGV using data pulled from the OrderTbl
        void FillPendingOrdersTable()
        {
            try
            {
                Con.Open();
                string PopulateSelectQuery = "select * from OrdersTbl";
                SqlDataAdapter da = new SqlDataAdapter(PopulateSelectQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrdersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Error filling pending orders table");
            }
        }

        //Populates the OrderHistoryTable, OrderHistoryGV using data pulled from the OrderHistoryTbl
        void FillOrdersHistoryTable()
        {
            try
            {
                Con.Open();
                string PopulateSelectQuery = "select * from OrdersHistoryTbl";
                SqlDataAdapter da = new SqlDataAdapter(PopulateSelectQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrderHistoryGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Error filling orders history table");
            }
        }

        //Populates PendingOrdersTable & OrdersHistoryTable when ViewOrder form loads
        private void ViewOrders_Load(object sender, EventArgs e)
        {
            FillPendingOrdersTable();
            FillOrdersHistoryTable();
        }

        //Populates the PendingOrderID text box when OrdersGV cell is clicked 
        private void OrdersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Tb_PendingOrderId.Text = OrdersGV.SelectedRows[0].Cells[0].Value.ToString();
        }
        //Populates the OrderHistoryID text box when the OrderHistoryGV is clicked
        private void OrderHistoryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Tb_OrderHistoryID.Text = OrderHistoryGV.SelectedRows[0].Cells[0].Value.ToString();
        }

        //Runs CompleteOrder() function when CompleteOrder button is clicked
        private void Btn_CompleteOrder_Click(object sender, EventArgs e)
        {
            CompleteOrder();
        }

        //User completes order and confirms choice
        //Product quantity is updated in ProductTbl using newly calculated NewQty (CurrentProdQty + OrderQty)
        //Order is removed from OrderTbl
        //PendingOrderTable is refreshed

        void CompleteOrder()
        {
            int OrderId = 0;
            int ProductId = 0;
            int NewQty = 0;
            int OrderQty = 0;
            ProductId = Convert.ToInt32(OrdersGV.SelectedRows[0].Cells[1].Value.ToString());
            OrderQty = Convert.ToInt32(OrdersGV.SelectedRows[0].Cells[5].Value.ToString());
            OrderId = Convert.ToInt32(OrdersGV.SelectedRows[0].Cells[0].Value.ToString());

            var confirmResult = MessageBox.Show("Are you sure you want to confirm this order?",
                         "Confirm Order",
                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                //Selecting product quantity from ProductTbl and storing in variable
                string SelectProductQtyQuery = "select Product_Qty from ProductTbl where Product_Id ='" + ProductId + "'";
                SqlCommand cmdSelect = new SqlCommand(SelectProductQtyQuery, Con);
                Con.Open();
                int CurrentProdQty = (int)cmdSelect.ExecuteScalar();

                //New product quantity calculated
                NewQty = CurrentProdQty + OrderQty;

                //Updating product quantity from ProductTbl using stored variable
                string UpdateQuery = "update ProductTbl set Product_Qty = " + NewQty + " where Product_Id=" + ProductId + ";";
                SqlCommand cmdUpdate = new SqlCommand(UpdateQuery, Con);
                cmdUpdate.ExecuteNonQuery();

                //Removing order from OrdersTbl after completed
                string DeleteOrderQuery = "delete from OrdersTbl where Order_Id = '" + OrderId + "'";
                SqlCommand cmdDelete = new SqlCommand(DeleteOrderQuery, Con);
                cmdDelete.ExecuteNonQuery();

                Con.Close();
                MessageBox.Show("Product quantity updated in database, order removed from pending list");

                FillPendingOrdersTable();
            }
            else
            {

            }
        }

        //Runs RemoveOrder() function
        private void Btn_CancelOrder_Click(object sender, EventArgs e)
        {
            RemoveOrder();
        }

        //Order is removed from OrderTbl, no updating of ProductQty is done
        void RemoveOrder()
        {
            int OrderId = 0;
            OrderId = Convert.ToInt32(OrdersGV.SelectedRows[0].Cells[0].Value.ToString());

            var confirmResult = MessageBox.Show("Are you sure you want to delete this order?",
                                     "Delete Order",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Con.Open();
                string DeleteOrderQuery = "delete from OrdersTbl where Order_Id = '" + OrderId + "'";
                SqlCommand cmdDelete = new SqlCommand(DeleteOrderQuery, Con);
                cmdDelete.ExecuteNonQuery();
                Con.Close();
                FillPendingOrdersTable();
            }
            else
            {

            }
        }

        //Removes orders from OrdersHistoryTbl using OrderId, can be filtered
        void RemoveOrderHistory()
        {
            int OrderId = 0;
            OrderId = Convert.ToInt32(OrderHistoryGV.SelectedRows[0].Cells[0].Value.ToString());

            var confirmResult = MessageBox.Show("Are you sure you want to delete this order?",
                                     "Delete Order",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Con.Open();
                string DeleteOrderQuery = "delete from OrdersHistoryTbl where Order_Id = '" + OrderId + "'";
                SqlCommand cmdDelete = new SqlCommand(DeleteOrderQuery, Con);
                cmdDelete.ExecuteNonQuery();
                Con.Close();
                FillOrdersHistoryTable();
            }
            else
            {

            }
        }

        //Filters orders history by OrderId
        void SearchOrderHistoryID()
        {
            int OrderId = 0;
            OrderId = Convert.ToInt32(Tb_OrderHistoryID.Text);

            Con.Open();
            string SearchOrderQuery = "select * from OrdersHistoryTbl where Order_Id = '" + OrderId + "'";
            SqlDataAdapter da = new SqlDataAdapter(SearchOrderQuery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            OrderHistoryGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        //Filters pending orders by OrderId
        void SearchPendingOrderID()
        {
            int OrderId = 0;
            OrderId = Convert.ToInt32(Tb_PendingOrderId.Text);

            Con.Open();
            string SearchOrderQuery = "select * from OrdersTbl where Order_Id = '" + OrderId + "'";
            SqlDataAdapter da = new SqlDataAdapter(SearchOrderQuery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            OrdersGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        //Removes order history
        private void Btn_RemoveOrderHistory_Click(object sender, EventArgs e)
        {
            RemoveOrderHistory();
        }

        //Filters OrderHistory by OrderId
        private void Btn_SearchOrderHistory_Click(object sender, EventArgs e)
        {
            SearchOrderHistoryID();
        }

        //Populates OrdersHistoryTable fully
        //Clears OrderHistoryID text box used to filter by ID
        private void Btn_OrderIDSearchRefresh_Click(object sender, EventArgs e)
        {
            FillOrdersHistoryTable();
            Tb_OrderHistoryID.Clear();
        }

        //Searches for pending order by ID
        private void Btn_SearchPendingOrders_Click(object sender, EventArgs e)
        {
            SearchPendingOrderID();
        }

        //Populates PendingOrdersTable fully
        //Clears PendingOrderID text box used to filter by ID
        private void Btn_RefreshPendingOrders_Click(object sender, EventArgs e)
        {
            FillPendingOrdersTable();
            Tb_PendingOrderId.Clear();
        }
    }
}
