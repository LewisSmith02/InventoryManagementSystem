using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystemPrototype
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string database_filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "IMS.mdf");

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\UniversityWork\year1\software-systems\Prototype\InventoryManagementSystem (Project)\InventoryManagementSystemPrototype\IMS.mdf;Integrated Security=True;Connect Timeout=30");

        //Toggles 'Show Password'
        private void Cb_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_ShowPass.Checked == false)
            {
                Tb_Password.UseSystemPasswordChar = true;
            }
            else
            {
                Tb_Password.UseSystemPasswordChar = false;
            }
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            //Authenticates login, checks user inputted details against UserTbl details
            //Opens corresponding user role homepage
            Con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("Select Count(*) from UserTbl where User_Name ='" + Tb_Username.Text + "' and User_Password = '" + Tb_Password.Text + "' and User_Role = '" + Cb_SelectRole.Text + "'", Con);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            //If selected role is "Senior Inventory Manager (Admin)" and login details are correct, open SIM page
            if ((DT.Rows[0][0].ToString() == "1") && (Cb_SelectRole.Text == "Senior Inventory Manager (Admin)"))
            {
                HomePageSIM HPSIM = new HomePageSIM();
                HPSIM.Show();
                this.Hide();
            }
            //If selected role is "Inventory Manager" and login details are correct, open IM page
            else if ((DT.Rows[0][0].ToString() == "1") && (Cb_SelectRole.Text == "Inventory Manager"))
            {
                HomePageIM HPIM = new HomePageIM();
                HPIM.Show();
                this.Hide();
            }
            //If selected role is "Employee" and login details are correct, open employee page
            else if ((DT.Rows[0][0].ToString() == "1") && (Cb_SelectRole.Text == "Employee"))
            {
                HomePageEMP HPEMP = new HomePageEMP();
                HPEMP.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect role, username or password");
            }
            Con.Close();
        }

        //Clears any inputted text from login fields
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Tb_Username.Text = "";
            Tb_Password.Text = "";
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}