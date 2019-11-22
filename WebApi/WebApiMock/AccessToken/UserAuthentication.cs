using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiMock
{
    public class UserAuthentication
    {
        public static bool Login(string login, string pass)
        {
            //Set here the login rules
            return true;
        }
    }
}