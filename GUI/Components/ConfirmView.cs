using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Components
{
    public partial class ConfirmView : UserControl
    {
        private String Tenmon = "";
        public String IDMon = "";
        private String Giamon = "";
        private int index = 0;
        private int SoLuong = 0;
        private GUI.ConfirmView ContextConfirm;
        public ConfirmView()
        {
            InitializeComponent();
        }
        private string ChangeGia(String gia)
        {
            int price = 0;
            price = Int32.Parse(gia);
            string pricestr = price.ToString();
            string changestr = "";
            for (int i = pricestr.Length - 3; i > 0; i -= 3)
            {
                changestr = pricestr.Insert(i, ".");
                pricestr = changestr;
            }
            return pricestr + " ₫";
        }

        public ConfirmView(string IDMon, string TenMon, int SoLuong, String GiaMon, GUI.ConfirmView context)
        {
            //Set số lượng
            this.IDMon = IDMon;
            this.Tenmon = TenMon;
            this.Giamon = GiaMon;
            this.SoLuong = SoLuong;
            InitializeComponent();
            lbl_TenMon.Text = this.Tenmon;
            lbl_SoLuong.Text = this.SoLuong.ToString();
            this.ContextConfirm = context;
        }

        private void btn_ConfirmFood_Click(object sender, EventArgs e)
        {
            BUS.TempBill tempBill = new BUS.TempBill();
            Dictionary<String, String> StatusInfo = new Dictionary<String, String>();
            StatusInfo.Add("MenuID", IDMon);
            tempBill.tryingChangeStatus(StatusInfo);
            ContextConfirm.addingShowDetailMon();
        }
    }
}
