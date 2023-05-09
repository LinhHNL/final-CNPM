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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiemKhoXemPhieuNhapHang));
            this.btn_SignOut = new WinFormsApp2.CustomControls.RoundedButton();
            this.lbl_ImportNote = new System.Windows.Forms.Label();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.dgv_Import = new MetroFramework.Controls.MetroGrid();
            this.CommodityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommodityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_ImportID = new System.Windows.Forms.Label();
            this.tb_ImportID = new WinFormsApp2.CustomControls.LeftAlignRoundedTextBox();
            this.tb_ImportDate = new WinFormsApp2.CustomControls.LeftAlignRoundedTextBox();
            this.lbl_ImportDate = new System.Windows.Forms.Label();
            this.btn_Edit = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_Save = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_ExportFile = new WinFormsApp2.CustomControls.RoundedButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lbl_AccountName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.btn_Import = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_Export = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_InStock = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_InventoryControl = new WinFormsApp2.CustomControls.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Import)).BeginInit();
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
            // lbl_ImportNote
            // 
            this.lbl_ImportNote.AutoSize = true;
            this.lbl_ImportNote.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ImportNote.Location = new System.Drawing.Point(265, 78);
            this.lbl_ImportNote.Name = "lbl_ImportNote";
            this.lbl_ImportNote.Size = new System.Drawing.Size(248, 40);
            this.lbl_ImportNote.TabIndex = 29;
            this.lbl_ImportNote.Text = "Phiếu nhập hàng";
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
            // dgv_Import
            // 
            this.dgv_Import.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgv_Import.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Import.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Import.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Import.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_Import.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Import.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Import.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Import.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommodityID,
            this.CommodityName,
            this.Unit,
            this.Quantity});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Import.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Import.EnableHeadersVisualStyles = false;
            this.dgv_Import.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_Import.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.dgv_Import.Location = new System.Drawing.Point(268, 218);
            this.dgv_Import.Name = "dgv_Import";
            this.dgv_Import.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Import.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Import.RowHeadersVisible = false;
            this.dgv_Import.RowHeadersWidth = 51;
            this.dgv_Import.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Import.RowTemplate.Height = 29;
            this.dgv_Import.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Import.Size = new System.Drawing.Size(905, 300);
            this.dgv_Import.TabIndex = 32;
            // 
            // CommodityID
            // 
            this.CommodityID.HeaderText = "Mã hàng hóa";
            this.CommodityID.MinimumWidth = 6;
            this.CommodityID.Name = "CommodityID";
            this.CommodityID.ReadOnly = true;
            this.CommodityID.Width = 200;
            // 
            // CommodityName
            // 
            this.CommodityName.HeaderText = "Tên hàng hóa";
            this.CommodityName.MinimumWidth = 6;
            this.CommodityName.Name = "CommodityName";
            this.CommodityName.ReadOnly = true;
            this.CommodityName.Width = 360;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Đơn vị tính";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 180;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 160;
            // 
            // lbl_ImportID
            // 
            this.lbl_ImportID.AutoSize = true;
            this.lbl_ImportID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ImportID.Location = new System.Drawing.Point(269, 133);
            this.lbl_ImportID.Name = "lbl_ImportID";
            this.lbl_ImportID.Size = new System.Drawing.Size(136, 24);
            this.lbl_ImportID.TabIndex = 33;
            this.lbl_ImportID.Text = "Mã nhập hàng:";
            // 
            // tb_ImportID
            // 
            this.tb_ImportID.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ImportID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.tb_ImportID.BorderFocusColor = System.Drawing.Color.Black;
            this.tb_ImportID.BorderRadius = 10;
            this.tb_ImportID.BorderSize = 1;
            this.tb_ImportID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ImportID.ForeColor = System.Drawing.Color.Black;
            this.tb_ImportID.Location = new System.Drawing.Point(449, 125);
            this.tb_ImportID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ImportID.Multiline = false;
            this.tb_ImportID.Name = "tb_ImportID";
            this.tb_ImportID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_ImportID.PasswordChar = false;
            this.tb_ImportID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_ImportID.PlaceholderText = "";
            this.tb_ImportID.ReadOnly = false;
            this.tb_ImportID.Size = new System.Drawing.Size(272, 39);
            this.tb_ImportID.TabIndex = 34;
            this.tb_ImportID.Texts = "";
            this.tb_ImportID.UnderlinedStyle = false;
            // 
            // tb_ImportDate
            // 
            this.tb_ImportDate.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ImportDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.tb_ImportDate.BorderFocusColor = System.Drawing.Color.Black;
            this.tb_ImportDate.BorderRadius = 10;
            this.tb_ImportDate.BorderSize = 1;
            this.tb_ImportDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ImportDate.ForeColor = System.Drawing.Color.Black;
            this.tb_ImportDate.Location = new System.Drawing.Point(449, 172);
            this.tb_ImportDate.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ImportDate.Multiline = false;
            this.tb_ImportDate.Name = "tb_ImportDate";
            this.tb_ImportDate.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_ImportDate.PasswordChar = false;
            this.tb_ImportDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_ImportDate.PlaceholderText = "";
            this.tb_ImportDate.ReadOnly = false;
            this.tb_ImportDate.Size = new System.Drawing.Size(272, 39);
            this.tb_ImportDate.TabIndex = 36;
            this.tb_ImportDate.Texts = "";
            this.tb_ImportDate.UnderlinedStyle = false;
            // 
            // lbl_ImportDate
            // 
            this.lbl_ImportDate.AutoSize = true;
            this.lbl_ImportDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ImportDate.Location = new System.Drawing.Point(269, 178);
            this.lbl_ImportDate.Name = "lbl_ImportDate";
            this.lbl_ImportDate.Size = new System.Drawing.Size(104, 24);
            this.lbl_ImportDate.TabIndex = 35;
            this.lbl_ImportDate.Text = "Ngày nhập:";
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Edit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Edit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Edit.BorderRadius = 8;
            this.btn_Edit.BorderSize = 0;
            this.btn_Edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(1008, 525);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(80, 35);
            this.btn_Edit.TabIndex = 40;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.TextColor = System.Drawing.Color.White;
            this.btn_Edit.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btn_Save.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btn_Save.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Save.BorderRadius = 8;
            this.btn_Save.BorderSize = 0;
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(1094, 525);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(80, 35);
            this.btn_Save.TabIndex = 41;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.TextColor = System.Drawing.Color.White;
            this.btn_Save.UseVisualStyleBackColor = false;
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
            this.metroPanel1.Controls.Add(this.lbl_AccountName);
            this.metroPanel1.Controls.Add(this.pictureBox2);
            this.metroPanel1.Controls.Add(this.metroPanel7);
            this.metroPanel1.Controls.Add(this.btn_Import);
            this.metroPanel1.Controls.Add(this.btn_Export);
            this.metroPanel1.Controls.Add(this.btn_InStock);
            this.metroPanel1.Controls.Add(this.btn_InventoryControl);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 35);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(259, 570);
            this.metroPanel1.TabIndex = 44;
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
            // btn_Import
            // 
            this.btn_Import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.btn_Import.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.btn_Import.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_Import.BorderRadius = 0;
            this.btn_Import.BorderSize = 0;
            this.btn_Import.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Import.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Import.ForeColor = System.Drawing.Color.Black;
            this.btn_Import.Location = new System.Drawing.Point(-1, 302);
            this.btn_Import.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(263, 64);
            this.btn_Import.TabIndex = 18;
            this.btn_Import.Text = "Nhập hàng";
            this.btn_Import.TextColor = System.Drawing.Color.Black;
            this.btn_Import.UseVisualStyleBackColor = false;
            // 
            // btn_Export
            // 
            this.btn_Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.btn_Export.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.btn_Export.BorderColor = System.Drawing.Color.Silver;
            this.btn_Export.BorderRadius = 0;
            this.btn_Export.BorderSize = 0;
            this.btn_Export.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Export.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_Export.Location = new System.Drawing.Point(-1, 243);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(264, 64);
            this.btn_Export.TabIndex = 17;
            this.btn_Export.Text = "Xuất hàng";
            this.btn_Export.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_Export.UseVisualStyleBackColor = false;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_InStock
            // 
            this.btn_InStock.BackColor = System.Drawing.Color.White;
            this.btn_InStock.BackgroundColor = System.Drawing.Color.White;
            this.btn_InStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_InStock.BorderRadius = 0;
            this.btn_InStock.BorderSize = 0;
            this.btn_InStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_InStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InStock.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_InStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_InStock.Location = new System.Drawing.Point(0, 130);
            this.btn_InStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_InStock.Name = "btn_InStock";
            this.btn_InStock.Size = new System.Drawing.Size(262, 60);
            this.btn_InStock.TabIndex = 16;
            this.btn_InStock.Text = "Hàng trong kho";
            this.btn_InStock.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_InStock.UseVisualStyleBackColor = false;
            this.btn_InStock.Click += new System.EventHandler(this.btn_InStock_Click);
            // 
            // btn_InventoryControl
            // 
            this.btn_InventoryControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_InventoryControl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_InventoryControl.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_InventoryControl.BorderRadius = 0;
            this.btn_InventoryControl.BorderSize = 0;
            this.btn_InventoryControl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_InventoryControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InventoryControl.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_InventoryControl.ForeColor = System.Drawing.Color.White;
            this.btn_InventoryControl.Location = new System.Drawing.Point(0, 189);
            this.btn_InventoryControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_InventoryControl.Name = "btn_InventoryControl";
            this.btn_InventoryControl.Size = new System.Drawing.Size(262, 56);
            this.btn_InventoryControl.TabIndex = 16;
            this.btn_InventoryControl.Text = "Kiểm kho";
            this.btn_InventoryControl.TextColor = System.Drawing.Color.White;
            this.btn_InventoryControl.UseVisualStyleBackColor = false;
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
            // KiemKhoXemPhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 605);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btn_ExportFile);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.tb_ImportDate);
            this.Controls.Add(this.lbl_ImportDate);
            this.Controls.Add(this.tb_ImportID);
            this.Controls.Add(this.lbl_ImportID);
            this.Controls.Add(this.dgv_Import);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.lbl_ImportNote);
            this.Controls.Add(this.btn_SignOut);
            this.Name = "KiemKhoXemPhieuNhapHang";
            this.Text = "v";
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Import)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RoundedButton btn_SignOut;
        private Label lbl_ImportNote;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroGrid dgv_Import;
        private Label lbl_ImportID;
        private CustomControls.LeftAlignRoundedTextBox tb_ImportID;
        private CustomControls.LeftAlignRoundedTextBox tb_ImportDate;
        private Label lbl_ImportDate;
        private CustomControls.RoundedButton btn_Edit;
        private CustomControls.RoundedButton btn_Save;
        private CustomControls.RoundedButton btn_ExportFile;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Label lbl_AccountName;
        private PictureBox pictureBox2;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private CustomControls.RoundedButton btn_Import;
        private CustomControls.RoundedButton btn_Export;
        private CustomControls.RoundedButton btn_InStock;
        private CustomControls.RoundedButton btn_InventoryControl;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn CommodityID;
        private DataGridViewTextBoxColumn CommodityName;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Quantity;
    }
}