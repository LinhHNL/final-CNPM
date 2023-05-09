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
using WinFormsApp2;

namespace GUI.Components
{
    public partial class UpdateFoodCom : UserControl
    {
        public UpdateFoodCom()
        {
            InitializeComponent();
        }
        private String IDFood = "";
        private String TenMon = "";
        private String GiaMon = "";
        private String URLImage = "";
        private int Soluongdaadd = 0;
        private AllMonAn Context;
        private HomepageFormSingle ContextHomePage;
        private LockFood ContextLockFood;
        private UpdateFood ContextUpdateFood;
        public UpdateFoodCom(String ten, String gia)
        {
            InitializeComponent();
            TenMon = ten;
            GiaMon = gia;
            lbl_ten.Text = ten;
            lbl_gia.Text = ChangeGia(gia);
        }
        public UpdateFoodCom(String ten, String gia, String URLImage)
        {
            InitializeComponent();
            TenMon = ten;
            GiaMon = gia;
            lbl_ten.Text = ten;
            lbl_gia.Text = ChangeGia(gia);
            this.URLImage = URLImage;
            pb_FoodImage.Image = Base64ToImage(URLImage);
        }
        public UpdateFoodCom(String IdFood, String ten, String gia, String URLImage, LockFood ContextLockFood)
        {
            InitializeComponent();
            this.IDFood = IdFood;
            TenMon = ten;
            GiaMon = gia;
            lbl_ten.Text = ten;
            lbl_gia.Text = ChangeGia(gia);
            this.URLImage = URLImage;
            pb_FoodImage.Image = Base64ToImage(URLImage);
            this.ContextLockFood = ContextLockFood;
        }
        public UpdateFoodCom(String IdFood, String ten, String gia, String URLImage, UpdateFood ContextUpdateFood)
        {
            InitializeComponent();
            this.IDFood = IdFood;
            TenMon = ten;
            GiaMon = gia;
            lbl_ten.Text = ten;
            lbl_gia.Text = ChangeGia(gia);
            this.URLImage = URLImage;
            pb_FoodImage.Image = Base64ToImage(URLImage);
            this.ContextUpdateFood = ContextUpdateFood;
        }
        public UpdateFoodCom(String ten, String gia, String URLImage, AllMonAn context)
        {
            InitializeComponent();
            TenMon = ten;
            Context = context;
            GiaMon = gia;
            lbl_ten.Text = ten;
            lbl_gia.Text = ChangeGia(gia);
            pb_FoodImage.Image = Base64ToImage(URLImage);
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

        public UpdateFoodCom(String ten, String gia, String URLImage, HomepageFormSingle context)
        {
            InitializeComponent();
            TenMon = ten;
            ContextHomePage = context;
            GiaMon = gia;
            lbl_ten.Text = ten;
            lbl_gia.Text = ChangeGia(gia);
            pb_FoodImage.Image = Base64ToImage(URLImage);
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


        private void btn_UpdateFood_Click_1(object sender, EventArgs e)
        {
            ContextUpdateFood.Hide();
            UpdateFoodForm UpdateFoodForm = new UpdateFoodForm(IDFood);
            UpdateFoodForm.ShowDialog();
            ContextUpdateFood.Close();
        }
    }
}

