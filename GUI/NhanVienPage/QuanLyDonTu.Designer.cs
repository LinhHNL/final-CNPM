namespace WinFormsApp2.NhanVienPage
{
    partial class QuanLyDonTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyDonTu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Signout = new WinFormsApp2.CustomControls.RoundedButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
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
            this.lbl_letterManagement = new System.Windows.Forms.Label();
            this.cb_Month = new MetroFramework.Controls.MetroComboBox();
            this.lbl_Month = new System.Windows.Forms.Label();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.cb_Department = new MetroFramework.Controls.MetroComboBox();
            this.tb_staffIDName = new WinFormsApp2.CustomControls.LeftAlignRoundedTextBox();
            this.dgv_DonTu = new MetroFramework.Controls.MetroGrid();
            this.letterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AccountIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonTu)).BeginInit();
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
            this.metroGrid1.Location = new System.Drawing.Point(370, 106);
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
            this.btn_letter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_letter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_letter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_letter.BorderRadius = 0;
            this.btn_letter.BorderSize = 0;
            this.btn_letter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_letter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_letter.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_letter.ForeColor = System.Drawing.Color.White;
            this.btn_letter.Location = new System.Drawing.Point(-1, 301);
            this.btn_letter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_letter.Name = "btn_letter";
            this.btn_letter.Size = new System.Drawing.Size(263, 64);
            this.btn_letter.TabIndex = 18;
            this.btn_letter.Text = "Đơn từ";
            this.btn_letter.TextColor = System.Drawing.Color.White;
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
            this.btn_StaffProfile.BackColor = System.Drawing.Color.White;
            this.btn_StaffProfile.BackgroundColor = System.Drawing.Color.White;
            this.btn_StaffProfile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_StaffProfile.BorderRadius = 0;
            this.btn_StaffProfile.BorderSize = 0;
            this.btn_StaffProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_StaffProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StaffProfile.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_StaffProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_StaffProfile.Location = new System.Drawing.Point(0, 131);
            this.btn_StaffProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_StaffProfile.Name = "btn_StaffProfile";
            this.btn_StaffProfile.Size = new System.Drawing.Size(262, 60);
            this.btn_StaffProfile.TabIndex = 16;
            this.btn_StaffProfile.Text = "Hồ sơ nhân viên";
            this.btn_StaffProfile.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
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
            // lbl_letterManagement
            // 
            this.lbl_letterManagement.AutoSize = true;
            this.lbl_letterManagement.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_letterManagement.Location = new System.Drawing.Point(267, 48);
            this.lbl_letterManagement.Name = "lbl_letterManagement";
            this.lbl_letterManagement.Size = new System.Drawing.Size(208, 37);
            this.lbl_letterManagement.TabIndex = 47;
            this.lbl_letterManagement.Text = "Quản lý đơn từ";
            // 
            // cb_Month
            // 
            this.cb_Month.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cb_Month.FormattingEnabled = true;
            this.cb_Month.ItemHeight = 29;
            this.cb_Month.Items.AddRange(new object[] {
            "03/2023",
            "02/2023",
            "01/2023"});
            this.cb_Month.Location = new System.Drawing.Point(350, 94);
            this.cb_Month.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_Month.Name = "cb_Month";
            this.cb_Month.PromptText = "Tháng";
            this.cb_Month.Size = new System.Drawing.Size(138, 35);
            this.cb_Month.TabIndex = 48;
            this.cb_Month.UseSelectable = true;
            // 
            // lbl_Month
            // 
            this.lbl_Month.AutoSize = true;
            this.lbl_Month.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Month.Location = new System.Drawing.Point(267, 97);
            this.lbl_Month.Name = "lbl_Month";
            this.lbl_Month.Size = new System.Drawing.Size(75, 28);
            this.lbl_Month.TabIndex = 49;
            this.lbl_Month.Text = "Tháng:";
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Search.Location = new System.Drawing.Point(516, 97);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(106, 28);
            this.lbl_Search.TabIndex = 62;
            this.lbl_Search.Text = "Tìm kiếm: ";
            // 
            // cb_Department
            // 
            this.cb_Department.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cb_Department.FormattingEnabled = true;
            this.cb_Department.ItemHeight = 29;
            this.cb_Department.Location = new System.Drawing.Point(855, 94);
            this.cb_Department.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_Department.Name = "cb_Department";
            this.cb_Department.PromptText = "Phòng ban";
            this.cb_Department.Size = new System.Drawing.Size(159, 35);
            this.cb_Department.TabIndex = 63;
            this.cb_Department.UseSelectable = true;
            // 
            // tb_staffIDName
            // 
            this.tb_staffIDName.BackColor = System.Drawing.SystemColors.Window;
            this.tb_staffIDName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.tb_staffIDName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_staffIDName.BorderRadius = 0;
            this.tb_staffIDName.BorderSize = 1;
            this.tb_staffIDName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_staffIDName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(70)))));
            this.tb_staffIDName.Location = new System.Drawing.Point(619, 94);
            this.tb_staffIDName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_staffIDName.Multiline = false;
            this.tb_staffIDName.Name = "tb_staffIDName";
            this.tb_staffIDName.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.tb_staffIDName.PasswordChar = false;
            this.tb_staffIDName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_staffIDName.PlaceholderText = "Mã / Tên nhân viên";
            this.tb_staffIDName.ReadOnly = false;
            this.tb_staffIDName.Size = new System.Drawing.Size(219, 35);
            this.tb_staffIDName.TabIndex = 65;
            this.tb_staffIDName.Texts = "";
            this.tb_staffIDName.UnderlinedStyle = false;
            // 
            // dgv_DonTu
            // 
            this.dgv_DonTu.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.dgv_DonTu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_DonTu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DonTu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_DonTu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DonTu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_DonTu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DonTu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_DonTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DonTu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.letterID,
            this.Staff,
            this.letterDate,
            this.Reason,
            this.status});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DonTu.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_DonTu.EnableHeadersVisualStyles = false;
            this.dgv_DonTu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_DonTu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.dgv_DonTu.Location = new System.Drawing.Point(269, 148);
            this.dgv_DonTu.Name = "dgv_DonTu";
            this.dgv_DonTu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DonTu.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_DonTu.RowHeadersVisible = false;
            this.dgv_DonTu.RowHeadersWidth = 51;
            this.dgv_DonTu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_DonTu.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_DonTu.RowTemplate.Height = 29;
            this.dgv_DonTu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DonTu.Size = new System.Drawing.Size(905, 446);
            this.dgv_DonTu.TabIndex = 66;
            // 
            // letterID
            // 
            this.letterID.FillWeight = 1F;
            this.letterID.HeaderText = "Mã đơn từ";
            this.letterID.MinimumWidth = 150;
            this.letterID.Name = "letterID";
            this.letterID.ReadOnly = true;
            // 
            // Staff
            // 
            this.Staff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Staff.FillWeight = 3F;
            this.Staff.HeaderText = "Nhân viên";
            this.Staff.MinimumWidth = 230;
            this.Staff.Name = "Staff";
            this.Staff.ReadOnly = true;
            // 
            // letterDate
            // 
            this.letterDate.FillWeight = 1F;
            this.letterDate.HeaderText = "Ngày làm đơn";
            this.letterDate.MinimumWidth = 170;
            this.letterDate.Name = "letterDate";
            this.letterDate.ReadOnly = true;
            // 
            // Reason
            // 
            this.Reason.FillWeight = 1F;
            this.Reason.HeaderText = "Lý do";
            this.Reason.MinimumWidth = 200;
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            // 
            // status
            // 
            this.status.FillWeight = 1F;
            this.status.HeaderText = "Trạng thái";
            this.status.MinimumWidth = 150;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // QuanLyDonTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 605);
            this.Controls.Add(this.dgv_DonTu);
            this.Controls.Add(this.tb_staffIDName);
            this.Controls.Add(this.cb_Department);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.lbl_Month);
            this.Controls.Add(this.cb_Month);
            this.Controls.Add(this.lbl_letterManagement);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.btn_Signout);
            this.Name = "QuanLyDonTu";
            this.Padding = new System.Windows.Forms.Padding(21, 80, 21, 20);
            this.Load += new System.EventHandler(this.QuanLyDonTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AccountIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonTu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RoundedButton btn_Signout;
        private MetroFramework.Controls.MetroGrid metroGrid1;
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
        private Label lbl_letterManagement;
        private MetroFramework.Controls.MetroComboBox cb_Month;
        private Label lbl_Month;
        private Label lbl_Search;
        private MetroFramework.Controls.MetroComboBox cb_Department;
        private CustomControls.LeftAlignRoundedTextBox tb_staffIDName;
        private MetroFramework.Controls.MetroGrid dgv_DonTu;
        private DataGridViewTextBoxColumn letterID;
        private DataGridViewTextBoxColumn Staff;
        private DataGridViewTextBoxColumn letterDate;
        private DataGridViewTextBoxColumn Reason;
        private DataGridViewButtonColumn status;
    }
}