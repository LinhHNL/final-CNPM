using WinFormsApp2.CustomControls;

namespace WinFormsApp2
{
    partial class SignInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            lbl_Login = new Label();
            btn_Login = new RoundedButton();
            pictureBox1 = new PictureBox();
            tb_Phone = new RoundedTextBox();
            tb_Password = new RoundedTextBox();
            btn_LoginForm = new RoundedButton();
            btn_SignupForm = new RoundedButton();
            btn_LoginGuest = new RoundedButton();
            lbl_errorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Login
            // 
            lbl_Login.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Login.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_Login.Location = new Point(325, 106);
            lbl_Login.Name = "lbl_Login";
            lbl_Login.Size = new Size(349, 49);
            lbl_Login.TabIndex = 4;
            lbl_Login.Text = "Đăng nhập";
            lbl_Login.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(229, 1, 17);
            btn_Login.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_Login.BorderColor = Color.PaleVioletRed;
            btn_Login.BorderRadius = 28;
            btn_Login.BorderSize = 0;
            btn_Login.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(428, 328);
            btn_Login.Margin = new Padding(3, 4, 3, 4);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(152, 54);
            btn_Login.TabIndex = 11;
            btn_Login.Text = "Đăng nhập";
            btn_Login.TextColor = Color.White;
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(449, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 107);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // tb_Phone
            // 
            tb_Phone.BackColor = Color.FromArgb(233, 236, 239);
            tb_Phone.BorderColor = Color.Transparent;
            tb_Phone.BorderFocusColor = Color.Transparent;
            tb_Phone.BorderRadius = 20;
            tb_Phone.BorderSize = 2;
            tb_Phone.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Phone.ForeColor = Color.FromArgb(64, 64, 64);
            tb_Phone.Location = new Point(325, 176);
            tb_Phone.Margin = new Padding(4);
            tb_Phone.Multiline = false;
            tb_Phone.Name = "tb_Phone";
            tb_Phone.Padding = new Padding(10, 7, 10, 7);
            tb_Phone.PasswordChar = false;
            tb_Phone.PlaceholderColor = Color.FromArgb(108, 117, 125);
            tb_Phone.PlaceholderText = "Số điện thoại";
            tb_Phone.Size = new Size(349, 43);
            tb_Phone.TabIndex = 15;
            tb_Phone.Texts = "";
            tb_Phone.UnderlinedStyle = false;
            // 
            // tb_Password
            // 
            tb_Password.BackColor = Color.FromArgb(233, 236, 239);
            tb_Password.BorderColor = Color.Transparent;
            tb_Password.BorderFocusColor = Color.Transparent;
            tb_Password.BorderRadius = 20;
            tb_Password.BorderSize = 2;
            tb_Password.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Password.ForeColor = Color.FromArgb(64, 64, 64);
            tb_Password.Location = new Point(325, 247);
            tb_Password.Margin = new Padding(4);
            tb_Password.Multiline = false;
            tb_Password.Name = "tb_Password";
            tb_Password.Padding = new Padding(10, 7, 10, 7);
            tb_Password.PasswordChar = true;
            tb_Password.PlaceholderColor = Color.FromArgb(108, 117, 125);
            tb_Password.PlaceholderText = "Mật khẩu";
            tb_Password.Size = new Size(349, 43);
            tb_Password.TabIndex = 16;
            tb_Password.Texts = "";
            tb_Password.UnderlinedStyle = false;
            // 
            // btn_LoginForm
            // 
            btn_LoginForm.BackColor = Color.FromArgb(229, 1, 17);
            btn_LoginForm.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_LoginForm.BorderColor = Color.White;
            btn_LoginForm.BorderRadius = 8;
            btn_LoginForm.BorderSize = 1;
            btn_LoginForm.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_LoginForm.FlatStyle = FlatStyle.Flat;
            btn_LoginForm.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_LoginForm.ForeColor = Color.White;
            btn_LoginForm.Location = new Point(747, 34);
            btn_LoginForm.Margin = new Padding(3, 4, 3, 4);
            btn_LoginForm.Name = "btn_LoginForm";
            btn_LoginForm.Size = new Size(117, 35);
            btn_LoginForm.TabIndex = 17;
            btn_LoginForm.Text = "Đăng nhập";
            btn_LoginForm.TextColor = Color.White;
            btn_LoginForm.UseVisualStyleBackColor = false;
            // 
            // btn_SignupForm
            // 
            btn_SignupForm.BackColor = Color.White;
            btn_SignupForm.BackgroundColor = Color.White;
            btn_SignupForm.BorderColor = Color.FromArgb(108, 117, 125);
            btn_SignupForm.BorderRadius = 8;
            btn_SignupForm.BorderSize = 1;
            btn_SignupForm.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_SignupForm.FlatStyle = FlatStyle.Flat;
            btn_SignupForm.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_SignupForm.ForeColor = Color.FromArgb(108, 117, 125);
            btn_SignupForm.Location = new Point(873, 34);
            btn_SignupForm.Margin = new Padding(3, 4, 3, 4);
            btn_SignupForm.Name = "btn_SignupForm";
            btn_SignupForm.Size = new Size(117, 35);
            btn_SignupForm.TabIndex = 18;
            btn_SignupForm.Text = "Đăng ký";
            btn_SignupForm.TextColor = Color.FromArgb(108, 117, 125);
            btn_SignupForm.UseVisualStyleBackColor = false;
            btn_SignupForm.Click += btn_SignupForm_Click_1;
            // 
            // btn_LoginGuest
            // 
            btn_LoginGuest.BackColor = Color.FromArgb(229, 1, 17);
            btn_LoginGuest.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_LoginGuest.BorderColor = Color.PaleVioletRed;
            btn_LoginGuest.BorderRadius = 28;
            btn_LoginGuest.BorderSize = 0;
            btn_LoginGuest.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_LoginGuest.FlatStyle = FlatStyle.Flat;
            btn_LoginGuest.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_LoginGuest.ForeColor = Color.White;
            btn_LoginGuest.Location = new Point(398, 399);
            btn_LoginGuest.Margin = new Padding(3, 4, 3, 4);
            btn_LoginGuest.Name = "btn_LoginGuest";
            btn_LoginGuest.Size = new Size(214, 51);
            btn_LoginGuest.TabIndex = 19;
            btn_LoginGuest.Text = "Đăng nhập khách";
            btn_LoginGuest.TextColor = Color.White;
            btn_LoginGuest.UseVisualStyleBackColor = false;
            btn_LoginGuest.Click += btn_LoginGuest_Click;
            // 
            // lbl_errorMessage
            // 
            lbl_errorMessage.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_errorMessage.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_errorMessage.Location = new Point(325, 294);
            lbl_errorMessage.Name = "lbl_errorMessage";
            lbl_errorMessage.Size = new Size(349, 30);
            lbl_errorMessage.TabIndex = 20;
            lbl_errorMessage.TextAlign = ContentAlignment.TopCenter;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 464);
            Controls.Add(lbl_errorMessage);
            Controls.Add(btn_LoginGuest);
            Controls.Add(btn_SignupForm);
            Controls.Add(btn_LoginForm);
            Controls.Add(tb_Password);
            Controls.Add(tb_Phone);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Login);
            Controls.Add(lbl_Login);
            Margin = new Padding(2, 3, 2, 3);
            Name = "SignInForm";
            Padding = new Padding(16, 80, 16, 20);
            Style = MetroFramework.MetroColorStyle.White;
            Load += SignInForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_Login;
        private RoundedButton btn_Login;
        private PictureBox pictureBox1;
        private RoundedTextBox tb_Phone;
        private RoundedTextBox tb_Password;
        private RoundedButton btn_LoginForm;
        private RoundedButton btn_SignupForm;
        private RoundedButton btn_LoginGuest;
        private Label lbl_errorMessage;
    }

}