using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp2.DataAccess
{
    internal class TakingValidateProc
    {
        private Dictionary<string, string> TakingValidateProcFunc(String username,String password)
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
        public Dictionary<string, string> TakingValidateProcFuncUsing(String username,String password)
        {
            return this.TakingValidateProcFunc(username, password);
        }
    }
}
