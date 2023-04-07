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
        private Dictionary<string, string> ValidateLoginFunc(String username,String password)
        {
            TakingValidateProc takingValidateProc = new TakingValidateProc();   
            return takingValidateProc.TakingValidateProcFuncUsing(username,password);
        }
        public Dictionary<string, string> returnResultLogin(String username,String password)
        {
            if (ValidateLoginFunc(username, password)["result"]!="1")
            {
                return validateData(username, password);
            }
            else
            {
            return ValidateLoginFunc(username,password);
            }
        }
        private Dictionary<string, string> validateData(String phone, String password)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (phone.Equals(""))
            {
                //lbl_errorMessage.Text = "Vui lòng nhập số điện thoại";
                //tb_phone.Focus();
                result.Add("id", "-1");
                result.Add("result", "-1");
                return result;

            }

            if (password.Equals(""))
            {
                //lbl_errorMessage.Text = "Vui lòng nhập mật khẩu";
                //tb_password.Focus();
                result.Add("id", "-1");
                result.Add("result", "-2");
                return result;
            }

            if (!IsDigitsOnly(phone) || phone.Length != 10)
            {
                //lbl_errorMessage.Text = "Số điện thoại không hợp lệ";
                //tb_phone.Focus();
                result.Add("id", "-1");
                result.Add("result", "-3");
                return result;
            }
            return result;
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
