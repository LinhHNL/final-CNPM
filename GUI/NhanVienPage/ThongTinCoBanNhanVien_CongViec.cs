﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using WinFormsApp2.AdminPage;

namespace WinFormsApp2.NhanVienPage
{
    public partial class ThongTinCoBanNhanVien_CongViec : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public ThongTinCoBanNhanVien_CongViec()
        {
            InitializeComponent();
            culture = CultureInfo.CurrentCulture;
            SetLanguage("en-US");
        }
        

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoSoNhanVien form = new HoSoNhanVien();
            form.ShowDialog();
            this.Close();
        }

        private void btn_CongViec_Paint_1(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(ColorTranslator.FromHtml("#A09F9F"));
            pen.Width = 2;
            e.Graphics.DrawLine(pen, 0, 0, 306, 0);
        }

        private void btn_HoSo_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinCoBanNhanVien_HoSo form = new ThongTinCoBanNhanVien_HoSo();
            form.ShowDialog();
            this.Close();
        }

        private void btn_BaoHiemXaHoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinCoBanNhanVien_BHXH form = new ThongTinCoBanNhanVien_BHXH();
            form.ShowDialog();
            this.Close();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuaThongTinNhanVien_CongViec form = new SuaThongTinNhanVien_CongViec();
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
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("GUI.Language.MyResource", typeof(AddFood).Assembly);
            btn_Signout.Text = rm.GetString("signoutText", culture);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
            btn_StaffProfile.Text = rm.GetString("staffProfileText", culture);
            btn_WorkScheduleManagement.Text = rm.GetString("workScheduleManagementText", culture);
            btn_TimekeepingManagement.Text = rm.GetString("timekeepingManagementText", culture);
            btn_letter.Text = rm.GetString("letterText", culture);
            btn_ExportFile.Text = rm.GetString("exportFileText", culture);
            StartDate.HeaderText = rm.GetString("startDateText", culture);
            btn_PayRoll.Text = rm.GetString("payrollText", culture);
            Description.HeaderText = rm.GetString("descriptionText", culture);
            Number.HeaderText = rm.GetString("numberText", culture);
            Position.HeaderText = rm.GetString("positionText", culture);
            EndDate.HeaderText = rm.GetString("endDateText", culture);
            lbl_status.Text = rm.GetString("statusText", culture);
            lbl_timekeepingCode.Text = rm.GetString("timekeepingCodeText", culture);
            lbl_Position.Text = rm.GetString("positionText", culture);
            lbl_Department.Text = rm.GetString("departmentText", culture);
            lbl_startWorkDay.Text = rm.GetString("startWorkDayText", culture);
            btn_profile.Text = rm.GetString("profileText", culture);
            btn_socialInsurance.Text = rm.GetString("socialInsuranceText", culture);
            lbl_staffInfoText.Text = rm.GetString("staffInfoText", culture);
            btn_job.Text = rm.GetString("jobText", culture);
            lbl_Back.Text = rm.GetString("backText", culture);
            gb_WorkInfo.Text = rm.GetString("workInfoText", culture);
            btn_Edit.Text = rm.GetString("editText", culture);
            gb_WorkProcess.Text = rm.GetString("workProgressText", culture);
        }
    }
}
