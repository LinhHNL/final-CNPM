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
    public partial class QuanLyDonTu : MetroFramework.Forms.MetroForm
    {
        public QuanLyDonTu()
        {
            InitializeComponent();
            var col = (DataGridViewButtonColumn)dgv_DonTu.Columns[4];
            col.FlatStyle = FlatStyle.Flat;
            col.DefaultCellStyle.ForeColor = Color.White;
            dgv_DonTu.AllowUserToAddRows = false;
        }

        public void AddRowDonTu(String ma, String nhanVien, String ngay, String lyDo, int trangThai)
        {
            String state = "";
            Color bg;
            switch (trangThai)
            {
                case 0:
                    state = "Đã duyệt";
                    bg = ColorTranslator.FromHtml("#058C42");
                    break;
                case 1:
                    state = "Chờ duyệt";
                    bg = ColorTranslator.FromHtml("#F9A620");
                    break;
                case -1:
                    state = "Không duyệt";
                    bg = ColorTranslator.FromHtml("#850A0A");
                    break;
                default:
                    return;
            }
            dgv_DonTu.Rows.Add(ma, nhanVien, ngay, lyDo, state);
            dgv_DonTu.Rows[dgv_DonTu.Rows.Count - 1 ].Cells[4].Style.BackColor = bg;
        }

        private void QuanLyDonTu_Load(object sender, EventArgs e)
        {
            AddRowDonTu("...", "...", "--/ --/ ----", "...", 1);
            AddRowDonTu("...", "...", "--/ --/ ----", "...", 0);
            AddRowDonTu("...", "...", "--/ --/ ----", "...", -1);
            dgv_DonTu.ClearSelection();
        }

        private void btn_QuanLyLichLam_Click(object sender, EventArgs e)
        {
            QuanLyLichLam form = new QuanLyLichLam();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btn_QuanLyChamCong_Click(object sender, EventArgs e)
        {
            QuanLyChamCong form = new QuanLyChamCong();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btn_DonTu_Click(object sender, EventArgs e)
        {
            QuanLyDonTu form = new QuanLyDonTu();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btn_LuongThuong_Click(object sender, EventArgs e)
        {
            QuanLyLuongThuong form = new QuanLyLuongThuong();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btn_HoSoNhanVien_Click(object sender, EventArgs e)
        {
            HoSoNhanVien form = new HoSoNhanVien();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
