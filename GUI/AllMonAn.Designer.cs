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
            btn_Beverage = new RoundedButton();
            btn_Snack = new RoundedButton();
            btn_Vegetable = new RoundedButton();
            btn_SavouryFood = new RoundedButton();
            btn_Hotpot = new RoundedButton();
            pictureBox1 = new PictureBox();
            tile_blacklayout = new MetroFramework.Controls.MetroTile();
            lbl_priceshow = new Label();
            btn_AccountForm = new RoundedButton();
            btn_SignOut = new RoundedButton();
            btn_Cart = new RoundedButton();
            panel_monan_1 = new FlowLayoutPanel();
            btn_ConfirmFoodChange = new RoundedButton();
            btn_PaymentChange = new RoundedButton();
            metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tile_blacklayout.SuspendLayout();
            SuspendLayout();
            // 
            // metroPanel1
            // 
            metroPanel1.Controls.Add(metroPanel7);
            metroPanel1.Controls.Add(btn_Beverage);
            metroPanel1.Controls.Add(btn_Snack);
            metroPanel1.Controls.Add(btn_Vegetable);
            metroPanel1.Controls.Add(btn_SavouryFood);
            metroPanel1.Controls.Add(btn_Hotpot);
            metroPanel1.Controls.Add(pictureBox1);
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(0, 32);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(262, 597);
            metroPanel1.TabIndex = 15;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
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
            // btn_Beverage
            // 
            btn_Beverage.BackColor = Color.White;
            btn_Beverage.BackgroundColor = Color.White;
            btn_Beverage.BorderColor = Color.FromArgb(0, 0, 15, 255);
            btn_Beverage.BorderRadius = 0;
            btn_Beverage.BorderSize = 0;
            btn_Beverage.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_Beverage.FlatStyle = FlatStyle.Flat;
            btn_Beverage.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Beverage.ForeColor = Color.FromArgb(160, 159, 159);
            btn_Beverage.Location = new Point(-2, 307);
            btn_Beverage.Margin = new Padding(3, 4, 3, 4);
            btn_Beverage.Name = "btn_Beverage";
            btn_Beverage.Size = new Size(264, 64);
            btn_Beverage.TabIndex = 19;
            btn_Beverage.Text = "Đồ uống";
            btn_Beverage.TextColor = Color.FromArgb(160, 159, 159);
            btn_Beverage.UseVisualStyleBackColor = false;
            btn_Beverage.Click += btn_Beverage_Click;
            // 
            // btn_Snack
            // 
            btn_Snack.BackColor = Color.White;
            btn_Snack.BackgroundColor = Color.White;
            btn_Snack.BorderColor = Color.FromArgb(0, 0, 15, 255);
            btn_Snack.BorderRadius = 0;
            btn_Snack.BorderSize = 0;
            btn_Snack.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_Snack.FlatStyle = FlatStyle.Flat;
            btn_Snack.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Snack.ForeColor = Color.FromArgb(160, 159, 159);
            btn_Snack.Location = new Point(0, 243);
            btn_Snack.Margin = new Padding(3, 4, 3, 4);
            btn_Snack.Name = "btn_Snack";
            btn_Snack.Size = new Size(264, 64);
            btn_Snack.TabIndex = 18;
            btn_Snack.Text = "Đồ ăn vặt";
            btn_Snack.TextColor = Color.FromArgb(160, 159, 159);
            btn_Snack.UseVisualStyleBackColor = false;
            btn_Snack.Click += btn_Snack_Click;
            // 
            // btn_Vegetable
            // 
            btn_Vegetable.BackColor = Color.White;
            btn_Vegetable.BackgroundColor = Color.White;
            btn_Vegetable.BorderColor = Color.FromArgb(0, 0, 15, 255);
            btn_Vegetable.BorderRadius = 0;
            btn_Vegetable.BorderSize = 0;
            btn_Vegetable.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_Vegetable.FlatStyle = FlatStyle.Flat;
            btn_Vegetable.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Vegetable.ForeColor = Color.FromArgb(160, 159, 159);
            btn_Vegetable.Location = new Point(0, 184);
            btn_Vegetable.Margin = new Padding(3, 4, 3, 4);
            btn_Vegetable.Name = "btn_Vegetable";
            btn_Vegetable.Size = new Size(264, 64);
            btn_Vegetable.TabIndex = 17;
            btn_Vegetable.Text = "Món rau";
            btn_Vegetable.TextColor = Color.FromArgb(160, 159, 159);
            btn_Vegetable.UseVisualStyleBackColor = false;
            btn_Vegetable.Click += btn_Vegetable_Click;
            // 
            // btn_SavouryFood
            // 
            btn_SavouryFood.BackColor = Color.FromArgb(229, 1, 17);
            btn_SavouryFood.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_SavouryFood.BorderColor = Color.FromArgb(0, 0, 15, 255);
            btn_SavouryFood.BorderRadius = 0;
            btn_SavouryFood.BorderSize = 0;
            btn_SavouryFood.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_SavouryFood.FlatStyle = FlatStyle.Flat;
            btn_SavouryFood.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_SavouryFood.ForeColor = Color.White;
            btn_SavouryFood.Location = new Point(0, 126);
            btn_SavouryFood.Margin = new Padding(3, 4, 3, 4);
            btn_SavouryFood.Name = "btn_SavouryFood";
            btn_SavouryFood.Size = new Size(262, 60);
            btn_SavouryFood.TabIndex = 16;
            btn_SavouryFood.Text = "Món mặn";
            btn_SavouryFood.TextColor = Color.White;
            btn_SavouryFood.UseVisualStyleBackColor = false;
            btn_SavouryFood.Click += btn_SavouryFood_Click;
            // 
            // btn_Hotpot
            // 
            btn_Hotpot.BackColor = Color.White;
            btn_Hotpot.BackgroundColor = Color.White;
            btn_Hotpot.BorderColor = Color.PaleVioletRed;
            btn_Hotpot.BorderRadius = 0;
            btn_Hotpot.BorderSize = 0;
            btn_Hotpot.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_Hotpot.FlatStyle = FlatStyle.Flat;
            btn_Hotpot.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Hotpot.ForeColor = Color.FromArgb(160, 159, 159);
            btn_Hotpot.Location = new Point(0, 71);
            btn_Hotpot.Margin = new Padding(3, 4, 3, 4);
            btn_Hotpot.Name = "btn_Hotpot";
            btn_Hotpot.Size = new Size(262, 56);
            btn_Hotpot.TabIndex = 16;
            btn_Hotpot.Text = "Lẩu";
            btn_Hotpot.TextColor = Color.FromArgb(160, 159, 159);
            btn_Hotpot.UseVisualStyleBackColor = false;
            btn_Hotpot.Click += btn_Hotpot_Click;
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
            // tile_blacklayout
            // 
            tile_blacklayout.ActiveControl = null;
            tile_blacklayout.BackColor = Color.Black;
            tile_blacklayout.Controls.Add(lbl_priceshow);
            tile_blacklayout.FlatAppearance.BorderColor = Color.Black;
            tile_blacklayout.FlatAppearance.MouseDownBackColor = Color.Black;
            tile_blacklayout.FlatAppearance.MouseOverBackColor = Color.Black;
            tile_blacklayout.FlatStyle = FlatStyle.Flat;
            tile_blacklayout.Location = new Point(259, 602);
            tile_blacklayout.Name = "tile_blacklayout";
            tile_blacklayout.PaintTileCount = false;
            tile_blacklayout.Size = new Size(753, 66);
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
            lbl_priceshow.Location = new Point(490, 18);
            lbl_priceshow.Name = "lbl_priceshow";
            lbl_priceshow.Size = new Size(254, 25);
            lbl_priceshow.TabIndex = 0;
            lbl_priceshow.Text = "0đ";
            lbl_priceshow.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_AccountForm
            // 
            btn_AccountForm.BackColor = Color.FromArgb(229, 1, 17);
            btn_AccountForm.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_AccountForm.BorderColor = Color.PaleVioletRed;
            btn_AccountForm.BorderRadius = 8;
            btn_AccountForm.BorderSize = 0;
            btn_AccountForm.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_AccountForm.FlatStyle = FlatStyle.Flat;
            btn_AccountForm.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AccountForm.ForeColor = Color.White;
            btn_AccountForm.Location = new Point(954, 27);
            btn_AccountForm.Margin = new Padding(3, 4, 3, 4);
            btn_AccountForm.Name = "btn_AccountForm";
            btn_AccountForm.Size = new Size(117, 35);
            btn_AccountForm.TabIndex = 18;
            btn_AccountForm.Text = "Tài khoản";
            btn_AccountForm.TextColor = Color.White;
            btn_AccountForm.UseVisualStyleBackColor = false;
            // 
            // btn_SignOut
            // 
            btn_SignOut.BackColor = Color.FromArgb(229, 1, 17);
            btn_SignOut.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_SignOut.BorderColor = Color.PaleVioletRed;
            btn_SignOut.BorderRadius = 8;
            btn_SignOut.BorderSize = 0;
            btn_SignOut.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_SignOut.FlatStyle = FlatStyle.Flat;
            btn_SignOut.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_SignOut.ForeColor = Color.White;
            btn_SignOut.Location = new Point(1077, 27);
            btn_SignOut.Margin = new Padding(3, 4, 3, 4);
            btn_SignOut.Name = "btn_SignOut";
            btn_SignOut.Size = new Size(117, 35);
            btn_SignOut.TabIndex = 21;
            btn_SignOut.Text = "Đăng xuất";
            btn_SignOut.TextColor = Color.White;
            btn_SignOut.UseVisualStyleBackColor = false;
            // 
            // btn_Cart
            // 
            btn_Cart.BackColor = Color.FromArgb(229, 1, 17);
            btn_Cart.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_Cart.BorderColor = Color.PaleVioletRed;
            btn_Cart.BorderRadius = 0;
            btn_Cart.BorderSize = 0;
            btn_Cart.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_Cart.FlatStyle = FlatStyle.Flat;
            btn_Cart.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cart.ForeColor = Color.White;
            btn_Cart.Location = new Point(1009, 602);
            btn_Cart.Margin = new Padding(3, 4, 3, 4);
            btn_Cart.Name = "btn_Cart";
            btn_Cart.Size = new Size(207, 60);
            btn_Cart.TabIndex = 21;
            btn_Cart.Text = "Giỏ hàng";
            btn_Cart.TextColor = Color.White;
            btn_Cart.UseVisualStyleBackColor = false;
            btn_Cart.Click += btn_Cart_Click;
            // 
            // panel_monan_1
            // 
            panel_monan_1.AutoScroll = true;
            panel_monan_1.Location = new Point(268, 103);
            panel_monan_1.Name = "panel_monan_1";
            panel_monan_1.Size = new Size(935, 493);
            panel_monan_1.TabIndex = 22;
            // 
            // btn_ConfirmFoodChange
            // 
            btn_ConfirmFoodChange.BackColor = Color.FromArgb(229, 1, 17);
            btn_ConfirmFoodChange.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_ConfirmFoodChange.BorderColor = Color.PaleVioletRed;
            btn_ConfirmFoodChange.BorderRadius = 8;
            btn_ConfirmFoodChange.BorderSize = 0;
            btn_ConfirmFoodChange.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_ConfirmFoodChange.FlatStyle = FlatStyle.Flat;
            btn_ConfirmFoodChange.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ConfirmFoodChange.ForeColor = Color.White;
            btn_ConfirmFoodChange.Location = new Point(778, 27);
            btn_ConfirmFoodChange.Margin = new Padding(3, 4, 3, 4);
            btn_ConfirmFoodChange.Name = "btn_ConfirmFoodChange";
            btn_ConfirmFoodChange.Size = new Size(159, 35);
            btn_ConfirmFoodChange.TabIndex = 23;
            btn_ConfirmFoodChange.Text = "Xác Nhận Món";
            btn_ConfirmFoodChange.TextColor = Color.White;
            btn_ConfirmFoodChange.UseVisualStyleBackColor = false;
            btn_ConfirmFoodChange.Click += btn_ComfirmFoodChange_Click;
            // 
            // btn_PaymentChange
            // 
            btn_PaymentChange.BackColor = Color.FromArgb(229, 1, 17);
            btn_PaymentChange.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_PaymentChange.BorderColor = Color.PaleVioletRed;
            btn_PaymentChange.BorderRadius = 8;
            btn_PaymentChange.BorderSize = 0;
            btn_PaymentChange.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_PaymentChange.FlatStyle = FlatStyle.Flat;
            btn_PaymentChange.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_PaymentChange.ForeColor = Color.White;
            btn_PaymentChange.Location = new Point(628, 27);
            btn_PaymentChange.Margin = new Padding(3, 4, 3, 4);
            btn_PaymentChange.Name = "btn_PaymentChange";
            btn_PaymentChange.Size = new Size(126, 35);
            btn_PaymentChange.TabIndex = 24;
            btn_PaymentChange.Text = "Thanh toán";
            btn_PaymentChange.TextColor = Color.White;
            btn_PaymentChange.UseVisualStyleBackColor = false;
            btn_PaymentChange.Click += btn_Payment_Click;
            // 
            // AllMonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 660);
            Controls.Add(btn_PaymentChange);
            Controls.Add(btn_ConfirmFoodChange);
            Controls.Add(panel_monan_1);
            Controls.Add(btn_Cart);
            Controls.Add(btn_SignOut);
            Controls.Add(btn_AccountForm);
            Controls.Add(tile_blacklayout);
            Controls.Add(metroPanel1);
            Name = "AllMonAn";
            Style = MetroFramework.MetroColorStyle.White;
            metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tile_blacklayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private PictureBox pictureBox1;
        private RoundedButton btn_Beverage;
        private RoundedButton btn_Snack;
        private RoundedButton btn_Vegetable;
        private RoundedButton btn_SavouryFood;
        private RoundedButton btn_Hotpot;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private MetroFramework.Controls.MetroTile tile_blacklayout;
        private RoundedButton btn_AccountForm;
        private RoundedButton btn_SignOut;
        private RoundedButton btn_Cart;
        private FlowLayoutPanel panel_monan_1;
        private Label lbl_priceshow;
        private RoundedButton btn_ComfirmFoodChange;
        private RoundedButton btn_Payment;
        private RoundedButton btn_ConfirmFoodChange;
        private RoundedButton btn_PaymentChange;
    }
}