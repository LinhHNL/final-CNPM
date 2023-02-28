namespace WinFormsApp2
{
    partial class HomepageForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myRoundedButton1 = new WinFormsApp2.MyRoundedButton();
            this.SuspendLayout();
            // 
            // myRoundedButton1
            // 
            this.myRoundedButton1.Location = new System.Drawing.Point(269, 261);
            this.myRoundedButton1.Name = "myRoundedButton1";
            this.myRoundedButton1.Size = new System.Drawing.Size(138, 59);
            this.myRoundedButton1.TabIndex = 0;
            this.myRoundedButton1.Text = "myRoundedButton1";
            this.myRoundedButton1.UseVisualStyleBackColor = true;
            this.myRoundedButton1.Click += new System.EventHandler(this.myRoundedButton1_Click);
            // 
            // HomepageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.myRoundedButton1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomepageForm";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 15);
            this.Text = "HomepageForm";
            this.Load += new System.EventHandler(this.HomepageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyRoundedButton myRoundedButton1;
    }
}