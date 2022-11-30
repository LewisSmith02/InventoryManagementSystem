using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystemPrototype
{
    public partial class ManageSuppliers : Form
    {
        public ManageSuppliers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\IMS.mdf" + ";Integrated Security=True;Connect Timeout=30");
        
        //Populates SuppliersGV with data from SupplierTbl
        void PopulateSuppliers()
        {
            try
            {
                Con.Open();
                string SelectFromSupplierTbl_Query = "select * from SupplierTbl";
                SqlDataAdapter da = new SqlDataAdapter(SelectFromSupplierTbl_Query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                SuppliersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Please ensure you have entered the required details correctly.");
            }
        }

        //Inserts supplier information values from text boxes into SuppliersTbl
        private void Btn_Supplier_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string InsertIntoSupplierTbl_Query = "insert into SupplierTbl values('" + Tb_Supplier_Name.Text + "','" + Tb_Supplier_Number.Text + "')";
                SqlCommand cmd = new SqlCommand(InsertIntoSupplierTbl_Query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supplier Successfully Added");
                Con.Close();
                PopulateSuppliers();
            }
            catch
            {
                MessageBox.Show("Please ensure you have entered the required details correctly.");
            }
        }

        //Populates SuppliersGV when ManageSuppliers form loads
        private void ManageSuppliers_Load(object sender, EventArgs e)
        {
            PopulateSuppliers();
        }

        //Deletes supplier from SupplierTbl and all owned products from ProductTbl using Supplier_Name
        private void Btn_Supplier_Delete_Click(object sender, EventArgs e)
        {
            if (Tb_Supplier_Name.Text == "")
            {
                MessageBox.Show("Enters the Supplier's name");
            }
            else
            {
                Con.Open();
                string DeleteFromSupplierTbl_Query = "delete from SupplierTbl where Supplier_Name='" + Tb_Supplier_Name.Text + "'";
                string DeleteFromProductsTbl_Query = "delete from ProductTbl where Product_SupplierName='" + Tb_Supplier_Name.Text + "'";
                SqlCommand DelSupplierFromSupplierTbl_cmd = new SqlCommand(DeleteFromSupplierTbl_Query, Con);
                SqlCommand DelProductFromProductsTbl_cmd = new SqlCommand(DeleteFromProductsTbl_Query, Con);

                DelSupplierFromSupplierTbl_cmd.ExecuteNonQuery();
                DelProductFromProductsTbl_cmd.ExecuteNonQuery();
                MessageBox.Show("Supplier & Products Successfully Deleted");
                Con.Close();
                PopulateSuppliers();
            }
        }

        //Populates text boxes with respective supplier data pulled from SuppliersGV
        private void SuppliersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Tb_Supplier_Name.Text = SuppliersGV.SelectedRows[0].Cells[0].Value.ToString();
            Tb_Supplier_Number.Text = SuppliersGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        //Updates SupplierTbl, editing supplier name and number
        private void Btn_Supplier_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string UpdateSupplierTbl_Query = "update SupplierTbl set Supplier_Number='" + Tb_Supplier_Number.Text + "' where Supplier_Name='" + Tb_Supplier_Name.Text + "'";
                SqlCommand cmd = new SqlCommand(UpdateSupplierTbl_Query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supplier Successfully Updated");
                Con.Close();
                PopulateSuppliers();
            }
            catch
            {
                MessageBox.Show("Please ensure you have entered the required details correctly.");
            }
        }
    }
}
