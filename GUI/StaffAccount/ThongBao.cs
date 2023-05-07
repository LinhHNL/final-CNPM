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
    public partial class ThongBao : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        private bool editMode = false;
        public ThongBao()
        {
            InitializeComponent();
            SetLanguage("en-US");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            DonTu form = new DonTu();
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

        }
    }
}
