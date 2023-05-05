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
    public partial class DonTu : MetroFramework.Forms.MetroForm
    {
        public DonTu()
        {
            InitializeComponent();
            var col = (DataGridViewButtonColumn)dgv_DonTu.Columns[4];
            col.FlatStyle = FlatStyle.Flat;
            col.DefaultCellStyle.ForeColor = Color.White;
            dgv_DonTu.AllowUserToAddRows = false;
        }

        public void AddRowDonTu(int STT, String loaiDon, String ngaylamdon, String ngayxuly, int trangThai, String chitiet)
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
            dgv_DonTu.Rows.Add(STT, loaiDon, ngaylamdon, ngayxuly, state, chitiet);
            dgv_DonTu.Rows[dgv_DonTu.Rows.Count - 1 ].Cells[4].Style.BackColor = bg;
            dgv_DonTu.Rows[dgv_DonTu.Rows.Count - 1].Cells[5].Style.ForeColor = ColorTranslator.FromHtml("#E50111");
        }

        private void QuanLyDonTu_Load(object sender, EventArgs e)
        {
            AddRowDonTu(1, "...", "--/ --/ ----", "--/ --/ ----", 1, "Chi tiết >");
            AddRowDonTu(2, "...", "--/ --/ ----", "--/ --/ ----", 0, "Chi tiết >");
            AddRowDonTu(3, "...", "--/ --/ ----", "--/ --/ ----", -1, "Chi tiết >");
            dgv_DonTu.ClearSelection();
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LamDon form = new LamDon();
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
