//logIn.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventorySystem
{
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\EmpDb.mdf;Integrated Security=True;Connect Timeout=30");
                string query = "Select count (*) from userLogin Where employeeNumber = '" + employeeNumber.Text + "' and password = '" + password.Text + "'"; 
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    mainForm OBJmainForm = new mainForm();
                    OBJmainForm.Show();   
                }
                else
                {
                    MessageBox.Show("Check your Employee Number and Password.", "Warning!");
                }
            }catch(System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("SQL Connection Error", "Warning!");
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void logIn_Load(object sender, EventArgs e)
        {

        }
    }
}
