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
using System.Resources;
using System.Globalization;
using WinFormsApp2.KhoPage;

namespace WinFormsApp2
{

    public partial class AllMonAn : MetroFramework.Forms.MetroForm
    {
        private string lbl_showprice = "0 VNĐ";
        CultureInfo culture;
        public AllMonAn()
        {
            InitializeComponent();
            SetLanguage("en-US");
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
            btn_SavouryFood.BackColor = ColorTranslator.FromHtml("#E50111");
            btn_SavouryFood.TextColor = ColorTranslator.FromHtml("#FFFFFF");
            btn_Vegetable.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            btn_Vegetable.TextColor = ColorTranslator.FromHtml("#A09F9F");
            btn_Snack.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            btn_Snack.TextColor = ColorTranslator.FromHtml("#A09F9F");
            btn_Beverage.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            btn_Beverage.TextColor = ColorTranslator.FromHtml("#A09F9F");
            RerenderKindFood(2);
        }

        private void roundedButton6_Click(object sender, EventArgs e)
        {
            btn_SavouryFood.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            btn_SavouryFood.TextColor = ColorTranslator.FromHtml("#A09F9F");
            btn_Vegetable.BackColor = ColorTranslator.FromHtml("#E50111");
            btn_Vegetable.TextColor = ColorTranslator.FromHtml("#FFFFFF");
            btn_Snack.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            btn_Snack.TextColor = ColorTranslator.FromHtml("#A09F9F");
            btn_Beverage.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            btn_Beverage.TextColor = ColorTranslator.FromHtml("#A09F9F");
            RerenderKindFood(3);
        }

        private void roundedButton7_Click(object sender, EventArgs e)
        {
            btn_SavouryFood.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            btn_SavouryFood.TextColor = ColorTranslator.FromHtml("#A09F9F");
            btn_Vegetable.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            btn_Vegetable.TextColor = ColorTranslator.FromHtml("#A09F9F");
            btn_Snack.BackColor = ColorTranslator.FromHtml("#E50111");
            btn_Snack.TextColor = ColorTranslator.FromHtml("#FFFFFF");
            btn_Beverage.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            btn_Beverage.TextColor = ColorTranslator.FromHtml("#A09F9F");
            RerenderKindFood(4);
        }

        private void roundedButton8_Click(object sender, EventArgs e)
        {
            btn_SavouryFood.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            btn_SavouryFood.TextColor = ColorTranslator.FromHtml("#A09F9F");
            btn_Vegetable.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            btn_Vegetable.TextColor = ColorTranslator.FromHtml("#A09F9F");
            btn_Snack.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            btn_Snack.TextColor = ColorTranslator.FromHtml("#A09F9F");
            btn_Beverage.BackColor = ColorTranslator.FromHtml("#E50111");
            btn_Beverage.TextColor = ColorTranslator.FromHtml("#FFFFFF");
            RerenderKindFood(5);
        }

        private void roundedButton9_Click(object sender, EventArgs e)
        {
            btn_SavouryFood.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            btn_SavouryFood.TextColor = ColorTranslator.FromHtml("#A09F9F");
            btn_Vegetable.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            btn_Vegetable.TextColor = ColorTranslator.FromHtml("#A09F9F");
            btn_Snack.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            btn_Snack.TextColor = ColorTranslator.FromHtml("#A09F9F");
            btn_Beverage.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            btn_Beverage.TextColor = ColorTranslator.FromHtml("#A09F9F");
           
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
            SqlConnection conn = new SqlConnection("Data Source = LAPTOP-VERULPGO\\SQLEXPRESS; Initial Catalog = hadilao; Integrated Security = True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from menu where KindFoodID=" + kindfoodID, conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    panel_monan_1.Controls.Add(new Components.MonAnComponent(reader["ten"].ToString(), reader["giaban"].ToString()));
                }
                panel_monan_1.Controls.Add(new Components.MonAnComponent("PrettyU", "5000", this));
                panel_monan_1.Controls.Add(new Components.MonAnComponent("Aju Nice", "50000", this));
                panel_monan_1.Controls.Add(new Components.MonAnComponent("Home", "500000", this));
                panel_monan_1.Controls.Add(new Components.MonAnComponent("Don't Wanna Cry", "5000000", this));
                panel_monan_1.Controls.Add(new Components.MonAnComponent("Come back home, I'm the best", "50000000", this));
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

        public void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("GUI.Language.MyResource",
                             typeof(HangHoaTrongKho).Assembly);
            btn_SignOut.Text = rm.GetString("signoutText", culture);
            btn_Hotpot.Text = rm.GetString("hotpotText", culture);
            btn_AccountForm.Text = rm.GetString("accountText", culture);
            btn_SignOut.Text = rm.GetString("signoutText", culture);
            btn_Cart.Text = rm.GetString("cartText", culture);
            btn_SavouryFood.Text = rm.GetString("savouryFoodText", culture);
            btn_Vegetable.Text = rm.GetString("vegetableText", culture);
            btn_Snack.Text = rm.GetString("snackText", culture);
            btn_Beverage.Text = rm.GetString("beverageText", culture);
        }


    }
}
