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
    public partial class ThongKeDoanhThu : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public ThongKeDoanhThu()
        {
            InitializeComponent();
            dgv_Revenue.Rows.Add("0", "asd", "asd", "asd", "asd","adsd");
            dgv_Revenue.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_Revenue.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_Revenue.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_Revenue.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_Revenue.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_Revenue.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
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
            lbl_Profit.Text = rm.GetString("profitText", culture);
            lbl_StartDate.Text = rm.GetString("startDateText", culture);
            lbl_EndDate.Text = rm.GetString("endDateText", culture);
            lbl_TotalCapital.Text = rm.GetString("totalCapitalText", culture);
            lbl_Revenue.Text = rm.GetString("revenueText", culture);
            btn_Search.Text = rm.GetString("searchText", culture);
            lbl_Time.Text = rm.GetString("timeText", culture);
            CustomerID.HeaderText = rm.GetString("customerIDText", culture);
            CustomerName.HeaderText = rm.GetString("customerNameText", culture);
            BillID.HeaderText = rm.GetString("billIDText", culture);
            Revenue.HeaderText = rm.GetString("revenueText", culture);
            Profit.HeaderText = rm.GetString("profitText", culture);
        }
    }
}
