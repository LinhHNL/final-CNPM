using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using BUS;
namespace WinFormsApp2.KhoPage
{
    public partial class KiemKhoNhapHang : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public KiemKhoNhapHang()
        {

            InitializeComponent();

            BUS.Order order = new BUS.Order();
            List<Dictionary<string, string>> importList = order.getAllImportOrder();
            foreach (Dictionary<string, string> item in importList)
            {
                
                dgv_Import.Rows.Add(item["ImportOrderID"], item["Date"], item["Name"]);
            }
            SetLanguage("en-US");
        }

        private void btn_ImportNoteAdd_Click(object sender, EventArgs e)
        {
            int numberofID = dgv_Import.RowCount;
            this.Hide();
            KiemKhoTaoPhieuNhapHang form = new KiemKhoTaoPhieuNhapHang(numberofID);
            form.ShowDialog();
            this.Close();
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
        private void dgv_NhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string value = "";
                if (dgv_Import.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    value = "";
                }
                else
                {
                    value = dgv_Import.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.Hide();
                    KiemKhoXemPhieuNhapHang form = new KiemKhoXemPhieuNhapHang(value);
                    form.ShowDialog();
                    this.Close();
                }
            }
        }
        public void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("GUI.Language.MyResource",
                             typeof(KiemKhoNhapHang).Assembly);
            btn_InStock.Text = rm.GetString("inStockText", culture);
            btn_InventoryControl.Text = rm.GetString("inventoryControlText", culture);
            btn_Import.Text = rm.GetString("importText", culture);
            btn_Export.Text = rm.GetString("exportText", culture);
            btn_SignOut.Text = rm.GetString("signoutText", culture);
            btn_ImportNoteAdd.Text = rm.GetString("importNoteAddText", culture);
            lbl_Import.Text = rm.GetString("importText", culture);
            ImportID.HeaderText = rm.GetString("importIDText", culture);
            DayHour.HeaderText = rm.GetString("dayHourText", culture);
            Status.HeaderText = rm.GetString("statusText", culture);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
        }
    }
}
