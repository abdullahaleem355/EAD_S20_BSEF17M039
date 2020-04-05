using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.Entities;

namespace UMS.DAL
{
    public static class UsersDAO
    {
        private static int DoesUserExist(String pLogin)
        {
            String sqlQuery = String.Format("select Count(*) from dbo.Users where Login='{0}';", pLogin);
            using (DBHelper helper = new DBHelper())
            {
                return (int) helper.ExecuteScalar(sqlQuery);
            }
        }

        public static int RegisterOrUpdateUser(UsersDTO dto)
        {
            String sqlQuery = "";
            String sqlDateTimeFormat = "yyyy-MM-dd hh:mm:ss";
            String sqlDateFormat = "yyyy-MM-dd";
            if (dto.UserID == 0) // insert
            {
                sqlQuery = String.Format("INSERT INTO dbo.Users(Name,Login,Password,Email,Gender,Address,Age,NIC,DOB,IsCricket,Hockey,Chess,ImageName,CreatedOn) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}')",
                            dto.Name, dto.Login, dto.Password, dto.Email,dto.Gender, dto.Address, dto.Age, dto.Nic, dto.Dob.ToString(sqlDateFormat), dto.IsCricket, dto.Hockey, dto.Chess, dto.ImageName, dto.CreatedOn.ToString(sqlDateTimeFormat));
            }
            else if (dto.UserID > 0)
            {
                sqlQuery = String.Format("Update dbo.Users Set Name='{0}', Login='{1}', Password='{2}',Email='{3}', Gender='{4}', Address='{5}', Age={6}, NIC='{7}', DOB='{8}', IsCricket='{9}', Hockey='{10}', Chess='{11}', ImageName='{12}' , CreatedOn = '{13}' where UserID='{14}'",
                                dto.Name, dto.Login, dto.Password,dto.Email, dto.Gender, dto.Address, dto.Age, dto.Nic, dto.Dob.ToString(sqlDateFormat), dto.IsCricket, dto.Hockey, dto.Chess, dto.ImageName, dto.CreatedOn.ToString(sqlDateTimeFormat), dto.UserID);
            }
            else
                return 0;
            using(DBHelper helper = new DBHelper())
            {
                return helper.ExecuteQuery(sqlQuery);
            }
        }

        public static Boolean ValidateUser(String pLogin, String pPassword)
        {
            if(DoesUserExist(pLogin) == 1)  // unique user exists
            {
                String sqlQuery = String.Format("Select Count(*) from dbo.Users where Login='{0}' AND Password='{1}';", pLogin, pPassword);
                using (DBHelper helper = new DBHelper())
                {
                    int count = (int) helper.ExecuteScalar(sqlQuery);
                    if (count == 1)
                        return true;
                }
            }
            return false;
        }

        public static int getUserIdViaEmail(String pEmail)
        {
            int userId = -1; // -1 shows it is unitialized by any userid.
            String sqlQuery = String.Format("Select UserID from dbo.Users where Email='{0}'", pEmail);
            using (DBHelper helper = new DBHelper())
            {
                SqlDataReader reader = helper.ExecuteReader(sqlQuery);
                if(reader.Read())
                {
                    userId = reader.GetInt32(reader.GetOrdinal("UserID"));
                }
                return userId;
            }
        }

        public static int updatePassword(int pUId, String pPassword)
        {
            String sqlQuery = String.Format("Update dbo.Users Set Password='{0}' where UserID='1'", pPassword, pUId);
            using (DBHelper helper = new DBHelper())
            {
                 return helper.ExecuteQuery(sqlQuery);
            }
        }

        public static UsersDTO GetUsersDTO(String pLogin, String pPassword)
        {
            UsersDTO dto = null;
            if(DoesUserExist(pLogin) == 1)
            {
                dto = new UsersDTO();
                String sqlQuery = String.Format("Select * from dbo.Users where Login='{0}' AND Password='{1}';", pLogin, pPassword);
                using (DBHelper helper = new DBHelper())
                {
                    SqlDataReader reader = helper.ExecuteReader(sqlQuery);
                    if (reader.Read())
                    {
                        dto.UserID = reader.GetInt32(reader.GetOrdinal("UserId"));
                        dto.Login = reader.GetString(reader.GetOrdinal("Login"));
                        dto.Name = reader.GetString(reader.GetOrdinal("Name"));
                        dto.Password = reader.GetString(reader.GetOrdinal("Password"));
                        dto.Email = reader.GetString(reader.GetOrdinal("Email"));
                        dto.Age = reader.GetInt32(reader.GetOrdinal("Age"));
                        dto.Address = reader.GetString(reader.GetOrdinal("Address"));
                        dto.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                        dto.Nic = reader.GetString(reader.GetOrdinal("NIC"));
                        dto.Dob = reader.GetDateTime(reader.GetOrdinal("DOB"));
                        dto.CreatedOn = reader.GetDateTime(reader.GetOrdinal("CreatedOn"));
                        dto.IsCricket = reader.GetBoolean(reader.GetOrdinal("IsCricket"));
                        dto.Chess = reader.GetBoolean(reader.GetOrdinal("Chess"));
                        dto.Hockey = reader.GetBoolean(reader.GetOrdinal("Hockey"));
                        dto.ImageName = reader.GetString(reader.GetOrdinal("ImageName"));
                    }
                }
            }
            return dto;
        }

        public static UsersDTO GetUsersDTOById(int userId)
        {
            UsersDTO dto = null;
            dto = new UsersDTO();
            String sqlQuery = String.Format("Select * from dbo.Users where UserID='{0}';", userId);
            using (DBHelper helper = new DBHelper())
            {
                SqlDataReader reader = helper.ExecuteReader(sqlQuery);
                if (reader.Read())
                {
                    dto.UserID = reader.GetInt32(reader.GetOrdinal("UserId"));
                    dto.Login = reader.GetString(reader.GetOrdinal("Login"));
                    dto.Name = reader.GetString(reader.GetOrdinal("Name"));
                    dto.Password = reader.GetString(reader.GetOrdinal("Password"));
                    dto.Email = reader.GetString(reader.GetOrdinal("Email"));
                    dto.Age = reader.GetInt32(reader.GetOrdinal("Age"));
                    dto.Address = reader.GetString(reader.GetOrdinal("Address"));
                    dto.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                    dto.Nic = reader.GetString(reader.GetOrdinal("NIC"));
                    dto.Dob = reader.GetDateTime(reader.GetOrdinal("DOB"));
                    dto.CreatedOn = reader.GetDateTime(reader.GetOrdinal("CreatedOn"));
                    dto.IsCricket = reader.GetBoolean(reader.GetOrdinal("IsCricket"));
                    dto.Chess = reader.GetBoolean(reader.GetOrdinal("Chess"));
                    dto.Hockey = reader.GetBoolean(reader.GetOrdinal("Hockey"));
                    dto.ImageName = reader.GetString(reader.GetOrdinal("ImageName"));
                }
            }
            return dto;
        }
    }
}
