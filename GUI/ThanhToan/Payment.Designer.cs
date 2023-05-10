namespace GUI.ThanhToan
{
    partial class Payment
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
            lbl_paymentDetail = new Label();
            lbl_idbill = new Label();
            lbl_billidvalue = new Label();
            lbl_totalMoney = new Label();
            lbl_TotalMoneyValue = new Label();
            lbl_offer = new Label();
            cb_offerID = new WinFormsApp2.CustomControls.CustomComboBox();
            lbl_paymentMethod = new Label();
            cb_paymentMethod = new WinFormsApp2.CustomControls.CustomComboBox();
            btn_pay = new WinFormsApp2.CustomControls.RoundedButton();
            lbl_datePayment = new Label();
            lbl_DatePaymentValue = new Label();
            SuspendLayout();
            // 
            // lbl_paymentDetail
            // 
            lbl_paymentDetail.AutoSize = true;
            lbl_paymentDetail.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_paymentDetail.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_paymentDetail.Location = new Point(55, 30);
            lbl_paymentDetail.Name = "lbl_paymentDetail";
            lbl_paymentDetail.Size = new Size(250, 37);
            lbl_paymentDetail.TabIndex = 35;
            lbl_paymentDetail.Text = "Chi tiết thanh toán";
            // 
            // lbl_idbill
            // 
            lbl_idbill.AutoSize = true;
            lbl_idbill.BackColor = Color.White;
            lbl_idbill.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_idbill.ForeColor = Color.Black;
            lbl_idbill.Location = new Point(55, 94);
            lbl_idbill.Name = "lbl_idbill";
            lbl_idbill.Size = new Size(143, 29);
            lbl_idbill.TabIndex = 36;
            lbl_idbill.Text = "Mã hóa đơn:";
            lbl_idbill.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_billidvalue
            // 
            lbl_billidvalue.AutoSize = true;
            lbl_billidvalue.BackColor = Color.White;
            lbl_billidvalue.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_billidvalue.ForeColor = Color.Black;
            lbl_billidvalue.Location = new Point(675, 94);
            lbl_billidvalue.Name = "lbl_billidvalue";
            lbl_billidvalue.Size = new Size(147, 29);
            lbl_billidvalue.TabIndex = 37;
            lbl_billidvalue.Text = "Giá trị mã bill";
            lbl_billidvalue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_totalMoney
            // 
            lbl_totalMoney.AutoSize = true;
            lbl_totalMoney.BackColor = Color.White;
            lbl_totalMoney.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_totalMoney.ForeColor = Color.Black;
            lbl_totalMoney.Location = new Point(55, 146);
            lbl_totalMoney.Name = "lbl_totalMoney";
            lbl_totalMoney.Size = new Size(115, 29);
            lbl_totalMoney.TabIndex = 38;
            lbl_totalMoney.Text = "Tổng Tiền:";
            lbl_totalMoney.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_TotalMoneyValue
            // 
            lbl_TotalMoneyValue.AutoSize = true;
            lbl_TotalMoneyValue.BackColor = Color.White;
            lbl_TotalMoneyValue.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TotalMoneyValue.ForeColor = Color.Black;
            lbl_TotalMoneyValue.Location = new Point(645, 146);
            lbl_TotalMoneyValue.Name = "lbl_TotalMoneyValue";
            lbl_TotalMoneyValue.Size = new Size(177, 29);
            lbl_TotalMoneyValue.TabIndex = 39;
            lbl_TotalMoneyValue.Text = "Giá Trị Tổng Tiền";
            lbl_TotalMoneyValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_offer
            // 
            lbl_offer.AutoSize = true;
            lbl_offer.BackColor = Color.White;
            lbl_offer.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_offer.ForeColor = Color.Black;
            lbl_offer.Location = new Point(55, 257);
            lbl_offer.Name = "lbl_offer";
            lbl_offer.Size = new Size(81, 29);
            lbl_offer.TabIndex = 40;
            lbl_offer.Text = "Ưu Đãi";
            lbl_offer.TextAlign = ContentAlignment.TopCenter;
            // 
            // cb_offerID
            // 
            cb_offerID.BackColor = Color.WhiteSmoke;
            cb_offerID.BorderColor = Color.MediumSlateBlue;
            cb_offerID.BorderSize = 1;
            cb_offerID.DropDownStyle = ComboBoxStyle.DropDown;
            cb_offerID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_offerID.ForeColor = Color.DimGray;
            cb_offerID.IconColor = Color.MediumSlateBlue;
            cb_offerID.ListBackColor = Color.FromArgb(230, 228, 245);
            cb_offerID.ListTextColor = Color.DimGray;
            cb_offerID.Location = new Point(55, 311);
            cb_offerID.MinimumSize = new Size(200, 30);
            cb_offerID.Name = "cb_offerID";
            cb_offerID.Padding = new Padding(1);
            cb_offerID.Size = new Size(250, 38);
            cb_offerID.TabIndex = 41;
            cb_offerID.Texts = "Mã ưu đãi";
            // 
            // lbl_paymentMethod
            // 
            lbl_paymentMethod.AutoSize = true;
            lbl_paymentMethod.BackColor = Color.White;
            lbl_paymentMethod.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_paymentMethod.ForeColor = Color.Black;
            lbl_paymentMethod.Location = new Point(55, 389);
            lbl_paymentMethod.Name = "lbl_paymentMethod";
            lbl_paymentMethod.Size = new Size(261, 29);
            lbl_paymentMethod.TabIndex = 42;
            lbl_paymentMethod.Text = "Phương thức thanh toán";
            lbl_paymentMethod.TextAlign = ContentAlignment.TopCenter;
            // 
            // cb_paymentMethod
            // 
            cb_paymentMethod.BackColor = Color.WhiteSmoke;
            cb_paymentMethod.BorderColor = Color.MediumSlateBlue;
            cb_paymentMethod.BorderSize = 1;
            cb_paymentMethod.DropDownStyle = ComboBoxStyle.DropDown;
            cb_paymentMethod.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_paymentMethod.ForeColor = Color.DimGray;
            cb_paymentMethod.IconColor = Color.MediumSlateBlue;
            cb_paymentMethod.Items.AddRange(new object[] { "Tiền mặt" });
            cb_paymentMethod.ListBackColor = Color.FromArgb(230, 228, 245);
            cb_paymentMethod.ListTextColor = Color.DimGray;
            cb_paymentMethod.Location = new Point(55, 459);
            cb_paymentMethod.MinimumSize = new Size(200, 30);
            cb_paymentMethod.Name = "cb_paymentMethod";
            cb_paymentMethod.Padding = new Padding(1);
            cb_paymentMethod.Size = new Size(250, 38);
            cb_paymentMethod.TabIndex = 43;
            cb_paymentMethod.Texts = "Phương thức thanh toán";
            // 
            // btn_pay
            // 
            btn_pay.BackColor = Color.FromArgb(229, 1, 17);
            btn_pay.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_pay.BorderColor = Color.PaleVioletRed;
            btn_pay.BorderRadius = 8;
            btn_pay.BorderSize = 0;
            btn_pay.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_pay.FlatStyle = FlatStyle.Flat;
            btn_pay.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_pay.ForeColor = Color.White;
            btn_pay.Location = new Point(684, 532);
            btn_pay.Margin = new Padding(3, 4, 3, 4);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(138, 35);
            btn_pay.TabIndex = 45;
            btn_pay.Text = "Thanh toán";
            btn_pay.TextColor = Color.White;
            btn_pay.UseVisualStyleBackColor = false;
            btn_pay.Click += btn_InsertTransaction_Click;
            // 
            // lbl_datePayment
            // 
            lbl_datePayment.AutoSize = true;
            lbl_datePayment.BackColor = Color.White;
            lbl_datePayment.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_datePayment.ForeColor = Color.Black;
            lbl_datePayment.Location = new Point(55, 198);
            lbl_datePayment.Name = "lbl_datePayment";
            lbl_datePayment.Size = new Size(185, 29);
            lbl_datePayment.TabIndex = 46;
            lbl_datePayment.Text = "Ngày thanh toán:";
            lbl_datePayment.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_DatePaymentValue
            // 
            lbl_DatePaymentValue.AutoSize = true;
            lbl_DatePaymentValue.BackColor = Color.White;
            lbl_DatePaymentValue.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DatePaymentValue.ForeColor = Color.Black;
            lbl_DatePaymentValue.Location = new Point(581, 198);
            lbl_DatePaymentValue.Name = "lbl_DatePaymentValue";
            lbl_DatePaymentValue.Size = new Size(241, 29);
            lbl_DatePaymentValue.TabIndex = 47;
            lbl_DatePaymentValue.Text = "Giá trị ngày thanh toán";
            lbl_DatePaymentValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 591);
            Controls.Add(lbl_DatePaymentValue);
            Controls.Add(lbl_datePayment);
            Controls.Add(btn_pay);
            Controls.Add(cb_paymentMethod);
            Controls.Add(lbl_paymentMethod);
            Controls.Add(cb_offerID);
            Controls.Add(lbl_offer);
            Controls.Add(lbl_TotalMoneyValue);
            Controls.Add(lbl_totalMoney);
            Controls.Add(lbl_billidvalue);
            Controls.Add(lbl_idbill);
            Controls.Add(lbl_paymentDetail);
            Name = "Payment";
            Load += Payment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_paymentDetail;
        private Label lbl_idbill;
        private Label lbl_billidvalue;
        private Label lbl_totalMoney;
        private Label lbl_TotalMoneyValue;
        private Label lbl_offer;
        private WinFormsApp2.CustomControls.CustomComboBox cb_offerID;
        private Label lbl_paymentMethod;
        private WinFormsApp2.CustomControls.CustomComboBox cb_paymentMethod;
        private WinFormsApp2.CustomControls.RoundedButton btn_pay;
        private Label lbl_datePayment;
        private Label lbl_DatePaymentValue;
    }
}