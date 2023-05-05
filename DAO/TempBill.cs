using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TempBill
    {
        public bool tryingChangeStatus(Dictionary<string, string> StatusInfo) {
            String Status = StatusInfo["MenuID"];
            String IDFood = StatusInfo["BillID"];
            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("UpdateTempBillDetails", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TempBillId", int.Parse(IDFood));
                cmd.Parameters.AddWithValue("@MenuID", int.Parse(Status));
                SqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<Dictionary<string, string>> getTempBillNotDone() {
            List<Dictionary<string, string>> resultList = new List<Dictionary<string, string>>();
            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetTempBillNotDone", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Dictionary<string, string> resultDic = new Dictionary<string, string>();
                    resultDic.Add("TempBillID", reader["Id"].ToString());
                    resultList.Add(resultDic);
                }
                conn.Close();
                return resultList;
            }
            catch (Exception ex)
            {
                return resultList;
            }
        }
        public List<Dictionary<string, string>> GetAllTempBillDetailsOfTempBill(String IDBillStr)
        {
            int IDBill = int.Parse(IDBillStr);
            List<Dictionary<string, string>> resultList = new List<Dictionary<string, string>>();
            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetAllTempBillDetailsOfTempBill", conn);
                cmd.Parameters.AddWithValue("@Id", IDBill);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Dictionary<string, string> resultDic = new Dictionary<string, string>();
                    resultDic.Add("MenuID", reader["MenuID"].ToString());
                    resultDic.Add("NumberOfFood", reader["Number"].ToString());
                    resultList.Add(resultDic);
                }
                conn.Close();
                return resultList;
            }
            catch (Exception ex)
            {
                return resultList;
            }
        }
    }
}
