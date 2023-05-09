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
            this.lbl_Signup = new System.Windows.Forms.Label();
            this.btn_Signup = new WinFormsApp2.CustomControls.RoundedButton();
            this.tb_FullName = new WinFormsApp2.CustomControls.RoundedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_Email = new WinFormsApp2.CustomControls.RoundedTextBox();
            this.tb_Phone = new WinFormsApp2.CustomControls.RoundedTextBox();
            this.tb_Password = new WinFormsApp2.CustomControls.RoundedTextBox();
            this.btn_LoginForm = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_SignupForm = new WinFormsApp2.CustomControls.RoundedButton();
            this.lbl_errorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Signup
            // 
            this.lbl_Signup.AutoSize = true;
            this.lbl_Signup.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.lbl_Signup.Location = new System.Drawing.Point(421, 115);
            this.lbl_Signup.Name = "lbl_Signup";
            this.lbl_Signup.Size = new System.Drawing.Size(155, 49);
            this.lbl_Signup.TabIndex = 4;
            this.lbl_Signup.Text = "Đăng ký";
            // 
            // btn_Signup
            // 
            this.btn_Signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Signup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Signup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Signup.BorderRadius = 28;
            this.btn_Signup.BorderSize = 0;
            this.btn_Signup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Signup.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Signup.ForeColor = System.Drawing.Color.White;
            this.btn_Signup.Location = new System.Drawing.Point(434, 449);
            this.btn_Signup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Signup.Name = "btn_Signup";
            this.btn_Signup.Size = new System.Drawing.Size(132, 55);
            this.btn_Signup.TabIndex = 11;
            this.btn_Signup.Text = "Đăng ký";
            this.btn_Signup.TextColor = System.Drawing.Color.White;
            this.btn_Signup.UseVisualStyleBackColor = false;
            this.btn_Signup.Click += new System.EventHandler(this.btn_Signup_Click);
            // 
            // tb_FullName
            // 
            this.tb_FullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tb_FullName.BorderColor = System.Drawing.Color.Transparent;
            this.tb_FullName.BorderFocusColor = System.Drawing.Color.Transparent;
            this.tb_FullName.BorderRadius = 20;
            this.tb_FullName.BorderSize = 2;
            this.tb_FullName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_FullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_FullName.Location = new System.Drawing.Point(325, 196);
            this.tb_FullName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_FullName.Multiline = false;
            this.tb_FullName.Name = "tb_FullName";
            this.tb_FullName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_FullName.PasswordChar = false;
            this.tb_FullName.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.tb_FullName.PlaceholderText = "Họ và tên";
            this.tb_FullName.Size = new System.Drawing.Size(349, 43);
            this.tb_FullName.TabIndex = 12;
            this.tb_FullName.Texts = "";
            this.tb_FullName.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 107);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tb_Email
            // 
            this.tb_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tb_Email.BorderColor = System.Drawing.Color.Transparent;
            this.tb_Email.BorderFocusColor = System.Drawing.Color.Transparent;
            this.tb_Email.BorderRadius = 20;
            this.tb_Email.BorderSize = 2;
            this.tb_Email.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Email.Location = new System.Drawing.Point(325, 261);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Email.Multiline = false;
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Email.PasswordChar = false;
            this.tb_Email.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.tb_Email.PlaceholderText = "Địa chỉ email";
            this.tb_Email.Size = new System.Drawing.Size(349, 43);
            this.tb_Email.TabIndex = 14;
            this.tb_Email.Texts = "";
            this.tb_Email.UnderlinedStyle = false;
            // 
            // tb_Phone
            // 
            this.tb_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tb_Phone.BorderColor = System.Drawing.Color.Transparent;
            this.tb_Phone.BorderFocusColor = System.Drawing.Color.Transparent;
            this.tb_Phone.BorderRadius = 20;
            this.tb_Phone.BorderSize = 2;
            this.tb_Phone.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Phone.Location = new System.Drawing.Point(325, 326);
            this.tb_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Phone.Multiline = false;
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Phone.PasswordChar = false;
            this.tb_Phone.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.tb_Phone.PlaceholderText = "Số điện thoại";
            this.tb_Phone.Size = new System.Drawing.Size(349, 43);
            this.tb_Phone.TabIndex = 15;
            this.tb_Phone.Texts = "";
            this.tb_Phone.UnderlinedStyle = false;
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tb_Password.BorderColor = System.Drawing.Color.Transparent;
            this.tb_Password.BorderFocusColor = System.Drawing.Color.Transparent;
            this.tb_Password.BorderRadius = 20;
            this.tb_Password.BorderSize = 2;
            this.tb_Password.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Password.Location = new System.Drawing.Point(325, 389);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Password.Multiline = false;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Password.PasswordChar = true;
            this.tb_Password.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.tb_Password.PlaceholderText = "Mật khẩu";
            this.tb_Password.Size = new System.Drawing.Size(349, 43);
            this.tb_Password.TabIndex = 16;
            this.tb_Password.Texts = "";
            this.tb_Password.UnderlinedStyle = false;
            // 
            // btn_LoginForm
            // 
            this.btn_LoginForm.BackColor = System.Drawing.Color.White;
            this.btn_LoginForm.BackgroundColor = System.Drawing.Color.White;
            this.btn_LoginForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btn_LoginForm.BorderRadius = 8;
            this.btn_LoginForm.BorderSize = 1;
            this.btn_LoginForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_LoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoginForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_LoginForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btn_LoginForm.Location = new System.Drawing.Point(747, 34);
            this.btn_LoginForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LoginForm.Name = "btn_LoginForm";
            this.btn_LoginForm.Size = new System.Drawing.Size(117, 35);
            this.btn_LoginForm.TabIndex = 17;
            this.btn_LoginForm.Text = "Đăng nhập";
            this.btn_LoginForm.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btn_LoginForm.UseVisualStyleBackColor = false;
            this.btn_LoginForm.Click += new System.EventHandler(this.btn_signInForm_Click);
            // 
            // btn_SignupForm
            // 
            this.btn_SignupForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_SignupForm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_SignupForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btn_SignupForm.BorderRadius = 8;
            this.btn_SignupForm.BorderSize = 1;
            this.btn_SignupForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_SignupForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignupForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SignupForm.ForeColor = System.Drawing.Color.White;
            this.btn_SignupForm.Location = new System.Drawing.Point(873, 34);
            this.btn_SignupForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SignupForm.Name = "btn_SignupForm";
            this.btn_SignupForm.Size = new System.Drawing.Size(117, 35);
            this.btn_SignupForm.TabIndex = 18;
            this.btn_SignupForm.Text = "Đăng ký";
            this.btn_SignupForm.TextColor = System.Drawing.Color.White;
            this.btn_SignupForm.UseVisualStyleBackColor = false;
            // 
            // lbl_errorMessage
            // 
            this.lbl_errorMessage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.lbl_errorMessage.Location = new System.Drawing.Point(325, 164);
            this.lbl_errorMessage.Name = "lbl_errorMessage";
            this.lbl_errorMessage.Size = new System.Drawing.Size(349, 30);
            this.lbl_errorMessage.TabIndex = 19;
            this.lbl_errorMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 521);
            this.Controls.Add(this.lbl_errorMessage);
            this.Controls.Add(this.btn_SignupForm);
            this.Controls.Add(this.btn_LoginForm);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_FullName);
            this.Controls.Add(this.btn_Signup);
            this.Controls.Add(this.lbl_Signup);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SignUpForm";
            this.Padding = new System.Windows.Forms.Padding(16, 80, 16, 20);
            this.Style = MetroFramework.MetroColorStyle.White;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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