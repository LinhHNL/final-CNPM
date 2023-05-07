using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TempBill
    {
        public bool tryingInsertTempBillDetail(Dictionary<string, string> TempBillDetailInfo)
        {
            DAO.TempBill tempBill = new DAO.TempBill();
            TempBillDetailInfo.Add("TempBillId", SessionStorage.TempBillID);
            return tempBill.tryingInsertTempBillDetail(TempBillDetailInfo);
        }
        public Dictionary<string, string> tryingInsertTempBill(Dictionary<string, string> TempBillInfo)
        {
            TokenGenerate tokenGenerate = new TokenGenerate();
            String TokenID = tokenGenerate.getTokenID();
            TempBillInfo.Add("CustomerID", SessionStorage.CustomerIDInUse);
            TempBillInfo.Add("Token", TokenID);
            SessionStorage.TokenStorage=TokenID;
            DAO.TempBill tempBill = new DAO.TempBill();
            return tempBill.tryingInsertTempBill(TempBillInfo);
        }
        public List<Dictionary<string, string>> getTempBillNotDone()
        {
            DAO.TempBill tempBill = new DAO.TempBill();
            return tempBill.getTempBillNotDone();
        }
        public List<Dictionary<string, string>> GetAllTempBillDetailsOfTempBill(string tempBillId)
        {
            DAO.TempBill tempBill = new DAO.TempBill();
            return tempBill.GetAllTempBillDetailsOfTempBill(tempBillId);
        }
        public bool tryingChangeStatus(Dictionary<string, string> StatusInfo)
        {
            DAO.TempBill tempBill = new DAO.TempBill();
            return tempBill.tryingChangeStatus(StatusInfo);
        }
    }
}
