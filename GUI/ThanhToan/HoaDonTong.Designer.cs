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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lbl_AccountName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_paymentDetail = new System.Windows.Forms.Label();
            this.lbl_idbill = new System.Windows.Forms.Label();
            this.lbl_billidvalue = new System.Windows.Forms.Label();
            this.lbl_totalMoney = new System.Windows.Forms.Label();
            this.lbl_TotalMoneyValue = new System.Windows.Forms.Label();
            this.lbl_orderedDishesList = new System.Windows.Forms.Label();
            this.lbl_food = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.flp_showDetailMon = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_confirm = new WinFormsApp2.CustomControls.RoundedButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lbl_AccountName);
            this.metroPanel1.Controls.Add(this.pictureBox2);
            this.metroPanel1.Controls.Add(this.metroPanel7);
            this.metroPanel1.Controls.Add(this.pb_Logo);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 17);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(261, 722);
            this.metroPanel1.TabIndex = 20;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lbl_AccountName
            // 
            this.lbl_AccountName.AutoSize = true;
            this.lbl_AccountName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AccountName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.lbl_AccountName.Location = new System.Drawing.Point(70, 86);
            this.lbl_AccountName.Name = "lbl_AccountName";
            this.lbl_AccountName.Size = new System.Drawing.Size(138, 28);
            this.lbl_AccountName.TabIndex = 31;
            this.lbl_AccountName.Text = "Tên tài khoản";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 26);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // metroPanel7
            // 
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
            // lbl_paymentDetail
            // 
            this.lbl_paymentDetail.AutoSize = true;
            this.lbl_paymentDetail.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_paymentDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.lbl_paymentDetail.Location = new System.Drawing.Point(289, 17);
            this.lbl_paymentDetail.Name = "lbl_paymentDetail";
            this.lbl_paymentDetail.Size = new System.Drawing.Size(250, 37);
            this.lbl_paymentDetail.TabIndex = 34;
            this.lbl_paymentDetail.Text = "Chi tiết thanh toán";
            // 
            // lbl_idbill
            // 
            this.lbl_idbill.AutoSize = true;
            this.lbl_idbill.BackColor = System.Drawing.Color.White;
            this.lbl_idbill.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_idbill.ForeColor = System.Drawing.Color.Black;
            this.lbl_idbill.Location = new System.Drawing.Point(299, 80);
            this.lbl_idbill.Name = "lbl_idbill";
            this.lbl_idbill.Size = new System.Drawing.Size(143, 29);
            this.lbl_idbill.TabIndex = 35;
            this.lbl_idbill.Text = "Mã hóa đơn:";
            this.lbl_idbill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_billidvalue
            // 
            this.lbl_billidvalue.AutoSize = true;
            this.lbl_billidvalue.BackColor = System.Drawing.Color.White;
            this.lbl_billidvalue.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_billidvalue.ForeColor = System.Drawing.Color.Black;
            this.lbl_billidvalue.Location = new System.Drawing.Point(461, 80);
            this.lbl_billidvalue.Name = "lbl_billidvalue";
            this.lbl_billidvalue.Size = new System.Drawing.Size(147, 29);
            this.lbl_billidvalue.TabIndex = 36;
            this.lbl_billidvalue.Text = "Giá trị mã bill";
            this.lbl_billidvalue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_billidvalue.Click += new System.EventHandler(this.lbl_billidvalue_Click);
            // 
            // lbl_totalMoney
            // 
            this.lbl_totalMoney.AutoSize = true;
            this.lbl_totalMoney.BackColor = System.Drawing.Color.White;
            this.lbl_totalMoney.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_totalMoney.ForeColor = System.Drawing.Color.Black;
            this.lbl_totalMoney.Location = new System.Drawing.Point(299, 142);
            this.lbl_totalMoney.Name = "lbl_totalMoney";
            this.lbl_totalMoney.Size = new System.Drawing.Size(115, 29);
            this.lbl_totalMoney.TabIndex = 37;
            this.lbl_totalMoney.Text = "Tổng Tiền:";
            this.lbl_totalMoney.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_TotalMoneyValue
            // 
            this.lbl_TotalMoneyValue.AutoSize = true;
            this.lbl_TotalMoneyValue.BackColor = System.Drawing.Color.White;
            this.lbl_TotalMoneyValue.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalMoneyValue.ForeColor = System.Drawing.Color.Black;
            this.lbl_TotalMoneyValue.Location = new System.Drawing.Point(431, 142);
            this.lbl_TotalMoneyValue.Name = "lbl_TotalMoneyValue";
            this.lbl_TotalMoneyValue.Size = new System.Drawing.Size(177, 29);
            this.lbl_TotalMoneyValue.TabIndex = 38;
            this.lbl_TotalMoneyValue.Text = "Giá Trị Tổng Tiền";
            this.lbl_TotalMoneyValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_orderedDishesList
            // 
            this.lbl_orderedDishesList.AutoSize = true;
            this.lbl_orderedDishesList.BackColor = System.Drawing.Color.White;
            this.lbl_orderedDishesList.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_orderedDishesList.ForeColor = System.Drawing.Color.Black;
            this.lbl_orderedDishesList.Location = new System.Drawing.Point(299, 210);
            this.lbl_orderedDishesList.Name = "lbl_orderedDishesList";
            this.lbl_orderedDishesList.Size = new System.Drawing.Size(237, 29);
            this.lbl_orderedDishesList.TabIndex = 39;
            this.lbl_orderedDishesList.Text = "Danh sách món đã đặt";
            this.lbl_orderedDishesList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_food
            // 
            this.lbl_food.AutoSize = true;
            this.lbl_food.BackColor = System.Drawing.Color.White;
            this.lbl_food.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_food.ForeColor = System.Drawing.Color.Black;
            this.lbl_food.Location = new System.Drawing.Point(338, 274);
            this.lbl_food.Name = "lbl_food";
            this.lbl_food.Size = new System.Drawing.Size(90, 29);
            this.lbl_food.TabIndex = 40;
            this.lbl_food.Text = "Món ăn";
            this.lbl_food.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.BackColor = System.Drawing.Color.White;
            this.lbl_quantity.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_quantity.ForeColor = System.Drawing.Color.Black;
            this.lbl_quantity.Location = new System.Drawing.Point(752, 274);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(103, 29);
            this.lbl_quantity.TabIndex = 41;
            this.lbl_quantity.Text = "Số lượng";
            this.lbl_quantity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.BackColor = System.Drawing.Color.White;
            this.lbl_price.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_price.ForeColor = System.Drawing.Color.Black;
            this.lbl_price.Location = new System.Drawing.Point(1206, 274);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(94, 29);
            this.lbl_price.TabIndex = 42;
            this.lbl_price.Text = "Giá Tiền";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flp_showDetailMon
            // 
            this.flp_showDetailMon.AutoScroll = true;
            this.flp_showDetailMon.Location = new System.Drawing.Point(299, 318);
            this.flp_showDetailMon.Name = "flp_showDetailMon";
            this.flp_showDetailMon.Size = new System.Drawing.Size(1063, 377);
            this.flp_showDetailMon.TabIndex = 43;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_confirm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_confirm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_confirm.BorderRadius = 8;
            this.btn_confirm.BorderSize = 0;
            this.btn_confirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.Location = new System.Drawing.Point(1224, 727);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(138, 35);
            this.btn_confirm.TabIndex = 44;
            this.btn_confirm.Text = "Xác Nhận";
            this.btn_confirm.TextColor = System.Drawing.Color.White;
            this.btn_confirm.UseVisualStyleBackColor = false;
            // 
            // HoaDonTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 786);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.flp_showDetailMon);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_food);
            this.Controls.Add(this.lbl_orderedDishesList);
            this.Controls.Add(this.lbl_TotalMoneyValue);
            this.Controls.Add(this.lbl_totalMoney);
            this.Controls.Add(this.lbl_billidvalue);
            this.Controls.Add(this.lbl_idbill);
            this.Controls.Add(this.lbl_paymentDetail);
            this.Controls.Add(this.metroPanel1);
            this.Name = "HoaDonTong";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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