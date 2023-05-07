using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace WinFormsApp2.AdminPage
{
    public partial class AddComboFood : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture;
        public AddComboFood()
        {
            InitializeComponent();
            culture = CultureInfo.CurrentCulture;
            SetLanguage("vi-VN");
        }

        private void AddComboFood_Load(object sender, EventArgs e)
        {
            cb_TypeofFood.Items.Add("Loại món ăn");
            cb_TypeofFood.SelectedIndex = 0;
        }

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

        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void tb_nameoffood__TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_gia__TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_TypeofFood_OnSelectedIndexChanged(object sender, EventArgs e)
        {

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
            lbl_AccountName.Text = rm.GetString("accountNameText", culture);
            btn_AddFood.Text = rm.GetString("addFoodText", culture);
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
