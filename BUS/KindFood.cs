using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class KindFood
    {
        public List<Dictionary<string, string>> gettingKindFood() { 
            DAO.KindFood kindFood = new DAO.KindFood();
            return kindFood.getAllKindFood();
        }
    }
}
