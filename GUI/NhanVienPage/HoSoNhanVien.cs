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
using WinFormsApp2.AdminPage;

namespace WinFormsApp2.NhanVienPage
{
    public partial class HoSoNhanVien : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public HoSoNhanVien()
        {
            InitializeComponent();
            dgv_NhanVien.Rows.Add("0", "asd", "asd", "asd", "asd","adsd");
            dgv_NhanVien.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add("0", "asd", "asd", "asd", "asd", "adsd");
            culture = CultureInfo.CurrentCulture;
            SetLanguage("en-US");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemNhanVien form = new ThemNhanVien();
            form.ShowDialog();
            this.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            XoaNhanVien form = new XoaNhanVien();
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
            btn_StaffProfile.Text = rm.GetString("staffProfileText",culture);
            btn_WorkScheduleManagement.Text = rm.GetString("workScheduleManagementText", culture);
            btn_TimekeepingManagement.Text = rm.GetString("timekeepingManagementText", culture);
            btn_letter.Text = rm.GetString("letterText",culture);
            lbl_Search.Text = rm.GetString("searchText",culture);
            tb_StaffID.PlaceholderText = rm.GetString("staffIDText", culture);
            cb_Department.PromptText = rm.GetString("departmentText",culture);
            btn_Add.Text = rm.GetString("addText", culture);
            btn_Delete.Text = rm.GetString("deleteText", culture);
            btn_ExportFile.Text = rm.GetString("exportFileText", culture);
            StaffID.HeaderText = rm.GetString("staffIDText",culture);
            FullName.HeaderText = rm.GetString("fullNameText", culture);
            Department.HeaderText = rm.GetString("departmentText", culture);
            Position.HeaderText = rm.GetString("positionText", culture);
            StartDate.HeaderText = rm.GetString("startDateText", culture);
            Status.HeaderText = rm.GetString("statusText", culture);
            btn_PayRoll.Text = rm.GetString("payrollText", culture);
            

        }
    }
}
