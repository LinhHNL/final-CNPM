using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.Components
{
    public partial class MonAnAddingInPanel : UserControl
    {
        private string ten;
        private MonAnComponentForAdding context;
        private int soluong = 1;
        public MonAnAddingInPanel(String Ten, MonAnComponentForAdding context)
        {
            InitializeComponent();
            this.ten = Ten;
            this.context=context;
            lbl_TenMon.Text = ten;
            lbl_SoLuong.Text = soluong.ToString();
        }
    }
}