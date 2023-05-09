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
    public partial class KiemKhoXemPhieuXuatHang : MetroFramework.Forms.MetroForm
    {
        String valueofID = "";
        CultureInfo culture;
        public KiemKhoXemPhieuXuatHang(String valueofID)
        {
            InitializeComponent();
            this.valueofID = valueofID;
            SetLanguage("en-US");
        }
        private void btn_InStock_Click(object sender, EventArgs e)
        {
            btn_InStock.ForeColor = ColorTranslator.FromHtml("white");
            btn_InStock.BackColor = ColorTranslator.FromHtml("#E50111");
            btn_InventoryControl.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            btn_InventoryControl.BackColor = ColorTranslator.FromHtml("white");
            btn_Import.Visible = false;
            btn_Export.Visible = false;
            this.Hide();
            HangHoaTrongKho form = new HangHoaTrongKho();
            form.ShowDialog();
            this.Close();
        }
        private void btn_Import_Click(object sender, EventArgs e)
        {
            btn_Import.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            this.Hide();
            KiemKhoNhapHang form = new KiemKhoNhapHang();
            form.ShowDialog();
            this.Close();
        }

        public void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("GUI.Language.MyResource",
                             typeof(KiemKhoSuaPhieuXuatHang).Assembly);
            btn_InStock.Text = rm.GetString("inStockText", culture);
            btn_InventoryControl.Text = rm.GetString("inventoryControlText", culture);
            btn_Import.Text = rm.GetString("importText", culture);
            btn_Export.Text = rm.GetString("exportText", culture);
            btn_SignOut.Text = rm.GetString("signoutText", culture);
            btn_Edit.Text = rm.GetString("editText", culture);
            btn_Save.Text = rm.GetString("saveText", culture);
            CommodityName.HeaderText = rm.GetString("commodityIDNameText", culture);
            CommodityID.HeaderText = rm.GetString("commodityIDText", culture);
            Unit.HeaderText = rm.GetString("unitText", culture);
            Quantity.HeaderText = rm.GetString("quantityText", culture);
            lbl_ExportID.Text = rm.GetString("exportIDText", culture);
            lbl_ExportNote.Text = rm.GetString("exportNoteText", culture);
            lbl_ExportDate.Text = rm.GetString("exportDateText", culture);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
            lbl_Exporter.Text = rm.GetString("exporterText", culture);
        }
    }
}
