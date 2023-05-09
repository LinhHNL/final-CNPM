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
            this.lbl_paymentDetail = new System.Windows.Forms.Label();
            this.lbl_idbill = new System.Windows.Forms.Label();
            this.lbl_billidvalue = new System.Windows.Forms.Label();
            this.lbl_totalMoney = new System.Windows.Forms.Label();
            this.lbl_TotalMoneyValue = new System.Windows.Forms.Label();
            this.lbl_offer = new System.Windows.Forms.Label();
            this.cb_offerID = new WinFormsApp2.CustomControls.CustomComboBox();
            this.lbl_paymentMethod = new System.Windows.Forms.Label();
            this.cb_paymentMethod = new WinFormsApp2.CustomControls.CustomComboBox();
            this.btn_pay = new WinFormsApp2.CustomControls.RoundedButton();
            this.lbl_datePayment = new System.Windows.Forms.Label();
            this.lbl_DatePaymentValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_paymentDetail
            // 
            this.lbl_paymentDetail.AutoSize = true;
            this.lbl_paymentDetail.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_paymentDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.lbl_paymentDetail.Location = new System.Drawing.Point(55, 30);
            this.lbl_paymentDetail.Name = "lbl_paymentDetail";
            this.lbl_paymentDetail.Size = new System.Drawing.Size(250, 37);
            this.lbl_paymentDetail.TabIndex = 35;
            this.lbl_paymentDetail.Text = "Chi tiết thanh toán";
            // 
            // lbl_idbill
            // 
            this.lbl_idbill.AutoSize = true;
            this.lbl_idbill.BackColor = System.Drawing.Color.White;
            this.lbl_idbill.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_idbill.ForeColor = System.Drawing.Color.Black;
            this.lbl_idbill.Location = new System.Drawing.Point(55, 94);
            this.lbl_idbill.Name = "lbl_idbill";
            this.lbl_idbill.Size = new System.Drawing.Size(143, 29);
            this.lbl_idbill.TabIndex = 36;
            this.lbl_idbill.Text = "Mã hóa đơn:";
            this.lbl_idbill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_billidvalue
            // 
            this.lbl_billidvalue.AutoSize = true;
            this.lbl_billidvalue.BackColor = System.Drawing.Color.White;
            this.lbl_billidvalue.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_billidvalue.ForeColor = System.Drawing.Color.Black;
            this.lbl_billidvalue.Location = new System.Drawing.Point(675, 94);
            this.lbl_billidvalue.Name = "lbl_billidvalue";
            this.lbl_billidvalue.Size = new System.Drawing.Size(147, 29);
            this.lbl_billidvalue.TabIndex = 37;
            this.lbl_billidvalue.Text = "Giá trị mã bill";
            this.lbl_billidvalue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_totalMoney
            // 
            this.lbl_totalMoney.AutoSize = true;
            this.lbl_totalMoney.BackColor = System.Drawing.Color.White;
            this.lbl_totalMoney.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_totalMoney.ForeColor = System.Drawing.Color.Black;
            this.lbl_totalMoney.Location = new System.Drawing.Point(55, 146);
            this.lbl_totalMoney.Name = "lbl_totalMoney";
            this.lbl_totalMoney.Size = new System.Drawing.Size(115, 29);
            this.lbl_totalMoney.TabIndex = 38;
            this.lbl_totalMoney.Text = "Tổng Tiền:";
            this.lbl_totalMoney.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_TotalMoneyValue
            // 
            this.lbl_TotalMoneyValue.AutoSize = true;
            this.lbl_TotalMoneyValue.BackColor = System.Drawing.Color.White;
            this.lbl_TotalMoneyValue.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalMoneyValue.ForeColor = System.Drawing.Color.Black;
            this.lbl_TotalMoneyValue.Location = new System.Drawing.Point(645, 146);
            this.lbl_TotalMoneyValue.Name = "lbl_TotalMoneyValue";
            this.lbl_TotalMoneyValue.Size = new System.Drawing.Size(177, 29);
            this.lbl_TotalMoneyValue.TabIndex = 39;
            this.lbl_TotalMoneyValue.Text = "Giá Trị Tổng Tiền";
            this.lbl_TotalMoneyValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_offer
            // 
            this.lbl_offer.AutoSize = true;
            this.lbl_offer.BackColor = System.Drawing.Color.White;
            this.lbl_offer.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_offer.ForeColor = System.Drawing.Color.Black;
            this.lbl_offer.Location = new System.Drawing.Point(55, 257);
            this.lbl_offer.Name = "lbl_offer";
            this.lbl_offer.Size = new System.Drawing.Size(81, 29);
            this.lbl_offer.TabIndex = 40;
            this.lbl_offer.Text = "Ưu Đãi";
            this.lbl_offer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_offerID
            // 
            this.cb_offerID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_offerID.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cb_offerID.BorderSize = 1;
            this.cb_offerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cb_offerID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_offerID.ForeColor = System.Drawing.Color.DimGray;
            this.cb_offerID.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cb_offerID.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cb_offerID.ListTextColor = System.Drawing.Color.DimGray;
            this.cb_offerID.Location = new System.Drawing.Point(55, 311);
            this.cb_offerID.MinimumSize = new System.Drawing.Size(200, 30);
            this.cb_offerID.Name = "cb_offerID";
            this.cb_offerID.Padding = new System.Windows.Forms.Padding(1);
            this.cb_offerID.Size = new System.Drawing.Size(250, 38);
            this.cb_offerID.TabIndex = 41;
            this.cb_offerID.Texts = "Mã ưu đãi";
            // 
            // lbl_paymentMethod
            // 
            this.lbl_paymentMethod.AutoSize = true;
            this.lbl_paymentMethod.BackColor = System.Drawing.Color.White;
            this.lbl_paymentMethod.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_paymentMethod.ForeColor = System.Drawing.Color.Black;
            this.lbl_paymentMethod.Location = new System.Drawing.Point(55, 389);
            this.lbl_paymentMethod.Name = "lbl_paymentMethod";
            this.lbl_paymentMethod.Size = new System.Drawing.Size(261, 29);
            this.lbl_paymentMethod.TabIndex = 42;
            this.lbl_paymentMethod.Text = "Phương thức thanh toán";
            this.lbl_paymentMethod.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_paymentMethod
            // 
            this.cb_paymentMethod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_paymentMethod.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cb_paymentMethod.BorderSize = 1;
            this.cb_paymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cb_paymentMethod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_paymentMethod.ForeColor = System.Drawing.Color.DimGray;
            this.cb_paymentMethod.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cb_paymentMethod.Items.AddRange(new object[] {
            "Tiền mặt"});
            this.cb_paymentMethod.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cb_paymentMethod.ListTextColor = System.Drawing.Color.DimGray;
            this.cb_paymentMethod.Location = new System.Drawing.Point(55, 459);
            this.cb_paymentMethod.MinimumSize = new System.Drawing.Size(200, 30);
            this.cb_paymentMethod.Name = "cb_paymentMethod";
            this.cb_paymentMethod.Padding = new System.Windows.Forms.Padding(1);
            this.cb_paymentMethod.Size = new System.Drawing.Size(250, 38);
            this.cb_paymentMethod.TabIndex = 43;
            this.cb_paymentMethod.Texts = "Phương thức thanh toán";
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_pay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_pay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_pay.BorderRadius = 8;
            this.btn_pay.BorderSize = 0;
            this.btn_pay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pay.ForeColor = System.Drawing.Color.White;
            this.btn_pay.Location = new System.Drawing.Point(684, 532);
            this.btn_pay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(138, 35);
            this.btn_pay.TabIndex = 45;
            this.btn_pay.Text = "Thanh toán";
            this.btn_pay.TextColor = System.Drawing.Color.White;
            this.btn_pay.UseVisualStyleBackColor = false;
            // 
            // lbl_datePayment
            // 
            this.lbl_datePayment.AutoSize = true;
            this.lbl_datePayment.BackColor = System.Drawing.Color.White;
            this.lbl_datePayment.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_datePayment.ForeColor = System.Drawing.Color.Black;
            this.lbl_datePayment.Location = new System.Drawing.Point(55, 198);
            this.lbl_datePayment.Name = "lbl_datePayment";
            this.lbl_datePayment.Size = new System.Drawing.Size(185, 29);
            this.lbl_datePayment.TabIndex = 46;
            this.lbl_datePayment.Text = "Ngày thanh toán:";
            this.lbl_datePayment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_DatePaymentValue
            // 
            this.lbl_DatePaymentValue.AutoSize = true;
            this.lbl_DatePaymentValue.BackColor = System.Drawing.Color.White;
            this.lbl_DatePaymentValue.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DatePaymentValue.ForeColor = System.Drawing.Color.Black;
            this.lbl_DatePaymentValue.Location = new System.Drawing.Point(581, 198);
            this.lbl_DatePaymentValue.Name = "lbl_DatePaymentValue";
            this.lbl_DatePaymentValue.Size = new System.Drawing.Size(241, 29);
            this.lbl_DatePaymentValue.TabIndex = 47;
            this.lbl_DatePaymentValue.Text = "Giá trị ngày thanh toán";
            this.lbl_DatePaymentValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 591);
            this.Controls.Add(this.lbl_DatePaymentValue);
            this.Controls.Add(this.lbl_datePayment);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.cb_paymentMethod);
            this.Controls.Add(this.lbl_paymentMethod);
            this.Controls.Add(this.cb_offerID);
            this.Controls.Add(this.lbl_offer);
            this.Controls.Add(this.lbl_TotalMoneyValue);
            this.Controls.Add(this.lbl_totalMoney);
            this.Controls.Add(this.lbl_billidvalue);
            this.Controls.Add(this.lbl_idbill);
            this.Controls.Add(this.lbl_paymentDetail);
            this.Name = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

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