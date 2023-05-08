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
using WinFormsApp2.Components;

namespace GUI.ThanhToan
{
    public partial class HoaDonTong : MetroForm
    {
        public HoaDonTong()
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
        int Price = 0;
        private void HoaDonTong_Load(object sender, EventArgs e)
        {
            List<Dictionary<String, String>> ListContainAllDetail = new List<Dictionary<String, String>>();
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

        private void btn_ChangeStatus_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDonTong HoaDonTong = new HoaDonTong();
            HoaDonTong.ShowDialog();
            this.Close();
        }
    }
}
