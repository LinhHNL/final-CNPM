namespace GUI.Components
{
    partial class KitchenView
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
            lbl_idban = new Label();
            lbl_status = new Label();
            lbl_lookInfo = new Label();
            mp_kitchenview = new MetroFramework.Controls.MetroPanel();
            mp_kitchenview.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_idban
            // 
            lbl_idban.BackColor = Color.White;
            lbl_idban.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_idban.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_idban.Location = new Point(16, 26);
            lbl_idban.Name = "lbl_idban";
            lbl_idban.Size = new Size(224, 32);
            lbl_idban.TabIndex = 18;
            lbl_idban.Text = "Mã bill";
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.BackColor = Color.White;
            lbl_status.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_status.ForeColor = Color.Black;
            lbl_status.Location = new Point(398, 26);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(187, 29);
            lbl_status.TabIndex = 19;
            lbl_status.Text = "Chưa hoàn thành";
            lbl_status.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_lookInfo
            // 
            lbl_lookInfo.BackColor = Color.White;
            lbl_lookInfo.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_lookInfo.ForeColor = Color.FromArgb(229, 1, 17);
            lbl_lookInfo.Location = new Point(860, 26);
            lbl_lookInfo.Name = "lbl_lookInfo";
            lbl_lookInfo.Size = new Size(105, 32);
            lbl_lookInfo.TabIndex = 20;
            lbl_lookInfo.Text = "Chi tiết >";
            lbl_lookInfo.Click += lbl_lookInfo_Click;
            // 
            // mp_kitchenview
            // 
            mp_kitchenview.BorderStyle = BorderStyle.Fixed3D;
            mp_kitchenview.Controls.Add(lbl_lookInfo);
            mp_kitchenview.Controls.Add(lbl_status);
            mp_kitchenview.Controls.Add(lbl_idban);
            mp_kitchenview.HorizontalScrollbarBarColor = true;
            mp_kitchenview.HorizontalScrollbarHighlightOnWheel = false;
            mp_kitchenview.HorizontalScrollbarSize = 10;
            mp_kitchenview.Location = new Point(3, 3);
            mp_kitchenview.Name = "mp_kitchenview";
            mp_kitchenview.Size = new Size(972, 74);
            mp_kitchenview.TabIndex = 21;
            mp_kitchenview.VerticalScrollbarBarColor = true;
            mp_kitchenview.VerticalScrollbarHighlightOnWheel = false;
            mp_kitchenview.VerticalScrollbarSize = 10;
            // 
            // KitchenView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(mp_kitchenview);
            Name = "KitchenView";
            Size = new Size(980, 80);
            mp_kitchenview.ResumeLayout(false);
            mp_kitchenview.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_idban;
        private Label lbl_status;
        private Label lbl_lookInfo;
        private MetroFramework.Controls.MetroPanel mp_kitchenview;
    }
}
