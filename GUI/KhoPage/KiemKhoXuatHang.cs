using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;

namespace WinFormsApp2.KhoPage
{
    public partial class KiemKhoXuatHang : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public KiemKhoXuatHang()
        {
            InitializeComponent();

            BUS.Order order = new BUS.Order();
            List<Dictionary<string, string>> ExportList = order.getAllExportOrder();
            foreach (Dictionary<string, string> item in ExportList)
            {
                dgv_XuatHang.Rows.Add(item["ExportOrderID"], item["Date"], item["Name"]);
            }
            SetLanguage("en-US");
        }

        private void btn_PhieuXuatHang_Click(object sender, EventArgs e)
        {
            int numberofID = dgv_XuatHang.RowCount;
            this.Hide();
            KiemKhoTaoPhieuXuatHang form = new KiemKhoTaoPhieuXuatHang(numberofID);
            form.ShowDialog();
            this.Close();
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
        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            btn_Import.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            this.Hide();
            KiemKhoNhapHang form = new KiemKhoNhapHang();
            form.ShowDialog();
            this.Close();
        }
        private void dgv_XuatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string value = "";
                if (dgv_XuatHang.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    value = "";
                }
                else
                {
                    value = dgv_XuatHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.Hide();
                    KiemKhoXemPhieuXuatHang form = new KiemKhoXemPhieuXuatHang(value);
                    form.ShowDialog();
                    this.Close();
                }
            }
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
            btn_ExportNoteAdd.Text = rm.GetString("exportNoteAddText", culture);
            ExportID.HeaderText = rm.GetString("exportIDText", culture);
            Exporter.HeaderText = rm.GetString("exporterText", culture);
            DayHour.HeaderText = rm.GetString("dayHourText", culture);
            lbl_Export.Text = rm.GetString("exportText", culture);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
        }
    }
}
