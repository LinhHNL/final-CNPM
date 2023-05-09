using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Transaction
    {
        public bool tryingInsertTransactionDetail(Dictionary<string, string> TransactionInfo)
        {
            int TransactionID = int.Parse(TransactionInfo["TransactionID"]);
            int MenuID = int.Parse(TransactionInfo["MenuID"]);
            int NumberOfFood = int.Parse(TransactionInfo["Number"]);
            float Price = (float)int.Parse(TransactionInfo["Price"]);
            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("AddTransactionDetail", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TransactionID", TransactionID);
                cmd.Parameters.AddWithValue("@MenuID", MenuID);
                cmd.Parameters.AddWithValue("@Number", NumberOfFood);
                cmd.Parameters.AddWithValue("@Price", Price);
                SqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Dictionary<string, string> tryingInsertTransaction(Dictionary<string, string> TransactionInfo)
        {
            Dictionary<string, string> resultDic = new Dictionary<string, string>();
            int CustomerID = int.Parse(TransactionInfo["CustomerID"]);
            String DateTime = TransactionInfo["Date"];
            float Price = (float)int.Parse(TransactionInfo["Price"]);
            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("InsertTransaction", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerId", CustomerID);
                cmd.Parameters.AddWithValue("@Date", DateTime);
                cmd.Parameters.AddWithValue("@TotalPrice", Price);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    resultDic.Add("TransactionID", reader["TransactionID"].ToString());
                }
                conn.Close();
                return resultDic;
            }
            catch (Exception ex)
            {
                resultDic.Add("TransactionID", "-1");
                return resultDic;
            }
        }
    }
}
