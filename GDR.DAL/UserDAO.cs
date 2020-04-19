using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDR.DAL
{
    public class UserDAO
    {
        public static int DoesUserExist(String pLogin)
        {
            String sqlQuery = String.Format("Select Count(*) from user where Login='{0}'", pLogin);
            using (DBHelper helper = new DBHelper())
            {
                Object result = helper.ExecuteScalar(sqlQuery);
                result = (result == DBNull.Value) ? null : result;
                int count = Convert.ToInt32(result);
                return count;
            }
        }

        public static Boolean ValidateUser(String pLogin, String pPassword)
        {
            if (DoesUserExist(pLogin) == 1)  // unique user exists
            {
                String sqlQuery = String.Format("Select Count(*) from user where Login='{0}' AND Password='{1}'", pLogin, pPassword);
                using (DBHelper helper = new DBHelper())
                {
                    Object result = helper.ExecuteScalar(sqlQuery);
                    result = (result == DBNull.Value) ? null : result;
                    int count = Convert.ToInt32(result);
                    if (count == 1)
                        return true;
                }
            }
            return false;
        }

        public static int RegisterUser(String pLogin, String pName, String pPassword)
        {
            String sqlQuery = String.Format("INSERT INTO user(Name, Login, Password) VALUES ('{0}', '{1}', '{2}')", pName, pLogin, pPassword);
            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }
    }
}
