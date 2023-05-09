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
            lbl_heading = new Label();
            lbl_idbill = new Label();
            lbl_billidvalue = new Label();
            lbl_totalMoney = new Label();
            lbl_TotalMoneyValue = new Label();
            lbl_PromotionHeading = new Label();
            cb_ChoosingPromotion = new WinFormsApp2.CustomControls.CustomComboBox();
            lbl_Payment = new Label();
            cb_Payment = new WinFormsApp2.CustomControls.CustomComboBox();
            btn_ChangeStatus = new WinFormsApp2.CustomControls.RoundedButton();
            lbl_datePayment = new Label();
            lbl_DatePaymentValue = new Label();
            SuspendLayout();
            // 
            // lbl_heading
            // 
            lbl_heading.AutoSize = true;
            lbl_heading.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_heading.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_heading.Location = new Point(55, 30);
            lbl_heading.Name = "lbl_heading";
            lbl_heading.Size = new Size(250, 37);
            lbl_heading.TabIndex = 35;
            lbl_heading.Text = "Chi tiết thanh toán";
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
            // lbl_PromotionHeading
            // 
            lbl_PromotionHeading.AutoSize = true;
            lbl_PromotionHeading.BackColor = Color.White;
            lbl_PromotionHeading.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PromotionHeading.ForeColor = Color.Black;
            lbl_PromotionHeading.Location = new Point(55, 257);
            lbl_PromotionHeading.Name = "lbl_PromotionHeading";
            lbl_PromotionHeading.Size = new Size(81, 29);
            lbl_PromotionHeading.TabIndex = 40;
            lbl_PromotionHeading.Text = "Ưu Đãi";
            lbl_PromotionHeading.TextAlign = ContentAlignment.TopCenter;
            // 
            // cb_ChoosingPromotion
            // 
            cb_ChoosingPromotion.BackColor = Color.WhiteSmoke;
            cb_ChoosingPromotion.BorderColor = Color.MediumSlateBlue;
            cb_ChoosingPromotion.BorderSize = 1;
            cb_ChoosingPromotion.DropDownStyle = ComboBoxStyle.DropDown;
            cb_ChoosingPromotion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_ChoosingPromotion.ForeColor = Color.DimGray;
            cb_ChoosingPromotion.IconColor = Color.MediumSlateBlue;
            cb_ChoosingPromotion.ListBackColor = Color.FromArgb(230, 228, 245);
            cb_ChoosingPromotion.ListTextColor = Color.DimGray;
            cb_ChoosingPromotion.Location = new Point(55, 311);
            cb_ChoosingPromotion.MinimumSize = new Size(200, 30);
            cb_ChoosingPromotion.Name = "cb_ChoosingPromotion";
            cb_ChoosingPromotion.Padding = new Padding(1);
            cb_ChoosingPromotion.Size = new Size(250, 38);
            cb_ChoosingPromotion.TabIndex = 41;
            cb_ChoosingPromotion.Texts = "Mã ưu đãi";
            // 
            // lbl_Payment
            // 
            lbl_Payment.AutoSize = true;
            lbl_Payment.BackColor = Color.White;
            lbl_Payment.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Payment.ForeColor = Color.Black;
            lbl_Payment.Location = new Point(55, 389);
            lbl_Payment.Name = "lbl_Payment";
            lbl_Payment.Size = new Size(261, 29);
            lbl_Payment.TabIndex = 42;
            lbl_Payment.Text = "Phương thức thanh toán";
            lbl_Payment.TextAlign = ContentAlignment.TopCenter;
            // 
            // cb_Payment
            // 
            cb_Payment.BackColor = Color.WhiteSmoke;
            cb_Payment.BorderColor = Color.MediumSlateBlue;
            cb_Payment.BorderSize = 1;
            cb_Payment.DropDownStyle = ComboBoxStyle.DropDown;
            cb_Payment.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Payment.ForeColor = Color.DimGray;
            cb_Payment.IconColor = Color.MediumSlateBlue;
            cb_Payment.Items.AddRange(new object[] { "Tiền mặt" });
            cb_Payment.ListBackColor = Color.FromArgb(230, 228, 245);
            cb_Payment.ListTextColor = Color.DimGray;
            cb_Payment.Location = new Point(55, 459);
            cb_Payment.MinimumSize = new Size(200, 30);
            cb_Payment.Name = "cb_Payment";
            cb_Payment.Padding = new Padding(1);
            cb_Payment.Size = new Size(250, 38);
            cb_Payment.TabIndex = 43;
            cb_Payment.Texts = "Phương thức thanh toán";
            // 
            // btn_ChangeStatus
            // 
            btn_ChangeStatus.BackColor = Color.FromArgb(229, 1, 17);
            btn_ChangeStatus.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_ChangeStatus.BorderColor = Color.PaleVioletRed;
            btn_ChangeStatus.BorderRadius = 8;
            btn_ChangeStatus.BorderSize = 0;
            btn_ChangeStatus.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_ChangeStatus.FlatStyle = FlatStyle.Flat;
            btn_ChangeStatus.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ChangeStatus.ForeColor = Color.White;
            btn_ChangeStatus.Location = new Point(684, 532);
            btn_ChangeStatus.Margin = new Padding(3, 4, 3, 4);
            btn_ChangeStatus.Name = "btn_ChangeStatus";
            btn_ChangeStatus.Size = new Size(138, 35);
            btn_ChangeStatus.TabIndex = 45;
            btn_ChangeStatus.Text = "Thanh toán";
            btn_ChangeStatus.TextColor = Color.White;
            btn_ChangeStatus.UseVisualStyleBackColor = false;
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
            Controls.Add(btn_ChangeStatus);
            Controls.Add(cb_Payment);
            Controls.Add(lbl_Payment);
            Controls.Add(cb_ChoosingPromotion);
            Controls.Add(lbl_PromotionHeading);
            Controls.Add(lbl_TotalMoneyValue);
            Controls.Add(lbl_totalMoney);
            Controls.Add(lbl_billidvalue);
            Controls.Add(lbl_idbill);
            Controls.Add(lbl_heading);
            Name = "Payment";
            Load += Payment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_heading;
        private Label lbl_idbill;
        private Label lbl_billidvalue;
        private Label lbl_totalMoney;
        private Label lbl_TotalMoneyValue;
        private Label lbl_PromotionHeading;
        private WinFormsApp2.CustomControls.CustomComboBox cb_ChoosingPromotion;
        private Label lbl_Payment;
        private WinFormsApp2.CustomControls.CustomComboBox cb_Payment;
        private WinFormsApp2.CustomControls.RoundedButton btn_ChangeStatus;
        private Label lbl_datePayment;
        private Label lbl_DatePaymentValue;
    }
}