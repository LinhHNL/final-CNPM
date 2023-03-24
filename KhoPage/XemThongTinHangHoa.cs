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
    public partial class XemThongTinHangHoa : MetroFramework.Forms.MetroForm
    {
        public XemThongTinHangHoa()
        {
            InitializeComponent();
        }


        private void roundedButton4_Click(object sender, EventArgs e)
        {
            
                if (roundedButtonNhapHang.Visible == false)
                {
                    roundedButtonNhapHang.Visible = true;
                    roundedButtonXuatHang.Visible = true;
                }
                else
                {
                    roundedButtonNhapHang.Visible = false;
                    roundedButtonXuatHang.Visible = false;
                }
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuaThongTinHangHoa form = new SuaThongTinHangHoa();
            form.ShowDialog();
            this.Close();
        }
    }
}
