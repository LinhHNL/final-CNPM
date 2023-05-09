namespace WinFormsApp2.CustomControls
{
    partial class CalendarCell
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Gio = new System.Windows.Forms.Label();
            this.lbl_Ca = new System.Windows.Forms.Label();
            this.lbl_Nghi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số giờ làm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Gio
            // 
            this.lbl_Gio.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Gio.Location = new System.Drawing.Point(0, 34);
            this.lbl_Gio.Name = "lbl_Gio";
            this.lbl_Gio.Size = new System.Drawing.Size(125, 21);
            this.lbl_Gio.TabIndex = 2;
            this.lbl_Gio.Text = "--:-- - --:--";
            this.lbl_Gio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Ca
            // 
            this.lbl_Ca.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Ca.Location = new System.Drawing.Point(0, 50);
            this.lbl_Ca.Name = "lbl_Ca";
            this.lbl_Ca.Size = new System.Drawing.Size(125, 21);
            this.lbl_Ca.TabIndex = 3;
            this.lbl_Ca.Text = "Ca --";
            this.lbl_Ca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Nghi
            // 
            this.lbl_Nghi.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nghi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.lbl_Nghi.Location = new System.Drawing.Point(-3, 21);
            this.lbl_Nghi.Name = "lbl_Nghi";
            this.lbl_Nghi.Size = new System.Drawing.Size(125, 27);
            this.lbl_Nghi.TabIndex = 4;
            this.lbl_Nghi.Text = "Nghỉ";
            this.lbl_Nghi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Nghi.Visible = false;
            // 
            // CalendarCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbl_Nghi);
            this.Controls.Add(this.lbl_Ca);
            this.Controls.Add(this.lbl_Gio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalendarCell";
            this.Size = new System.Drawing.Size(125, 107);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbl_Gio;
        private Label lbl_Ca;
        private Label lbl_Nghi;
    }
}
