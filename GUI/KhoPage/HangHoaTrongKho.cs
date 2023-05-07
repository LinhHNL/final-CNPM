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
            dgv_InStock.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_InStock.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_InStock.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_InStock.Rows.Add("0", "asd", "asd", "asd", "asd");
            dgv_InStock.Rows.Add("0", "asd", "asd", "asd", "asd");
            SetLanguage("en-US");
        }

        

        private void dgv_XuatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemHangHoa form = new ThemHangHoa();
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
        }
    }
}
