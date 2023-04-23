

using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void metroSetTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void myTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                MessageBox.Show("Đăng ký thành công");
            }

        }

        private bool validateData()
        {
            String firstName = tb_firstName.Text.Trim();
            String lastName = tb_lastName.Text.Trim();
            String email = tb_email.Text.Trim();
            String phone = tb_phone.Text.Trim();
            String password = tb_password.Text;
            String passwordConfirm = tb_passwordCofirm.Text;
            Regex rgEmail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", RegexOptions.IgnoreCase);



            if (firstName.Equals("") || lastName.Equals("") || email.Equals("") || phone.Equals("") || password.Equals("") || passwordConfirm.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }

            if (!rgEmail.IsMatch(email))
            {
                MessageBox.Show("Email không hợp lệ");
                return false;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu có độ dài từ 6 kí tự");
                return false;
            }

            if (!IsDigitsOnly(phone) || phone.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return false;
            }

            if (!password.Equals(passwordConfirm))
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp");
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

        private void tile_signIn_Click(object sender, EventArgs e)
        {

        }

        private void tile_signUp_Click(object sender, EventArgs e)
        {

        }
    }
}