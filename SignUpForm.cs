

using System.Text.RegularExpressions;

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
            if (validateData())
            {
                lbl_errorMessage.Text = "Đăng ký thành công";
            }

        }

        private bool validateData()
        {
            String name = tb_name.Texts.Trim();
            String email = tb_email.Texts.Trim();
            String phone = tb_phone.Texts.Trim();
            String password = tb_password.Texts;
            Regex rgEmail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", RegexOptions.IgnoreCase);


            if (name.Equals(""))
            {
                lbl_errorMessage.Text = "Vui lòng nhập họ và tên";
                tb_name.Focus();
                return false;
            }

            if (email.Equals(""))
            {
                lbl_errorMessage.Text = "Vui lòng nhập địa chỉ email";
                tb_email.Focus();
                return false;
            }

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

            if (!rgEmail.IsMatch(email))
            {
                lbl_errorMessage.Text = "Email không hợp lệ";
                tb_email.Focus();
                return false;
            }

            if (password.Length < 8)
            {
                lbl_errorMessage.Text = "Vui lòng nhập mật khẩu có độ dài từ 8 kí tự";
                tb_password.Focus();
                return false;
            }

            if (!IsDigitsOnly(phone))
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