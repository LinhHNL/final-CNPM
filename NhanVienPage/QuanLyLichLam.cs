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
    public partial class QuanLyLichLam : MetroFramework.Forms.MetroForm
    {
        public QuanLyLichLam()
        {
            InitializeComponent();
        }

        private void QuanLyLichLam_Load(object sender, EventArgs e)
        {
            calendar.setParentForm(this);
            calendar.SetMonthYear(DateTime.Now.Month, DateTime.Now.Year);
            cb_month.SelectedIndex = 0;
        }

        private void cb_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = Int32.Parse(cb_month.SelectedItem.ToString().Split("/")[0]);
            int year = Int32.Parse(cb_month.SelectedItem.ToString().Split("/")[1]);
            calendar.SetMonthYear(month, year);
            calendar.Reload();
        }
    }
}
