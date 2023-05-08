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
        public Dictionary<string, string> getTempBillByIDAndToken(Dictionary<string, string> TempBillInfo)
        {
            int CustomerID = int.Parse(TempBillInfo["CustomerID"]);
            String TokenID = TempBillInfo["Token"];
            Dictionary<string, string> resultDic = new Dictionary<string, string>();
            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetTempBill", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Token", TokenID);
                cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    resultDic.Add("TempBillID", reader["Id"].ToString());
                }
                conn.Close();
                return resultDic;
            }
            catch (Exception ex)
            {
                return resultDic;
            }
        }
        public bool tryingInsertTempBillDetail(Dictionary<string, string> TempBillDetailInfo)
        {
            int TempBillId = int.Parse(TempBillDetailInfo["TempBillId"]);
            int MenuID = int.Parse(TempBillDetailInfo["MenuID"]);
            int NumberOfFood = int.Parse(TempBillDetailInfo["Number"]);
            float Price = (float)int.Parse(TempBillDetailInfo["Price"]);
            int Status = 0;
            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("InsertTempBillDetails", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TempBillId", TempBillId);
                cmd.Parameters.AddWithValue("@MenuID", MenuID);
                cmd.Parameters.AddWithValue("@Number", NumberOfFood);
                cmd.Parameters.AddWithValue("@Status", Status);
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
        public Dictionary<string, string> tryingInsertTempBill(Dictionary<string, string> TempBillInfo)
        {
            Dictionary<string, string> resultDic = new Dictionary<string, string>();
            int CustomerID = int.Parse(TempBillInfo["CustomerID"]);
            int Status = 0;
            String TokenID = TempBillInfo["Token"];
            float Price = (float) int.Parse(TempBillInfo["Price"]);
            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("InsertTempBill", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerId", CustomerID);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@Token", TokenID);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    resultDic.Add("TempBilID", reader["TempBilID"].ToString());
                }
            conn.Close();
            return resultDic;
            }
            catch (Exception ex)
            {
                resultDic.Add("TempBilID", "-1");
                return resultDic;
            }
        }
        public bool tryingChangeStatus(Dictionary<string, string> StatusInfo) {
            String MenuID = StatusInfo["MenuID"];
            String IDFood = StatusInfo["BillID"];
            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("UpdateTempBillDetails", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TempBillId", int.Parse(IDFood));
                cmd.Parameters.AddWithValue("@MenuID", int.Parse(MenuID));
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
        public List<Dictionary<string, string>> getAllTempBillDetailsOfTempBill(String IDBillStr)
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
                    resultDic.Add("Status", reader["Status"].ToString());
                    resultDic.Add("Price", reader["Price"].ToString());
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
