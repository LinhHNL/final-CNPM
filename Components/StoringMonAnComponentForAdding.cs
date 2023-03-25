using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Components
{
    internal class StoringMonAnComponentForAdding
    {
        public static List<MonAnComponentForAdding> StoringMonAnAdding = new List<MonAnComponentForAdding>();

        public static void Add(MonAnComponentForAdding item)
        {
            if (item.getTrangThai())
            {
                //MonAnComponentForAdding itemcantang = StoringMonAnAdding.FirstOrDefault(itemseperate => itemseperate.getTenMon().Equals(item.getTenMon()) && itemseperate.getGiaMon().Equals(itemseperate.getTenMon()));
                //itemcantang.TangSoLuong();
                StoringMonAnAdding.Add(item);
            }
        }
        public void Delete(MonAnComponentForAdding item)
        {
            StoringMonAnAdding.Remove(item);
        }
        public void Clear()
        {
            StoringMonAnAdding.Clear();
        }
        public int getLength()
        {
            return StoringMonAnAdding.Count();
        }
        public List<MonAnComponentForAdding> getStoringMonAnAdding()
        {
            return StoringMonAnAdding;
        }
    }
}
