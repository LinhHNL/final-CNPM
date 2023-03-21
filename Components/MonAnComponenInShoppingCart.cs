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
        private int index = 0;
        private int SoLuong = 0;
        public MonAnComponenInShoppingCart()
        {
            InitializeComponent();
        }
        
        public MonAnComponenInShoppingCart(string TenMon,int SoLuong,String GiaMon, List<MonAnComponent> list)
        {
            // Set index
            index = list.Count();
            //Set số lượng
            this.Tenmon = TenMon;
            this.Giamon = GiaMon;
            this.SoLuong = SoLuong;
            InitializeComponent();
            lbl_TenMon.Text = this.Tenmon;
            lbl_SoLuong.Text = this.SoLuong.ToString();
            lbl_price.Text = this.Giamon;

        }


    }
}
