using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Components;
using BUS;
using System.Resources;
using System.Globalization;

namespace WinFormsApp2.AdminPage
{
    public partial class AdminAddingComboFood : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;

        public AdminAddingComboFood()
        {
            InitializeComponent();
            culture = CultureInfo.CurrentCulture;
            SetLanguage("vi-VN");
        }
        public void HienThiMonAn()
        {
            List<MonAnComponentForAdding> listdachon = StoringMonAnComponentForAdding.StoringMonAnAdding;
            List<MonAnComponentForAdding> listdaxuly = new List<MonAnComponentForAdding>();
            List<MonAnAddingInPanel> listdaxulypanel = new List<MonAnAddingInPanel>();
            flp_Hienthimonan.Controls.Clear();
            if(listdachon.Count > 0) {
            // MessageBox.Show(listdachon.Count().ToString());


                foreach (MonAnComponentForAdding i in listdachon)
                {
                    foreach(MonAnAddingInPanel j in StoringMonAnPanel.StoringMonAnPanelList)
                    {
                        if (i.getTrangThai())
                        {
                            listdaxuly.Add(i);

                            if (i.getTenMon().Equals(j.getTen()) && listdaxulypanel.Find(x => x.getTen().Equals(j.getTen()))==null)
                            {
                                flp_Hienthimonan.Controls.Add(j);
                                continue;
                            }
                        }
                    }
                       
                }
            }
        }
        private void AdminAddingComboFood_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = LAPTOP-VERULPGO\\SQLEXPRESS; Initial Catalog = hadilao; Integrated Security = True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select ten, giaban from monan", conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {

                    panel_monan_1.Controls.Add(new Components.MonAnComponentForAdding(reader["ten"].ToString()));
                    
                }

                panel_monan_1.Controls.Add(new Components.MonAnComponentForAdding("PrettyU",this));
                panel_monan_1.Controls.Add(new Components.MonAnComponentForAdding("Aju Nice",this));
                panel_monan_1.Controls.Add(new Components.MonAnComponentForAdding("Home", this));
                panel_monan_1.Controls.Add(new Components.MonAnComponentForAdding("Don't Wanna Cry", this));
            }
        }

        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("GUI.Language.MyResource", typeof(AdminAddingComboFood).Assembly);
            
            btn_UpdateFood.Text = rm.GetString("updateFoodText", culture);
            btn_AddComboFood.Text = rm.GetString("addComboText", culture);
            btn_LockFood.Text = rm.GetString("lockFoodText", culture);
            btn_Signout.Text = rm.GetString("signoutText", culture);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
            btn_AddingFood.Text = rm.GetString("addText", culture);
            btn_AddFood.Text = rm.GetString("addFoodText", culture);
            lbl_Food.Text = rm.GetString("dishText",culture);
            lbl_deleteAll.Text = rm.GetString("deleteAllText",culture);
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
