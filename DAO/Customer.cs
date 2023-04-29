using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Customer
    {
        private Dictionary<string, string> tryingAddCustomer(String username, String password, String name, String email)
        {
            Dictionary<string, string> resultlist = new Dictionary<string, string>();
            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("AddCustomer", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@address", email);
                cmd.Parameters.AddWithValue("@name", name);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    resultlist.Add("id", reader["CustormerID"].ToString());
                    resultlist.Add("result", reader["Result"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                resultlist.Add("id", "-1");
                resultlist.Add("result", "0");
            }
            return resultlist;
        }
        public Dictionary<string, string> registerCustomer(String username, String password, String name, String email)
        {
            return this.tryingAddCustomer(username, password, name, email);
        }
        private Dictionary<string, string> validateLoginFunc(String username, String password)
        {
            Dictionary<string, string> resultlist = new Dictionary<string, string>();
            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("CheckLogin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    resultlist.Add("id", reader["CustormerID"].ToString());
                    resultlist.Add("result", reader["Result"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                resultlist.Add("id", "-1");
                resultlist.Add("result", "0");
            }
            return resultlist;
        }
        public Dictionary<string, string> loginCustomer(String username, String password)
        {
            return this.validateLoginFunc(username, password);
        }
    }
}
