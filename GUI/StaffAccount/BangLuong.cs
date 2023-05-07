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
    public partial class BangLuong : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public BangLuong()
        {
            InitializeComponent();
            SetLanguage("en-US");
        }

        

        private void QuanLyLuongThuongChiTiet_Load(object sender, EventArgs e)
        {

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


            lbl_PayrollDetail.Text = rm.GetString("payrollDetailText", culture);
            lbl_Month.Text = rm.GetString("monthText", culture);
            lbl_Work.Text = rm.GetString("workText", culture);
            lbl_TotalSalaryText.Text = rm.GetString("totalSalaryText", culture);
            lbl_RevenueBonus.Text = rm.GetString("revenueBonusText", culture);
            lbl_ParkingAllowance.Text = rm.GetString("parkingAllowanceText", culture);
            lbl_LateTimes.Text = rm.GetString("lateTimesText", culture);
            lbl_DaysoffWithoutPermission.Text = rm.GetString("daysoffWithoutPermissionText", culture);
            lbl_EarlyEndTimes.Text = rm.GetString("earlyEndTimesText", culture);
            lbl_FineForLate.Text = rm.GetString("fineForLateText", culture);
            lbl_OvertimeAllowance.Text = rm.GetString("overtimeAllowanceText", culture);
            lbl_PersonalIncomeTax.Text = rm.GetString("personalIncomeTax", culture);
            lbl_SocialInsuranceMoney.Text = rm.GetString("socialInsuranceMoneyText", culture);
            lbl_StaffLevelBonus.Text = rm.GetString("staffLevelBonusText", culture);
            lbl_TrueWorkTime.Text = rm.GetString("trueWorkTimeText", culture);
            lbl_TrueWork.Text = rm.GetString("trueWorkText", culture);
            lbl_UnionMoney.Text = rm.GetString("unionMoneyText", culture);
            lbl_Wage.Text = rm.GetString("wageText", culture);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
        }
    }
}
