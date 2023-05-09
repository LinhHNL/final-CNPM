namespace WinFormsApp2.KhachHangManager
{
    partial class ListCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListCustomerForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            cb_ChoosingType = new MetroFramework.Controls.MetroComboBox();
            tb_findingMaKhach = new CustomControls.LeftAlignRoundedTextBox();
            label1 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            metroPanel7 = new MetroFramework.Controls.MetroPanel();
            pictureBox1 = new PictureBox();
            btn_DangXuat = new CustomControls.RoundedButton();
            label2 = new Label();
            btn_Them = new CustomControls.RoundedButton();
            btn_Xoa = new CustomControls.RoundedButton();
            btn_XuatFile = new CustomControls.RoundedButton();
            dgv_DanhsachKhachHang = new MetroFramework.Controls.MetroGrid();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhsachKhachHang).BeginInit();
            SuspendLayout();
            // 
            // metroPanel1
            // 
            metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            metroPanel1.Controls.Add(cb_ChoosingType);
            metroPanel1.Controls.Add(tb_findingMaKhach);
            metroPanel1.Controls.Add(label1);
            metroPanel1.Controls.Add(label4);
            metroPanel1.Controls.Add(pictureBox2);
            metroPanel1.Controls.Add(metroPanel7);
            metroPanel1.Controls.Add(pictureBox1);
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 11;
            metroPanel1.Location = new Point(0, 42);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(259, 561);
            metroPanel1.TabIndex = 45;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cb_ChoosingType
            // 
            cb_ChoosingType.FormattingEnabled = true;
            cb_ChoosingType.ItemHeight = 24;
            cb_ChoosingType.Location = new Point(22, 253);
            cb_ChoosingType.Name = "cb_ChoosingType";
            cb_ChoosingType.Size = new Size(200, 30);
            cb_ChoosingType.TabIndex = 49;
            cb_ChoosingType.UseSelectable = true;
            // 
            // tb_findingMaKhach
            // 
            tb_findingMaKhach.BackColor = SystemColors.Window;
            tb_findingMaKhach.BorderColor = Color.Gray;
            tb_findingMaKhach.BorderFocusColor = Color.Black;
            tb_findingMaKhach.BorderRadius = 10;
            tb_findingMaKhach.BorderSize = 1;
            tb_findingMaKhach.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_findingMaKhach.ForeColor = Color.Black;
            tb_findingMaKhach.Location = new Point(22, 181);
            tb_findingMaKhach.Margin = new Padding(4);
            tb_findingMaKhach.Multiline = false;
            tb_findingMaKhach.Name = "tb_findingMaKhach";
            tb_findingMaKhach.Padding = new Padding(10, 7, 10, 7);
            tb_findingMaKhach.PasswordChar = false;
            tb_findingMaKhach.PlaceholderColor = Color.DarkGray;
            tb_findingMaKhach.PlaceholderText = "Mã/ Tên Khách Hàng";
            tb_findingMaKhach.ReadOnly = false;
            tb_findingMaKhach.Size = new Size(200, 39);
            tb_findingMaKhach.TabIndex = 46;
            tb_findingMaKhach.Texts = "";
            tb_findingMaKhach.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(81, 136);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 48;
            label1.Text = "Tìm kiếm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(229, 1, 17);
            label4.Location = new Point(70, 85);
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
            pictureBox2.Size = new Size(30, 27);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // metroPanel7
            // 
            metroPanel7.BackColor = Color.Black;
            metroPanel7.HorizontalScrollbarBarColor = true;
            metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel7.HorizontalScrollbarSize = 11;
            metroPanel7.Location = new Point(259, 539);
            metroPanel7.Name = "metroPanel7";
            metroPanel7.Size = new Size(904, 55);
            metroPanel7.TabIndex = 20;
            metroPanel7.VerticalScrollbarBarColor = true;
            metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            metroPanel7.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(101, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 51);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // btn_DangXuat
            // 
            btn_DangXuat.BackColor = Color.FromArgb(229, 1, 17);
            btn_DangXuat.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_DangXuat.BorderColor = Color.PaleVioletRed;
            btn_DangXuat.BorderRadius = 8;
            btn_DangXuat.BorderSize = 0;
            btn_DangXuat.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_DangXuat.FlatStyle = FlatStyle.Flat;
            btn_DangXuat.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_DangXuat.ForeColor = Color.White;
            btn_DangXuat.Location = new Point(936, 42);
            btn_DangXuat.Margin = new Padding(3, 4, 3, 4);
            btn_DangXuat.Name = "btn_DangXuat";
            btn_DangXuat.Size = new Size(117, 35);
            btn_DangXuat.TabIndex = 50;
            btn_DangXuat.Text = "Đăng xuất";
            btn_DangXuat.TextColor = Color.White;
            btn_DangXuat.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(274, 103);
            label2.Name = "label2";
            label2.Size = new Size(316, 38);
            label2.TabIndex = 51;
            label2.Text = "Danh Sách khách hàng";
            // 
            // btn_Them
            // 
            btn_Them.BackColor = Color.FromArgb(253, 197, 183);
            btn_Them.BackgroundColor = Color.FromArgb(253, 197, 183);
            btn_Them.BorderColor = Color.FromArgb(215, 122, 125);
            btn_Them.BorderRadius = 8;
            btn_Them.BorderSize = 1;
            btn_Them.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_Them.FlatStyle = FlatStyle.Flat;
            btn_Them.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Them.ForeColor = Color.FromArgb(229, 1, 17);
            btn_Them.Location = new Point(704, 103);
            btn_Them.Margin = new Padding(3, 4, 3, 4);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(87, 35);
            btn_Them.TabIndex = 52;
            btn_Them.Text = "+ Thêm";
            btn_Them.TextColor = Color.FromArgb(229, 1, 17);
            btn_Them.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            btn_Xoa.BackColor = Color.FromArgb(253, 197, 183);
            btn_Xoa.BackgroundColor = Color.FromArgb(253, 197, 183);
            btn_Xoa.BorderColor = Color.FromArgb(215, 122, 125);
            btn_Xoa.BorderRadius = 8;
            btn_Xoa.BorderSize = 1;
            btn_Xoa.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_Xoa.FlatStyle = FlatStyle.Flat;
            btn_Xoa.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Xoa.ForeColor = Color.FromArgb(229, 1, 17);
            btn_Xoa.Location = new Point(831, 103);
            btn_Xoa.Margin = new Padding(3, 4, 3, 4);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(77, 35);
            btn_Xoa.TabIndex = 53;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.TextColor = Color.FromArgb(229, 1, 17);
            btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_XuatFile
            // 
            btn_XuatFile.BackColor = Color.FromArgb(253, 197, 183);
            btn_XuatFile.BackgroundColor = Color.FromArgb(253, 197, 183);
            btn_XuatFile.BorderColor = Color.FromArgb(215, 122, 125);
            btn_XuatFile.BorderRadius = 8;
            btn_XuatFile.BorderSize = 1;
            btn_XuatFile.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_XuatFile.FlatStyle = FlatStyle.Flat;
            btn_XuatFile.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_XuatFile.ForeColor = Color.FromArgb(229, 1, 17);
            btn_XuatFile.Location = new Point(936, 103);
            btn_XuatFile.Margin = new Padding(3, 4, 3, 4);
            btn_XuatFile.Name = "btn_XuatFile";
            btn_XuatFile.Size = new Size(117, 35);
            btn_XuatFile.TabIndex = 54;
            btn_XuatFile.Text = " Xuất file";
            btn_XuatFile.TextColor = Color.FromArgb(229, 1, 17);
            btn_XuatFile.UseVisualStyleBackColor = false;
            // 
            // dgv_DanhsachKhachHang
            // 
            dgv_DanhsachKhachHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 235, 235);
            dgv_DanhsachKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_DanhsachKhachHang.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgv_DanhsachKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv_DanhsachKhachHang.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgv_DanhsachKhachHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(253, 197, 183);
            dataGridViewCellStyle2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(253, 197, 183);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_DanhsachKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_DanhsachKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhsachKhachHang.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_DanhsachKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_DanhsachKhachHang.EnableHeadersVisualStyles = false;
            dgv_DanhsachKhachHang.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgv_DanhsachKhachHang.GridColor = Color.FromArgb(197, 198, 198);
            dgv_DanhsachKhachHang.Location = new Point(274, 170);
            dgv_DanhsachKhachHang.Name = "dgv_DanhsachKhachHang";
            dgv_DanhsachKhachHang.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_DanhsachKhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_DanhsachKhachHang.RowHeadersVisible = false;
            dgv_DanhsachKhachHang.RowHeadersWidth = 51;
            dgv_DanhsachKhachHang.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_DanhsachKhachHang.RowTemplate.Height = 29;
            dgv_DanhsachKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_DanhsachKhachHang.Size = new Size(779, 357);
            dgv_DanhsachKhachHang.TabIndex = 55;
            dgv_DanhsachKhachHang.CellContentClick += dgv_DanhsachKhachHang_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã khách hàng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 170;
            // 
            // Column2
            // 
            Column2.HeaderText = "Họ tên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 120;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số Điện Thoại";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Địa Chỉ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 130;
            // 
            // Column5
            // 
            Column5.HeaderText = "Loại Thành Viên";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 180;
            // 
            // ListCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 602);
            Controls.Add(dgv_DanhsachKhachHang);
            Controls.Add(btn_XuatFile);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Them);
            Controls.Add(label2);
            Controls.Add(btn_DangXuat);
            Controls.Add(metroPanel1);
            Name = "ListCustomerForm";
            metroPanel1.ResumeLayout(false);
            metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhsachKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Label label4;
        private PictureBox pictureBox2;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private PictureBox pictureBox1;
        private Label label1;
        private CustomControls.LeftAlignRoundedTextBox tb_findingMaKhach;
        private MetroFramework.Controls.MetroComboBox cb_ChoosingType;
        private CustomControls.RoundedButton btn_DangXuat;
        private Label label2;
        private CustomControls.RoundedButton btn_Them;
        private CustomControls.RoundedButton btn_Xoa;
        private CustomControls.RoundedButton btn_XuatFile;
        private MetroFramework.Controls.MetroGrid dgv_DanhsachKhachHang;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}