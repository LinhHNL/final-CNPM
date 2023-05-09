using System.Data.SqlClient;
using WinFormsApp2.Components;
using BUS;
using GUI.ThanhToan;

namespace WinFormsApp2
{
    public partial class HomepageFormSingle : MetroFramework.Forms.MetroForm
    {
        public HomepageFormSingle(String ResetValue)
        {
            InitializeComponent();
            if (ResetValue == "0")
            {
                Updateprice();
            }
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
            label7.Text = "Bạn đang chọn loại 1 đáy nồi";
            panel_doublePot.Visible = false;
            panel_singlePot.Visible = true;
            panel_fourPot.Visible = false;
            btn_singlePot.BackColor = ColorTranslator.FromHtml("#E50111");
            btn_singlePot.ForeColor = Color.White;
            btn_doublePot.BackColor = ColorTranslator.FromHtml("#DEE2E6");
            btn_doublePot.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            btn_fourPot.BackColor = ColorTranslator.FromHtml("#DEE2E6");
            btn_fourPot.ForeColor = ColorTranslator.FromHtml("#A09F9F");
        }

        private void btn_doublePot_Click(object sender, EventArgs e)
        {
            label7.Text = "Bạn đang chọn loại 2 đáy nồi";
            panel_doublePot.Visible = true;
            panel_singlePot.Visible = false;
            panel_fourPot.Visible = false;
            btn_doublePot.BackColor = ColorTranslator.FromHtml("#E50111");
            btn_doublePot.ForeColor = Color.White;
            btn_singlePot.BackColor = ColorTranslator.FromHtml("#DEE2E6");
            btn_singlePot.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            btn_fourPot.BackColor = ColorTranslator.FromHtml("#DEE2E6");
            btn_fourPot.ForeColor = ColorTranslator.FromHtml("#A09F9F");
        }

        private void btn_fourPot_Click(object sender, EventArgs e)
        {
            label7.Text = "Bạn đang chọn loại 4 đáy nồi";
            panel_doublePot.Visible = false;
            panel_singlePot.Visible = false;
            panel_fourPot.Visible = true;
            btn_fourPot.BackColor = ColorTranslator.FromHtml("#E50111");
            btn_fourPot.ForeColor = Color.White;
            btn_singlePot.BackColor = ColorTranslator.FromHtml("#DEE2E6");
            btn_singlePot.ForeColor = ColorTranslator.FromHtml("#A09F9F");
            btn_doublePot.BackColor = ColorTranslator.FromHtml("#DEE2E6");
            btn_doublePot.ForeColor = ColorTranslator.FromHtml("#A09F9F");
        }





        private void btn_ChangeToSectionFood1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllMonAn homepageFormSingle = new AllMonAn("0", 1);
            homepageFormSingle.ShowDialog();
            this.Close();
        }

        private void btn_ChangeToSectionFood2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllMonAn homepageFormSingle = new AllMonAn("0", 2);
            homepageFormSingle.ShowDialog();
            this.Close();
        }

        private void btn_ChangeToSectionFood3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllMonAn homepageFormSingle = new AllMonAn("0", 3);
            homepageFormSingle.ShowDialog();
            this.Close();
        }

        private void btn_ChangeToSectionFood4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllMonAn homepageFormSingle = new AllMonAn("0", 4);
            homepageFormSingle.ShowDialog();
            this.Close();
        }

        private void btn_ChangeToSectionFood5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllMonAn homepageFormSingle = new AllMonAn("0", 5);
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
            panel_monan_1.Controls.Clear();
            BUS.Menu menu = new BUS.Menu();
            List<Dictionary<string, string>> menuList = menu.getAllMenu();
            foreach (Dictionary<string, string> item in menuList)
            {
                if (item["KindFoodID"] == "1" && item["Status"] == "1")
                {
                    panel_monan_1.Controls.Add(new Components.MonAnComponent(item["MenuID"], item["Name"], item["Price"], item["URLImage"], this));
                }
            }
        }

        private void btn_ChangingtoCartForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShoppingCartForm ShoppingCartForm = new ShoppingCartForm();
            ShoppingCartForm.ShowDialog();
            this.Close();
        }

        private void btn_ComfirmFoodChange_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.ConfirmView confirmView = new GUI.ConfirmView();
            confirmView.ShowDialog();
            this.Close();
        }

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDonTong payment = new HoaDonTong();
            payment.ShowDialog();
            this.Close();
        }
    }
}
