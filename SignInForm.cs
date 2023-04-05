﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.DataAccess;

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


        private bool validateData()
        {
            String phone = tb_phone.Texts.Trim();
            String password = tb_password.Texts;

            if (phone.Equals(""))
            {
                lbl_errorMessage.Text = "Vui lòng nhập số điện thoại";
                tb_phone.Focus();
                return false;
            }

            if (password.Equals(""))
            {
                lbl_errorMessage.Text = "Vui lòng nhập mật khẩu";
                tb_password.Focus();
                return false;
            }

            if (!IsDigitsOnly(phone) || phone.Length != 10)
            {
                lbl_errorMessage.Text = "Số điện thoại không hợp lệ";
                tb_phone.Focus();
                return false;
            }

            return true;
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
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
            HomepageFormSingle homepageFormSingle = new HomepageFormSingle();
            homepageFormSingle.ShowDialog();
            this.Close();
        }

        private void lbl_errorMessage_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            TakingValidateProc resultlogin=new TakingValidateProc();
            Dictionary<string, string> resultlist= new Dictionary<string, string>();
            resultlist=resultlogin.TakingValidateProcFuncUsing(this.tb_phone.ToString(), this.tb_password.ToString());
            String result = resultlist["result"];
            if (this.tb_phone!=null & this.tb_password != null)
            {
                if (result == "0")
                {
                    lbl_errorMessage.Text = "Sai Tài Khoản và Mật Khẩu";
                }
                else
                {
                    this.Hide();
                    HomepageFormSingle HomepageFormSingle = new HomepageFormSingle();
                    HomepageFormSingle.ShowDialog();
                    this.Close();
                }
            }
            
        }
    }
}
