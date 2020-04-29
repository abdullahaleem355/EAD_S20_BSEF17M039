using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDR.DAL
{
    public static class UserDAO
    {
        public static int DoesUserExist(String pLogin)
        {
            String sqlQuery = String.Format("Select Count(*) from dbo.Users where Login='{0}'", pLogin);
            using (DBHelper helper = new DBHelper())
            {
                return (int)helper.ExecuteScalar(sqlQuery);
            }
        }

        public static UserDTO ValidateUser(String pLogin, String pPassword)
        {
            UserDTO dto = null;
            if (DoesUserExist(pLogin) == 1)  // unique user exists
            {
                String sqlQuery = String.Format("Select Login, Password from dbo.Users where Login='{0}' AND Password='{1}'", pLogin, pPassword);
                using (DBHelper helper = new DBHelper())
                {
                    
                    SqlDataReader reader = helper.ExecuteReader(sqlQuery);
                    if(reader.Read())
                    {
                        dto = new UserDTO();
                        dto.Login = reader.GetString(reader.GetOrdinal("Login"));
                        dto.Password = reader.GetString(reader.GetOrdinal("Password"));
                    }
                }
            }
            return dto;
        }

        public static int RegisterUser(String pLogin, String pName, String pPassword)
        {
            String sqlQuery = String.Format("INSERT INTO dbo.Users(Name, Login, Password) VALUES ('{0}', '{1}', '{2}')", pName, pLogin, pPassword);
            using (DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }
    }
}
