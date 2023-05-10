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

    public partial class QuanLyChamCongBangChamCong2 : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public QuanLyChamCongBangChamCong2()
        {
            InitializeComponent();
            culture = CultureInfo.CurrentCulture;
            SetLanguage("en-US");
        }


        private void btn_Back_Click(object sender, EventArgs e)
        {
            QuanLyChamCongBangChamCong form = new QuanLyChamCongBangChamCong();
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
            lbl_Timekeeping.Text = rm.GetString("timekeepingText", culture);
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
