using System;
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
    public partial class QuanLyLichLamThemNhanVien : MetroFramework.Forms.MetroForm
    {
        int day, month, year, shift;
        CultureInfo culture;

        public QuanLyLichLamThemNhanVien()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                panel_NhanVien.Controls.Add(new CustomControls.RowDeletable("Ten nv", i));
            }
            culture = CultureInfo.CurrentCulture;
            SetLanguage("en-US");
        }

        public QuanLyLichLamThemNhanVien(int day, int month, int year, int shift)
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
            cb_Shift.SelectedIndex = shift;
            for (int i = 0; i < 10; i++)
            {
                panel_NhanVien.Controls.Add(new CustomControls.RowAdd("Ten nv", i));
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            QuanLyLichLamCa form = new QuanLyLichLamCa(day, month, year, shift);
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
            btn_PayRoll.Text = rm.GetString("payrollText", culture);
            lbl_Date.Text = rm.GetString("dayText", culture);
            cb_date.PromptText = rm.GetString("dayText", culture);
            lbl_Shift.Text = rm.GetString("shiftText", culture);
            cb_Shift.PromptText = rm.GetString("shiftText", culture);
            lbl_staffList.Text = rm.GetString("staffListText", culture);
            lbl_AssignShift.Text = rm.GetString("assignShiftText", culture);
            btn_Back.Text = rm.GetString("backText", culture);
            lbl_Search.Text = rm.GetString("searchText", culture);
            lbl_Shift.Text = rm.GetString("shiftText", culture);
            cb_Shift.PromptText = rm.GetString("shiftText", culture);
            cb_Department.PromptText = rm.GetString("departmentText", culture);
            tb_staffIDNameText.PlaceholderText = rm.GetString("staffIDNameText", culture);
        }
    }
}
