namespace WinFormsApp2.StaffAccount
{
    partial class DonTu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonTu));
            this.btn_SignOut = new WinFormsApp2.CustomControls.RoundedButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.lbl_MakeLetter = new System.Windows.Forms.Label();
            this.cb_Letter = new MetroFramework.Controls.MetroComboBox();
            this.dgv_Letter = new MetroFramework.Controls.MetroGrid();
            this.btn_CreateLetter = new WinFormsApp2.CustomControls.RoundedButton();
            this.lbl_LetterHistory = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_PasswordReset = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_Notification = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_Payroll = new WinFormsApp2.CustomControls.RoundedButton();
            this.lbl_AccountName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.btn_Letter = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_Timekeeping = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_MyProfile = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_WorkSchedule = new WinFormsApp2.CustomControls.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LetterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MakeLetterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Letter)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btn_SignOut.Location = new System.Drawing.Point(1057, 35);
            this.btn_SignOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(117, 35);
            this.btn_SignOut.TabIndex = 22;
            this.btn_SignOut.Text = "Đăng xuất";
            this.btn_SignOut.TextColor = System.Drawing.Color.White;
            this.btn_SignOut.UseVisualStyleBackColor = false;
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
            // lbl_MakeLetter
            // 
            this.lbl_MakeLetter.AutoSize = true;
            this.lbl_MakeLetter.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_MakeLetter.Location = new System.Drawing.Point(267, 48);
            this.lbl_MakeLetter.Name = "lbl_MakeLetter";
            this.lbl_MakeLetter.Size = new System.Drawing.Size(128, 37);
            this.lbl_MakeLetter.TabIndex = 47;
            this.lbl_MakeLetter.Text = "Làm đơn";
            // 
            // cb_Letter
            // 
            this.cb_Letter.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cb_Letter.FormattingEnabled = true;
            this.cb_Letter.ItemHeight = 29;
            this.cb_Letter.Items.AddRange(new object[] {
            "03/2023",
            "02/2023",
            "01/2023"});
            this.cb_Letter.Location = new System.Drawing.Point(269, 94);
            this.cb_Letter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_Letter.Name = "cb_Letter";
            this.cb_Letter.PromptText = "Đơn xác nhận chấm công";
            this.cb_Letter.Size = new System.Drawing.Size(267, 35);
            this.cb_Letter.TabIndex = 48;
            this.cb_Letter.UseSelectable = true;
            // 
            // dgv_Letter
            // 
            this.dgv_Letter.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.dgv_Letter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Letter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Letter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Letter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Letter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_Letter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Letter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Letter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Letter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.LetterType,
            this.MakeLetterDate,
            this.ProcessingDate,
            this.Status,
            this.Column5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Letter.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Letter.EnableHeadersVisualStyles = false;
            this.dgv_Letter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_Letter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.dgv_Letter.Location = new System.Drawing.Point(269, 224);
            this.dgv_Letter.Name = "dgv_Letter";
            this.dgv_Letter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Letter.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Letter.RowHeadersVisible = false;
            this.dgv_Letter.RowHeadersWidth = 51;
            this.dgv_Letter.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Letter.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Letter.RowTemplate.Height = 29;
            this.dgv_Letter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Letter.Size = new System.Drawing.Size(905, 370);
            this.dgv_Letter.TabIndex = 66;
            // 
            // btn_CreateLetter
            // 
            this.btn_CreateLetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            this.btn_CreateLetter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            this.btn_CreateLetter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btn_CreateLetter.BorderRadius = 8;
            this.btn_CreateLetter.BorderSize = 1;
            this.btn_CreateLetter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_CreateLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateLetter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CreateLetter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_CreateLetter.Location = new System.Drawing.Point(542, 94);
            this.btn_CreateLetter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CreateLetter.Name = "btn_CreateLetter";
            this.btn_CreateLetter.Size = new System.Drawing.Size(111, 35);
            this.btn_CreateLetter.TabIndex = 67;
            this.btn_CreateLetter.Text = "Tạo đơn";
            this.btn_CreateLetter.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_CreateLetter.UseVisualStyleBackColor = false;
            this.btn_CreateLetter.Click += new System.EventHandler(this.roundedButton4_Click);
            // 
            // lbl_LetterHistory
            // 
            this.lbl_LetterHistory.AutoSize = true;
            this.lbl_LetterHistory.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_LetterHistory.Location = new System.Drawing.Point(269, 175);
            this.lbl_LetterHistory.Name = "lbl_LetterHistory";
            this.lbl_LetterHistory.Size = new System.Drawing.Size(216, 37);
            this.lbl_LetterHistory.TabIndex = 68;
            this.lbl_LetterHistory.Text = "Lịch sử làm đơn";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btn_PasswordReset);
            this.metroPanel1.Controls.Add(this.btn_Notification);
            this.metroPanel1.Controls.Add(this.btn_Payroll);
            this.metroPanel1.Controls.Add(this.lbl_AccountName);
            this.metroPanel1.Controls.Add(this.pictureBox2);
            this.metroPanel1.Controls.Add(this.metroPanel7);
            this.metroPanel1.Controls.Add(this.btn_Letter);
            this.metroPanel1.Controls.Add(this.btn_Timekeeping);
            this.metroPanel1.Controls.Add(this.btn_MyProfile);
            this.metroPanel1.Controls.Add(this.btn_WorkSchedule);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 11;
            this.metroPanel1.Location = new System.Drawing.Point(0, 25);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(263, 578);
            this.metroPanel1.TabIndex = 69;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_PasswordReset
            // 
            this.btn_PasswordReset.BackColor = System.Drawing.Color.White;
            this.btn_PasswordReset.BackgroundColor = System.Drawing.Color.White;
            this.btn_PasswordReset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_PasswordReset.BorderRadius = 0;
            this.btn_PasswordReset.BorderSize = 0;
            this.btn_PasswordReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_PasswordReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PasswordReset.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_PasswordReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_PasswordReset.Location = new System.Drawing.Point(0, 485);
            this.btn_PasswordReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_PasswordReset.Name = "btn_PasswordReset";
            this.btn_PasswordReset.Size = new System.Drawing.Size(263, 64);
            this.btn_PasswordReset.TabIndex = 47;
            this.btn_PasswordReset.Text = "Đổi mật khẩu";
            this.btn_PasswordReset.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_PasswordReset.UseVisualStyleBackColor = false;
            this.btn_PasswordReset.Click += new System.EventHandler(this.btn_DoiMatKhau_Click);
            // 
            // btn_Notification
            // 
            this.btn_Notification.BackColor = System.Drawing.Color.White;
            this.btn_Notification.BackgroundColor = System.Drawing.Color.White;
            this.btn_Notification.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_Notification.BorderRadius = 0;
            this.btn_Notification.BorderSize = 0;
            this.btn_Notification.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Notification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Notification.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Notification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_Notification.Location = new System.Drawing.Point(0, 420);
            this.btn_Notification.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Notification.Name = "btn_Notification";
            this.btn_Notification.Size = new System.Drawing.Size(263, 64);
            this.btn_Notification.TabIndex = 46;
            this.btn_Notification.Text = "Thông báo";
            this.btn_Notification.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_Notification.UseVisualStyleBackColor = false;
            this.btn_Notification.Click += new System.EventHandler(this.btn_ThongBao_Click);
            // 
            // btn_Payroll
            // 
            this.btn_Payroll.BackColor = System.Drawing.Color.White;
            this.btn_Payroll.BackgroundColor = System.Drawing.Color.White;
            this.btn_Payroll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_Payroll.BorderRadius = 0;
            this.btn_Payroll.BorderSize = 0;
            this.btn_Payroll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Payroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Payroll.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Payroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_Payroll.Location = new System.Drawing.Point(0, 363);
            this.btn_Payroll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Payroll.Name = "btn_Payroll";
            this.btn_Payroll.Size = new System.Drawing.Size(263, 64);
            this.btn_Payroll.TabIndex = 45;
            this.btn_Payroll.Text = "Lương thưởng";
            this.btn_Payroll.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_Payroll.UseVisualStyleBackColor = false;
            this.btn_Payroll.Click += new System.EventHandler(this.btn_LuongThuong_Click);
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
            // btn_Letter
            // 
            this.btn_Letter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Letter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Letter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_Letter.BorderRadius = 0;
            this.btn_Letter.BorderSize = 0;
            this.btn_Letter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Letter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Letter.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Letter.ForeColor = System.Drawing.Color.White;
            this.btn_Letter.Location = new System.Drawing.Point(-1, 301);
            this.btn_Letter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Letter.Name = "btn_Letter";
            this.btn_Letter.Size = new System.Drawing.Size(263, 64);
            this.btn_Letter.TabIndex = 18;
            this.btn_Letter.Text = "Đơn từ";
            this.btn_Letter.TextColor = System.Drawing.Color.White;
            this.btn_Letter.UseVisualStyleBackColor = false;
            this.btn_Letter.Click += new System.EventHandler(this.btn_DonTu_Click);
            // 
            // btn_Timekeeping
            // 
            this.btn_Timekeeping.BackColor = System.Drawing.Color.White;
            this.btn_Timekeeping.BackgroundColor = System.Drawing.Color.White;
            this.btn_Timekeeping.BorderColor = System.Drawing.Color.Silver;
            this.btn_Timekeeping.BorderRadius = 0;
            this.btn_Timekeeping.BorderSize = 0;
            this.btn_Timekeeping.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Timekeeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Timekeeping.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Timekeeping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_Timekeeping.Location = new System.Drawing.Point(-1, 243);
            this.btn_Timekeeping.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Timekeeping.Name = "btn_Timekeeping";
            this.btn_Timekeeping.Size = new System.Drawing.Size(264, 64);
            this.btn_Timekeeping.TabIndex = 17;
            this.btn_Timekeeping.Text = "Chấm công";
            this.btn_Timekeeping.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_Timekeeping.UseVisualStyleBackColor = false;
            this.btn_Timekeeping.Click += new System.EventHandler(this.btn_QuanLyChamCong_Click);
            // 
            // btn_MyProfile
            // 
            this.btn_MyProfile.BackColor = System.Drawing.Color.White;
            this.btn_MyProfile.BackgroundColor = System.Drawing.Color.White;
            this.btn_MyProfile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_MyProfile.BorderRadius = 0;
            this.btn_MyProfile.BorderSize = 0;
            this.btn_MyProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_MyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MyProfile.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_MyProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_MyProfile.Location = new System.Drawing.Point(0, 131);
            this.btn_MyProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_MyProfile.Name = "btn_MyProfile";
            this.btn_MyProfile.Size = new System.Drawing.Size(262, 60);
            this.btn_MyProfile.TabIndex = 16;
            this.btn_MyProfile.Text = "Hồ sơ của tôi";
            this.btn_MyProfile.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_MyProfile.UseVisualStyleBackColor = false;
            this.btn_MyProfile.Click += new System.EventHandler(this.btn_HoSoCuaToi_Click);
            // 
            // btn_WorkSchedule
            // 
            this.btn_WorkSchedule.BackColor = System.Drawing.Color.White;
            this.btn_WorkSchedule.BackgroundColor = System.Drawing.Color.White;
            this.btn_WorkSchedule.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_WorkSchedule.BorderRadius = 0;
            this.btn_WorkSchedule.BorderSize = 0;
            this.btn_WorkSchedule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_WorkSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WorkSchedule.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_WorkSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_WorkSchedule.Location = new System.Drawing.Point(0, 189);
            this.btn_WorkSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_WorkSchedule.Name = "btn_WorkSchedule";
            this.btn_WorkSchedule.Size = new System.Drawing.Size(262, 56);
            this.btn_WorkSchedule.TabIndex = 16;
            this.btn_WorkSchedule.Text = "Lịch làm";
            this.btn_WorkSchedule.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_WorkSchedule.UseVisualStyleBackColor = false;
            this.btn_WorkSchedule.Click += new System.EventHandler(this.btn_QuanLyLichLam_Click);
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
            // Number
            // 
            this.Number.DataPropertyName = "Note";
            this.Number.FillWeight = 1F;
            this.Number.HeaderText = "STT";
            this.Number.MinimumWidth = 50;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // LetterType
            // 
            this.LetterType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LetterType.FillWeight = 3F;
            this.LetterType.HeaderText = "Loại đơn";
            this.LetterType.MinimumWidth = 150;
            this.LetterType.Name = "LetterType";
            this.LetterType.ReadOnly = true;
            // 
            // MakeLetterDate
            // 
            this.MakeLetterDate.FillWeight = 1F;
            this.MakeLetterDate.HeaderText = "Ngày làm đơn";
            this.MakeLetterDate.MinimumWidth = 170;
            this.MakeLetterDate.Name = "MakeLetterDate";
            this.MakeLetterDate.ReadOnly = true;
            // 
            // ProcessingDate
            // 
            this.ProcessingDate.FillWeight = 1F;
            this.ProcessingDate.HeaderText = "Ngày xử lý";
            this.ProcessingDate.MinimumWidth = 150;
            this.ProcessingDate.Name = "ProcessingDate";
            this.ProcessingDate.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.FillWeight = 1F;
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 150;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.MinimumWidth = 180;
            this.Column5.Name = "Column5";
            // 
            // DonTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 605);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lbl_LetterHistory);
            this.Controls.Add(this.btn_CreateLetter);
            this.Controls.Add(this.dgv_Letter);
            this.Controls.Add(this.cb_Letter);
            this.Controls.Add(this.lbl_MakeLetter);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.btn_SignOut);
            this.Name = "DonTu";
            this.Padding = new System.Windows.Forms.Padding(21, 80, 21, 20);
            this.Load += new System.EventHandler(this.QuanLyDonTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Letter)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RoundedButton btn_SignOut;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private Label lbl_MakeLetter;
        private MetroFramework.Controls.MetroComboBox cb_Letter;
        private MetroFramework.Controls.MetroGrid dgv_Letter;
        private CustomControls.RoundedButton btn_CreateLetter;
        private Label lbl_LetterHistory;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private CustomControls.RoundedButton btn_PasswordReset;
        private CustomControls.RoundedButton btn_Notification;
        private CustomControls.RoundedButton btn_Payroll;
        private Label lbl_AccountName;
        private PictureBox pictureBox2;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private CustomControls.RoundedButton btn_Letter;
        private CustomControls.RoundedButton btn_Timekeeping;
        private CustomControls.RoundedButton btn_MyProfile;
        private CustomControls.RoundedButton btn_WorkSchedule;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn LetterType;
        private DataGridViewTextBoxColumn MakeLetterDate;
        private DataGridViewTextBoxColumn ProcessingDate;
        private DataGridViewButtonColumn Status;
        private DataGridViewTextBoxColumn Column5;
    }
}