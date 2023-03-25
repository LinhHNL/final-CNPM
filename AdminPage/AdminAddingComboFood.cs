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
            flp_Hienthimonan.Controls.Clear();
            if(listdachon.Count > 0) {
            // MessageBox.Show(listdachon.Count().ToString());


                foreach (MonAnComponentForAdding i in listdachon)
                {
                        if (i.getTrangThai())
                        {
                            listdaxuly.Add(i);
                            flp_Hienthimonan.Controls.Add(new MonAnAddingInPanel(i.getTenMon(), i));
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
