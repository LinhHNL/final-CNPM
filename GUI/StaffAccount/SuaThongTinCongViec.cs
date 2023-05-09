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
using WinFormsApp2.KhoPage;

namespace WinFormsApp2.StaffAccount
{
    public partial class SuaThongTinCongViec : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public SuaThongTinCongViec()
        {
            InitializeComponent();
            SetLanguage("en-US");
        }

        private void btn_CongViec_Paint_1(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(ColorTranslator.FromHtml("#A09F9F"));
            pen.Width = 2;
            e.Graphics.DrawLine(pen, 0, 0, 306, 0);
        }

        private void btn_BaoHiemXaHoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinBHXH form = new ThongTinBHXH();
            form.ShowDialog();
            this.Close();
        }

        private void btn_HoSo_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinCaNhan form = new ThongTinCaNhan();
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


            btn_profile.Text = rm.GetString("profileText", culture);
            btn_socialInsurance.Text = rm.GetString("socialInsuranceText", culture);
            btn_job.Text = rm.GetString("jobText", culture);
            btn_Cancel.Text = rm.GetString("cancelText", culture);
            lbl_PersonalInfo.Text = rm.GetString("personalInfoText", culture);
            Number.HeaderText = rm.GetString("numberText", culture);
            btn_profile.Text = rm.GetString("profileText", culture);
            btn_socialInsurance.Text = rm.GetString("socialInsuranceText", culture);
            btn_job.Text = rm.GetString("jobText", culture);
            btn_Save.Text = rm.GetString("saveText", culture);

            StartDate.HeaderText = rm.GetString("startDateText", culture);
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
            btn_job.Text = rm.GetString("jobText", culture);
            gb_WorkInfo.Text = rm.GetString("workInfoText", culture);
            gb_WorkProcess.Text = rm.GetString("workProgressText", culture);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinCongViec form = new ThongTinCongViec();
            form.ShowDialog();
            this.Close();
        }
    }
}
