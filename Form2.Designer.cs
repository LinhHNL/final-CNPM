namespace WinFormsApp1
{
    partial class Form2
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
            this.tb_firstName = new WinFormsApp1.MyTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_lastName = new WinFormsApp1.MyTextbox();
            this.tb_email = new WinFormsApp1.MyTextbox();
            this.tb_phone = new WinFormsApp1.MyTextbox();
            this.tb_password = new WinFormsApp1.MyTextbox();
            this.tb_passwordCofirm = new WinFormsApp1.MyTextbox();
            this.btn_signUp = new WinFormsApp1.RoundedButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.tile_signUp = new MetroFramework.Controls.MetroTile();
            this.pb_signUp = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tile_signIn = new MetroFramework.Controls.MetroTile();
            this.pb_signIn = new System.Windows.Forms.PictureBox();
            this.metroTile1.SuspendLayout();
            this.tile_signUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_signUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tile_signIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_signIn)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_firstName
            // 
            this.tb_firstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_firstName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_firstName.ForeColor = System.Drawing.Color.SteelBlue;
            this.tb_firstName.Location = new System.Drawing.Point(230, 112);
            this.tb_firstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.PlaceholderText = "First name";
            this.tb_firstName.Size = new System.Drawing.Size(271, 33);
            this.tb_firstName.TabIndex = 3;
            this.tb_firstName.TextChanged += new System.EventHandler(this.myTextbox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(464, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sign up";
            // 
            // tb_lastName
            // 
            this.tb_lastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_lastName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_lastName.ForeColor = System.Drawing.Color.SteelBlue;
            this.tb_lastName.Location = new System.Drawing.Point(561, 112);
            this.tb_lastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.PlaceholderText = "Last name";
            this.tb_lastName.Size = new System.Drawing.Size(271, 33);
            this.tb_lastName.TabIndex = 5;
            // 
            // tb_email
            // 
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_email.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_email.ForeColor = System.Drawing.Color.SteelBlue;
            this.tb_email.Location = new System.Drawing.Point(230, 195);
            this.tb_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_email.Name = "tb_email";
            this.tb_email.PlaceholderText = "E-mail";
            this.tb_email.Size = new System.Drawing.Size(271, 33);
            this.tb_email.TabIndex = 6;
            // 
            // tb_phone
            // 
            this.tb_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_phone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_phone.ForeColor = System.Drawing.Color.SteelBlue;
            this.tb_phone.Location = new System.Drawing.Point(561, 195);
            this.tb_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.PlaceholderText = "Phone";
            this.tb_phone.Size = new System.Drawing.Size(271, 33);
            this.tb_phone.TabIndex = 7;
            // 
            // tb_password
            // 
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_password.ForeColor = System.Drawing.Color.SteelBlue;
            this.tb_password.Location = new System.Drawing.Point(230, 283);
            this.tb_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '●';
            this.tb_password.PlaceholderText = "Password";
            this.tb_password.Size = new System.Drawing.Size(271, 33);
            this.tb_password.TabIndex = 8;
            // 
            // tb_passwordCofirm
            // 
            this.tb_passwordCofirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_passwordCofirm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_passwordCofirm.ForeColor = System.Drawing.Color.SteelBlue;
            this.tb_passwordCofirm.Location = new System.Drawing.Point(561, 283);
            this.tb_passwordCofirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_passwordCofirm.Name = "tb_passwordCofirm";
            this.tb_passwordCofirm.PasswordChar = '●';
            this.tb_passwordCofirm.PlaceholderText = "Confirm password";
            this.tb_passwordCofirm.Size = new System.Drawing.Size(271, 33);
            this.tb_passwordCofirm.TabIndex = 9;
            // 
            // btn_signUp
            // 
            this.btn_signUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_signUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_signUp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_signUp.ForeColor = System.Drawing.Color.White;
            this.btn_signUp.Location = new System.Drawing.Point(447, 373);
            this.btn_signUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(168, 67);
            this.btn_signUp.TabIndex = 11;
            this.btn_signUp.Text = "Sign up";
            this.btn_signUp.UseVisualStyleBackColor = false;
            this.btn_signUp.Click += new System.EventHandler(this.roundedButton1_Click);
            this.btn_signUp.MouseHover += new System.EventHandler(this.roundedButton1_MouseHover);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.metroTile1.Controls.Add(this.tile_signUp);
            this.metroTile1.Controls.Add(this.pictureBox1);
            this.metroTile1.Controls.Add(this.tile_signIn);
            this.metroTile1.Location = new System.Drawing.Point(0, -3);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(101, 505);
            this.metroTile1.TabIndex = 12;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseVisualStyleBackColor = false;
            // 
            // tile_signUp
            // 
            this.tile_signUp.ActiveControl = null;
            this.tile_signUp.BackColor = System.Drawing.Color.White;
            this.tile_signUp.Controls.Add(this.pb_signUp);
            this.tile_signUp.Location = new System.Drawing.Point(0, 156);
            this.tile_signUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tile_signUp.Name = "tile_signUp";
            this.tile_signUp.Size = new System.Drawing.Size(101, 56);
            this.tile_signUp.TabIndex = 2;
            this.tile_signUp.UseCustomBackColor = true;
            this.tile_signUp.UseSelectable = true;
            this.tile_signUp.UseVisualStyleBackColor = false;
            // 
            // pb_signUp
            // 
            this.pb_signUp.Location = new System.Drawing.Point(33, 15);
            this.pb_signUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_signUp.Name = "pb_signUp";
            this.pb_signUp.Size = new System.Drawing.Size(114, 67);
            this.pb_signUp.TabIndex = 1;
            this.pb_signUp.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tile_signIn
            // 
            this.tile_signIn.ActiveControl = null;
            this.tile_signIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.tile_signIn.Controls.Add(this.pb_signIn);
            this.tile_signIn.Location = new System.Drawing.Point(0, 107);
            this.tile_signIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tile_signIn.Name = "tile_signIn";
            this.tile_signIn.Size = new System.Drawing.Size(101, 56);
            this.tile_signIn.TabIndex = 3;
            this.tile_signIn.UseCustomBackColor = true;
            this.tile_signIn.UseSelectable = true;
            this.tile_signIn.UseVisualStyleBackColor = false;
            // 
            // pb_signIn
            // 
            this.pb_signIn.Location = new System.Drawing.Point(33, 4);
            this.pb_signIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_signIn.Name = "pb_signIn";
            this.pb_signIn.Size = new System.Drawing.Size(114, 37);
            this.pb_signIn.TabIndex = 3;
            this.pb_signIn.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 500);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.tb_passwordCofirm);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_firstName);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(16, 80, 16, 20);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTile1.ResumeLayout(false);
            this.tile_signUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_signUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tile_signIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_signIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MyTextbox tb_firstName;
        private Label label1;
        private MyTextbox tb_lastName;
        private MyTextbox tb_email;
        private MyTextbox tb_phone;
        private MyTextbox tb_password;
        private MyTextbox tb_passwordCofirm;
        private RoundedButton btn_signUp;
        private MetroFramework.Controls.MetroTile metroTile1;
        private PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile tile_signUp;
        private PictureBox pb_signUp;
        private PictureBox pb_signIn;
        private MetroFramework.Controls.MetroTile tile_signIn;
    }
}