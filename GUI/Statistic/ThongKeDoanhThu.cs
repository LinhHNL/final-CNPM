using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.Statistic
{
    public partial class ThongKeDoanhThu : MetroFramework.Forms.MetroForm
    {
        public ThongKeDoanhThu()
        {
            InitializeComponent();
            dgv_DoanhThu.Rows.Add("0", "asd", "asd", "asd", "asd","adsd");
            dgv_DoanhThu.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_DoanhThu.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_DoanhThu.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_DoanhThu.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_DoanhThu.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_DoanhThu.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
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
    }
}
