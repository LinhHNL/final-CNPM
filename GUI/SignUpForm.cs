

using System.Text.RegularExpressions;
using WinFormsApp2.Components;
using BUS;
namespace WinFormsApp2
{
    public partial class SignUpForm : MetroFramework.Forms.MetroForm
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            BUS.Customer customer = new BUS.Customer();
            String name = tb_name.Texts.Trim();
            String email = tb_email.Texts.Trim();
            String phone = tb_phone.Texts.Trim();
            String password = tb_password.Texts;
            
            Dictionary<string, string> resultlist = new Dictionary<string, string>();
            resultlist = customer.returnResultRegister(phone, password, name, email);
            String result = resultlist["result"];
            if (this.tb_phone != null & this.tb_password != null)
            {
                if (result == "1")
                {
                    BUS.SessionStorage.CustomerIDInUse = resultlist["id"];
                    this.Hide();
                    HomepageFormSingle HomepageFormSingle = new HomepageFormSingle();
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
                        tb_name.Focus();
                    }
                    if (result == "-2")
                    {
                        lbl_errorMessage.Text = "Vui lòng nhập địa chỉ email";
                        tb_email.Focus();
                    }
                    if (result == "-3")
                    {
                        lbl_errorMessage.Text = "Vui lòng nhập số điện thoại";
                        tb_phone.Focus();
                    }
                    if (result == "-4")
                    {
                        lbl_errorMessage.Text = "Vui lòng nhập mật khẩu";
                        tb_password.Focus();
                    }
                    if (result == "-5")
                    {
                        lbl_errorMessage.Text = "Email không hợp lệ";
                        tb_email.Focus();
                    }
                    if (result == "-6")
                    {
                        lbl_errorMessage.Text = "Vui lòng nhập mật khẩu có độ dài từ 8 kí tự";
                        tb_password.Focus();
                    }
                    if (result == "-7")
                    {
                        lbl_errorMessage.Text = "Số điện thoại không hợp lệ";
                        tb_phone.Focus();
                    }
                }
            }
        }

        

        

        private void roundedButton1_MouseHover(object sender, EventArgs e)
        {
            btn_signUp.Cursor = Cursors.Hand;
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
    }
}