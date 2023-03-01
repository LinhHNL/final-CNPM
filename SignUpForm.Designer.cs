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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_signUp = new WinFormsApp2.CustomControls.RoundedButton();
            this.tb_name = new WinFormsApp2.CustomControls.RoundedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_email = new WinFormsApp2.CustomControls.RoundedTextBox();
            this.tb_phone = new WinFormsApp2.CustomControls.RoundedTextBox();
            this.tb_password = new WinFormsApp2.CustomControls.RoundedTextBox();
            this.roundedButton1 = new WinFormsApp2.CustomControls.RoundedButton();
            this.roundedButton2 = new WinFormsApp2.CustomControls.RoundedButton();
            this.lbl_errorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(428, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đăng ký";
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
            this.btn_signUp.Location = new System.Drawing.Point(434, 449);
            this.btn_signUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(132, 55);
            this.btn_signUp.TabIndex = 11;
            this.btn_signUp.Text = "Đăng ký";
            this.btn_signUp.TextColor = System.Drawing.Color.White;
            this.btn_signUp.UseVisualStyleBackColor = false;
            this.btn_signUp.Click += new System.EventHandler(this.roundedButton1_Click);
            this.btn_signUp.MouseHover += new System.EventHandler(this.roundedButton1_MouseHover);
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tb_name.BorderColor = System.Drawing.Color.Transparent;
            this.tb_name.BorderFocusColor = System.Drawing.Color.Transparent;
            this.tb_name.BorderRadius = 20;
            this.tb_name.BorderSize = 2;
            this.tb_name.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_name.Location = new System.Drawing.Point(325, 196);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_name.Multiline = false;
            this.tb_name.Name = "tb_name";
            this.tb_name.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_name.PasswordChar = false;
            this.tb_name.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.tb_name.PlaceholderText = "Họ và tên";
            this.tb_name.Size = new System.Drawing.Size(349, 43);
            this.tb_name.TabIndex = 12;
            this.tb_name.Texts = "";
            this.tb_name.UnderlinedStyle = false;
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
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tb_email.BorderColor = System.Drawing.Color.Transparent;
            this.tb_email.BorderFocusColor = System.Drawing.Color.Transparent;
            this.tb_email.BorderRadius = 20;
            this.tb_email.BorderSize = 2;
            this.tb_email.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_email.Location = new System.Drawing.Point(325, 261);
            this.tb_email.Margin = new System.Windows.Forms.Padding(4);
            this.tb_email.Multiline = false;
            this.tb_email.Name = "tb_email";
            this.tb_email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_email.PasswordChar = false;
            this.tb_email.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.tb_email.PlaceholderText = "Địa chỉ email";
            this.tb_email.Size = new System.Drawing.Size(349, 43);
            this.tb_email.TabIndex = 14;
            this.tb_email.Texts = "";
            this.tb_email.UnderlinedStyle = false;
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
            this.tb_phone.Location = new System.Drawing.Point(325, 326);
            this.tb_phone.Margin = new System.Windows.Forms.Padding(4);
            this.tb_phone.Multiline = false;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_phone.PasswordChar = false;
            this.tb_phone.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.tb_phone.PlaceholderText = "Họ và tên";
            this.tb_phone.Size = new System.Drawing.Size(349, 43);
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
            this.tb_password.Location = new System.Drawing.Point(325, 389);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_password.Multiline = false;
            this.tb_password.Name = "tb_password";
            this.tb_password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_password.PasswordChar = true;
            this.tb_password.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.tb_password.PlaceholderText = "Mật khẩu";
            this.tb_password.Size = new System.Drawing.Size(349, 43);
            this.tb_password.TabIndex = 16;
            this.tb_password.Texts = "";
            this.tb_password.UnderlinedStyle = false;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.roundedButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.roundedButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButton1.BorderRadius = 8;
            this.roundedButton1.BorderSize = 0;
            this.roundedButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(747, 34);
            this.roundedButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(117, 35);
            this.roundedButton1.TabIndex = 17;
            this.roundedButton1.Text = "Đăng nhập";
            this.roundedButton1.TextColor = System.Drawing.Color.White;
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.White;
            this.roundedButton2.BackgroundColor = System.Drawing.Color.White;
            this.roundedButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.roundedButton2.BorderRadius = 8;
            this.roundedButton2.BorderSize = 1;
            this.roundedButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundedButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.roundedButton2.Location = new System.Drawing.Point(873, 34);
            this.roundedButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(117, 35);
            this.roundedButton2.TabIndex = 18;
            this.roundedButton2.Text = "Đăng ký";
            this.roundedButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.roundedButton2.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SignUpForm";
            this.Padding = new System.Windows.Forms.Padding(16, 80, 16, 20);
            this.Style = MetroFramework.MetroColorStyle.White;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private RoundedButton btn_signUp;
        private RoundedTextBox tb_name;
        private PictureBox pictureBox1;
        private RoundedTextBox tb_email;
        private RoundedTextBox tb_phone;
        private RoundedTextBox tb_password;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
        private Label lbl_errorMessage;
    }
}