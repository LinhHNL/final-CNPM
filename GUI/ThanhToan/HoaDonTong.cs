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
    public partial class HoaDonTong : MetroForm
    {
        CultureInfo culture;
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
    }
}
