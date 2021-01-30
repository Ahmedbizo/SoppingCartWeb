using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Common.Helpers
{
    public class EmailHelper
    {
        public static void SendRegistrationEmail(string strToMail, string cc, string bcc, string strSubject, string strbody)
        {

            string userName = "<you'r user name>";
            string password = "<you'r password>";
            string smtpHost = "smtp.gmail.com";
            string port = "25";
            string fromEmail = "admin@myShoppingCart.com";

            //Create the msg object to be sent
            MailMessage msg = new MailMessage();
            //Add your email address to the recipients
            msg.To.Add(strToMail);
            msg.CC.Add("<CC email address>");
            //Configure the address we are sending the mail from
            MailAddress address = new MailAddress(fromEmail);
            msg.From = address;
            msg.Subject = strSubject;
            msg.Body = strbody;

            //Configure an SmtpClient to send the mail.            
            SmtpClient client = new SmtpClient();
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = false;
            client.Host = "smtpout.asia.secureserver.net";// smtpHost ;//"relay -hosting.secureserver.net";
            client.Port = 3535;

            //Setup credentials to login to our sender email address ("UserName", "Password")
            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(userName, password);
            client.UseDefaultCredentials = true;
            client.Credentials = credentials;

            //Send the msg
            client.Send(msg);




        }

    }
}
