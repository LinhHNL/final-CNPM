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
    public partial class AddComboFood : MetroFramework.Forms.MetroForm
    {
        public AddComboFood()
        {
            InitializeComponent();
        }

        private void AddComboFood_Load(object sender, EventArgs e)
        {

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
                    byte[] imageData = File.ReadAllBytes(imageLocation);
                    ImageURL = Convert.ToBase64String(imageData);
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

        private void AddingComboFood_Click(object sender, EventArgs e)
        {
            String GiaCombo = this.tb_giacombo.Texts;
            String NameCombo = this.tb_nameofcombo.Texts;
            this.Hide();
            AdminAddingComboFood AdminAddingComboFood = new AdminAddingComboFood(NameCombo, GiaCombo, this.ImageURL);
            AdminAddingComboFood.ShowDialog();
            this.Close();
        }
        
    }
}
