namespace WinFormsApp2.AdminPage
{
    partial class AdminAddingComboFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAddingComboFood));
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            lbl_AccountName = new Label();
            pb_AccountIcon = new PictureBox();
            metroPanel7 = new MetroFramework.Controls.MetroPanel();
            btn_UpdateFood = new CustomControls.RoundedButton();
            btn_LockFood = new CustomControls.RoundedButton();
            btn_AddFood = new CustomControls.RoundedButton();
            btn_AddComboFood = new CustomControls.RoundedButton();
            pb_Logo = new PictureBox();
            panel_monan_1 = new FlowLayoutPanel();
            flp_Hienthimonan = new FlowLayoutPanel();
            btn_Signout = new CustomControls.RoundedButton();
            btn_AddingFood = new CustomControls.RoundedButton();
            metroTile1 = new MetroFramework.Controls.MetroTile();
            lbl_Food = new Label();
            panel2 = new Panel();
            lbl_deleteAll = new Label();
            PB_Delicon = new PictureBox();
            metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_AccountIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_Delicon).BeginInit();
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
            metroPanel1.Location = new Point(5, 48);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(259, 567);
            metroPanel1.TabIndex = 18;
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
            btn_UpdateFood.AutoSizeChanged += btn_UpdateFood_Click;
            btn_UpdateFood.Click += btn_UpdateFood_Click;
            // 
            // btn_LockFood
            // 
            btn_LockFood.BackColor = Color.White;
            btn_LockFood.BackgroundColor = Color.White;
            btn_LockFood.BorderColor = Color.FromArgb(0, 0, 15, 255);
            btn_LockFood.BorderRadius = 0;
            btn_LockFood.BorderSize = 0;
            btn_LockFood.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_LockFood.FlatStyle = FlatStyle.Flat;
            btn_LockFood.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_LockFood.ForeColor = Color.FromArgb(160, 159, 159);
            btn_LockFood.Location = new Point(-1, 241);
            btn_LockFood.Margin = new Padding(3, 4, 3, 4);
            btn_LockFood.Name = "btn_LockFood";
            btn_LockFood.Size = new Size(264, 64);
            btn_LockFood.TabIndex = 17;
            btn_LockFood.Text = "Khóa món ăn";
            btn_LockFood.TextColor = Color.FromArgb(160, 159, 159);
            btn_LockFood.UseVisualStyleBackColor = false;
            btn_LockFood.AutoSizeChanged += btn_LockFood_Click;
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
            btn_AddFood.AutoSizeChanged += btn_AddFood_Click;
            btn_AddFood.Click += btn_AddFood_Click;
            // 
            // btn_AddComboFood
            // 
            btn_AddComboFood.BackColor = Color.FromArgb(229, 1, 17);
            btn_AddComboFood.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_AddComboFood.BorderColor = Color.Transparent;
            btn_AddComboFood.BorderRadius = 0;
            btn_AddComboFood.BorderSize = 0;
            btn_AddComboFood.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_AddComboFood.FlatStyle = FlatStyle.Flat;
            btn_AddComboFood.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AddComboFood.ForeColor = Color.White;
            btn_AddComboFood.Location = new Point(0, 187);
            btn_AddComboFood.Margin = new Padding(3, 4, 3, 4);
            btn_AddComboFood.Name = "btn_AddComboFood";
            btn_AddComboFood.Size = new Size(262, 56);
            btn_AddComboFood.TabIndex = 16;
            btn_AddComboFood.Text = "Thêm combo món ăn";
            btn_AddComboFood.TextColor = Color.White;
            btn_AddComboFood.UseVisualStyleBackColor = false;
            btn_AddComboFood.AutoSizeChanged += btn_AddComboFood_Click;
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
            // panel_monan_1
            // 
            panel_monan_1.AutoScroll = true;
            panel_monan_1.Location = new Point(270, 86);
            panel_monan_1.Name = "panel_monan_1";
            panel_monan_1.Size = new Size(500, 529);
            panel_monan_1.TabIndex = 23;
            // 
            // flp_Hienthimonan
            // 
            flp_Hienthimonan.AutoScroll = true;
            flp_Hienthimonan.Location = new Point(786, 130);
            flp_Hienthimonan.Name = "flp_Hienthimonan";
            flp_Hienthimonan.Size = new Size(382, 426);
            flp_Hienthimonan.TabIndex = 29;
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
            btn_Signout.Location = new Point(1051, 48);
            btn_Signout.Margin = new Padding(3, 4, 3, 4);
            btn_Signout.Name = "btn_Signout";
            btn_Signout.Size = new Size(117, 35);
            btn_Signout.TabIndex = 23;
            btn_Signout.Text = "Đăng xuất";
            btn_Signout.TextColor = Color.White;
            btn_Signout.UseVisualStyleBackColor = false;
            // 
            // btn_AddingFood
            // 
            btn_AddingFood.BackColor = Color.FromArgb(229, 1, 17);
            btn_AddingFood.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_AddingFood.BorderColor = Color.PaleVioletRed;
            btn_AddingFood.BorderRadius = 0;
            btn_AddingFood.BorderSize = 0;
            btn_AddingFood.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_AddingFood.FlatStyle = FlatStyle.Flat;
            btn_AddingFood.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AddingFood.ForeColor = Color.White;
            btn_AddingFood.Location = new Point(1012, 562);
            btn_AddingFood.Margin = new Padding(3, 4, 3, 4);
            btn_AddingFood.Name = "btn_AddingFood";
            btn_AddingFood.Size = new Size(156, 53);
            btn_AddingFood.TabIndex = 30;
            btn_AddingFood.Text = "Thêm";
            btn_AddingFood.TextColor = Color.White;
            btn_AddingFood.UseVisualStyleBackColor = false;
            // 
            // metroTile1
            // 
            metroTile1.ActiveControl = null;
            metroTile1.BackColor = Color.Black;
            metroTile1.FlatAppearance.BorderColor = Color.Black;
            metroTile1.FlatAppearance.MouseDownBackColor = Color.Black;
            metroTile1.FlatAppearance.MouseOverBackColor = Color.Black;
            metroTile1.FlatStyle = FlatStyle.Flat;
            metroTile1.Location = new Point(786, 562);
            metroTile1.Name = "metroTile1";
            metroTile1.PaintTileCount = false;
            metroTile1.Size = new Size(229, 53);
            metroTile1.Style = MetroFramework.MetroColorStyle.Black;
            metroTile1.TabIndex = 31;
            metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroTile1.UseCustomBackColor = true;
            metroTile1.UseSelectable = true;
            metroTile1.UseStyleColors = true;
            metroTile1.UseVisualStyleBackColor = false;
            // 
            // lbl_Food
            // 
            lbl_Food.AutoSize = true;
            lbl_Food.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Food.Location = new Point(786, 96);
            lbl_Food.Name = "lbl_Food";
            lbl_Food.Size = new Size(84, 28);
            lbl_Food.TabIndex = 32;
            lbl_Food.Text = "Món ăn";
            // 
            // panel2
            // 
            panel2.Controls.Add(lbl_deleteAll);
            panel2.Controls.Add(PB_Delicon);
            panel2.Location = new Point(1051, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(111, 40);
            panel2.TabIndex = 33;
            // 
            // lbl_deleteAll
            // 
            lbl_deleteAll.AutoSize = true;
            lbl_deleteAll.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_deleteAll.ForeColor = Color.FromArgb(108, 117, 125);
            lbl_deleteAll.Location = new Point(32, 6);
            lbl_deleteAll.Name = "lbl_deleteAll";
            lbl_deleteAll.Size = new Size(79, 28);
            lbl_deleteAll.TabIndex = 28;
            lbl_deleteAll.Text = "Xóa hết";
            // 
            // PB_Delicon
            // 
            PB_Delicon.Image = (Image)resources.GetObject("PB_Delicon.Image");
            PB_Delicon.Location = new Point(3, 3);
            PB_Delicon.Name = "PB_Delicon";
            PB_Delicon.Size = new Size(32, 34);
            PB_Delicon.TabIndex = 24;
            PB_Delicon.TabStop = false;
            // 
            // AdminAddingComboFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 619);
            Controls.Add(panel2);
            Controls.Add(lbl_Food);
            Controls.Add(metroTile1);
            Controls.Add(btn_AddingFood);
            Controls.Add(btn_Signout);
            Controls.Add(flp_Hienthimonan);
            Controls.Add(panel_monan_1);
            Controls.Add(metroPanel1);
            Name = "AdminAddingComboFood";
            Load += AdminAddingComboFood_Load;
            metroPanel1.ResumeLayout(false);
            metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_AccountIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_Delicon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Label lbl_AccountName;
        private PictureBox pb_AccountIcon;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private CustomControls.RoundedButton btn_UpdateFood;
        private CustomControls.RoundedButton btn_LockFood;
        private CustomControls.RoundedButton btn_AddFood;
        private CustomControls.RoundedButton btn_AddComboFood;
        private PictureBox pb_Logo;
        private FlowLayoutPanel panel_monan_1;
        private FlowLayoutPanel flp_Hienthimonan;
        private CustomControls.RoundedButton btn_Signout;
        private CustomControls.RoundedButton btn_AddingFood;
        private MetroFramework.Controls.MetroTile metroTile1;
        private Label lbl_Food;
        private Panel panel2;
        private Label lbl_deleteAll;
        private PictureBox PB_Delicon;
    }
}