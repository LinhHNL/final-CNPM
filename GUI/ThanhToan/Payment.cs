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
using WinFormsApp2;
using BUS;
using System.Resources;
using System.Globalization;

namespace GUI.ThanhToan
{
    public partial class Payment : MetroForm
    {
        CultureInfo culture;
        private List<Dictionary<String, String>> ListContainAllDetail;
        private int Price = 0;
        public Payment(List<Dictionary<String, String>> ListContainAllDetail,int Price)
        {
            this.ListContainAllDetail = ListContainAllDetail;
            this.Price = Price;
            InitializeComponent();
            culture = CultureInfo.CurrentCulture;
            SetLanguage("en-US");
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
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
             ResourceManager("GUI.Language.MyResource", typeof(HoaDonTong).Assembly);
            lbl_paymentDetail.Text = rm.GetString("paymentDetailText", culture);
            lbl_idbill.Text = rm.GetString("billIDText", culture);
            lbl_totalMoney.Text = rm.GetString("totalText", culture);
            lbl_datePayment.Text = rm.GetString("paymentDateText",culture);
            lbl_offer.Text = rm.GetString("offerText", culture);
            cb_offerID.Texts = rm.GetString("offerIDText", culture);
            lbl_paymentMethod.Text = rm.GetString("paymentMethodText", culture);
            cb_paymentMethod.Texts = rm.GetString("paymentMethodText", culture);
            btn_pay.Text = rm.GetString("payText", culture);
        }
    }
}
