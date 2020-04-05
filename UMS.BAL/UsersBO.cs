using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.DAL;
using UMS.Entities;

namespace UMS.BAL
{
    public static class UsersBO
    {
        public static Boolean ValidateUser(String pLogin, String pPassword)
        {
            return UsersDAO.ValidateUser(pLogin, pPassword);
        }

        public static int RegisterOrUpdateUser(UsersDTO dto)
        {
            return UsersDAO.RegisterOrUpdateUser(dto);
        }

        public static UsersDTO GetUsersDTO(String pLogin, String pPassword)
        {
            return UsersDAO.GetUsersDTO(pLogin, pPassword);
        }
        

        public static UsersDTO GetUserDTOById(int userId)
        {
            return UsersDAO.GetUsersDTOById(userId);
        }

        public static int UpdatePassword(int pUId, String pPassword)
        {
            return UsersDAO.updatePassword(pUId, pPassword);
        }

        public static int GetUserIdViaEmail(String pEmail)
        {
            return UsersDAO.getUserIdViaEmail(pEmail);
        }
    }
}
