using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class Warehouse
    {
     public List<Dictionary<String, string>> gettingCommodity()
        {
            DAO.Warehouse Warehouse = new DAO.Warehouse();
            return Warehouse.getAllCommodity();

        }
        public Dictionary<String, String> getCommodityByID(int id)
        {
            DAO.Warehouse Warehouse = new DAO.Warehouse();
            return Warehouse.getCommodityById(id);
        }
    }
}
