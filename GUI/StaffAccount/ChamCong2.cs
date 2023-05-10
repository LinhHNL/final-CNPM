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
    public partial class ChamCong2 : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public ChamCong2()
        {
            InitializeComponent();
            SetLanguage("en-US");
        }


        private void btn_Back_Click(object sender, EventArgs e)
        {
            ChamCong form = new ChamCong();
            this.Hide();
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
            lbl_Synthesis.Text = rm.GetString("synthesisText", culture);
            lbl_work.Text = rm.GetString("workText", culture);
            lbl_trueWorkTime.Text = rm.GetString("trueWorkTimeText", culture);
            lbl_trueWork.Text = rm.GetString("trueWorkText", culture);
            lbl_lateTimes.Text = rm.GetString("lateTimesText", culture);
            lbl_earlyEndTimes.Text = rm.GetString("earlyEndTimesText", culture);
            btn_Back.Text = rm.GetString("backText", culture);
            lbl_daysoffWithoutPermission.Text = rm.GetString("daysoffWithoutPermissionText", culture);
        }
    }
}
