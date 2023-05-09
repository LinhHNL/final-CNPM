

using System.Text.RegularExpressions;
using WinFormsApp2.Components;
using BUS;
using System.Resources;
using System.Globalization;
using WinFormsApp2.KhoPage;

namespace WinFormsApp2
{
    public partial class SignUpForm : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public SignUpForm()
        {
            InitializeComponent();
            SetLanguage("en-US");
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            BUS.Customer customer = new BUS.Customer();
            String name = tb_FullName.Texts.Trim();
            String email = tb_Email.Texts.Trim();
            String phone = tb_Phone.Texts.Trim();
            String password = tb_Password.Texts;
            
            Dictionary<string, string> resultlist = new Dictionary<string, string>();
            resultlist = customer.returnResultRegister(phone, password, name, email);
            String result = resultlist["result"];
            if (this.tb_Phone != null & this.tb_Password != null)
            {
                if (result == "1")
                {
                    BUS.SessionStorage.CustomerIDInUse = resultlist["id"];
                    this.Hide();
                    HomepageFormSingle HomepageFormSingle = new HomepageFormSingle("0");
                    HomepageFormSingle.ShowDialog();
                    this.Close();
                }
                else
                {
                    if (result == "0")
                    {
                        lbl_errorMessage.Text = "Khởi tạo tài khoản thất bại";
                    }
                    if (result == "-1")
                    {
                        lbl_errorMessage.Text = "Vui lòng nhập họ và tên";
                        tb_FullName.Focus();
                    }
                    if (result == "-2")
                    {
                        lbl_errorMessage.Text = "Vui lòng nhập địa chỉ email";
                        tb_Email.Focus();
                    }
                    if (result == "-3")
                    {
                        lbl_errorMessage.Text = "Vui lòng nhập số điện thoại";
                        tb_Phone.Focus();
                    }
                    if (result == "-4")
                    {
                        lbl_errorMessage.Text = "Vui lòng nhập mật khẩu";
                        tb_Password.Focus();
                    }
                    if (result == "-5")
                    {
                        lbl_errorMessage.Text = "Email không hợp lệ";
                        tb_Email.Focus();
                    }
                    if (result == "-6")
                    {
                        lbl_errorMessage.Text = "Vui lòng nhập mật khẩu có độ dài từ 8 kí tự";
                        tb_Password.Focus();
                    }
                    if (result == "-7")
                    {
                        lbl_errorMessage.Text = "Số điện thoại không hợp lệ";
                        tb_Phone.Focus();
                    }
                }
            }
        }

        

        

        private void roundedButton1_MouseHover(object sender, EventArgs e)
        {
            btn_Signup.Cursor = Cursors.Hand;
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_signInForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signInForm = new SignInForm();
            signInForm.ShowDialog();
            this.Close();
        }

        public void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("GUI.Language.MyResource",
                             typeof(HangHoaTrongKho).Assembly);
            btn_Signup.Text = rm.GetString("signupText", culture);
            btn_LoginForm.Text = rm.GetString("loginText", culture);
            tb_Phone.PlaceholderText = rm.GetString("phoneText", culture);
            tb_Password.PlaceholderText = rm.GetString("passwordText", culture);
            tb_Email.PlaceholderText = rm.GetString("emailText", culture);
            tb_FullName.PlaceholderText = rm.GetString("fullNameText", culture);
            btn_SignupForm.Text = rm.GetString("signupText", culture);
            btn_SignupForm.Text = rm.GetString("signupText", culture);
            lbl_Signup.Text = rm.GetString("signupText", culture);
        }
    }
}