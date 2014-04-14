using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Deepak_Xerox.DAL
{
    internal class ConnectionManager
    {
        private string ConnectionString = "Data Source=P-PC\\SQLEXPRESS;Initial Catalog=DeepakXerox;Integrated Security=True";
        internal DataTable ExecuteGetDataTable(string Query)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            DataTable dt = new DataTable();
            try
            {
                cmd.CommandText = Query;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                da.Dispose();
            }
            catch
            {
            }
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return dt;
        }

        internal int ExecuteNonQuery(string Query)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            int result = 0;
            try
            {
                cmd.CommandText = Query;
                //param is SqlParameter[]
                //cmd.Parameters.AddRange(param);
                result = cmd.ExecuteNonQuery();
            }
            catch
            {
                result = -1;
            }
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return result;
        }

        internal int ExecuteNonQuery(string Query, SqlParameter[] param)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            int result = 0;
            try
            {
                cmd.CommandText = Query;
                cmd.Parameters.AddRange(param);
                result = cmd.ExecuteNonQuery();
            }
            catch
            {
                result = -1;
            }
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return result;
        }

        internal object ExecuteScalar(string Query)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            object obj = null;
            try
            {
                cmd.CommandText = Query;
                obj = cmd.ExecuteScalar();
            }
            catch
            {
            }
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return obj;
        }
        int count;
        internal int ExecuteScalarforCount(string Query)
        {
           
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            
            try
            {
                cmd.CommandText = Query;
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch
            {
            }
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return count;
        }

        internal object ExecuteScalar(string Query, CommandType cmdType)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = cmdType;
            cmd.Connection = con;
            object obj = null;
            try
            {
                cmd.CommandText = Query;
                obj = cmd.ExecuteScalar();
            }
            catch
            {
            }
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return obj;
        }
    }
}
