namespace WinFormsApp2.Components
{
    partial class MonAnComponentForAdding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonAnComponentForAdding));
            pictureBox3 = new PictureBox();
            lbl_ten = new Label();
            btn_add_them_soluong = new CustomControls.RoundedButton();
            btn_uncheckedadding = new CustomControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(212, 187);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // lbl_ten
            // 
            lbl_ten.AutoSize = true;
            lbl_ten.BackColor = Color.White;
            lbl_ten.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ten.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_ten.Location = new Point(218, 11);
            lbl_ten.Name = "lbl_ten";
            lbl_ten.Size = new Size(123, 37);
            lbl_ten.TabIndex = 18;
            lbl_ten.Text = "Tên món";
            // 
            // btn_add_them_soluong
            // 
            btn_add_them_soluong.BackColor = Color.White;
            btn_add_them_soluong.BackgroundColor = Color.White;
            btn_add_them_soluong.BackgroundImageLayout = ImageLayout.Center;
            btn_add_them_soluong.BorderColor = Color.FromArgb(229, 1, 17);
            btn_add_them_soluong.BorderRadius = 18;
            btn_add_them_soluong.BorderSize = 1;
            btn_add_them_soluong.FlatAppearance.BorderSize = 0;
            btn_add_them_soluong.FlatStyle = FlatStyle.Flat;
            btn_add_them_soluong.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_them_soluong.ForeColor = Color.White;
            btn_add_them_soluong.Location = new Point(416, 149);
            btn_add_them_soluong.Name = "btn_add_them_soluong";
            btn_add_them_soluong.Size = new Size(36, 36);
            btn_add_them_soluong.TabIndex = 21;
            btn_add_them_soluong.TextColor = Color.White;
            btn_add_them_soluong.UseVisualStyleBackColor = false;
            btn_add_them_soluong.Click += add_them_soluong_Click;
            // 
            // btn_uncheckedadding
            // 
            btn_uncheckedadding.BackColor = Color.FromArgb(229, 1, 17);
            btn_uncheckedadding.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_uncheckedadding.BackgroundImage = (Image)resources.GetObject("btn_uncheckedadding.BackgroundImage");
            btn_uncheckedadding.BackgroundImageLayout = ImageLayout.Center;
            btn_uncheckedadding.BorderColor = Color.FromArgb(229, 1, 17);
            btn_uncheckedadding.BorderRadius = 18;
            btn_uncheckedadding.BorderSize = 0;
            btn_uncheckedadding.FlatAppearance.BorderSize = 0;
            btn_uncheckedadding.FlatStyle = FlatStyle.Flat;
            btn_uncheckedadding.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_uncheckedadding.ForeColor = Color.White;
            btn_uncheckedadding.Location = new Point(416, 149);
            btn_uncheckedadding.Name = "btn_uncheckedadding";
            btn_uncheckedadding.Size = new Size(36, 36);
            btn_uncheckedadding.TabIndex = 22;
            btn_uncheckedadding.TextColor = Color.White;
            btn_uncheckedadding.UseVisualStyleBackColor = false;
            btn_uncheckedadding.Click += btn_uncheckedadding_Click;
            // 
            // MonAnComponentForAdding
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btn_add_them_soluong);
            Controls.Add(lbl_ten);
            Controls.Add(pictureBox3);
            Controls.Add(btn_uncheckedadding);
            Name = "MonAnComponentForAdding";
            Size = new Size(455, 188);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private Label lbl_ten;
        private CustomControls.RoundedButton btn_add_them_soluong;
        private CustomControls.RoundedButton btn_uncheckedadding;
    }
}
