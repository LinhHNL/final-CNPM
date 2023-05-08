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
        public Dictionary<string, string> getTempBillByIDAndToken() {
            DAO.TempBill tempBill=new DAO.TempBill();
            Dictionary<string, string> TempBillInfo= new Dictionary<string, string>();
            TempBillInfo.Add("CustomerID", SessionStorage.CustomerIDInUse);
            TempBillInfo.Add("Token", SessionStorage.TokenStorage);
            return tempBill.getTempBillByIDAndToken(TempBillInfo);
        }
        public List<Dictionary<string, string>> getAllTempBillDetailsOfTempBill(string tempBillId)
        {
            DAO.TempBill tempBill = new DAO.TempBill();
            return tempBill.getAllTempBillDetailsOfTempBill(tempBillId);
        }
        public bool tryingChangeStatus(Dictionary<string, string> StatusInfo)
        {
            DAO.TempBill tempBill = new DAO.TempBill();
            StatusInfo.Add("BillID",SessionStorage.TempBillID);
            return tempBill.tryingChangeStatus(StatusInfo);
        }
    }
}
