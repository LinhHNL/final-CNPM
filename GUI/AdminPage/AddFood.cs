﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
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
            BUS.KindFood kindFood = new BUS.KindFood();
            List<Dictionary<string, string>> kindFoodList = kindFood.gettingKindFood();
            foreach (Dictionary<string, string> item in kindFoodList)
            {
                if (item.ContainsKey("Name"))
                {
                    string name = item["Name"].ToString();
                    cb_TypeofFood.Items.Add(name);
                }
            }
        }
        String imageLocation = "";
        private void btn_addPicture_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    btn_addPicture.Visible = false;
                    btn_placeholderlabel.Visible = false;
                    UploadPlaceBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bị lỗi update hình");
            }
        }

        private void UploadPlaceBox_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    btn_addPicture.Visible = false;
                    btn_placeholderlabel.Visible = false;
                    UploadPlaceBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bị lỗi update hình");
            }
        }

        private void btn_addingMenu_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> itemtoadd = new Dictionary<string, string>();
            String nameoffood = this.tb_NameOfFood.ToString();
            int price = int.Parse(this.tb_Price.ToString());
            String typeID = cb_TypeofFood.SelectedIndex.ToString();
            String RoomID = cb_RoomID.SelectedIndex.ToString();
            itemtoadd.Add("Name", nameoffood);
            itemtoadd.Add("Price", price.ToString());
            itemtoadd.Add("typeID", typeID);
            itemtoadd.Add("URLImage", imageLocation);
            itemtoadd.Add("RoomID", RoomID);
            BUS.Menu Menu = new BUS.Menu();
            if (Menu.addMenu(itemtoadd))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
