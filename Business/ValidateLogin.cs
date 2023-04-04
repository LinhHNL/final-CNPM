using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.DataAccess;

namespace WinFormsApp2.Business
{
    internal class ValidateLogin
    {
        private int ValidateLoginFunc(String username,String password)
        {
            TakingValidateProc takingValidateProc = new TakingValidateProc();   
            return takingValidateProc.TakingValidateProcFuncUsing(username,password);
        }
        public int returnResultLogin(String username,String password)
        {
            return ValidateLoginFunc(username,password);
        }
    }
}
