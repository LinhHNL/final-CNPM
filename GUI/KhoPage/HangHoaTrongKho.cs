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
    public partial class HangHoaTrongKho : MetroFramework.Forms.MetroForm
    {
        public HangHoaTrongKho()
        {
            InitializeComponent();
            dgv_HangTrongKho.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_HangTrongKho.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_HangTrongKho.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_HangTrongKho.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_HangTrongKho.Rows.Add("0", "asd", "asd", "asd", "asd");
        }

        

        private void dgv_XuatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemHangHoa form = new ThemHangHoa();
            form.ShowDialog();
            this.Close();
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
    }
}
