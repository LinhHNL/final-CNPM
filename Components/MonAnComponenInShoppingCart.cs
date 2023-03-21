using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.Components
{
    public partial class MonAnComponenInShoppingCart : UserControl
    {
        private String Tenmon = "";
        private String Giamon = "";
        private int soluong = 0;
        private int index = 0;
        public MonAnComponenInShoppingCart()
        {
            InitializeComponent();
        }
        
        public MonAnComponenInShoppingCart(MonAnComponent item, List<MonAnComponenInShoppingCart> list)
        {
            index = list.Count;
            //Set số lượng
            if (soluong == 0)
            {
                Tenmon= item.getGiaMon();
                Giamon= item.getTenMon();
                this.soluong = 1;
            }
            else
            {
                this.soluong = this.soluong++;
            }
            InitializeComponent();
            lbl_TenMon.Text = Tenmon;
            lbl_SoLuong.Text = soluong.ToString();
            lbl_price.Text = Giamon;

        }


    }
}
