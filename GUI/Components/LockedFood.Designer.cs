namespace GUI.Components
{
    partial class LockedFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockedFood));
            metroPanel3 = new MetroFramework.Controls.MetroPanel();
            btn_unlockedfood = new WinFormsApp2.CustomControls.RoundedButton();
            lbl_gia = new Label();
            lbl_ten = new Label();
            pb_FoodImage = new PictureBox();
            metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_FoodImage).BeginInit();
            SuspendLayout();
            // 
            // metroPanel3
            // 
            metroPanel3.BorderStyle = BorderStyle.FixedSingle;
            metroPanel3.Controls.Add(btn_unlockedfood);
            metroPanel3.Controls.Add(lbl_gia);
            metroPanel3.Controls.Add(lbl_ten);
            metroPanel3.Controls.Add(pb_FoodImage);
            metroPanel3.HorizontalScrollbar = true;
            metroPanel3.HorizontalScrollbarBarColor = true;
            metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel3.HorizontalScrollbarSize = 10;
            metroPanel3.Location = new Point(3, 3);
            metroPanel3.Name = "metroPanel3";
            metroPanel3.Size = new Size(455, 188);
            metroPanel3.TabIndex = 23;
            metroPanel3.VerticalScrollbarBarColor = true;
            metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            metroPanel3.VerticalScrollbarSize = 10;
            // 
            // btn_unlockedfood
            // 
            btn_unlockedfood.BackColor = Color.FromArgb(108, 117, 125);
            btn_unlockedfood.BackgroundColor = Color.FromArgb(108, 117, 125);
            btn_unlockedfood.BorderColor = Color.PaleVioletRed;
            btn_unlockedfood.BorderRadius = 8;
            btn_unlockedfood.BorderSize = 0;
            btn_unlockedfood.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_unlockedfood.FlatStyle = FlatStyle.Flat;
            btn_unlockedfood.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_unlockedfood.ForeColor = Color.White;
            btn_unlockedfood.Location = new Point(334, 146);
            btn_unlockedfood.Margin = new Padding(3, 4, 3, 4);
            btn_unlockedfood.Name = "btn_unlockedfood";
            btn_unlockedfood.Size = new Size(116, 35);
            btn_unlockedfood.TabIndex = 24;
            btn_unlockedfood.Text = "Mở Khóa";
            btn_unlockedfood.TextColor = Color.White;
            btn_unlockedfood.UseVisualStyleBackColor = false;
            btn_unlockedfood.Click += btn_unlockedfood_Click;
            // 
            // lbl_gia
            // 
            lbl_gia.AutoSize = true;
            lbl_gia.BackColor = Color.White;
            lbl_gia.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_gia.ForeColor = Color.Black;
            lbl_gia.Location = new Point(236, 115);
            lbl_gia.Name = "lbl_gia";
            lbl_gia.Size = new Size(90, 29);
            lbl_gia.TabIndex = 18;
            lbl_gia.Text = "Giá tiền";
            // 
            // lbl_ten
            // 
            lbl_ten.BackColor = Color.White;
            lbl_ten.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ten.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_ten.Location = new Point(236, 16);
            lbl_ten.Name = "lbl_ten";
            lbl_ten.Size = new Size(204, 89);
            lbl_ten.TabIndex = 17;
            lbl_ten.Text = "Tên món";
            // 
            // pb_FoodImage
            // 
            pb_FoodImage.Image = (Image)resources.GetObject("pb_FoodImage.Image");
            pb_FoodImage.Location = new Point(-1, 0);
            pb_FoodImage.Name = "pb_FoodImage";
            pb_FoodImage.Size = new Size(212, 187);
            pb_FoodImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_FoodImage.TabIndex = 2;
            pb_FoodImage.TabStop = false;
            // 
            // LockedFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(metroPanel3);
            Name = "LockedFood";
            Size = new Size(462, 194);
            metroPanel3.ResumeLayout(false);
            metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_FoodImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel3;
        private WinFormsApp2.CustomControls.RoundedButton btn_unlockedfood;
        private Label lbl_gia;
        private Label lbl_ten;
        private PictureBox pb_FoodImage;
    }
}
