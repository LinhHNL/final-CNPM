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
            this.lbl_Login = new System.Windows.Forms.Label();
            this.btn_Login = new WinFormsApp2.CustomControls.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_Phone = new WinFormsApp2.CustomControls.RoundedTextBox();
            this.tb_Password = new WinFormsApp2.CustomControls.RoundedTextBox();
            this.btn_LoginForm = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_SignupForm = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_LoginGuest = new WinFormsApp2.CustomControls.RoundedButton();
            this.lbl_errorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.lbl_Login.Location = new System.Drawing.Point(325, 106);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(349, 49);
            this.lbl_Login.TabIndex = 4;
            this.lbl_Login.Text = "Đăng nhập";
            this.lbl_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Login.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Login.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Login.BorderRadius = 28;
            this.btn_Login.BorderSize = 0;
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(428, 328);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(152, 54);
            this.btn_Login.TabIndex = 11;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.TextColor = System.Drawing.Color.White;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(449, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 107);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
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
            this.tb_Phone.Location = new System.Drawing.Point(325, 176);
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
            this.tb_Password.Location = new System.Drawing.Point(325, 247);
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
            this.btn_LoginForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_LoginForm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_LoginForm.BorderColor = System.Drawing.Color.White;
            this.btn_LoginForm.BorderRadius = 8;
            this.btn_LoginForm.BorderSize = 1;
            this.btn_LoginForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_LoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoginForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_LoginForm.ForeColor = System.Drawing.Color.White;
            this.btn_LoginForm.Location = new System.Drawing.Point(747, 34);
            this.btn_LoginForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LoginForm.Name = "btn_LoginForm";
            this.btn_LoginForm.Size = new System.Drawing.Size(117, 35);
            this.btn_LoginForm.TabIndex = 17;
            this.btn_LoginForm.Text = "Đăng nhập";
            this.btn_LoginForm.TextColor = System.Drawing.Color.White;
            this.btn_LoginForm.UseVisualStyleBackColor = false;
            // 
            // btn_SignupForm
            // 
            this.btn_SignupForm.BackColor = System.Drawing.Color.White;
            this.btn_SignupForm.BackgroundColor = System.Drawing.Color.White;
            this.btn_SignupForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btn_SignupForm.BorderRadius = 8;
            this.btn_SignupForm.BorderSize = 1;
            this.btn_SignupForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_SignupForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignupForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SignupForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btn_SignupForm.Location = new System.Drawing.Point(873, 34);
            this.btn_SignupForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SignupForm.Name = "btn_SignupForm";
            this.btn_SignupForm.Size = new System.Drawing.Size(117, 35);
            this.btn_SignupForm.TabIndex = 18;
            this.btn_SignupForm.Text = "Đăng ký";
            this.btn_SignupForm.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btn_SignupForm.UseVisualStyleBackColor = false;
            this.btn_SignupForm.Click += new System.EventHandler(this.btn_SignupForm_Click_1);
            // 
            // btn_LoginGuest
            // 
            this.btn_LoginGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_LoginGuest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_LoginGuest.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_LoginGuest.BorderRadius = 28;
            this.btn_LoginGuest.BorderSize = 0;
            this.btn_LoginGuest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_LoginGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoginGuest.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_LoginGuest.ForeColor = System.Drawing.Color.White;
            this.btn_LoginGuest.Location = new System.Drawing.Point(398, 399);
            this.btn_LoginGuest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LoginGuest.Name = "btn_LoginGuest";
            this.btn_LoginGuest.Size = new System.Drawing.Size(214, 51);
            this.btn_LoginGuest.TabIndex = 19;
            this.btn_LoginGuest.Text = "Đăng nhập khách";
            this.btn_LoginGuest.TextColor = System.Drawing.Color.White;
            this.btn_LoginGuest.UseVisualStyleBackColor = false;
            // 
            // lbl_errorMessage
            // 
            this.lbl_errorMessage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.lbl_errorMessage.Location = new System.Drawing.Point(325, 294);
            this.lbl_errorMessage.Name = "lbl_errorMessage";
            this.lbl_errorMessage.Size = new System.Drawing.Size(349, 30);
            this.lbl_errorMessage.TabIndex = 20;
            this.lbl_errorMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 464);
            this.Controls.Add(this.lbl_errorMessage);
            this.Controls.Add(this.btn_LoginGuest);
            this.Controls.Add(this.btn_SignupForm);
            this.Controls.Add(this.btn_LoginForm);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Login);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SignInForm";
            this.Padding = new System.Windows.Forms.Padding(16, 80, 16, 20);
            this.Style = MetroFramework.MetroColorStyle.White;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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