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
    public partial class KiemKhoXemPhieuNhapHang : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public KiemKhoXemPhieuNhapHang()
        {
            InitializeComponent();
            dgv_Import.Rows.Add("0", "asd", "asd");
            dgv_Import.Rows.Add("0", "asd", "asd");
            dgv_Import.Rows.Add("0", "asd", "asd");
            dgv_Import.Rows.Add("0", "asd", "asd");
            dgv_Import.Rows.Add("0", "asd", "asd");
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

        private void btn_Export_Click(object sender, EventArgs e)
        {
            btn_Import.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            this.Hide();
            KiemKhoXuatHang form = new KiemKhoXuatHang();
            form.ShowDialog();
            this.Close();
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
            btn_Edit.Text = rm.GetString("editText", culture);
            btn_ExportFile.Text = rm.GetString("exportFileText", culture);
            CommodityName.HeaderText = rm.GetString("commodityIDNameText", culture);
            CommodityID.HeaderText = rm.GetString("commodityIDText", culture);
            Unit.HeaderText = rm.GetString("unitText", culture);
            Quantity.HeaderText = rm.GetString("quantityText", culture);
            lbl_ImportID.Text = rm.GetString("importIDText", culture);
            lbl_ImportDate.Text = rm.GetString("importDateText", culture);
            btn_Save.Text = rm.GetString("saveText", culture);
            btn_Edit.Text = rm.GetString("editText", culture);
            lbl_ImportNote.Text = rm.GetString("importNoteText", culture);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
        }
    }
}
