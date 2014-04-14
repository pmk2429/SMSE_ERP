using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Deepak_Xerox.DAL;
using Deepak_Xerox.Entities;
using Deepak_Xerox.Properties;

namespace Deepak_Xerox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=P-PC\\SQLEXPRESS;Initial Catalog=DeepakXerox;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT Customer_Details.first_name, Customer_Details.last_name, Customer_Details.name_of_com from Customer_Details INNER JOIN Customer_Order ON Customer_Details.customer_id = Customer_Order.Customer_Id",con);
            DataTable dt = new DataTable();
            da.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                dgv_practice.DataSource = dt;
                dgv_practice.Show();
            }
            else
            {
                MessageBox.Show("No Data.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
