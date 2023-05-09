namespace WinFormsApp2.KhoPage
{
    partial class KiemKhoXemPhieuXuatHang
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiemKhoXemPhieuXuatHang));
            btn_DangXuat = new CustomControls.RoundedButton();
            label1 = new Label();
            metroGrid1 = new MetroFramework.Controls.MetroGrid();
            dgv_HangHoa = new MetroFramework.Controls.MetroGrid();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            tb_MaXuatHang = new CustomControls.LeftAlignRoundedTextBox();
            tb_NguoiXuatHang = new CustomControls.LeftAlignRoundedTextBox();
            label3 = new Label();
            tb_NgayXuatHang = new CustomControls.LeftAlignRoundedTextBox();
            label5 = new Label();
            btn_Sua = new CustomControls.RoundedButton();
            btn_Luu = new CustomControls.RoundedButton();
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
            ((System.ComponentModel.ISupportInitialize)dgv_HangHoa).BeginInit();
            metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            btn_DangXuat.Location = new Point(1057, 35);
            btn_DangXuat.Margin = new Padding(3, 4, 3, 4);
            btn_DangXuat.Name = "btn_DangXuat";
            btn_DangXuat.Size = new Size(117, 35);
            btn_DangXuat.TabIndex = 22;
            btn_DangXuat.Text = "Đăng xuất";
            btn_DangXuat.TextColor = Color.White;
            btn_DangXuat.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(265, 78);
            label1.Name = "label1";
            label1.Size = new Size(238, 40);
            label1.TabIndex = 29;
            label1.Text = "Phiếu xuất hàng";
            // 
            // metroGrid1
            // 
            metroGrid1.AllowUserToResizeRows = false;
            metroGrid1.BackgroundColor = Color.FromArgb(255, 255, 255);
            metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            metroGrid1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            metroGrid1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            metroGrid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            metroGrid1.DefaultCellStyle = dataGridViewCellStyle9;
            metroGrid1.EnableHeadersVisualStyles = false;
            metroGrid1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            metroGrid1.GridColor = Color.FromArgb(255, 255, 255);
            metroGrid1.Location = new Point(381, 153);
            metroGrid1.Name = "metroGrid1";
            metroGrid1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            metroGrid1.RowHeadersWidth = 51;
            metroGrid1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            metroGrid1.RowTemplate.Height = 29;
            metroGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            metroGrid1.Size = new Size(8, 8);
            metroGrid1.TabIndex = 31;
            // 
            // dgv_HangHoa
            // 
            dgv_HangHoa.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(235, 235, 235);
            dgv_HangHoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dgv_HangHoa.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgv_HangHoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv_HangHoa.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgv_HangHoa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(253, 197, 183);
            dataGridViewCellStyle12.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(253, 197, 183);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgv_HangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgv_HangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HangHoa.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle13.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle13.SelectionBackColor = Color.White;
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dgv_HangHoa.DefaultCellStyle = dataGridViewCellStyle13;
            dgv_HangHoa.EnableHeadersVisualStyles = false;
            dgv_HangHoa.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgv_HangHoa.GridColor = Color.FromArgb(197, 198, 198);
            dgv_HangHoa.Location = new Point(268, 218);
            dgv_HangHoa.Name = "dgv_HangHoa";
            dgv_HangHoa.ReadOnly = true;
            dgv_HangHoa.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle14.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgv_HangHoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgv_HangHoa.RowHeadersVisible = false;
            dgv_HangHoa.RowHeadersWidth = 51;
            dgv_HangHoa.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_HangHoa.RowTemplate.Height = 29;
            dgv_HangHoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_HangHoa.Size = new Size(905, 300);
            dgv_HangHoa.TabIndex = 32;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã hàng hóa";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên hàng hóa";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 360;
            // 
            // Column3
            // 
            Column3.HeaderText = "Đơn vị tính";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 180;
            // 
            // Column4
            // 
            Column4.HeaderText = "Số lượng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 160;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(269, 133);
            label2.Name = "label2";
            label2.Size = new Size(130, 24);
            label2.TabIndex = 33;
            label2.Text = "Mã xuất hàng:";
            // 
            // tb_MaXuatHang
            // 
            tb_MaXuatHang.BackColor = SystemColors.Window;
            tb_MaXuatHang.BorderColor = Color.FromArgb(173, 181, 189);
            tb_MaXuatHang.BorderFocusColor = Color.Black;
            tb_MaXuatHang.BorderRadius = 10;
            tb_MaXuatHang.BorderSize = 1;
            tb_MaXuatHang.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_MaXuatHang.ForeColor = Color.Black;
            tb_MaXuatHang.Location = new Point(449, 125);
            tb_MaXuatHang.Margin = new Padding(4);
            tb_MaXuatHang.Multiline = false;
            tb_MaXuatHang.Name = "tb_MaXuatHang";
            tb_MaXuatHang.Padding = new Padding(10, 7, 10, 7);
            tb_MaXuatHang.PasswordChar = false;
            tb_MaXuatHang.PlaceholderColor = Color.DarkGray;
            tb_MaXuatHang.PlaceholderText = "";
            tb_MaXuatHang.ReadOnly = true;
            tb_MaXuatHang.Size = new Size(272, 39);
            tb_MaXuatHang.TabIndex = 34;
            tb_MaXuatHang.Texts = "";
            tb_MaXuatHang.UnderlinedStyle = false;
            // 
            // tb_NguoiXuatHang
            // 
            tb_NguoiXuatHang.BackColor = SystemColors.Window;
            tb_NguoiXuatHang.BorderColor = Color.FromArgb(173, 181, 189);
            tb_NguoiXuatHang.BorderFocusColor = Color.Black;
            tb_NguoiXuatHang.BorderRadius = 10;
            tb_NguoiXuatHang.BorderSize = 1;
            tb_NguoiXuatHang.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_NguoiXuatHang.ForeColor = Color.Black;
            tb_NguoiXuatHang.Location = new Point(449, 172);
            tb_NguoiXuatHang.Margin = new Padding(4);
            tb_NguoiXuatHang.Multiline = false;
            tb_NguoiXuatHang.Name = "tb_NguoiXuatHang";
            tb_NguoiXuatHang.Padding = new Padding(10, 7, 10, 7);
            tb_NguoiXuatHang.PasswordChar = false;
            tb_NguoiXuatHang.PlaceholderColor = Color.DarkGray;
            tb_NguoiXuatHang.PlaceholderText = "";
            tb_NguoiXuatHang.ReadOnly = true;
            tb_NguoiXuatHang.Size = new Size(272, 39);
            tb_NguoiXuatHang.TabIndex = 36;
            tb_NguoiXuatHang.Texts = "";
            tb_NguoiXuatHang.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(269, 178);
            label3.Name = "label3";
            label3.Size = new Size(154, 24);
            label3.TabIndex = 35;
            label3.Text = "Người xuất hàng:";
            // 
            // tb_NgayXuatHang
            // 
            tb_NgayXuatHang.BackColor = SystemColors.Window;
            tb_NgayXuatHang.BorderColor = Color.FromArgb(173, 181, 189);
            tb_NgayXuatHang.BorderFocusColor = Color.Black;
            tb_NgayXuatHang.BorderRadius = 10;
            tb_NgayXuatHang.BorderSize = 1;
            tb_NgayXuatHang.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_NgayXuatHang.ForeColor = Color.Black;
            tb_NgayXuatHang.Location = new Point(902, 125);
            tb_NgayXuatHang.Margin = new Padding(4);
            tb_NgayXuatHang.Multiline = false;
            tb_NgayXuatHang.Name = "tb_NgayXuatHang";
            tb_NgayXuatHang.Padding = new Padding(10, 7, 10, 7);
            tb_NgayXuatHang.PasswordChar = false;
            tb_NgayXuatHang.PlaceholderColor = Color.DarkGray;
            tb_NgayXuatHang.PlaceholderText = "";
            tb_NgayXuatHang.ReadOnly = true;
            tb_NgayXuatHang.Size = new Size(272, 39);
            tb_NgayXuatHang.TabIndex = 38;
            tb_NgayXuatHang.Texts = "";
            tb_NgayXuatHang.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(751, 133);
            label5.Name = "label5";
            label5.Size = new Size(144, 24);
            label5.TabIndex = 37;
            label5.Text = "Ngày xuất hàng:";
            // 
            // btn_Sua
            // 
            btn_Sua.BackColor = Color.FromArgb(229, 1, 17);
            btn_Sua.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_Sua.BorderColor = Color.PaleVioletRed;
            btn_Sua.BorderRadius = 8;
            btn_Sua.BorderSize = 0;
            btn_Sua.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_Sua.FlatStyle = FlatStyle.Flat;
            btn_Sua.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Sua.ForeColor = Color.White;
            btn_Sua.Location = new Point(1008, 525);
            btn_Sua.Margin = new Padding(3, 4, 3, 4);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(80, 35);
            btn_Sua.TabIndex = 40;
            btn_Sua.Text = "Sửa";
            btn_Sua.TextColor = Color.White;
            btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Luu
            // 
            btn_Luu.BackColor = Color.FromArgb(108, 117, 125);
            btn_Luu.BackgroundColor = Color.FromArgb(108, 117, 125);
            btn_Luu.BorderColor = Color.PaleVioletRed;
            btn_Luu.BorderRadius = 8;
            btn_Luu.BorderSize = 0;
            btn_Luu.Enabled = false;
            btn_Luu.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_Luu.FlatStyle = FlatStyle.Flat;
            btn_Luu.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Luu.ForeColor = Color.White;
            btn_Luu.Location = new Point(1094, 525);
            btn_Luu.Margin = new Padding(3, 4, 3, 4);
            btn_Luu.Name = "btn_Luu";
            btn_Luu.Size = new Size(80, 35);
            btn_Luu.TabIndex = 41;
            btn_Luu.Text = "Lưu";
            btn_Luu.TextColor = Color.White;
            btn_Luu.UseVisualStyleBackColor = false;
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
            metroPanel1.TabIndex = 42;
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
            btn_NhapHang.ForeColor = Color.FromArgb(160, 159, 159);
            btn_NhapHang.Location = new Point(-1, 302);
            btn_NhapHang.Margin = new Padding(3, 4, 3, 4);
            btn_NhapHang.Name = "btn_NhapHang";
            btn_NhapHang.Size = new Size(263, 64);
            btn_NhapHang.TabIndex = 18;
            btn_NhapHang.Text = "Nhập hàng";
            btn_NhapHang.TextColor = Color.FromArgb(160, 159, 159);
            btn_NhapHang.UseVisualStyleBackColor = false;
            btn_NhapHang.Click += btn_NhapHang_Click;
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
            btn_XuatHang.ForeColor = Color.Black;
            btn_XuatHang.Location = new Point(-1, 243);
            btn_XuatHang.Margin = new Padding(3, 4, 3, 4);
            btn_XuatHang.Name = "btn_XuatHang";
            btn_XuatHang.Size = new Size(264, 64);
            btn_XuatHang.TabIndex = 17;
            btn_XuatHang.Text = "Xuất hàng";
            btn_XuatHang.TextColor = Color.Black;
            btn_XuatHang.UseVisualStyleBackColor = false;
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
            // KiemKhoXemPhieuXuatHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 605);
            Controls.Add(metroPanel1);
            Controls.Add(btn_Luu);
            Controls.Add(btn_Sua);
            Controls.Add(tb_NgayXuatHang);
            Controls.Add(label5);
            Controls.Add(tb_NguoiXuatHang);
            Controls.Add(label3);
            Controls.Add(tb_MaXuatHang);
            Controls.Add(label2);
            Controls.Add(dgv_HangHoa);
            Controls.Add(metroGrid1);
            Controls.Add(label1);
            Controls.Add(btn_DangXuat);
            Name = "KiemKhoXemPhieuXuatHang";
            Text = "v";
            ((System.ComponentModel.ISupportInitialize)metroGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_HangHoa).EndInit();
            metroPanel1.ResumeLayout(false);
            metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomControls.RoundedButton btn_DangXuat;
        private Label label1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroGrid dgv_HangHoa;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label2;
        private CustomControls.LeftAlignRoundedTextBox tb_MaXuatHang;
        private CustomControls.LeftAlignRoundedTextBox tb_NguoiXuatHang;
        private Label label3;
        private CustomControls.LeftAlignRoundedTextBox tb_NgayXuatHang;
        private Label label5;
        private CustomControls.RoundedButton btn_Sua;
        private CustomControls.RoundedButton btn_Luu;
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