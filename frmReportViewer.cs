using System;
using System.Data;
using System.Windows.Forms;
using Deepak_Xerox.DAL;
using Deepak_Xerox.Entities;

namespace Deepak_Xerox
{
    public partial class frmReportViewer : Form
    {
        public int customer_id = 0;
        public frmReportViewer(int cid)
        {
            customer_id = cid;
            InitializeComponent();
        }

      

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            try
            {
                string que = "SELECT * FROM Customer_Order where Customer_Id = " + customer_id;
                Order ord = new OrderManager().GetAllData(que);

                string que1 = "SELECT * FROM Customer_Details where customer_Id = " + customer_id;
                Customer cus = new CustomerManager().GetAllCustData(que1);

                DataSet ds = new DataSet();
                ds.Tables.Add("Customer_Details");
                ds.Tables["Customer_Details"].Columns.Add("customer_id");
                ds.Tables["Customer_Details"].Columns.Add("first_name");
                ds.Tables["Customer_Details"].Columns.Add("last_name");
                ds.Tables["Customer_Details"].Columns.Add("address");
                ds.Tables["Customer_Details"].Columns.Add("name_of_com");
                ds.Tables["Customer_Details"].Columns.Add("contact_no");
                ds.Tables["Customer_Details"].Columns.Add("mobile");
                ds.Tables["Customer_Details"].Columns.Add("email_id");

                ds.Tables["Customer_Details"].Rows.Add();
                ds.Tables["Customer_Details"].Rows[0]["customer_id"] = customer_id;
                ds.Tables["Customer_Details"].Rows[0]["first_name"] = cus.Name.ToString();
                ds.Tables["Customer_Details"].Rows[0]["last_name"] = cus.Surname.ToString();
                ds.Tables["Customer_Details"].Rows[0]["address"] = "---";
                ds.Tables["Customer_Details"].Rows[0]["name_of_com"] = cus.NameOfCom.ToString();
                ds.Tables["Customer_Details"].Rows[0]["contact_no"] = "---";
                ds.Tables["Customer_Details"].Rows[0]["mobile"] = cus.Mobile.ToString();
                ds.Tables["Customer_Details"].Rows[0]["email_id"] = "--";

                ds.Tables.Add("Customer_Order");
                ds.Tables["Customer_Order"].Columns.Add("User_id");
                ds.Tables["Customer_Order"].Columns.Add("order_no");
                ds.Tables["Customer_Order"].Columns.Add("date");
                ds.Tables["Customer_Order"].Columns.Add("type_of_work");
                ds.Tables["Customer_Order"].Columns.Add("no_of_copies");
                ds.Tables["Customer_Order"].Columns.Add("rate");
                ds.Tables["Customer_Order"].Columns.Add("total");
                ds.Tables["Customer_Order"].Columns.Add("Customer_Id");

                ds.Tables["Customer_Order"].Rows.Add();
                ds.Tables["Customer_Order"].Rows[0]["User_id"] = ord.ID;
                ds.Tables["Customer_Order"].Rows[0]["order_no"] = ord.OrderNo;
                ds.Tables["Customer_Order"].Rows[0]["date"] = ord.Date;
                ds.Tables["Customer_Order"].Rows[0]["type_of_work"] = ord.TypeOfWork.ToString();
                ds.Tables["Customer_Order"].Rows[0]["no_of_copies"] = ord.NOC.ToString();
                ds.Tables["Customer_Order"].Rows[0]["rate"] = ord.Rate.ToString();
                ds.Tables["Customer_Order"].Rows[0]["total"] = ord.Total.ToString();
                ds.Tables["Customer_Order"].Rows[0]["Customer_Id"] = customer_id;

                rptMyReport rpt = new rptMyReport();
                rpt.SetDataSource(ds);

                crystalReportViewer1.ReportSource = rpt;
            }
            catch
            {
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }


    }
}
