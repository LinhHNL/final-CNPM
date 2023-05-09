using WinFormsApp2.CustomControls;

namespace WinFormsApp2
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            lbl_Signup = new Label();
            btn_Signup = new RoundedButton();
            tb_FullName = new RoundedTextBox();
            pictureBox1 = new PictureBox();
            tb_Email = new RoundedTextBox();
            tb_Phone = new RoundedTextBox();
            tb_Password = new RoundedTextBox();
            btn_LoginForm = new RoundedButton();
            btn_SignupForm = new RoundedButton();
            lbl_errorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Signup
            // 
            lbl_Signup.AutoSize = true;
            lbl_Signup.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Signup.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_Signup.Location = new Point(421, 115);
            lbl_Signup.Name = "lbl_Signup";
            lbl_Signup.Size = new Size(155, 49);
            lbl_Signup.TabIndex = 4;
            lbl_Signup.Text = "Đăng ký";
            // 
            // btn_Signup
            // 
            btn_Signup.BackColor = Color.FromArgb(229, 1, 17);
            btn_Signup.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_Signup.BorderColor = Color.PaleVioletRed;
            btn_Signup.BorderRadius = 28;
            btn_Signup.BorderSize = 0;
            btn_Signup.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_Signup.FlatStyle = FlatStyle.Flat;
            btn_Signup.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Signup.ForeColor = Color.White;
            btn_Signup.Location = new Point(434, 449);
            btn_Signup.Margin = new Padding(3, 4, 3, 4);
            btn_Signup.Name = "btn_Signup";
            btn_Signup.Size = new Size(132, 55);
            btn_Signup.TabIndex = 11;
            btn_Signup.Text = "Đăng ký";
            btn_Signup.TextColor = Color.White;
            btn_Signup.UseVisualStyleBackColor = false;
            btn_Signup.Click += btn_Signup_Click;
            // 
            // tb_FullName
            // 
            tb_FullName.BackColor = Color.FromArgb(233, 236, 239);
            tb_FullName.BorderColor = Color.Transparent;
            tb_FullName.BorderFocusColor = Color.Transparent;
            tb_FullName.BorderRadius = 20;
            tb_FullName.BorderSize = 2;
            tb_FullName.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_FullName.ForeColor = Color.FromArgb(64, 64, 64);
            tb_FullName.Location = new Point(325, 196);
            tb_FullName.Margin = new Padding(4);
            tb_FullName.Multiline = false;
            tb_FullName.Name = "tb_FullName";
            tb_FullName.Padding = new Padding(10, 7, 10, 7);
            tb_FullName.PasswordChar = false;
            tb_FullName.PlaceholderColor = Color.FromArgb(108, 117, 125);
            tb_FullName.PlaceholderText = "Họ và tên";
            tb_FullName.Size = new Size(349, 43);
            tb_FullName.TabIndex = 12;
            tb_FullName.Texts = "";
            tb_FullName.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(450, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 107);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // tb_Email
            // 
            tb_Email.BackColor = Color.FromArgb(233, 236, 239);
            tb_Email.BorderColor = Color.Transparent;
            tb_Email.BorderFocusColor = Color.Transparent;
            tb_Email.BorderRadius = 20;
            tb_Email.BorderSize = 2;
            tb_Email.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Email.ForeColor = Color.FromArgb(64, 64, 64);
            tb_Email.Location = new Point(325, 261);
            tb_Email.Margin = new Padding(4);
            tb_Email.Multiline = false;
            tb_Email.Name = "tb_Email";
            tb_Email.Padding = new Padding(10, 7, 10, 7);
            tb_Email.PasswordChar = false;
            tb_Email.PlaceholderColor = Color.FromArgb(108, 117, 125);
            tb_Email.PlaceholderText = "Địa chỉ email";
            tb_Email.Size = new Size(349, 43);
            tb_Email.TabIndex = 14;
            tb_Email.Texts = "";
            tb_Email.UnderlinedStyle = false;
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
            tb_Phone.Location = new Point(325, 326);
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
            tb_Password.Location = new Point(325, 389);
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
            btn_LoginForm.BackColor = Color.White;
            btn_LoginForm.BackgroundColor = Color.White;
            btn_LoginForm.BorderColor = Color.FromArgb(108, 117, 125);
            btn_LoginForm.BorderRadius = 8;
            btn_LoginForm.BorderSize = 1;
            btn_LoginForm.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_LoginForm.FlatStyle = FlatStyle.Flat;
            btn_LoginForm.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_LoginForm.ForeColor = Color.FromArgb(108, 117, 125);
            btn_LoginForm.Location = new Point(747, 34);
            btn_LoginForm.Margin = new Padding(3, 4, 3, 4);
            btn_LoginForm.Name = "btn_LoginForm";
            btn_LoginForm.Size = new Size(117, 35);
            btn_LoginForm.TabIndex = 17;
            btn_LoginForm.Text = "Đăng nhập";
            btn_LoginForm.TextColor = Color.FromArgb(108, 117, 125);
            btn_LoginForm.UseVisualStyleBackColor = false;
            btn_LoginForm.Click += btn_signInForm_Click;
            // 
            // btn_SignupForm
            // 
            btn_SignupForm.BackColor = Color.FromArgb(229, 1, 17);
            btn_SignupForm.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_SignupForm.BorderColor = Color.FromArgb(108, 117, 125);
            btn_SignupForm.BorderRadius = 8;
            btn_SignupForm.BorderSize = 1;
            btn_SignupForm.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_SignupForm.FlatStyle = FlatStyle.Flat;
            btn_SignupForm.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_SignupForm.ForeColor = Color.White;
            btn_SignupForm.Location = new Point(873, 34);
            btn_SignupForm.Margin = new Padding(3, 4, 3, 4);
            btn_SignupForm.Name = "btn_SignupForm";
            btn_SignupForm.Size = new Size(117, 35);
            btn_SignupForm.TabIndex = 18;
            btn_SignupForm.Text = "Đăng ký";
            btn_SignupForm.TextColor = Color.White;
            btn_SignupForm.UseVisualStyleBackColor = false;
            // 
            // lbl_errorMessage
            // 
            lbl_errorMessage.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_errorMessage.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_errorMessage.Location = new Point(325, 164);
            lbl_errorMessage.Name = "lbl_errorMessage";
            lbl_errorMessage.Size = new Size(349, 30);
            lbl_errorMessage.TabIndex = 19;
            lbl_errorMessage.TextAlign = ContentAlignment.TopCenter;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 521);
            Controls.Add(lbl_errorMessage);
            Controls.Add(btn_SignupForm);
            Controls.Add(btn_LoginForm);
            Controls.Add(tb_Password);
            Controls.Add(tb_Phone);
            Controls.Add(tb_Email);
            Controls.Add(pictureBox1);
            Controls.Add(tb_FullName);
            Controls.Add(btn_Signup);
            Controls.Add(lbl_Signup);
            Margin = new Padding(2, 3, 2, 3);
            Name = "SignUpForm";
            Padding = new Padding(16, 80, 16, 20);
            Style = MetroFramework.MetroColorStyle.White;
            Load += SignUpForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Signup;
        private RoundedButton btn_Signup;
        private RoundedTextBox tb_FullName;
        private PictureBox pictureBox1;
        private RoundedTextBox tb_Email;
        private RoundedTextBox tb_Phone;
        private RoundedTextBox tb_Password;
        private RoundedButton btn_LoginForm;
        private RoundedButton btn_SignupForm;
        private Label lbl_errorMessage;
    }
}