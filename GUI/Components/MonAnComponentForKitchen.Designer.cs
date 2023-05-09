namespace WinFormsApp2.Components
{
    partial class MonAnComponentForKitchen
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
            // lbl_SoLuong
            // 
            lbl_SoLuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_SoLuong.Location = new Point(868, 15);
            lbl_SoLuong.Name = "lbl_SoLuong";
            lbl_SoLuong.Size = new Size(159, 75);
            lbl_SoLuong.TabIndex = 22;
            lbl_SoLuong.Text = "Số lượng";
            // 
            // MonAnComponentForKitchen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_SoLuong);
            Controls.Add(lbl_TenMon);
            Name = "MonAnComponentForKitchen";
            Size = new Size(1045, 90);
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_TenMon;
        private System.CodeDom.CodeTypeReference btn_addmoreitem;
        private Label lbl_SoLuong;
    }
}
