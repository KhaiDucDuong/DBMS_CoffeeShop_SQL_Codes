using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApplication.DB
{
    public class DBConnection
    {
        private static DBConnection _instance;
        private static SqlConnection conn;
        private static string username, password;
        private const string serverName = "LAPTOP-1PAHHD1P";

        public static string Username { set => username = value; }
        public static string Password { set => password = value; }

        public static void resetConnection()
        {
            conn = null;
            Username = null;
            Password = null;
        }

        private DBConnection()
        {
            if (username != null && password != null)
                conn = new SqlConnection("Server=" + serverName +  ";Database=CoffeeShop;User Id=" + username + ";Password=" + password + ";");
        }

        public string GetConnectionString()
        {
            return conn.ConnectionString;
        }

        public static DBConnection getInstance()
        {
            if (_instance == null || conn == null)
            {
                _instance = new DBConnection();
            }
            return _instance;
        }

        public DataSet ExecuteQuery(string sqlStr, CommandType ct, SqlParameter[] parameters = null)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
            } catch (Exception ex) { MessageBox.Show(ex.ToString(), "Connection Error"); }
            
            SqlCommand comm = new SqlCommand(sqlStr, conn);
            comm.CommandType = ct;
            if (parameters != null)
                comm.Parameters.AddRange(parameters);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);

            } catch (Exception ex) { MessageBox.Show(ex.ToString(), "ERROR MESSAGE"); }
            return ds;
        }

        public bool ExecuteNonQuery(string sqlStr, CommandType ct, SqlParameter[] parameters = null)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Connection Error"); }

            SqlCommand comm = new SqlCommand(sqlStr, conn);
            comm.CommandType = ct;
            if (parameters != null)
                comm.Parameters.AddRange(parameters);
            try
            {
                comm.ExecuteNonQuery();
                return true;
            } catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}