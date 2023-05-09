namespace WinFormsApp2.AdminPage
{
    partial class UpdateFoodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateFoodForm));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lbl_AccountName = new System.Windows.Forms.Label();
            this.pb_AccountIcon = new System.Windows.Forms.PictureBox();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.btn_UpdateFood = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_LockFood = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_AddFood = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_AddComboFood = new WinFormsApp2.CustomControls.RoundedButton();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.btn_Signout = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_addPicture = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_PictueLabel = new System.Windows.Forms.Label();
            this.UploadPlaceBox = new System.Windows.Forms.PictureBox();
            this.cb_TypeofFood = new WinFormsApp2.CustomControls.CustomComboBox();
            this.btn_ChooseDish = new WinFormsApp2.CustomControls.RoundedButton();
            this.tb_Price = new WinFormsApp2.CustomControls.LeftAlignRoundedTextBox();
            this.tb_NameOfFood = new WinFormsApp2.CustomControls.LeftAlignRoundedTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AccountIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UploadPlaceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lbl_AccountName);
            this.metroPanel1.Controls.Add(this.pb_AccountIcon);
            this.metroPanel1.Controls.Add(this.metroPanel7);
            this.metroPanel1.Controls.Add(this.btn_UpdateFood);
            this.metroPanel1.Controls.Add(this.btn_LockFood);
            this.metroPanel1.Controls.Add(this.btn_AddFood);
            this.metroPanel1.Controls.Add(this.btn_AddComboFood);
            this.metroPanel1.Controls.Add(this.pb_Logo);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 37);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(259, 552);
            this.metroPanel1.TabIndex = 17;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lbl_AccountName
            // 
            this.lbl_AccountName.AutoSize = true;
            this.lbl_AccountName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AccountName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.lbl_AccountName.Location = new System.Drawing.Point(69, 82);
            this.lbl_AccountName.Name = "lbl_AccountName";
            this.lbl_AccountName.Size = new System.Drawing.Size(138, 28);
            this.lbl_AccountName.TabIndex = 33;
            this.lbl_AccountName.Text = "Tên tài khoản";
            // 
            // pb_AccountIcon
            // 
            this.pb_AccountIcon.Image = ((System.Drawing.Image)(resources.GetObject("pb_AccountIcon.Image")));
            this.pb_AccountIcon.Location = new System.Drawing.Point(33, 84);
            this.pb_AccountIcon.Name = "pb_AccountIcon";
            this.pb_AccountIcon.Size = new System.Drawing.Size(30, 26);
            this.pb_AccountIcon.TabIndex = 32;
            this.pb_AccountIcon.TabStop = false;
            // 
            // metroPanel7
            // 
<<<<<<< HEAD
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
            // roundedButton7
            // 
            roundedButton7.BackColor = Color.White;
            roundedButton7.BackgroundColor = Color.White;
            roundedButton7.BorderColor = Color.FromArgb(0, 0, 15, 255);
            roundedButton7.BorderRadius = 0;
            roundedButton7.BorderSize = 0;
            roundedButton7.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            roundedButton7.FlatStyle = FlatStyle.Flat;
            roundedButton7.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton7.ForeColor = Color.FromArgb(160, 159, 159);
            roundedButton7.Location = new Point(-1, 302);
            roundedButton7.Margin = new Padding(3, 4, 3, 4);
            roundedButton7.Name = "roundedButton7";
            roundedButton7.Size = new Size(263, 64);
            roundedButton7.TabIndex = 18;
            roundedButton7.Text = "Cập nhật món ăn";
            roundedButton7.TextColor = Color.FromArgb(160, 159, 159);
            roundedButton7.UseVisualStyleBackColor = false;
            // 
            // roundedButton6
            // 
            roundedButton6.BackColor = Color.White;
            roundedButton6.BackgroundColor = Color.White;
            roundedButton6.BorderColor = Color.FromArgb(0, 0, 15, 255);
            roundedButton6.BorderRadius = 0;
            roundedButton6.BorderSize = 0;
            roundedButton6.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            roundedButton6.FlatStyle = FlatStyle.Flat;
            roundedButton6.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton6.ForeColor = Color.FromArgb(160, 159, 159);
            roundedButton6.Location = new Point(-1, 243);
            roundedButton6.Margin = new Padding(3, 4, 3, 4);
            roundedButton6.Name = "roundedButton6";
            roundedButton6.Size = new Size(264, 64);
            roundedButton6.TabIndex = 17;
            roundedButton6.Text = "Khóa món ăn";
            roundedButton6.TextColor = Color.FromArgb(160, 159, 159);
            roundedButton6.UseVisualStyleBackColor = false;
            // 
            // roundedButton5
            // 
            roundedButton5.BackColor = Color.FromArgb(229, 1, 17);
            roundedButton5.BackgroundColor = Color.FromArgb(229, 1, 17);
            roundedButton5.BorderColor = Color.FromArgb(0, 0, 15, 255);
            roundedButton5.BorderRadius = 0;
            roundedButton5.BorderSize = 0;
            roundedButton5.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            roundedButton5.FlatStyle = FlatStyle.Flat;
            roundedButton5.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton5.ForeColor = Color.White;
            roundedButton5.Location = new Point(0, 130);
            roundedButton5.Margin = new Padding(3, 4, 3, 4);
            roundedButton5.Name = "roundedButton5";
            roundedButton5.Size = new Size(262, 60);
            roundedButton5.TabIndex = 16;
            roundedButton5.Text = "Thêm món ăn";
            roundedButton5.TextColor = Color.White;
            roundedButton5.UseVisualStyleBackColor = false;
            // 
            // roundedButton4
            // 
            roundedButton4.BackColor = Color.FromArgb(0, 0, 15, 255);
            roundedButton4.BackgroundColor = Color.FromArgb(0, 0, 15, 255);
            roundedButton4.BorderColor = Color.PaleVioletRed;
            roundedButton4.BorderRadius = 0;
            roundedButton4.BorderSize = 0;
            roundedButton4.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            roundedButton4.FlatStyle = FlatStyle.Flat;
            roundedButton4.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton4.ForeColor = Color.FromArgb(160, 159, 159);
            roundedButton4.Location = new Point(0, 189);
            roundedButton4.Margin = new Padding(3, 4, 3, 4);
            roundedButton4.Name = "roundedButton4";
            roundedButton4.Size = new Size(262, 56);
            roundedButton4.TabIndex = 16;
            roundedButton4.Text = "Thêm combo món ăn";
            roundedButton4.TextColor = Color.FromArgb(160, 159, 159);
            roundedButton4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
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
            roundedButton10.Location = new Point(1042, 37);
            roundedButton10.Margin = new Padding(3, 4, 3, 4);
            roundedButton10.Name = "roundedButton10";
            roundedButton10.Size = new Size(117, 35);
            roundedButton10.TabIndex = 22;
            roundedButton10.Text = "Đăng xuất";
            roundedButton10.TextColor = Color.White;
            roundedButton10.UseVisualStyleBackColor = false;
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
            btn_addPicture.Location = new Point(311, 108);
            btn_addPicture.Name = "btn_addPicture";
            btn_addPicture.Size = new Size(400, 400);
            btn_addPicture.TabIndex = 23;
            btn_addPicture.TextColor = SystemColors.WindowText;
            btn_addPicture.UseVisualStyleBackColor = false;
            // 
            // btn_placeholderlabel
            // 
            btn_placeholderlabel.AutoSize = true;
            btn_placeholderlabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_placeholderlabel.Location = new Point(432, 280);
            btn_placeholderlabel.Name = "btn_placeholderlabel";
            btn_placeholderlabel.Size = new Size(157, 32);
            btn_placeholderlabel.TabIndex = 24;
            btn_placeholderlabel.Text = "+ Thêm ảnh ";
            btn_placeholderlabel.Click += btn_placeholderlabel_Click;
            // 
            // UploadPlaceBox
            // 
            UploadPlaceBox.Location = new Point(311, 108);
            UploadPlaceBox.Name = "UploadPlaceBox";
            UploadPlaceBox.Size = new Size(400, 399);
            UploadPlaceBox.TabIndex = 29;
            UploadPlaceBox.TabStop = false;
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
            cb_TypeofFood.TabIndex = 34;
            cb_TypeofFood.Texts = "Loại món ăn";
=======
            this.metroPanel7.BackColor = System.Drawing.Color.Black;
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 10;
            this.metroPanel7.Location = new System.Drawing.Point(259, 539);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(904, 55);
            this.metroPanel7.TabIndex = 20;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 10;
>>>>>>> 8d249ced943f806d153ec3e35ac6189216f94312
            // 
            // btn_UpdateFood
            // 
            this.btn_UpdateFood.BackColor = System.Drawing.Color.White;
            this.btn_UpdateFood.BackgroundColor = System.Drawing.Color.White;
            this.btn_UpdateFood.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_UpdateFood.BorderRadius = 0;
            this.btn_UpdateFood.BorderSize = 0;
            this.btn_UpdateFood.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_UpdateFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateFood.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_UpdateFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_UpdateFood.Location = new System.Drawing.Point(-1, 302);
            this.btn_UpdateFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_UpdateFood.Name = "btn_UpdateFood";
            this.btn_UpdateFood.Size = new System.Drawing.Size(263, 64);
            this.btn_UpdateFood.TabIndex = 18;
            this.btn_UpdateFood.Text = "Cập nhật món ăn";
            this.btn_UpdateFood.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_UpdateFood.UseVisualStyleBackColor = false;
            this.btn_UpdateFood.Click += new System.EventHandler(this.btn_UpdateFood_Click);
            // 
            // btn_LockFood
            // 
            this.btn_LockFood.BackColor = System.Drawing.Color.White;
            this.btn_LockFood.BackgroundColor = System.Drawing.Color.White;
            this.btn_LockFood.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_LockFood.BorderRadius = 0;
            this.btn_LockFood.BorderSize = 0;
            this.btn_LockFood.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_LockFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LockFood.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_LockFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_LockFood.Location = new System.Drawing.Point(-1, 243);
            this.btn_LockFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LockFood.Name = "btn_LockFood";
            this.btn_LockFood.Size = new System.Drawing.Size(264, 64);
            this.btn_LockFood.TabIndex = 17;
            this.btn_LockFood.Text = "Khóa món ăn";
            this.btn_LockFood.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_LockFood.UseVisualStyleBackColor = false;
            this.btn_LockFood.Click += new System.EventHandler(this.btn_LockFood_Click);
            // 
            // btn_AddFood
            // 
            this.btn_AddFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_AddFood.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_AddFood.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_AddFood.BorderRadius = 0;
            this.btn_AddFood.BorderSize = 0;
            this.btn_AddFood.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_AddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddFood.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AddFood.ForeColor = System.Drawing.Color.White;
            this.btn_AddFood.Location = new System.Drawing.Point(0, 130);
            this.btn_AddFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddFood.Name = "btn_AddFood";
            this.btn_AddFood.Size = new System.Drawing.Size(262, 60);
            this.btn_AddFood.TabIndex = 16;
            this.btn_AddFood.Text = "Thêm món ăn";
            this.btn_AddFood.TextColor = System.Drawing.Color.White;
            this.btn_AddFood.UseVisualStyleBackColor = false;
            this.btn_AddFood.Click += new System.EventHandler(this.btn_AddFood_Click);
            // 
            // btn_AddComboFood
            // 
            this.btn_AddComboFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_AddComboFood.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_AddComboFood.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_AddComboFood.BorderRadius = 0;
            this.btn_AddComboFood.BorderSize = 0;
            this.btn_AddComboFood.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_AddComboFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddComboFood.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AddComboFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_AddComboFood.Location = new System.Drawing.Point(0, 189);
            this.btn_AddComboFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddComboFood.Name = "btn_AddComboFood";
            this.btn_AddComboFood.Size = new System.Drawing.Size(262, 56);
            this.btn_AddComboFood.TabIndex = 16;
            this.btn_AddComboFood.Text = "Thêm combo món ăn";
            this.btn_AddComboFood.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_AddComboFood.UseVisualStyleBackColor = false;
            this.btn_AddComboFood.Click += new System.EventHandler(this.btn_AddComboFood_Click);
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(100, 14);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(50, 50);
            this.pb_Logo.TabIndex = 16;
            this.pb_Logo.TabStop = false;
            // 
            // btn_Signout
            // 
            this.btn_Signout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Signout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Signout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Signout.BorderRadius = 8;
            this.btn_Signout.BorderSize = 0;
            this.btn_Signout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Signout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Signout.ForeColor = System.Drawing.Color.White;
            this.btn_Signout.Location = new System.Drawing.Point(1042, 37);
            this.btn_Signout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Signout.Name = "btn_Signout";
            this.btn_Signout.Size = new System.Drawing.Size(117, 35);
            this.btn_Signout.TabIndex = 22;
            this.btn_Signout.Text = "Đăng xuất";
            this.btn_Signout.TextColor = System.Drawing.Color.White;
            this.btn_Signout.UseVisualStyleBackColor = false;
            // 
            // btn_addPicture
            // 
            this.btn_addPicture.BackColor = System.Drawing.Color.Transparent;
            this.btn_addPicture.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_addPicture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_addPicture.BorderRadius = 0;
            this.btn_addPicture.BorderSize = 3;
            this.btn_addPicture.FlatAppearance.BorderSize = 0;
            this.btn_addPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addPicture.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_addPicture.Location = new System.Drawing.Point(311, 108);
            this.btn_addPicture.Name = "btn_addPicture";
            this.btn_addPicture.Size = new System.Drawing.Size(400, 400);
            this.btn_addPicture.TabIndex = 23;
            this.btn_addPicture.TextColor = System.Drawing.SystemColors.WindowText;
            this.btn_addPicture.UseVisualStyleBackColor = false;
            // 
            // btn_PictueLabel
            // 
            this.btn_PictueLabel.AutoSize = true;
            this.btn_PictueLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_PictueLabel.Location = new System.Drawing.Point(432, 280);
            this.btn_PictueLabel.Name = "btn_PictueLabel";
            this.btn_PictueLabel.Size = new System.Drawing.Size(157, 32);
            this.btn_PictueLabel.TabIndex = 24;
            this.btn_PictueLabel.Text = "+ Thêm ảnh ";
            // 
            // UploadPlaceBox
            // 
            this.UploadPlaceBox.Location = new System.Drawing.Point(311, 108);
            this.UploadPlaceBox.Name = "UploadPlaceBox";
            this.UploadPlaceBox.Size = new System.Drawing.Size(400, 399);
            this.UploadPlaceBox.TabIndex = 29;
            this.UploadPlaceBox.TabStop = false;
            // 
            // cb_TypeofFood
            // 
            this.cb_TypeofFood.BackColor = System.Drawing.Color.White;
            this.cb_TypeofFood.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cb_TypeofFood.BorderSize = 1;
            this.cb_TypeofFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cb_TypeofFood.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_TypeofFood.ForeColor = System.Drawing.Color.DimGray;
            this.cb_TypeofFood.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cb_TypeofFood.ListBackColor = System.Drawing.Color.White;
            this.cb_TypeofFood.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cb_TypeofFood.Location = new System.Drawing.Point(738, 337);
            this.cb_TypeofFood.MinimumSize = new System.Drawing.Size(200, 30);
            this.cb_TypeofFood.Name = "cb_TypeofFood";
            this.cb_TypeofFood.Padding = new System.Windows.Forms.Padding(1);
            this.cb_TypeofFood.Size = new System.Drawing.Size(421, 49);
            this.cb_TypeofFood.TabIndex = 34;
            this.cb_TypeofFood.Texts = "Loại món ăn";
            // 
            // btn_ChooseDish
            // 
            this.btn_ChooseDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_ChooseDish.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_ChooseDish.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ChooseDish.BorderRadius = 8;
            this.btn_ChooseDish.BorderSize = 0;
            this.btn_ChooseDish.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_ChooseDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChooseDish.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ChooseDish.ForeColor = System.Drawing.Color.White;
            this.btn_ChooseDish.Location = new System.Drawing.Point(876, 419);
            this.btn_ChooseDish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ChooseDish.Name = "btn_ChooseDish";
            this.btn_ChooseDish.Size = new System.Drawing.Size(151, 35);
            this.btn_ChooseDish.TabIndex = 33;
            this.btn_ChooseDish.Text = "Chọn món ăn";
            this.btn_ChooseDish.TextColor = System.Drawing.Color.White;
            this.btn_ChooseDish.UseVisualStyleBackColor = false;
            //this.btn_ChooseDish.Click += new System.EventHandler(this.btn_ChooseDish_Click);
            // 
            // tb_Price
            // 
            this.tb_Price.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Price.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tb_Price.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_Price.BorderRadius = 0;
            this.tb_Price.BorderSize = 1;
            this.tb_Price.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Price.Location = new System.Drawing.Point(738, 254);
            this.tb_Price.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Price.Multiline = false;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Price.PasswordChar = false;
            this.tb_Price.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_Price.PlaceholderText = "Giá tiền";
            this.tb_Price.ReadOnly = false;
            this.tb_Price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_Price.Size = new System.Drawing.Size(421, 43);
            this.tb_Price.TabIndex = 32;
            this.tb_Price.Texts = "";
            this.tb_Price.UnderlinedStyle = false;
            // 
            // tb_NameOfFood
            // 
            this.tb_NameOfFood.BackColor = System.Drawing.SystemColors.Window;
            this.tb_NameOfFood.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tb_NameOfFood.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_NameOfFood.BorderRadius = 0;
            this.tb_NameOfFood.BorderSize = 1;
            this.tb_NameOfFood.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_NameOfFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_NameOfFood.Location = new System.Drawing.Point(738, 167);
            this.tb_NameOfFood.Margin = new System.Windows.Forms.Padding(4);
            this.tb_NameOfFood.Multiline = false;
            this.tb_NameOfFood.Name = "tb_NameOfFood";
            this.tb_NameOfFood.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_NameOfFood.PasswordChar = false;
            this.tb_NameOfFood.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_NameOfFood.PlaceholderText = "Tên món ăn";
            this.tb_NameOfFood.ReadOnly = false;
            this.tb_NameOfFood.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_NameOfFood.Size = new System.Drawing.Size(421, 43);
            this.tb_NameOfFood.TabIndex = 31;
            this.tb_NameOfFood.Texts = "";
            this.tb_NameOfFood.UnderlinedStyle = false;
            // 
            // UpdateFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 605);
            this.Controls.Add(this.cb_TypeofFood);
            this.Controls.Add(this.btn_ChooseDish);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.tb_NameOfFood);
            this.Controls.Add(this.btn_PictueLabel);
            this.Controls.Add(this.btn_addPicture);
            this.Controls.Add(this.btn_Signout);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.UploadPlaceBox);
            this.Name = "UpdateFoodForm";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AccountIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UploadPlaceBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private PictureBox UploadPlaceBox;
        private CustomControls.CustomComboBox cb_TypeofFood;
        private CustomControls.RoundedButton btn_ChooseDish;
        private CustomControls.LeftAlignRoundedTextBox tb_Price;
        private CustomControls.LeftAlignRoundedTextBox tb_NameOfFood;
        private Label lbl_AccountName;
        private PictureBox pb_AccountIcon;
    }
}