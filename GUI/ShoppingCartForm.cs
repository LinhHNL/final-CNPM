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
using System.Resources;
using System.Globalization;
using WinFormsApp2.KhoPage;

namespace WinFormsApp2
{
    public partial class ShoppingCartForm : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;

        public ShoppingCartForm()
        {
            InitializeComponent();
            SetLanguage("en-US");
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
            lbl_Price.Text = pricestr + " VNĐ";

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


        public void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("GUI.Language.MyResource",
                             typeof(HangHoaTrongKho).Assembly);
            lbl_mySelections.Text = rm.GetString("mySelectionsText", culture);
            btn_AccountForm.Text = rm.GetString("accountText", culture);
            btn_SignOut.Text = rm.GetString("signoutText", culture);
            btn_Back.Text = rm.GetString("backText", culture);
            btn_SignOut.Text = rm.GetString("signoutText", culture);
            lbl_Dish.Text = rm.GetString("dishText", culture);
            btn_Order.Text = rm.GetString("orderText", culture);
            lbl_Price.Text = rm.GetString("priceText", culture);
            lbl_Total.Text = rm.GetString("totalText", culture);
            lbl_DeleteAll.Text = rm.GetString("deleteAllText", culture);
        }
    }
}
