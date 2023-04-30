using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.KhoPage
{
    public partial class KiemKhoXemPhieuXuatHang : MetroFramework.Forms.MetroForm
    {
        String valueofID = "";
        public KiemKhoXemPhieuXuatHang(String valueofID)
        {
            InitializeComponent();
            this.valueofID = valueofID;
        }
        private void btn_HangTrongKho_Click(object sender, EventArgs e)
        {
            btn_HangTrongKho.ForeColor = ColorTranslator.FromHtml("white");
            btn_HangTrongKho.BackColor = ColorTranslator.FromHtml("#E50111");
            btn_KiemKho.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            btn_KiemKho.BackColor = ColorTranslator.FromHtml("white");
            btn_NhapHang.Visible = false;
            btn_XuatHang.Visible = false;
            this.Hide();
            HangHoaTrongKho form = new HangHoaTrongKho();
            form.ShowDialog();
            this.Close();
        }
        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            btn_NhapHang.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            this.Hide();
            KiemKhoNhapHang form = new KiemKhoNhapHang();
            form.ShowDialog();
            this.Close();
        }
    }
}
