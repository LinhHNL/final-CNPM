﻿namespace WinFormsApp2.KhoPage
{
    partial class KiemKhoTaoPhieuXuatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiemKhoTaoPhieuXuatHang));
            this.btn_DangXuat = new WinFormsApp2.CustomControls.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.dgv_HangHoa = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_MaXuatHang = new WinFormsApp2.CustomControls.LeftAlignRoundedTextBox();
            this.tb_NguoiXuatHang = new WinFormsApp2.CustomControls.LeftAlignRoundedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_NgayXuatHang = new WinFormsApp2.CustomControls.LeftAlignRoundedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_TaoPhieu = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_Add = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.btn_NhapHang = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_XuatHang = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_HangTrongKho = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_KiemKho = new WinFormsApp2.CustomControls.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_DangXuat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_DangXuat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_DangXuat.BorderRadius = 8;
            this.btn_DangXuat.BorderSize = 0;
            this.btn_DangXuat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangXuat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DangXuat.ForeColor = System.Drawing.Color.White;
            this.btn_DangXuat.Location = new System.Drawing.Point(1057, 35);
            this.btn_DangXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(117, 35);
            this.btn_DangXuat.TabIndex = 22;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.TextColor = System.Drawing.Color.White;
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(265, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 40);
            this.label1.TabIndex = 29;
            this.label1.Text = "Phiếu xuất hàng";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(381, 153);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidth = 51;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 29;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(8, 8);
            this.metroGrid1.TabIndex = 31;
            // 
            // dgv_HangHoa
            // 
            this.dgv_HangHoa.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgv_HangHoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_HangHoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_HangHoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_HangHoa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_HangHoa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_HangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_HangHoa.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_HangHoa.EnableHeadersVisualStyles = false;
            this.dgv_HangHoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_HangHoa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.dgv_HangHoa.Location = new System.Drawing.Point(268, 218);
            this.dgv_HangHoa.Name = "dgv_HangHoa";
            this.dgv_HangHoa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HangHoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_HangHoa.RowHeadersVisible = false;
            this.dgv_HangHoa.RowHeadersWidth = 51;
            this.dgv_HangHoa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_HangHoa.RowTemplate.Height = 29;
            this.dgv_HangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HangHoa.Size = new System.Drawing.Size(905, 300);
            this.dgv_HangHoa.TabIndex = 32;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã hàng hóa";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên hàng hóa";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 360;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn vị tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 160;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(269, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã xuất hàng:";
            // 
            // tb_MaXuatHang
            // 
            this.tb_MaXuatHang.BackColor = System.Drawing.SystemColors.Window;
            this.tb_MaXuatHang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.tb_MaXuatHang.BorderFocusColor = System.Drawing.Color.Black;
            this.tb_MaXuatHang.BorderRadius = 10;
            this.tb_MaXuatHang.BorderSize = 1;
            this.tb_MaXuatHang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_MaXuatHang.ForeColor = System.Drawing.Color.Black;
            this.tb_MaXuatHang.Location = new System.Drawing.Point(449, 125);
            this.tb_MaXuatHang.Margin = new System.Windows.Forms.Padding(4);
            this.tb_MaXuatHang.Multiline = false;
            this.tb_MaXuatHang.Name = "tb_MaXuatHang";
            this.tb_MaXuatHang.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_MaXuatHang.PasswordChar = false;
            this.tb_MaXuatHang.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_MaXuatHang.PlaceholderText = "";
            this.tb_MaXuatHang.Size = new System.Drawing.Size(272, 39);
            this.tb_MaXuatHang.TabIndex = 34;
            this.tb_MaXuatHang.Texts = "";
            this.tb_MaXuatHang.UnderlinedStyle = false;
            // 
            // tb_NguoiXuatHang
            // 
            this.tb_NguoiXuatHang.BackColor = System.Drawing.SystemColors.Window;
            this.tb_NguoiXuatHang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.tb_NguoiXuatHang.BorderFocusColor = System.Drawing.Color.Black;
            this.tb_NguoiXuatHang.BorderRadius = 10;
            this.tb_NguoiXuatHang.BorderSize = 1;
            this.tb_NguoiXuatHang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_NguoiXuatHang.ForeColor = System.Drawing.Color.Black;
            this.tb_NguoiXuatHang.Location = new System.Drawing.Point(449, 172);
            this.tb_NguoiXuatHang.Margin = new System.Windows.Forms.Padding(4);
            this.tb_NguoiXuatHang.Multiline = false;
            this.tb_NguoiXuatHang.Name = "tb_NguoiXuatHang";
            this.tb_NguoiXuatHang.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_NguoiXuatHang.PasswordChar = false;
            this.tb_NguoiXuatHang.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_NguoiXuatHang.PlaceholderText = "";
            this.tb_NguoiXuatHang.Size = new System.Drawing.Size(272, 39);
            this.tb_NguoiXuatHang.TabIndex = 36;
            this.tb_NguoiXuatHang.Texts = "";
            this.tb_NguoiXuatHang.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(269, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Người xuất hàng:";
            // 
            // tb_NgayXuatHang
            // 
            this.tb_NgayXuatHang.BackColor = System.Drawing.SystemColors.Window;
            this.tb_NgayXuatHang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.tb_NgayXuatHang.BorderFocusColor = System.Drawing.Color.Black;
            this.tb_NgayXuatHang.BorderRadius = 10;
            this.tb_NgayXuatHang.BorderSize = 1;
            this.tb_NgayXuatHang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_NgayXuatHang.ForeColor = System.Drawing.Color.Black;
            this.tb_NgayXuatHang.Location = new System.Drawing.Point(902, 125);
            this.tb_NgayXuatHang.Margin = new System.Windows.Forms.Padding(4);
            this.tb_NgayXuatHang.Multiline = false;
            this.tb_NgayXuatHang.Name = "tb_NgayXuatHang";
            this.tb_NgayXuatHang.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_NgayXuatHang.PasswordChar = false;
            this.tb_NgayXuatHang.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_NgayXuatHang.PlaceholderText = "";
            this.tb_NgayXuatHang.Size = new System.Drawing.Size(272, 39);
            this.tb_NgayXuatHang.TabIndex = 38;
            this.tb_NgayXuatHang.Texts = "";
            this.tb_NgayXuatHang.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(751, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ngày xuất hàng:";
            // 
            // btn_TaoPhieu
            // 
            this.btn_TaoPhieu.BackColor = System.Drawing.Color.Black;
            this.btn_TaoPhieu.BackgroundColor = System.Drawing.Color.Black;
            this.btn_TaoPhieu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TaoPhieu.BorderRadius = 8;
            this.btn_TaoPhieu.BorderSize = 0;
            this.btn_TaoPhieu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_TaoPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoPhieu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TaoPhieu.ForeColor = System.Drawing.Color.White;
            this.btn_TaoPhieu.Location = new System.Drawing.Point(1057, 560);
            this.btn_TaoPhieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TaoPhieu.Name = "btn_TaoPhieu";
            this.btn_TaoPhieu.Size = new System.Drawing.Size(117, 35);
            this.btn_TaoPhieu.TabIndex = 39;
            this.btn_TaoPhieu.Text = "Tạo phiếu";
            this.btn_TaoPhieu.TextColor = System.Drawing.Color.White;
            this.btn_TaoPhieu.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.Location = new System.Drawing.Point(1141, 524);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(33, 34);
            this.btn_Add.TabIndex = 41;
            this.btn_Add.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.Controls.Add(this.pictureBox2);
            this.metroPanel1.Controls.Add(this.metroPanel7);
            this.metroPanel1.Controls.Add(this.btn_NhapHang);
            this.metroPanel1.Controls.Add(this.btn_XuatHang);
            this.metroPanel1.Controls.Add(this.btn_HangTrongKho);
            this.metroPanel1.Controls.Add(this.btn_KiemKho);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(4, 35);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(259, 570);
            this.metroPanel1.TabIndex = 42;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.label4.Location = new System.Drawing.Point(70, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 28);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tên tài khoản";
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
            // btn_NhapHang
            // 
            this.btn_NhapHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.btn_NhapHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.btn_NhapHang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_NhapHang.BorderRadius = 0;
            this.btn_NhapHang.BorderSize = 0;
            this.btn_NhapHang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_NhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhapHang.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_NhapHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_NhapHang.Location = new System.Drawing.Point(-1, 302);
            this.btn_NhapHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_NhapHang.Name = "btn_NhapHang";
            this.btn_NhapHang.Size = new System.Drawing.Size(263, 64);
            this.btn_NhapHang.TabIndex = 18;
            this.btn_NhapHang.Text = "Nhập hàng";
            this.btn_NhapHang.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_NhapHang.UseVisualStyleBackColor = false;
            this.btn_NhapHang.Click += new System.EventHandler(this.btn_NhapHang_Click);
            // 
            // btn_XuatHang
            // 
            this.btn_XuatHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.btn_XuatHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.btn_XuatHang.BorderColor = System.Drawing.Color.Silver;
            this.btn_XuatHang.BorderRadius = 0;
            this.btn_XuatHang.BorderSize = 0;
            this.btn_XuatHang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_XuatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XuatHang.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_XuatHang.ForeColor = System.Drawing.Color.Black;
            this.btn_XuatHang.Location = new System.Drawing.Point(-1, 243);
            this.btn_XuatHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XuatHang.Name = "btn_XuatHang";
            this.btn_XuatHang.Size = new System.Drawing.Size(264, 64);
            this.btn_XuatHang.TabIndex = 17;
            this.btn_XuatHang.Text = "Xuất hàng";
            this.btn_XuatHang.TextColor = System.Drawing.Color.Black;
            this.btn_XuatHang.UseVisualStyleBackColor = false;
            // 
            // btn_HangTrongKho
            // 
            this.btn_HangTrongKho.BackColor = System.Drawing.Color.White;
            this.btn_HangTrongKho.BackgroundColor = System.Drawing.Color.White;
            this.btn_HangTrongKho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_HangTrongKho.BorderRadius = 0;
            this.btn_HangTrongKho.BorderSize = 0;
            this.btn_HangTrongKho.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_HangTrongKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HangTrongKho.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_HangTrongKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_HangTrongKho.Location = new System.Drawing.Point(0, 130);
            this.btn_HangTrongKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_HangTrongKho.Name = "btn_HangTrongKho";
            this.btn_HangTrongKho.Size = new System.Drawing.Size(262, 60);
            this.btn_HangTrongKho.TabIndex = 16;
            this.btn_HangTrongKho.Text = "Hàng trong kho";
            this.btn_HangTrongKho.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_HangTrongKho.UseVisualStyleBackColor = false;
            // 
            // btn_KiemKho
            // 
            this.btn_KiemKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_KiemKho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_KiemKho.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_KiemKho.BorderRadius = 0;
            this.btn_KiemKho.BorderSize = 0;
            this.btn_KiemKho.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_KiemKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KiemKho.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KiemKho.ForeColor = System.Drawing.Color.White;
            this.btn_KiemKho.Location = new System.Drawing.Point(0, 189);
            this.btn_KiemKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_KiemKho.Name = "btn_KiemKho";
            this.btn_KiemKho.Size = new System.Drawing.Size(262, 56);
            this.btn_KiemKho.TabIndex = 16;
            this.btn_KiemKho.Text = "Kiểm kho";
            this.btn_KiemKho.TextColor = System.Drawing.Color.White;
            this.btn_KiemKho.UseVisualStyleBackColor = false;
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
            // KiemKhoTaoPhieuXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 605);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_TaoPhieu);
            this.Controls.Add(this.tb_NgayXuatHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_NguoiXuatHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_MaXuatHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_HangHoa);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DangXuat);
            this.Name = "KiemKhoTaoPhieuXuatHang";
            this.Text = "v";
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private CustomControls.RoundedButton btn_TaoPhieu;
        private PictureBox btn_Add;
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