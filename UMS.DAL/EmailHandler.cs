using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace UMS.DAL
{
    public class EmailHandler
    {
        public static Boolean SendEmail(String toEmailAddress, String subject, String body)
        {
            try
            {
                String fromDisplayEmail = "EAD.SEMorning@gmail.com";
                String fromPassword = "SEMorning2017";

                String fromDisplayName = "UMS Admin";

                MailAddress fromAddress = new MailAddress(fromDisplayEmail, fromDisplayName);
                MailAddress toAddress = new MailAddress(toEmailAddress);

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }  
    }
}
