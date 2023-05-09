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
        private String ID = "";
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
        public static Image Base64ToImage(string base64String)
        {
            // Convert the Base64 string to a byte array
            var bytes = Convert.FromBase64String(base64String);
            // Create a MemoryStream from the byte array
            using (var ms = new MemoryStream(bytes))
            {
                // Create an Image from the MemoryStream
                var image = Image.FromStream(ms);
                return image;
            }
        }
        public MonAnComponentForAdding(String ID, String ten, String URLImage, AdminAddingComboFood context)
        {
            InitializeComponent();
            this.ID = ID;
            TenMon = ten;
            this.context = context;
            lbl_ten.Text = ten;
            pb_FoodImage.Image = Base64ToImage(URLImage);
        }
        public MonAnComponentForAdding(String ten, AdminAddingComboFood context)
        {
            InitializeComponent();
            TenMon = ten;
            lbl_ten.Text = ten;
            this.context = context;
        }
        public String getIDMon()
        {
            return ID;
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
            if (Checking == true)
            {
                return;
            }
            btn_add_them_soluong.Hide();
            btn_uncheckedadding.Show();
            this.setTrangThai();
            if (this.Checking && StoringMonAnComponentForAdding.StoringMonAnAdding.Find(x => x.getTenMon().Equals(this.getTenMon())) == null)
            {
                this.Soluongdaadd++;
                StoringMonAnComponentForAdding.StoringMonAnAdding.Add(this);
                StoringMonAnPanel.StoringMonAnPanelList.Add(new Components.MonAnAddingInPanel(this.TenMon, this));
            }
            context.HienThiMonAn();
        }

        private void btn_uncheckedadding_Click(object sender, EventArgs e)
        {
            if (Checking == false)
            {
                return;
            }
            btn_add_them_soluong.Show();
            btn_uncheckedadding.Hide();
            this.setTrangThai();
            StoringMonAnComponentForAdding.Remove(this.TenMon);
            MonAnAddingInPanel itemcantim = StoringMonAnPanel.StoringMonAnPanelList.Find(x => x.getTen().Equals(this.getTenMon()));
            StoringMonAnPanel.StoringMonAnPanelList.Remove(itemcantim);
            this.Soluongdaadd = 0;
            context.HienThiMonAn();
        }
    }
}
