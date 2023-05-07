using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;


namespace WinFormsApp2.KhoPage
{
    public partial class KiemKhoTaoPhieuNhapHang : MetroFramework.Forms.MetroForm
    {
        private int IDMonHang = 0;

        public KiemKhoTaoPhieuNhapHang(int iDMonHang)
        {
            InitializeComponent();
            
            this.IDMonHang = iDMonHang;
            SetLanguage("en-US");
        }
        private void btn_HangTrongKho_Click(object sender, EventArgs e)
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

        private void btn_XuatHang_Click(object sender, EventArgs e)
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
            btn_CreateNote.Text = rm.GetString("createNoteText", culture);
            btn_Add.Text = rm.GetString("addText", culture);
            btn_ExportFile.Text = rm.GetString("exportFileText", culture);
            CommodityName.HeaderText = rm.GetString("commodityIDNameText", culture);
            CommodityID.HeaderText = rm.GetString("commodityIDText", culture);
            Unit.HeaderText = rm.GetString("unitText", culture);
            Quantity.HeaderText = rm.GetString("quantityText", culture);
            lbl_ImportID.Text = rm.GetString("importIDText", culture);
            lbl_ImportNote.Text = rm.GetString("importNoteText", culture);
            lbl_ImportDate.Text = rm.GetString("importDateText", culture);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
        }
    }
}
