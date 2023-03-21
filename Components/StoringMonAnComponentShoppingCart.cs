using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Components
{
    internal class StoringMonAnComponentShoppingCart
    {   
        private List <MonAnComponenInShoppingCart> StoringMonAnComponentShoppingCartList = new List<MonAnComponenInShoppingCart>();
    
        public void Add(MonAnComponenInShoppingCart item)
        {
            StoringMonAnComponentShoppingCartList.Add(item);
        }
        public void Delete(MonAnComponenInShoppingCart item)
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
        public List<MonAnComponenInShoppingCart> getStoringMonAnComponentShoppingCartList()
        {
            return StoringMonAnComponentShoppingCartList;
        }
    }
}
