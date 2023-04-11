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
        private AllMonAn Context;
        private HomepageFormSingle ContextHomePage;
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

        public MonAnComponent(String ten, String gia, AllMonAn context)
        {
            InitializeComponent();
            TenMon = ten;
            Context = context;
            GiaMon = gia;
            lbl_ten.Text = ten;
         lbl_gia.Text = ChangeGia(gia);
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
        public MonAnComponent(String ten, String gia, HomepageFormSingle context)
        {
            InitializeComponent();
            TenMon = ten;
            ContextHomePage = context;
            GiaMon = gia;
            lbl_ten.Text = ten;
            lbl_gia.Text = ChangeGia(gia);
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
        public void GiamSoLuong()
        {
            this.Soluongdaadd--;
        }
        private void add_them_soluong_Click(object sender, EventArgs e)
        {
            StoringMonAnComponentShoppingCart.Add(this);
            if (Context != null)
            {
                Context.Updateprice();
            }
            else
            {
                ContextHomePage.Updateprice();
            }
        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
