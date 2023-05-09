using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Components;
using BUS;
using System.Resources;
using System.Globalization;
using WinFormsApp2.KhoPage;

namespace WinFormsApp2
{
    public partial class SignInForm : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public SignInForm()
        {
            InitializeComponent();
            SetLanguage("en-US");
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }


       

        private void roundedButton1_MouseHover(object sender, EventArgs e)
        {
            btn_Login.Cursor = Cursors.Hand;
        }

        private void SignInForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_signUpForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
            this.Close();
        }

        private void roundedTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomepageFormSingle homepageFormSingle = new HomepageFormSingle("0");
            homepageFormSingle.ShowDialog();
            this.Close();
        }

        private void lbl_errorMessage_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            BUS.Customer customer=new BUS.Customer();
            Dictionary<string, string> resultlist= new Dictionary<string, string>();
            resultlist= customer.returnResultLogin(this.tb_Phone.Texts.ToString(), this.tb_Password.Texts.ToString());
            String result = resultlist["result"];
            if (this.tb_Phone!=null & this.tb_Password != null) 
            {
                if (result == "1")
                {
                    SessionStorage.CustomerIDInUse = resultlist["id"];
                    this.Hide();
                    HomepageFormSingle HomepageFormSingle = new HomepageFormSingle("0");
                    HomepageFormSingle.ShowDialog();
                    this.Close();
                 
                }
                else
                {
                    if(result == "0") {
                        lbl_errorMessage.Text = "Sai tài khoản và mật khẩu";
                    }
                    if (result == "-1")
                    {
                        lbl_errorMessage.Text = "Vui lòng nhập số điện thoại";
                        tb_Phone.Focus();
                    }
                    if(result == "-2") {
                        lbl_errorMessage.Text = "Vui lòng nhập mật khẩu";
                        tb_Password.Focus();
                    }
                    if(result == "-3"){
                        lbl_errorMessage.Text = "Số điện thoại không hợp lệ";
                        tb_Phone.Focus();
                    }
                }
            }
            
        }

        public void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("GUI.Language.MyResource",
                             typeof(HangHoaTrongKho).Assembly);
            btn_Login.Text = rm.GetString("loginText", culture);
            btn_LoginForm.Text = rm.GetString("loginText", culture);
            btn_LoginGuest.Text = rm.GetString("loginGuestText", culture);
            tb_Phone.PlaceholderText = rm.GetString("phoneText", culture);
            tb_Password.PlaceholderText= rm.GetString("passwordText", culture);
            btn_SignupForm.Text = rm.GetString("signupText", culture);
            lbl_Login.Text = rm.GetString("loginText", culture);
        }

        private void btn_SignupForm_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
            this.Close();
        }
    }
}
