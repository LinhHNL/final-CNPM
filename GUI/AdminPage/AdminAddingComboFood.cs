using GUI.Components;
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
        private String TenCombo;
        private String GiaCombo;
        private String ImageURL;
        public AdminAddingComboFood()
        {
            InitializeComponent();
        }
        public AdminAddingComboFood(String TenCombo, String GiaCombo, String ImageURL)
        {
            this.TenCombo = TenCombo;
            this.GiaCombo = GiaCombo;
            this.ImageURL = ImageURL;
            InitializeComponent();
        }
        public void HienThiMonAn()
        {
            List<MonAnComponentForAdding> listdachon = StoringMonAnComponentForAdding.StoringMonAnAdding;
            List<MonAnComponentForAdding> listdaxuly = new List<MonAnComponentForAdding>();
            List<MonAnAddingInPanel> listdaxulypanel = new List<MonAnAddingInPanel>();
            flp_Hienthimonan.Controls.Clear();
            if (listdachon.Count > 0)
            {
                // MessageBox.Show(listdachon.Count().ToString());


                foreach (MonAnComponentForAdding i in listdachon)
                {
                    foreach (MonAnAddingInPanel j in StoringMonAnPanel.StoringMonAnPanelList)
                    {
                        if (i.getTrangThai())
                        {
                            listdaxuly.Add(i);

                            if (i.getTenMon().Equals(j.getTen()) && listdaxulypanel.Find(x => x.getTen().Equals(j.getTen())) == null)
                            {
                                flp_Hienthimonan.Controls.Add(j);
                                continue;
                            }
                        }
                    }

                }
            }
        }
        public void UpdateFood()
        {
            panel_monan_1.Controls.Clear();
            BUS.Menu menu = new BUS.Menu();
            List<Dictionary<string, string>> menuList = menu.getAllMenu();
            foreach (Dictionary<string, string> item in menuList)
            {
                if (item["Status"] == "1")
                {
                    panel_monan_1.Controls.Add(new MonAnComponentForAdding(item["MenuID"], item["Name"], item["URLImage"], this));
                }
            }
        }
        private void AdminAddingComboFood_Load(object sender, EventArgs e)
        {
            UpdateFood();
        }

        private void btn_addbtn_Click(object sender, EventArgs e)
        {
            String IdMenu = "";
            String SoLuongMon = "";
            BUS.Combo combo= new BUS.Combo();
            Dictionary<string, string> ComboInfo = new Dictionary<string, string>();
            Dictionary<string, string> ComboDetailInfo = new Dictionary<string, string>();
            ComboInfo.Add("Name", TenCombo);
            ComboInfo.Add("Cost", GiaCombo);
            ComboInfo.Add("ImageURL", ImageURL);
            if (combo.tryingAddingCombo(ComboInfo)) 
            {
                String IDCombo = combo.getLastIDCombo()["ComboID"];
                foreach (MonAnComponentForAdding element in panel_monan_1.Controls.OfType<MonAnComponentForAdding>())
                {
                    if (element.getSoLuong() == 0)
                    {
                        continue;
                    }
                    ComboDetailInfo.Clear();
                    IdMenu = element.getIDMon();
                    SoLuongMon = element.getSoLuong().ToString();
                    ComboDetailInfo.Add("MenuID", IdMenu);
                    ComboDetailInfo.Add("ComboID", IDCombo);
                    ComboDetailInfo.Add("NumberOfFood", SoLuongMon);
                    if(!combo.tryingAddingComboDetail(ComboDetailInfo))
                    {
                        MessageBox.Show("Thêm thất bại");
                        break;
                    }
                }
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
