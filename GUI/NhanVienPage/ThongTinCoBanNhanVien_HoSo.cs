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
    public partial class ThongTinCoBanNhanVien_HoSo : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public ThongTinCoBanNhanVien_HoSo()
        {
            InitializeComponent();
            culture = CultureInfo.CurrentCulture;
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
        
      

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoSoNhanVien form = new HoSoNhanVien();
            form.ShowDialog();
            this.Close();
        }

        private void btn_CongViec_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinCoBanNhanVien_CongViec form = new ThongTinCoBanNhanVien_CongViec();
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

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuaThongTinNhanVien_HoSo form = new SuaThongTinNhanVien_HoSo();
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
            btn_PayRoll.Text = rm.GetString("payrollText", culture);
            Number.HeaderText = rm.GetString("numberText", culture);
            btn_profile.Text = rm.GetString("profileText", culture);
            btn_socialInsurance.Text = rm.GetString("socialInsuranceText", culture);
            lbl_staffInfoText.Text = rm.GetString("staffInfoText", culture);
            btn_job.Text = rm.GetString("jobText", culture);
            lbl_Back.Text = rm.GetString("backText", culture);
            btn_Edit.Text = rm.GetString("editText", culture);
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
            lbl_accountName2.Text = rm.GetString("accountNameText",culture);
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
