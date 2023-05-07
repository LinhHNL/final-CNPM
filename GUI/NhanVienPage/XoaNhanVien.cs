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
    public partial class XoaNhanVien : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public XoaNhanVien()
        {
            InitializeComponent();
            dgv_NhanVien.Rows.Add(true, "0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add(true, "0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add(true, "0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add(true, "0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add(true, "0", "asd", "asd", "asd", "asd", "adsd");
            dgv_NhanVien.Rows.Add(true, "0", "asd", "asd", "asd", "asd", "adsd");
            culture = CultureInfo.CurrentCulture;
            SetLanguage("en-US");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoSoNhanVien form = new HoSoNhanVien(); 
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
            btn_Back.Text = rm.GetString("backText", culture);
            lbl_staffList.Text = rm.GetString("staffListText", culture);
            lbl_Search.Text = rm.GetString("searchText", culture);
            tb_StaffID.PlaceholderText = rm.GetString("staffIDText", culture);
            cb_Department.Text = rm.GetString("departmentText", culture);
            btn_Delete.Text = rm.GetString("deleteText", culture);
            staffID.HeaderText = rm.GetString("staffIDText", culture);
            FullName.HeaderText = rm.GetString("fullNameText", culture);
            department.HeaderText = rm.GetString("departmentText", culture);
            Position.HeaderText = rm.GetString("positionText", culture);
            startWorkDate2.HeaderText = rm.GetString("startWorkDayText2", culture);
            status.HeaderText = rm.GetString("statusText", culture);
            cb_Department.PromptText = rm.GetString("departmentText", culture);
        }
    }
}
