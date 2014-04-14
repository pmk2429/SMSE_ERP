using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
using Deepak_Xerox.DAL;
using Deepak_Xerox.Entities;


namespace Deepak_Xerox
{
    public partial class Personal_Details : Form
    {
        Customer cs;
        Order order;

        public Personal_Details()
        {
            InitializeComponent();
            txt_email.Leave += new EventHandler(txt_email_Leave);
            txt_mobile.KeyPress += new KeyPressEventHandler(txt_mobile_KeyPress);
            txt_contact.KeyPress += new KeyPressEventHandler(txt_contact_KeyPress);
        }

        void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            //WRITE DOWN MOBILE No VALIDATION
            //IF NOT A NUMBER/BackSpace than do not do anything
            e.Handled = !(char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar));
        }

        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar));
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {

            Regex mRegxExpression = null;

            if (txt_email.Text.Trim() != string.Empty)
            {

                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(txt_email.Text.Trim()))
                {

                    lbl_validate_email.Visible = true;
                    lbl_validate_email.Text = "E-mail address must be in form - name@example.com";
                    //MessageBox.Show("E-mail address format is incorrect!", "E-mail format incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txt_email.Focus();

                }

            }
            /* private void txt_firstname_KeyUp(object sender, KeyEventArgs e)
             {
                 if (e.KeyCode == Keys.Enter && txt_firstname.TextLength > 0)
                     LoadCustomers("Name", txt_firstname);

             }    
             private void btn_customerorder_Click(object sender, EventArgs e)
             {

             }

         */
        }




        private void ResetForm(bool isEnabled, bool isUpdate)
        {
            //if (isEnabled)
            //    pnlEntry.DataSource = null;

            pnlentry.Enabled = isEnabled;
            btn_add.Enabled = !isEnabled;
            btn_save.Enabled = isEnabled;
            btn_delete.Enabled = isUpdate;
            btn_update.Enabled = isEnabled;
            btn_close.Enabled = !isEnabled;
            txt_fname.Focus();

        }

        private void ResetForm1(bool isEnabled, bool isUpdate)
        {
            //if (!isEnabled)
            pnlorder.Enabled = isEnabled;
            pnl_order.Enabled = isEnabled;
            btnadd.Enabled = !isEnabled;
            btnsave.Enabled = isEnabled;
            bt_update.Enabled = isEnabled;
            btnview.Enabled = isEnabled;
            txt_firstname.Focus();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            cs = new Customer();
            pnlentry.DataSource = cs;
            ResetForm(true, false);

        }
        private void btn_save_Click_1(object sender, EventArgs e)
        {

            if (txt_fname.Text.Trim().Length > 0 && txt_lname.Text.Trim().Length > 0)
            {
                if (cs.Id == 0)
                {
                    if (new CustomerManager().InsertCustomer(cs) > 0)
                    {
                        MessageBox.Show("Record saved.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm(false, false);
                    }
                    else
                    {
                        MessageBox.Show("Could not save the record!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    if (new CustomerManager().UpdateCustomer(cs) > 0)
                    {
                        MessageBox.Show("Record Updated.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm(false, false);
                    }
                    else
                        MessageBox.Show("Could not UPDATE the record!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {

                MessageBox.Show("Please entered correct values!!!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }


        private void Personal_Details_Load(object sender, EventArgs e)
        {
            ResetForm(false, false);
        }


        private void LoadCustomers(string column, TextBox txt)
        {
            if (txt.Text.Trim().Length > 0)
            {
                List<Customer> cust = (new CustomerManager().SearchCustomerByField(column, string.Format(" LIKE '%{1}%'", column, txt.Text))) as List<Customer>;
                if (cust.Count == 0)
                {
                    MessageBox.Show("No Customer Found!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    txt_firstname.Tag = cust[0].Id;
                    txt_firstname.Text = cust[0].Name;
                    txt_lastname.Text = cust[0].Surname;
                    txt_contactno.Text = cust[0].Contact;
                    txt_company.Text = cust[0].NameOfCom;
                }
            }
            else
            { }


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            order = new Order();
            order.OrderNo = new OrderManager().GenerateOrderNo(DateTime.Now.Month, DateTime.Now.Year);
            txt_ordernum.Text = order.OrderNo.ToString();
            ResetForm1(true, false);

        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            string Query = "SELECT customer_id from Customer_Details where first_name = '" + txt_firstname.Text.Trim() + "' AND contact_no = '" + txt_contactno.Text + "'";
            order.CustomerId = new OrderManager().GetCustomerId(Query); 

            order.NOC = Convert.ToInt32(txt_noofcopy.Text);
            order.Rate = Convert.ToInt32(txt_rate.Text);
            order.Total = Convert.ToInt32(txt_total.Text);

            if (txt_firstname.Tag != null && txt_ordernum.Text.Trim().Length > 0)
            {
                order.TypeOfWork = (TypeOfWorks)(cmb_tow.SelectedIndex);
                if (order.ID == 0)
                {
                    //new OrderManager().GetCombobox(typework);
                    if (new OrderManager().InsertOrder(order) < 0)
                    {
                        MessageBox.Show("Could not save order!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    if (new OrderManager().UpdateOrder(order) < 0)
                    {
                        MessageBox.Show("Could not save order!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                MessageBox.Show("Record saved.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm(false, false);
            }
            else
            {
                MessageBox.Show("Please select a customer and Items for the order.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                ResetForm(false, false);
            }
            else
            {
                ResetForm1(false, false);
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            View_Billing vbs = new View_Billing();
            vbs.Show();
        }

        private void txt_firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_firstname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_firstname.TextLength > 0)
            {
                LoadCustomers("first_name", txt_firstname);
            }
        }

        private void txt_lastname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_lastname.TextLength > 0)
                LoadCustomers("last_name", txt_lastname);
        }

        private void txt_contactno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_contactno.TextLength > 0)
                LoadCustomers("contact_no", txt_contactno);
        }

        private void txt_company_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_company.TextLength > 0)
                LoadCustomers("name_of_com", txt_company);
        }

        private void txt_rate_TextChanged(object sender, EventArgs e)
        {
            txt_total.Text = (Convert.ToInt32(txt_noofcopy.Text) * Convert.ToInt32(txt_rate.Text)).ToString();
        }


        Customer customer;
        internal void UpdateCustomer(int custo_id)
        {
            if (customer == null)
                customer = new Customer();


            customer.Id = custo_id;
            string query = "SELECT * FROM Customer_Details where customer_id = " + customer.Id;
            Customer cust = new CustomerManager().GetAllCustData(query);

            if (cust.Id > 0)
            {
                //Personal Details Form
                ResetForm_Update(true, false);
                txt_fname.Text = cust.Name.ToString();
                txt_lname.Text = cust.Surname.ToString();
                txt_add.Text = cust.Add.ToString();
                txt_nameofcom.Text = cust.NameOfCom.ToString();
                txt_contact.Text = cust.Contact.ToString();
                txt_mobile.Text = cust.Mobile.ToString();
                txt_email.Text = cust.Email.ToString();


            }
            else
            {
                MessageBox.Show("Please provide the essential details!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ResetForm_Update(bool isEnabled, bool isUpdate)
        {
            pnlentry.Enabled = isEnabled;
            btn_add.Enabled = !isEnabled;
            btn_save.Enabled = !isEnabled;
            btn_delete.Enabled = isUpdate;
            btn_update.Enabled = isEnabled;
            btn_close.Enabled = !isEnabled;
            txt_fname.Focus();
        }

        internal void UpdateOrder(int custo_id)
        {
            if (order == null)
                order = new Order();
            if (customer == null)
                customer = new Customer();

            string query = "SELECT * FROM Customer_Order where Customer_Id = " + custo_id;
            Order ord = new OrderManager().GetAllData(query);
            string query1 = "SELECT * FROM Customer_Details where customer_id = " + customer.Id;
            Customer cust = new CustomerManager().GetAllCustData(query1);

            order.CustomerId = customer.Id;
            if (ord.CustomerId > 0)
            {
                //Customer Order form
                ResetForm1_Update(true, false);
                txt_firstname.Text = customer.Name.ToString();
                txt_lastname.Text = customer.Surname.ToString();
                txt_contactno.Text = customer.Contact.ToString();
                txt_company.Text = customer.NameOfCom.ToString();

                txt_ordernum.Text = ord.OrderNo.ToString();
                cmb_tow.SelectedItem = ord.TypeOfWork.ToString();
                txt_noofcopy.Text = ord.NOC.ToString();
                txt_rate.Text = ord.Rate.ToString();
                txt_total.Text = ord.Total.ToString();
            }
            else
            {
                MessageBox.Show("Please provide the essential details!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ResetForm1_Update(bool isEnabled, bool isUpdate)
        {
            pnlorder.Enabled = isEnabled;
            pnl_order.Enabled = isEnabled;
            btnadd.Enabled = !isEnabled;
            btnsave.Enabled = !isEnabled;
            btnview.Enabled = isEnabled;
            txt_firstname.Focus();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();

            }
            else
            {
                ResetForm(false, false);
            }
        }
    }


}


