//orders.cs

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
    public partial class orders : Form
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\EmpDb.mdf;Integrated Security=True;Connect Timeout=30");

        public orders()
        {
            InitializeComponent();
        }
        public void displayData()
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from orders";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            recordList.DataSource = dt;

            sqlcon.Close();
        }

        private void orders_Load(object sender, EventArgs e)
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
                cmd.CommandText = "INSERT INTO oders VALUES('" + orderNumber.Text + "', '" + customerName.Text + "', '" + dateOfPurchase.Text + "', '" + price.Text + "', '" + orderStatus.Text + "')";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("Order placed.");

                orderNumber.Text = " ";
                customerName.Text = " ";
                price.Text = " ";
                orderStatus.Text = " ";

                displayData();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("One or more input(s) is/are invalid.");
            }
            catch (System.InvalidOperationException)
            {
                this.Hide();
                orders OBJorders = new orders();
                OBJorders.Show();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE oders set CustomerName = '" + customerName.Text + "', DateofPurchase = '" + dateOfPurchase.Text + "', Price = '" + price.Text + "', Status = '" + orderStatus.Text + "' WHERE OrderNumber = '" + orderNumber.Text + "'";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("Order updated.");

                orderNumber.Text = " ";
                customerName.Text = " ";
                price.Text = " ";
                orderStatus.Text = " ";

                displayData();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("One or more input(s) is/are invalid.");
            }
            catch (System.InvalidOperationException)
            {
                this.Hide();
                orders OBJorders = new orders();
                OBJorders.Show();
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM oders WHERE OrderNumber = '" + searchOrder.Text + "'";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("Order record deleted.");

                orderNumber.Text = " ";
                customerName.Text = " ";
                price.Text = " ";
                orderStatus.Text = " ";

                displayData();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("One or more input(s) is/are invalid.");
            }
            catch (System.InvalidOperationException)
            {
                this.Hide();
                orders OBJorders = new orders();
                OBJorders.Show();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from oders where OrderNumber = '" + searchOrder.Text + "'";
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
            searchOrder.Text = " ";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm OBJmainForm = new mainForm();
            OBJmainForm.Show();
        }
    }
}
