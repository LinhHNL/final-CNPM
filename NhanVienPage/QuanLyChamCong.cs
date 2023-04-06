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
    public partial class QuanLyChamCong : MetroFramework.Forms.MetroForm
    {
        public QuanLyChamCong()
        {
            InitializeComponent();
            cb_month.SelectedIndex = 0;
            dgv_NhanVien.Rows.Add("001", "TEN NV", "ASD", "ASD");
            dgv_NhanVien.Rows.Add("001", "TEN NV", "ASD", "ASD");
            dgv_NhanVien.Rows.Add("001", "TEN NV", "ASD", "ASD");
            dgv_NhanVien.Rows.Add("001", "TEN NV", "ASD", "ASD");
            dgv_NhanVien.Rows.Add("001", "TEN NV", "ASD", "ASD");
            dgv_NhanVien.Rows.Add("001", "TEN NV", "ASD", "ASD");
        }

    }
}
