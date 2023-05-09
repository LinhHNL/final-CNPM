using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Warehouse

    {
        public Dictionary<String, String> getCommodityById(int id)
        {

            Dictionary<String, String> commodity = new Dictionary<String, String>();
            SqlConnection conn = DatabaseConnection.connectDBFunc();
            conn.Open();
            SqlCommand cmd = new SqlCommand("getCommodity", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CommodityID", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                commodity.Add("CommodityID", reader.GetInt32(reader.GetOrdinal("ComodityID")).ToString());
                commodity.Add("Name", reader.GetString(reader.GetOrdinal("Name")));
                commodity.Add("Number", reader.GetDouble(reader.GetOrdinal("Number")).ToString());
                commodity.Add("UnitName", reader.GetString(reader.GetOrdinal("UnitName")));
            }
            reader.Close();
            conn.Close();
            return commodity;

        }
        
        public List<Dictionary<String, string>> getAllCommodity()
        {
                List<Dictionary<String, String>> listCommodity = new List<Dictionary<String, String>>();

            try
            {

                SqlConnection conn = DatabaseConnection.connectDBFunc();
                conn.Open();
                SqlCommand cmd = new SqlCommand("getAllCommoditys", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Dictionary<string, string> resultDic = new Dictionary<string, string>();
                    resultDic.Add("CommodityID", reader["ComodityID"].ToString());
                    resultDic.Add("Name", reader["Name"].ToString());
                    resultDic.Add("Number", reader["Number"].ToString());
                    resultDic.Add("UnitName", reader["UnitName"].ToString());
                    listCommodity.Add(resultDic);
                }
                conn.Close();
                return listCommodity;

            }
            catch (Exception ex)
            {

                return listCommodity;

            }

        }
    }
}
