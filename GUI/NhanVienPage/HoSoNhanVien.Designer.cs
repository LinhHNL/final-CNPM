namespace WinFormsApp2.NhanVienPage
{
    partial class HoSoNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoSoNhanVien));
            this.btn_Signout = new WinFormsApp2.CustomControls.RoundedButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.dgv_NhanVien = new MetroFramework.Controls.MetroGrid();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_StaffID = new WinFormsApp2.CustomControls.LeftAlignRoundedTextBox();
            this.btn_ExportFile = new WinFormsApp2.CustomControls.RoundedButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_PayRoll = new WinFormsApp2.CustomControls.RoundedButton();
            this.lbl_AccountName = new System.Windows.Forms.Label();
            this.pb_AccountIcon = new System.Windows.Forms.PictureBox();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.btn_letter = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_TimekeepingManagement = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_StaffProfile = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_WorkScheduleManagement = new WinFormsApp2.CustomControls.RoundedButton();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.btn_Add = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_Delete = new WinFormsApp2.CustomControls.RoundedButton();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.cb_Department = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AccountIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Signout
            // 
            this.btn_Signout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Signout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Signout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Signout.BorderRadius = 8;
            this.btn_Signout.BorderSize = 0;
            this.btn_Signout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Signout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Signout.ForeColor = System.Drawing.Color.White;
            this.btn_Signout.Location = new System.Drawing.Point(1057, 35);
            this.btn_Signout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Signout.Name = "btn_Signout";
            this.btn_Signout.Size = new System.Drawing.Size(117, 35);
            this.btn_Signout.TabIndex = 22;
            this.btn_Signout.Text = "Đăng xuất";
            this.btn_Signout.TextColor = System.Drawing.Color.White;
            this.btn_Signout.UseVisualStyleBackColor = false;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(381, 153);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.metroGrid1.RowHeadersWidth = 51;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 29;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(8, 8);
            this.metroGrid1.TabIndex = 31;
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgv_NhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_NhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_NhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_NhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_NhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffID,
            this.FullName,
            this.Department,
            this.Position,
            this.StartDate,
            this.Status});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NhanVien.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_NhanVien.EnableHeadersVisualStyles = false;
            this.dgv_NhanVien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_NhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.dgv_NhanVien.Location = new System.Drawing.Point(271, 141);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_NhanVien.RowHeadersVisible = false;
            this.dgv_NhanVien.RowHeadersWidth = 51;
            this.dgv_NhanVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_NhanVien.RowTemplate.Height = 29;
            this.dgv_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NhanVien.Size = new System.Drawing.Size(905, 464);
            this.dgv_NhanVien.TabIndex = 32;
            // 
            // StaffID
            // 
            this.StaffID.HeaderText = "Mã nhân viên";
            this.StaffID.MinimumWidth = 6;
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            this.StaffID.Width = 170;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Họ tên";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 120;
            // 
            // Department
            // 
            this.Department.HeaderText = "Phòng ban";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.Width = 150;
            // 
            // Position
            // 
            this.Position.HeaderText = "Chức vụ";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.Width = 130;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Ngày vào làm";
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            this.StartDate.Width = 180;
            // 
            // Status
            // 
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // tb_StaffID
            // 
            this.tb_StaffID.BackColor = System.Drawing.SystemColors.Window;
            this.tb_StaffID.BorderColor = System.Drawing.Color.DimGray;
            this.tb_StaffID.BorderFocusColor = System.Drawing.Color.Black;
            this.tb_StaffID.BorderRadius = 10;
            this.tb_StaffID.BorderSize = 1;
            this.tb_StaffID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_StaffID.ForeColor = System.Drawing.Color.Black;
            this.tb_StaffID.Location = new System.Drawing.Point(359, 85);
            this.tb_StaffID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_StaffID.Multiline = false;
            this.tb_StaffID.Name = "tb_StaffID";
            this.tb_StaffID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_StaffID.PasswordChar = false;
            this.tb_StaffID.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tb_StaffID.PlaceholderText = "Mã nhân viên";
            this.tb_StaffID.ReadOnly = false;
            this.tb_StaffID.Size = new System.Drawing.Size(272, 39);
            this.tb_StaffID.TabIndex = 34;
            this.tb_StaffID.Texts = "";
            this.tb_StaffID.UnderlinedStyle = false;
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
            this.btn_ExportFile.Location = new System.Drawing.Point(1057, 85);
            this.btn_ExportFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ExportFile.Name = "btn_ExportFile";
            this.btn_ExportFile.Size = new System.Drawing.Size(117, 35);
            this.btn_ExportFile.TabIndex = 43;
            this.btn_ExportFile.Text = " Xuất file";
            this.btn_ExportFile.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_ExportFile.UseVisualStyleBackColor = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btn_PayRoll);
            this.metroPanel1.Controls.Add(this.lbl_AccountName);
            this.metroPanel1.Controls.Add(this.pb_AccountIcon);
            this.metroPanel1.Controls.Add(this.metroPanel7);
            this.metroPanel1.Controls.Add(this.btn_letter);
            this.metroPanel1.Controls.Add(this.btn_TimekeepingManagement);
            this.metroPanel1.Controls.Add(this.btn_StaffProfile);
            this.metroPanel1.Controls.Add(this.btn_WorkScheduleManagement);
            this.metroPanel1.Controls.Add(this.pb_Logo);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 11;
            this.metroPanel1.Location = new System.Drawing.Point(-1, 35);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(263, 571);
            this.metroPanel1.TabIndex = 44;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_PayRoll
            // 
            this.btn_PayRoll.BackColor = System.Drawing.Color.White;
            this.btn_PayRoll.BackgroundColor = System.Drawing.Color.White;
            this.btn_PayRoll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_PayRoll.BorderRadius = 0;
            this.btn_PayRoll.BorderSize = 0;
            this.btn_PayRoll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_PayRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PayRoll.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_PayRoll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_PayRoll.Location = new System.Drawing.Point(0, 363);
            this.btn_PayRoll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_PayRoll.Name = "btn_PayRoll";
            this.btn_PayRoll.Size = new System.Drawing.Size(263, 64);
            this.btn_PayRoll.TabIndex = 45;
            this.btn_PayRoll.Text = "Lương thưởng";
            this.btn_PayRoll.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_PayRoll.UseVisualStyleBackColor = false;
            this.btn_PayRoll.Click += new System.EventHandler(this.btn_LuongThuong_Click);
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
            // pb_AccountIcon
            // 
            this.pb_AccountIcon.Image = ((System.Drawing.Image)(resources.GetObject("pb_AccountIcon.Image")));
            this.pb_AccountIcon.Location = new System.Drawing.Point(34, 88);
            this.pb_AccountIcon.Name = "pb_AccountIcon";
            this.pb_AccountIcon.Size = new System.Drawing.Size(30, 27);
            this.pb_AccountIcon.TabIndex = 21;
            this.pb_AccountIcon.TabStop = false;
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
            // btn_letter
            // 
            this.btn_letter.BackColor = System.Drawing.Color.White;
            this.btn_letter.BackgroundColor = System.Drawing.Color.White;
            this.btn_letter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_letter.BorderRadius = 0;
            this.btn_letter.BorderSize = 0;
            this.btn_letter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_letter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_letter.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_letter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_letter.Location = new System.Drawing.Point(-1, 301);
            this.btn_letter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_letter.Name = "btn_letter";
            this.btn_letter.Size = new System.Drawing.Size(263, 64);
            this.btn_letter.TabIndex = 18;
            this.btn_letter.Text = "Đơn từ";
            this.btn_letter.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_letter.UseVisualStyleBackColor = false;
            this.btn_letter.Click += new System.EventHandler(this.btn_DonTu_Click);
            // 
            // btn_TimekeepingManagement
            // 
            this.btn_TimekeepingManagement.BackColor = System.Drawing.Color.White;
            this.btn_TimekeepingManagement.BackgroundColor = System.Drawing.Color.White;
            this.btn_TimekeepingManagement.BorderColor = System.Drawing.Color.Silver;
            this.btn_TimekeepingManagement.BorderRadius = 0;
            this.btn_TimekeepingManagement.BorderSize = 0;
            this.btn_TimekeepingManagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_TimekeepingManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimekeepingManagement.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TimekeepingManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_TimekeepingManagement.Location = new System.Drawing.Point(-1, 243);
            this.btn_TimekeepingManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TimekeepingManagement.Name = "btn_TimekeepingManagement";
            this.btn_TimekeepingManagement.Size = new System.Drawing.Size(264, 64);
            this.btn_TimekeepingManagement.TabIndex = 17;
            this.btn_TimekeepingManagement.Text = "Quản lý chấm công";
            this.btn_TimekeepingManagement.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_TimekeepingManagement.UseVisualStyleBackColor = false;
            this.btn_TimekeepingManagement.Click += new System.EventHandler(this.btn_QuanLyChamCong_Click);
            // 
            // btn_StaffProfile
            // 
            this.btn_StaffProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_StaffProfile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_StaffProfile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_StaffProfile.BorderRadius = 0;
            this.btn_StaffProfile.BorderSize = 0;
            this.btn_StaffProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_StaffProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StaffProfile.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_StaffProfile.ForeColor = System.Drawing.Color.White;
            this.btn_StaffProfile.Location = new System.Drawing.Point(0, 131);
            this.btn_StaffProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_StaffProfile.Name = "btn_StaffProfile";
            this.btn_StaffProfile.Size = new System.Drawing.Size(262, 60);
            this.btn_StaffProfile.TabIndex = 16;
            this.btn_StaffProfile.Text = "Hồ sơ nhân viên";
            this.btn_StaffProfile.TextColor = System.Drawing.Color.White;
            this.btn_StaffProfile.UseVisualStyleBackColor = false;
            this.btn_StaffProfile.Click += new System.EventHandler(this.btn_HoSoNhanVien_Click);
            // 
            // btn_WorkScheduleManagement
            // 
            this.btn_WorkScheduleManagement.BackColor = System.Drawing.Color.White;
            this.btn_WorkScheduleManagement.BackgroundColor = System.Drawing.Color.White;
            this.btn_WorkScheduleManagement.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_WorkScheduleManagement.BorderRadius = 0;
            this.btn_WorkScheduleManagement.BorderSize = 0;
            this.btn_WorkScheduleManagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_WorkScheduleManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WorkScheduleManagement.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_WorkScheduleManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_WorkScheduleManagement.Location = new System.Drawing.Point(0, 189);
            this.btn_WorkScheduleManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_WorkScheduleManagement.Name = "btn_WorkScheduleManagement";
            this.btn_WorkScheduleManagement.Size = new System.Drawing.Size(262, 56);
            this.btn_WorkScheduleManagement.TabIndex = 16;
            this.btn_WorkScheduleManagement.Text = "Quản lý lịch làm";
            this.btn_WorkScheduleManagement.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_WorkScheduleManagement.UseVisualStyleBackColor = false;
            this.btn_WorkScheduleManagement.Click += new System.EventHandler(this.btn_QuanLyLichLam_Click);
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(101, 13);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(50, 51);
            this.pb_Logo.TabIndex = 16;
            this.pb_Logo.TabStop = false;
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
            this.btn_Add.Location = new System.Drawing.Point(880, 85);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(87, 35);
            this.btn_Add.TabIndex = 45;
            this.btn_Add.Text = "+ Thêm";
            this.btn_Add.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Them_Click);
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
            this.btn_Delete.Location = new System.Drawing.Point(974, 85);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(77, 35);
            this.btn_Delete.TabIndex = 46;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Search.Location = new System.Drawing.Point(266, 92);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(91, 28);
            this.lbl_Search.TabIndex = 47;
            this.lbl_Search.Text = "Tìm kiếm";
            // 
            // cb_Department
            // 
            this.cb_Department.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cb_Department.FormattingEnabled = true;
            this.cb_Department.ItemHeight = 29;
            this.cb_Department.Location = new System.Drawing.Point(645, 87);
            this.cb_Department.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_Department.Name = "cb_Department";
            this.cb_Department.PromptText = "Phòng ban";
            this.cb_Department.Size = new System.Drawing.Size(138, 35);
            this.cb_Department.TabIndex = 48;
            this.cb_Department.UseSelectable = true;
            // 
            // HoSoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 605);
            this.Controls.Add(this.cb_Department);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btn_ExportFile);
            this.Controls.Add(this.tb_StaffID);
            this.Controls.Add(this.dgv_NhanVien);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.btn_Signout);
            this.Name = "HoSoNhanVien";
            this.Padding = new System.Windows.Forms.Padding(21, 80, 21, 20);
            this.Text = "v";
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AccountIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RoundedButton btn_Signout;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroGrid dgv_NhanVien;
        private CustomControls.LeftAlignRoundedTextBox tb_StaffID;
        private CustomControls.RoundedButton btn_ExportFile;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Label lbl_AccountName;
        private PictureBox pb_AccountIcon;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private CustomControls.RoundedButton btn_letter;
        private CustomControls.RoundedButton btn_TimekeepingManagement;
        private CustomControls.RoundedButton btn_StaffProfile;
        private CustomControls.RoundedButton btn_WorkScheduleManagement;
        private PictureBox pb_Logo;
        private CustomControls.RoundedButton btn_PayRoll;
        private CustomControls.RoundedButton btn_Add;
        private CustomControls.RoundedButton btn_Delete;
        private Label lbl_Search;
        private MetroFramework.Controls.MetroComboBox cb_Department;
        private DataGridViewTextBoxColumn StaffID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn Status;
    }
}