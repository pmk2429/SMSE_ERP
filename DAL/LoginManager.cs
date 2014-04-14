using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Deepak_Xerox.Properties;
using Deepak_Xerox.Entities;
using System.Text.RegularExpressions;

namespace Deepak_Xerox.DAL
{

    class LoginManager
    {
        private IEnumerable<Client> GetClients(string Query)
        {
            DataTable dt = new ConnectionManager().ExecuteGetDataTable(Query);
            List<Client> lstClient = new List<Client>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach(DataRow r in dt.Rows )
                {
                    Client cl = new Client();
                    cl.ID = Convert.ToInt32(r["client_id"]);
                    cl.Name = r["user_name"].ToString();
                    cl.Pass = r["password"].ToString();
                    cl.Active = Convert.ToBoolean(r["active"]);
                    lstClient.Add(cl);
                }
            }
            return lstClient;
        }

        public int GetCount(string Query)
        {
            return new ConnectionManager().ExecuteScalarforCount(Query);
        }

        public int InsertClient(Client clnt)
        {
            string Query = "INSERT into Client_login (user_name, password, active) values (@user_name,@password,@active)";
            return new ConnectionManager().ExecuteNonQuery(Query, CreateParameters(clnt));
        }



        private SqlParameter[] CreateParameters(Client clnt)
        {
            SqlParameter[] param;
            int count = 0;
            if (clnt.ID != 0)
            {
                param = new SqlParameter[4];
                param[0] = new SqlParameter("@client_id", clnt.ID);
                count++;
            }
            else
            {
                param = new SqlParameter[3];
            }
            param[count] = new SqlParameter("@user_name", clnt.Name);
            param[count + 1] = new SqlParameter("@password", clnt.Pass);
            param[count + 2] = new SqlParameter("@active", clnt.Active);

            return param;
        }
    }
}
