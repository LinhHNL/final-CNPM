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

namespace WinFormsApp2.AdminPage
{
    public partial class LockFood : MetroFramework.Forms.MetroForm
    {

        public LockFood()
        {
            InitializeComponent();
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
                if (item["Status"] == "1" && item["Initual"]=="0")
                {
                    pnl_food_lock.Controls.Add(new UnlockedFood(item["MenuID"], item["Name"], item["Price"], item["URLImage"], this));
                }
                if (item["Status"] == "0" && item["Initual"] == "0")
                {
                    pnl_food_lock.Controls.Add(new LockedFood(item["MenuID"], item["Name"], item["Price"], item["URLImage"], this));
                }
            }
        }
        public void LockFood_Load(object sender, EventArgs e)
        {
            UpdateMenu();
        }


    }
}
