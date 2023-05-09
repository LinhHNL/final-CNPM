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
    public partial class HangHoaTrongKho : MetroFramework.Forms.MetroForm
    {
        public HangHoaTrongKho()
        {
            InitializeComponent();

        }


        private void HangHoaTrongKho_Load(object sender, EventArgs e)
        {
            BUS.Warehouse bus = new BUS.Warehouse();
            List<Dictionary<String, string>> listCommodity = bus.gettingCommodity();

            if (listCommodity.Count == 0)
            {
                MessageBox.Show("Không có đối tượng commodity nào được tìm thấy.");
                return;
            }

            dgv_HangTrongKho.ColumnCount = 4;
            dgv_HangTrongKho.Columns[0].Name = "Mã hàng hóa";
            dgv_HangTrongKho.Columns[1].Name = "Tên hàng hóa";
            dgv_HangTrongKho.Columns[2].Name = "Số lượng";
            dgv_HangTrongKho.Columns[3].Name = "Đơn vị tính";

            foreach (Dictionary<String, String> commodity in listCommodity)
            {
                string[] row = new string[]
                {
                    commodity["CommodityID"],
                    commodity["Name"],
                    commodity["Number"],
                    commodity["UnitName"]
                };
                dgv_HangTrongKho.Rows.Add(row);
            }
        }

        private void dgv_XuatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            int numberofID = dgv_HangTrongKho.RowCount;
            this.Hide();
            ThemHangHoa form = new ThemHangHoa(numberofID);
            form.ShowDialog();
            this.Close();
        }
        private void btn_KiemKho_Click(object sender, EventArgs e)
        {
            btn_HangTrongKho.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            btn_HangTrongKho.BackColor = ColorTranslator.FromHtml("white");
            btn_KiemKho.BackColor = ColorTranslator.FromHtml("#E50111");
            btn_KiemKho.ForeColor = ColorTranslator.FromHtml("white");
            if (btn_NhapHang.Visible == false)
            {
                btn_NhapHang.Visible = true;
                btn_XuatHang.Visible = true;
            }
            else
            {
                btn_NhapHang.Visible = false;
                btn_XuatHang.Visible = false;
            }
            this.Hide();
            KiemKhoXuatHang form = new KiemKhoXuatHang();
            form.ShowDialog();
            this.Close();
        }

        private void dgv_HangTrongKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string value = "0";
                if (dgv_HangTrongKho.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    value = "0";
                }
                else
                {
                    value = dgv_HangTrongKho.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.Hide();
                    XemThongTinHangHoa form = new XemThongTinHangHoa(value);
                    form.ShowDialog();
                    this.Close();
                }
            }

        }



        private void btn_XuatFile_Click(object sender, EventArgs e)
        {

        }


        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
