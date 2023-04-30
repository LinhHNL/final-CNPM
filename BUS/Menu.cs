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
        public List<Dictionary<string, string>> getAllMenu()
        {
            DAO.Menu menu = new DAO.Menu();
            return menu.getAllMonAn();
        }
        public bool changeStatusMenu(Dictionary<string, string> StatusInfo)
        {
            DAO.Menu menu = new DAO.Menu();
            return menu.tryingChangeStatus(StatusInfo);
        }
    }
}
