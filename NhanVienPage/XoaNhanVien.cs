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
    public partial class XoaNhanVien : MetroFramework.Forms.MetroForm
    {
        public XoaNhanVien()
        {
            InitializeComponent();
            dgv_NhanVien.Rows.Add(true, "0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add(true, "0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add(true, "0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add(true, "0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add(true, "0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add(true, "0", "asd", "asd", "asd", "asd", "adsd");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoSoNhanVien form = new HoSoNhanVien(); 
            form.ShowDialog();
            this.Close();
        }
    }
}
