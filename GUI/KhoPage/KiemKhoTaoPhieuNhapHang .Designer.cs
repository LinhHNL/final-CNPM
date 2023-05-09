namespace WinFormsApp2.KhoPage
{
    partial class KiemKhoTaoPhieuNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiemKhoTaoPhieuNhapHang));
            this.btn_SignOut = new WinFormsApp2.CustomControls.RoundedButton();
            this.lbl_ImportNote = new System.Windows.Forms.Label();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.dgv_Import = new MetroFramework.Controls.MetroGrid();
            this.lbl_ImportID = new System.Windows.Forms.Label();
            this.tb_ImportID = new WinFormsApp2.CustomControls.LeftAlignRoundedTextBox();
            this.tb_ImportDate = new WinFormsApp2.CustomControls.LeftAlignRoundedTextBox();
            this.lbl_ImportDate = new System.Windows.Forms.Label();
            this.btn_CreateNote = new WinFormsApp2.CustomControls.RoundedButton();
            this.btn_Add = new System.Windows.Forms.PictureBox();
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
            this.CommodityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommodityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Import)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SignOut
            // 
<<<<<<< HEAD
            btn_DangXuat.BackColor = Color.FromArgb(229, 1, 17);
            btn_DangXuat.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_DangXuat.BorderColor = Color.PaleVioletRed;
            btn_DangXuat.BorderRadius = 8;
            btn_DangXuat.BorderSize = 0;
            btn_DangXuat.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_DangXuat.FlatStyle = FlatStyle.Flat;
            btn_DangXuat.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_DangXuat.ForeColor = Color.White;
            btn_DangXuat.Location = new Point(925, 26);
            btn_DangXuat.Name = "btn_DangXuat";
            btn_DangXuat.Size = new Size(102, 26);
            btn_DangXuat.TabIndex = 22;
            btn_DangXuat.Text = "Đăng xuất";
            btn_DangXuat.TextColor = Color.White;
            btn_DangXuat.UseVisualStyleBackColor = false;
=======
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
>>>>>>> 8d249ced943f806d153ec3e35ac6189216f94312
            // 
            // lbl_ImportNote
            // 
<<<<<<< HEAD
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(232, 58);
            label1.Name = "label1";
            label1.Size = new Size(199, 33);
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
            metroGrid1.Location = new Point(333, 115);
            metroGrid1.Margin = new Padding(3, 2, 3, 2);
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
            metroGrid1.Size = new Size(7, 6);
            metroGrid1.TabIndex = 31;
=======
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
>>>>>>> 8d249ced943f806d153ec3e35ac6189216f94312
            // 
            // dgv_Import
            // 
<<<<<<< HEAD
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
            dgv_HangHoa.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4 });
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
            dgv_HangHoa.Location = new Point(234, 164);
            dgv_HangHoa.Margin = new Padding(3, 2, 3, 2);
            dgv_HangHoa.Name = "dgv_HangHoa";
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
            dgv_HangHoa.Size = new Size(792, 225);
            dgv_HangHoa.TabIndex = 32;
            dgv_HangHoa.CellContentClick += dgv_HangHoa_CellContentClick;
=======
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
>>>>>>> 8d249ced943f806d153ec3e35ac6189216f94312
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
<<<<<<< HEAD
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(235, 100);
            label2.Name = "label2";
            label2.Size = new Size(106, 19);
            label2.TabIndex = 33;
            label2.Text = "Mã nhập hàng:";
=======
            this.lbl_ImportDate.AutoSize = true;
            this.lbl_ImportDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ImportDate.Location = new System.Drawing.Point(269, 178);
            this.lbl_ImportDate.Name = "lbl_ImportDate";
            this.lbl_ImportDate.Size = new System.Drawing.Size(104, 24);
            this.lbl_ImportDate.TabIndex = 35;
            this.lbl_ImportDate.Text = "Ngày nhập:";
>>>>>>> 8d249ced943f806d153ec3e35ac6189216f94312
            // 
            // btn_CreateNote
            // 
<<<<<<< HEAD
            tb_MaNhapHang.BackColor = SystemColors.Window;
            tb_MaNhapHang.BorderColor = Color.FromArgb(173, 181, 189);
            tb_MaNhapHang.BorderFocusColor = Color.Black;
            tb_MaNhapHang.BorderRadius = 10;
            tb_MaNhapHang.BorderSize = 1;
            tb_MaNhapHang.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_MaNhapHang.ForeColor = Color.Black;
            tb_MaNhapHang.Location = new Point(393, 94);
            tb_MaNhapHang.Margin = new Padding(4, 3, 4, 3);
            tb_MaNhapHang.Multiline = false;
            tb_MaNhapHang.Name = "tb_MaNhapHang";
            tb_MaNhapHang.Padding = new Padding(9, 5, 9, 5);
            tb_MaNhapHang.PasswordChar = false;
            tb_MaNhapHang.PlaceholderColor = Color.DarkGray;
            tb_MaNhapHang.PlaceholderText = "";
            tb_MaNhapHang.ReadOnly = true;
            tb_MaNhapHang.Size = new Size(238, 30);
            tb_MaNhapHang.TabIndex = 34;
            tb_MaNhapHang.Texts = "";
            tb_MaNhapHang.UnderlinedStyle = false;
=======
            this.btn_CreateNote.BackColor = System.Drawing.Color.Black;
            this.btn_CreateNote.BackgroundColor = System.Drawing.Color.Black;
            this.btn_CreateNote.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_CreateNote.BorderRadius = 8;
            this.btn_CreateNote.BorderSize = 0;
            this.btn_CreateNote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_CreateNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateNote.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CreateNote.ForeColor = System.Drawing.Color.White;
            this.btn_CreateNote.Location = new System.Drawing.Point(1057, 560);
            this.btn_CreateNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CreateNote.Name = "btn_CreateNote";
            this.btn_CreateNote.Size = new System.Drawing.Size(117, 35);
            this.btn_CreateNote.TabIndex = 39;
            this.btn_CreateNote.Text = "Tạo phiếu";
            this.btn_CreateNote.TextColor = System.Drawing.Color.White;
            this.btn_CreateNote.UseVisualStyleBackColor = false;
>>>>>>> 8d249ced943f806d153ec3e35ac6189216f94312
            // 
            // btn_Add
            // 
<<<<<<< HEAD
            tb_NgayNhap.BackColor = SystemColors.Window;
            tb_NgayNhap.BorderColor = Color.FromArgb(173, 181, 189);
            tb_NgayNhap.BorderFocusColor = Color.Black;
            tb_NgayNhap.BorderRadius = 10;
            tb_NgayNhap.BorderSize = 1;
            tb_NgayNhap.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_NgayNhap.ForeColor = Color.Black;
            tb_NgayNhap.Location = new Point(393, 129);
            tb_NgayNhap.Margin = new Padding(4, 3, 4, 3);
            tb_NgayNhap.Multiline = false;
            tb_NgayNhap.Name = "tb_NgayNhap";
            tb_NgayNhap.Padding = new Padding(9, 5, 9, 5);
            tb_NgayNhap.PasswordChar = false;
            tb_NgayNhap.PlaceholderColor = Color.DarkGray;
            tb_NgayNhap.PlaceholderText = "";
            tb_NgayNhap.ReadOnly = false;
            tb_NgayNhap.Size = new Size(238, 30);
            tb_NgayNhap.TabIndex = 36;
            tb_NgayNhap.Texts = "";
            tb_NgayNhap.UnderlinedStyle = false;
=======
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.Location = new System.Drawing.Point(1141, 524);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(33, 34);
            this.btn_Add.TabIndex = 41;
            this.btn_Add.TabStop = false;
>>>>>>> 8d249ced943f806d153ec3e35ac6189216f94312
            // 
            // btn_ExportFile
            // 
<<<<<<< HEAD
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(235, 134);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 35;
            label3.Text = "Ngày nhập:";
            // 
            // btn_TaoPhieu
            // 
            btn_TaoPhieu.BackColor = Color.Black;
            btn_TaoPhieu.BackgroundColor = Color.Black;
            btn_TaoPhieu.BorderColor = Color.PaleVioletRed;
            btn_TaoPhieu.BorderRadius = 8;
            btn_TaoPhieu.BorderSize = 0;
            btn_TaoPhieu.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_TaoPhieu.FlatStyle = FlatStyle.Flat;
            btn_TaoPhieu.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_TaoPhieu.ForeColor = Color.White;
            btn_TaoPhieu.Location = new Point(925, 420);
            btn_TaoPhieu.Name = "btn_TaoPhieu";
            btn_TaoPhieu.Size = new Size(102, 26);
            btn_TaoPhieu.TabIndex = 39;
            btn_TaoPhieu.Text = "Tạo phiếu";
            btn_TaoPhieu.TextColor = Color.White;
            btn_TaoPhieu.UseVisualStyleBackColor = false;
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
            btn_XuatFile.Location = new Point(925, 64);
            btn_XuatFile.Name = "btn_XuatFile";
            btn_XuatFile.Size = new Size(102, 26);
            btn_XuatFile.TabIndex = 42;
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
            metroPanel1.HorizontalScrollbarSize = 8;
            metroPanel1.Location = new Point(4, 26);
            metroPanel1.Margin = new Padding(3, 2, 3, 2);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(227, 428);
            metroPanel1.TabIndex = 46;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 9;
=======
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
            this.btn_ExportFile.TabIndex = 42;
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
            this.metroPanel1.Location = new System.Drawing.Point(4, 35);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(259, 570);
            this.metroPanel1.TabIndex = 46;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
>>>>>>> 8d249ced943f806d153ec3e35ac6189216f94312
            // 
            // lbl_AccountName
            // 
<<<<<<< HEAD
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(229, 1, 17);
            label4.Location = new Point(61, 64);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 31;
            label4.Text = "Tên tài khoản";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(30, 66);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 20);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // metroPanel7
            // 
            metroPanel7.BackColor = Color.Black;
            metroPanel7.HorizontalScrollbarBarColor = true;
            metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel7.HorizontalScrollbarSize = 8;
            metroPanel7.Location = new Point(227, 404);
            metroPanel7.Margin = new Padding(3, 2, 3, 2);
            metroPanel7.Name = "metroPanel7";
            metroPanel7.Size = new Size(791, 41);
            metroPanel7.TabIndex = 20;
            metroPanel7.VerticalScrollbarBarColor = true;
            metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            metroPanel7.VerticalScrollbarSize = 9;
=======
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
>>>>>>> 8d249ced943f806d153ec3e35ac6189216f94312
            // 
            // btn_Import
            // 
<<<<<<< HEAD
            btn_NhapHang.BackColor = Color.FromArgb(253, 230, 232);
            btn_NhapHang.BackgroundColor = Color.FromArgb(253, 230, 232);
            btn_NhapHang.BorderColor = Color.FromArgb(0, 0, 15, 255);
            btn_NhapHang.BorderRadius = 0;
            btn_NhapHang.BorderSize = 0;
            btn_NhapHang.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_NhapHang.FlatStyle = FlatStyle.Flat;
            btn_NhapHang.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_NhapHang.ForeColor = Color.Black;
            btn_NhapHang.Location = new Point(-1, 226);
            btn_NhapHang.Name = "btn_NhapHang";
            btn_NhapHang.Size = new Size(230, 48);
            btn_NhapHang.TabIndex = 18;
            btn_NhapHang.Text = "Nhập hàng";
            btn_NhapHang.TextColor = Color.Black;
            btn_NhapHang.UseVisualStyleBackColor = false;
=======
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
>>>>>>> 8d249ced943f806d153ec3e35ac6189216f94312
            // 
            // btn_Export
            // 
<<<<<<< HEAD
            btn_XuatHang.BackColor = Color.FromArgb(253, 230, 232);
            btn_XuatHang.BackgroundColor = Color.FromArgb(253, 230, 232);
            btn_XuatHang.BorderColor = Color.Silver;
            btn_XuatHang.BorderRadius = 0;
            btn_XuatHang.BorderSize = 0;
            btn_XuatHang.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_XuatHang.FlatStyle = FlatStyle.Flat;
            btn_XuatHang.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_XuatHang.ForeColor = Color.FromArgb(160, 159, 159);
            btn_XuatHang.Location = new Point(-1, 182);
            btn_XuatHang.Name = "btn_XuatHang";
            btn_XuatHang.Size = new Size(231, 48);
            btn_XuatHang.TabIndex = 17;
            btn_XuatHang.Text = "Xuất hàng";
            btn_XuatHang.TextColor = Color.FromArgb(160, 159, 159);
            btn_XuatHang.UseVisualStyleBackColor = false;
            btn_XuatHang.Click += btn_XuatHang_Click;
=======
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
            this.btn_Export.Click += new System.EventHandler(this.btn_XuatHang_Click);
>>>>>>> 8d249ced943f806d153ec3e35ac6189216f94312
            // 
            // btn_InStock
            // 
<<<<<<< HEAD
            btn_HangTrongKho.BackColor = Color.White;
            btn_HangTrongKho.BackgroundColor = Color.White;
            btn_HangTrongKho.BorderColor = Color.FromArgb(0, 0, 15, 255);
            btn_HangTrongKho.BorderRadius = 0;
            btn_HangTrongKho.BorderSize = 0;
            btn_HangTrongKho.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_HangTrongKho.FlatStyle = FlatStyle.Flat;
            btn_HangTrongKho.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_HangTrongKho.ForeColor = Color.FromArgb(160, 159, 159);
            btn_HangTrongKho.Location = new Point(0, 98);
            btn_HangTrongKho.Name = "btn_HangTrongKho";
            btn_HangTrongKho.Size = new Size(229, 45);
            btn_HangTrongKho.TabIndex = 16;
            btn_HangTrongKho.Text = "Hàng trong kho";
            btn_HangTrongKho.TextColor = Color.FromArgb(160, 159, 159);
            btn_HangTrongKho.UseVisualStyleBackColor = false;
            btn_HangTrongKho.Click += btn_HangTrongKho_Click;
=======
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
            this.btn_InStock.Click += new System.EventHandler(this.btn_HangTrongKho_Click);
>>>>>>> 8d249ced943f806d153ec3e35ac6189216f94312
            // 
            // btn_InventoryControl
            // 
<<<<<<< HEAD
            btn_KiemKho.BackColor = Color.FromArgb(229, 1, 17);
            btn_KiemKho.BackgroundColor = Color.FromArgb(229, 1, 17);
            btn_KiemKho.BorderColor = Color.PaleVioletRed;
            btn_KiemKho.BorderRadius = 0;
            btn_KiemKho.BorderSize = 0;
            btn_KiemKho.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
            btn_KiemKho.FlatStyle = FlatStyle.Flat;
            btn_KiemKho.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_KiemKho.ForeColor = Color.White;
            btn_KiemKho.Location = new Point(0, 142);
            btn_KiemKho.Name = "btn_KiemKho";
            btn_KiemKho.Size = new Size(229, 42);
            btn_KiemKho.TabIndex = 16;
            btn_KiemKho.Text = "Kiểm kho";
            btn_KiemKho.TextColor = Color.White;
            btn_KiemKho.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(88, 10);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 38);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // KiemKhoTaoPhieuNhapHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 454);
            Controls.Add(metroPanel1);
            Controls.Add(btn_XuatFile);
            Controls.Add(btn_TaoPhieu);
            Controls.Add(tb_NgayNhap);
            Controls.Add(label3);
            Controls.Add(tb_MaNhapHang);
            Controls.Add(label2);
            Controls.Add(dgv_HangHoa);
            Controls.Add(metroGrid1);
            Controls.Add(label1);
            Controls.Add(btn_DangXuat);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KiemKhoTaoPhieuNhapHang";
            Padding = new Padding(18, 60, 18, 15);
            Text = "v";
            ((System.ComponentModel.ISupportInitialize)metroGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_HangHoa).EndInit();
            metroPanel1.ResumeLayout(false);
            metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
=======
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
            // KiemKhoTaoPhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 605);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btn_ExportFile);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_CreateNote);
            this.Controls.Add(this.tb_ImportDate);
            this.Controls.Add(this.lbl_ImportDate);
            this.Controls.Add(this.tb_ImportID);
            this.Controls.Add(this.lbl_ImportID);
            this.Controls.Add(this.dgv_Import);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.lbl_ImportNote);
            this.Controls.Add(this.btn_SignOut);
            this.Name = "KiemKhoTaoPhieuNhapHang";
            this.Text = "v";
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Import)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

>>>>>>> 8d249ced943f806d153ec3e35ac6189216f94312
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
        private CustomControls.RoundedButton btn_CreateNote;
        private PictureBox btn_Add;
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