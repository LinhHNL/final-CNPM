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
    public partial class MonAnComponent : UserControl
    {
        private String MenuID = "";
        private String TenMon = "";
        private String GiaMon = "";
        private String URLImage = "";
        private int Soluongdaadd = 0;
        private AllMonAn Context;
        private HomepageFormSingle ContextHomePage;
        public MonAnComponent()
        {
            InitializeComponent();
        }
        public MonAnComponent(string menuID,String ten, String gia)
        {
            InitializeComponent();
            TenMon = ten;
            GiaMon = gia;
            lbl_ten.Text = ten;
            lbl_gia.Text = gia;
        }
        public MonAnComponent(string menuID,String ten, String gia, String URLImage)
        {
            InitializeComponent();
            TenMon = ten;
            GiaMon = gia;
            lbl_ten.Text = ten;
            lbl_gia.Text = gia;
            this.URLImage= URLImage;
            pb_FoodImage.Image = Base64ToImage(URLImage);
        }

        public MonAnComponent(string menuID,String ten, String gia, String URLImage, AllMonAn context)
        {
            InitializeComponent();
            TenMon = ten;
            Context = context;
            GiaMon = gia;
            lbl_ten.Text = ten;
            lbl_gia.Text = ChangeGia(gia);
            pb_FoodImage.Image = Base64ToImage(URLImage);
            MenuID = menuID;
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

        public MonAnComponent(string menuID,String ten, String gia, String URLImage, HomepageFormSingle context)
        {
            InitializeComponent();
            TenMon = ten;
            ContextHomePage = context;
            GiaMon = gia;
            lbl_ten.Text = ten;
            lbl_gia.Text = ChangeGia(gia);
            pb_FoodImage.Image = Base64ToImage(URLImage);
            this.MenuID = menuID;
        }
        public String getTenMon()
        {
            return TenMon;
        }
        public String getMenuID()
        {
            return MenuID;
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
        private void add_them_soluong_Click(object sender, EventArgs e)
        {
            StoringMonAnComponentShoppingCart.Add(this);
            if (Context != null)
            {
                Context.Updateprice();
            }
            else
            {
                ContextHomePage.Updateprice();
            }
        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
