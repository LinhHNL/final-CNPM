using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Components;

namespace WinFormsApp2
{
    public partial class ShoppingCartForm : MetroFramework.Forms.MetroForm
    {

        public ShoppingCartForm()
        {
            InitializeComponent();
        }
        public void UpdatePrice()
        {
            int price = 0;
            int tmpprice = 0;
            foreach (MonAnComponent i in StoringMonAnComponentShoppingCart.StoringMonAnComponentShoppingCartList)
            {
                tmpprice = Int32.Parse(i.getGiaMon()) * i.getSoLuong();
                price += tmpprice;
            }
            string pricestr = price.ToString();
            string changestr = "";
            for (int i = pricestr.Length - 3; i > 0; i -= 3)
            {
                changestr = pricestr.Insert(i, ".");
                pricestr = changestr;
            }
            lbl_priceshow.Text = pricestr + " VNĐ";

        }
        private void ShoppingCartForm_Load(object sender, EventArgs e)
        {
            List<MonAnComponent> listdachon = StoringMonAnComponentShoppingCart.StoringMonAnComponentShoppingCartList;
            List<MonAnComponent> listdaxuly = new List<MonAnComponent>();
            int price = 0;
            int tmpprice = 0;
            // MessageBox.Show(listdachon.Count().ToString());
            foreach (MonAnComponent i in listdachon)
            {
                listdaxuly.Add(i);
                flp_Hienthimonan.Controls.Add(new MonAnComponenInShoppingCart(i.getTenMon(), i.getSoLuong(), i.getGiaMon(), listdaxuly, this));

            }
            this.UpdatePrice();
        }

        private void lbl_returnplace_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllMonAn MonAn = new AllMonAn();
            MonAn.ShowDialog();
            this.Close();
        }


        private void lbl_deleteAll_Click(object sender, EventArgs e)
        {
            StoringMonAnComponentShoppingCart.StoringMonAnComponentShoppingCartList.Clear();
            this.Hide();
            AllMonAn MonAn = new AllMonAn();
            MonAn.ShowDialog();
            this.Close();
        }

        private void PB_Delicon_Click(object sender, EventArgs e)
        {
            StoringMonAnComponentShoppingCart.StoringMonAnComponentShoppingCartList.Clear();
            this.Hide();
            AllMonAn MonAn = new AllMonAn();
            MonAn.ShowDialog();
            this.Close();
        }

        private void btn_submitfood_Click(object sender, EventArgs e)
        {
        }
    }
}
