using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Deepak_Xerox.DAL;
using Deepak_Xerox.Entities;
using Deepak_Xerox.Properties;
using Deepak_Xerox.DeepakXeroxDataSourceTableAdapters;


namespace Deepak_Xerox
{
    public partial class View_Billing : Form
    {
        Order order;

        public View_Billing()
        {
            InitializeComponent();
        }


        private void btn_searchorder_Click(object sender, EventArgs e)
        {
            if (txt_searchfield.Tag != null)
            {
                //OrderManager om;
                //new OrderManager().GenerateOrderNo(dtp_startdate.Value.Month, dtp_startdate.Value.Year);
                string txtvalue = txt_searchfield.Text;
                if (order == null)
                    order = new Order();
                order.CustomerId = int.Parse(txt_searchfield.Tag.ToString()); //new OrderManager().GetCustId(cb_search.SelectedItem.ToString(), txtvalue);

                DataTable dt = new OrderManager().GetData(dtp_startdate.Value.Date, dtp_enddate.Value.Date, cb_search.Text, txt_searchfield.Text, order.CustomerId);

                dgv_order.DataSource = dt;
                dgv_order.Columns[0].ReadOnly = true;
            }
        }

        private void dgv_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                string txtval = txt_searchfield.Text;
                if (order == null)
                    order = new Order();


                order.CustomerId = new OrderManager().GetCustId(cb_search.SelectedItem.ToString(), txtval);

                //Edit
                if (e.ColumnIndex == 0)
                {
                    Personal_Details pd = new Personal_Details();
                    pd.UpdateCustomer(order.CustomerId);
                    pd.UpdateOrder(order.CustomerId);
                    pd.ShowDialog();

                } //Delete
                else if (e.ColumnIndex == 1)
                {

                }
            }
        }


        private void btn_print_Click(object sender, EventArgs e)
        {

            string txtvalue = txt_searchfield.Text;
            if (order == null)
                order = new Order();

            order.CustomerId = new OrderManager().GetCustId(cb_search.SelectedItem.ToString(), txtvalue);

            //int custid = Convert.ToInt32(order.CustomerId);
            if (order.CustomerId > 0)
            {
                frmReportViewer frv = new frmReportViewer(order.CustomerId);
                frv.Show();
            }
            else
            {
                MessageBox.Show("Please specify the required value!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void View_Billing_Load(object sender, EventArgs e)
        {


        }

        private void txt_searchfield_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchfield.TextLength > 0)
            {
                //AutoCompleteStringCollection namecoll = new AutoCompleteStringCollection();
                //string query = "SELECT distinct(first_name+''+last_name)AS name from Customer_Details where first_name LIKE @name OR last_name LIKE @name";
                //Customer cs = new CustomerManager().GetSpecificData(query);

                txt_searchfield.AutoCompleteSource = AutoCompleteSource.None;
                txt_searchfield.AutoCompleteMode = AutoCompleteMode.None;
                listBox1.Visible = true;
                DataTable dt = new DataTable();
                if (cb_search.SelectedItem.ToString() == "First_Name" || cb_search.SelectedItem.ToString() == "Last_Name")
                {
                    string query = string.Format("SELECT distinct(first_name+' '+last_name)AS name, customer_id from Customer_Details where first_name LIKE '{0}%' OR last_name LIKE '{0}%'", txt_searchfield.Text);
                    dt = new ConnectionManager().ExecuteGetDataTable(query);
                    listBox1.DisplayMember = dt.Columns[0].ColumnName;
                }

                //AutoCompleteStringCollection namecoll = new AutoCompleteStringCollection();
                //List<string> lst = new List<string>();
                //for (int i = 0; i < dt.Rows.Count; i++)
                //    lst.Add(dt.Rows[i][0].ToString());
                //namecoll.AddRange(lst.ToArray());
                //txt_searchfield.AutoCompleteCustomSource = namecoll

                if (cb_search.SelectedItem.ToString() == "Mobile Number")
                {
                    string query = string.Format("SELECT distinct mobile, customer_id from Customer_Details WHERE mobile LIKE '{0}%'", txt_searchfield.Text);
                    dt = new ConnectionManager().ExecuteGetDataTable(query);
                    listBox1.DisplayMember = dt.Columns[0].ColumnName;
                }
                if (cb_search.SelectedItem.ToString() == "Company Name")
                {
                    string query = string.Format("SELECT distinct name_of_com, customer_id from Customer_Details where name_of_com LIKE '{0}%'", txt_searchfield.Text);
                    dt = new ConnectionManager().ExecuteGetDataTable(query);
                    listBox1.DisplayMember = dt.Columns[0].ColumnName;
                }
                listBox1.ValueMember = dt.Columns[1].ColumnName;
                listBox1.DataSource = dt.DefaultView;
            }
            else
            {
                listBox1.Visible = false;
            }
        }

        private void txt_searchfield_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SelectCustomer();
            }
        }
        private void SelectCustomer()
        {
            DataRowView drv = ((DataRowView)listBox1.SelectedItem);
            txt_searchfield.Text = drv[0].ToString();
            txt_searchfield.Tag = drv[1].ToString();
            txt_searchfield.SelectionStart = txt_searchfield.TextLength;
            dtp_startdate.Focus();
        }

        private void txt_searchfield_Leave(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int itemIndex = e.Y / listBox1.ItemHeight;
            listBox1.SelectedIndex = itemIndex;
            SelectCustomer();
        }




    }
}
