using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.DataAccess
{
    internal class TakingValidateProc
    {
        private int TakingValidateProcFunc(String username,String password)
        {
            SqlConnection conn = new SqlConnection("Data Source = LAPTOP-VERULPGO\\SQLEXPRESS; Initial Catalog = hadilao; Integrated Security = True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("CheckLogin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@phone", username);
            cmd.Parameters.AddWithValue("@password", password);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }
        public int TakingValidateProcFuncUsing(String username,String password)
        {
            return this.TakingValidateProcFunc(username, password);
        }
    }
}
