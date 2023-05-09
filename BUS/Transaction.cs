using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Transaction
    {
        public bool tryingInsertTransactionDetail(Dictionary<string, string> TransactionInfo)
        {
            DAO.Transaction transaction = new DAO.Transaction();
            return transaction.tryingInsertTransactionDetail(TransactionInfo);
        }
        public Dictionary<string, string> tryingInsertTransaction(Dictionary<string, string> TransactionInfo)
        {
            TransactionInfo.Add("CustomerID", SessionStorage.CustomerIDInUse);
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("yyyy-MM-dd");
            TransactionInfo.Add("Date", formattedDate);
            DAO.Transaction transaction = new DAO.Transaction();
            return transaction.tryingInsertTransaction(TransactionInfo);
        }
        }
}
