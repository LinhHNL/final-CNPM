namespace GUI.Kitchen
{
    partial class DetailKitchen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailKitchen));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lbl_AccountName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_MakeDishBill = new System.Windows.Forms.Label();
            this.lbl_BillID = new System.Windows.Forms.Label();
            this.lbl_BillIDVal = new System.Windows.Forms.Label();
            this.lbl_DishList = new System.Windows.Forms.Label();
            this.lbl_Dish = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.flp_showDetailMon = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Finish = new WinFormsApp2.CustomControls.RoundedButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lbl_AccountName);
            this.metroPanel1.Controls.Add(this.pictureBox2);
            this.metroPanel1.Controls.Add(this.metroPanel7);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 5);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(261, 722);
            this.metroPanel1.TabIndex = 19;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lbl_AccountName
            // 
            this.lbl_AccountName.AutoSize = true;
            this.lbl_AccountName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AccountName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.lbl_AccountName.Location = new System.Drawing.Point(70, 86);
            this.lbl_AccountName.Name = "lbl_AccountName";
            this.lbl_AccountName.Size = new System.Drawing.Size(138, 28);
            this.lbl_AccountName.TabIndex = 31;
            this.lbl_AccountName.Text = "Tên tài khoản";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 26);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // metroPanel7
            // 
            this.metroPanel7.BackColor = System.Drawing.Color.Black;
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 10;
            this.metroPanel7.Location = new System.Drawing.Point(259, 539);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(904, 55);
            this.metroPanel7.TabIndex = 20;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_MakeDishBill
            // 
            this.lbl_MakeDishBill.AutoSize = true;
            this.lbl_MakeDishBill.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_MakeDishBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.lbl_MakeDishBill.Location = new System.Drawing.Point(294, 19);
            this.lbl_MakeDishBill.Name = "lbl_MakeDishBill";
            this.lbl_MakeDishBill.Size = new System.Drawing.Size(171, 37);
            this.lbl_MakeDishBill.TabIndex = 33;
            this.lbl_MakeDishBill.Text = "Bill làm món";
            // 
            // lbl_BillID
            // 
            this.lbl_BillID.AutoSize = true;
            this.lbl_BillID.BackColor = System.Drawing.Color.White;
            this.lbl_BillID.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_BillID.ForeColor = System.Drawing.Color.Black;
            this.lbl_BillID.Location = new System.Drawing.Point(303, 90);
            this.lbl_BillID.Name = "lbl_BillID";
            this.lbl_BillID.Size = new System.Drawing.Size(89, 29);
            this.lbl_BillID.TabIndex = 32;
            this.lbl_BillID.Text = "Mã bill:";
            this.lbl_BillID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_BillIDVal
            // 
            this.lbl_BillIDVal.AutoSize = true;
            this.lbl_BillIDVal.BackColor = System.Drawing.Color.White;
            this.lbl_BillIDVal.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_BillIDVal.ForeColor = System.Drawing.Color.Black;
            this.lbl_BillIDVal.Location = new System.Drawing.Point(398, 90);
            this.lbl_BillIDVal.Name = "lbl_BillIDVal";
            this.lbl_BillIDVal.Size = new System.Drawing.Size(147, 29);
            this.lbl_BillIDVal.TabIndex = 34;
            this.lbl_BillIDVal.Text = "Giá trị mã bill";
            this.lbl_BillIDVal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_DishList
            // 
            this.lbl_DishList.AutoSize = true;
            this.lbl_DishList.BackColor = System.Drawing.Color.White;
            this.lbl_DishList.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DishList.ForeColor = System.Drawing.Color.Black;
            this.lbl_DishList.Location = new System.Drawing.Point(303, 150);
            this.lbl_DishList.Name = "lbl_DishList";
            this.lbl_DishList.Size = new System.Drawing.Size(197, 29);
            this.lbl_DishList.TabIndex = 35;
            this.lbl_DishList.Text = "Danh sách món ăn";
            this.lbl_DishList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Dish
            // 
            this.lbl_Dish.AutoSize = true;
            this.lbl_Dish.BackColor = System.Drawing.Color.White;
            this.lbl_Dish.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dish.ForeColor = System.Drawing.Color.Black;
            this.lbl_Dish.Location = new System.Drawing.Point(365, 213);
            this.lbl_Dish.Name = "lbl_Dish";
            this.lbl_Dish.Size = new System.Drawing.Size(90, 29);
            this.lbl_Dish.TabIndex = 36;
            this.lbl_Dish.Text = "Món ăn";
            this.lbl_Dish.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.BackColor = System.Drawing.Color.White;
            this.lbl_Quantity.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Quantity.ForeColor = System.Drawing.Color.Black;
            this.lbl_Quantity.Location = new System.Drawing.Point(1186, 213);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(103, 29);
            this.lbl_Quantity.TabIndex = 37;
            this.lbl_Quantity.Text = "Số lượng";
            this.lbl_Quantity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flp_showDetailMon
            // 
            this.flp_showDetailMon.AutoScroll = true;
            this.flp_showDetailMon.Location = new System.Drawing.Point(294, 265);
            this.flp_showDetailMon.Name = "flp_showDetailMon";
            this.flp_showDetailMon.Size = new System.Drawing.Size(1063, 377);
            this.flp_showDetailMon.TabIndex = 38;
            // 
            // btn_Finish
            // 
            this.btn_Finish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Finish.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Finish.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Finish.BorderRadius = 8;
            this.btn_Finish.BorderSize = 0;
            this.btn_Finish.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Finish.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Finish.ForeColor = System.Drawing.Color.White;
            this.btn_Finish.Location = new System.Drawing.Point(1219, 669);
            this.btn_Finish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(138, 35);
            this.btn_Finish.TabIndex = 39;
            this.btn_Finish.Text = "Hoàn thành";
            this.btn_Finish.TextColor = System.Drawing.Color.White;
            this.btn_Finish.UseVisualStyleBackColor = false;
            // 
            // DetailKitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 728);
            this.Controls.Add(this.btn_Finish);
            this.Controls.Add(this.flp_showDetailMon);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_Dish);
            this.Controls.Add(this.lbl_DishList);
            this.Controls.Add(this.lbl_BillIDVal);
            this.Controls.Add(this.lbl_BillID);
            this.Controls.Add(this.lbl_MakeDishBill);
            this.Controls.Add(this.metroPanel1);
            this.Name = "DetailKitchen";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Label lbl_AccountName;
        private PictureBox pictureBox2;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private PictureBox pictureBox1;
        private Label lbl_MakeDishBill;
        private Label lbl_BillID;
        private Label lbl_BillIDVal;
        private Label lbl_DishList;
        private Label lbl_Dish;
        private Label lbl_Quantity;
        private FlowLayoutPanel flp_showDetailMon;
        private WinFormsApp2.CustomControls.RoundedButton btn_Finish;
    }
}