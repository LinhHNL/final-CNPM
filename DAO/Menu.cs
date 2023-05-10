using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace DAO
{
    public class Menu
    {
        public bool tryingAddingMonAn(Dictionary<string, string> MenuInfo)
        {
            String Name = MenuInfo["Name"];
            String Price = MenuInfo["Price"];
            String TypeID = MenuInfo["typeID"];
            String RoomID = MenuInfo["RoomID"];
            String ImageURl = MenuInfo["ImageURL"];
            int Point = Int32.Parse(Price) / 1000;

            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_add_menu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@price", Price);
                cmd.Parameters.AddWithValue("@point", Point);
                cmd.Parameters.AddWithValue("@url_image", ImageURl);
                cmd.Parameters.AddWithValue("@kind_food_id", TypeID);
                cmd.Parameters.AddWithValue("@room_id", RoomID);
                cmd.Parameters.AddWithValue("@status", 1);
                cmd.Parameters.AddWithValue("@Initual", 0);
                SqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public List<Dictionary<string, string>> getAllMonAn()
        {
            List<Dictionary<string, string>> resultList = new List<Dictionary<string, string>>();
            //try
            //{
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_getAll_Menu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Dictionary<string, string> resultDic = new Dictionary<string, string>();
                    resultDic.Add("MenuID", reader["MenuID"].ToString());
                    resultDic.Add("Name", reader["Name"].ToString());
                    resultDic.Add("Price", reader["Price"].ToString());
                    resultDic.Add("URLImage", reader["URLImage"].ToString());
                    resultDic.Add("KindFoodID", reader["KindFoodID"].ToString());
                    resultDic.Add("RoomID", reader["RoomID"].ToString());
                    resultDic.Add("Status", reader["status"].ToString());
                    resultDic.Add("Initual", reader["Initual"].ToString());
                    resultList.Add(resultDic);
                }
                conn.Close();
                return resultList;
            /*}
            catch (Exception ex)
            {
                return resultList;
            }*/
        }
        public bool tryingChangeMenu(Dictionary<string, string> MenuInfo)
        {
            String ID = MenuInfo["MenuID"];
            String Name = MenuInfo["Name"];
            String Price = MenuInfo["Price"];
            String TypeID = MenuInfo["KindFoodID"];
            String RoomID = MenuInfo["RoomID"];
            String ImageURl = MenuInfo["URLImage"];
            int Point = Int32.Parse(Price) / 1000;

            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_update_menu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@price", Price);
                cmd.Parameters.AddWithValue("@point", Point);
                cmd.Parameters.AddWithValue("@url_image", ImageURl);
                cmd.Parameters.AddWithValue("@kind_food_id", TypeID);
                cmd.Parameters.AddWithValue("@room_id", RoomID);
                cmd.Parameters.AddWithValue("@status", 1);
                
                SqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool tryingChangeStatus(Dictionary<string, string> StatusInfo)
        {
            String Status = StatusInfo["Status"];
            String IDFood = StatusInfo["IDFood"];
            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("change_status", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", int.Parse(IDFood));
                cmd.Parameters.AddWithValue("@status", int.Parse(Status));
                SqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    

        public Dictionary<string, string> getMonAnByID(int ID)
        {
            Dictionary<string, string> resultDic = new Dictionary<string, string>();
            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_getMenuByID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    resultDic.Add("MenuID", reader["MenuID"].ToString());
                    resultDic.Add("Name", reader["Name"].ToString());
                    resultDic.Add("Price", reader["Price"].ToString());
                    resultDic.Add("URLImage", reader["URLImage"].ToString());
                    resultDic.Add("KindFoodID", reader["KindFoodID"].ToString());
                    resultDic.Add("RoomID", reader["RoomID"].ToString());
                    resultDic.Add("Status", reader["Status"].ToString());
                }
                return resultDic;
            }
            catch (Exception ex)
            {
                return resultDic;
            }
        }
    }
}
