using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.KhoPage
{
    public partial class KiemKhoXuatHang : MetroFramework.Forms.MetroForm
    {
        public KiemKhoXuatHang()
        {
            InitializeComponent();
            BUS.Order order = new BUS.Order();
            List<Dictionary<string, string>> ExportList = order.getAllExportOrder();
            foreach (Dictionary<string, string> item in ExportList)
            {
                dgv_XuatHang.Rows.Add(item["ExportOrderID"], item["Date"], item["Name"]);
            }
        }

        private void btn_PhieuXuatHang_Click(object sender, EventArgs e)
        {
            int numberofID = dgv_XuatHang.RowCount;
            this.Hide();
            KiemKhoTaoPhieuXuatHang form = new KiemKhoTaoPhieuXuatHang(numberofID);
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
        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            btn_NhapHang.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            this.Hide();
            KiemKhoNhapHang form = new KiemKhoNhapHang();
            form.ShowDialog();
            this.Close();
        }

        private void dgv_XuatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string value = "";
                if (dgv_XuatHang.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    value = "";
                }
                else
                {
                    value = dgv_XuatHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.Hide();
                    KiemKhoXemPhieuXuatHang form = new KiemKhoXemPhieuXuatHang(value);
                    form.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
