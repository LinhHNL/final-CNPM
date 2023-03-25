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
    public partial class KiemKhoSuaPhieuNhapHang : MetroFramework.Forms.MetroForm
    {
        public KiemKhoSuaPhieuNhapHang()
        {
            InitializeComponent();
            dgv_HangHoa.Rows.Add("0", "asd", "asd");
            dgv_HangHoa.Rows.Add("0", "asd", "asd");
            dgv_HangHoa.Rows.Add("0", "asd", "asd");
            dgv_HangHoa.Rows.Add("0", "asd", "asd");
            dgv_HangHoa.Rows.Add("0", "asd", "asd");
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

        private void btn_XuatHang_Click(object sender, EventArgs e)
        {
            btn_NhapHang.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            this.Hide();
            KiemKhoXuatHang form = new KiemKhoXuatHang();
            form.ShowDialog();
            this.Close();
        }
    }
}
