using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using GUI.Components;
using BUS;
using System.Resources;
using System.Globalization;
using System.Text.RegularExpressions;
using GUI.AdminPage;

namespace WinFormsApp2.AdminPage
{
    public partial class LockFood : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public LockFood()
        {
            InitializeComponent();
            culture = CultureInfo.CurrentCulture;
            SetLanguage("en-US");
        }
        public void UpdateMenu()
        {
            pnl_food_lock.Controls.Clear();
            BUS.Menu menu = new BUS.Menu();
            List<Dictionary<string, string>> menuList = menu.getAllMenu();
            BUS.Combo combo = new Combo();
            List<Dictionary<string, string>> ComboList = combo.getAllCombo();
            foreach (Dictionary<string, string> item in ComboList)
            {
                if (item["Status"] == "True")
                {
                    pnl_food_lock.Controls.Add(new UnlockedFood(item["ComboID"], item["Name"], item["Price"], item["URLImage"], this, "Combo"));
                }
                if (item["Status"] == "False")
                {
                    pnl_food_lock.Controls.Add(new LockedFood(item["ComboID"], item["Name"], item["Price"], item["URLImage"], this, "Combo"));
                }
            }
            foreach (Dictionary<string, string> item in menuList)
            {
                if (item["Status"] == "1" && item["Initual"] == "0")
                {
                    pnl_food_lock.Controls.Add(new UnlockedFood(item["MenuID"], item["Name"], item["Price"], item["URLImage"], this));
                }
                if (item["Status"] == "0" && item["Initual"] == "0")
                {
                    pnl_food_lock.Controls.Add(new LockedFood(item["MenuID"], item["Name"], item["Price"], item["URLImage"], this));
                }
            }
        }
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("GUI.Language.MyResource", typeof(LockFood).Assembly);
            btn_UpdateFood.Text = rm.GetString("updateFoodText", culture);
            btn_AddComboFood.Text = rm.GetString("addComboText", culture);
            btn_LockFood.Text = rm.GetString("lockFoodText", culture);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
            btn_AddFood.Text = rm.GetString("addFoodText", culture);
            btn_Signout.Text = rm.GetString("signoutText", culture);
        }
        private void btn_AddFood_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFood form = new AddFood();
            form.ShowDialog();
            this.Close();
        }

        private void btn_AddComboFood_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddComboFood form = new AddComboFood();
            form.ShowDialog();
            this.Close();
        }

        private void btn_LockFood_Click(object sender, EventArgs e)
        {
            this.Hide();
            LockFood form = new LockFood();
            form.ShowDialog();
            this.Close();
        }
        private void LockFood_Load(object sender, EventArgs e)
        {
            UpdateMenu();
        }
        private void btn_UpdateFood_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateFood form = new UpdateFood();
            form.ShowDialog();
            this.Close();
        }

        private void btn_AddingFood_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAddingComboFood form = new AdminAddingComboFood();
            form.ShowDialog();
            this.Close();
        }
    }
}
