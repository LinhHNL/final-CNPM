﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Components;

namespace WinFormsApp2
{
    public partial class HomepageFormSingle : MetroFramework.Forms.MetroForm
    {
        public HomepageFormSingle()
        {
            InitializeComponent();
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

        private void metroTile2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void roundedButton18_Click(object sender, EventArgs e)
        {

        }

        private void btn_rightDoublePot_Click(object sender, EventArgs e)
        {

        }

        private void btn_topLeftFourPot_Click(object sender, EventArgs e)
        {

        }

        private void btn_bottomLeftFourPot_Click(object sender, EventArgs e)
        {

        }

        private void btn_topRightFourPot_Click(object sender, EventArgs e)
        {

        }

        private void btn_bottomRightFourPot_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton22_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonAn homepageFormSingle = new MonAn();
            homepageFormSingle.ShowDialog();
            this.Close();
        }

        private void roundedButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonAn homepageFormSingle = new MonAn();
            homepageFormSingle.ShowDialog();
            this.Close();
        }

        private void roundedButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonAn homepageFormSingle = new MonAn();
            homepageFormSingle.ShowDialog();
            this.Close();
        }

        private void roundedButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonAn homepageFormSingle = new MonAn();
            homepageFormSingle.ShowDialog();
            this.Close();
        }

        private void roundedButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonAn homepageFormSingle = new MonAn();
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
    }
}
