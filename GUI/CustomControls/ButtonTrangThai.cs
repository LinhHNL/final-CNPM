using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.AdminPage;
using System.Resources;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2.CustomControls
{
    public partial class ButtonTrangThai : UserControl
    {
        CultureInfo culture;
        private static string approvedText = "";
        private static string pendingText = "";
        private static string rejectedText = "";
        public ButtonTrangThai()
        {
            InitializeComponent();
            culture = CultureInfo.CurrentCulture;
            SetLanguage("en-US");
        }

        public ButtonTrangThai(int mode)
        {
            InitializeComponent();
            switch (mode)
            {
                case 0:
                    button.BackColor = ColorTranslator.FromHtml("#058C42");
                    button.Text = approvedText;
                    break;  
                case 1:
                    button.BackColor = ColorTranslator.FromHtml("#F9A620");
                    button.Text = pendingText;
                    break;
                case -1:
                    button.BackColor = ColorTranslator.FromHtml("#850A0A");
                    button.Text = rejectedText;
                    break;
            }
        }
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("GUI.Language.MyResource", typeof(ButtonTrangThai).Assembly);
            pendingText = rm.GetString("pendingText", culture);
            approvedText = rm.GetString("approvedText", culture);
            rejectedText = rm.GetString("rejectedText", culture);
        }
    }
}
