using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using WinFormsApp2.AdminPage;

namespace WinFormsApp2.NhanVienPage
{
    public partial class QuanLyLuongThuong : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public QuanLyLuongThuong()
        {
            InitializeComponent();
            culture = CultureInfo.CurrentCulture;
            SetLanguage("en-US");
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
            lbl_Search.Text = rm.GetString("searchText", culture);
            tb_StaffID.PlaceholderText = rm.GetString("staffIDText", culture);
            cb_Department.PromptText = rm.GetString("departmentText", culture);
            StaffID.HeaderText = rm.GetString("staffIDText", culture);
            Position.HeaderText = rm.GetString("positionText", culture);
            btn_PayRoll.Text = rm.GetString("payrollText", culture);
            Staff.HeaderText = rm.GetString("staffText", culture);
            lbl_Month.Text = rm.GetString("monthText", culture);
            totalSalary.HeaderText = rm.GetString("totalSalaryText", culture);
            lbl_payrollManagement.Text = rm.GetString("payrollManagementText", culture);
            btn_exportFile.Text = rm.GetString("exportFileText", culture);
            cb_Month.PromptText = rm.GetString("monthText", culture);
        }
    }
}
