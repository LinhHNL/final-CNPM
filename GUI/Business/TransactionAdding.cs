using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Components;
using WinFormsApp2.DataAccess;

namespace WinFormsApp2.Business
{
    internal class TransactionAdding
    {
        public void TransactionAddedFunc()
        {
            int price = 0;
            int tmpprice = 0;
            int year=DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            String DaytoAdd=year+"/"+month+"/"+day;
            foreach (MonAnComponent i in StoringMonAnComponentShoppingCart.StoringMonAnComponentShoppingCartList)
            {
                tmpprice = Int32.Parse(i.getGiaMon()) * i.getSoLuong();
                price += tmpprice;
            }
            float pricestoring = (float)price;
            int customerID = StoringCustomerID.CustomerID;
            if (customerID == -64)
            {
                return;
            }
            else
            {
                AddTransaction addTransaction = new AddTransaction();
                addTransaction.TryingAddTransactionFunc(pricestoring, DaytoAdd, customerID);
            }
        }
    }
}
