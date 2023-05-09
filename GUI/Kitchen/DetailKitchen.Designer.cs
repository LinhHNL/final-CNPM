namespace GUI.Kitchen
{
    partial class DetailKitchen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailKitchen));
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            metroPanel7 = new MetroFramework.Controls.MetroPanel();
            pictureBox1 = new PictureBox();
            lbl_heading = new Label();
            lbl_idbill = new Label();
            lbl_billidvalue = new Label();
            lbl_foodlist = new Label();
            lbl_food = new Label();
            label1 = new Label();
            flp_showDetailMon = new FlowLayoutPanel();
            btn_ChangeStatus = new WinFormsApp2.CustomControls.RoundedButton();
            metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // metroPanel1
            // 
            metroPanel1.Controls.Add(label4);
            metroPanel1.Controls.Add(pictureBox2);
            metroPanel1.Controls.Add(metroPanel7);
            metroPanel1.Controls.Add(pictureBox1);
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(0, 5);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(261, 722);
            metroPanel1.TabIndex = 19;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(229, 1, 17);
            label4.Location = new Point(70, 86);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 31;
            label4.Text = "Tên tài khoản";
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // lbl_heading
            // 
            lbl_heading.AutoSize = true;
            lbl_heading.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_heading.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_heading.Location = new Point(294, 19);
            lbl_heading.Name = "lbl_heading";
            lbl_heading.Size = new Size(171, 37);
            lbl_heading.TabIndex = 33;
            lbl_heading.Text = "Bill làm món";
            // 
            // lbl_idbill
            // 
            lbl_idbill.AutoSize = true;
            lbl_idbill.BackColor = Color.White;
            lbl_idbill.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_idbill.ForeColor = Color.Black;
            lbl_idbill.Location = new Point(303, 90);
            lbl_idbill.Name = "lbl_idbill";
            lbl_idbill.Size = new Size(89, 29);
            lbl_idbill.TabIndex = 32;
            lbl_idbill.Text = "Mã bill:";
            lbl_idbill.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_billidvalue
            // 
            lbl_billidvalue.AutoSize = true;
            lbl_billidvalue.BackColor = Color.White;
            lbl_billidvalue.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_billidvalue.ForeColor = Color.Black;
            lbl_billidvalue.Location = new Point(398, 90);
            lbl_billidvalue.Name = "lbl_billidvalue";
            lbl_billidvalue.Size = new Size(147, 29);
            lbl_billidvalue.TabIndex = 34;
            lbl_billidvalue.Text = "Giá trị mã bill";
            lbl_billidvalue.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_foodlist
            // 
            lbl_foodlist.AutoSize = true;
            lbl_foodlist.BackColor = Color.White;
            lbl_foodlist.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_foodlist.ForeColor = Color.Black;
            lbl_foodlist.Location = new Point(303, 150);
            lbl_foodlist.Name = "lbl_foodlist";
            lbl_foodlist.Size = new Size(197, 29);
            lbl_foodlist.TabIndex = 35;
            lbl_foodlist.Text = "Danh sách món ăn";
            lbl_foodlist.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_food
            // 
            lbl_food.AutoSize = true;
            lbl_food.BackColor = Color.White;
            lbl_food.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_food.ForeColor = Color.Black;
            lbl_food.Location = new Point(365, 213);
            lbl_food.Name = "lbl_food";
            lbl_food.Size = new Size(90, 29);
            lbl_food.TabIndex = 36;
            lbl_food.Text = "Món ăn";
            lbl_food.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(1186, 213);
            label1.Name = "label1";
            label1.Size = new Size(103, 29);
            label1.TabIndex = 37;
            label1.Text = "Số lượng";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // flp_showDetailMon
            // 
            flp_showDetailMon.AutoScroll = true;
            flp_showDetailMon.Location = new Point(294, 265);
            flp_showDetailMon.Name = "flp_showDetailMon";
            flp_showDetailMon.Size = new Size(1063, 377);
            flp_showDetailMon.TabIndex = 38;
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
            btn_ChangeStatus.Location = new Point(1219, 669);
            btn_ChangeStatus.Margin = new Padding(3, 4, 3, 4);
            btn_ChangeStatus.Name = "btn_ChangeStatus";
            btn_ChangeStatus.Size = new Size(138, 35);
            btn_ChangeStatus.TabIndex = 39;
            btn_ChangeStatus.Text = "Hoàn thành";
            btn_ChangeStatus.TextColor = Color.White;
            btn_ChangeStatus.UseVisualStyleBackColor = false;
            btn_ChangeStatus.Click += btn_ChangeStatus_Click;
            // 
            // DetailKitchen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 728);
            Controls.Add(btn_ChangeStatus);
            Controls.Add(flp_showDetailMon);
            Controls.Add(label1);
            Controls.Add(lbl_food);
            Controls.Add(lbl_foodlist);
            Controls.Add(lbl_billidvalue);
            Controls.Add(lbl_idbill);
            Controls.Add(lbl_heading);
            Controls.Add(metroPanel1);
            Name = "DetailKitchen";
            Load += DetailKitchen_Load;
            metroPanel1.ResumeLayout(false);
            metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Label label4;
        private PictureBox pictureBox2;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private PictureBox pictureBox1;
        private Label lbl_heading;
        private Label lbl_idbill;
        private Label lbl_billidvalue;
        private Label lbl_foodlist;
        private Label lbl_food;
        private Label label1;
        private FlowLayoutPanel flp_showDetailMon;
        private WinFormsApp2.CustomControls.RoundedButton btn_ChangeStatus;
    }
}