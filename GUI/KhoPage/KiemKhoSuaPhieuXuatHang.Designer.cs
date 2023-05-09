namespace WinFormsApp2.KhoPage
{
    partial class KiemKhoSuaPhieuXuatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiemKhoSuaPhieuXuatHang));
            this.btn_SignOut = new WinFormsApp2.CustomControls.RoundedButton();
            this.lbl_ExportNote = new System.Windows.Forms.Label();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.dgv_Export = new MetroFramework.Controls.MetroGrid();
            this.CommodityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommodityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_ExportID = new System.Windows.Forms.Label();
            this.tb_ExportID = new WinFormsApp2.CustomControls.LeftAlignRoundedTextBox();
            this.tb_Exporter = new WinFormsApp2.CustomControls.LeftAlignRoundedTextBox();
            this.lbl_Exporter = new System.Windows.Forms.Label();
            this.tb_ExportDate = new WinFormsApp2.CustomControls.LeftAlignRoundedTextBox();
            this.lbl_ExportDate = new System.Windows.Forms.Label();
            this.btn_Edit = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_Save = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_Add = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Export)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).BeginInit();
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
            // lbl_ExportNote
            // 
            this.lbl_ExportNote.AutoSize = true;
            this.lbl_ExportNote.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ExportNote.Location = new System.Drawing.Point(265, 78);
            this.lbl_ExportNote.Name = "lbl_ExportNote";
            this.lbl_ExportNote.Size = new System.Drawing.Size(238, 40);
            this.lbl_ExportNote.TabIndex = 29;
            this.lbl_ExportNote.Text = "Phiếu xuất hàng";
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
            // dgv_Export
            // 
            this.dgv_Export.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgv_Export.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Export.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Export.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Export.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_Export.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Export.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Export.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Export.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommodityID,
            this.CommodityName,
            this.Unit,
            this.Quantity});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Export.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_Export.EnableHeadersVisualStyles = false;
            this.dgv_Export.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_Export.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.dgv_Export.Location = new System.Drawing.Point(268, 218);
            this.dgv_Export.Name = "dgv_Export";
            this.dgv_Export.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Export.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_Export.RowHeadersVisible = false;
            this.dgv_Export.RowHeadersWidth = 51;
            this.dgv_Export.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Export.RowTemplate.Height = 29;
            this.dgv_Export.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Export.Size = new System.Drawing.Size(905, 300);
            this.dgv_Export.TabIndex = 32;
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
            // lbl_ExportID
            // 
            this.lbl_ExportID.AutoSize = true;
            this.lbl_ExportID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ExportID.Location = new System.Drawing.Point(269, 133);
            this.lbl_ExportID.Name = "lbl_ExportID";
            this.lbl_ExportID.Size = new System.Drawing.Size(130, 24);
            this.lbl_ExportID.TabIndex = 33;
            this.lbl_ExportID.Text = "Mã xuất hàng:";
            // 
            // tb_ExportID
            // 
            this.tb_ExportID.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ExportID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.tb_ExportID.BorderFocusColor = System.Drawing.Color.Black;
            this.tb_ExportID.BorderRadius = 10;
            this.tb_ExportID.BorderSize = 1;
            this.tb_ExportID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ExportID.ForeColor = System.Drawing.Color.Black;
            this.tb_ExportID.Location = new System.Drawing.Point(449, 125);
            this.tb_ExportID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ExportID.Multiline = false;
            this.tb_ExportID.Name = "tb_ExportID";
            this.tb_ExportID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_ExportID.PasswordChar = false;
            this.tb_ExportID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_ExportID.PlaceholderText = "";
            this.tb_ExportID.ReadOnly = false;
            this.tb_ExportID.Size = new System.Drawing.Size(272, 39);
            this.tb_ExportID.TabIndex = 34;
            this.tb_ExportID.Texts = "";
            this.tb_ExportID.UnderlinedStyle = false;
            // 
            // tb_Exporter
            // 
            this.tb_Exporter.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Exporter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.tb_Exporter.BorderFocusColor = System.Drawing.Color.Black;
            this.tb_Exporter.BorderRadius = 10;
            this.tb_Exporter.BorderSize = 1;
            this.tb_Exporter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Exporter.ForeColor = System.Drawing.Color.Black;
            this.tb_Exporter.Location = new System.Drawing.Point(449, 172);
            this.tb_Exporter.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Exporter.Multiline = false;
            this.tb_Exporter.Name = "tb_Exporter";
            this.tb_Exporter.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Exporter.PasswordChar = false;
            this.tb_Exporter.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_Exporter.PlaceholderText = "";
            this.tb_Exporter.ReadOnly = false;
            this.tb_Exporter.Size = new System.Drawing.Size(272, 39);
            this.tb_Exporter.TabIndex = 36;
            this.tb_Exporter.Texts = "";
            this.tb_Exporter.UnderlinedStyle = false;
            // 
            // lbl_Exporter
            // 
            this.lbl_Exporter.AutoSize = true;
            this.lbl_Exporter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Exporter.Location = new System.Drawing.Point(269, 178);
            this.lbl_Exporter.Name = "lbl_Exporter";
            this.lbl_Exporter.Size = new System.Drawing.Size(154, 24);
            this.lbl_Exporter.TabIndex = 35;
            this.lbl_Exporter.Text = "Người xuất hàng:";
            // 
            // tb_ExportDate
            // 
            this.tb_ExportDate.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ExportDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.tb_ExportDate.BorderFocusColor = System.Drawing.Color.Black;
            this.tb_ExportDate.BorderRadius = 10;
            this.tb_ExportDate.BorderSize = 1;
            this.tb_ExportDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ExportDate.ForeColor = System.Drawing.Color.Black;
            this.tb_ExportDate.Location = new System.Drawing.Point(902, 125);
            this.tb_ExportDate.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ExportDate.Multiline = false;
            this.tb_ExportDate.Name = "tb_ExportDate";
            this.tb_ExportDate.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_ExportDate.PasswordChar = false;
            this.tb_ExportDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_ExportDate.PlaceholderText = "";
            this.tb_ExportDate.ReadOnly = false;
            this.tb_ExportDate.Size = new System.Drawing.Size(272, 39);
            this.tb_ExportDate.TabIndex = 38;
            this.tb_ExportDate.Texts = "";
            this.tb_ExportDate.UnderlinedStyle = false;
            // 
            // lbl_ExportDate
            // 
            this.lbl_ExportDate.AutoSize = true;
            this.lbl_ExportDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ExportDate.Location = new System.Drawing.Point(751, 133);
            this.lbl_ExportDate.Name = "lbl_ExportDate";
            this.lbl_ExportDate.Size = new System.Drawing.Size(144, 24);
            this.lbl_ExportDate.TabIndex = 37;
            this.lbl_ExportDate.Text = "Ngày xuất hàng:";
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btn_Edit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btn_Edit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Edit.BorderRadius = 8;
            this.btn_Edit.BorderSize = 0;
            this.btn_Edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(1008, 565);
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
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Save.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Save.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Save.BorderRadius = 8;
            this.btn_Save.BorderSize = 0;
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(1094, 565);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(80, 35);
            this.btn_Save.TabIndex = 41;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.TextColor = System.Drawing.Color.White;
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.Location = new System.Drawing.Point(1140, 529);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(33, 34);
            this.btn_Add.TabIndex = 42;
            this.btn_Add.TabStop = false;
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
            this.metroPanel1.Location = new System.Drawing.Point(4, 35);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(259, 570);
            this.metroPanel1.TabIndex = 43;
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
            this.btn_Import.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_Import.Location = new System.Drawing.Point(-1, 302);
            this.btn_Import.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(263, 64);
            this.btn_Import.TabIndex = 18;
            this.btn_Import.Text = "Nhập hàng";
            this.btn_Import.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_Import.UseVisualStyleBackColor = false;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
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
            this.btn_Export.ForeColor = System.Drawing.Color.Black;
            this.btn_Export.Location = new System.Drawing.Point(-1, 243);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(264, 64);
            this.btn_Export.TabIndex = 17;
            this.btn_Export.Text = "Xuất hàng";
            this.btn_Export.TextColor = System.Drawing.Color.Black;
            this.btn_Export.UseVisualStyleBackColor = false;
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
            // KiemKhoSuaPhieuXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 605);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.tb_ExportDate);
            this.Controls.Add(this.lbl_ExportDate);
            this.Controls.Add(this.tb_Exporter);
            this.Controls.Add(this.lbl_Exporter);
            this.Controls.Add(this.tb_ExportID);
            this.Controls.Add(this.lbl_ExportID);
            this.Controls.Add(this.dgv_Export);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.lbl_ExportNote);
            this.Controls.Add(this.btn_SignOut);
            this.Name = "KiemKhoSuaPhieuXuatHang";
            this.Text = "v";
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Export)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RoundedButton btn_SignOut;
        private Label lbl_ExportNote;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroGrid dgv_Export;
        private Label lbl_ExportID;
        private CustomControls.LeftAlignRoundedTextBox tb_ExportID;
        private CustomControls.LeftAlignRoundedTextBox tb_Exporter;
        private Label lbl_Exporter;
        private CustomControls.LeftAlignRoundedTextBox tb_ExportDate;
        private Label lbl_ExportDate;
        private CustomControls.RoundedButton btn_Edit;
        private CustomControls.RoundedButton btn_Save;
        private PictureBox btn_Add;
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