using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.DAL;

namespace UMS.BAL
{
   public class EmailHandlerBO
    {
        public static Boolean SendEmail(String toEmailAddress, String subject, String body)
        {
            return EmailHandler.SendEmail(toEmailAddress, subject, body);
        }
    }
}
