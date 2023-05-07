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
    public partial class QuanLyDonTuNoiDungDon : MetroFramework.Forms.MetroForm
    {
        private bool editMode = false;
        CultureInfo culture;

        public QuanLyDonTuNoiDungDon()
        {
            InitializeComponent();
            culture = CultureInfo.CurrentCulture;
            SetLanguage("en-US");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            QuanLyDonTu form = new QuanLyDonTu();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            btn_Edit.BackColor = ColorTranslator.FromHtml("#6C757D");
            btn_Save.BackColor = ColorTranslator.FromHtml("#E50111");
            editMode = true; 
        }

        private void QuanLyDonTuNoiDungDon_Load(object sender, EventArgs e)
        {
            cb_Status.SelectedIndex = 0;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            btn_Save.BackColor = ColorTranslator.FromHtml("#6C757D");
            btn_Edit.BackColor = ColorTranslator.FromHtml("#E50111");
            editMode = false;
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
            lbl_letterContent.Text = rm.GetString("letterContentText", culture);
            lbl_staffID.Text = rm.GetString("staffIDText", culture);
            lbl_reason.Text = rm.GetString("reasonText", culture);
            lbl_reasonDescription.Text = rm.GetString("reasonDescriptionText", culture);
            lbl_FullName.Text = rm.GetString("fullNameText", culture);
            lbl_letterDate.Text = rm.GetString("letterDateText", culture);
            btn_Back.Text = rm.GetString("backText", culture);
            btn_Edit.Text = rm.GetString("updateText", culture);
            btn_Save.Text = rm.GetString("saveText", culture);
            lbl_Status.Text = rm.GetString("statusText", culture);
            
        }
    }
}
