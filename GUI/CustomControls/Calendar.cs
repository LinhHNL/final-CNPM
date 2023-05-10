using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.NhanVienPage;
using System.Resources;
using System.Globalization;
using System.Text.RegularExpressions;
using WinFormsApp2.AdminPage;

namespace WinFormsApp2.CustomControls
{
    public partial class Calendar : UserControl
    {
        int month = 1, year = 2023;
        Dictionary<String, int> dict = new Dictionary<string, int>();
        Form parentForm;
        public Action<object, EventArgs> cellClickEvent;
        CultureInfo culture;

        public Calendar()
        {
            InitializeComponent();
            dict.Add("Sunday", 1);
            dict.Add("Monday", 2);
            dict.Add("Tuesday", 3);
            dict.Add("Wednesday", 4);
            dict.Add("Thursday", 5);
            dict.Add("Friday", 6);
            dict.Add("Saturday", 7);
            culture = CultureInfo.CurrentCulture;
            SetLanguage("en-US");
        }

        public Calendar(int month, int year)
        {
            InitializeComponent();
            this.month = month;
            this.year = year;
        }

        public int Month { get { return month; } }
        public int Year { get { return year; } }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(ColorTranslator.FromHtml("#A09F9F"));
            pen.Width = 1;
            //e.Graphics.DrawLine(pen, Width/7*0, Width/7*0 + 1, Width/7 * 0, Height+1);
            flowLayoutPanel1.Width = Width;
            flowLayoutPanel1.Height = Height;
            for (int i = 0; i < 7; i++)
            {
                e.Graphics.DrawLine(pen, Width / 7 * i, 0, Width / 7 * i, Height);
            }
            e.Graphics.DrawLine(pen, Width - 1, 0, Width - 1, Height);

            int titleHeight = flowLayoutPanel1.Controls[0].Height;
            e.Graphics.DrawLine(pen, 0, 0, Width, 0);
            e.Graphics.DrawLine(pen, 0, titleHeight, Width, titleHeight);
            int cellHeight = (Height - titleHeight) / 6;
            e.Graphics.DrawLine(pen, 0, titleHeight + (cellHeight * 1), Width, titleHeight + (cellHeight * 1));
            e.Graphics.DrawLine(pen, 0, titleHeight + (cellHeight * 2), Width, titleHeight + (cellHeight * 2));
            e.Graphics.DrawLine(pen, 0, titleHeight + (cellHeight * 3), Width, titleHeight + (cellHeight * 3));
            e.Graphics.DrawLine(pen, 0, titleHeight + (cellHeight * 4), Width, titleHeight + (cellHeight * 4));
            e.Graphics.DrawLine(pen, 0, titleHeight + (cellHeight * 5), Width, titleHeight + (cellHeight * 5));
            e.Graphics.DrawLine(pen, 0, Height - 1, Width, Height - 1);


        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            AddCells();
        }

        public void SetMonthYear(int month, int year)
        {
            this.month = month;
            this.year = year;
        }

        public void setParentForm(Form form)
        {
            this.parentForm = form;
        }

        public void Reload()
        {
            for (int i = flowLayoutPanel1.Controls.Count - 1; i >= 7; i--)
            {
                flowLayoutPanel1.Controls.RemoveAt(i);
            }
            AddCells();
        }

        private void AddCells()
        {
            DateTime dt = new DateTime(year, month, 1);
            String dw = dt.DayOfWeek.ToString();

            int prevMonth = month == 1 ? 12 : month - 1;
            int prevYear = year - 1;
            int daysOfPrevMonth = DateTime.DaysInMonth(prevYear, prevMonth);
            int daysOfCurrentMonth = DateTime.DaysInMonth(year, month);
            for (int i = 0; i < dict[dw] - 1; i++)
            {
                CalendarCell cell = new CalendarCell();
                int titleHeight = flowLayoutPanel1.Controls[0].Height;
                cell.Height = (Height - titleHeight) / 6;
                cell.Margin = new Padding(0, 0, 0, 0);
                cell.getDay().Text = (daysOfPrevMonth - dict[dw] + i + 2).ToString();
                cell.getDay().ForeColor = ColorTranslator.FromHtml("#A09F9F");
                flowLayoutPanel1.Controls.Add(cell);
            }
            for (int i = 1; i <= daysOfCurrentMonth; i++)
            {
                CalendarCell cell = new CalendarCell();
                int titleHeight = flowLayoutPanel1.Controls[0].Height;
                cell.Height = (Height - titleHeight) / 6;
                cell.Margin = new Padding(0, 0, 0, 0);
                cell.getDay().Text = i.ToString();
                cell.Click += new System.EventHandler(cellClickEvent);
                
                flowLayoutPanel1.Controls.Add(cell);
            }
            int currentCount = flowLayoutPanel1.Controls.Count;

            for (int i = 1; i <= 49 - currentCount; i++)
            {
                CalendarCell cell = new CalendarCell();
                int titleHeight = flowLayoutPanel1.Controls[0].Height;
                cell.Height = (Height - titleHeight) / 6;
                cell.Margin = new Padding(0, 0, 0, 0);
                cell.getDay().Text = i.ToString();
                cell.getDay().ForeColor = ColorTranslator.FromHtml("#A09F9F");
                flowLayoutPanel1.Controls.Add(cell);
            }
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Width = Width / 7;
            }
        }

        public CalendarCell getCellAtDay(int day)
        {
            DateTime dt = new DateTime(year, month, 1);
            String dw = dt.DayOfWeek.ToString();
            return (CalendarCell) flowLayoutPanel1.Controls[7 + dict[dw] + day-2];
        }
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("GUI.Language.MyResource", typeof(AddFood).Assembly);
            lbl_Friday.Text = rm.GetString("fridayText", culture);
            lbl_Monday.Text = rm.GetString("mondayText", culture);
            lbl_Saturday.Text = rm.GetString("saturdayText", culture);
            lbl_Sunday.Text = rm.GetString("sundayText", culture);
            lbl_Thursday.Text = rm.GetString("thursdayText", culture);
            lbl_Tuesday.Text = rm.GetString("tuesdayText", culture);
            lbl_Wednesday.Text = rm.GetString("wednesdayText", culture) ;
        }
    }

}
