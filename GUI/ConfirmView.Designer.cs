namespace GUI
{
    partial class ConfirmView
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
            btn_ChangeToAccountSection = new WinFormsApp2.CustomControls.RoundedButton();
            roundedButton10 = new WinFormsApp2.CustomControls.RoundedButton();
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            lbl_returnplace = new Label();
            lbl_heading = new Label();
            flp_showDetailMon = new FlowLayoutPanel();
            lbl_description = new Label();
            lbl_headingNumOfFood = new Label();
            btn_ConfirmBill = new WinFormsApp2.CustomControls.RoundedButton();
            metroPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_ChangeToAccountSection
            // 
            btn_ChangeToAccountSection.BackColor = Color.FromArgb(229, 1, 17);
            btn_ChangeToAccountSection.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_ChangeToAccountSection.BorderColor = Color.PaleVioletRed;
            btn_ChangeToAccountSection.BorderRadius = 8;
            btn_ChangeToAccountSection.BorderSize = 0;
            btn_ChangeToAccountSection.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_ChangeToAccountSection.FlatStyle = FlatStyle.Flat;
            btn_ChangeToAccountSection.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ChangeToAccountSection.ForeColor = Color.White;
            btn_ChangeToAccountSection.Location = new Point(896, 44);
            btn_ChangeToAccountSection.Margin = new Padding(3, 4, 3, 4);
            btn_ChangeToAccountSection.Name = "btn_ChangeToAccountSection";
            btn_ChangeToAccountSection.Size = new Size(117, 35);
            btn_ChangeToAccountSection.TabIndex = 20;
            btn_ChangeToAccountSection.Text = "Tài khoản";
            btn_ChangeToAccountSection.TextColor = Color.White;
            btn_ChangeToAccountSection.UseVisualStyleBackColor = false;
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
            roundedButton10.Location = new Point(1019, 44);
            roundedButton10.Margin = new Padding(3, 4, 3, 4);
            roundedButton10.Name = "roundedButton10";
            roundedButton10.Size = new Size(117, 35);
            roundedButton10.TabIndex = 22;
            roundedButton10.Text = "Đăng xuất";
            roundedButton10.TextColor = Color.White;
            roundedButton10.UseVisualStyleBackColor = false;
            // 
            // metroPanel1
            // 
            metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            metroPanel1.Controls.Add(lbl_returnplace);
            metroPanel1.Controls.Add(lbl_heading);
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(2, 86);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(1134, 52);
            metroPanel1.TabIndex = 25;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lbl_returnplace
            // 
            lbl_returnplace.AutoSize = true;
            lbl_returnplace.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_returnplace.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_returnplace.Location = new Point(999, 11);
            lbl_returnplace.Name = "lbl_returnplace";
            lbl_returnplace.Size = new Size(110, 28);
            lbl_returnplace.TabIndex = 3;
            lbl_returnplace.Text = "Quay lại >";
            lbl_returnplace.Click += lbl_returnplace_Click;
            // 
            // lbl_heading
            // 
            lbl_heading.AutoSize = true;
            lbl_heading.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_heading.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_heading.Location = new Point(24, 9);
            lbl_heading.Name = "lbl_heading";
            lbl_heading.Size = new Size(203, 32);
            lbl_heading.TabIndex = 2;
            lbl_heading.Text = "Món ăn tôi chọn";
            // 
            // flp_showDetailMon
            // 
            flp_showDetailMon.AutoScroll = true;
            flp_showDetailMon.Location = new Point(2, 190);
            flp_showDetailMon.Name = "flp_showDetailMon";
            flp_showDetailMon.Size = new Size(1134, 353);
            flp_showDetailMon.TabIndex = 39;
            // 
            // lbl_description
            // 
            lbl_description.AutoSize = true;
            lbl_description.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_description.ForeColor = Color.FromArgb(108, 117, 125);
            lbl_description.Location = new Point(27, 150);
            lbl_description.Name = "lbl_description";
            lbl_description.Size = new Size(79, 28);
            lbl_description.TabIndex = 27;
            lbl_description.Text = "Món ăn";
            // 
            // lbl_headingNumOfFood
            // 
            lbl_headingNumOfFood.AutoSize = true;
            lbl_headingNumOfFood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_headingNumOfFood.ForeColor = Color.FromArgb(108, 117, 125);
            lbl_headingNumOfFood.Location = new Point(543, 150);
            lbl_headingNumOfFood.Name = "lbl_headingNumOfFood";
            lbl_headingNumOfFood.Size = new Size(96, 28);
            lbl_headingNumOfFood.TabIndex = 40;
            lbl_headingNumOfFood.Text = "Số Lượng";
            // 
            // btn_ConfirmBill
            // 
            btn_ConfirmBill.BackColor = Color.FromArgb(229, 1, 17);
            btn_ConfirmBill.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_ConfirmBill.BorderColor = Color.PaleVioletRed;
            btn_ConfirmBill.BorderRadius = 8;
            btn_ConfirmBill.BorderSize = 0;
            btn_ConfirmBill.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_ConfirmBill.FlatStyle = FlatStyle.Flat;
            btn_ConfirmBill.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ConfirmBill.ForeColor = Color.White;
            btn_ConfirmBill.Location = new Point(972, 563);
            btn_ConfirmBill.Margin = new Padding(3, 4, 3, 4);
            btn_ConfirmBill.Name = "btn_ConfirmBill";
            btn_ConfirmBill.Size = new Size(164, 37);
            btn_ConfirmBill.TabIndex = 41;
            btn_ConfirmBill.Text = "Xác Nhận Hết";
            btn_ConfirmBill.TextColor = Color.White;
            btn_ConfirmBill.UseVisualStyleBackColor = false;
            btn_ConfirmBill.Click += btn_ConfirmBill_Click;
            // 
            // ConfirmView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 624);
            Controls.Add(btn_ConfirmBill);
            Controls.Add(lbl_headingNumOfFood);
            Controls.Add(lbl_description);
            Controls.Add(flp_showDetailMon);
            Controls.Add(metroPanel1);
            Controls.Add(roundedButton10);
            Controls.Add(btn_ChangeToAccountSection);
            Name = "ConfirmView";
            Load += ConfirmView_Load;
            metroPanel1.ResumeLayout(false);
            metroPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WinFormsApp2.CustomControls.RoundedButton btn_ChangeToAccountSection;
        private WinFormsApp2.CustomControls.RoundedButton roundedButton10;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Label lbl_returnplace;
        private Label lbl_heading;
        private FlowLayoutPanel flp_showDetailMon;
        private Label lbl_description;
        private Label lbl_headingNumOfFood;
        private WinFormsApp2.CustomControls.RoundedButton btn_ConfirmBill;
    }
}