using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using WinFormsApp2.NhanVienPage;

namespace WinFormsApp2.StaffAccount
{
    public partial class DangKyLichLam : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture; 
        int day;
        int month;
        int year;
        public DangKyLichLam()
        {
            InitializeComponent();
            SetLanguage("en-US");
        }

        public DangKyLichLam(int day, int month, int year)
        {
            InitializeComponent();
            this.day = day;
            this.month = month;
            this.year = year;
        }

        private void DangKyLichLam_Load(object sender, EventArgs e)
        {
            int daysInCurrentMonth = DateTime.DaysInMonth(year, month);
            for (int i = daysInCurrentMonth; i >= 1; i--)
            {
                cb_date.Items.Add(i + "/" + month + "/" + year);
            }
            cb_date.SelectedIndex = daysInCurrentMonth - day;

        }

        private void btn_CaSang_MouseEnter(object sender, EventArgs e)
        {
            lbl_CaSang.BackColor = ColorTranslator.FromHtml("#e5e5e5");
        }

        private void btn_CaSang_MouseLeave(object sender, EventArgs e)
        {
            lbl_CaSang.BackColor = Color.White;
        }

        private void btn_CaChieu_MouseEnter(object sender, EventArgs e)
        {
            lbl_CaChieu.BackColor = ColorTranslator.FromHtml("#e5e5e5");
        }

        private void btn_CaChieu_MouseLeave(object sender, EventArgs e)
        {
            lbl_CaChieu.BackColor = Color.White;
        }

        private void btn_CaToi_MouseEnter(object sender, EventArgs e)
        {
            lbl_CaToi.BackColor = ColorTranslator.FromHtml("#e5e5e5");
        }

        private void btn_CaToi_MouseLeave(object sender, EventArgs e)
        {
            lbl_CaToi.BackColor = Color.White;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            LichLam form = new LichLam();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btn_CaSang_Click(object sender, EventArgs e)
        {
            //QuanLyLichLamCa form = new QuanLyLichLamCa(day, month, year, 0);
            this.Hide();
            //form.ShowDialog();
            this.Close();
        }

        private void btn_CaChieu_Click(object sender, EventArgs e)
        {
            //QuanLyLichLamCa form = new QuanLyLichLamCa(day, month, year, 1);
            this.Hide();
            //form.ShowDialog();
            this.Close();
        }

        private void btn_CaToi_Click(object sender, EventArgs e)
        {
            //QuanLyLichLamCa form = new QuanLyLichLamCa(day, month, year, 2);
            this.Hide();
            //form.ShowDialog();
            this.Close();
        }

        private void btn_QuanLyLichLam_Click(object sender, EventArgs e)
        {
            //QuanLyLichLam form = new QuanLyLichLam();
            this.Hide();
            //form.ShowDialog();
            this.Close();
        }

        private void btn_QuanLyChamCong_Click(object sender, EventArgs e)
        {
            //QuanLyChamCong form = new QuanLyChamCong();
            this.Hide();
            //form.ShowDialog();
            this.Close();
        }

        private void btn_DonTu_Click(object sender, EventArgs e)
        {
            //QuanLyDonTu form = new QuanLyDonTu();
            this.Hide();
            //form.ShowDialog();
            this.Close();
        }

        private void btn_LuongThuong_Click(object sender, EventArgs e)
        {
            //QuanLyLuongThuong form = new QuanLyLuongThuong();
            this.Hide();
            //form.ShowDialog();
            this.Close();
        }

        private void btn_HoSoNhanVien_Click(object sender, EventArgs e)
        {
            //HoSoNhanVien form = new HoSoNhanVien();
            this.Hide();
            //form.ShowDialog();
            this.Close();
        }

        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("GUI.Language.MyResource", typeof(QuanLyLichLamNgay).Assembly);
            btn_Signout.Text = rm.GetString("signoutText", culture);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
            btn_StaffProfile.Text = rm.GetString("staffProfileText", culture);
            btn_WorkScheduleManagement.Text = rm.GetString("workScheduleManagementText", culture);
            btn_TimekeepingManagement.Text = rm.GetString("timekeepingManagementText", culture);
            btn_letter.Text = rm.GetString("letterText", culture);
            btn_PayRoll.Text = rm.GetString("payrollText", culture);
            lbl_Date.Text = rm.GetString("dayText", culture);
            cb_date.PromptText = rm.GetString("dayText", culture);
            lbl_RegisterShift.Text = rm.GetString("registerShiftText", culture);
            btn_afternoonShift.Text = rm.GetString("afternoonShiftText", culture);
            btn_morningShift.Text = rm.GetString("morningShiftText", culture);
            btn_eveningShift.Text = rm.GetString("eveningShiftText", culture);
            btn_Back.Text = rm.GetString("backText", culture);
        }
    }
}
