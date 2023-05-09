using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using WinFormsApp2.AdminPage;

namespace WinFormsApp2.CustomControls
{
    public partial class CalendarCell : UserControl
    {
        CultureInfo culture;
        public CalendarCell()
        {
            InitializeComponent();
            lbl_Gio.Hide();
            lbl_Shift.Hide();
            lbl_WorkHours.Hide();
            culture = CultureInfo.CurrentCulture;
            SetLanguage("en-US");
        }

        public void setCa(int hourStart, int minStart, int hourEnd, int minEnd, int shift)
        {
            lbl_Gio.Show();
            lbl_Shift.Show();
            lbl_WorkHours.Show();
            lbl_Gio.Text = hourStart.ToString().PadLeft(2, '0') + ":" + minStart.ToString().PadLeft(2, '0') + " - " + hourEnd.ToString().PadLeft(2, '0') + ":" + minEnd.ToString().PadLeft(2, '0');
            lbl_Shift.Text = lbl_Shift.Text + " " + shift;
        }

        public void setOff()
        {
            lbl_Gio.Hide();
            lbl_Shift.Hide();
            lbl_WorkHours.Hide();
            lbl_Dayoff.Visible = true;
        }

        public void setDefault()
        {
            lbl_Gio.Hide();
            lbl_Shift.Hide();
            lbl_WorkHours.Hide();
            lbl_Dayoff.Visible = false;
        }

        public Label getDay()
        {
            return label1;
        }
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("GUI.Language.MyResource", typeof(CalendarCell).Assembly);
            lbl_Shift.Text = rm.GetString("shiftText", culture);
            lbl_Dayoff.Text = rm.GetString("dayoffText", culture);
            lbl_WorkHours.Text = rm.GetString("workHoursText", culture);
        }
    }
}
