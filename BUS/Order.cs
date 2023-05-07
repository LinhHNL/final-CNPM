using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class Order
    {
        public List<Dictionary<string, string>> getAllImportOrder()
        {
            DAO.Order order = new DAO.Order();
            return order.getAllImportOrder();
        }
        public List<Dictionary<string, string>> getAllExportOrder()
        {
            DAO.Order order = new DAO.Order();
            return order.getAllExportOrder();
        }
    }
}
