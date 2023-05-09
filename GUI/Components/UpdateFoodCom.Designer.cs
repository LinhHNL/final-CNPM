namespace GUI.Components
{
    partial class UpdateFoodCom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateFoodCom));
            metroPanel3 = new MetroFramework.Controls.MetroPanel();
            btn_UpdateFood = new WinFormsApp2.CustomControls.RoundedButton();
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
            metroPanel3.Controls.Add(btn_UpdateFood);
            metroPanel3.Controls.Add(lbl_gia);
            metroPanel3.Controls.Add(lbl_ten);
            metroPanel3.Controls.Add(pb_FoodImage);
            metroPanel3.HorizontalScrollbar = true;
            metroPanel3.HorizontalScrollbarBarColor = true;
            metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel3.HorizontalScrollbarSize = 10;
            metroPanel3.Location = new Point(2, 3);
            metroPanel3.Name = "metroPanel3";
            metroPanel3.Size = new Size(455, 188);
            metroPanel3.TabIndex = 23;
            metroPanel3.VerticalScrollbarBarColor = true;
            metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            metroPanel3.VerticalScrollbarSize = 10;
            // 
            // btn_UpdateFood
            // 
            btn_UpdateFood.BackColor = Color.FromArgb(229, 1, 17);
            btn_UpdateFood.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_UpdateFood.BorderColor = Color.PaleVioletRed;
            btn_UpdateFood.BorderRadius = 8;
            btn_UpdateFood.BorderSize = 0;
            btn_UpdateFood.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_UpdateFood.FlatStyle = FlatStyle.Flat;
            btn_UpdateFood.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_UpdateFood.ForeColor = Color.White;
            btn_UpdateFood.Location = new Point(323, 147);
            btn_UpdateFood.Margin = new Padding(3, 4, 3, 4);
            btn_UpdateFood.Name = "btn_UpdateFood";
            btn_UpdateFood.Size = new Size(117, 35);
            btn_UpdateFood.TabIndex = 27;
            btn_UpdateFood.Text = "Cập nhật";
            btn_UpdateFood.TextColor = Color.White;
            btn_UpdateFood.UseVisualStyleBackColor = false;
            btn_UpdateFood.Click += btn_UpdateFood_Click_1;
            // 
            // lbl_gia
            // 
            lbl_gia.AutoSize = true;
            lbl_gia.BackColor = Color.White;
            lbl_gia.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_gia.ForeColor = Color.Black;
            lbl_gia.Location = new Point(236, 114);
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
            // UpdateFoodCom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(metroPanel3);
            Name = "UpdateFoodCom";
            Size = new Size(459, 194);
            metroPanel3.ResumeLayout(false);
            metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_FoodImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel3;
        private Label lbl_gia;
        private Label lbl_ten;
        private PictureBox pb_FoodImage;
        private WinFormsApp2.CustomControls.RoundedButton btn_UpdateFood;
    }
}
