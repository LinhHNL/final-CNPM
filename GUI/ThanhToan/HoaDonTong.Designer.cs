namespace GUI.ThanhToan
{
    partial class HoaDonTong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonTong));
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            lbl_AccountName = new Label();
            pictureBox2 = new PictureBox();
            metroPanel7 = new MetroFramework.Controls.MetroPanel();
            pb_Logo = new PictureBox();
            lbl_paymentDetail = new Label();
            lbl_idbill = new Label();
            lbl_billidvalue = new Label();
            lbl_totalMoney = new Label();
            lbl_TotalMoneyValue = new Label();
            lbl_orderedDishesList = new Label();
            lbl_food = new Label();
            lbl_quantity = new Label();
            lbl_price = new Label();
            flp_showDetailMon = new FlowLayoutPanel();
            btn_confirm = new WinFormsApp2.CustomControls.RoundedButton();
            metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).BeginInit();
            SuspendLayout();
            // 
            // metroPanel1
            // 
            metroPanel1.Controls.Add(lbl_AccountName);
            metroPanel1.Controls.Add(pictureBox2);
            metroPanel1.Controls.Add(metroPanel7);
            metroPanel1.Controls.Add(pb_Logo);
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(0, 17);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(261, 722);
            metroPanel1.TabIndex = 20;
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(34, 88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 26);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
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
            // pb_Logo
            // 
            pb_Logo.Image = (Image)resources.GetObject("pb_Logo.Image");
            pb_Logo.Location = new Point(100, 14);
            pb_Logo.Name = "pb_Logo";
            pb_Logo.Size = new Size(50, 50);
            pb_Logo.TabIndex = 16;
            pb_Logo.TabStop = false;
            // 
            // lbl_paymentDetail
            // 
            lbl_paymentDetail.AutoSize = true;
            lbl_paymentDetail.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_paymentDetail.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_paymentDetail.Location = new Point(289, 17);
            lbl_paymentDetail.Name = "lbl_paymentDetail";
            lbl_paymentDetail.Size = new Size(250, 37);
            lbl_paymentDetail.TabIndex = 34;
            lbl_paymentDetail.Text = "Chi tiết thanh toán";
            // 
            // lbl_idbill
            // 
            lbl_idbill.AutoSize = true;
            lbl_idbill.BackColor = Color.White;
            lbl_idbill.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_idbill.ForeColor = Color.Black;
            lbl_idbill.Location = new Point(299, 80);
            lbl_idbill.Name = "lbl_idbill";
            lbl_idbill.Size = new Size(143, 29);
            lbl_idbill.TabIndex = 35;
            lbl_idbill.Text = "Mã hóa đơn:";
            lbl_idbill.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_billidvalue
            // 
            lbl_billidvalue.AutoSize = true;
            lbl_billidvalue.BackColor = Color.White;
            lbl_billidvalue.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_billidvalue.ForeColor = Color.Black;
            lbl_billidvalue.Location = new Point(461, 80);
            lbl_billidvalue.Name = "lbl_billidvalue";
            lbl_billidvalue.Size = new Size(147, 29);
            lbl_billidvalue.TabIndex = 36;
            lbl_billidvalue.Text = "Giá trị mã bill";
            lbl_billidvalue.TextAlign = ContentAlignment.TopCenter;
            lbl_billidvalue.Click += lbl_billidvalue_Click;
            // 
            // lbl_totalMoney
            // 
            lbl_totalMoney.AutoSize = true;
            lbl_totalMoney.BackColor = Color.White;
            lbl_totalMoney.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_totalMoney.ForeColor = Color.Black;
            lbl_totalMoney.Location = new Point(299, 142);
            lbl_totalMoney.Name = "lbl_totalMoney";
            lbl_totalMoney.Size = new Size(115, 29);
            lbl_totalMoney.TabIndex = 37;
            lbl_totalMoney.Text = "Tổng Tiền:";
            lbl_totalMoney.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_TotalMoneyValue
            // 
            lbl_TotalMoneyValue.AutoSize = true;
            lbl_TotalMoneyValue.BackColor = Color.White;
            lbl_TotalMoneyValue.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TotalMoneyValue.ForeColor = Color.Black;
            lbl_TotalMoneyValue.Location = new Point(431, 142);
            lbl_TotalMoneyValue.Name = "lbl_TotalMoneyValue";
            lbl_TotalMoneyValue.Size = new Size(177, 29);
            lbl_TotalMoneyValue.TabIndex = 38;
            lbl_TotalMoneyValue.Text = "Giá Trị Tổng Tiền";
            lbl_TotalMoneyValue.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_orderedDishesList
            // 
            lbl_orderedDishesList.AutoSize = true;
            lbl_orderedDishesList.BackColor = Color.White;
            lbl_orderedDishesList.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_orderedDishesList.ForeColor = Color.Black;
            lbl_orderedDishesList.Location = new Point(299, 210);
            lbl_orderedDishesList.Name = "lbl_orderedDishesList";
            lbl_orderedDishesList.Size = new Size(237, 29);
            lbl_orderedDishesList.TabIndex = 39;
            lbl_orderedDishesList.Text = "Danh sách món đã đặt";
            lbl_orderedDishesList.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_food
            // 
            lbl_food.AutoSize = true;
            lbl_food.BackColor = Color.White;
            lbl_food.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_food.ForeColor = Color.Black;
            lbl_food.Location = new Point(338, 274);
            lbl_food.Name = "lbl_food";
            lbl_food.Size = new Size(90, 29);
            lbl_food.TabIndex = 40;
            lbl_food.Text = "Món ăn";
            lbl_food.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_quantity
            // 
            lbl_quantity.AutoSize = true;
            lbl_quantity.BackColor = Color.White;
            lbl_quantity.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_quantity.ForeColor = Color.Black;
            lbl_quantity.Location = new Point(752, 274);
            lbl_quantity.Name = "lbl_quantity";
            lbl_quantity.Size = new Size(103, 29);
            lbl_quantity.TabIndex = 41;
            lbl_quantity.Text = "Số lượng";
            lbl_quantity.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_price
            // 
            lbl_price.AutoSize = true;
            lbl_price.BackColor = Color.White;
            lbl_price.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_price.ForeColor = Color.Black;
            lbl_price.Location = new Point(1206, 274);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(94, 29);
            lbl_price.TabIndex = 42;
            lbl_price.Text = "Giá Tiền";
            lbl_price.TextAlign = ContentAlignment.TopCenter;
            // 
            // flp_showDetailMon
            // 
            flp_showDetailMon.AutoScroll = true;
            flp_showDetailMon.Location = new Point(299, 318);
            flp_showDetailMon.Name = "flp_showDetailMon";
            flp_showDetailMon.Size = new Size(1063, 377);
            flp_showDetailMon.TabIndex = 43;
            // 
            // btn_confirm
            // 
            btn_confirm.BackColor = Color.FromArgb(229, 1, 17);
            btn_confirm.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_confirm.BorderColor = Color.PaleVioletRed;
            btn_confirm.BorderRadius = 8;
            btn_confirm.BorderSize = 0;
            btn_confirm.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_confirm.FlatStyle = FlatStyle.Flat;
            btn_confirm.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_confirm.ForeColor = Color.White;
            btn_confirm.Location = new Point(1224, 727);
            btn_confirm.Margin = new Padding(3, 4, 3, 4);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(138, 35);
            btn_confirm.TabIndex = 44;
            btn_confirm.Text = "Xác Nhận";
            btn_confirm.TextColor = Color.White;
            btn_confirm.UseVisualStyleBackColor = false;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // HoaDonTong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 786);
            Controls.Add(btn_confirm);
            Controls.Add(flp_showDetailMon);
            Controls.Add(lbl_price);
            Controls.Add(lbl_quantity);
            Controls.Add(lbl_food);
            Controls.Add(lbl_orderedDishesList);
            Controls.Add(lbl_TotalMoneyValue);
            Controls.Add(lbl_totalMoney);
            Controls.Add(lbl_billidvalue);
            Controls.Add(lbl_idbill);
            Controls.Add(lbl_paymentDetail);
            Controls.Add(metroPanel1);
            Name = "HoaDonTong";
            Load += HoaDonTong_Load;
            metroPanel1.ResumeLayout(false);
            metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Label lbl_AccountName;
        private PictureBox pictureBox2;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private PictureBox pb_Logo;
        private Label lbl_paymentDetail;
        private Label lbl_idbill;
        private Label lbl_billidvalue;
        private Label lbl_totalMoney;
        private Label lbl_TotalMoneyValue;
        private Label lbl_orderedDishesList;
        private Label lbl_food;
        private Label lbl_quantity;
        private Label lbl_price;
        private FlowLayoutPanel flp_showDetailMon;
        private WinFormsApp2.CustomControls.RoundedButton btn_confirm;
    }
}