using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.NhanVienPage
{
    public partial class QuanLyDonTu : MetroFramework.Forms.MetroForm
    {
        public QuanLyDonTu()
        {
            InitializeComponent();
            ColumnState.Text = " OK";
            var col = (DataGridViewButtonColumn)dgv_DonTu.Columns[4];
            col.FlatStyle = FlatStyle.Flat;
            dgv_DonTu.Rows.Add("...", "...", "--/ --/ ----", "...", "OK") ;
            var cell = (DataGridViewButtonCell)dgv_DonTu.Rows[1].Cells[4];

            dgv_DonTu.Rows[1].Cells[4].Style.BackColor = ColorTranslator.FromHtml("#058C42");
            dgv_DonTu.Rows.Add("...", "...", "--/ --/ ----", "...", new CustomControls.ButtonTrangThai(0));
            dgv_DonTu.Rows.Add("...", "...", "--/ --/ ----", "...", new CustomControls.ButtonTrangThai(-1));
            
        }

        
    }
}
