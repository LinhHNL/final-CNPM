using GUI.Components;
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

namespace WinFormsApp2.AdminPage
{
    public partial class UpdateFood : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public UpdateFood()
        {
            InitializeComponent();
            culture = CultureInfo.CurrentCulture;
            SetLanguage("vi-VN");
        }

        private void UpdateFood_Load(object sender, EventArgs e)
        {
            
            flp_food_update.Controls.Clear();
            BUS.Menu menu = new BUS.Menu();
            List<Dictionary<string, string>> menuList = menu.getAllMenu();
            foreach (Dictionary<string, string> item in menuList)
            {
                if (item["Status"] == "1")
                {
                    flp_food_update.Controls.Add(new UpdateFoodCom(item["MenuID"], item["Name"], item["Price"], item["URLImage"], this));
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
            lbl_Price.Text = rm.GetString("priceText", culture);
            lbl_FoodName.Text = rm.GetString("foodNameText", culture);
            btn_Signout.Text = rm.GetString("signoutText", culture);
            btn_Update.Text = rm.GetString("updateText", culture);
            btn_Delete.Text = rm.GetString("deleteText", culture);
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
