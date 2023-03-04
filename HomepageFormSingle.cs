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
    public partial class HomepageFormSingle : MetroFramework.Forms.MetroForm
    {
        public HomepageFormSingle()
        {
            InitializeComponent();
        }

        private void HomepageForm_Load(object sender, EventArgs e)
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

        private void btn_singlePot_Click(object sender, EventArgs e)
        {
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
    }
}
