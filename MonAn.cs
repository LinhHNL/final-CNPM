using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{

    public partial class MonAn : MetroFramework.Forms.MetroForm
    {

        public MonAn()
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
            roundedButton9.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton9.TextColor = ColorTranslator.FromHtml("#A09F9F");
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
            roundedButton9.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton9.TextColor = ColorTranslator.FromHtml("#A09F9F");
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
            roundedButton9.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton9.TextColor = ColorTranslator.FromHtml("#A09F9F");
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
            roundedButton9.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            roundedButton9.TextColor = ColorTranslator.FromHtml("#A09F9F");
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
            roundedButton9.BackColor = ColorTranslator.FromHtml("#E50111");
            roundedButton9.TextColor = ColorTranslator.FromHtml("#FFFFFF");
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
    }
}
