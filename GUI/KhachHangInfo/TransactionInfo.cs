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
using WinFormsApp2.AdminPage;

namespace GUI.KhachHangInfo
{
    public partial class TransactionInfo : MetroForm
    {
        CultureInfo culture;
        public TransactionInfo()
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
            lbl_bill.Text = rm.GetString("billText", culture);
            btn_specialOffer.Text = rm.GetString("specialOfferText", culture);
        }
    }
}
