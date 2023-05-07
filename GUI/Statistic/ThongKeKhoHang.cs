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
    public partial class ThongKeKhoHang : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public ThongKeKhoHang()
        {
            InitializeComponent();
            dgv_SoldProducts.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_SoldProducts.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_SoldProducts.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_SoldProducts.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_SoldProducts.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_SoldProducts.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_SoldProducts.Rows.Add("0", "asd", "asd", "asd", "asd");
            SetLanguage("en-US");
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
            btn_Search.Text = rm.GetString("searchText", culture);
            Number.HeaderText = rm.GetString("numberText", culture);
            ProductID.HeaderText = rm.GetString("productIDText", culture);
            ProductName.HeaderText = rm.GetString("productNameText", culture);
            InStockQuantity.HeaderText = rm.GetString("inStockQuantityText", culture);
        }
    }
}
