using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinFormsApp2.AdminPage;
using System.Resources;
using System.Globalization;

namespace WinFormsApp2.NhanVienPage
{
    public partial class QuanLyDonTu : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        private static string approvedText = "";
        private static string pendingText = "";
        private static string rejectedText = "";
        public QuanLyDonTu()
        {
            InitializeComponent();
            var col = (DataGridViewButtonColumn)dgv_DonTu.Columns[4];
            col.FlatStyle = FlatStyle.Flat;
            col.DefaultCellStyle.ForeColor = Color.White;
            dgv_DonTu.AllowUserToAddRows = false;
            culture = CultureInfo.CurrentCulture;
            SetLanguage("en-US");
        }

        public void AddRowDonTu(String ma, String nhanVien, String ngay, String lyDo, int trangThai)
        {
            String state = "";
            Color bg;
            switch (trangThai)
            {
                case 0:
                    state = approvedText;
                    bg = ColorTranslator.FromHtml("#058C42");
                    break;
                case 1:
                    state = pendingText;
                    bg = ColorTranslator.FromHtml("#F9A620");
                    break;
                case -1:
                    state = rejectedText;
                    bg = ColorTranslator.FromHtml("#850A0A");
                    break;
                default:
                    return;
            }
            dgv_DonTu.Rows.Add(ma, nhanVien, ngay, lyDo, state);
            dgv_DonTu.Rows[dgv_DonTu.Rows.Count - 1 ].Cells[4].Style.BackColor = bg;
        }

        private void QuanLyDonTu_Load(object sender, EventArgs e)
        {
            AddRowDonTu("...", "...", "--/ --/ ----", "...", 1);
            AddRowDonTu("...", "...", "--/ --/ ----", "...", 0);
            AddRowDonTu("...", "...", "--/ --/ ----", "...", -1);
            dgv_DonTu.ClearSelection();
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
            cb_Department.PromptText = rm.GetString("departmentText", culture);
            btn_PayRoll.Text = rm.GetString("payrollText", culture);
            lbl_Month.Text = rm.GetString("monthText", culture);
            lbl_letterManagement.Text = rm.GetString("letterManagementText", culture);
            tb_staffIDName.PlaceholderText = rm.GetString("staffIDNameText", culture);
            letterID.HeaderText = rm.GetString("letterIDText", culture);
            Staff.HeaderText = rm.GetString("staffText", culture);
            letterDate.HeaderText = rm.GetString("letterDateText", culture);
            Reason.HeaderText = rm.GetString("reasonText", culture);
            status.HeaderText = rm.GetString("statusText", culture);
            cb_Month.PromptText = rm.GetString("monthText", culture);
            pendingText = rm.GetString("pendingText", culture);
            approvedText = rm.GetString("approvedText", culture);
            rejectedText = rm.GetString("rejectedText", culture);
        }
    }
}
