using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.Entities;

namespace UMS.DAL
{
   public static class AdminDAO
    {
        private static int DoesAdminExist(String pLogin)
        {
            String sqlQuery = String.Format("select Count(*) from dbo.Admin where Login='{0}';", pLogin);
            using (DBHelper helper = new DBHelper())
            {
                return (int)helper.ExecuteScalar(sqlQuery);
            }
        }
        public static Boolean ValidateAdmin(String pLogin, String pPassword)
        {
            if (DoesAdminExist(pLogin) > 0)
            {
                String sqlQuery = String.Format("Select Count(*) from dbo.Admin where Login='{0}' AND Password='{1}';", pLogin, pPassword);
                using (DBHelper helper = new DBHelper())
                {
                    int count = (int)helper.ExecuteScalar(sqlQuery);
                    if (count == 1)
                        return true;
                }
            }
            return false;
        }

        public static DataTable GetUsers()
        {
            String sqlQuery = String.Format("Select UserID,Name,Login,Address,Age From dbo.Users");
            using (DBHelper helper = new DBHelper())
            {
                SqlDataReader reader = helper.ExecuteReader(sqlQuery);
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }
    }
}
