using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.StaffAccount
{
    public partial class SuaThongTinCaNhan : MetroFramework.Forms.MetroForm
    {
        public SuaThongTinCaNhan()
        {
            InitializeComponent();
        }


        private void btn_HoSo_Paint(object sender, PaintEventArgs e)
        {
            if (btn_HoSo.ForeColor == ColorTranslator.FromHtml("#E50111"))
            {
                Pen pen = new Pen(ColorTranslator.FromHtml("#A09F9F"));
                pen.Width = 2;
                e.Graphics.DrawLine(pen, 0, 0, 306, 0);
            }
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {

        }

        private void btn_CongViec_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinCongViec form = new ThongTinCongViec();
            form.ShowDialog();
            this.Close();
        }

        private void btn_BaoHiemXaHoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinBHXH form = new ThongTinBHXH();
            form.ShowDialog();
            this.Close();
        }
        private void btn_HoSoCuaToi_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinCaNhan form = new ThongTinCaNhan();
            form.ShowDialog();
            this.Close();
        }

        private void btn_QuanLyLichLam_Click(object sender, EventArgs e)
        {

        }

        private void btn_QuanLyChamCong_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChamCong form = new ChamCong();
            form.ShowDialog();
            this.Close();
        }

        private void btn_DonTu_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonTu form = new DonTu();
            form.ShowDialog();
            this.Close();
        }

        private void btn_LuongThuong_Click(object sender, EventArgs e)
        {
            this.Hide();
            BangLuong form = new BangLuong();
            form.ShowDialog();
            this.Close();
        }

        private void btn_ThongBao_Click(object sender, EventArgs e)
        {

        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatKhau form = new DoiMatKhau();
            form.ShowDialog();
            this.Close();
        }
    }
}
