namespace WinFormsApp2.KhoPage
{
    partial class KiemKhoXemPhieuNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiemKhoXemPhieuNhapHang));
            btn_DangXuat = new CustomControls.RoundedButton();
            label1 = new Label();
            metroGrid1 = new MetroFramework.Controls.MetroGrid();
            dgv_HangHoa = new MetroFramework.Controls.MetroGrid();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            tb_MaNhapHang = new CustomControls.LeftAlignRoundedTextBox();
            tb_NgayNhap = new CustomControls.LeftAlignRoundedTextBox();
            label3 = new Label();
            btn_Sua = new CustomControls.RoundedButton();
            btn_Luu = new CustomControls.RoundedButton();
            btn_XuatFile = new CustomControls.RoundedButton();
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
            label1.Size = new Size(248, 40);
            label1.TabIndex = 29;
            label1.Text = "Phiếu nhập hàng";
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
            // dgv_HangHoa
            // 
            dgv_HangHoa.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 235, 235);
            dgv_HangHoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_HangHoa.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgv_HangHoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv_HangHoa.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgv_HangHoa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(253, 197, 183);
            dataGridViewCellStyle5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(253, 197, 183);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv_HangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv_HangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HangHoa.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv_HangHoa.DefaultCellStyle = dataGridViewCellStyle6;
            dgv_HangHoa.EnableHeadersVisualStyles = false;
            dgv_HangHoa.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgv_HangHoa.GridColor = Color.FromArgb(197, 198, 198);
            dgv_HangHoa.Location = new Point(268, 218);
            dgv_HangHoa.Name = "dgv_HangHoa";
            dgv_HangHoa.ReadOnly = true;
            dgv_HangHoa.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_HangHoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            label2.Size = new Size(136, 24);
            label2.TabIndex = 33;
            label2.Text = "Mã nhập hàng:";
            // 
            // tb_MaNhapHang
            // 
            tb_MaNhapHang.BackColor = SystemColors.Window;
            tb_MaNhapHang.BorderColor = Color.FromArgb(173, 181, 189);
            tb_MaNhapHang.BorderFocusColor = Color.Black;
            tb_MaNhapHang.BorderRadius = 10;
            tb_MaNhapHang.BorderSize = 1;
            tb_MaNhapHang.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_MaNhapHang.ForeColor = Color.Black;
            tb_MaNhapHang.Location = new Point(449, 125);
            tb_MaNhapHang.Margin = new Padding(4);
            tb_MaNhapHang.Multiline = false;
            tb_MaNhapHang.Name = "tb_MaNhapHang";
            tb_MaNhapHang.Padding = new Padding(10, 7, 10, 7);
            tb_MaNhapHang.PasswordChar = false;
            tb_MaNhapHang.PlaceholderColor = Color.DarkGray;
            tb_MaNhapHang.PlaceholderText = "";
            tb_MaNhapHang.ReadOnly = true;
            tb_MaNhapHang.Size = new Size(272, 39);
            tb_MaNhapHang.TabIndex = 34;
            tb_MaNhapHang.Texts = "";
            tb_MaNhapHang.UnderlinedStyle = false;
            // 
            // tb_NgayNhap
            // 
            tb_NgayNhap.BackColor = SystemColors.Window;
            tb_NgayNhap.BorderColor = Color.FromArgb(173, 181, 189);
            tb_NgayNhap.BorderFocusColor = Color.Black;
            tb_NgayNhap.BorderRadius = 10;
            tb_NgayNhap.BorderSize = 1;
            tb_NgayNhap.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_NgayNhap.ForeColor = Color.Black;
            tb_NgayNhap.Location = new Point(449, 172);
            tb_NgayNhap.Margin = new Padding(4);
            tb_NgayNhap.Multiline = false;
            tb_NgayNhap.Name = "tb_NgayNhap";
            tb_NgayNhap.Padding = new Padding(10, 7, 10, 7);
            tb_NgayNhap.PasswordChar = false;
            tb_NgayNhap.PlaceholderColor = Color.DarkGray;
            tb_NgayNhap.PlaceholderText = "";
            tb_NgayNhap.ReadOnly = true;
            tb_NgayNhap.Size = new Size(272, 39);
            tb_NgayNhap.TabIndex = 36;
            tb_NgayNhap.Texts = "";
            tb_NgayNhap.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(269, 178);
            label3.Name = "label3";
            label3.Size = new Size(104, 24);
            label3.TabIndex = 35;
            label3.Text = "Ngày nhập:";
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
            btn_XuatFile.Location = new Point(1057, 85);
            btn_XuatFile.Margin = new Padding(3, 4, 3, 4);
            btn_XuatFile.Name = "btn_XuatFile";
            btn_XuatFile.Size = new Size(117, 35);
            btn_XuatFile.TabIndex = 43;
            btn_XuatFile.Text = " Xuất file";
            btn_XuatFile.TextColor = Color.FromArgb(229, 1, 17);
            btn_XuatFile.UseVisualStyleBackColor = false;
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
            metroPanel1.Location = new Point(3, 35);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(259, 570);
            metroPanel1.TabIndex = 44;
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
            // KiemKhoXemPhieuNhapHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 605);
            Controls.Add(metroPanel1);
            Controls.Add(btn_XuatFile);
            Controls.Add(btn_Luu);
            Controls.Add(btn_Sua);
            Controls.Add(tb_NgayNhap);
            Controls.Add(label3);
            Controls.Add(tb_MaNhapHang);
            Controls.Add(label2);
            Controls.Add(dgv_HangHoa);
            Controls.Add(metroGrid1);
            Controls.Add(label1);
            Controls.Add(btn_DangXuat);
            Name = "KiemKhoXemPhieuNhapHang";
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
        private CustomControls.LeftAlignRoundedTextBox tb_MaNhapHang;
        private CustomControls.LeftAlignRoundedTextBox tb_NgayNhap;
        private Label label3;
        private CustomControls.RoundedButton btn_Sua;
        private CustomControls.RoundedButton btn_Luu;
        private CustomControls.RoundedButton btn_XuatFile;
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