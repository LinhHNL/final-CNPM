namespace WinFormsApp2.AdminPage
{
    partial class LockFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockFood));
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            lbl_AccountName = new Label();
            pb_AccountIcon = new PictureBox();
            metroPanel7 = new MetroFramework.Controls.MetroPanel();
            btn_UpdateFood = new CustomControls.RoundedButton();
            btn_LockFood = new CustomControls.RoundedButton();
            btn_AddFood = new CustomControls.RoundedButton();
            btn_AddComboFood = new CustomControls.RoundedButton();
            pb_Logo = new PictureBox();
            btn_Signout = new CustomControls.RoundedButton();
            pnl_food_lock = new MetroFramework.Controls.MetroPanel();
            metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_AccountIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).BeginInit();
            SuspendLayout();
            // 
            // metroPanel1
            // 
            metroPanel1.Controls.Add(lbl_AccountName);
            metroPanel1.Controls.Add(pb_AccountIcon);
            metroPanel1.Controls.Add(metroPanel7);
            metroPanel1.Controls.Add(btn_UpdateFood);
            metroPanel1.Controls.Add(btn_LockFood);
            metroPanel1.Controls.Add(btn_AddFood);
            metroPanel1.Controls.Add(btn_AddComboFood);
            metroPanel1.Controls.Add(pb_Logo);
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(0, 37);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(259, 552);
            metroPanel1.TabIndex = 17;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lbl_AccountName
            // 
            lbl_AccountName.AutoSize = true;
            lbl_AccountName.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_AccountName.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_AccountName.Location = new Point(82, 80);
            lbl_AccountName.Name = "lbl_AccountName";
            lbl_AccountName.Size = new Size(138, 28);
            lbl_AccountName.TabIndex = 33;
            lbl_AccountName.Text = "Tên tài khoản";
            // 
            // pb_AccountIcon
            // 
            pb_AccountIcon.Image = (Image)resources.GetObject("pb_AccountIcon.Image");
            pb_AccountIcon.Location = new Point(46, 82);
            pb_AccountIcon.Name = "pb_AccountIcon";
            pb_AccountIcon.Size = new Size(30, 26);
            pb_AccountIcon.TabIndex = 32;
            pb_AccountIcon.TabStop = false;
            // 
            // metroPanel7
            // 
            metroPanel7.BackColor = Color.Black;
            metroPanel7.HorizontalScrollbarBarColor = true;
            metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel7.HorizontalScrollbarSize = 10;
            metroPanel7.Location = new Point(259, 539);
            metroPanel7.Name = "metroPanel7";
            metroPanel7.Size = new Size(904, 55);
            metroPanel7.TabIndex = 20;
            metroPanel7.VerticalScrollbarBarColor = true;
            metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            metroPanel7.VerticalScrollbarSize = 10;
            // 
            // btn_UpdateFood
            // 
            btn_UpdateFood.BackColor = Color.White;
            btn_UpdateFood.BackgroundColor = Color.White;
            btn_UpdateFood.BorderColor = Color.FromArgb(0, 0, 15, 255);
            btn_UpdateFood.BorderRadius = 0;
            btn_UpdateFood.BorderSize = 0;
            btn_UpdateFood.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_UpdateFood.FlatStyle = FlatStyle.Flat;
            btn_UpdateFood.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_UpdateFood.ForeColor = Color.FromArgb(160, 159, 159);
            btn_UpdateFood.Location = new Point(-1, 300);
            btn_UpdateFood.Margin = new Padding(3, 4, 3, 4);
            btn_UpdateFood.Name = "btn_UpdateFood";
            btn_UpdateFood.Size = new Size(263, 64);
            btn_UpdateFood.TabIndex = 18;
            btn_UpdateFood.Text = "Cập nhật món ăn";
            btn_UpdateFood.TextColor = Color.FromArgb(160, 159, 159);
            btn_UpdateFood.UseVisualStyleBackColor = false;
            btn_UpdateFood.Click += btn_UpdateFood_Click;
            // 
            // btn_LockFood
            // 
            btn_LockFood.BackColor = Color.FromArgb(229, 1, 17);
            btn_LockFood.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_LockFood.BorderColor = Color.FromArgb(0, 0, 15, 255);
            btn_LockFood.BorderRadius = 0;
            btn_LockFood.BorderSize = 0;
            btn_LockFood.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_LockFood.FlatStyle = FlatStyle.Flat;
            btn_LockFood.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_LockFood.ForeColor = Color.White;
            btn_LockFood.Location = new Point(-1, 241);
            btn_LockFood.Margin = new Padding(3, 4, 3, 4);
            btn_LockFood.Name = "btn_LockFood";
            btn_LockFood.Size = new Size(264, 64);
            btn_LockFood.TabIndex = 17;
            btn_LockFood.Text = "Khóa món ăn";
            btn_LockFood.TextColor = Color.White;
            btn_LockFood.UseVisualStyleBackColor = false;
            btn_LockFood.Click += btn_LockFood_Click;
            // 
            // btn_AddFood
            // 
            btn_AddFood.BackColor = Color.FromArgb(0, 0, 15, 255);
            btn_AddFood.BackgroundColor = Color.FromArgb(0, 0, 15, 255);
            btn_AddFood.BorderColor = Color.Transparent;
            btn_AddFood.BorderRadius = 0;
            btn_AddFood.BorderSize = 0;
            btn_AddFood.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_AddFood.FlatStyle = FlatStyle.Flat;
            btn_AddFood.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AddFood.ForeColor = Color.FromArgb(160, 159, 159);
            btn_AddFood.Location = new Point(0, 128);
            btn_AddFood.Margin = new Padding(3, 4, 3, 4);
            btn_AddFood.Name = "btn_AddFood";
            btn_AddFood.Size = new Size(262, 60);
            btn_AddFood.TabIndex = 16;
            btn_AddFood.Text = "Thêm món ăn";
            btn_AddFood.TextColor = Color.FromArgb(160, 159, 159);
            btn_AddFood.UseVisualStyleBackColor = false;
            btn_AddFood.Click += btn_AddFood_Click;
            // 
            // btn_AddComboFood
            // 
            btn_AddComboFood.BackColor = Color.FromArgb(0, 0, 15, 255);
            btn_AddComboFood.BackgroundColor = Color.FromArgb(0, 0, 15, 255);
            btn_AddComboFood.BorderColor = Color.Transparent;
            btn_AddComboFood.BorderRadius = 0;
            btn_AddComboFood.BorderSize = 0;
            btn_AddComboFood.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_AddComboFood.FlatStyle = FlatStyle.Flat;
            btn_AddComboFood.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AddComboFood.ForeColor = Color.FromArgb(160, 159, 159);
            btn_AddComboFood.Location = new Point(0, 187);
            btn_AddComboFood.Margin = new Padding(3, 4, 3, 4);
            btn_AddComboFood.Name = "btn_AddComboFood";
            btn_AddComboFood.Size = new Size(262, 56);
            btn_AddComboFood.TabIndex = 16;
            btn_AddComboFood.Text = "Thêm combo món ăn";
            btn_AddComboFood.TextColor = Color.FromArgb(160, 159, 159);
            btn_AddComboFood.UseVisualStyleBackColor = false;
            btn_AddComboFood.Click += btn_AddComboFood_Click;
            // 
            // pb_Logo
            // 
            pb_Logo.Image = (Image)resources.GetObject("pb_Logo.Image");
            pb_Logo.Location = new Point(100, 14);
            pb_Logo.Name = "pb_Logo";
            pb_Logo.Size = new Size(50, 50);
            pb_Logo.TabIndex = 16;
            pb_Logo.TabStop = false;
            // 
            // btn_Signout
            // 
            btn_Signout.BackColor = Color.FromArgb(229, 1, 17);
            btn_Signout.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_Signout.BorderColor = Color.PaleVioletRed;
            btn_Signout.BorderRadius = 8;
            btn_Signout.BorderSize = 0;
            btn_Signout.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_Signout.FlatStyle = FlatStyle.Flat;
            btn_Signout.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Signout.ForeColor = Color.White;
            btn_Signout.Location = new Point(1042, 37);
            btn_Signout.Margin = new Padding(3, 4, 3, 4);
            btn_Signout.Name = "btn_Signout";
            btn_Signout.Size = new Size(117, 35);
            btn_Signout.TabIndex = 22;
            btn_Signout.Text = "Đăng xuất";
            btn_Signout.TextColor = Color.White;
            btn_Signout.UseVisualStyleBackColor = false;
            // 
            // pnl_food_lock
            // 
            pnl_food_lock.AutoScroll = true;
            pnl_food_lock.HorizontalScrollbar = true;
            pnl_food_lock.HorizontalScrollbarBarColor = true;
            pnl_food_lock.HorizontalScrollbarHighlightOnWheel = false;
            pnl_food_lock.HorizontalScrollbarSize = 10;
            pnl_food_lock.Location = new Point(270, 79);
            pnl_food_lock.Name = "pnl_food_lock";
            pnl_food_lock.Size = new Size(901, 533);
            pnl_food_lock.TabIndex = 23;
            pnl_food_lock.VerticalScrollbar = true;
            pnl_food_lock.VerticalScrollbarBarColor = true;
            pnl_food_lock.VerticalScrollbarHighlightOnWheel = false;
            pnl_food_lock.VerticalScrollbarSize = 10;
            // 
            // LockFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 605);
            Controls.Add(pnl_food_lock);
            Controls.Add(btn_Signout);
            Controls.Add(metroPanel1);
            Name = "LockFood";
            metroPanel1.ResumeLayout(false);
            metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_AccountIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private CustomControls.RoundedButton btn_UpdateFood;
        private CustomControls.RoundedButton btn_LockFood;
        private CustomControls.RoundedButton btn_AddFood;
        private CustomControls.RoundedButton btn_AddComboFood;
        private PictureBox pb_Logo;
        private CustomControls.RoundedButton btn_Signout;
        private MetroFramework.Controls.MetroPanel pnl_food_lock;
        private Label lbl_AccountName;
        private PictureBox pb_AccountIcon;
    }
}