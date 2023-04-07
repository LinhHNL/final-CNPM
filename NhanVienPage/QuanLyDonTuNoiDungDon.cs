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
    public partial class QuanLyDonTuNoiDungDon : MetroFramework.Forms.MetroForm
    {
        private bool editMode = false;
        public QuanLyDonTuNoiDungDon()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            QuanLyDonTu form = new QuanLyDonTu();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            btn_Sua.BackColor = ColorTranslator.FromHtml("#6C757D");
            btn_Luu.BackColor = ColorTranslator.FromHtml("#E50111");
            editMode = true; 
        }

        private void QuanLyDonTuNoiDungDon_Load(object sender, EventArgs e)
        {
            cb_TrangThai.SelectedIndex = 0;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            btn_Luu.BackColor = ColorTranslator.FromHtml("#6C757D");
            btn_Sua.BackColor = ColorTranslator.FromHtml("#E50111");
            editMode = false;
        }
    }
}
