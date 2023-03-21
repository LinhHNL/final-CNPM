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
    public partial class MonAnComponent : UserControl
    {
        private String TenMon = "";
        private String GiaMon = "";
        private int Soluongdaadd = 0;
        public MonAnComponent()
        {
            InitializeComponent();
        }

        public MonAnComponent(String ten, String gia)
        {
            InitializeComponent();
            TenMon = ten;
            GiaMon = gia;
            lbl_ten.Text = ten;
            lbl_gia.Text = gia;
        }
        public String getTenMon()
        {
            return TenMon;
        }
        public String getGiaMon()
        {
            return GiaMon;
        }
        public int getSoLuong()
        {
            return Soluongdaadd;
        }
        public void TangSoLuong()
        {
            this.Soluongdaadd++;
        }
        private void add_them_soluong_Click(object sender, EventArgs e)
        {
            StoringMonAnComponentShoppingCart.Add(this);
        }
    }
}
