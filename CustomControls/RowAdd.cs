using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.CustomControls
{
    public partial class RowAdd : UserControl
    {
        String label;
        public RowAdd()
        {
            InitializeComponent();
        }

        public RowAdd(String label)
        {
            InitializeComponent();
            this.label = label;
            label1.Text = label;
        }

        public RowAdd(String label, int index)
        {
            InitializeComponent();
            this.label = label;
            label1.Text = label;
            if (index % 2 == 0)
                this.BackColor = ColorTranslator.FromHtml("#E9ECEF");
            else
                this.BackColor = Color.White;
        }
    }
}
