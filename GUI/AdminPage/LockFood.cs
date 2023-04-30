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
            foreach (Dictionary<string, string> item in menuList)
            {
                if (item["Status"] == "1")
                {
                    pnl_food_lock.Controls.Add(new UnlockedFood(item["MenuID"], item["Name"], item["Price"], item["URLImage"], this));
                }
                if (item["Status"] == "0")
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
