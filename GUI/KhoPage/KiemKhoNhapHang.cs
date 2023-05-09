using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace WinFormsApp2.KhoPage
{
    public partial class KiemKhoNhapHang : MetroFramework.Forms.MetroForm
    {
        public KiemKhoNhapHang()
        {
            InitializeComponent();
            BUS.Order order = new BUS.Order();
            List<Dictionary<string, string>> importList = order.getAllImportOrder();
            foreach (Dictionary<string, string> item in importList)
            {
                dgv_NhapHang.Rows.Add(item["ImportOrderID"], item["Date"], item["Name"]);
            }
        }

        private void btn_PhieuXuatHang_Click(object sender, EventArgs e)
        {
            int numberofID = dgv_NhapHang.RowCount;
            this.Hide();
            KiemKhoTaoPhieuNhapHang form = new KiemKhoTaoPhieuNhapHang(numberofID);
            form.ShowDialog();
            this.Close();
        }


        private void btn_HangTrongKho_Click(object sender, EventArgs e)
        {
            btn_HangTrongKho.ForeColor = ColorTranslator.FromHtml("white");
            btn_HangTrongKho.BackColor = ColorTranslator.FromHtml("#E50111");
            btn_KiemKho.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            btn_KiemKho.BackColor = ColorTranslator.FromHtml("white");
            btn_NhapHang.Visible = false;
            btn_XuatHang.Visible = false;
            this.Hide();
            HangHoaTrongKho form = new HangHoaTrongKho();
            form.ShowDialog();
            this.Close();
        }

        private void btn_XuatHang_Click(object sender, EventArgs e)
        {
            btn_NhapHang.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            this.Hide();
            KiemKhoXuatHang form = new KiemKhoXuatHang();
            form.ShowDialog();
            this.Close();
        }

        private void dgv_NhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string value = "";
                if (dgv_NhapHang.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    value = "";
                }
                else
                {
                    value = dgv_NhapHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.Hide();
                    KiemKhoXemPhieuNhapHang form = new KiemKhoXemPhieuNhapHang(value);
                    form.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
