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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cb_ChoosingType = new MetroFramework.Controls.MetroComboBox();
            this.tb_CustomerIDName = new WinFormsApp2.CustomControls.LeftAlignRoundedTextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.lbl_AccountName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_SignOut = new WinFormsApp2.CustomControls.RoundedButton();
            this.lbl_CustomerList = new System.Windows.Forms.Label();
            this.btn_Add = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_Delete = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_ExportFile = new WinFormsApp2.CustomControls.RoundedButton();
            this.dgv_CustomerList = new MetroFramework.Controls.MetroGrid();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.cb_ChoosingType);
            this.metroPanel1.Controls.Add(this.tb_CustomerIDName);
            this.metroPanel1.Controls.Add(this.lbl_Search);
            this.metroPanel1.Controls.Add(this.lbl_AccountName);
            this.metroPanel1.Controls.Add(this.pictureBox2);
            this.metroPanel1.Controls.Add(this.metroPanel7);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 11;
            this.metroPanel1.Location = new System.Drawing.Point(0, 42);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(259, 561);
            this.metroPanel1.TabIndex = 45;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cb_ChoosingType
            // 
            this.cb_ChoosingType.FormattingEnabled = true;
            this.cb_ChoosingType.ItemHeight = 24;
            this.cb_ChoosingType.Location = new System.Drawing.Point(22, 253);
            this.cb_ChoosingType.Name = "cb_ChoosingType";
            this.cb_ChoosingType.Size = new System.Drawing.Size(200, 30);
            this.cb_ChoosingType.TabIndex = 49;
            this.cb_ChoosingType.UseSelectable = true;
            // 
            // tb_CustomerIDName
            // 
<<<<<<< HEAD
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
=======
            this.tb_CustomerIDName.BackColor = System.Drawing.SystemColors.Window;
            this.tb_CustomerIDName.BorderColor = System.Drawing.Color.Gray;
            this.tb_CustomerIDName.BorderFocusColor = System.Drawing.Color.Black;
            this.tb_CustomerIDName.BorderRadius = 10;
            this.tb_CustomerIDName.BorderSize = 1;
            this.tb_CustomerIDName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_CustomerIDName.ForeColor = System.Drawing.Color.Black;
            this.tb_CustomerIDName.Location = new System.Drawing.Point(22, 181);
            this.tb_CustomerIDName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CustomerIDName.Multiline = false;
            this.tb_CustomerIDName.Name = "tb_CustomerIDName";
            this.tb_CustomerIDName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_CustomerIDName.PasswordChar = false;
            this.tb_CustomerIDName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_CustomerIDName.PlaceholderText = "Mã/ Tên Khách Hàng";
            this.tb_CustomerIDName.ReadOnly = false;
            this.tb_CustomerIDName.Size = new System.Drawing.Size(200, 39);
            this.tb_CustomerIDName.TabIndex = 46;
            this.tb_CustomerIDName.Texts = "";
            this.tb_CustomerIDName.UnderlinedStyle = false;
>>>>>>> 8d249ced943f806d153ec3e35ac6189216f94312
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Search.Location = new System.Drawing.Point(81, 136);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(91, 28);
            this.lbl_Search.TabIndex = 48;
            this.lbl_Search.Text = "Tìm kiếm";
            // 
            // lbl_AccountName
            // 
            this.lbl_AccountName.AutoSize = true;
            this.lbl_AccountName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AccountName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.lbl_AccountName.Location = new System.Drawing.Point(70, 85);
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
            this.pictureBox2.Size = new System.Drawing.Size(30, 27);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // metroPanel7
            // 
            this.metroPanel7.BackColor = System.Drawing.Color.Black;
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 11;
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
            this.pictureBox1.Location = new System.Drawing.Point(101, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 51);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_SignOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_SignOut.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_SignOut.BorderRadius = 8;
            this.btn_SignOut.BorderSize = 0;
            this.btn_SignOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_SignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SignOut.ForeColor = System.Drawing.Color.White;
            this.btn_SignOut.Location = new System.Drawing.Point(936, 42);
            this.btn_SignOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(117, 35);
            this.btn_SignOut.TabIndex = 50;
            this.btn_SignOut.Text = "Đăng xuất";
            this.btn_SignOut.TextColor = System.Drawing.Color.White;
            this.btn_SignOut.UseVisualStyleBackColor = false;
            // 
            // lbl_CustomerList
            // 
            this.lbl_CustomerList.AutoSize = true;
            this.lbl_CustomerList.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CustomerList.Location = new System.Drawing.Point(274, 103);
            this.lbl_CustomerList.Name = "lbl_CustomerList";
            this.lbl_CustomerList.Size = new System.Drawing.Size(316, 38);
            this.lbl_CustomerList.TabIndex = 51;
            this.lbl_CustomerList.Text = "Danh Sách khách hàng";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            this.btn_Add.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            this.btn_Add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btn_Add.BorderRadius = 8;
            this.btn_Add.BorderSize = 1;
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Add.Location = new System.Drawing.Point(704, 103);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(87, 35);
            this.btn_Add.TabIndex = 52;
            this.btn_Add.Text = "+ Thêm";
            this.btn_Add.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            this.btn_Delete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            this.btn_Delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btn_Delete.BorderRadius = 8;
            this.btn_Delete.BorderSize = 1;
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Delete.Location = new System.Drawing.Point(831, 103);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(77, 35);
            this.btn_Delete.TabIndex = 53;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_ExportFile
            // 
            this.btn_ExportFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            this.btn_ExportFile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            this.btn_ExportFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btn_ExportFile.BorderRadius = 8;
            this.btn_ExportFile.BorderSize = 1;
            this.btn_ExportFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_ExportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ExportFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_ExportFile.Location = new System.Drawing.Point(936, 103);
            this.btn_ExportFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ExportFile.Name = "btn_ExportFile";
            this.btn_ExportFile.Size = new System.Drawing.Size(117, 35);
            this.btn_ExportFile.TabIndex = 54;
            this.btn_ExportFile.Text = " Xuất file";
            this.btn_ExportFile.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_ExportFile.UseVisualStyleBackColor = false;
            // 
            // dgv_CustomerList
            // 
<<<<<<< HEAD
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
=======
            this.dgv_CustomerList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgv_CustomerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CustomerList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_CustomerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_CustomerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_CustomerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CustomerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.FullName,
            this.Phone,
            this.Address,
            this.MembershipType});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CustomerList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_CustomerList.EnableHeadersVisualStyles = false;
            this.dgv_CustomerList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_CustomerList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.dgv_CustomerList.Location = new System.Drawing.Point(274, 170);
            this.dgv_CustomerList.Name = "dgv_CustomerList";
            this.dgv_CustomerList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CustomerList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_CustomerList.RowHeadersVisible = false;
            this.dgv_CustomerList.RowHeadersWidth = 51;
            this.dgv_CustomerList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_CustomerList.RowTemplate.Height = 29;
            this.dgv_CustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CustomerList.Size = new System.Drawing.Size(779, 357);
            this.dgv_CustomerList.TabIndex = 55;
>>>>>>> 8d249ced943f806d153ec3e35ac6189216f94312
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Mã khách hàng";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Width = 170;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Họ tên";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 120;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Số Điện Thoại";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 150;
            // 
            // Address
            // 
            this.Address.HeaderText = "Địa Chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 130;
            // 
            // MembershipType
            // 
            this.MembershipType.HeaderText = "Loại Thành Viên";
            this.MembershipType.MinimumWidth = 6;
            this.MembershipType.Name = "MembershipType";
            this.MembershipType.Width = 180;
            // 
            // ListCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 602);
            this.Controls.Add(this.dgv_CustomerList);
            this.Controls.Add(this.btn_ExportFile);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_CustomerList);
            this.Controls.Add(this.btn_SignOut);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ListCustomerForm";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Label lbl_AccountName;
        private PictureBox pictureBox2;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private PictureBox pictureBox1;
        private Label lbl_Search;
        private CustomControls.LeftAlignRoundedTextBox tb_CustomerIDName;
        private MetroFramework.Controls.MetroComboBox cb_ChoosingType;
        private CustomControls.RoundedButton btn_SignOut;
        private Label lbl_CustomerList;
        private CustomControls.RoundedButton btn_Add;
        private CustomControls.RoundedButton btn_Delete;
        private CustomControls.RoundedButton btn_ExportFile;
        private MetroFramework.Controls.MetroGrid dgv_CustomerList;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn MembershipType;
    }
}