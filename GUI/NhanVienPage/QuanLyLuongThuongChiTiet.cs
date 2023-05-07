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

namespace WinFormsApp2.NhanVienPage
{
    public partial class QuanLyLuongThuongChiTiet : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public QuanLyLuongThuongChiTiet()
        {
            InitializeComponent();
            SetLanguage("en-US");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            QuanLyLuongThuong form = new QuanLyLuongThuong();
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

        private void QuanLyLuongThuongChiTiet_Load(object sender, EventArgs e)
        {

        }
        public void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("GUI.Language.MyResource",
                             typeof(QuanLyLuongThuongChiTiet).Assembly);           
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
            btn_Signout.Text = rm.GetString("signoutText", culture);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
            btn_StaffProfile.Text = rm.GetString("staffProfileText", culture);
            btn_WorkScheduleManagement.Text = rm.GetString("workScheduleManagementText", culture);
            btn_TimekeepingManagement.Text = rm.GetString("timekeepingManagementText", culture);
            btn_letter.Text = rm.GetString("letterText", culture);
            btn_PayRoll.Text = rm.GetString("payrollText", culture);
            lbl_payrollDetail.Text = rm.GetString("payrolllDetailText", culture);
            btn_exportFile.Text = rm.GetString("exportFileText", culture);
            btn_Back.Text = rm.GetString("backText", culture);
            lbl_StaffID.Text = rm.GetString("staffIDText", culture);
            lbl_Department.Text = rm.GetString("departmentText", culture);
            lbl_FullName.Text = rm.GetString("fullNameText", culture);
            lbl_Position.Text = rm.GetString("positionText", culture);
                            
        }
    }
}
