namespace WinFormsApp2.Components
{
    partial class PaymentView : UserControl
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
            lbl_price = new Label();
            lbl_SoLuong = new Label();
            SuspendLayout();
            // 
            // lbl_TenMon
            // 
            lbl_TenMon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TenMon.Location = new Point(20, 15);
            lbl_TenMon.Name = "lbl_TenMon";
            lbl_TenMon.Size = new Size(466, 75);
            lbl_TenMon.TabIndex = 0;
            lbl_TenMon.Text = "Tên món";
            // 
            // lbl_price
            // 
            lbl_price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_price.Location = new Point(928, 15);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(214, 75);
            lbl_price.TabIndex = 1;
            lbl_price.Text = "Giá tiền";
            // 
            // lbl_SoLuong
            // 
            lbl_SoLuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_SoLuong.Location = new Point(492, 15);
            lbl_SoLuong.Name = "lbl_SoLuong";
            lbl_SoLuong.Size = new Size(65, 75);
            lbl_SoLuong.TabIndex = 22;
            lbl_SoLuong.Text = "Số lượng";
            // 
            // PaymentView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_SoLuong);
            Controls.Add(lbl_price);
            Controls.Add(lbl_TenMon);
            Name = "PaymentView";
            Size = new Size(1145, 92);
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_TenMon;
        private Label lbl_price;
        private System.CodeDom.CodeTypeReference btn_addmoreitem;
        private Label lbl_SoLuong;
    }
}
