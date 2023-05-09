namespace GUI.Kitchen
{
    partial class ViewingKitchen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewingKitchen));
            pnl_sidebar = new MetroFramework.Controls.MetroPanel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            metroPanel7 = new MetroFramework.Controls.MetroPanel();
            pictureBox1 = new PictureBox();
            flp_ShowBillTemp = new FlowLayoutPanel();
            btn_DangXuat = new WinFormsApp2.CustomControls.RoundedButton();
            lbl_heading = new Label();
            pnl_sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnl_sidebar
            // 
            pnl_sidebar.Controls.Add(label4);
            pnl_sidebar.Controls.Add(pictureBox2);
            pnl_sidebar.Controls.Add(metroPanel7);
            pnl_sidebar.Controls.Add(pictureBox1);
            pnl_sidebar.HorizontalScrollbarBarColor = true;
            pnl_sidebar.HorizontalScrollbarHighlightOnWheel = false;
            pnl_sidebar.HorizontalScrollbarSize = 10;
            pnl_sidebar.Location = new Point(1, 22);
            pnl_sidebar.Name = "pnl_sidebar";
            pnl_sidebar.Size = new Size(263, 525);
            pnl_sidebar.TabIndex = 18;
            pnl_sidebar.VerticalScrollbarBarColor = true;
            pnl_sidebar.VerticalScrollbarHighlightOnWheel = false;
            pnl_sidebar.VerticalScrollbarSize = 10;
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
            // flp_ShowBillTemp
            // 
            flp_ShowBillTemp.AutoScroll = true;
            flp_ShowBillTemp.Location = new Point(282, 87);
            flp_ShowBillTemp.Name = "flp_ShowBillTemp";
            flp_ShowBillTemp.Size = new Size(1016, 460);
            flp_ShowBillTemp.TabIndex = 19;
            // 
            // btn_DangXuat
            // 
            btn_DangXuat.BackColor = Color.FromArgb(229, 1, 17);
            btn_DangXuat.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_DangXuat.BorderColor = Color.PaleVioletRed;
            btn_DangXuat.BorderRadius = 8;
            btn_DangXuat.BorderSize = 0;
            btn_DangXuat.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_DangXuat.FlatStyle = FlatStyle.Flat;
            btn_DangXuat.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_DangXuat.ForeColor = Color.White;
            btn_DangXuat.Location = new Point(1181, 36);
            btn_DangXuat.Margin = new Padding(3, 4, 3, 4);
            btn_DangXuat.Name = "btn_DangXuat";
            btn_DangXuat.Size = new Size(117, 35);
            btn_DangXuat.TabIndex = 23;
            btn_DangXuat.Text = "Đăng xuất";
            btn_DangXuat.TextColor = Color.White;
            btn_DangXuat.UseVisualStyleBackColor = false;
            // 
            // lbl_heading
            // 
            lbl_heading.AutoSize = true;
            lbl_heading.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_heading.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_heading.Location = new Point(282, 34);
            lbl_heading.Name = "lbl_heading";
            lbl_heading.Size = new Size(171, 37);
            lbl_heading.TabIndex = 32;
            lbl_heading.Text = "Bill làm món";
            // 
            // ViewingKitchen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 557);
            Controls.Add(lbl_heading);
            Controls.Add(btn_DangXuat);
            Controls.Add(flp_ShowBillTemp);
            Controls.Add(pnl_sidebar);
            Name = "ViewingKitchen";
            Load += ViewingKitchen_Load;
            pnl_sidebar.ResumeLayout(false);
            pnl_sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnl_sidebar;
        private Label label4;
        private PictureBox pictureBox2;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flp_ShowBillTemp;
        private WinFormsApp2.CustomControls.RoundedButton btn_DangXuat;
        private Label lbl_heading;
    }
}