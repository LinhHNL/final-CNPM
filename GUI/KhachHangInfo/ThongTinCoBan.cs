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
    public partial class ThongTinCoBan : MetroForm
    {
        CultureInfo culture;
        public ThongTinCoBan()
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
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
            lbl_myProfile.Text = rm.GetString("myProfileText", culture);
            lbl_FullName.Text = rm.GetString("fullNameText", culture);
            lbl_Phone.Text = rm.GetString("phoneText", culture);
            lbl_Address.Text = rm.GetString("addressText", culture);
            lbl_membershipLevel.Text = rm.GetString("membershipLevelText", culture);
            btn_edit.Text = rm.GetString("editText", culture);
            btn_specialOffer.Text = rm.GetString("specialOfferText", culture);
        }
    }
}
