using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.CustomControls;
using System.Resources;
using System.Globalization;
using WinFormsApp2.AdminPage;

namespace WinFormsApp2.NhanVienPage
{
    public partial class QuanLyChamCongBangChamCong : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public QuanLyChamCongBangChamCong()
        {
            InitializeComponent();
            cb_Month.SelectedIndex = 0;
            calendar.cellClickEvent = (sender, e) =>
            {
                int day = Int32.Parse(((CalendarCell)sender).getDay().Text);
                QuanLyLichLamNgay form = new QuanLyLichLamNgay(day, calendar.Month, calendar.Year);
                this.Hide();
                form.ShowDialog();
                this.Close();
            };
            culture = CultureInfo.CurrentCulture;
            SetLanguage("vi-VN");

        }

        private void QuanLyChamCongBangChamCong_Load(object sender, EventArgs e)
        {
            calendar.setParentForm(this);
            calendar.SetMonthYear(DateTime.Now.Month, DateTime.Now.Year);
            cb_Month.SelectedIndex = 0;

            calendar.getCellAtDay(7).setOff();
            calendar.getCellAtDay(6).setCa(9, 30, 10, 0, 1);
        }


        private void cb_month_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int month = Int32.Parse(cb_Month.SelectedItem.ToString().Split("/")[0]);
            int year = Int32.Parse(cb_Month.SelectedItem.ToString().Split("/")[1]);
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
            lbl_Month.Text = rm.GetString("monthText", culture);
            lbl_Timekeeping.Text = rm.GetString("timekeepingText", culture);
            
        }
    }
}
