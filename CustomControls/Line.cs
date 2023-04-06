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
    public partial class Line : UserControl
    {
        public Line()
        {
            InitializeComponent();
        }

        private void Line_Paint(object sender, PaintEventArgs e)
        {
            Brush brush = new SolidBrush(ColorTranslator.FromHtml("#A09F9F"));
            e.Graphics.FillRectangle(brush, new Rectangle(0, 0, Width, Height));
        }
    }
}
