using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class Customer
    {
        private Dictionary<string, string> validateLoginFunc(String username, String password)
        {
            DAO.Customer customer = new DAO.Customer();
            return customer.loginCustomer(username, password);
        }
        public Dictionary<string, string> returnResultLogin(String username, String password)
        {
            if (validateDataLogin(username, password)["result"] != "1")
            {
                return validateDataLogin(username, password);
            }
            else
            {
                return validateLoginFunc(username, password);
            }
        }
        private Dictionary<string, string> validateDataLogin(String phone, String password)
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

            if (!isDigitsOnly(phone) || phone.Length != 10)
            {
                //lbl_errorMessage.Text = "Số điện thoại không hợp lệ";
                //tb_phone.Focus();
                result.Add("id", "-1");
                result.Add("result", "-3");
                return result;
            }
            result.Add("id", "-1");
            result.Add("result", "1");
            return result;
        }

        private bool isDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
       
        private Dictionary<string, string> validateDataRegister(String username, String password, String name, String email)
        {
            Regex rgEmail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", RegexOptions.IgnoreCase);
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (name.Equals(""))
            {
                //lbl_errorMessage.Text = "Vui lòng nhập họ và tên";
                //tb_name.Focus();
                result.Add("id", "-1");
                result.Add("result", "-1");
                return result;
            }

            if (email.Equals(""))
            {
                //lbl_errorMessage.Text = "Vui lòng nhập địa chỉ email";
                //tb_email.Focus();
                result.Add("id", "-1");
                result.Add("result", "-2");
                return result;
            }

            if (username.Equals(""))
            {
                //lbl_errorMessage.Text = "Vui lòng nhập số điện thoại";
                //tb_phone.Focus();
                result.Add("id", "-1");
                result.Add("result", "-3");
                return result;
            }

            if (password.Equals(""))
            {
                //lbl_errorMessage.Text = "Vui lòng nhập mật khẩu";
                //tb_password.Focus();
                result.Add("id", "-1");
                result.Add("result", "-4");
                return result;
            }

            if (!rgEmail.IsMatch(email))
            {
                //lbl_errorMessage.Text = "Email không hợp lệ";
                //tb_email.Focus();
                result.Add("id", "-1");
                result.Add("result", "-5");
                return result;
            }

            if (password.Length < 8)
            {
                //lbl_errorMessage.Text = "Vui lòng nhập mật khẩu có độ dài từ 8 kí tự";
                //tb_password.Focus();
                result.Add("id", "-1");
                result.Add("result", "-6");
                return result;
            }

            if (!isDigitsOnly(username))
            {
                //lbl_errorMessage.Text = "Số điện thoại không hợp lệ";
                //tb_phone.Focus();
                result.Add("id", "-1");
                result.Add("result", "-7");
                return result;
            }
            result.Add("id", "-1");
            result.Add("result", "1");
            return result;
        }
        private Dictionary<string, string> validateRegisterFunc(String username, String password, String name, String email)
        {
            DAO.Customer customer = new DAO.Customer();
            return customer.registerCustomer(username, password,name,email);
        }
        public Dictionary<string, string> returnResultRegister(String username, String password, String name, String email)
        {
            if (validateDataRegister(username, password, name, email)["result"] != "1")
            {
                return validateDataRegister(username, password, name, email);
            }
            else
            {
                return validateRegisterFunc(username, password, name, email);
            }
        }


    }
}
