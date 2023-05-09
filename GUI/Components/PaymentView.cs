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
    public partial class PaymentView : UserControl
    {
        private String Tenmon = "";
        private String Giamon = "";
        private int index = 0;
        private int SoLuong = 0;
        private ShoppingCartForm context;
        public PaymentView()
        {
            InitializeComponent();
        }
        private string ChangeGia(String gia)
        {
            int price = 0;
            price = Int32.Parse(gia);
            string pricestr = price.ToString();
            string changestr = "";
            for (int i = pricestr.Length - 3; i > 0; i -= 3)
            {
                changestr = pricestr.Insert(i, ".");
                pricestr = changestr;
            }
            return pricestr + " ₫";
        }
        public PaymentView(string TenMon, int SoLuong, String GiaMon, List<MonAnComponent> list, ShoppingCartForm context)
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
            lbl_price.Text = ChangeGia((int.Parse(GiaMon)*SoLuong).ToString());
            this.context = context;
        }
        public PaymentView(string TenMon, int SoLuong, String GiaMon)
        {
            //Set số lượng
            this.Tenmon = TenMon;
            this.Giamon = GiaMon;
            this.SoLuong = SoLuong;
            InitializeComponent();
            lbl_TenMon.Text = this.Tenmon;
            lbl_SoLuong.Text = this.SoLuong.ToString();
            lbl_price.Text = ChangeGia((int.Parse(GiaMon) * SoLuong).ToString());
            this.context = context;
        }

        private void add_them_soluong_Click(object sender, EventArgs e)
        {
            MonAnComponent monancantang = StoringMonAnComponentShoppingCart.StoringMonAnComponentShoppingCartList[index - 1];
            monancantang.TangSoLuong();
            lbl_SoLuong.Text = monancantang.getSoLuong().ToString();
            context.UpdatePrice();
        }

        private void btn_giamsoluong_Click(object sender, EventArgs e)
        {
            MonAnComponent monancantang = StoringMonAnComponentShoppingCart.StoringMonAnComponentShoppingCartList[index - 1];
            if (monancantang.getSoLuong() == 1)
            {
                return;
            }
            monancantang.GiamSoLuong();
            lbl_SoLuong.Text = monancantang.getSoLuong().ToString();
            context.UpdatePrice();
        }
    }
}
