using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WinFormsApp2.Components;

namespace WinFormsApp2
{

    public partial class AllMonAn : MetroFramework.Forms.MetroForm
    {
        private string lbl_showprice = "0 VNĐ";
        public AllMonAn()
        {
            InitializeComponent();
        }

        private void MonAn_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void myRoundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void Pa_ColorDis_Click(object sender, EventArgs e)
        {

        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            roundedButton5.BackColor = ColorTranslator.FromHtml("#E50111");
            roundedButton5.TextColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton6.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton6.TextColor = ColorTranslator.FromHtml("#A09F9F");
            roundedButton7.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton7.TextColor = ColorTranslator.FromHtml("#A09F9F");
            roundedButton8.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton8.TextColor = ColorTranslator.FromHtml("#A09F9F");
            RerenderKindFood(2);
        }

        private void roundedButton6_Click(object sender, EventArgs e)
        {
            roundedButton5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton5.TextColor = ColorTranslator.FromHtml("#A09F9F");
            roundedButton6.BackColor = ColorTranslator.FromHtml("#E50111");
            roundedButton6.TextColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton7.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton7.TextColor = ColorTranslator.FromHtml("#A09F9F");
            roundedButton8.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton8.TextColor = ColorTranslator.FromHtml("#A09F9F");
            RerenderKindFood(3);
        }

        private void roundedButton7_Click(object sender, EventArgs e)
        {
            roundedButton5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton5.TextColor = ColorTranslator.FromHtml("#A09F9F");
            roundedButton6.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton6.TextColor = ColorTranslator.FromHtml("#A09F9F");
            roundedButton7.BackColor = ColorTranslator.FromHtml("#E50111");
            roundedButton7.TextColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton8.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton8.TextColor = ColorTranslator.FromHtml("#A09F9F");
            RerenderKindFood(4);
        }

        private void roundedButton8_Click(object sender, EventArgs e)
        {
            roundedButton5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton5.TextColor = ColorTranslator.FromHtml("#A09F9F");
            roundedButton6.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton6.TextColor = ColorTranslator.FromHtml("#A09F9F");
            roundedButton7.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton7.TextColor = ColorTranslator.FromHtml("#A09F9F");
            roundedButton8.BackColor = ColorTranslator.FromHtml("#E50111");
            roundedButton8.TextColor = ColorTranslator.FromHtml("#FFFFFF");
            RerenderKindFood(5);
        }

        private void roundedButton9_Click(object sender, EventArgs e)
        {
            roundedButton5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton5.TextColor = ColorTranslator.FromHtml("#A09F9F");
            roundedButton6.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton6.TextColor = ColorTranslator.FromHtml("#A09F9F");
            roundedButton7.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton7.TextColor = ColorTranslator.FromHtml("#A09F9F");
            roundedButton8.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton8.TextColor = ColorTranslator.FromHtml("#A09F9F");
           
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomepageFormSingle homepageFormSingle = new HomepageFormSingle();
            homepageFormSingle.ShowDialog();
            this.Close();
        }

        private void roundedButton10_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signUpForm = new SignInForm();
            signUpForm.ShowDialog();
            this.Close();
        }
        private void RerenderKindFood(int kindfoodID)
        {
            panel_monan_1.Controls.Clear();
            BUS.Menu menu = new BUS.Menu();
            List<Dictionary<string, string>> menuList = menu.getAllMenu();
            foreach (Dictionary<string, string> item in menuList)
            {
                if (item["KindFoodID"] == kindfoodID.ToString() && item["Status"] == "1")
                {
                    panel_monan_1.Controls.Add(new Components.MonAnComponent(item["Name"], item["Price"], item["URLImage"], this));
                }
            }
            this.Updateprice();
        }
        private void MonAn_Load_1(object sender, EventArgs e)
        {
            RerenderKindFood(2);
            this.Updateprice();
        }

        private void btn_ChangetoForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShoppingCartForm ShoppingCartForm = new ShoppingCartForm();
            ShoppingCartForm.ShowDialog();
            this.Close();
        }
        public void Updateprice()
        {
            int price = 0;
            int tmpprice = 0;
            foreach (MonAnComponent i in StoringMonAnComponentShoppingCart.StoringMonAnComponentShoppingCartList)
            {
                tmpprice = Int32.Parse(i.getGiaMon()) * i.getSoLuong();
                price += tmpprice;
            }
            string pricestr = price.ToString();
            string changestr = "";
            for (int i = pricestr.Length - 3; i > 0; i -= 3)
            {
                changestr = pricestr.Insert(i, ".");
                pricestr = changestr;
            }
            lbl_priceshow.Text = pricestr + " VNĐ";
            this.lbl_showprice = pricestr + " VNĐ";
        }

    }
}
