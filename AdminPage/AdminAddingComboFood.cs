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

namespace WinFormsApp2.AdminPage
{
    public partial class AdminAddingComboFood : MetroFramework.Forms.MetroForm
    {
        public AdminAddingComboFood()
        {
            InitializeComponent();
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

        
    }
}
