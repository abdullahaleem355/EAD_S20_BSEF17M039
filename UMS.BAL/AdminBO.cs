using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.DAL;

namespace UMS.BAL
{
    public static class AdminBO
    {
        public static Boolean ValidateAdmin(String pLogin, String pPassword)
        {
            return AdminDAO.ValidateAdmin(pLogin, pPassword);
        }

        public static DataTable GetUsers()
        {
            return AdminDAO.GetUsers();
        }
    }
}
