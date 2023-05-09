using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.Components
{
    public partial class MonAnComponentForKitchen : UserControl
    {
        private String Tenmon = "";
        private int SoLuong = 0;
        private String MenuID = "";
        public MonAnComponentForKitchen()
        {
            InitializeComponent();
        }

        public MonAnComponentForKitchen(String MenuID,string TenMon, int SoLuong)
        {
            //Set số lượng
            this.Tenmon = TenMon;
            this.SoLuong = SoLuong;
            InitializeComponent();
            lbl_TenMon.Text = this.Tenmon;
            lbl_SoLuong.Text = this.SoLuong.ToString();
            this.MenuID = MenuID;
        }
        public String getTenMon()
        {
            return this.Tenmon;
        }
        public String getMenuID()
        {
            return this.MenuID;
        }
    }
}
