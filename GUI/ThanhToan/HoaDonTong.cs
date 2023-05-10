using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System.Text.RegularExpressions;
using WinFormsApp2.Components;

namespace GUI.ThanhToan
{
    public partial class HoaDonTong : MetroForm
    {
        CultureInfo culture;
        List<Dictionary<String, String>> ListContainAllDetail = new List<Dictionary<String, String>>();
        public HoaDonTong()
        {
            InitializeComponent();
            culture = CultureInfo.CurrentCulture;
            SetLanguage("en-US");
        }

        private void lbl_billidvalue_Click(object sender, EventArgs e)
        {

        }
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("GUI.Language.MyResource", typeof(HoaDonTong).Assembly);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
            lbl_paymentDetail.Text = rm.GetString("paymentDetailText", culture);
            lbl_idbill.Text = rm.GetString("billIDText", culture);
            lbl_totalMoney.Text = rm.GetString("totalMoneyText", culture);
            lbl_orderedDishesList.Text = rm.GetString("orderedDishesListText", culture);
            lbl_food.Text = rm.GetString("dishText", culture);
            lbl_quantity.Text = rm.GetString("quantityText", culture);
            lbl_price.Text = rm.GetString("priceText", culture);
            btn_confirm.Text = rm.GetString("confirmText", culture);
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
        int Price = 0;
        private void HoaDonTong_Load(object sender, EventArgs e)
        {

            flp_showDetailMon.Controls.Clear();
            BUS.TempBill tempBill = new BUS.TempBill();
            BUS.Menu menu = new BUS.Menu();
            String TempBillID = tempBill.getTempBillByIDAndToken()["TempBillID"];
            lbl_billidvalue.Text = TempBillID.ToString();
            if (TempBillID == "-1")
            {
                return;
            }
            else
            {
                ListContainAllDetail = tempBill.getAllTempBillDetailsOfTempBill(TempBillID);
                foreach (Dictionary<string, string> item in ListContainAllDetail)
                {
                    if (item["Status"] == "True")
                    {
                        Dictionary<String, String> FoodInfo = menu.getMonAnByID(item["MenuID"]);
                        String Name = FoodInfo["Name"];
                        flp_showDetailMon.Controls.Add(new PaymentView(Name, int.Parse(item["NumberOfFood"]), item["Price"], item["MenuID"]));
                        Price += int.Parse(item["NumberOfFood"]) * int.Parse(item["Price"]);
                    }
                }
                lbl_TotalMoneyValue.Text = ChangeGia(Price.ToString());
            }
        }

       

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment HoaDonTong = new Payment(ListContainAllDetail, Price);
            HoaDonTong.ShowDialog();
            this.Close();
        }
    }
}
