﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.CustomControls;

namespace WinFormsApp2.NhanVienPage
{
    public partial class QuanLyChamCongBangChamCong : MetroFramework.Forms.MetroForm
    {
        public QuanLyChamCongBangChamCong()
        {
            InitializeComponent();
            cb_month.SelectedIndex = 0;
            calendar.cellClickEvent = (sender, e) =>
            {
                int day = Int32.Parse(((CalendarCell)sender).getDay().Text);
                QuanLyLichLamNgay form = new QuanLyLichLamNgay(day, calendar.Month, calendar.Year);
                this.Hide();
                form.ShowDialog();
                this.Close();
            };
           

        }

        private void QuanLyChamCongBangChamCong_Load(object sender, EventArgs e)
        {
            calendar.setParentForm(this);
            calendar.SetMonthYear(DateTime.Now.Month, DateTime.Now.Year);
            cb_month.SelectedIndex = 0;

            calendar.getCellAtDay(7).setOff();
            calendar.getCellAtDay(6).setCa(9, 30, 10, 0, 1);
        }


        private void cb_month_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int month = Int32.Parse(cb_month.SelectedItem.ToString().Split("/")[0]);
            int year = Int32.Parse(cb_month.SelectedItem.ToString().Split("/")[1]);
            calendar.SetMonthYear(month, year);
            calendar.Reload();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            QuanLyChamCong form = new QuanLyChamCong();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
