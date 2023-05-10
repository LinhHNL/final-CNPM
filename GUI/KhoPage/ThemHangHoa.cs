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

namespace WinFormsApp2.KhoPage
{
    public partial class ThemHangHoa : MetroFramework.Forms.MetroForm
    {
        private int numberofRows = 0;
        CultureInfo culture;
        public ThemHangHoa(int numberofRows)
        {
            InitializeComponent();
            this.numberofRows = numberofRows;
            SetLanguage("en-US");
        }

        private void ThemHangHoa_Load(object sender, EventArgs e)
        {
            this.tb_CommodityID.Texts = "HH" + this.numberofRows.ToString();
        }

        private void btn_KiemKho_Click(object sender, EventArgs e)
        {
            btn_InStock.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            btn_InStock.BackColor = ColorTranslator.FromHtml("white");
            btn_InventoryControl.BackColor = ColorTranslator.FromHtml("#E50111");
            btn_InventoryControl.ForeColor = ColorTranslator.FromHtml("white");
            if (btn_Import.Visible == false)
            {
                btn_Import.Visible = true;
                btn_Export.Visible = true;
            }
            else
            {
                btn_Import.Visible = false;
                btn_Export.Visible = false;
            }
            this.Hide();
            KiemKhoXuatHang form = new KiemKhoXuatHang();
            form.ShowDialog();
            this.Close();
        }

        private void ThemHangHoa_Load_1(object sender, EventArgs e)
        {

        }

        public void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("GUI.Language.MyResource",
                             typeof(HangHoaTrongKho).Assembly);
            btn_InStock.Text = rm.GetString("inStockText", culture);
            btn_InventoryControl.Text = rm.GetString("inventoryControlText", culture);
            btn_Import.Text = rm.GetString("importText", culture);
            btn_Export.Text = rm.GetString("exportText", culture);
            btn_SignOut.Text = rm.GetString("signoutText", culture);
            btn_Save.Text = rm.GetString("saveText", culture);
            lbl_CommodityID.Text = rm.GetString("commodityIDText", culture);
            lbl_CommodityAdd.Text = rm.GetString("commodityAddText", culture);
            lbl_CommodityName.Text = rm.GetString("commodityNameText", culture);
            lbl_Unit.Text = rm.GetString("unitText", culture);
            lbl_Quantity.Text = rm.GetString("quantityText", culture);
            lbl_CommodityName.Text = rm.GetString("commodityNameText", culture);
            lbl_ImportDate.Text = rm.GetString("importDateText", culture);
            btn_Save.Text = rm.GetString("saveText", culture);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
        }
    }
}
