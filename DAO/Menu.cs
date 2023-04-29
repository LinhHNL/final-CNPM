using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            Dictionary<string, string> resultlist = new Dictionary<string, string>();
            try
            {
                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_add_menu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@price", Price);
                cmd.Parameters.AddWithValue("@point",(int) (int.Parse(Price)/1000));
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
    }
}
