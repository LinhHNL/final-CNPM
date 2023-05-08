using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.ThanhToan
{
    public partial class Payment : MetroForm
    {
        List<Dictionary<String, String>> ListContainAllDetail = new List<Dictionary<String, String>>();
        int Price = 0;
        public Payment(List<Dictionary<String, String>> ListContainAllDetail,int Price)
        {
            this.ListContainAllDetail= ListContainAllDetail;
            this.Price = Price;
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("yyyy-MM-dd");
            lbl_billidvalue.Text = BUS.SessionStorage.TempBillID;
            lbl_DatePaymentValue.Text = formattedDate;
            lbl_TotalMoneyValue.Text = Price.ToString();
        }
    }
}
