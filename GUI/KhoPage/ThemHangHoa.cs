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
    public partial class ThemHangHoa : MetroFramework.Forms.MetroForm
    {
        private int numberofRows = 0;
        public ThemHangHoa(int numberofRows)
        {
            InitializeComponent();
            this.numberofRows = numberofRows;
        }

        private void ThemHangHoa_Load(object sender, EventArgs e)
        {
            this.tb_MaHang.Texts = "HH" + this.numberofRows.ToString();
        }

        private void btn_KiemKho_Click(object sender, EventArgs e)
        {
            btn_HangTrongKho.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            btn_HangTrongKho.BackColor = ColorTranslator.FromHtml("white");
            btn_KiemKho.BackColor = ColorTranslator.FromHtml("#E50111");
            btn_KiemKho.ForeColor = ColorTranslator.FromHtml("white");
            if (btn_NhapHang.Visible == false)
            {
                btn_NhapHang.Visible = true;
                btn_XuatHang.Visible = true;
            }
            else
            {
                btn_NhapHang.Visible = false;
                btn_XuatHang.Visible = false;
            }
            this.Hide();
            KiemKhoXuatHang form = new KiemKhoXuatHang();
            form.ShowDialog();
            this.Close();
        }

        private void ThemHangHoa_Load_1(object sender, EventArgs e)
        {

        }
    }
}
