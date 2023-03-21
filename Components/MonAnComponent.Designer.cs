namespace WinFormsApp2.Components
{
    partial class MonAnComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonAnComponent));
            metroPanel3 = new MetroFramework.Controls.MetroPanel();
            add_them_soluong = new CustomControls.RoundedButton();
            lbl_gia = new Label();
            lbl_ten = new Label();
            pictureBox3 = new PictureBox();
            metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // metroPanel3
            // 
            metroPanel3.BorderStyle = BorderStyle.FixedSingle;
            metroPanel3.Controls.Add(add_them_soluong);
            metroPanel3.Controls.Add(lbl_gia);
            metroPanel3.Controls.Add(lbl_ten);
            metroPanel3.Controls.Add(pictureBox3);
            metroPanel3.HorizontalScrollbar = true;
            metroPanel3.HorizontalScrollbarBarColor = true;
            metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel3.HorizontalScrollbarSize = 10;
            metroPanel3.Location = new Point(0, 0);
            metroPanel3.Name = "metroPanel3";
            metroPanel3.Size = new Size(455, 188);
            metroPanel3.TabIndex = 21;
            metroPanel3.VerticalScrollbarBarColor = true;
            metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            metroPanel3.VerticalScrollbarSize = 10;
            // 
            // add_them_soluong
            // 
            add_them_soluong.BackColor = Color.FromArgb(229, 1, 17);
            add_them_soluong.BackgroundColor = Color.FromArgb(229, 1, 17);
            add_them_soluong.BackgroundImage = (Image)resources.GetObject("add_them_soluong.BackgroundImage");
            add_them_soluong.BackgroundImageLayout = ImageLayout.Center;
            add_them_soluong.BorderColor = Color.Transparent;
            add_them_soluong.BorderRadius = 18;
            add_them_soluong.BorderSize = 0;
            add_them_soluong.FlatAppearance.BorderSize = 0;
            add_them_soluong.FlatStyle = FlatStyle.Flat;
            add_them_soluong.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            add_them_soluong.ForeColor = Color.White;
            add_them_soluong.Location = new Point(414, 136);
            add_them_soluong.Name = "add_them_soluong";
            add_them_soluong.Size = new Size(36, 36);
            add_them_soluong.TabIndex = 21;
            add_them_soluong.TextColor = Color.White;
            add_them_soluong.UseVisualStyleBackColor = false;
            add_them_soluong.Click += add_them_soluong_Click;
            // 
            // lbl_gia
            // 
            lbl_gia.AutoSize = true;
            lbl_gia.BackColor = Color.White;
            lbl_gia.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_gia.ForeColor = Color.Black;
            lbl_gia.Location = new Point(236, 89);
            lbl_gia.Name = "lbl_gia";
            lbl_gia.Size = new Size(90, 29);
            lbl_gia.TabIndex = 18;
            lbl_gia.Text = "Giá tiền";
            // 
            // lbl_ten
            // 
            lbl_ten.AutoSize = true;
            lbl_ten.BackColor = Color.White;
            lbl_ten.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ten.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_ten.Location = new Point(236, 16);
            lbl_ten.Name = "lbl_ten";
            lbl_ten.Size = new Size(123, 37);
            lbl_ten.TabIndex = 17;
            lbl_ten.Text = "Tên món";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-1, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(212, 187);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // MonAnComponent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(metroPanel3);
            Name = "MonAnComponent";
            Size = new Size(455, 188);
            metroPanel3.ResumeLayout(false);
            metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel3;
        private Label lbl_gia;
        private Label lbl_ten;
        private PictureBox pictureBox3;
        private CustomControls.RoundedButton add_them_soluong;
    }
}
