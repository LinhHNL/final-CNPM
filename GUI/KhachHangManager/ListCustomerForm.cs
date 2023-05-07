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
using WinFormsApp2.KhoPage;

namespace WinFormsApp2.KhachHangManager
{
    public partial class ListCustomerForm : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public ListCustomerForm()
        {
            InitializeComponent();
            SetLanguage("en-US");
        }

        public void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("GUI.Language.MyResource",
                             typeof(HangHoaTrongKho).Assembly);
            btn_SignOut.Text = rm.GetString("signoutText", culture);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);


            CustomerID.HeaderText = rm.GetString("customerIDText", culture);
            FullName.HeaderText = rm.GetString("fullNameText", culture);
            Phone.HeaderText = rm.GetString("phoneText", culture);
            Address.HeaderText = rm.GetString("addressText", culture);
            MembershipType.HeaderText = rm.GetString("membershipTypeText", culture);

            btn_Add.Text = rm.GetString("addText", culture);
            btn_Delete.Text = rm.GetString("deleteText", culture);
            btn_ExportFile.Text = rm.GetString("exportFileText", culture);
            lbl_CustomerList.Text = rm.GetString("customerListText", culture);
            lbl_Search.Text = rm.GetString("customerListText", culture);
            tb_CustomerIDName.PlaceholderText = rm.GetString("customerIDNameText", culture);

        }
    }
}
