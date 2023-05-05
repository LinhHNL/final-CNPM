using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DAO
{
    public class Combo
    {
        public List<Dictionary<string, string>> getAllCombo()
        {
            List<Dictionary<string, string>> resultList = new List<Dictionary<string, string>>();
            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetCombos", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Dictionary<string, string> resultDic = new Dictionary<string, string>();
                    resultDic.Add("ComboID", reader["Id"].ToString());
                    resultDic.Add("Name", reader["Name"].ToString());
                    resultDic.Add("Price", reader["Cost"].ToString());
                    resultDic.Add("URLImage", reader["ImageURL"].ToString());
                    resultDic.Add("Description", reader["Description"].ToString());
                    resultDic.Add("Status", reader["status"].ToString());
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
        public Dictionary<string, string> getLastIDCombo()
        {
            Dictionary<string, string> resultDic = new Dictionary<string, string>();
            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetLastIDCombo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    resultDic.Add("ComboID", reader["Id"].ToString());
                    
                }
                return resultDic;
            }
            catch (Exception ex)
            {
                resultDic.Add("ComboID", "-1");
                return resultDic;
            }
        }
        public bool tryingAddingCombo(Dictionary<string, string> MenuInfo)
        {
            String Name = MenuInfo["Name"];
            String Cost = MenuInfo["Cost"];
            String ImageURl = MenuInfo["ImageURL"];

            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("AddCombo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Cost", Cost);
                cmd.Parameters.AddWithValue("@ImageURL", ImageURl);
                cmd.Parameters.AddWithValue("@Description", "");
                SqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool tryingFlipStatusCombo(Dictionary<string, string> MenuInfo)
        {
            int IDCombo = int.Parse(MenuInfo["ComboID"]);
            String Status = MenuInfo["Status"];
            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("change_statusCombo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", IDCombo);
                cmd.Parameters.AddWithValue("@status", Status);
                SqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool tryingAddingComboDetail(Dictionary<string, string> MenuInfo)
        {
            int IDMenu = int.Parse(MenuInfo["MenuID"]);
            int IDCombo = int.Parse(MenuInfo["ComboID"]);
            String NumberOfFood = MenuInfo["NumberOfFood"];

            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("AddMenuToCombo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MenuID", IDMenu);
                cmd.Parameters.AddWithValue("@ComboID", IDCombo);
                cmd.Parameters.AddWithValue("@NumberOfFood", NumberOfFood);
                SqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
