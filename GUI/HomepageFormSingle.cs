using System.Data.SqlClient;
using WinFormsApp2.Components;
using System.Resources;
using System.Globalization;
using WinFormsApp2.KhoPage;

namespace WinFormsApp2
{
    public partial class HomepageFormSingle : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        String chooseOneText = "";
        String chooseTwoText = "";
        String chooseFourText = "";

        public HomepageFormSingle()
        {
            InitializeComponent();
            SetLanguage("en-US");

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
            btn_showprice.Text = pricestr + " VNĐ";
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

        private void btn_singlePot_Click(object sender, EventArgs e)
        {
            lbl_Message.Text = chooseOneText;
            panel_doublePot.Visible = false;
            panel_singlePot.Visible = true;
            panel_fourPot.Visible = false;
            btn_SinglePot.BackColor = ColorTranslator.FromHtml("#E50111");
            btn_SinglePot.ForeColor = Color.White;
            btn_DualSidedPot.BackColor = ColorTranslator.FromHtml("#DEE2E6");
            btn_DualSidedPot.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            btn_FourSidedPot.BackColor = ColorTranslator.FromHtml("#DEE2E6");
            btn_FourSidedPot.ForeColor = ColorTranslator.FromHtml("#A09F9F");
        }

        private void btn_doublePot_Click(object sender, EventArgs e)
        {
            lbl_Message.Text = chooseTwoText;
            panel_doublePot.Visible = true;
            panel_singlePot.Visible = false;
            panel_fourPot.Visible = false;
            btn_DualSidedPot.BackColor = ColorTranslator.FromHtml("#E50111");
            btn_DualSidedPot.ForeColor = Color.White;
            btn_SinglePot.BackColor = ColorTranslator.FromHtml("#DEE2E6");
            btn_SinglePot.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            btn_FourSidedPot.BackColor = ColorTranslator.FromHtml("#DEE2E6");
            btn_FourSidedPot.ForeColor = ColorTranslator.FromHtml("#A09F9F");
        }

        private void btn_fourPot_Click(object sender, EventArgs e)
        {
            lbl_Message.Text = chooseFourText;
            panel_doublePot.Visible = false;
            panel_singlePot.Visible = false;
            panel_fourPot.Visible = true;
            btn_FourSidedPot.BackColor = ColorTranslator.FromHtml("#E50111");
            btn_FourSidedPot.ForeColor = Color.White;
            btn_SinglePot.BackColor = ColorTranslator.FromHtml("#DEE2E6");
            btn_SinglePot.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            btn_DualSidedPot.BackColor = ColorTranslator.FromHtml("#DEE2E6");
            btn_DualSidedPot.ForeColor = ColorTranslator.FromHtml("#A09F9F");
        }





        private void btn_ChangeToSectionFood1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllMonAn homepageFormSingle = new AllMonAn();
            homepageFormSingle.ShowDialog();
            this.Close();
        }

        private void btn_ChangeToSectionFood2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllMonAn homepageFormSingle = new AllMonAn();
            homepageFormSingle.ShowDialog();
            this.Close();
        }

        private void btn_ChangeToSectionFood3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllMonAn homepageFormSingle = new AllMonAn();
            homepageFormSingle.ShowDialog();
            this.Close();
        }

        private void btn_ChangeToSectionFood4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllMonAn homepageFormSingle = new AllMonAn();
            homepageFormSingle.ShowDialog();
            this.Close();
        }

        private void btn_ChangeToSectionFood5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllMonAn homepageFormSingle = new AllMonAn();
            homepageFormSingle.ShowDialog();
            this.Close();
        }

        private void btn_ReturnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signUpForm = new SignInForm();
            signUpForm.ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void HomepageFormSingle_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = LAPTOP-VERULPGO\\SQLEXPRESS; Initial Catalog = hadilao; Integrated Security = True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select ten, giaban from monan", conn);

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
                this.Updateprice();
            }
        }

        private void btn_ChangingtoCartForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShoppingCartForm ShoppingCartForm = new ShoppingCartForm();
            ShoppingCartForm.ShowDialog();
            this.Close();
        }


        public void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("GUI.Language.MyResource",
                             typeof(HangHoaTrongKho).Assembly);
            btn_SignOut.Text = rm.GetString("signoutText", culture);
            btn_Hotpot.Text = rm.GetString("hotpotText", culture);
            btn_SinglePot.Text = rm.GetString("singlePotText", culture);
            btn_DualSidedPot.Text = rm.GetString("dualSidedPotText", culture);
            btn_FourSidedPot.Text = rm.GetString("fourSidedPotText", culture);
            btn_AccountForm.Text = rm.GetString("accountText", culture);
            btn_SignOut.Text = rm.GetString("signoutText", culture);
            btn_Cart.Text = rm.GetString("cartText", culture);
            btn_SavouryFood.Text = rm.GetString("savouryFoodText", culture);
            btn_Vegetable.Text = rm.GetString("vegetableText", culture);
            btn_Snack.Text = rm.GetString("snackText", culture);
            btn_Beverage.Text = rm.GetString("beverageText", culture);
            lbl_Message.Text = rm.GetString("chooseOneText", culture);
            chooseOneText = rm.GetString("chooseOneText", culture);
            chooseTwoText = rm.GetString("chooseTwoText", culture);
            chooseFourText = rm.GetString("chooseFourText", culture);
        }
    }
}
