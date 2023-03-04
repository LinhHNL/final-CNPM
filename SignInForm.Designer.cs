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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_signUp = new WinFormsApp2.CustomControls.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_phone = new WinFormsApp2.CustomControls.RoundedTextBox();
            this.tb_password = new WinFormsApp2.CustomControls.RoundedTextBox();
            this.roundedButton1 = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_signUpForm = new WinFormsApp2.CustomControls.RoundedButton();
            this.roundedButton2 = new WinFormsApp2.CustomControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(501, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đăng nhập";
            // 
            // btn_signUp
            // 
            this.btn_signUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_signUp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_signUp.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_signUp.BorderRadius = 28;
            this.btn_signUp.BorderSize = 0;
            this.btn_signUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signUp.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_signUp.ForeColor = System.Drawing.Color.White;
            this.btn_signUp.Location = new System.Drawing.Point(540, 424);
            this.btn_signUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(173, 52);
            this.btn_signUp.TabIndex = 11;
            this.btn_signUp.Text = "Đăng nhập";
            this.btn_signUp.TextColor = System.Drawing.Color.White;
            this.btn_signUp.UseVisualStyleBackColor = false;
            this.btn_signUp.Click += new System.EventHandler(this.roundedButton1_Click);
            this.btn_signUp.MouseHover += new System.EventHandler(this.roundedButton1_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(562, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 134);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tb_phone
            // 
            this.tb_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tb_phone.BorderColor = System.Drawing.Color.Transparent;
            this.tb_phone.BorderFocusColor = System.Drawing.Color.Transparent;
            this.tb_phone.BorderRadius = 20;
            this.tb_phone.BorderSize = 2;
            this.tb_phone.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_phone.Location = new System.Drawing.Point(406, 234);
            this.tb_phone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tb_phone.Multiline = false;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.tb_phone.PasswordChar = false;
            this.tb_phone.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.tb_phone.PlaceholderText = "Số điện thoại";
            this.tb_phone.Size = new System.Drawing.Size(436, 54);
            this.tb_phone.TabIndex = 15;
            this.tb_phone.Texts = "";
            this.tb_phone.UnderlinedStyle = false;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tb_password.BorderColor = System.Drawing.Color.Transparent;
            this.tb_password.BorderFocusColor = System.Drawing.Color.Transparent;
            this.tb_password.BorderRadius = 20;
            this.tb_password.BorderSize = 2;
            this.tb_password.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_password.Location = new System.Drawing.Point(406, 333);
            this.tb_password.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tb_password.Multiline = false;
            this.tb_password.Name = "tb_password";
            this.tb_password.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.tb_password.PasswordChar = true;
            this.tb_password.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.tb_password.PlaceholderText = "Mật khẩu";
            this.tb_password.Size = new System.Drawing.Size(436, 54);
            this.tb_password.TabIndex = 16;
            this.tb_password.Texts = "";
            this.tb_password.UnderlinedStyle = false;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.White;
            this.roundedButton1.BackgroundColor = System.Drawing.Color.White;
            this.roundedButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.roundedButton1.BorderRadius = 8;
            this.roundedButton1.BorderSize = 1;
            this.roundedButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundedButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.roundedButton1.Location = new System.Drawing.Point(934, 42);
            this.roundedButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(146, 44);
            this.roundedButton1.TabIndex = 17;
            this.roundedButton1.Text = "Đăng nhập";
            this.roundedButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // btn_signUpForm
            // 
            this.btn_signUpForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_signUpForm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_signUpForm.BorderColor = System.Drawing.Color.White;
            this.btn_signUpForm.BorderRadius = 8;
            this.btn_signUpForm.BorderSize = 0;
            this.btn_signUpForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_signUpForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signUpForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_signUpForm.ForeColor = System.Drawing.Color.White;
            this.btn_signUpForm.Location = new System.Drawing.Point(1091, 42);
            this.btn_signUpForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_signUpForm.Name = "btn_signUpForm";
            this.btn_signUpForm.Size = new System.Drawing.Size(146, 44);
            this.btn_signUpForm.TabIndex = 18;
            this.btn_signUpForm.Text = "Đăng ký";
            this.btn_signUpForm.TextColor = System.Drawing.Color.White;
            this.btn_signUpForm.UseVisualStyleBackColor = false;
            this.btn_signUpForm.Click += new System.EventHandler(this.btn_signUpForm_Click);
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.roundedButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.roundedButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButton2.BorderRadius = 28;
            this.roundedButton2.BorderSize = 0;
            this.roundedButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Location = new System.Drawing.Point(492, 497);
            this.roundedButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(273, 53);
            this.roundedButton2.TabIndex = 19;
            this.roundedButton2.Text = "Đăng nhập khách";
            this.roundedButton2.TextColor = System.Drawing.Color.White;
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 580);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.btn_signUpForm);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "SignInForm";
            this.Padding = new System.Windows.Forms.Padding(20, 100, 20, 25);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.SignInForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private RoundedButton btn_signUp;
        private PictureBox pictureBox1;
        private RoundedTextBox tb_phone;
        private RoundedTextBox tb_password;
        private RoundedButton roundedButton1;
        private RoundedButton btn_signUpForm;
        private RoundedButton roundedButton2;
    }

}