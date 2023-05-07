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
    public partial class DonTu : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        private static string approvedText = "";
        private static string pendingText = "";
        private static string rejectedText = "";
        private static string detailText = "";
        public DonTu()
        {
            InitializeComponent();
            var col = (DataGridViewButtonColumn)dgv_Letter.Columns[4];
            col.FlatStyle = FlatStyle.Flat;
            col.DefaultCellStyle.ForeColor = Color.White;
            dgv_Letter.AllowUserToAddRows = false;
            SetLanguage("en-US");
        }

        public void AddRowDonTu(int STT, String loaiDon, String ngaylamdon, String ngayxuly, int trangThai, String chitiet)
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
            dgv_Letter.Rows.Add(STT, loaiDon, ngaylamdon, ngayxuly, state, chitiet);
            dgv_Letter.Rows[dgv_Letter.Rows.Count - 1 ].Cells[4].Style.BackColor = bg;
            dgv_Letter.Rows[dgv_Letter.Rows.Count - 1].Cells[5].Style.ForeColor = ColorTranslator.FromHtml("#E50111");
        }

        private void QuanLyDonTu_Load(object sender, EventArgs e)
        {
            AddRowDonTu(1, "...", "--/ --/ ----", "--/ --/ ----", 1, detailText);
            AddRowDonTu(2, "...", "--/ --/ ----", "--/ --/ ----", 0, detailText);
            AddRowDonTu(3, "...", "--/ --/ ----", "--/ --/ ----", -1, detailText);
            dgv_Letter.ClearSelection();
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LamDon form = new LamDon();
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
            this.Hide();
            ThongBao form = new ThongBao();
            form.ShowDialog();
            this.Close();
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


            lbl_MakeLetter.Text = rm.GetString("makeLetterText", culture);
            btn_CreateLetter.Text = rm.GetString("createLetterText", culture);
            lbl_LetterHistory.Text = rm.GetString("letterHistoryText", culture);
            Number.HeaderText = rm.GetString("numberText", culture);
            LetterType.HeaderText = rm.GetString("letterTypeText", culture);
            MakeLetterDate.HeaderText = rm.GetString("makeLetterDateText", culture);
            ProcessingDate.HeaderText = rm.GetString("processingDateText", culture);
            Status.HeaderText = rm.GetString("statusText", culture);
            pendingText = rm.GetString("pendingText", culture);
            approvedText = rm.GetString("approvedText", culture);
            rejectedText = rm.GetString("rejectedText", culture);
            detailText = rm.GetString("detailText", culture);
            cb_Letter.PromptText = rm.GetString("timekeepingConfirmLetterText", culture);

        }
    }
}
