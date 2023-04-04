using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.NhanVienPage
{
    public partial class ThongTinCoBanNhanVien_BHXH : MetroFramework.Forms.MetroForm
    {
        public ThongTinCoBanNhanVien_BHXH()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoSoNhanVien form = new HoSoNhanVien();
            form.ShowDialog();
            this.Close();
        }

        private void btn_BaoHiemXaHoi_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(ColorTranslator.FromHtml("#A09F9F"));
            pen.Width = 2;
            e.Graphics.DrawLine(pen, 0, 0, 306, 0);
        }
        private void btn_CongViec_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinCoBanNhanVien_CongViec form = new ThongTinCoBanNhanVien_CongViec();
            form.ShowDialog();
            this.Close();
        }

        private void btn_HoSo_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinCoBanNhanVien_HoSo form = new ThongTinCoBanNhanVien_HoSo();
            form.ShowDialog();
            this.Close();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinCoBanNhanVien_SuaBHXH form = new ThongTinCoBanNhanVien_SuaBHXH();
            form.ShowDialog();
            this.Close();
        }
    }
}
