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
using WinFormsApp2.KhoPage;

namespace WinFormsApp2.StaffAccount
{
    public partial class ChamCong : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public ChamCong()
        {
            InitializeComponent();
            SetLanguage("en-US");
            cb_Month.SelectedIndex = 0;
            calendar.cellClickEvent = (sender, e) =>
            {
                int day = Int32.Parse(((CalendarCell)sender).getDay().Text);
                //QuanLyLichLamNgay form = new QuanLyLichLamNgay(day, calendar.Month, calendar.Year);
                this.Hide();
                //form.ShowDialog();
                this.Close();
            };
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

        

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChamCong2 form = new ChamCong2();
            form.ShowDialog();
            this.Close();
        }

        private void btn_HoSoCuaToi_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinCaNhan form = new ThongTinCaNhan();
            form.ShowDialog();
            this.Close();
        }

        private void btn_QuanLyLichLam_Click(object sender, EventArgs e)
        {
            this.Hide();
            LichLam form = new LichLam();
            form.ShowDialog();
            this.Close();
        }

        private void btn_QuanLyChamCong_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChamCong form = new ChamCong();
            form.ShowDialog();
            this.Close();
        }

        private void btn_DonTu_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonTu form = new DonTu();
            form.ShowDialog();
            this.Close();
        }

        private void btn_LuongThuong_Click(object sender, EventArgs e)
        {
            this.Hide();
            BangLuong form = new BangLuong();
            form.ShowDialog();
            this.Close();
        }

        private void btn_ThongBao_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongBao form = new ThongBao();
            form.ShowDialog();
            this.Close();
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatKhau form = new DoiMatKhau();
            form.ShowDialog();
            this.Close();
        }
        public void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("GUI.Language.MyResource",
                             typeof(HangHoaTrongKho).Assembly);
            btn_MyProfile.Text = rm.GetString("myProfileText", culture);
            btn_WorkSchedule.Text = rm.GetString("workScheduleText", culture);
            btn_Timekeeping.Text = rm.GetString("timekeepingText", culture);
            btn_Letter.Text = rm.GetString("letterText", culture);
            btn_Payroll.Text = rm.GetString("payrollText", culture);
            btn_Notification.Text = rm.GetString("notificationText", culture);
            btn_PasswordReset.Text = rm.GetString("passwordResetText", culture);
            btn_SignOut.Text = rm.GetString("signoutText", culture);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);


            lbl_Month.Text = rm.GetString("monthText", culture);
            lbl_Timekeeping.Text = rm.GetString("timekeepingText", culture);
            lbl_Month.Text = rm.GetString("monthText", culture);
            btn_Detail.Text = rm.GetString("detailText", culture);
        }
    }
}
