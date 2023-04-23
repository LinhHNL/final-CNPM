using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.DataAccess
{
    internal class AddCustomer
    {
        private Dictionary<string, string> TryingAddCustomer(String username, String password,String name,String email)
        {
            Dictionary<string, string> resultlist = new Dictionary<string, string>();
            try
            {
                SqlConnection conn = new SqlConnection("Data Source = LAPTOP-VERULPGO\\SQLEXPRESS; Initial Catalog = hadilao; Integrated Security = True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("CheckLogin", conn);
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
        public Dictionary<string, string> TakingValidateProcFuncUsing(String username, String password, String name, String email)
        {
            return this.TryingAddCustomer(username, password, name, email);
        }
    }
}
