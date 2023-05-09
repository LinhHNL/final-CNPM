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
    public partial class XemThongTinHangHoa : MetroFramework.Forms.MetroForm
    {
        private string hanghoaid = "1";
        public XemThongTinHangHoa(string hanghoaid)
        {
            InitializeComponent();
            this.hanghoaid = hanghoaid;
        }

        private void XemThongTinHangHoa_Load(object sender, EventArgs e)
        {
            if (hanghoaid != null)
            {
                BUS.Warehouse bus = new BUS.Warehouse();
                int id = int.Parse(hanghoaid);
                Dictionary<String, String> result = bus.getCommodityByID(id);
                tb_MaHang.Texts = result["CommodityID"].ToString();
                tb_SoLuong.Texts = Convert.ToDouble(result["Number"]).ToString();
                tb_TenHang.Texts = result["Name"].ToString();
                tb_Donvitinh.Texts = result["UnitName"].ToString();
            }
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuaThongTinHangHoa form = new SuaThongTinHangHoa(this.hanghoaid);
            form.ShowDialog();
            this.Close();
        }
    }
}
