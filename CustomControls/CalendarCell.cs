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
    public partial class CalendarCell : UserControl
    {
        public CalendarCell()
        {
            InitializeComponent();
        }

        public Label getDay()
        {
            return label1;
        }
    }
}
