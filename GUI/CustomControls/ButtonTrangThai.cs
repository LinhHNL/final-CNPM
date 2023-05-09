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
    public partial class ButtonTrangThai : UserControl
    {
        public ButtonTrangThai()
        {
            InitializeComponent();
        }

        public ButtonTrangThai(int mode)
        {
            InitializeComponent();
            switch (mode)
            {
                case 0:
                    button.BackColor = ColorTranslator.FromHtml("#058C42");
                    button.Text = "Đã duyệt";
                    break;  
                case 1:
                    button.BackColor = ColorTranslator.FromHtml("#F9A620");
                    button.Text = "Chờ duyệt";
                    break;
                case -1:
                    button.BackColor = ColorTranslator.FromHtml("#850A0A");
                    button.Text = "Không duyệt";
                    break;
            }
        }
    }
}
