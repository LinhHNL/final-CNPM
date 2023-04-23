using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.AdminPage;

namespace WinFormsApp2.Components
{
    public partial class MonAnAddingInPanel : UserControl
    {
        private string ten;
        private MonAnComponentForAdding context;
        private int soluong = 1;
        private int index = 0;
        public MonAnAddingInPanel(String Ten, MonAnComponentForAdding context)
        {   
            InitializeComponent();
            this.index = StoringMonAnComponentForAdding.StoringMonAnAdding.Count();
            this.ten = Ten;
            this.context = context;
            lbl_TenMon.Text = ten;
            lbl_SoLuong.Text = soluong.ToString();
        }

        private void btn_deleteitem_Click(object sender, EventArgs e)
        {

        }
        public int getIndex()
        {
            return index;
        }
        public String getTen()
        {
            return ten;
        }
        private void add_them_soluong_Click(object sender, EventArgs e)
        {
            MonAnComponentForAdding monancantang = StoringMonAnComponentForAdding.StoringMonAnAdding[index - 1];
            monancantang.TangSoLuong();
            lbl_SoLuong.Text = monancantang.getSoLuong().ToString();
        }
        public void setIndex(int value)
        {
            this.index = value;
        }
        private void btn_giamsoluong_Click(object sender, EventArgs e)
        {
            MonAnComponentForAdding monancantang = StoringMonAnComponentForAdding.StoringMonAnAdding[index - 1];
            if (monancantang.getSoLuong() == 1)
            {
                return;
            }
            monancantang.GiamSoLuong();
            lbl_SoLuong.Text = monancantang.getSoLuong().ToString();
            
        }
    }
}