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
    public partial class QuanLyLichLamCa : MetroFramework.Forms.MetroForm 
    {
        int day, month, year, shift;
        public QuanLyLichLamCa()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                panel_NhanVien.Controls.Add(new CustomControls.RowDeletable("Ten nv", i));
            }
        }

        public QuanLyLichLamCa(int day, int month, int year, int shift)
        {
            InitializeComponent();
            this.day = day; 
            this.month = month;
            this.year = year;
            this.shift = shift;
            int daysInCurrentMonth = DateTime.DaysInMonth(year, month);
            for (int i = daysInCurrentMonth; i >= 1; i--)
            {
                cb_date.Items.Add(i + "/" + month + "/" + year);
            }
            cb_date.SelectedIndex = daysInCurrentMonth - day;
            cb_Ca.SelectedIndex = shift;
            for (int i = 0; i < 10; i++)
            {
                panel_NhanVien.Controls.Add(new CustomControls.RowDeletable("Ten nv", i));
            }
        }
    }
}
