using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;

namespace WinFormsApp2.KhoPage
{
    public partial class HangHoaTrongKho : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public HangHoaTrongKho()
        {
            InitializeComponent();

            SetLanguage("en-US");

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
            int numberofID = dgv_InStock.RowCount;
            this.Hide();
            ThemHangHoa form = new ThemHangHoa(numberofID);
            form.ShowDialog();
            this.Close();
        }
        private void btn_KiemKho_Click(object sender, EventArgs e)
        {
            btn_InStock.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            btn_InStock.BackColor = ColorTranslator.FromHtml("white");
            btn_InventoryControl.BackColor = ColorTranslator.FromHtml("#E50111");
            btn_InventoryControl.ForeColor = ColorTranslator.FromHtml("white");
            if (btn_Import.Visible == false)
            {
                btn_Import.Visible = true;
                btn_Export.Visible = true;
            }
            else
            {
                btn_Import.Visible = false;
                btn_Export.Visible = false;
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

                string value = "";
                if (dgv_InStock.Rows[e.RowIndex].Cells[0].Value == null)

                {
                    value = "0";
                }
                else
                {
                    value = dgv_InStock.Rows[e.RowIndex].Cells[0].Value.ToString();
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

=======
        public void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("GUI.Language.MyResource",
                             typeof(HangHoaTrongKho).Assembly);
            btn_InStock.Text = rm.GetString("inStockText", culture);
            btn_InventoryControl.Text = rm.GetString("inventoryControlText", culture);
            btn_Import.Text = rm.GetString("importText", culture);
            btn_Export.Text = rm.GetString("exportText", culture);
            btn_SignOut.Text = rm.GetString("signoutText", culture);
            btn_Delete.Text = rm.GetString("deleteText", culture);
            btn_Add.Text = rm.GetString("addText", culture);
            btn_ExportFile.Text = rm.GetString("exportFileText", culture);
            CommodityName.HeaderText = rm.GetString("commodityIDNameText", culture);
            CommodityID.HeaderText = rm.GetString("commodityIDText", culture);
            Unit.HeaderText = rm.GetString("unitText", culture);
            Quantity.HeaderText = rm.GetString("quantityText", culture);
            ImportDate.HeaderText = rm.GetString("importDateText", culture);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
>>>>>>> 8d249ced943f806d153ec3e35ac6189216f94312
        }
    }
}
