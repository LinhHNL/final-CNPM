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