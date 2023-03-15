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
    public partial class AddFood : MetroFramework.Forms.MetroForm
    {
        public AddFood()
        {
            InitializeComponent();
        }

        private void AddFood_Load(object sender, EventArgs e)
        {
            cb_TypeofFood.Items.Add("Loại món ăn");
            cb_TypeofFood.SelectedIndex = 0;
        }
    }
}
