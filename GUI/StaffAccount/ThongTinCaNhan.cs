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
using System.Text.RegularExpressions;
using WinFormsApp2.KhoPage;

namespace WinFormsApp2.StaffAccount
{
    public partial class ThongTinCaNhan : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public ThongTinCaNhan()
        {
            InitializeComponent();
            SetLanguage("en-US");
        }


        private void btn_HoSo_Paint(object sender, PaintEventArgs e)
        {
            if (btn_profile.ForeColor == ColorTranslator.FromHtml("#E50111"))
            {
                Pen pen = new Pen(ColorTranslator.FromHtml("#A09F9F"));
                pen.Width = 2;
                e.Graphics.DrawLine(pen, 0, 0, 306, 0);
            }
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuaThongTinCaNhan form = new SuaThongTinCaNhan();
            form.ShowDialog();
            this.Close();
        }

        private void btn_CongViec_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinCongViec form = new ThongTinCongViec();
            form.ShowDialog();
            this.Close();
        }

        private void btn_BaoHiemXaHoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinBHXH form = new ThongTinBHXH();
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
            btn_Edit.Text = rm.GetString("editText", culture);
            lbl_PersonalInfo.Text = rm.GetString("personalInfoText", culture);
            Number.HeaderText = rm.GetString("numberText", culture);
            btn_profile.Text = rm.GetString("profileText", culture);
            btn_socialInsurance.Text = rm.GetString("socialInsuranceText", culture);
            btn_job.Text = rm.GetString("jobText", culture);
            FullName.HeaderText = rm.GetString("fullNameText", culture);
            Gender.HeaderText = rm.GetString("genderText", culture);
            Relative.HeaderText = rm.GetString("relationshipText", culture);
            lbl_staffID.Text = rm.GetString("staffIDText", culture);
            lbl_gender.Text = rm.GetString("genderText", culture);
            lbl_phone.Text = rm.GetString("phoneText", culture);
            lbl_nationalID.Text = rm.GetString("nationalIDText", culture);
            lbl_dateOfIssue.Text = rm.GetString("dateOfIssueText", culture);
            lbl_permanentAddress.Text = rm.GetString("permanentAddressText", culture);
            lbl_currentAddress.Text = rm.GetString("currentAddressText", culture);
            lbl_taxCode.Text = rm.GetString("taxCodeText", culture);
            lbl_bankAccountNumber.Text = rm.GetString("bankAccountNumberText", culture);
            lbl_accountName2.Text = rm.GetString("accountNameText", culture);
            lbl_bankNameNumber.Text = rm.GetString("bankNameNumberText", culture);
            lbl_dateOfBirth.Text = rm.GetString("dateOfBirthText", culture);
            lbl_nationality.Text = rm.GetString("nationalityText", culture);
            lbl_placeOfIssue.Text = rm.GetString("placeOfIssueText", culture);
            lbl_fullName.Text = rm.GetString("fullNameText", culture);
            gb_basicInfo.Text = rm.GetString("basicInfoText", culture);
            gb_relativeInfo.Text = rm.GetString("relativeInfoText", culture);
        }
    }
}
