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
    public partial class KiemKhoNhapHang : MetroFramework.Forms.MetroForm
    {
        public KiemKhoNhapHang()
        {
            InitializeComponent();
            dgv_NhapHang.Rows.Add("0", "asd", "asd");
            dgv_NhapHang.Rows.Add("0", "asd", "asd");
            dgv_NhapHang.Rows.Add("0", "asd", "asd");
            dgv_NhapHang.Rows.Add("0", "asd", "asd");
            dgv_NhapHang.Rows.Add("0", "asd", "asd");
        }

        private void btn_PhieuXuatHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            KiemKhoTaoPhieuXuatHang form = new KiemKhoTaoPhieuXuatHang();
            form.ShowDialog();
            this.Close();
        }
    }
}
