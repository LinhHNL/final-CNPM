namespace WinFormsApp2.KhoPage
{
    partial class HangHoaTrongKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangHoaTrongKho));


            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lbl_AccountName = new System.Windows.Forms.Label();
            this.pb_AccountIcon = new System.Windows.Forms.PictureBox();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.btn_Import = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_Export = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_InStock = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_InventoryControl = new WinFormsApp2.CustomControls.RoundedButton();
            this.pictureBoxBrand = new System.Windows.Forms.PictureBox();
            this.btn_SignOut = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_ExportFile = new WinFormsApp2.CustomControls.RoundedButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.btn_Add = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_Delete = new WinFormsApp2.CustomControls.RoundedButton();
            this.dgv_InStock = new MetroFramework.Controls.MetroGrid();
            this.CommodityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommodityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AccountIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InStock)).BeginInit();
            this.SuspendLayout();

            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lbl_AccountName);
            this.metroPanel1.Controls.Add(this.pb_AccountIcon);
            this.metroPanel1.Controls.Add(this.metroPanel7);
            this.metroPanel1.Controls.Add(this.btn_Import);
            this.metroPanel1.Controls.Add(this.btn_Export);
            this.metroPanel1.Controls.Add(this.btn_InStock);
            this.metroPanel1.Controls.Add(this.btn_InventoryControl);
            this.metroPanel1.Controls.Add(this.pictureBoxBrand);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 37);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(259, 570);
            this.metroPanel1.TabIndex = 17;
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
            // pb_AccountIcon
            // 
            this.pb_AccountIcon.Image = ((System.Drawing.Image)(resources.GetObject("pb_AccountIcon.Image")));
            this.pb_AccountIcon.Location = new System.Drawing.Point(34, 88);
            this.pb_AccountIcon.Name = "pb_AccountIcon";
            this.pb_AccountIcon.Size = new System.Drawing.Size(30, 26);
            this.pb_AccountIcon.TabIndex = 21;
            this.pb_AccountIcon.TabStop = false;
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
            this.btn_Import.Visible = false;

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
            this.btn_Export.Visible = false;
            // 
            // btn_InStock
            // 
            this.btn_InStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_InStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_InStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.btn_InStock.BorderRadius = 0;
            this.btn_InStock.BorderSize = 0;
            this.btn_InStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_InStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InStock.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_InStock.ForeColor = System.Drawing.Color.White;
            this.btn_InStock.Location = new System.Drawing.Point(0, 130);
            this.btn_InStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_InStock.Name = "btn_InStock";
            this.btn_InStock.Size = new System.Drawing.Size(262, 60);
            this.btn_InStock.TabIndex = 16;
            this.btn_InStock.Text = "Hàng trong kho";
            this.btn_InStock.TextColor = System.Drawing.Color.White;
            this.btn_InStock.UseVisualStyleBackColor = false;
            // 
            // btn_InventoryControl
            // 
            this.btn_InventoryControl.BackColor = System.Drawing.Color.White;
            this.btn_InventoryControl.BackgroundColor = System.Drawing.Color.White;
            this.btn_InventoryControl.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_InventoryControl.BorderRadius = 0;
            this.btn_InventoryControl.BorderSize = 0;
            this.btn_InventoryControl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_InventoryControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InventoryControl.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_InventoryControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_InventoryControl.Location = new System.Drawing.Point(0, 189);
            this.btn_InventoryControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_InventoryControl.Name = "btn_InventoryControl";
            this.btn_InventoryControl.Size = new System.Drawing.Size(262, 56);
            this.btn_InventoryControl.TabIndex = 16;
            this.btn_InventoryControl.Text = "Kiểm kho";
            this.btn_InventoryControl.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btn_InventoryControl.UseVisualStyleBackColor = false;
            this.btn_InventoryControl.Click += new System.EventHandler(this.btn_KiemKho_Click);
            // 
            // pictureBoxBrand
            // 
            this.pictureBoxBrand.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBrand.Image")));
            this.pictureBoxBrand.Location = new System.Drawing.Point(100, 14);
            this.pictureBoxBrand.Name = "pictureBoxBrand";
            this.pictureBoxBrand.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxBrand.TabIndex = 16;
            this.pictureBoxBrand.TabStop = false;
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
            this.btn_SignOut.Location = new System.Drawing.Point(1042, 37);
            this.btn_SignOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(117, 35);
            this.btn_SignOut.TabIndex = 22;
            this.btn_SignOut.Text = "Đăng xuất";
            this.btn_SignOut.TextColor = System.Drawing.Color.White;
            this.btn_SignOut.UseVisualStyleBackColor = false;
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
            this.btn_ExportFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ExportFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_ExportFile.Location = new System.Drawing.Point(1042, 80);
            this.btn_ExportFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ExportFile.Name = "btn_ExportFile";
            this.btn_ExportFile.Size = new System.Drawing.Size(117, 35);
            this.btn_ExportFile.TabIndex = 30;
            this.btn_ExportFile.Text = "Xuất file";
            this.btn_ExportFile.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_ExportFile.UseVisualStyleBackColor = false;

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
            // btn_Add
            // 

            btn_Them.BackColor = Color.FromArgb(253, 197, 183);
            btn_Them.BackgroundColor = Color.FromArgb(253, 197, 183);
            btn_Them.BorderColor = Color.FromArgb(215, 122, 125);
            btn_Them.BorderRadius = 8;
            btn_Them.BorderSize = 1;
            btn_Them.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_Them.FlatStyle = FlatStyle.Flat;
            btn_Them.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Them.ForeColor = Color.FromArgb(229, 1, 17);
            btn_Them.Location = new Point(936, 80);
            btn_Them.Margin = new Padding(3, 4, 3, 4);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(104, 35);
            btn_Them.TabIndex = 33;
            btn_Them.Text = "+ Thêm";
            btn_Them.TextColor = Color.FromArgb(229, 1, 17);
            btn_Them.UseVisualStyleBackColor = false;
            btn_Them.Click += btn_Them_Click;
            // 
            // dgv_HangTrongKho

            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            this.btn_Add.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            this.btn_Add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btn_Add.BorderRadius = 8;
            this.btn_Add.BorderSize = 1;
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Add.Location = new System.Drawing.Point(932, 80);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(104, 35);
            this.btn_Add.TabIndex = 33;
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
            this.btn_Delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Delete.Location = new System.Drawing.Point(847, 80);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(79, 35);
            this.btn_Delete.TabIndex = 34;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // dgv_InStock

            // 
            this.dgv_InStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.dgv_InStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_InStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_InStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_InStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_InStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_InStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_InStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_InStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommodityID,
            this.CommodityName,
            this.Unit,
            this.Quantity,
            this.ImportDate});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_InStock.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_InStock.EnableHeadersVisualStyles = false;
            this.dgv_InStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_InStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.dgv_InStock.Location = new System.Drawing.Point(265, 123);
            this.dgv_InStock.Name = "dgv_InStock";
            this.dgv_InStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_InStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_InStock.RowHeadersVisible = false;
            this.dgv_InStock.RowHeadersWidth = 51;
            this.dgv_InStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_InStock.RowTemplate.Height = 29;
            this.dgv_InStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_InStock.Size = new System.Drawing.Size(905, 463);
            this.dgv_InStock.TabIndex = 35;
            // 
            // CommodityID
            // 
            this.CommodityID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CommodityID.FillWeight = 1F;
            this.CommodityID.HeaderText = "Mã hàng hóa";
            this.CommodityID.MinimumWidth = 150;
            this.CommodityID.Name = "CommodityID";
            this.CommodityID.ReadOnly = true;
            // 
            // CommodityName
            // 
            this.CommodityName.FillWeight = 3F;
            this.CommodityName.HeaderText = "Tên hàng hóa";
            this.CommodityName.MinimumWidth = 300;
            this.CommodityName.Name = "CommodityName";
            this.CommodityName.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.FillWeight = 1F;
            this.Unit.HeaderText = "Đơn vị tính";
            this.Unit.MinimumWidth = 150;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 1F;
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.MinimumWidth = 150;
            this.Quantity.Name = "Quantity";
            // 
            // ImportDate
            // 
            this.ImportDate.FillWeight = 1F;
            this.ImportDate.HeaderText = "Ngày nhập";
            this.ImportDate.MinimumWidth = 150;
            this.ImportDate.Name = "ImportDate";
            // 
            // HangHoaTrongKho
            // 

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 605);
            Controls.Add(dgv_HangTrongKho);
            Controls.Add(btn_Them);
            Controls.Add(metroGrid1);
           
            Controls.Add(metroPanel1);
            Name = "HangHoaTrongKho";
            Load += HangHoaTrongKho_Load;
            metroPanel1.ResumeLayout(false);
            metroPanel1.PerformLayout();
          
            ((System.ComponentModel.ISupportInitialize)metroGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_HangTrongKho).EndInit();
            ResumeLayout(false);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 605);
            this.Controls.Add(this.dgv_InStock);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.btn_ExportFile);
            this.Controls.Add(this.btn_SignOut);
            this.Controls.Add(this.metroPanel1);
            this.Name = "HangHoaTrongKho";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AccountIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InStock)).EndInit();
            this.ResumeLayout(false);


        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private CustomControls.RoundedButton btn_Import;
        private CustomControls.RoundedButton btn_Export;
        private CustomControls.RoundedButton btn_InStock;
        private CustomControls.RoundedButton btn_InventoryControl;
        private PictureBox pictureBoxBrand;
        private CustomControls.RoundedButton btn_SignOut;
        private PictureBox pb_AccountIcon;
        private Label lbl_AccountName;
        private CustomControls.RoundedButton btn_ExportFile;
        private MetroFramework.Controls.MetroGrid metroGrid1;

        private CustomControls.RoundedButton btn_Them;
        private MetroFramework.Controls.MetroGrid dgv_HangTrongKho;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;

        private CustomControls.RoundedButton btn_Add;
        private CustomControls.RoundedButton btn_Delete;
        private MetroFramework.Controls.MetroGrid dgv_InStock;
        private DataGridViewTextBoxColumn CommodityID;
        private DataGridViewTextBoxColumn CommodityName;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn ImportDate;

    }
}