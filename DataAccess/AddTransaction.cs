using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.DataAccess
{
    internal class AddTransaction
    {
        private Dictionary<string, string> TryingAddTransaction(float TotalPrice, String Date, int CustormerID)
        {
            Dictionary<string, string> resultlist = new Dictionary<string, string>();
            try
            {
                SqlConnection conn = new SqlConnection("Data Source = LAPTOP-VERULPGO\\SQLEXPRESS; Initial Catalog = hadilao; Integrated Security = True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert_transaction", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TotalPrice", TotalPrice);
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@CustormerID", CustormerID);
                int result = cmd.ExecuteNonQuery();
                resultlist.Add("result", "1");
                conn.Close();
            }
            catch (Exception ex)
            {
                resultlist.Add("result", "0");
            }
            return resultlist;
        }
        public Dictionary<string, string> TryingAddTransactionFunc(float TotalPrice, String Date, int CustormerID)
        {
            return this.TryingAddTransaction(TotalPrice, Date, CustormerID);
        }
    }
}
