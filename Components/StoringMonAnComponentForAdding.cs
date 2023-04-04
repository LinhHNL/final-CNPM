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
            if (StoringMonAnAdding.Contains(StoringMonAnAdding.Find(x => x.getTenMon().Equals(item.getTenMon()))))
            {
                //MonAnComponent itemcantang = StoringMonAnComponentShoppingCartList.FirstOrDefault(itemseperate => itemseperate.getTenMon().Equals(item.getTenMon()) && itemseperate.getGiaMon().Equals(itemseperate.getTenMon()));
                //itemcantang.TangSoLuong();
                StoringMonAnAdding.Find(x => x.getTenMon().Equals(item.getTenMon())).TangSoLuong();
            }
            else
            {
                item.TangSoLuong();
                StoringMonAnAdding.Add(item);
            }
        }
        public static void Remove(String tenmon) {
          ;
            MonAnComponentForAdding itemneedtoremove = StoringMonAnAdding.Find(x => x.getTenMon().Equals(tenmon));
            int index = 0;
            foreach (MonAnAddingInPanel i in StoringMonAnPanel.StoringMonAnPanelList)
            {
                if (tenmon.Equals(i.getTen()))
                {
                    index = i.getIndex();
                    break;
                }
            }
            StoringMonAnAdding.Remove(itemneedtoremove);
            for(int i=index-1;i<StoringMonAnPanel.StoringMonAnPanelList.Count;i++)
            {
                StoringMonAnPanel.StoringMonAnPanelList[i].setIndex(i-1);
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
