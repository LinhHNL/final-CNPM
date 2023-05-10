namespace WinFormsApp2
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
            btn_AccountForm = new CustomControls.RoundedButton();
            btn_SignOut = new CustomControls.RoundedButton();
            pictureBox1 = new PictureBox();
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            btn_Back = new Label();
            lbl_mySelections = new Label();
            lbl_Dish = new Label();
            PB_Delicon = new PictureBox();
            lbl_DeleteAll = new Label();
            flp_Hienthimonan = new FlowLayoutPanel();
            lbl_Total = new Label();
            lbl_Price = new Label();
            btn_Order = new CustomControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_Delicon).BeginInit();
            SuspendLayout();
            // 
            // btn_AccountForm
            // 
            btn_AccountForm.BackColor = Color.FromArgb(229, 1, 17);
            btn_AccountForm.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_AccountForm.BorderColor = Color.PaleGoldenrod;
            btn_AccountForm.BorderRadius = 8;
            btn_AccountForm.BorderSize = 0;
            btn_AccountForm.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_AccountForm.FlatStyle = FlatStyle.Flat;
            btn_AccountForm.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AccountForm.ForeColor = Color.White;
            btn_AccountForm.Location = new Point(762, 35);
            btn_AccountForm.Margin = new Padding(3, 4, 3, 4);
            btn_AccountForm.Name = "btn_AccountForm";
            btn_AccountForm.Size = new Size(117, 35);
            btn_AccountForm.TabIndex = 19;
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
            btn_SignOut.Location = new Point(902, 35);
            btn_SignOut.Margin = new Padding(3, 4, 3, 4);
            btn_SignOut.Name = "btn_SignOut";
            btn_SignOut.Size = new Size(117, 35);
            btn_SignOut.TabIndex = 22;
            btn_SignOut.Text = "Đăng xuất";
            btn_SignOut.TextColor = Color.White;
            btn_SignOut.UseVisualStyleBackColor = false;
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
            metroPanel1.Controls.Add(btn_Back);
            metroPanel1.Controls.Add(lbl_mySelections);
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
            // btn_Back
            // 
            btn_Back.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Back.ForeColor = Color.FromArgb(229, 1, 17);
            btn_Back.Location = new Point(877, 11);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(143, 28);
            btn_Back.TabIndex = 3;
            btn_Back.Text = "Quay lại >";
            btn_Back.TextAlign = ContentAlignment.MiddleRight;
            btn_Back.Click += lbl_returnplace_Click;
            // 
            // lbl_mySelections
            // 
            lbl_mySelections.AutoSize = true;
            lbl_mySelections.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_mySelections.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_mySelections.Location = new Point(24, 9);
            lbl_mySelections.Name = "lbl_mySelections";
            lbl_mySelections.Size = new Size(203, 32);
            lbl_mySelections.TabIndex = 2;
            lbl_mySelections.Text = "Món ăn tôi chọn";
            // 
            // lbl_Dish
            // 
            lbl_Dish.AutoSize = true;
            lbl_Dish.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Dish.ForeColor = Color.FromArgb(108, 117, 125);
            lbl_Dish.Location = new Point(23, 157);
            lbl_Dish.Name = "lbl_Dish";
            lbl_Dish.Size = new Size(79, 28);
            lbl_Dish.TabIndex = 26;
            lbl_Dish.Text = "Món ăn";
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
            // lbl_DeleteAll
            // 
            lbl_DeleteAll.AutoSize = true;
            lbl_DeleteAll.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DeleteAll.ForeColor = Color.FromArgb(108, 117, 125);
            lbl_DeleteAll.Location = new Point(940, 157);
            lbl_DeleteAll.Name = "lbl_DeleteAll";
            lbl_DeleteAll.Size = new Size(79, 28);
            lbl_DeleteAll.TabIndex = 28;
            lbl_DeleteAll.Text = "Xóa hết";
            lbl_DeleteAll.Click += lbl_deleteAll_Click;
            // 
            // flp_Hienthimonan
            // 
            flp_Hienthimonan.AutoScroll = true;
            flp_Hienthimonan.Location = new Point(-2, 203);
            flp_Hienthimonan.Name = "flp_Hienthimonan";
            flp_Hienthimonan.Size = new Size(1045, 289);
            flp_Hienthimonan.TabIndex = 28;
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Total.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_Total.Location = new Point(23, 513);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(124, 32);
            lbl_Total.TabIndex = 3;
            lbl_Total.Text = "Tổng tiền";
            // 
            // lbl_Price
            // 
            lbl_Price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Price.Location = new Point(374, 504);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new Size(433, 50);
            lbl_Price.TabIndex = 29;
            lbl_Price.Text = "Giá tiền";
            lbl_Price.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_Order
            // 
            btn_Order.BackColor = Color.FromArgb(229, 1, 17);
            btn_Order.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_Order.BorderColor = Color.PaleVioletRed;
            btn_Order.BorderRadius = 8;
            btn_Order.BorderSize = 0;
            btn_Order.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_Order.FlatStyle = FlatStyle.Flat;
            btn_Order.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Order.ForeColor = Color.White;
            btn_Order.Location = new Point(835, 504);
            btn_Order.Margin = new Padding(3, 4, 3, 4);
            btn_Order.Name = "btn_Order";
            btn_Order.Size = new Size(184, 55);
            btn_Order.TabIndex = 20;
            btn_Order.Text = "Đặt món ăn";
            btn_Order.TextColor = Color.White;
            btn_Order.UseVisualStyleBackColor = false;
            btn_Order.Click += btn_submitfood_Click;
            // 
            // ShoppingCartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 565);
            Controls.Add(lbl_DeleteAll);
            Controls.Add(PB_Delicon);
            Controls.Add(btn_Order);
            Controls.Add(lbl_Price);
            Controls.Add(lbl_Total);
            Controls.Add(flp_Hienthimonan);
            Controls.Add(lbl_Dish);
            Controls.Add(metroPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_SignOut);
            Controls.Add(btn_AccountForm);
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

        private CustomControls.RoundedButton btn_AccountForm;
        private CustomControls.RoundedButton btn_SignOut;
        private PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Label btn_Back;
        private Label lbl_mySelections;
        private Label lbl_Dish;
        private Label lbl_DeleteAll;
        private PictureBox PB_Delicon;
        private FlowLayoutPanel flp_Hienthimonan;
        private Label lbl_Total;
        private Label lbl_Price;
        private CustomControls.RoundedButton btn_Order;
    }
}