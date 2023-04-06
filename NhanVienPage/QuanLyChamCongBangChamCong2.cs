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
    public partial class QuanLyChamCongBangChamCong2 : MetroFramework.Forms.MetroForm
    {
        public QuanLyChamCongBangChamCong2()
        {
            InitializeComponent();
        }


        private void btn_Back_Click(object sender, EventArgs e)
        {
            QuanLyChamCongBangChamCong form = new QuanLyChamCongBangChamCong();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
