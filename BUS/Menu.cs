using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class Menu
    {
        public bool addMenu(Dictionary<string, string> MenuInfo)
        {
            DAO.Menu menu = new DAO.Menu();
            return menu.tryingAddingMonAn(MenuInfo);
        }
    }
}
