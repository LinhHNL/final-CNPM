namespace WinFormsApp2.KhoPage
{
    partial class SuaThongTinHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaThongTinHangHoa));
            this.btn_SignOut = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_Save = new WinFormsApp2.CustomControls.RoundedButton();
            this.lbl_CommodityInfo = new System.Windows.Forms.Label();
            this.tb_CommodityID = new WinFormsApp2.CustomControls.RoundedTextBox();
            this.lbl_CommodityID = new System.Windows.Forms.Label();
            this.tb_CommodityName = new WinFormsApp2.CustomControls.RoundedTextBox();
            this.tb_ImportDate = new WinFormsApp2.CustomControls.RoundedTextBox();
            this.tb_Unit = new WinFormsApp2.CustomControls.RoundedTextBox();
            this.tb_Quantity = new WinFormsApp2.CustomControls.RoundedTextBox();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.lbl_ImportDate = new System.Windows.Forms.Label();
            this.lbl_CommodityName = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.btn_Edit = new WinFormsApp2.CustomControls.RoundedButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lbl_AccountName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.btn_Import = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_Export = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_InStock = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_InventoryControl = new WinFormsApp2.CustomControls.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.btn_SignOut.Location = new System.Drawing.Point(1042, 37);
            this.btn_SignOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(117, 35);
            this.btn_SignOut.TabIndex = 22;
            this.btn_SignOut.Text = "Đăng xuất";
            this.btn_SignOut.TextColor = System.Drawing.Color.White;
            this.btn_SignOut.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Save.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.btn_Save.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btn_Save.BorderRadius = 8;
            this.btn_Save.BorderSize = 1;
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(669, 438);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(83, 35);
            this.btn_Save.TabIndex = 28;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.TextColor = System.Drawing.Color.White;
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // lbl_CommodityInfo
            // 
            this.lbl_CommodityInfo.AutoSize = true;
            this.lbl_CommodityInfo.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CommodityInfo.Location = new System.Drawing.Point(276, 81);
            this.lbl_CommodityInfo.Name = "lbl_CommodityInfo";
            this.lbl_CommodityInfo.Size = new System.Drawing.Size(237, 35);
            this.lbl_CommodityInfo.TabIndex = 29;
            this.lbl_CommodityInfo.Text = "Thông tin hàng hóa";
            // 
            // tb_CommodityID
            // 
            this.tb_CommodityID.BackColor = System.Drawing.SystemColors.Window;
            this.tb_CommodityID.BorderColor = System.Drawing.Color.Gray;
            this.tb_CommodityID.BorderFocusColor = System.Drawing.Color.Black;
            this.tb_CommodityID.BorderRadius = 10;
            this.tb_CommodityID.BorderSize = 2;
            this.tb_CommodityID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_CommodityID.ForeColor = System.Drawing.Color.Black;
            this.tb_CommodityID.Location = new System.Drawing.Point(565, 165);
            this.tb_CommodityID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CommodityID.Multiline = false;
            this.tb_CommodityID.Name = "tb_CommodityID";
            this.tb_CommodityID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_CommodityID.PasswordChar = false;
            this.tb_CommodityID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_CommodityID.PlaceholderText = "";
            this.tb_CommodityID.Size = new System.Drawing.Size(214, 39);
            this.tb_CommodityID.TabIndex = 30;
            this.tb_CommodityID.Texts = "";
            this.tb_CommodityID.UnderlinedStyle = false;
            // 
            // lbl_CommodityID
            // 
            this.lbl_CommodityID.AutoSize = true;
            this.lbl_CommodityID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CommodityID.Location = new System.Drawing.Point(397, 171);
            this.lbl_CommodityID.Name = "lbl_CommodityID";
            this.lbl_CommodityID.Size = new System.Drawing.Size(126, 24);
            this.lbl_CommodityID.TabIndex = 31;
            this.lbl_CommodityID.Text = "Mã hàng hóa:";
            // 
            // tb_CommodityName
            // 
            this.tb_CommodityName.BackColor = System.Drawing.SystemColors.Window;
            this.tb_CommodityName.BorderColor = System.Drawing.Color.Gray;
            this.tb_CommodityName.BorderFocusColor = System.Drawing.Color.Black;
            this.tb_CommodityName.BorderRadius = 10;
            this.tb_CommodityName.BorderSize = 2;
            this.tb_CommodityName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_CommodityName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.tb_CommodityName.Location = new System.Drawing.Point(565, 214);
            this.tb_CommodityName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CommodityName.Multiline = false;
            this.tb_CommodityName.Name = "tb_CommodityName";
            this.tb_CommodityName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_CommodityName.PasswordChar = false;
            this.tb_CommodityName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_CommodityName.PlaceholderText = "";
            this.tb_CommodityName.Size = new System.Drawing.Size(214, 39);
            this.tb_CommodityName.TabIndex = 32;
            this.tb_CommodityName.Texts = "";
            this.tb_CommodityName.UnderlinedStyle = false;
            // 
            // tb_ImportDate
            // 
            this.tb_ImportDate.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ImportDate.BorderColor = System.Drawing.Color.Gray;
            this.tb_ImportDate.BorderFocusColor = System.Drawing.Color.Black;
            this.tb_ImportDate.BorderRadius = 10;
            this.tb_ImportDate.BorderSize = 2;
            this.tb_ImportDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ImportDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.tb_ImportDate.Location = new System.Drawing.Point(565, 265);
            this.tb_ImportDate.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ImportDate.Multiline = false;
            this.tb_ImportDate.Name = "tb_ImportDate";
            this.tb_ImportDate.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_ImportDate.PasswordChar = false;
            this.tb_ImportDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_ImportDate.PlaceholderText = "";
            this.tb_ImportDate.Size = new System.Drawing.Size(214, 39);
            this.tb_ImportDate.TabIndex = 33;
            this.tb_ImportDate.Texts = "";
            this.tb_ImportDate.UnderlinedStyle = false;
            // 
            // tb_Unit
            // 
            this.tb_Unit.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Unit.BorderColor = System.Drawing.Color.Gray;
            this.tb_Unit.BorderFocusColor = System.Drawing.Color.Black;
            this.tb_Unit.BorderRadius = 10;
            this.tb_Unit.BorderSize = 2;
            this.tb_Unit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Unit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.tb_Unit.Location = new System.Drawing.Point(565, 316);
            this.tb_Unit.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Unit.Multiline = false;
            this.tb_Unit.Name = "tb_Unit";
            this.tb_Unit.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Unit.PasswordChar = false;
            this.tb_Unit.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_Unit.PlaceholderText = "";
            this.tb_Unit.Size = new System.Drawing.Size(214, 39);
            this.tb_Unit.TabIndex = 34;
            this.tb_Unit.Texts = "";
            this.tb_Unit.UnderlinedStyle = false;
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Quantity.BorderColor = System.Drawing.Color.Gray;
            this.tb_Quantity.BorderFocusColor = System.Drawing.Color.Black;
            this.tb_Quantity.BorderRadius = 10;
            this.tb_Quantity.BorderSize = 2;
            this.tb_Quantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.tb_Quantity.Location = new System.Drawing.Point(565, 367);
            this.tb_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Quantity.Multiline = false;
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_Quantity.PasswordChar = false;
            this.tb_Quantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_Quantity.PlaceholderText = "";
            this.tb_Quantity.Size = new System.Drawing.Size(214, 39);
            this.tb_Quantity.TabIndex = 35;
            this.tb_Quantity.Texts = "";
            this.tb_Quantity.UnderlinedStyle = false;
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Unit.Location = new System.Drawing.Point(396, 324);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(111, 24);
            this.lbl_Unit.TabIndex = 36;
            this.lbl_Unit.Text = "Đơn vị tính:";
            // 
            // lbl_ImportDate
            // 
            this.lbl_ImportDate.AutoSize = true;
            this.lbl_ImportDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ImportDate.Location = new System.Drawing.Point(396, 273);
            this.lbl_ImportDate.Name = "lbl_ImportDate";
            this.lbl_ImportDate.Size = new System.Drawing.Size(105, 24);
            this.lbl_ImportDate.TabIndex = 37;
            this.lbl_ImportDate.Text = "Ngày nhập:";
            // 
            // lbl_CommodityName
            // 
            this.lbl_CommodityName.AutoSize = true;
            this.lbl_CommodityName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CommodityName.Location = new System.Drawing.Point(395, 222);
            this.lbl_CommodityName.Name = "lbl_CommodityName";
            this.lbl_CommodityName.Size = new System.Drawing.Size(128, 24);
            this.lbl_CommodityName.TabIndex = 38;
            this.lbl_CommodityName.Text = "Tên hàng hóa:";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Quantity.Location = new System.Drawing.Point(397, 372);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(92, 24);
            this.lbl_Quantity.TabIndex = 39;
            this.lbl_Quantity.Text = "Số lượng:";
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
            this.btn_Edit.Location = new System.Drawing.Point(580, 438);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(83, 35);
            this.btn_Edit.TabIndex = 40;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.TextColor = System.Drawing.Color.White;
            this.btn_Edit.UseVisualStyleBackColor = false;
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
            this.metroPanel1.Location = new System.Drawing.Point(11, 27);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(259, 570);
            this.metroPanel1.TabIndex = 42;
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
            this.btn_InventoryControl.Click += new System.EventHandler(this.btn_InventoryControl_Click);
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
            // SuaThongTinHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 605);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_CommodityName);
            this.Controls.Add(this.lbl_ImportDate);
            this.Controls.Add(this.lbl_Unit);
            this.Controls.Add(this.tb_Quantity);
            this.Controls.Add(this.tb_Unit);
            this.Controls.Add(this.tb_ImportDate);
            this.Controls.Add(this.tb_CommodityName);
            this.Controls.Add(this.lbl_CommodityID);
            this.Controls.Add(this.tb_CommodityID);
            this.Controls.Add(this.lbl_CommodityInfo);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_SignOut);
            this.Name = "SuaThongTinHangHoa";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RoundedButton btn_SignOut;
        private CustomControls.RoundedButton btn_Save;
        private Label lbl_CommodityInfo;
        private CustomControls.RoundedTextBox tb_CommodityID;
        private Label lbl_CommodityID;
        private CustomControls.RoundedTextBox tb_CommodityName;
        private CustomControls.RoundedTextBox tb_ImportDate;
        private CustomControls.RoundedTextBox tb_Unit;
        private CustomControls.RoundedTextBox tb_Quantity;
        private Label lbl_Unit;
        private Label lbl_ImportDate;
        private Label lbl_CommodityName;
        private Label lbl_Quantity;
        private CustomControls.RoundedButton btn_Edit;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Label lbl_AccountName;
        private PictureBox pictureBox2;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private CustomControls.RoundedButton btn_Import;
        private CustomControls.RoundedButton btn_Export;
        private CustomControls.RoundedButton btn_InStock;
        private CustomControls.RoundedButton btn_InventoryControl;
        private PictureBox pictureBox1;
    }
}