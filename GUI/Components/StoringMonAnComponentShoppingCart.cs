using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Components
{
    internal class StoringMonAnComponentShoppingCart
    {   
        public static List <MonAnComponent> StoringMonAnComponentShoppingCartList = new List<MonAnComponent>();

        public static void Add(MonAnComponent item)
        {
            if (StoringMonAnComponentShoppingCartList.Contains(StoringMonAnComponentShoppingCartList.Find(x => x.getTenMon().Equals(item.getTenMon()))))
            {
                //MonAnComponent itemcantang = StoringMonAnComponentShoppingCartList.FirstOrDefault(itemseperate => itemseperate.getTenMon().Equals(item.getTenMon()) && itemseperate.getGiaMon().Equals(itemseperate.getTenMon()));
                //itemcantang.TangSoLuong();
                StoringMonAnComponentShoppingCartList.Find(x => x.getTenMon().Equals(item.getTenMon())).TangSoLuong();
            }
            else
            {
                item.TangSoLuong();
                StoringMonAnComponentShoppingCartList.Add(item);
            }
        }
        public void Delete(MonAnComponent item)
        {
            StoringMonAnComponentShoppingCartList.Remove(item);
        }
        public void Clear()
        {
            StoringMonAnComponentShoppingCartList.Clear();
        }
        public int getLength()
        {
            return StoringMonAnComponentShoppingCartList.Count();
        }
        public List<MonAnComponent> getStoringMonAnComponentShoppingCartList()
        {
            return StoringMonAnComponentShoppingCartList;
        }
    }
}
