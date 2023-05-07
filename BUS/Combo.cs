using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class Combo
    {
        public List<Dictionary<string, string>> getAllCombo()
        {
            DAO.Combo combo = new();
            return combo.getAllCombo();
        }
        
        public Dictionary<string, string> tryingAddingCombo(Dictionary<string, string> ComboInfo)
        {
            DAO.Combo combo = new();
            return combo.tryingAddingCombo(ComboInfo);
        }
        public bool tryingAddingComboDetail(Dictionary<string, string> ComboInfo)
        {
            DAO.Combo combo = new();
            return combo.tryingAddingComboDetail(ComboInfo);
        }
        public bool tryingFlipStatusCombo(Dictionary<string, string> ComboInfo)
        {
            DAO.Combo combo = new();
            return combo.tryingFlipStatusCombo(ComboInfo);
        }
    }
}
