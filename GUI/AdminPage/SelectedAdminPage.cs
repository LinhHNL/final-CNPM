using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Resources;
using System.Globalization;

namespace WinFormsApp2.AdminPage
{
    public partial class SelectedAdminPage : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public SelectedAdminPage()
        {
            InitializeComponent();
            culture = CultureInfo.CurrentCulture;
            SetLanguage("en-US");
        }
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("GUI.Language.MyResource", typeof(SelectedAdminPage).Assembly);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
            btn_Signout.Text = rm.GetString("signoutText", culture);
            lbl_FoodManagement.Text = rm.GetString("foodManagementText", culture);
            lbl_customerManagement.Text = rm.GetString("customerManagementText", culture);
            lbl_StaffManagement.Text = rm.GetString("staffManagementText", culture);
            lbl_StockManagement.Text = rm.GetString("stockManagementText", culture);
            lbl_Statistic.Text = rm.GetString("statisticsText", culture);
        }
    }
}
