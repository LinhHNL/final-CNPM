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
            lbl_Gio.Hide();
            lbl_Ca.Hide();
            label2.Hide();
        }

        public void setCa(int hourStart, int minStart, int hourEnd, int minEnd, int shift)
        {
            lbl_Gio.Show();
            lbl_Ca.Show();
            label2.Show();
            lbl_Gio.Text = hourStart.ToString().PadLeft(2, '0') + ":" + minStart.ToString().PadLeft(2, '0') + " - " + hourEnd.ToString().PadLeft(2, '0') + ":" + minEnd.ToString().PadLeft(2, '0');
            lbl_Ca.Text = "Ca " + shift;
        }

        public void setOff()
        {
            lbl_Gio.Hide();
            lbl_Ca.Hide();
            label2.Hide();
            lbl_Nghi.Visible = true;
        }

        public void setDefault()
        {
            lbl_Gio.Hide();
            lbl_Ca.Hide();
            label2.Hide();
            lbl_Nghi.Visible = false;
        }

        public Label getDay()
        {
            return label1;
        }
    }
}
