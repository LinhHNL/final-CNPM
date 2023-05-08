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
using WinFormsApp2;

namespace GUI
{
    public partial class ConfirmView : MetroForm
    {
        public ConfirmView()
        {

            InitializeComponent();
        }
        public void addingShowDetailMon()
        {
            //string TenMon, int SoLuong, String GiaMon,ConfirmView context
            List<Dictionary<String, String>> ListContainAllDetail = new List<Dictionary<String, String>>();
            flp_showDetailMon.Controls.Clear();
            BUS.TempBill tempBill = new BUS.TempBill();
            BUS.Menu menu = new BUS.Menu();
            if (BUS.SessionStorage.TempBillID == "-1")
            {
                this.Hide();
                AllMonAn allMonAn = new AllMonAn("0");
                allMonAn.ShowDialog();
                this.Close();
            }
            String TempBillID = tempBill.getTempBillByIDAndToken()["TempBillID"];
            if (TempBillID == "-1")
            {
                return;
            }
            else
            {
                ListContainAllDetail = tempBill.getAllTempBillDetailsOfTempBill(TempBillID);
                foreach (Dictionary<string, string> item in ListContainAllDetail)
                {
                    if (item["Status"] == "False")
                    {
                        Dictionary<String, String> FoodInfo = menu.getMonAnByID(item["MenuID"]);
                        String Name = FoodInfo["Name"];
                        flp_showDetailMon.Controls.Add(new Components.ConfirmView(item["MenuID"], Name, int.Parse(item["NumberOfFood"]), item["Price"], this));
                    }
                }
            }
        }
        private void ConfirmView_Load(object sender, EventArgs e)
        {
            addingShowDetailMon();
        }

        private void btn_ConfirmBill_Click(object sender, EventArgs e)
        {
            foreach (Components.ConfirmView item in flp_showDetailMon.Controls)
            {
                BUS.TempBill tempBill = new BUS.TempBill();
                Dictionary<String, String> StatusInfo = new Dictionary<String, String>();
                StatusInfo.Add("MenuID", item.IDMon);
                tempBill.tryingChangeStatus(StatusInfo);
            }
            addingShowDetailMon();
            this.Hide();
            AllMonAn allMonAn = new AllMonAn("0");
            allMonAn.ShowDialog();
            this.Close();
        }

        private void lbl_returnplace_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllMonAn allMonAn = new AllMonAn("0");
            allMonAn.ShowDialog();
            this.Close();
        }
    }
}
