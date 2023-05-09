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
        string pricestrValue = "0";
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
            pricestrValue= pricestr;
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
                flp_Hienthimonan.Controls.Add(new MonAnComponenInShoppingCart(i.getMenuID(),i.getTenMon(), i.getSoLuong(), i.getGiaMon(), listdaxuly, this));

            }
            this.UpdatePrice();
        }

        private void lbl_returnplace_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllMonAn MonAn = new AllMonAn("0", 1);
            MonAn.ShowDialog();
            this.Close();
        }


        private void lbl_deleteAll_Click(object sender, EventArgs e)
        {
            StoringMonAnComponentShoppingCart.StoringMonAnComponentShoppingCartList.Clear();
            this.Hide();
            AllMonAn MonAn = new AllMonAn("1", 1);
            MonAn.ShowDialog();
            this.Close();
        }

        private void PB_Delicon_Click(object sender, EventArgs e)
        {
            StoringMonAnComponentShoppingCart.StoringMonAnComponentShoppingCartList.Clear();
            this.Hide();
            AllMonAn MonAn = new AllMonAn("1", 1);
            MonAn.ShowDialog();
            this.Close();
        }

        private void btn_submitfood_Click(object sender, EventArgs e)
        {
            BUS.TempBill tempBill = new BUS.TempBill();
            Dictionary<String,String> tempBillInfo=new Dictionary<String,String>();
            Dictionary<String, String> IDInfo = new Dictionary<String, String>();
            tempBillInfo.Add("Price", pricestrValue);
            if (BUS.SessionStorage.TempBillID.Equals("-1"))
            {
            IDInfo=tempBill.tryingInsertTempBill(tempBillInfo);
            BUS.SessionStorage.TempBillID = IDInfo["TempBilID"];
            }
            if (BUS.SessionStorage.TempBillID != "-1")
            {
                foreach(MonAnComponenInShoppingCart item in flp_Hienthimonan.Controls)
                {
                    if (item.MenuID != "-1")
                    {
                        Dictionary<String, String> tempBillDetailInfo = new Dictionary<String, String>();
                       
                        tempBillDetailInfo.Add("MenuID", item.MenuID);
                        tempBillDetailInfo.Add("Number", item.SoLuong.ToString());
                        tempBillDetailInfo.Add("Price",item.Giamon.ToString());
                        BUS.TempBill tempBill1 = new BUS.TempBill();
                        tempBill1.tryingInsertTempBillDetail(tempBillDetailInfo);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                        return;
                    }
                }
                this.Hide();
                AllMonAn allMonAn = new AllMonAn("1", 1);
                allMonAn.ShowDialog();
                this.Close();
            }
            else{
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
