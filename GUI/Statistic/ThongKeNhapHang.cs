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
    public partial class ThongKeNhapHang : MetroFramework.Forms.MetroForm
    {
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
        }

        private void roundedButton1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(ColorTranslator.FromHtml("#A09F9F"));
            pen.Width = 2;
            e.Graphics.DrawLine(pen, 0, 37, 698, 37);
        }

        private void btn_NhapHang_Paint(object sender, PaintEventArgs e)
        {
            if (btn_NhapHang.ForeColor == ColorTranslator.FromHtml("#E50111"))
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
    }
}
