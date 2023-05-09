using WinFormsApp2.CustomControls;

namespace WinFormsApp2
{
    partial class AllMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllMonAn));
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            metroPanel7 = new MetroFramework.Controls.MetroPanel();
            roundedButton8 = new RoundedButton();
            roundedButton7 = new RoundedButton();
            roundedButton6 = new RoundedButton();
            roundedButton5 = new RoundedButton();
            roundedButton4 = new RoundedButton();
            pictureBox1 = new PictureBox();
            tile_blacklayout = new MetroFramework.Controls.MetroTile();
            lbl_priceshow = new Label();
            btn_signInForm = new RoundedButton();
            roundedButton10 = new RoundedButton();
            btn_ChangetoForm = new RoundedButton();
            panel_monan_1 = new FlowLayoutPanel();
            btn_ComfirmFoodChange = new RoundedButton();
            metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tile_blacklayout.SuspendLayout();
            SuspendLayout();
            // 
            // metroPanel1
            // 
            metroPanel1.Controls.Add(metroPanel7);
            metroPanel1.Controls.Add(roundedButton8);
            metroPanel1.Controls.Add(roundedButton7);
            metroPanel1.Controls.Add(roundedButton6);
            metroPanel1.Controls.Add(roundedButton5);
            metroPanel1.Controls.Add(roundedButton4);
            metroPanel1.Controls.Add(pictureBox1);
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 8;
            metroPanel1.Location = new Point(0, 24);
            metroPanel1.Margin = new Padding(3, 2, 3, 2);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(229, 448);
            metroPanel1.TabIndex = 15;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 9;
            // 
            // metroPanel7
            // 
            metroPanel7.BackColor = Color.Black;
            metroPanel7.HorizontalScrollbarBarColor = true;
            metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel7.HorizontalScrollbarSize = 8;
            metroPanel7.Location = new Point(227, 404);
            metroPanel7.Margin = new Padding(3, 2, 3, 2);
            metroPanel7.Name = "metroPanel7";
            metroPanel7.Size = new Size(791, 41);
            metroPanel7.TabIndex = 20;
            metroPanel7.VerticalScrollbarBarColor = true;
            metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            metroPanel7.VerticalScrollbarSize = 9;
            // 
            // roundedButton8
            // 
            roundedButton8.BackColor = Color.White;
            roundedButton8.BackgroundColor = Color.White;
            roundedButton8.BorderColor = Color.FromArgb(0, 0, 15, 255);
            roundedButton8.BorderRadius = 0;
            roundedButton8.BorderSize = 0;
            roundedButton8.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            roundedButton8.FlatStyle = FlatStyle.Flat;
            roundedButton8.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton8.ForeColor = Color.FromArgb(160, 159, 159);
            roundedButton8.Location = new Point(-2, 230);
            roundedButton8.Name = "roundedButton8";
            roundedButton8.Size = new Size(231, 48);
            roundedButton8.TabIndex = 19;
            roundedButton8.Text = "Đồ uống";
            roundedButton8.TextColor = Color.FromArgb(160, 159, 159);
            roundedButton8.UseVisualStyleBackColor = false;
            roundedButton8.Click += roundedButton8_Click;
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
            roundedButton7.Location = new Point(0, 182);
            roundedButton7.Name = "roundedButton7";
            roundedButton7.Size = new Size(231, 48);
            roundedButton7.TabIndex = 18;
            roundedButton7.Text = "Đồ ăn vặt";
            roundedButton7.TextColor = Color.FromArgb(160, 159, 159);
            roundedButton7.UseVisualStyleBackColor = false;
            roundedButton7.Click += roundedButton7_Click;
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
            roundedButton6.Location = new Point(0, 138);
            roundedButton6.Name = "roundedButton6";
            roundedButton6.Size = new Size(231, 48);
            roundedButton6.TabIndex = 17;
            roundedButton6.Text = "Món rau";
            roundedButton6.TextColor = Color.FromArgb(160, 159, 159);
            roundedButton6.UseVisualStyleBackColor = false;
            roundedButton6.Click += roundedButton6_Click;
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
            roundedButton5.Location = new Point(0, 94);
            roundedButton5.Name = "roundedButton5";
            roundedButton5.Size = new Size(229, 45);
            roundedButton5.TabIndex = 16;
            roundedButton5.Text = "Món mặn";
            roundedButton5.TextColor = Color.White;
            roundedButton5.UseVisualStyleBackColor = false;
            roundedButton5.Click += roundedButton5_Click;
            // 
            // roundedButton4
            // 
            roundedButton4.BackColor = Color.White;
            roundedButton4.BackgroundColor = Color.White;
            roundedButton4.BorderColor = Color.PaleVioletRed;
            roundedButton4.BorderRadius = 0;
            roundedButton4.BorderSize = 0;
            roundedButton4.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            roundedButton4.FlatStyle = FlatStyle.Flat;
            roundedButton4.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton4.ForeColor = Color.FromArgb(160, 159, 159);
            roundedButton4.Location = new Point(0, 53);
            roundedButton4.Name = "roundedButton4";
            roundedButton4.Size = new Size(229, 42);
            roundedButton4.TabIndex = 16;
            roundedButton4.Text = "Lẩu";
            roundedButton4.TextColor = Color.FromArgb(160, 159, 159);
            roundedButton4.UseVisualStyleBackColor = false;
            roundedButton4.Click += roundedButton4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(88, 10);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 38);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // tile_blacklayout
            // 
            tile_blacklayout.ActiveControl = null;
            tile_blacklayout.BackColor = Color.Black;
            tile_blacklayout.Controls.Add(lbl_priceshow);
            tile_blacklayout.FlatAppearance.BorderColor = Color.Black;
            tile_blacklayout.FlatAppearance.MouseDownBackColor = Color.Black;
            tile_blacklayout.FlatAppearance.MouseOverBackColor = Color.Black;
            tile_blacklayout.FlatStyle = FlatStyle.Flat;
            tile_blacklayout.Location = new Point(227, 452);
            tile_blacklayout.Margin = new Padding(3, 2, 3, 2);
            tile_blacklayout.Name = "tile_blacklayout";
            tile_blacklayout.PaintTileCount = false;
            tile_blacklayout.Size = new Size(659, 50);
            tile_blacklayout.Style = MetroFramework.MetroColorStyle.Black;
            tile_blacklayout.TabIndex = 20;
            tile_blacklayout.Theme = MetroFramework.MetroThemeStyle.Dark;
            tile_blacklayout.UseCustomBackColor = true;
            tile_blacklayout.UseSelectable = true;
            tile_blacklayout.UseStyleColors = true;
            tile_blacklayout.UseVisualStyleBackColor = false;
            // 
            // lbl_priceshow
            // 
            lbl_priceshow.BackColor = Color.Black;
            lbl_priceshow.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_priceshow.ForeColor = Color.White;
            lbl_priceshow.Location = new Point(429, 14);
            lbl_priceshow.Name = "lbl_priceshow";
            lbl_priceshow.Size = new Size(222, 19);
            lbl_priceshow.TabIndex = 0;
            lbl_priceshow.Text = "0đ";
            lbl_priceshow.TextAlign = ContentAlignment.MiddleRight;
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
            btn_signInForm.Location = new Point(835, 34);
            btn_signInForm.Name = "btn_signInForm";
            btn_signInForm.Size = new Size(102, 26);
            btn_signInForm.TabIndex = 18;
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
            roundedButton10.Location = new Point(942, 34);
            roundedButton10.Name = "roundedButton10";
            roundedButton10.Size = new Size(102, 26);
            roundedButton10.TabIndex = 21;
            roundedButton10.Text = "Đăng xuất";
            roundedButton10.TextColor = Color.White;
            roundedButton10.UseVisualStyleBackColor = false;
            // 
            // btn_ChangetoForm
            // 
            btn_ChangetoForm.BackColor = Color.FromArgb(229, 1, 17);
            btn_ChangetoForm.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_ChangetoForm.BorderColor = Color.PaleVioletRed;
            btn_ChangetoForm.BorderRadius = 0;
            btn_ChangetoForm.BorderSize = 0;
            btn_ChangetoForm.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_ChangetoForm.FlatStyle = FlatStyle.Flat;
            btn_ChangetoForm.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ChangetoForm.ForeColor = Color.White;
            btn_ChangetoForm.Location = new Point(883, 452);
            btn_ChangetoForm.Name = "btn_ChangetoForm";
            btn_ChangetoForm.Size = new Size(181, 45);
            btn_ChangetoForm.TabIndex = 21;
            btn_ChangetoForm.Text = "Giỏ hàng";
            btn_ChangetoForm.TextColor = Color.White;
            btn_ChangetoForm.UseVisualStyleBackColor = false;
            btn_ChangetoForm.Click += btn_ChangetoForm_Click;
            // 
            // panel_monan_1
            // 
            panel_monan_1.AutoScroll = true;
            panel_monan_1.Location = new Point(234, 77);
            panel_monan_1.Margin = new Padding(3, 2, 3, 2);
            panel_monan_1.Name = "panel_monan_1";
            panel_monan_1.Size = new Size(818, 370);
            panel_monan_1.TabIndex = 22;
            panel_monan_1.Paint += panel_monan_1_Paint;
            // 
            // btn_ComfirmFoodChange
            // 
            btn_ComfirmFoodChange.BackColor = Color.FromArgb(229, 1, 17);
            btn_ComfirmFoodChange.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_ComfirmFoodChange.BorderColor = Color.PaleVioletRed;
            btn_ComfirmFoodChange.BorderRadius = 8;
            btn_ComfirmFoodChange.BorderSize = 0;
            btn_ComfirmFoodChange.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_ComfirmFoodChange.FlatStyle = FlatStyle.Flat;
            btn_ComfirmFoodChange.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ComfirmFoodChange.ForeColor = Color.White;
            btn_ComfirmFoodChange.Location = new Point(704, 34);
            btn_ComfirmFoodChange.Name = "btn_ComfirmFoodChange";
            btn_ComfirmFoodChange.Size = new Size(125, 26);
            btn_ComfirmFoodChange.TabIndex = 37;
            btn_ComfirmFoodChange.Text = "Xác Nhận Món";
            btn_ComfirmFoodChange.TextColor = Color.White;
            btn_ComfirmFoodChange.UseVisualStyleBackColor = false;
            // 
            // AllMonAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 495);
            Controls.Add(btn_ComfirmFoodChange);
            Controls.Add(panel_monan_1);
            Controls.Add(btn_ChangetoForm);
            Controls.Add(roundedButton10);
            Controls.Add(btn_signInForm);
            Controls.Add(tile_blacklayout);
            Controls.Add(metroPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AllMonAn";
            Padding = new Padding(18, 45, 18, 15);
            Style = MetroFramework.MetroColorStyle.White;
            Load += MonAn_Load_1;
            metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tile_blacklayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private PictureBox pictureBox1;
        private RoundedButton roundedButton8;
        private RoundedButton roundedButton7;
        private RoundedButton roundedButton6;
        private RoundedButton roundedButton5;
        private RoundedButton roundedButton4;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private MetroFramework.Controls.MetroTile tile_blacklayout;
        private RoundedButton btn_signInForm;
        private RoundedButton roundedButton10;
        private RoundedButton btn_ChangetoForm;
        private FlowLayoutPanel panel_monan_1;
        private Label lbl_priceshow;
        private RoundedButton btn_ComfirmFoodChange;
    }
}