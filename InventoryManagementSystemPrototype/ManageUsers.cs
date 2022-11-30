using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystemPrototype
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\IMS.mdf" + ";Integrated Security=True;Connect Timeout=30");
        
        //Populates UsersGV with data pulled from UserTbl
        void PopulateUsers()
        {
            try
            {
                Con.Open();
                string SelectQuery = "select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(SelectQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Please ensure you have entered the required details correctly.");
            }
        }

        //Inserts new user into UserTbl with the below values
        private void Btn_User_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string InsertQuery = "insert into UserTbl values('" + Tb_User_Id.Text + "','" + Tb_User_Name.Text + "','" + Tb_User_Password.Text + "', '" + Cb_User_Role.Text + "')";
                SqlCommand cmd = new SqlCommand(InsertQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
                Con.Close();
                PopulateUsers();
            }
            catch
            {
                MessageBox.Show("Please ensure you have entered the required details correctly.");
            }
        }

        //Populates the UsersGV when ManageUsers form is loaded
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateUsers();
        }

        //Deletes user from UserTbl using User_Id
        private void Btn_User_Delete_Click(object sender, EventArgs e)
        {
            if (Tb_User_Id.Text == "")
            {
                MessageBox.Show("Enters the User's ID");
            }
            else
            {
                Con.Open();
                string DeleteQuery = "delete from UserTbl where User_Id='" + Tb_User_Id.Text + "'";
                SqlCommand cmd = new SqlCommand(DeleteQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                Con.Close();
                PopulateUsers();
            }
        }

        //Populates text boxes using data from UserGV when row is selected
        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Tb_User_Id.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            Tb_User_Name.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            Tb_User_Password.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
            Cb_User_Role.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        //Updates UserTbl, edits values of variables User_Name, User_Password & User_Role
        private void Btn_User_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string EditQuery = "update UserTbl set User_Name='" + Tb_User_Name.Text + "',User_Password='" + Tb_User_Password.Text + "',User_Role='" + Cb_User_Role.Text + "' where User_Id='" + Tb_User_Id.Text + "'";
                SqlCommand cmd = new SqlCommand(EditQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
                Con.Close();
                PopulateUsers();
            }
            catch
            {
                MessageBox.Show("Please ensure you have entered the required details correctly.");
            }
        }
    }
}
