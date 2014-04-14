using System;
using System.Collections.Generic;
using System.Text;
using Deepak_Xerox.DAL;
using Deepak_Xerox.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
using Deepak_Xerox.Properties;


namespace Deepak_Xerox.DAL
{

    internal class CustomerManager
    {
        

        public IEnumerable<Customer> GetAllCustomers()
        {
            string Query = "sp_customerdetails_select";
            return GetCustomers(Query);
        }

       
        private IEnumerable<Customer> GetCustomers(string Query)
        {
            DataTable dt = new ConnectionManager().ExecuteGetDataTable(Query);
            List<Customer> lst = new List<Customer>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    Customer cs = new Customer();
                    cs.Id = Convert.ToInt32(r["customer_id"]);
                    cs.Name = r["first_name"].ToString();
                    cs.Surname = r["last_name"].ToString();
                    cs.Add = r["address"].ToString();
                    cs.NameOfCom = r["name_of_com"].ToString();
                    cs.Contact = r["contact_no"].ToString();
                    cs.Mobile = r["mobile"].ToString();
                    cs.Email= r["email_id"].ToString();
                    lst.Add(cs);
                }
            }
            return lst;
        }

        public int InsertCustomer(Customer cust)
        {
         
            string Query = "sp_customerdetails_insert";
            return new ConnectionManager().ExecuteNonQuery(Query, CreateParameters(cust));

        }

        public int UpdateCustomer(Customer cust)
        {
            string Query = "sp_customerdetails_update";
            return new ConnectionManager().ExecuteNonQuery(Query, CreateParameters(cust));

        }

        public int DeleteCustomer(int id)
        {
            string Query = "sp_customerdetails_delete";
            return new ConnectionManager().ExecuteNonQuery(Query);

        }


        private SqlParameter[] CreateParameters(Customer cust)
        {
            SqlParameter[] param;
            int count = 0;
            if (cust.Id != 0)
            {
                param = new SqlParameter[8];
                param[0] = new SqlParameter("@customer_id", cust.Id);
                count++;
            }
            else
            {
                param = new SqlParameter[7];
            }
            param[count] = new SqlParameter("@first_name", cust.Name);
            param[count + 1] = new SqlParameter("@last_name", cust.Surname);            
            param[count + 2] = new SqlParameter("@address", cust.Add);
            param[count + 3] = new SqlParameter("@name_of_com", cust.NameOfCom);
            param[count + 4] = new SqlParameter("@contact_no", cust.Contact);
            param[count + 5] = new SqlParameter("@mobile", cust.Mobile);
            param[count + 6] = new SqlParameter("@email_id", cust.Email);
            return param;
        }


        internal IEnumerable<Customer> SearchCustomerByField(string fieldname, string value)
        {
            return GetCustomers(string.Format("SELECT * from Customer_Details where {0}{1}", fieldname, value));
        }

        internal Customer GetAllCustData(string Query)
        {
            
            DataTable dt = new ConnectionManager().ExecuteGetDataTable(Query);
            List<Customer> lst = new List<Customer>();
            if (dt != null && dt.Rows.Count > 0)
            {

                Customer cs = new Customer();
                cs.Id = Convert.ToInt32(dt.Rows[0]["customer_id"]);
                cs.Name = dt.Rows[0]["first_name"].ToString();
                cs.Surname = dt.Rows[0]["last_name"].ToString();
                cs.Add = dt.Rows[0]["address"].ToString();
                cs.NameOfCom = dt.Rows[0]["name_of_com"].ToString();
                cs.Contact = dt.Rows[0]["contact_no"].ToString();
                cs.Mobile = dt.Rows[0]["mobile"].ToString();
                cs.Email = dt.Rows[0]["email_id"].ToString();
                return cs;

            }
            else
            {
                return null;
            }
           
        }

        internal Customer GetSpecificData(string query)
        {
            //object data = new ConnectionManager().ExecuteScalar(query, CommandType.Text);
            
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader dr = cmd.ExecuteReader();

            ////if (dr.HasRows == true)
            ////{ 
            ////    //while(dr.Read)
            ////    //    namecoll 
                    
            ////}
            return null;
        }
    }
}
