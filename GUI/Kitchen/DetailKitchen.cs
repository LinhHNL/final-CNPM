using GUI.Components;
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

namespace GUI.Kitchen
{
    public partial class DetailKitchen : MetroForm
    {
        private String BillID = "";
        public DetailKitchen(string billID)
        {
            InitializeComponent();
            BillID = billID;
            lbl_billidvalue.Text = billID;
        }

        private void DetailKitchen_Load(object sender, EventArgs e)
        {
            /* flp_showDetailMon.Controls.Clear();
            BUS.TempBill TempBill = new BUS.TempBill();
            List<Dictionary<string, string>> tempDetailList = TempBill.GetAllTempBillDetailsOfTempBill(BillID);
            BUS.Menu menu = new BUS.Menu();
            foreach (Dictionary<string, string> item in tempDetailList)
            {
                Dictionary<string, string> MonAnInfo = new Dictionary<string, string>();
                MonAnInfo = menu.getMonAnByID(item["MenuID"]);
                flp_showDetailMon.Controls.Add(new MonAnComponentForKitchen(item["MenuID"], MonAnInfo["Name"], int.Parse(item["NumberOfFood"])));
            }*/
        }

        private void btn_ChangeStatus_Click(object sender, EventArgs e)
        {
            /*BUS.TempBill TempBill = new BUS.TempBill();
            Dictionary<string, string> StatusInfo=new Dictionary<string, string>();
            foreach (MonAnComponentForKitchen element in flp_showDetailMon.Controls.OfType<MonAnComponentForKitchen>())
            {
                StatusInfo.Add("MenuID", element.getMenuID());
                StatusInfo.Add("BillID", BillID);
                TempBill.tryingChangeStatus(StatusInfo);
            }
            this.Hide();
            ViewingKitchen ViewingKitchen = new ViewingKitchen();
            ViewingKitchen.Show();
            this.Close();*/
        }
    }
}
