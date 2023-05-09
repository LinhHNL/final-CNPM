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
namespace WinFormsApp2
{
    public partial class SignInForm : MetroFramework.Forms.MetroForm
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }


       

        private void roundedButton1_MouseHover(object sender, EventArgs e)
        {
            btn_login.Cursor = Cursors.Hand;
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
            resultlist= customer.returnResultLogin(this.tb_phone.Texts.ToString(), this.tb_password.Texts.ToString());
            String result = resultlist["result"];
            if (this.tb_phone!=null & this.tb_password != null) 
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
                        tb_phone.Focus();
                    }
                    if(result == "-2") {
                        lbl_errorMessage.Text = "Vui lòng nhập mật khẩu";
                        tb_password.Focus();
                    }
                    if(result == "-3"){
                        lbl_errorMessage.Text = "Số điện thoại không hợp lệ";
                        tb_phone.Focus();
                    }
                }
            }
            
        }
    }
}
