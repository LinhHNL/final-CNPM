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
            label1 = new Label();
            btn_signUp = new RoundedButton();
            tb_name = new RoundedTextBox();
            pictureBox1 = new PictureBox();
            tb_email = new RoundedTextBox();
            tb_phone = new RoundedTextBox();
            tb_password = new RoundedTextBox();
            btn_signInForm = new RoundedButton();
            roundedButton2 = new RoundedButton();
            lbl_errorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(229, 1, 17);
            label1.Location = new Point(428, 117);
            label1.Name = "label1";
            label1.Size = new Size(155, 49);
            label1.TabIndex = 4;
            label1.Text = "Đăng ký";
            // 
            // btn_signUp
            // 
            btn_signUp.BackColor = Color.FromArgb(229, 1, 17);
            btn_signUp.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_signUp.BorderColor = Color.PaleVioletRed;
            btn_signUp.BorderRadius = 28;
            btn_signUp.BorderSize = 0;
            btn_signUp.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_signUp.FlatStyle = FlatStyle.Flat;
            btn_signUp.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_signUp.ForeColor = Color.White;
            btn_signUp.Location = new Point(434, 449);
            btn_signUp.Margin = new Padding(3, 4, 3, 4);
            btn_signUp.Name = "btn_signUp";
            btn_signUp.Size = new Size(132, 55);
            btn_signUp.TabIndex = 11;
            btn_signUp.Text = "Đăng ký";
            btn_signUp.TextColor = Color.White;
            btn_signUp.UseVisualStyleBackColor = false;
            btn_signUp.Click += roundedButton1_Click;
            btn_signUp.MouseHover += roundedButton1_MouseHover;
            // 
            // tb_name
            // 
            tb_name.BackColor = Color.FromArgb(233, 236, 239);
            tb_name.BorderColor = Color.Transparent;
            tb_name.BorderFocusColor = Color.Transparent;
            tb_name.BorderRadius = 20;
            tb_name.BorderSize = 2;
            tb_name.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_name.ForeColor = Color.FromArgb(64, 64, 64);
            tb_name.Location = new Point(325, 196);
            tb_name.Margin = new Padding(4);
            tb_name.Multiline = false;
            tb_name.Name = "tb_name";
            tb_name.Padding = new Padding(10, 7, 10, 7);
            tb_name.PasswordChar = false;
            tb_name.PlaceholderColor = Color.FromArgb(108, 117, 125);
            tb_name.PlaceholderText = "Họ và tên";
            tb_name.Size = new Size(349, 43);
            tb_name.TabIndex = 12;
            tb_name.Texts = "";
            tb_name.UnderlinedStyle = false;
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
            // tb_email
            // 
            tb_email.BackColor = Color.FromArgb(233, 236, 239);
            tb_email.BorderColor = Color.Transparent;
            tb_email.BorderFocusColor = Color.Transparent;
            tb_email.BorderRadius = 20;
            tb_email.BorderSize = 2;
            tb_email.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_email.ForeColor = Color.FromArgb(64, 64, 64);
            tb_email.Location = new Point(325, 261);
            tb_email.Margin = new Padding(4);
            tb_email.Multiline = false;
            tb_email.Name = "tb_email";
            tb_email.Padding = new Padding(10, 7, 10, 7);
            tb_email.PasswordChar = false;
            tb_email.PlaceholderColor = Color.FromArgb(108, 117, 125);
            tb_email.PlaceholderText = "Địa chỉ email";
            tb_email.Size = new Size(349, 43);
            tb_email.TabIndex = 14;
            tb_email.Texts = "";
            tb_email.UnderlinedStyle = false;
            // 
            // tb_phone
            // 
            tb_phone.BackColor = Color.FromArgb(233, 236, 239);
            tb_phone.BorderColor = Color.Transparent;
            tb_phone.BorderFocusColor = Color.Transparent;
            tb_phone.BorderRadius = 20;
            tb_phone.BorderSize = 2;
            tb_phone.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_phone.ForeColor = Color.FromArgb(64, 64, 64);
            tb_phone.Location = new Point(325, 326);
            tb_phone.Margin = new Padding(4);
            tb_phone.Multiline = false;
            tb_phone.Name = "tb_phone";
            tb_phone.Padding = new Padding(10, 7, 10, 7);
            tb_phone.PasswordChar = false;
            tb_phone.PlaceholderColor = Color.FromArgb(108, 117, 125);
            tb_phone.PlaceholderText = "Số điện thoại";
            tb_phone.Size = new Size(349, 43);
            tb_phone.TabIndex = 15;
            tb_phone.Texts = "";
            tb_phone.UnderlinedStyle = false;
            // 
            // tb_password
            // 
            tb_password.BackColor = Color.FromArgb(233, 236, 239);
            tb_password.BorderColor = Color.Transparent;
            tb_password.BorderFocusColor = Color.Transparent;
            tb_password.BorderRadius = 20;
            tb_password.BorderSize = 2;
            tb_password.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_password.ForeColor = Color.FromArgb(64, 64, 64);
            tb_password.Location = new Point(325, 389);
            tb_password.Margin = new Padding(4);
            tb_password.Multiline = false;
            tb_password.Name = "tb_password";
            tb_password.Padding = new Padding(10, 7, 10, 7);
            tb_password.PasswordChar = true;
            tb_password.PlaceholderColor = Color.FromArgb(108, 117, 125);
            tb_password.PlaceholderText = "Mật khẩu";
            tb_password.Size = new Size(349, 43);
            tb_password.TabIndex = 16;
            tb_password.Texts = "";
            tb_password.UnderlinedStyle = false;
            // 
            // btn_signInForm
            // 
            btn_signInForm.BackColor = Color.White;
            btn_signInForm.BackgroundColor = Color.White;
            btn_signInForm.BorderColor = Color.FromArgb(108, 117, 125);
            btn_signInForm.BorderRadius = 8;
            btn_signInForm.BorderSize = 1;
            btn_signInForm.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_signInForm.FlatStyle = FlatStyle.Flat;
            btn_signInForm.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_signInForm.ForeColor = Color.FromArgb(108, 117, 125);
            btn_signInForm.Location = new Point(747, 34);
            btn_signInForm.Margin = new Padding(3, 4, 3, 4);
            btn_signInForm.Name = "btn_signInForm";
            btn_signInForm.Size = new Size(117, 35);
            btn_signInForm.TabIndex = 17;
            btn_signInForm.Text = "Đăng nhập";
            btn_signInForm.TextColor = Color.FromArgb(108, 117, 125);
            btn_signInForm.UseVisualStyleBackColor = false;
            btn_signInForm.Click += btn_signInForm_Click;
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = Color.FromArgb(229, 1, 17);
            roundedButton2.BackgroundColor = Color.FromArgb(229, 1, 17);
            roundedButton2.BorderColor = Color.FromArgb(108, 117, 125);
            roundedButton2.BorderRadius = 8;
            roundedButton2.BorderSize = 1;
            roundedButton2.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton2.ForeColor = Color.White;
            roundedButton2.Location = new Point(873, 34);
            roundedButton2.Margin = new Padding(3, 4, 3, 4);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(117, 35);
            roundedButton2.TabIndex = 18;
            roundedButton2.Text = "Đăng ký";
            roundedButton2.TextColor = Color.White;
            roundedButton2.UseVisualStyleBackColor = false;
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
            Controls.Add(roundedButton2);
            Controls.Add(btn_signInForm);
            Controls.Add(tb_password);
            Controls.Add(tb_phone);
            Controls.Add(tb_email);
            Controls.Add(pictureBox1);
            Controls.Add(tb_name);
            Controls.Add(btn_signUp);
            Controls.Add(label1);
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
        private Label label1;
        private RoundedButton btn_signUp;
        private RoundedTextBox tb_name;
        private PictureBox pictureBox1;
        private RoundedTextBox tb_email;
        private RoundedTextBox tb_phone;
        private RoundedTextBox tb_password;
        private RoundedButton btn_signInForm;
        private RoundedButton roundedButton2;
        private Label lbl_errorMessage;
    }
}