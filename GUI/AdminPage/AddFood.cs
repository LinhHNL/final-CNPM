using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Resources;
using System.Globalization;

namespace WinFormsApp2.AdminPage
{
    public partial class AddFood : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public AddFood()
        {
            InitializeComponent();
            culture = CultureInfo.CurrentCulture;
            SetLanguage("en-US");
        }

        private void AddFood_Load(object sender, EventArgs e)
        {

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

            BUS.Room Room = new BUS.Room();
            List<Dictionary<string, string>> RoomList = Room.gettingRoom();
            foreach (Dictionary<string, string> item in RoomList)
            {
                if (item.ContainsKey("Name"))
                {
                    string RoomName = item["Name"].ToString();
                    cb_RoomID.Items.Add(RoomName);
                }
            }
        }
        String imageLocation = "";
        String ImageURL = "";
        private void btn_addPicture_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    byte[] imageData = File.ReadAllBytes(imageLocation);
                    ImageURL = Convert.ToBase64String(imageData);
                    btn_addPicture.Visible = false;
                    btn_PictueLabel.Visible = false;
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
                    byte[] imageData = File.ReadAllBytes(imageLocation);
                    ImageURL = Convert.ToBase64String(imageData);
                    btn_addPicture.Visible = false;
                    btn_PictueLabel.Visible = false;
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
            String nameoffood = this.tb_NameOfFood.Texts.ToString();
            String price = this.tb_Price.Texts.ToString();
            String typeID = (this.cb_TypeofFood.SelectedIndex + 1).ToString();
            String RoomID = (this.cb_RoomID.SelectedIndex + 1).ToString();
            itemtoadd.Add("Name", nameoffood);
            itemtoadd.Add("Price", price);
            itemtoadd.Add("typeID", typeID);
            itemtoadd.Add("ImageURL", ImageURL);
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
        
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("GUI.Language.MyResource", typeof(AddFood).Assembly);
            btn_AddingFood.Text = rm.GetString("addText", culture);
            btn_UpdateFood.Text = rm.GetString("updateFoodText", culture);
            btn_AddComboFood.Text = rm.GetString("addComboText", culture);
            btn_PictueLabel.Text = rm.GetString("addImageText", culture);
            btn_LockFood.Text = rm.GetString("lockFoodText", culture);
            btn_Signout.Text = rm.GetString("signoutText", culture);
            tb_NameOfFood.PlaceholderText = rm.GetString("foodNameText", culture);
            tb_Price.PlaceholderText = rm.GetString("priceText", culture);
            cb_TypeofFood.Texts = rm.GetString("foodTypeText", culture);
            cb_RoomID.Texts = rm.GetString("undertakingRoomText", culture);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
            btn_AddFood.Text = rm.GetString("addFoodText",culture);
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
    }
}
