namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_firstName = new WinFormsApp1.MyTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_signUp = new WinFormsApp1.RoundedButton();
            this.tb_password = new WinFormsApp1.MyTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_login_change = new System.Windows.Forms.Button();
            this.btn_signupchange = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_firstName
            // 
            this.tb_firstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_firstName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_firstName.ForeColor = System.Drawing.Color.SteelBlue;
            this.tb_firstName.Location = new System.Drawing.Point(331, 112);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.PlaceholderText = "Username";
            this.tb_firstName.Size = new System.Drawing.Size(237, 25);
            this.tb_firstName.TabIndex = 3;
            this.tb_firstName.Click += new System.EventHandler(this.tb_firstName_Click);
            this.tb_firstName.TextChanged += new System.EventHandler(this.myTextbox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(406, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sign in";
            // 
            // btn_signUp
            // 
            this.btn_signUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_signUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_signUp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_signUp.ForeColor = System.Drawing.Color.White;
            this.btn_signUp.Location = new System.Drawing.Point(391, 280);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(147, 50);
            this.btn_signUp.TabIndex = 11;
            this.btn_signUp.Text = "Sign in";
            this.btn_signUp.UseVisualStyleBackColor = false;
            this.btn_signUp.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_signUp.MouseHover += new System.EventHandler(this.roundedButton1_MouseHover);
            // 
            // tb_password
            // 
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_password.ForeColor = System.Drawing.Color.SteelBlue;
            this.tb_password.Location = new System.Drawing.Point(331, 166);
            this.tb_password.Name = "tb_password";
            this.tb_password.PlaceholderText = "Password";
            this.tb_password.Size = new System.Drawing.Size(237, 25);
            this.tb_password.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.btn_login_change);
            this.panel1.Controls.Add(this.btn_signupchange);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 377);
            this.panel1.TabIndex = 14;
            // 
            // btn_login_change
            // 
            this.btn_login_change.BackColor = System.Drawing.Color.White;
            this.btn_login_change.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login_change.BackgroundImage")));
            this.btn_login_change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_login_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_change.ForeColor = System.Drawing.Color.Transparent;
            this.btn_login_change.Location = new System.Drawing.Point(0, 86);
            this.btn_login_change.Name = "btn_login_change";
            this.btn_login_change.Size = new System.Drawing.Size(118, 51);
            this.btn_login_change.TabIndex = 2;
            this.btn_login_change.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login_change.UseVisualStyleBackColor = false;
            this.btn_login_change.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_signupchange
            // 
            this.btn_signupchange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_signupchange.BackgroundImage")));
            this.btn_signupchange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_signupchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signupchange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_signupchange.Location = new System.Drawing.Point(0, 143);
            this.btn_signupchange.Name = "btn_signupchange";
            this.btn_signupchange.Size = new System.Drawing.Size(118, 51);
            this.btn_signupchange.TabIndex = 0;
            this.btn_signupchange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_signupchange.UseVisualStyleBackColor = true;
            this.btn_signupchange.Click += new System.EventHandler(this.btn_signupchange_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 80);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 375);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_firstName);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(14, 60, 14, 15);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MyTextbox tb_firstName;
        private Label label1;
        private RoundedButton btn_signUp;
        private MyTextbox tb_password;
        private Panel panel1;
        private Button btn_login_change;
        private Button btn_signupchange;
        private Panel panel2;
    }
}