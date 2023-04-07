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