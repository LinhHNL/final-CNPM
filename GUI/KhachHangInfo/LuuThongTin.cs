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
using WinFormsApp2.AdminPage;

namespace GUI.KhachHangInfo
{
    public partial class LuuThongTin : MetroForm
    {
        CultureInfo culture;
        public LuuThongTin()
        {
            InitializeComponent();
            culture = CultureInfo.CurrentCulture;
            SetLanguage("en-US");
        }
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("GUI.Language.MyResource", typeof(AddFood).Assembly);
            btn_profile.Text = rm.GetString("profileText", culture);
            btn_bill.Text = rm.GetString("billText", culture);
            btn_specialOffer.Text = rm.GetString("specialOfferText", culture);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
            lbl_myProfile.Text = rm.GetString("myProfileText", culture);
            btn_order.Text = rm.GetString("orderText", culture);
            btn_Signout.Text = rm.GetString("signoutText", culture);
            lbl_FullName.Text = rm.GetString("fullNameText", culture);
            lbl_Phone.Text = rm.GetString("phoneText",culture);
            lbl_Address.Text = rm.GetString("addressText", culture);
            btn_Save.Text = rm.GetString("saveText", culture);
        }
    }
}
