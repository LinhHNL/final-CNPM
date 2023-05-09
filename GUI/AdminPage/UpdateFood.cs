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

namespace WinFormsApp2.AdminPage
{
    public partial class UpdateFood : MetroFramework.Forms.MetroForm
    {
        public UpdateFood()
        {
            InitializeComponent();
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


    }
}
