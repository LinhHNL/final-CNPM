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
            this.btn_AccountForm = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_SignOut = new WinFormsApp2.CustomControls.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_Back = new System.Windows.Forms.Label();
            this.lbl_mySelections = new System.Windows.Forms.Label();
            this.lbl_Dish = new System.Windows.Forms.Label();
            this.PB_Delicon = new System.Windows.Forms.PictureBox();
            this.lbl_DeleteAll = new System.Windows.Forms.Label();
            this.flp_Hienthimonan = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.btn_Order = new WinFormsApp2.CustomControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Delicon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AccountForm
            // 
            this.btn_AccountForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_AccountForm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_AccountForm.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_AccountForm.BorderRadius = 8;
            this.btn_AccountForm.BorderSize = 0;
            this.btn_AccountForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_AccountForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AccountForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AccountForm.ForeColor = System.Drawing.Color.White;
            this.btn_AccountForm.Location = new System.Drawing.Point(762, 35);
            this.btn_AccountForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AccountForm.Name = "btn_AccountForm";
            this.btn_AccountForm.Size = new System.Drawing.Size(117, 35);
            this.btn_AccountForm.TabIndex = 19;
            this.btn_AccountForm.Text = "Tài khoản";
            this.btn_AccountForm.TextColor = System.Drawing.Color.White;
            this.btn_AccountForm.UseVisualStyleBackColor = false;
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_SignOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_SignOut.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_SignOut.BorderRadius = 8;
            this.btn_SignOut.BorderSize = 0;
            this.btn_SignOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_SignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SignOut.ForeColor = System.Drawing.Color.White;
            this.btn_SignOut.Location = new System.Drawing.Point(902, 35);
            this.btn_SignOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(117, 35);
            this.btn_SignOut.TabIndex = 22;
            this.btn_SignOut.Text = "Đăng xuất";
            this.btn_SignOut.TextColor = System.Drawing.Color.White;
            this.btn_SignOut.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btn_Back);
            this.metroPanel1.Controls.Add(this.lbl_mySelections);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-2, 91);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1045, 52);
            this.metroPanel1.TabIndex = 24;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Back.Location = new System.Drawing.Point(877, 11);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(143, 28);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Quay lại >";
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_mySelections
            // 
            this.lbl_mySelections.AutoSize = true;
            this.lbl_mySelections.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_mySelections.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.lbl_mySelections.Location = new System.Drawing.Point(24, 9);
            this.lbl_mySelections.Name = "lbl_mySelections";
            this.lbl_mySelections.Size = new System.Drawing.Size(203, 32);
            this.lbl_mySelections.TabIndex = 2;
            this.lbl_mySelections.Text = "Món ăn tôi chọn";
            // 
            // lbl_Dish
            // 
            this.lbl_Dish.AutoSize = true;
            this.lbl_Dish.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lbl_Dish.Location = new System.Drawing.Point(23, 157);
            this.lbl_Dish.Name = "lbl_Dish";
            this.lbl_Dish.Size = new System.Drawing.Size(79, 28);
            this.lbl_Dish.TabIndex = 26;
            this.lbl_Dish.Text = "Món ăn";
            // 
            // PB_Delicon
            // 
            this.PB_Delicon.Image = ((System.Drawing.Image)(resources.GetObject("PB_Delicon.Image")));
            this.PB_Delicon.Location = new System.Drawing.Point(902, 157);
            this.PB_Delicon.Name = "PB_Delicon";
            this.PB_Delicon.Size = new System.Drawing.Size(32, 34);
            this.PB_Delicon.TabIndex = 24;
            this.PB_Delicon.TabStop = false;
            // 
            // lbl_DeleteAll
            // 
            this.lbl_DeleteAll.AutoSize = true;
            this.lbl_DeleteAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DeleteAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lbl_DeleteAll.Location = new System.Drawing.Point(940, 157);
            this.lbl_DeleteAll.Name = "lbl_DeleteAll";
            this.lbl_DeleteAll.Size = new System.Drawing.Size(79, 28);
            this.lbl_DeleteAll.TabIndex = 28;
            this.lbl_DeleteAll.Text = "Xóa hết";
            // 
            // flp_Hienthimonan
            // 
            this.flp_Hienthimonan.AutoScroll = true;
            this.flp_Hienthimonan.Location = new System.Drawing.Point(-2, 203);
            this.flp_Hienthimonan.Name = "flp_Hienthimonan";
            this.flp_Hienthimonan.Size = new System.Drawing.Size(1045, 289);
            this.flp_Hienthimonan.TabIndex = 28;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.lbl_Total.Location = new System.Drawing.Point(23, 513);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(124, 32);
            this.lbl_Total.TabIndex = 3;
            this.lbl_Total.Text = "Tổng tiền";
            // 
            // lbl_Price
            // 
            this.lbl_Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Price.Location = new System.Drawing.Point(374, 504);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(433, 50);
            this.lbl_Price.TabIndex = 29;
            this.lbl_Price.Text = "Giá tiền";
            this.lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Order
            // 
            this.btn_Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Order.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Order.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Order.BorderRadius = 8;
            this.btn_Order.BorderSize = 0;
            this.btn_Order.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Order.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Order.ForeColor = System.Drawing.Color.White;
            this.btn_Order.Location = new System.Drawing.Point(835, 504);
            this.btn_Order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(184, 55);
            this.btn_Order.TabIndex = 20;
            this.btn_Order.Text = "Đặt món ăn";
            this.btn_Order.TextColor = System.Drawing.Color.White;
            this.btn_Order.UseVisualStyleBackColor = false;
            // 
            // ShoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 565);
            this.Controls.Add(this.lbl_DeleteAll);
            this.Controls.Add(this.PB_Delicon);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.flp_Hienthimonan);
            this.Controls.Add(this.lbl_Dish);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_SignOut);
            this.Controls.Add(this.btn_AccountForm);
            this.Name = "ShoppingCartForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Delicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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