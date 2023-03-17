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
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.roundedButton13 = new WinFormsApp2.CustomControls.RoundedButton();
            this.lbl_gia = new System.Windows.Forms.Label();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.roundedButton13);
            this.metroPanel3.Controls.Add(this.lbl_gia);
            this.metroPanel3.Controls.Add(this.lbl_ten);
            this.metroPanel3.Controls.Add(this.pictureBox3);
            this.metroPanel3.HorizontalScrollbar = true;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(455, 188);
            this.metroPanel3.TabIndex = 21;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // roundedButton13
            // 
            this.roundedButton13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.roundedButton13.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.roundedButton13.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButton13.BorderRadius = 8;
            this.roundedButton13.BorderSize = 0;
            this.roundedButton13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.roundedButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundedButton13.ForeColor = System.Drawing.Color.White;
            this.roundedButton13.Location = new System.Drawing.Point(329, 145);
            this.roundedButton13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundedButton13.Name = "roundedButton13";
            this.roundedButton13.Size = new System.Drawing.Size(117, 35);
            this.roundedButton13.TabIndex = 23;
            this.roundedButton13.Text = "Khóa";
            this.roundedButton13.TextColor = System.Drawing.Color.White;
            this.roundedButton13.UseVisualStyleBackColor = false;
            // 
            // lbl_gia
            // 
            this.lbl_gia.AutoSize = true;
            this.lbl_gia.BackColor = System.Drawing.Color.White;
            this.lbl_gia.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_gia.ForeColor = System.Drawing.Color.Black;
            this.lbl_gia.Location = new System.Drawing.Point(236, 89);
            this.lbl_gia.Name = "lbl_gia";
            this.lbl_gia.Size = new System.Drawing.Size(90, 29);
            this.lbl_gia.TabIndex = 18;
            this.lbl_gia.Text = "Giá tiền";
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.BackColor = System.Drawing.Color.White;
            this.lbl_ten.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.lbl_ten.Location = new System.Drawing.Point(236, 16);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(123, 37);
            this.lbl_ten.TabIndex = 17;
            this.lbl_ten.Text = "Tên món";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(212, 187);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // MonAnComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel3);
            this.Name = "MonAnComponent";
            this.Size = new System.Drawing.Size(455, 188);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel3;
        private CustomControls.RoundedButton roundedButton13;
        private Label lbl_gia;
        private Label lbl_ten;
        private PictureBox pictureBox3;
    }
}
