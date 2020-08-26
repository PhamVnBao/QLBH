using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class LoginBUS
    {
        public bool loginValid(string userName, string passWord)
        {
            LoginDAO lg = new LoginDAO();
            if (userName == "" || passWord == "")
                return false;
            else
                return lg.loginValid(userName, passWord);
        }
    }
}
