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
using WinFormsApp2.Components;
using WinFormsApp2;

namespace GUI.ThanhToan
{
    public partial class Payment : MetroForm
    {
        List<Dictionary<String, String>> ListContainAllDetail = new List<Dictionary<String, String>>();
        int Price = 0;
        public Payment(List<Dictionary<String, String>> ListContainAllDetail, int Price)
        {
            this.ListContainAllDetail = ListContainAllDetail;
            this.Price = Price;
            InitializeComponent();
        }
        private string ChangeGia(String gia)
        {
            int price = 0;
            price = Int32.Parse(gia);
            string pricestr = price.ToString();
            string changestr = "";
            for (int i = pricestr.Length - 3; i > 0; i -= 3)
            {
                changestr = pricestr.Insert(i, ".");
                pricestr = changestr;
            }
            return pricestr + " ₫";
        }
        private void Payment_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string formattedDateDisplay = currentDate.ToString("dd-MM-yyyy");
            lbl_billidvalue.Text = BUS.SessionStorage.TempBillID;
            lbl_DatePaymentValue.Text = formattedDateDisplay;
            lbl_TotalMoneyValue.Text = ChangeGia(Price.ToString());
        }

        private void btn_InsertTransaction_Click(object sender, EventArgs e)
        {
            BUS.Transaction transaction=new BUS.Transaction();
            Dictionary<String, String> TransactionInfo = new Dictionary<String, String>();
            Dictionary<String, String> IDInfo = new Dictionary<String, String>();
            TransactionInfo.Add("Price",this.Price.ToString());
            IDInfo = transaction.tryingInsertTransaction(TransactionInfo);
            String TransactionID= IDInfo["TransactionID"];
            if (TransactionID != "-1")
            {
                foreach (Dictionary<String, String> item in ListContainAllDetail)
                {
                    if (item["MenuID"] != "-1")
                    {
                        Dictionary<String, String> TransactionDetailInfo = new Dictionary<String, String>();
                        TransactionDetailInfo.Add("TransactionID", TransactionID);
                        TransactionDetailInfo.Add("MenuID", item["MenuID"]);
                        TransactionDetailInfo.Add("Number", item["NumberOfFood"]);
                        TransactionDetailInfo.Add("Price", item["Price"]);
                        transaction.tryingInsertTransactionDetail(TransactionDetailInfo);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                        return;
                    }
                }
                this.Hide();
                SignInForm signInForm = new SignInForm();
                signInForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
