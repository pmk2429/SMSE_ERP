using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Deepak_Xerox.Entities;


namespace Deepak_Xerox.DAL
{
    internal class OrderManager
    {
        //Order order;
        Personal_Details pd;

        public IEnumerable<Order> GetAllOrders()
        {
            string Query = "sp_customerorder_select";
            DataTable dt = new ConnectionManager().ExecuteGetDataTable(Query);

            List<Order> lst = new List<Order>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    Order order = new Order();
                    order.ID = Convert.ToInt32(r["User_id"]);
                    order.OrderNo = Convert.ToInt32(r["order_no"]);
                    order.Date = Convert.ToDateTime(r["date"]);
                    order.TOW = Convert.ToString(r["type_of_work"]);
                    order.TypeOfWork = (TypeOfWorks)Enum.Parse(typeof(TypeOfWorks), r["type_of_work"].ToString());
                    order.NOC = Convert.ToInt32(r["number_of_copies"]);
                    order.Rate = Convert.ToSingle(r["rate"]);
                    order.Total = Convert.ToSingle(r["total"]);
                    order.CustomerId = Convert.ToInt32(r["Customer_Id"]);
                    lst.Add(order);
                }
            }
            return lst;
        }

        public int InsertOrder(Order order)
        {
            string Query = "sp_customerorder_insert";
            //The Stored_Procedure is used to...
            string queselect = "sp_odermanager_select";
            int result = new ConnectionManager().ExecuteNonQuery(Query, Createparameters(order));
            object id = new ConnectionManager().ExecuteScalar(queselect);
            if (id != null && id != DBNull.Value)
            {
                order.ID = (int)id;
            }
            else
            {
                throw new Exception("Could not be saved!");
            }
            return result;
        }



        public int UpdateOrder(Order order)
        {
            string Query = "sp_customerorder_update";
            return new ConnectionManager().ExecuteNonQuery(Query, Createparameters(order));
        }

        public int DeleteOrder(int id)
        {
            string Query = "sp_customerorder_delete";
            return new ConnectionManager().ExecuteNonQuery(Query);
        }

        string combo;
        public void GetCombobox(string cmb)
        {
            combo = cmb;
        }

        private SqlParameter[] Createparameters(Order order)
        {
            SqlParameter[] param;
            int count = 0;
            if (order.ID != 0)
            {
                param = new SqlParameter[8];
                param[0] = new SqlParameter("User_id", order.ID);
                count++;
            }
            else
            {
                param = new SqlParameter[7];
            }


            param[count] = new SqlParameter("@order_no", order.OrderNo);
            param[count + 1] = new SqlParameter("@date", order.Date);
            //Combobox
            param[count + 2] = new SqlParameter("@type_of_work", order.TypeOfWork.ToString());

            param[count + 3] = new SqlParameter("@no_of_copies", order.NOC);
            param[count + 4] = new SqlParameter("@rate", order.Rate);
            param[count + 5] = new SqlParameter("@total", order.Total);
            param[count + 6] = new SqlParameter("customer_id", order.CustomerId);
            return param;

        }

        internal int GenerateOrderNo(int orderMonth, int orderYear)
        {

            int lastday = DateTime.DaysInMonth(orderYear, orderMonth);
            DateTime endDate = new DateTime(orderYear, orderMonth, lastday);
            DateTime startDate = new DateTime(orderYear, orderMonth, 1);

            object order_no = new ConnectionManager().ExecuteScalar(string.Format("SELECT order_no from Customer_Order WHERE date between '{0:yyyy-MM-dd}' AND '{1:yyyy-MM-dd}'", startDate, endDate));
            if (order_no == null || order_no == DBNull.Value)
            {
                return 1;
            }
            else
            {
                return ((int)order_no) + 1;
            }




        }

        public DataTable GetData(DateTime Startdate, DateTime EndDate, string Columnname, string value, int customerid)
        {
            SqlConnection con = new SqlConnection("Data Source=P-PC\\SQLEXPRESS;Initial Catalog=DeepakXerox;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT Customer_Order.order_no, Customer_Details.first_name, Customer_Details.last_name, Customer_Details.name_of_com, Customer_Details.mobile, Customer_Order.date, Customer_Order.type_of_work, Customer_Order.no_of_copies, Customer_Order.rate, Customer_Order.total from Customer_Details INNER JOIN Customer_Order ON Customer_Details.customer_id = Customer_Order.Customer_Id WHERE Customer_Order.date BETWEEN '" + Startdate.ToString("dd-MMM-yyyy") + "' AND '" +
                EndDate.ToString("dd-MMM-yyyy") + "' AND '" + Columnname + "'='" + Columnname + "'" + " AND Customer_Order.Customer_Id =" + "'" + customerid + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }



        internal int GetCustomerId(string custid)
        {
            //throw new NotImplementedException();
            object cid = new ConnectionManager().ExecuteScalar(custid, CommandType.Text);
            return Convert.ToInt32(cid);
        }

        internal Order GetAllData(string Query)
        {
            // throw new NotImplementedException();
            //Order ord = (Order)new ConnectionManager().ExecuteScalar(que, CommandType.Text);
            //return ord;
            DataTable dt = new ConnectionManager().ExecuteGetDataTable(Query);

            if (dt != null && dt.Rows.Count > 0)
            {
                Order order = new Order();
                order.ID = Convert.ToInt32(dt.Rows[0]["User_id"]);
                order.OrderNo = Convert.ToInt32(dt.Rows[0]["order_no"]);
                order.Date = Convert.ToDateTime(dt.Rows[0]["date"]);
                order.TOW = Convert.ToString(dt.Rows[0]["type_of_work"]);
               // order.TypeOfWork = (TypeOfWorks)Enum.Parse(typeof(TypeOfWorks), dt.Rows[0]["type_of_work"].ToString());
                order.NOC = Convert.ToInt32(dt.Rows[0]["no_of_copies"]);
                order.Rate = Convert.ToSingle(dt.Rows[0]["rate"]);
                order.Total = Convert.ToSingle(dt.Rows[0]["total"]);
                order.CustomerId = Convert.ToInt32(dt.Rows[0]["Customer_Id"]);
                return order;
            }
            else
            {
                return null;
            }
        }

        internal int GetCustId(string combodata, string txtvalue)
        {
            object custid;
            string parameter = "", paramvalue = "";
            string[] value = txtvalue.Split(' ');
            //string Query = "SELECT customer_id FROM Customer_Details WHERE {0}{1}", combodata, txtvalue);

            //Code is used for separating first_name and last_name if passed as whole as parameter...
            if (combodata == "First_Name")
            {
                parameter = "first_name";
                paramvalue = value[0];
                custid = new ConnectionManager().ExecuteScalar(string.Format("SELECT customer_id FROM Customer_Details WHERE {0} like '%{1}%'", parameter, paramvalue), CommandType.Text);
            }
            else if (combodata == "Last_Name")
            {
                parameter = "last_name";
                paramvalue = value[1];
                custid = new ConnectionManager().ExecuteScalar(string.Format("SELECT customer_id FROM Customer_Details WHERE {0} like '%{1}%'", parameter, paramvalue), CommandType.Text);
            }
            else if (combodata == "Mobile Number")
            {
                parameter = "contact_no";
                paramvalue = txtvalue;
                custid = new ConnectionManager().ExecuteScalar(string.Format("SELECT customer_id FROM Customer_Details WHERE {0} = {1}", parameter, paramvalue), CommandType.Text);
            }
            else
            {
                parameter = "name_of_com";
                paramvalue = txtvalue;
                custid = new ConnectionManager().ExecuteScalar(string.Format("SELECT customer_id FROM Customer_Details WHERE {0} = {1}", parameter, paramvalue), CommandType.Text);
            }


            return Convert.ToInt32(custid);
            //SELECT customer_id from (SELECT * FROM( SELECT (first_name + ' ' + last_name) as name,* from Customer_Details)as temp1 WHERE name like '%Pav%')as temp2
        }

        internal DataTable GetPracticeData()
        {
            throw new NotImplementedException();
        }
    }
}
