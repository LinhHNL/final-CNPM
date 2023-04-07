namespace WinFormsApp2.CustomControls
{
    partial class ButtonTrangThai
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
            this.button = new WinFormsApp2.CustomControls.RoundedButton();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(140)))), ((int)(((byte)(66)))));
            this.button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(140)))), ((int)(((byte)(66)))));
            this.button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(140)))), ((int)(((byte)(66)))));
            this.button.BorderRadius = 8;
            this.button.BorderSize = 0;
            this.button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Location = new System.Drawing.Point(3, 4);
            this.button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(125, 35);
            this.button.TabIndex = 23;
            this.button.Text = "Đã duyệt";
            this.button.TextColor = System.Drawing.Color.White;
            this.button.UseVisualStyleBackColor = false;
            // 
            // ButtonTrangThai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button);
            this.Name = "ButtonTrangThai";
            this.Size = new System.Drawing.Size(131, 43);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton button;
    }
}
