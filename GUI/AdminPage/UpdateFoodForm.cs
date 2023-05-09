using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using GUI.AdminPage;

namespace WinFormsApp2.AdminPage
{
    public partial class UpdateFoodForm : MetroFramework.Forms.MetroForm
    {
        private String UpdateFoodID = "0";
        Dictionary<string, string> MenuItem;
        CultureInfo culture;
        public UpdateFoodForm(String UpdateFoodID)
        {
            InitializeComponent();
            this.UpdateFoodID = UpdateFoodID;
            culture = CultureInfo.CurrentCulture;
            SetLanguage("en-US");
        }
        public static Image Base64ToImage(string base64String)
        {
            // Convert the Base64 string to a byte array
            var bytes = Convert.FromBase64String(base64String);
            // Create a MemoryStream from the byte array
            using (var ms = new MemoryStream(bytes))
            {
                // Create an Image from the MemoryStream
                var image = Image.FromStream(ms);
                return image;
            }
        }
        private void UpdateFoodForm_Load(object sender, EventArgs e)
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
                    //cb_RoomID.Items.Add(RoomName);

                }
            }
            BUS.Menu menu = new BUS.Menu();
            MenuItem = menu.getMonAnByID(UpdateFoodID);
            this.tb_NameOfFood.Texts = MenuItem["Name"];
            this.tb_Price.Texts = MenuItem["Price"];
            this.cb_TypeofFood.SelectedIndex = int.Parse(MenuItem["KindFoodID"]);
            //this.cb_RoomID.SelectedIndex = int.Parse(MenuItem["RoomID"]);
            this.UploadPlaceBox.Image = Base64ToImage(MenuItem["URLImage"]);
            ImageURL = MenuItem["URLImage"];
            btn_addPicture.Visible = false;

            btn_PictueLabel.Visible = false;
        }
        String ImageURL = "";
        private void btn_addPicture_Click(object sender, EventArgs e)
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

        private void btn_UpdateFood_Click(object sender, EventArgs e)
        {
            if (tb_NameOfFood.Texts.ToString() != "")
            {
                MenuItem["Name"] = tb_NameOfFood.Texts.ToString();
            }
            if (tb_Price.Texts.ToString() != "")
            {
                MenuItem["Price"] = tb_Price.Texts.ToString();
            }
            if (this.cb_TypeofFood.SelectedItem != null)
            {
                MenuItem["KindFoodID"] = (this.cb_TypeofFood.SelectedIndex + 1).ToString();
            }
            //if (this.cb_RoomID.SelectedItem != null)
            {
                //MenuItem["RoomID"] = (this.cb_RoomID.SelectedIndex + 1).ToString();
            }
            MenuItem["URLImage"] = ImageURL.ToString();
            BUS.Menu menu = new BUS.Menu();
            if (menu.changeMenu(MenuItem))
            {
                MessageBox.Show("Cập nhật thành công");
                this.Hide();
                UpdateFood UpdateFood = new UpdateFood();
                UpdateFood.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("GUI.Language.MyResource", typeof(AddFood).Assembly);
            btn_UpdateFood.Text = rm.GetString("updateFoodText", culture);
            btn_AddComboFood.Text = rm.GetString("addComboText", culture);
            btn_PictueLabel.Text = rm.GetString("addImageText", culture);
            btn_LockFood.Text = rm.GetString("lockFoodText", culture);
            btn_Signout.Text = rm.GetString("signoutText", culture);
            tb_NameOfFood.PlaceholderText = rm.GetString("foodNameText", culture);
            tb_Price.PlaceholderText = rm.GetString("priceText", culture);
            cb_TypeofFood.Texts = rm.GetString("foodTypeText", culture);
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
            btn_AddFood.Text = rm.GetString("addFoodText", culture);
            btn_ChooseDish.Text = rm.GetString("chooseDishText", culture);
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



        private void btn_AddingFood_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAddingComboFood form = new AdminAddingComboFood();
            form.ShowDialog();
            this.Close();
        }
    }
}
