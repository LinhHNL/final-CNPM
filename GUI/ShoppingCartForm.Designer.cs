﻿namespace WinFormsApp2
{
    partial class ShoppingCartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCartForm));
            btn_signInForm = new CustomControls.RoundedButton();
            roundedButton10 = new CustomControls.RoundedButton();
            pictureBox1 = new PictureBox();
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            lbl_returnplace = new Label();
            lbl_heading = new Label();
            lbl_description = new Label();
            PB_Delicon = new PictureBox();
            lbl_deleteAll = new Label();
            flp_Hienthimonan = new FlowLayoutPanel();
            lbl_priceshowheading = new Label();
            lbl_priceshow = new Label();
            btn_submitfood = new CustomControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_Delicon).BeginInit();
            SuspendLayout();
            // 
            // btn_signInForm
            // 
            btn_signInForm.BackColor = Color.FromArgb(229, 1, 17);
            btn_signInForm.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_signInForm.BorderColor = Color.PaleVioletRed;
            btn_signInForm.BorderRadius = 8;
            btn_signInForm.BorderSize = 0;
            btn_signInForm.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_signInForm.FlatStyle = FlatStyle.Flat;
            btn_signInForm.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_signInForm.ForeColor = Color.White;
            btn_signInForm.Location = new Point(762, 35);
            btn_signInForm.Margin = new Padding(3, 4, 3, 4);
            btn_signInForm.Name = "btn_signInForm";
            btn_signInForm.Size = new Size(117, 35);
            btn_signInForm.TabIndex = 19;
            btn_signInForm.Text = "Tài khoản";
            btn_signInForm.TextColor = Color.White;
            btn_signInForm.UseVisualStyleBackColor = false;
            // 
            // roundedButton10
            // 
            roundedButton10.BackColor = Color.FromArgb(229, 1, 17);
            roundedButton10.BackgroundColor = Color.FromArgb(229, 1, 17);
            roundedButton10.BorderColor = Color.PaleVioletRed;
            roundedButton10.BorderRadius = 8;
            roundedButton10.BorderSize = 0;
            roundedButton10.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            roundedButton10.FlatStyle = FlatStyle.Flat;
            roundedButton10.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton10.ForeColor = Color.White;
            roundedButton10.Location = new Point(902, 35);
            roundedButton10.Margin = new Padding(3, 4, 3, 4);
            roundedButton10.Name = "roundedButton10";
            roundedButton10.Size = new Size(117, 35);
            roundedButton10.TabIndex = 22;
            roundedButton10.Text = "Đăng xuất";
            roundedButton10.TextColor = Color.White;
            roundedButton10.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // metroPanel1
            // 
            metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            metroPanel1.Controls.Add(lbl_returnplace);
            metroPanel1.Controls.Add(lbl_heading);
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(-2, 91);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(1045, 52);
            metroPanel1.TabIndex = 24;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lbl_returnplace
            // 
            lbl_returnplace.AutoSize = true;
            lbl_returnplace.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_returnplace.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_returnplace.Location = new Point(888, 11);
            lbl_returnplace.Name = "lbl_returnplace";
            lbl_returnplace.Size = new Size(110, 28);
            lbl_returnplace.TabIndex = 3;
            lbl_returnplace.Text = "Quay lại >";
            lbl_returnplace.Click += lbl_returnplace_Click;
            // 
            // lbl_heading
            // 
            lbl_heading.AutoSize = true;
            lbl_heading.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_heading.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_heading.Location = new Point(24, 9);
            lbl_heading.Name = "lbl_heading";
            lbl_heading.Size = new Size(203, 32);
            lbl_heading.TabIndex = 2;
            lbl_heading.Text = "Món ăn tôi chọn";
            // 
            // lbl_description
            // 
            lbl_description.AutoSize = true;
            lbl_description.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_description.ForeColor = Color.FromArgb(108, 117, 125);
            lbl_description.Location = new Point(23, 157);
            lbl_description.Name = "lbl_description";
            lbl_description.Size = new Size(79, 28);
            lbl_description.TabIndex = 26;
            lbl_description.Text = "Món ăn";
            // 
            // PB_Delicon
            // 
            PB_Delicon.Image = (Image)resources.GetObject("PB_Delicon.Image");
            PB_Delicon.Location = new Point(902, 157);
            PB_Delicon.Name = "PB_Delicon";
            PB_Delicon.Size = new Size(32, 34);
            PB_Delicon.TabIndex = 24;
            PB_Delicon.TabStop = false;
            PB_Delicon.Click += PB_Delicon_Click;
            // 
            // lbl_deleteAll
            // 
            lbl_deleteAll.AutoSize = true;
            lbl_deleteAll.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_deleteAll.ForeColor = Color.FromArgb(108, 117, 125);
            lbl_deleteAll.Location = new Point(940, 157);
            lbl_deleteAll.Name = "lbl_deleteAll";
            lbl_deleteAll.Size = new Size(79, 28);
            lbl_deleteAll.TabIndex = 28;
            lbl_deleteAll.Text = "Xóa hết";
            lbl_deleteAll.Click += lbl_deleteAll_Click;
            // 
            // flp_Hienthimonan
            // 
            flp_Hienthimonan.AutoScroll = true;
            flp_Hienthimonan.Location = new Point(-2, 203);
            flp_Hienthimonan.Name = "flp_Hienthimonan";
            flp_Hienthimonan.Size = new Size(1045, 289);
            flp_Hienthimonan.TabIndex = 28;
            // 
            // lbl_priceshowheading
            // 
            lbl_priceshowheading.AutoSize = true;
            lbl_priceshowheading.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_priceshowheading.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_priceshowheading.Location = new Point(23, 513);
            lbl_priceshowheading.Name = "lbl_priceshowheading";
            lbl_priceshowheading.Size = new Size(124, 32);
            lbl_priceshowheading.TabIndex = 3;
            lbl_priceshowheading.Text = "Tổng tiền";
            // 
            // lbl_priceshow
            // 
            lbl_priceshow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_priceshow.Location = new Point(374, 504);
            lbl_priceshow.Name = "lbl_priceshow";
            lbl_priceshow.Size = new Size(433, 50);
            lbl_priceshow.TabIndex = 29;
            lbl_priceshow.Text = "Giá tiền";
            lbl_priceshow.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_submitfood
            // 
            btn_submitfood.BackColor = Color.FromArgb(229, 1, 17);
            btn_submitfood.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_submitfood.BorderColor = Color.PaleVioletRed;
            btn_submitfood.BorderRadius = 8;
            btn_submitfood.BorderSize = 0;
            btn_submitfood.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_submitfood.FlatStyle = FlatStyle.Flat;
            btn_submitfood.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_submitfood.ForeColor = Color.White;
            btn_submitfood.Location = new Point(813, 504);
            btn_submitfood.Margin = new Padding(3, 4, 3, 4);
            btn_submitfood.Name = "btn_submitfood";
            btn_submitfood.Size = new Size(184, 55);
            btn_submitfood.TabIndex = 20;
            btn_submitfood.Text = "Đặt món ăn";
            btn_submitfood.TextColor = Color.White;
            btn_submitfood.UseVisualStyleBackColor = false;
            btn_submitfood.Click += btn_submitfood_Click;
            // 
            // ShoppingCartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 565);
            Controls.Add(lbl_deleteAll);
            Controls.Add(PB_Delicon);
            Controls.Add(btn_submitfood);
            Controls.Add(lbl_priceshow);
            Controls.Add(lbl_priceshowheading);
            Controls.Add(flp_Hienthimonan);
            Controls.Add(lbl_description);
            Controls.Add(metroPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(roundedButton10);
            Controls.Add(btn_signInForm);
            Name = "ShoppingCartForm";
            Load += ShoppingCartForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            metroPanel1.ResumeLayout(false);
            metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_Delicon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RoundedButton btn_signInForm;
        private CustomControls.RoundedButton roundedButton10;
        private PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Label lbl_returnplace;
        private Label lbl_heading;
        private Label lbl_description;
        private Label lbl_deleteAll;
        private PictureBox PB_Delicon;
        private FlowLayoutPanel flp_Hienthimonan;
        private Label lbl_priceshowheading;
        private Label lbl_priceshow;
        private CustomControls.RoundedButton btn_submitfood;
    }
}