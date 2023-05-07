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

namespace GUI.ThanhToan
{
    public partial class Payment : MetroForm
    {
        CultureInfo culture;
        public Payment()
        {
            InitializeComponent();
            culture = CultureInfo.CurrentCulture;
            SetLanguage("en-US");
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("GUI.Language.MyResource", typeof(HoaDonTong).Assembly);
            lbl_paymentDetail.Text = rm.GetString("paymentDetailText", culture);
            lbl_idbill.Text = rm.GetString("billIDText", culture);
            lbl_totalMoney.Text = rm.GetString("totalText", culture);
            lbl_datePayment.Text = rm.GetString("paymentDateText",culture);
            lbl_offer.Text = rm.GetString("offerText", culture);
            cb_offerID.Texts = rm.GetString("offerIDText", culture);
            lbl_paymentMethod.Text = rm.GetString("paymentMethodText", culture);
            cb_paymentMethod.Texts = rm.GetString("paymentMethodText", culture);
            btn_pay.Text = rm.GetString("payText", culture);
        }
    }
}
