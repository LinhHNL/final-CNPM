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
using System.Resources;
using System.Globalization;
using System.Text.RegularExpressions;
using WinFormsApp2.KhoPage;

namespace GUI.Kitchen
{
    public partial class ViewingKitchen : MetroForm
    {
        CultureInfo culture;
        public ViewingKitchen()
        {
            InitializeComponent();
            SetLanguage("en-US");
        }

        private void ViewingKitchen_Load(object sender, EventArgs e)
        {
            flp_ShowBillTemp.Controls.Clear();
            BUS.TempBill TempBill = new BUS.TempBill();
            List<Dictionary<string, string>> TempBilList = TempBill.getTempBillNotDone();
            foreach (Dictionary<string, string> item in TempBilList)
            {
                    flp_ShowBillTemp.Controls.Add(new KitchenView(item["TempBillID"], this));
            }
        }

        public void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("GUI.Language.MyResource",
                             typeof(HangHoaTrongKho).Assembly);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);



            lbl_MakeDishBill.Text = rm.GetString("makeDishBillText", culture);
            btn_SignOut.Text = rm.GetString("signoutText", culture);

        }
    }
}
