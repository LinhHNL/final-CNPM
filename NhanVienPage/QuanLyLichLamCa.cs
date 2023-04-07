﻿using System;
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            QuanLyLichLamNgay form = new QuanLyLichLamNgay(day, month, year);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }


        private void btn_AddNhanVien_Click(object sender, EventArgs e)
        {
            QuanLyLichLamThemNhanVien form = new QuanLyLichLamThemNhanVien(day, month, year, shift);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btn_QuanLyLichLam_Click(object sender, EventArgs e)
        {
            QuanLyLichLam form = new QuanLyLichLam();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btn_QuanLyChamCong_Click(object sender, EventArgs e)
        {
            QuanLyChamCong form = new QuanLyChamCong();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btn_DonTu_Click(object sender, EventArgs e)
        {
            QuanLyDonTu form = new QuanLyDonTu();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btn_LuongThuong_Click(object sender, EventArgs e)
        {
            QuanLyLuongThuong form = new QuanLyLuongThuong();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btn_HoSoNhanVien_Click(object sender, EventArgs e)
        {
            HoSoNhanVien form = new HoSoNhanVien();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
