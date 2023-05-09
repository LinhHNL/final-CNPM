namespace WinFormsApp2.AdminPage
{
    partial class AddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFood));
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
            btn_addPicture = new CustomControls.RoundedButton();
            btn_PictueLabel = new Label();
            tb_NameOfFood = new CustomControls.LeftAlignRoundedTextBox();
            tb_Price = new CustomControls.LeftAlignRoundedTextBox();
            btn_AddingFood = new CustomControls.RoundedButton();
            UploadPlaceBox = new PictureBox();
            cb_TypeofFood = new CustomControls.CustomComboBox();
            cb_RoomID = new CustomControls.CustomComboBox();
            metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_AccountIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UploadPlaceBox).BeginInit();
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
            lbl_AccountName.Location = new Point(70, 86);
            lbl_AccountName.Name = "lbl_AccountName";
            lbl_AccountName.Size = new Size(138, 28);
            lbl_AccountName.TabIndex = 31;
            lbl_AccountName.Text = "Tên tài khoản";
            // 
            // pb_AccountIcon
            // 
            pb_AccountIcon.Image = (Image)resources.GetObject("pb_AccountIcon.Image");
            pb_AccountIcon.Location = new Point(34, 88);
            pb_AccountIcon.Name = "pb_AccountIcon";
            pb_AccountIcon.Size = new Size(30, 26);
            pb_AccountIcon.TabIndex = 21;
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
            btn_UpdateFood.Location = new Point(-1, 302);
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
            btn_LockFood.BackColor = Color.White;
            btn_LockFood.BackgroundColor = Color.White;
            btn_LockFood.BorderColor = Color.FromArgb(0, 0, 15, 255);
            btn_LockFood.BorderRadius = 0;
            btn_LockFood.BorderSize = 0;
            btn_LockFood.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_LockFood.FlatStyle = FlatStyle.Flat;
            btn_LockFood.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_LockFood.ForeColor = Color.FromArgb(160, 159, 159);
            btn_LockFood.Location = new Point(-1, 243);
            btn_LockFood.Margin = new Padding(3, 4, 3, 4);
            btn_LockFood.Name = "btn_LockFood";
            btn_LockFood.Size = new Size(264, 64);
            btn_LockFood.TabIndex = 17;
            btn_LockFood.Text = "Khóa món ăn";
            btn_LockFood.TextColor = Color.FromArgb(160, 159, 159);
            btn_LockFood.UseVisualStyleBackColor = false;
            btn_LockFood.Click += btn_LockFood_Click;
            // 
            // btn_AddFood
            // 
            btn_AddFood.BackColor = Color.FromArgb(229, 1, 17);
            btn_AddFood.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_AddFood.BorderColor = Color.FromArgb(0, 0, 15, 255);
            btn_AddFood.BorderRadius = 0;
            btn_AddFood.BorderSize = 0;
            btn_AddFood.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_AddFood.FlatStyle = FlatStyle.Flat;
            btn_AddFood.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AddFood.ForeColor = Color.White;
            btn_AddFood.Location = new Point(0, 130);
            btn_AddFood.Margin = new Padding(3, 4, 3, 4);
            btn_AddFood.Name = "btn_AddFood";
            btn_AddFood.Size = new Size(262, 60);
            btn_AddFood.TabIndex = 16;
            btn_AddFood.Text = "Thêm món ăn";
            btn_AddFood.TextColor = Color.White;
            btn_AddFood.UseVisualStyleBackColor = false;
            btn_AddFood.Click += btn_AddFood_Click;
            // 
            // btn_AddComboFood
            // 
            btn_AddComboFood.BackColor = Color.White;
            btn_AddComboFood.BackgroundColor = Color.White;
            btn_AddComboFood.BorderColor = Color.PaleVioletRed;
            btn_AddComboFood.BorderRadius = 0;
            btn_AddComboFood.BorderSize = 0;
            btn_AddComboFood.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_AddComboFood.FlatStyle = FlatStyle.Flat;
            btn_AddComboFood.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AddComboFood.ForeColor = Color.FromArgb(160, 159, 159);
            btn_AddComboFood.Location = new Point(0, 189);
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
            // btn_addPicture
            // 
            btn_addPicture.BackColor = Color.Transparent;
            btn_addPicture.BackgroundColor = Color.Transparent;
            btn_addPicture.BorderColor = Color.FromArgb(33, 32, 32);
            btn_addPicture.BorderRadius = 0;
            btn_addPicture.BorderSize = 3;
            btn_addPicture.FlatAppearance.BorderSize = 0;
            btn_addPicture.FlatStyle = FlatStyle.Flat;
            btn_addPicture.ForeColor = SystemColors.WindowText;
            btn_addPicture.Location = new Point(311, 107);
            btn_addPicture.Name = "btn_addPicture";
            btn_addPicture.Size = new Size(400, 400);
            btn_addPicture.TabIndex = 23;
            btn_addPicture.TextColor = SystemColors.WindowText;
            btn_addPicture.UseVisualStyleBackColor = false;
            btn_addPicture.Click += btn_addPicture_Click;
            // 
            // btn_PictueLabel
            // 
            btn_PictueLabel.AutoSize = true;
            btn_PictueLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_PictueLabel.Location = new Point(432, 280);
            btn_PictueLabel.Name = "btn_PictueLabel";
            btn_PictueLabel.Size = new Size(157, 32);
            btn_PictueLabel.TabIndex = 24;
            btn_PictueLabel.Text = "+ Thêm ảnh ";
            // 
            // tb_NameOfFood
            // 
            tb_NameOfFood.BackColor = SystemColors.Window;
            tb_NameOfFood.BorderColor = Color.FromArgb(33, 32, 32);
            tb_NameOfFood.BorderFocusColor = Color.HotPink;
            tb_NameOfFood.BorderRadius = 0;
            tb_NameOfFood.BorderSize = 1;
            tb_NameOfFood.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_NameOfFood.ForeColor = Color.FromArgb(64, 64, 64);
            tb_NameOfFood.Location = new Point(738, 167);
            tb_NameOfFood.Margin = new Padding(4);
            tb_NameOfFood.Multiline = false;
            tb_NameOfFood.Name = "tb_NameOfFood";
            tb_NameOfFood.Padding = new Padding(10, 7, 10, 7);
            tb_NameOfFood.PasswordChar = false;
            tb_NameOfFood.PlaceholderColor = Color.DarkGray;
            tb_NameOfFood.PlaceholderText = "Tên món ăn";
            tb_NameOfFood.ReadOnly = false;
            tb_NameOfFood.RightToLeft = RightToLeft.No;
            tb_NameOfFood.Size = new Size(421, 43);
            tb_NameOfFood.TabIndex = 25;
            tb_NameOfFood.Texts = "";
            tb_NameOfFood.UnderlinedStyle = false;
            // 
            // tb_Price
            // 
            tb_Price.BackColor = SystemColors.Window;
            tb_Price.BorderColor = Color.FromArgb(33, 32, 32);
            tb_Price.BorderFocusColor = Color.HotPink;
            tb_Price.BorderRadius = 0;
            tb_Price.BorderSize = 1;
            tb_Price.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Price.ForeColor = Color.FromArgb(64, 64, 64);
            tb_Price.Location = new Point(738, 254);
            tb_Price.Margin = new Padding(4);
            tb_Price.Multiline = false;
            tb_Price.Name = "tb_Price";
            tb_Price.Padding = new Padding(10, 7, 10, 7);
            tb_Price.PasswordChar = false;
            tb_Price.PlaceholderColor = Color.DarkGray;
            tb_Price.PlaceholderText = "Giá tiền";
            tb_Price.ReadOnly = false;
            tb_Price.RightToLeft = RightToLeft.No;
            tb_Price.Size = new Size(421, 43);
            tb_Price.TabIndex = 26;
            tb_Price.Texts = "";
            tb_Price.UnderlinedStyle = false;
            // 
            // btn_AddingFood
            // 
            btn_AddingFood.BackColor = Color.FromArgb(229, 1, 17);
            btn_AddingFood.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_AddingFood.BorderColor = Color.PaleVioletRed;
            btn_AddingFood.BorderRadius = 8;
            btn_AddingFood.BorderSize = 0;
            btn_AddingFood.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_AddingFood.FlatStyle = FlatStyle.Flat;
            btn_AddingFood.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AddingFood.ForeColor = Color.White;
            btn_AddingFood.Location = new Point(915, 512);
            btn_AddingFood.Margin = new Padding(3, 4, 3, 4);
            btn_AddingFood.Name = "btn_AddingFood";
            btn_AddingFood.Size = new Size(117, 35);
            btn_AddingFood.TabIndex = 28;
            btn_AddingFood.Text = "Thêm";
            btn_AddingFood.TextColor = Color.White;
            btn_AddingFood.UseVisualStyleBackColor = false;
            btn_AddingFood.Click += btn_addingMenu_Click;
            // 
            // UploadPlaceBox
            // 
            UploadPlaceBox.Location = new Point(311, 108);
            UploadPlaceBox.Name = "UploadPlaceBox";
            UploadPlaceBox.Size = new Size(400, 399);
            UploadPlaceBox.TabIndex = 29;
            UploadPlaceBox.TabStop = false;
            UploadPlaceBox.Click += UploadPlaceBox_Click;
            // 
            // cb_TypeofFood
            // 
            cb_TypeofFood.BackColor = Color.White;
            cb_TypeofFood.BorderColor = Color.FromArgb(33, 32, 32);
            cb_TypeofFood.BorderSize = 1;
            cb_TypeofFood.DropDownStyle = ComboBoxStyle.DropDown;
            cb_TypeofFood.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cb_TypeofFood.ForeColor = Color.DimGray;
            cb_TypeofFood.IconColor = Color.FromArgb(33, 32, 32);
            cb_TypeofFood.ListBackColor = Color.White;
            cb_TypeofFood.ListTextColor = Color.FromArgb(33, 32, 32);
            cb_TypeofFood.Location = new Point(738, 337);
            cb_TypeofFood.MinimumSize = new Size(200, 30);
            cb_TypeofFood.Name = "cb_TypeofFood";
            cb_TypeofFood.Padding = new Padding(1);
            cb_TypeofFood.Size = new Size(421, 49);
            cb_TypeofFood.TabIndex = 30;
            cb_TypeofFood.Texts = "Loại món ăn";
            // 
            // cb_RoomID
            // 
            cb_RoomID.BackColor = Color.White;
            cb_RoomID.BorderColor = Color.FromArgb(33, 32, 32);
            cb_RoomID.BorderSize = 1;
            cb_RoomID.DropDownStyle = ComboBoxStyle.DropDown;
            cb_RoomID.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cb_RoomID.ForeColor = Color.DimGray;
            cb_RoomID.IconColor = Color.FromArgb(33, 32, 32);
            cb_RoomID.ListBackColor = Color.White;
            cb_RoomID.ListTextColor = Color.FromArgb(33, 32, 32);
            cb_RoomID.Location = new Point(738, 424);
            cb_RoomID.MinimumSize = new Size(200, 30);
            cb_RoomID.Name = "cb_RoomID";
            cb_RoomID.Padding = new Padding(1);
            cb_RoomID.Size = new Size(421, 49);
            cb_RoomID.TabIndex = 31;
            cb_RoomID.Texts = "Loại phòng đảm nhận";
            // 
            // AddFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 605);
            Controls.Add(cb_RoomID);
            Controls.Add(cb_TypeofFood);
            Controls.Add(btn_AddingFood);
            Controls.Add(tb_Price);
            Controls.Add(tb_NameOfFood);
            Controls.Add(btn_PictueLabel);
            Controls.Add(btn_addPicture);
            Controls.Add(btn_Signout);
            Controls.Add(metroPanel1);
            Controls.Add(UploadPlaceBox);
            Name = "AddFood";
            Load += AddFood_Load;
            metroPanel1.ResumeLayout(false);
            metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_AccountIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)UploadPlaceBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private CustomControls.RoundedButton btn_addPicture;
        private Label btn_PictueLabel;
        private CustomControls.LeftAlignRoundedTextBox tb_NameOfFood;
        private CustomControls.LeftAlignRoundedTextBox tb_Price;
        private CustomControls.RoundedButton btn_AddingFood;
        private PictureBox UploadPlaceBox;
        private CustomControls.CustomComboBox cb_TypeofFood;
        private PictureBox pb_AccountIcon;
        private Label lbl_AccountName;
        private CustomControls.CustomComboBox cb_RoomID;
    }
}