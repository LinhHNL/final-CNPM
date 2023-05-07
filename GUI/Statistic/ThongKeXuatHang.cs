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
using WinFormsApp2.KhoPage;
using System.Resources;
using System.Globalization;

namespace WinFormsApp2.Statistic
{
    public partial class ThongKeXuatHang : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public ThongKeXuatHang()
        {
            InitializeComponent();
            dgv_SanPhamBanRa.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_SanPhamBanRa.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_SanPhamBanRa.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_SanPhamBanRa.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_SanPhamBanRa.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_SanPhamBanRa.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_SanPhamBanRa.Rows.Add("0", "asd", "asd", "asd", "asd");
            SetLanguage("en-US");
        }

        private void btn_XuatHang_Paint(object sender, PaintEventArgs e)
        {
            if (btn_Export.ForeColor == ColorTranslator.FromHtml("#E50111"))
            {
                Pen pen = new Pen(ColorTranslator.FromHtml("#A09F9F"));
                pen.Width = 2;
                e.Graphics.DrawLine(pen, 0, 0, 306, 0);
            }
        }

        private void roundedButton1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(ColorTranslator.FromHtml("#A09F9F"));
            pen.Width = 2;
            e.Graphics.DrawLine(pen, 0, 37, 698, 37);
        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKeNhapHang form = new ThongKeNhapHang();
            form.ShowDialog();
            this.Close();
        }

        private void btn_SanPhamBanRa_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKeSanPhamBanRa form = new ThongKeSanPhamBanRa();
            form.ShowDialog();
            this.Close();
        }

        private void btn_NhapXuatHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKeXuatHang form = new ThongKeXuatHang();
            form.ShowDialog();
            this.Close();
        }

        private void btn_KhoHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKeKhoHang form = new ThongKeKhoHang();
            form.ShowDialog();
            this.Close();
        }

        private void btn_LuongNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKeLuongNhanVien form = new ThongKeLuongNhanVien();
            form.ShowDialog();
            this.Close();
        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKeDoanhThu form = new ThongKeDoanhThu();
            form.ShowDialog();
            this.Close();
        }
        public void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("GUI.Language.MyResource",
                             typeof(HangHoaTrongKho).Assembly);
            btn_Revenue.Text = rm.GetString("revenueText", culture);
            btn_SoldProducts.Text = rm.GetString("soldProductsText", culture);
            btn_ImportExport.Text = rm.GetString("importExportText", culture);
            btn_SignOut.Text = rm.GetString("signoutText", culture);
            btn_StaffSalary.Text = rm.GetString("staffSalaryText", culture);
            btn_SignOut.Text = rm.GetString("signoutText", culture);
            btn_Stock.Text = rm.GetString("stockText", culture);
            btn_ExportFile.Text = rm.GetString("exportFileText", culture);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
            lbl_Detail.Text = rm.GetString("detailText", culture);
            lbl_StartDate.Text = rm.GetString("startDateText", culture);
            lbl_EndDate.Text = rm.GetString("endDateText", culture);
            btn_Search.Text = rm.GetString("searchText", culture);
            Number.HeaderText = rm.GetString("numberText", culture);
            CommodityID.HeaderText = rm.GetString("commodityIDText", culture);
            CommodityName.HeaderText = rm.GetString("commodityNameText", culture);
            Quantity.HeaderText = rm.GetString("quantityText", culture);
            btn_Import.Text = rm.GetString("importText2", culture);
            btn_Export.Text = rm.GetString("exportText2", culture);
            lbl_Time.Text = rm.GetString("timeText", culture);

        }
    }
}
