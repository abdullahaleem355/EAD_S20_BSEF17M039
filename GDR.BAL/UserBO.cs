using GDR.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDR.BAL
{
    public class UserBO
    {
        public static int DoesUserExist(String pLogin)
        {
            return UserDAO.DoesUserExist(pLogin);
        }
        public static Boolean ValidateUser(String pLogin, String pPassword)
        {
            return UserDAO.ValidateUser(pLogin, pPassword);
        }

        public static int RegisterUser(String pLogin, String pName, String pPassword)
        {
            return UserDAO.RegisterUser(pLogin, pName, pPassword);
        }
    }
}
