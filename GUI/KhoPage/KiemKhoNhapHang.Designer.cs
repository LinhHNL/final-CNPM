namespace WinFormsApp2.KhoPage
{
    partial class KiemKhoNhapHang
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiemKhoNhapHang));
            roundedButton10 = new CustomControls.RoundedButton();
            label1 = new Label();
            btn_PhieuNhapHang = new CustomControls.RoundedButton();
            metroGrid1 = new MetroFramework.Controls.MetroGrid();
            dgv_NhapHang = new MetroFramework.Controls.MetroGrid();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            metroPanel7 = new MetroFramework.Controls.MetroPanel();
            btn_NhapHang = new CustomControls.RoundedButton();
            btn_XuatHang = new CustomControls.RoundedButton();
            btn_HangTrongKho = new CustomControls.RoundedButton();
            btn_KiemKho = new CustomControls.RoundedButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)metroGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_NhapHang).BeginInit();
            metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // roundedButton10
            // 
            roundedButton10.BackColor = Color.FromArgb(229, 1, 17);
            roundedButton10.BackgroundColor = Color.FromArgb(229, 1, 17);
            roundedButton10.BorderColor = Color.PaleVioletRed;
            roundedButton10.BorderRadius = 8;
            roundedButton10.BorderSize = 0;
            roundedButton10.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            roundedButton10.FlatStyle = FlatStyle.Flat;
            roundedButton10.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton10.ForeColor = Color.White;
            roundedButton10.Location = new Point(1057, 35);
            roundedButton10.Margin = new Padding(3, 4, 3, 4);
            roundedButton10.Name = "roundedButton10";
            roundedButton10.Size = new Size(117, 35);
            roundedButton10.TabIndex = 22;
            roundedButton10.Text = "Đăng xuất";
            roundedButton10.TextColor = Color.White;
            roundedButton10.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(269, 73);
            label1.Name = "label1";
            label1.Size = new Size(166, 40);
            label1.TabIndex = 29;
            label1.Text = "Nhập hàng";
            // 
            // btn_PhieuNhapHang
            // 
            btn_PhieuNhapHang.BackColor = Color.FromArgb(253, 197, 183);
            btn_PhieuNhapHang.BackgroundColor = Color.FromArgb(253, 197, 183);
            btn_PhieuNhapHang.BorderColor = Color.FromArgb(215, 122, 125);
            btn_PhieuNhapHang.BorderRadius = 8;
            btn_PhieuNhapHang.BorderSize = 1;
            btn_PhieuNhapHang.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_PhieuNhapHang.FlatStyle = FlatStyle.Flat;
            btn_PhieuNhapHang.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_PhieuNhapHang.ForeColor = Color.FromArgb(229, 1, 17);
            btn_PhieuNhapHang.Location = new Point(992, 78);
            btn_PhieuNhapHang.Margin = new Padding(3, 4, 3, 4);
            btn_PhieuNhapHang.Name = "btn_PhieuNhapHang";
            btn_PhieuNhapHang.Size = new Size(182, 35);
            btn_PhieuNhapHang.TabIndex = 30;
            btn_PhieuNhapHang.Text = "+ Phiếu nhập hàng";
            btn_PhieuNhapHang.TextColor = Color.FromArgb(229, 1, 17);
            btn_PhieuNhapHang.UseVisualStyleBackColor = false;
            btn_PhieuNhapHang.Click += btn_PhieuXuatHang_Click;
            // 
            // metroGrid1
            // 
            metroGrid1.AllowUserToResizeRows = false;
            metroGrid1.BackgroundColor = Color.FromArgb(255, 255, 255);
            metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            metroGrid1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            metroGrid1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            metroGrid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            metroGrid1.EnableHeadersVisualStyles = false;
            metroGrid1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            metroGrid1.GridColor = Color.FromArgb(255, 255, 255);
            metroGrid1.Location = new Point(381, 153);
            metroGrid1.Name = "metroGrid1";
            metroGrid1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            metroGrid1.RowHeadersWidth = 51;
            metroGrid1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            metroGrid1.RowTemplate.Height = 29;
            metroGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            metroGrid1.Size = new Size(8, 8);
            metroGrid1.TabIndex = 31;
            // 
            // dgv_NhapHang
            // 
            dgv_NhapHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 235, 235);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(175, 175, 175);
            dgv_NhapHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_NhapHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_NhapHang.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgv_NhapHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv_NhapHang.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgv_NhapHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(253, 197, 183);
            dataGridViewCellStyle5.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(253, 197, 183);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv_NhapHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv_NhapHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_NhapHang.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(175, 175, 175);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv_NhapHang.DefaultCellStyle = dataGridViewCellStyle6;
            dgv_NhapHang.EnableHeadersVisualStyles = false;
            dgv_NhapHang.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgv_NhapHang.GridColor = Color.FromArgb(197, 198, 198);
            dgv_NhapHang.Location = new Point(269, 125);
            dgv_NhapHang.Name = "dgv_NhapHang";
            dgv_NhapHang.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_NhapHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgv_NhapHang.RowHeadersVisible = false;
            dgv_NhapHang.RowHeadersWidth = 51;
            dgv_NhapHang.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_NhapHang.RowTemplate.Height = 29;
            dgv_NhapHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_NhapHang.Size = new Size(905, 463);
            dgv_NhapHang.TabIndex = 32;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã nhập hàng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Ngày/Giờ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Trạng thái";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // metroPanel1
            // 
            metroPanel1.Controls.Add(label4);
            metroPanel1.Controls.Add(pictureBox2);
            metroPanel1.Controls.Add(metroPanel7);
            metroPanel1.Controls.Add(btn_NhapHang);
            metroPanel1.Controls.Add(btn_XuatHang);
            metroPanel1.Controls.Add(btn_HangTrongKho);
            metroPanel1.Controls.Add(btn_KiemKho);
            metroPanel1.Controls.Add(pictureBox1);
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(4, 35);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(259, 570);
            metroPanel1.TabIndex = 33;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(229, 1, 17);
            label4.Location = new Point(70, 86);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 31;
            label4.Text = "Tên tài khoản";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(34, 88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 26);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // metroPanel7
            // 
            metroPanel7.BackColor = Color.Black;
            metroPanel7.HorizontalScrollbarBarColor = true;
            metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel7.HorizontalScrollbarSize = 10;
            metroPanel7.Location = new Point(259, 539);
            metroPanel7.Name = "metroPanel7";
            metroPanel7.Size = new Size(904, 55);
            metroPanel7.TabIndex = 20;
            metroPanel7.VerticalScrollbarBarColor = true;
            metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            metroPanel7.VerticalScrollbarSize = 10;
            // 
            // btn_NhapHang
            // 
            btn_NhapHang.BackColor = Color.FromArgb(253, 230, 232);
            btn_NhapHang.BackgroundColor = Color.FromArgb(253, 230, 232);
            btn_NhapHang.BorderColor = Color.FromArgb(0, 0, 15, 255);
            btn_NhapHang.BorderRadius = 0;
            btn_NhapHang.BorderSize = 0;
            btn_NhapHang.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_NhapHang.FlatStyle = FlatStyle.Flat;
            btn_NhapHang.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_NhapHang.ForeColor = Color.Black;
            btn_NhapHang.Location = new Point(-1, 302);
            btn_NhapHang.Margin = new Padding(3, 4, 3, 4);
            btn_NhapHang.Name = "btn_NhapHang";
            btn_NhapHang.Size = new Size(263, 64);
            btn_NhapHang.TabIndex = 18;
            btn_NhapHang.Text = "Nhập hàng";
            btn_NhapHang.TextColor = Color.Black;
            btn_NhapHang.UseVisualStyleBackColor = false;
            // 
            // btn_XuatHang
            // 
            btn_XuatHang.BackColor = Color.FromArgb(253, 230, 232);
            btn_XuatHang.BackgroundColor = Color.FromArgb(253, 230, 232);
            btn_XuatHang.BorderColor = Color.Silver;
            btn_XuatHang.BorderRadius = 0;
            btn_XuatHang.BorderSize = 0;
            btn_XuatHang.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_XuatHang.FlatStyle = FlatStyle.Flat;
            btn_XuatHang.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_XuatHang.ForeColor = Color.FromArgb(160, 159, 159);
            btn_XuatHang.Location = new Point(-1, 243);
            btn_XuatHang.Margin = new Padding(3, 4, 3, 4);
            btn_XuatHang.Name = "btn_XuatHang";
            btn_XuatHang.Size = new Size(264, 64);
            btn_XuatHang.TabIndex = 17;
            btn_XuatHang.Text = "Xuất hàng";
            btn_XuatHang.TextColor = Color.FromArgb(160, 159, 159);
            btn_XuatHang.UseVisualStyleBackColor = false;
            btn_XuatHang.Click += btn_XuatHang_Click;
            // 
            // btn_HangTrongKho
            // 
            btn_HangTrongKho.BackColor = Color.White;
            btn_HangTrongKho.BackgroundColor = Color.White;
            btn_HangTrongKho.BorderColor = Color.FromArgb(0, 0, 15, 255);
            btn_HangTrongKho.BorderRadius = 0;
            btn_HangTrongKho.BorderSize = 0;
            btn_HangTrongKho.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_HangTrongKho.FlatStyle = FlatStyle.Flat;
            btn_HangTrongKho.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_HangTrongKho.ForeColor = Color.FromArgb(160, 159, 159);
            btn_HangTrongKho.Location = new Point(0, 130);
            btn_HangTrongKho.Margin = new Padding(3, 4, 3, 4);
            btn_HangTrongKho.Name = "btn_HangTrongKho";
            btn_HangTrongKho.Size = new Size(262, 60);
            btn_HangTrongKho.TabIndex = 16;
            btn_HangTrongKho.Text = "Hàng trong kho";
            btn_HangTrongKho.TextColor = Color.FromArgb(160, 159, 159);
            btn_HangTrongKho.UseVisualStyleBackColor = false;
            btn_HangTrongKho.Click += btn_HangTrongKho_Click;
            // 
            // btn_KiemKho
            // 
            btn_KiemKho.BackColor = Color.FromArgb(229, 1, 17);
            btn_KiemKho.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_KiemKho.BorderColor = Color.PaleVioletRed;
            btn_KiemKho.BorderRadius = 0;
            btn_KiemKho.BorderSize = 0;
            btn_KiemKho.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_KiemKho.FlatStyle = FlatStyle.Flat;
            btn_KiemKho.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_KiemKho.ForeColor = Color.White;
            btn_KiemKho.Location = new Point(0, 189);
            btn_KiemKho.Margin = new Padding(3, 4, 3, 4);
            btn_KiemKho.Name = "btn_KiemKho";
            btn_KiemKho.Size = new Size(262, 56);
            btn_KiemKho.TabIndex = 16;
            btn_KiemKho.Text = "Kiểm kho";
            btn_KiemKho.TextColor = Color.White;
            btn_KiemKho.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // KiemKhoNhapHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 605);
            Controls.Add(metroPanel1);
            Controls.Add(dgv_NhapHang);
            Controls.Add(metroGrid1);
            Controls.Add(btn_PhieuNhapHang);
            Controls.Add(label1);
            Controls.Add(roundedButton10);
            Name = "KiemKhoNhapHang";
            ((System.ComponentModel.ISupportInitialize)metroGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_NhapHang).EndInit();
            metroPanel1.ResumeLayout(false);
            metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomControls.RoundedButton roundedButton10;
        private Label label1;
        private CustomControls.RoundedButton btn_PhieuNhapHang;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroGrid dgv_NhapHang;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Label label4;
        private PictureBox pictureBox2;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private CustomControls.RoundedButton btn_NhapHang;
        private CustomControls.RoundedButton btn_XuatHang;
        private CustomControls.RoundedButton btn_HangTrongKho;
        private CustomControls.RoundedButton btn_KiemKho;
        private PictureBox pictureBox1;
    }
}