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
using WinFormsApp2.KhoPage;

namespace WinFormsApp2.Statistic
{
    public partial class ThongKeNhapHang : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public ThongKeNhapHang()
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

        private void roundedButton1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(ColorTranslator.FromHtml("#A09F9F"));
            pen.Width = 2;
            e.Graphics.DrawLine(pen, 0, 37, 698, 37);
        }

        private void btn_NhapHang_Paint(object sender, PaintEventArgs e)
        {
            if (btn_Import.ForeColor == ColorTranslator.FromHtml("#E50111"))
            {
                Pen penOne = new Pen(ColorTranslator.FromHtml("#A09F9F"));
                penOne.Width = 2;
                e.Graphics.DrawLine(penOne, 0, 0, 306, 0);
                Pen penSecond = new Pen(ColorTranslator.FromHtml("#A09F9F"));
                penSecond.Width = 2;
                e.Graphics.DrawLine(penSecond, 10, 0, 306, 0);
            }
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

        private void btn_Export_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKeXuatHang form = new ThongKeXuatHang();
            form.ShowDialog();
            this.Close();
        }
    }
}
