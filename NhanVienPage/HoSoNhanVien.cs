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
    public partial class HoSoNhanVien : MetroFramework.Forms.MetroForm
    {
        public HoSoNhanVien()
        {
            InitializeComponent();
            dgv_NhanVien.Rows.Add("0", "asd", "asd", "asd", "asd","adsd");
            dgv_NhanVien.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemNhanVien form = new ThemNhanVien();
            form.ShowDialog();
            this.Close();
        }
    }
}
