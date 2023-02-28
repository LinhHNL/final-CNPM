

namespace WinFormsApp1
{
    public partial class Form1 :  MetroFramework.Forms.MetroForm
    {
        public Form1()
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

        private void roundedButton1_MouseHover(object sender, EventArgs e)
        {
            btn_signUp.Cursor = Cursors.Hand;
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            String tmp = tb_firstName.Text;
            if (tmp == "")
            {
                MessageBox.Show("Vui long nhap so dien thoai");
                return;
            }
            if (tb_password.Text == "")
            {
                MessageBox.Show("Vui long nhap mat khau");
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_firstName_Click(object sender, EventArgs e)
        {
        }

        private void btn_signupchange_Click(object sender, EventArgs e)
        {
            
        }
    }
}