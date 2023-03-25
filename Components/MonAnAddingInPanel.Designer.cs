namespace WinFormsApp2.Components
{
    partial class MonAnAddingInPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonAnAddingInPanel));
            lbl_TenMon = new Label();
            lbl_SoLuong = new Label();
            btn_giamsoluong = new CustomControls.RoundedButton();
            add_them_soluong = new CustomControls.RoundedButton();
            btn_deleteitem = new CustomControls.RoundedButton();
            SuspendLayout();
            // 
            // lbl_TenMon
            // 
            lbl_TenMon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TenMon.Location = new Point(3, 31);
            lbl_TenMon.Name = "lbl_TenMon";
            lbl_TenMon.Size = new Size(351, 75);
            lbl_TenMon.TabIndex = 1;
            lbl_TenMon.Text = "Tên món";
            // 
            // lbl_SoLuong
            // 
            lbl_SoLuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_SoLuong.Location = new Point(453, 31);
            lbl_SoLuong.Name = "lbl_SoLuong";
            lbl_SoLuong.Size = new Size(65, 75);
            lbl_SoLuong.TabIndex = 25;
            lbl_SoLuong.Text = "Số lượng";
            // 
            // btn_giamsoluong
            // 
            btn_giamsoluong.BackColor = Color.FromArgb(229, 1, 17);
            btn_giamsoluong.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_giamsoluong.BackgroundImage = (Image)resources.GetObject("btn_giamsoluong.BackgroundImage");
            btn_giamsoluong.BackgroundImageLayout = ImageLayout.Center;
            btn_giamsoluong.BorderColor = Color.Transparent;
            btn_giamsoluong.BorderRadius = 18;
            btn_giamsoluong.BorderSize = 0;
            btn_giamsoluong.FlatAppearance.BorderSize = 0;
            btn_giamsoluong.FlatStyle = FlatStyle.Flat;
            btn_giamsoluong.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_giamsoluong.ForeColor = Color.White;
            btn_giamsoluong.Location = new Point(389, 31);
            btn_giamsoluong.Name = "btn_giamsoluong";
            btn_giamsoluong.Size = new Size(36, 36);
            btn_giamsoluong.TabIndex = 24;
            btn_giamsoluong.TextColor = Color.White;
            btn_giamsoluong.UseVisualStyleBackColor = false;
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
            add_them_soluong.Location = new Point(535, 31);
            add_them_soluong.Name = "add_them_soluong";
            add_them_soluong.Size = new Size(36, 36);
            add_them_soluong.TabIndex = 23;
            add_them_soluong.TextColor = Color.White;
            add_them_soluong.UseVisualStyleBackColor = false;
            // 
            // btn_deleteitem
            // 
            btn_deleteitem.BackColor = Color.Gray;
            btn_deleteitem.BackgroundColor = Color.Gray;
            btn_deleteitem.BackgroundImage = (Image)resources.GetObject("btn_deleteitem.BackgroundImage");
            btn_deleteitem.BackgroundImageLayout = ImageLayout.Center;
            btn_deleteitem.BorderColor = Color.Transparent;
            btn_deleteitem.BorderRadius = 18;
            btn_deleteitem.BorderSize = 0;
            btn_deleteitem.FlatAppearance.BorderSize = 0;
            btn_deleteitem.FlatStyle = FlatStyle.Flat;
            btn_deleteitem.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_deleteitem.ForeColor = Color.White;
            btn_deleteitem.Location = new Point(675, 31);
            btn_deleteitem.Name = "btn_deleteitem";
            btn_deleteitem.Size = new Size(36, 36);
            btn_deleteitem.TabIndex = 26;
            btn_deleteitem.TextColor = Color.White;
            btn_deleteitem.UseVisualStyleBackColor = false;
            // 
            // MonAnAddingInPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_deleteitem);
            Controls.Add(lbl_SoLuong);
            Controls.Add(btn_giamsoluong);
            Controls.Add(add_them_soluong);
            Controls.Add(lbl_TenMon);
            Name = "MonAnAddingInPanel";
            Size = new Size(741, 150);
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_TenMon;
        private Label lbl_SoLuong;
        private CustomControls.RoundedButton btn_giamsoluong;
        private CustomControls.RoundedButton add_them_soluong;
        private CustomControls.RoundedButton btn_deleteitem;
    }
}
