using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TempBill
    {
        public bool tryingInsertTempBillDetail(Dictionary<string, string> TempBillInfo)
        {
            DAO.TempBill tempBill = new DAO.TempBill();
            return tempBill.tryingInsertTempBillDetail(TempBillInfo);
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
