namespace WinFormsApp2.Components
{
    partial class ConfirmView : UserControl
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
            lbl_TenMon = new Label();
            lbl_SoLuong = new Label();
            btn_ConfirmFood = new CustomControls.RoundedButton();
            SuspendLayout();
            // 
            // lbl_TenMon
            // 
            lbl_TenMon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TenMon.Location = new Point(12, 24);
            lbl_TenMon.Name = "lbl_TenMon";
            lbl_TenMon.Size = new Size(457, 65);
            lbl_TenMon.TabIndex = 0;
            lbl_TenMon.Text = "Tên món";
            // 
            // lbl_SoLuong
            // 
            lbl_SoLuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_SoLuong.Location = new Point(492, 25);
            lbl_SoLuong.Name = "lbl_SoLuong";
            lbl_SoLuong.Size = new Size(97, 35);
            lbl_SoLuong.TabIndex = 22;
            lbl_SoLuong.Text = "Số lượng";
            // 
            // btn_ConfirmFood
            // 
            btn_ConfirmFood.BackColor = Color.FromArgb(229, 1, 17);
            btn_ConfirmFood.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_ConfirmFood.BorderColor = Color.White;
            btn_ConfirmFood.BorderRadius = 8;
            btn_ConfirmFood.BorderSize = 1;
            btn_ConfirmFood.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_ConfirmFood.FlatStyle = FlatStyle.Flat;
            btn_ConfirmFood.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ConfirmFood.ForeColor = Color.White;
            btn_ConfirmFood.Location = new Point(865, 24);
            btn_ConfirmFood.Margin = new Padding(3, 4, 3, 4);
            btn_ConfirmFood.Name = "btn_ConfirmFood";
            btn_ConfirmFood.Size = new Size(154, 35);
            btn_ConfirmFood.TabIndex = 23;
            btn_ConfirmFood.Text = "Xác Nhận Món";
            btn_ConfirmFood.TextColor = Color.White;
            btn_ConfirmFood.UseVisualStyleBackColor = false;
            // 
            // ConfirmView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_ConfirmFood);
            Controls.Add(lbl_SoLuong);
            Controls.Add(lbl_TenMon);
            Name = "ConfirmView";
            Size = new Size(1045, 90);
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_TenMon;
        private System.CodeDom.CodeTypeReference btn_addmoreitem;
        private Label lbl_SoLuong;
        private CustomControls.RoundedButton btn_ConfirmFood;
    }
}
