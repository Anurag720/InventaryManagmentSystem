//stocks.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class stocks : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\EmpDb.mdf;Integrated Security=True;Connect Timeout=30");
        public stocks()
        {
            InitializeComponent();
        }

        public void displayData()
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stocks";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            recordList.DataSource = dt;

            sqlcon.Close();
        }

        private void stocks_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO stocks VALUES('" + productID.Text + "', '" + productName.Text + "', '" + price.Text + "', '" + stockNum.Text + "')";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("Product added to inventory.");

                productID.Text = " ";
                productName.Text = " ";
                price.Text = " ";
                stockNum.Text = " ";

                displayData();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Product serial exists.");
            }
            catch (System.InvalidOperationException)
            {
                this.Hide();
                stocks OBJstocks = new stocks();
                OBJstocks.Show();
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE stocks set ProductName = '" + productName.Text + "', Price = '" + price.Text + "', Stock = '" + stockNum.Text + "' WHERE SerialID = '" + productID.Text + "'";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("Product updated.");

                productID.Text = " ";
                productName.Text = " ";
                price.Text = " ";
                stockNum.Text = " ";

                displayData();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Some input(s) is/are invalid.");
            }
            catch (System.InvalidOperationException)
            {
                this.Hide();
                stocks OBJstocks = new stocks();
                OBJstocks.Show();
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM stocks WHERE serialID = '" + searchID.Text + "'";
                cmd.ExecuteNonQuery();
                

                MessageBox.Show("Product deleted from inventory.");

                
                sqlcon.Close();

                searchID.Text = " ";
                displayData();
                
            }
            catch (System.Data.SqlClient.SqlException)
            {
                //catch.accidental.sqlEx
            }
            catch (System.InvalidOperationException)
            {
                this.Hide();
                stocks OBJstocks = new stocks();
                OBJstocks.Show();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stocks where SerialID = '" + searchID.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            recordList.DataSource = dt;

            sqlcon.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            displayData();
            searchID.Text = "";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm OBJmainForm = new mainForm();
            OBJmainForm.Show();
        }
    }
}
