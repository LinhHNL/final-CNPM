using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.AdminPage;

namespace WinFormsApp2.Components
{
    public partial class MonAnComponentForAdding : UserControl
    {
        private String TenMon = "";
        private String GiaMon = "";
        private int Soluongdaadd = 0;
        private bool Checking = false;
        private AdminAddingComboFood context;
        public MonAnComponentForAdding(string ten)
        {
            InitializeComponent();
            TenMon = ten;
            lbl_ten.Text = ten;
            btn_uncheckedadding.Hide();
        }


        public MonAnComponentForAdding(String ten, AdminAddingComboFood context)
        {
            InitializeComponent();
            TenMon = ten;
            lbl_ten.Text = ten;
            this.context = context;
        }
        public String getTenMon()
        {
            return TenMon;
        }
        public String getGiaMon()
        {
            return GiaMon;
        }
        public int getSoLuong()
        {
            return Soluongdaadd;
        }
        public void TangSoLuong()
        {
            this.Soluongdaadd++;
        }
        public void GiamSoLuong()
        {
            this.Soluongdaadd--;
        }
        public void setTrangThai()
        {
            this.Checking = !this.Checking;
        }
        public bool getTrangThai()
        {
            return this.Checking;
        }
        private void add_them_soluong_Click(object sender, EventArgs e)
        {
            btn_add_them_soluong.Hide();
            btn_uncheckedadding.Show();
            this.setTrangThai();
            if(this.Checking && StoringMonAnComponentForAdding.StoringMonAnAdding.Find(x => x.getTenMon().Equals(this.getTenMon())) == null)
            {
            this.Soluongdaadd++;
            StoringMonAnComponentForAdding.StoringMonAnAdding.Add(this);
            }
            context.HienThiMonAn();
        }

        private void btn_uncheckedadding_Click(object sender, EventArgs e)
        {
            btn_add_them_soluong.Show();
            btn_uncheckedadding.Hide();
            this.setTrangThai();
            this.Soluongdaadd--;
            context.HienThiMonAn();
        }
    }
}
