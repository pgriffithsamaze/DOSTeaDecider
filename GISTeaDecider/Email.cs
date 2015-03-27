using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace GISTeaDecider
{
    class Email
    {

        public bool sendEmail(string emailAddress, string name)
        {
            bool isSuccess = false;

            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.co");
                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(
                  "gisteadecider@gmail.com", "eAmazed14!");
                MailMessage msg = new MailMessage();
                msg.To.Add(emailAddress);
                msg.IsBodyHtml = true;
                msg.From = new MailAddress("GIS@TeaDecider.com");
                msg.Subject = "Attention! Your on Tea Duty";
                msg.Body = "Hello " + name + "," + " <br /> <br /> I hate to be the bearer of bad news but the <u>GIS Tea decider</u> has picked you to make the team a brew! <br /> <br /><b>HERE'S THE BREW LIST</b> <br/> <br/> <strong>Paul Griffiths</strong> - Coffee, Green Milk (Normal), 1 Sugars <br/><strong>James Wright</strong> - Coffee, Red Milk (1/3 milk), 1 Sugar (Heaped) <br/><strong>James Wilkinson</strong> - Coffee, Green Milk (Normal), 2 Sugars <br/><strong>Paul Knight</strong> - Tea, Green Milk (small amount), No Sugars <br/><strong>Alessandro Scolozzi</strong> - Espresso out the machine (number 64) <br/> <strong>Dan Goodwin</strong> - Coffee, Green Milk (Normal), 1 Sugars <br/><strong>Charnelle</strong> - Decafe Tea, Red Milk (Normal), 0 Sugars <br/><strong>Amanda Follit</strong> - Tea, Green Milk (Normal), 0 Sugars <br/><strong>Tom Bodington</strong> - Tea, Green Milk (small amount), 1 1/2 Sugars <br/> <br/> GET YOUR ARSE TO THE KITCHEN!!!!";
                client.Send(msg);
                //if the email is successfull thaen set the isSuccess variable to true
                isSuccess = true;
            }
            catch (Exception ex)
            {
                //sending the email failed so the isSuccess variable remains false
            }

            return isSuccess;
        }

        public bool sendWildcardEmail(string emailAddress, string name)
        {
            bool isSuccess = false;

            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.co");
                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(
                  "gisteadecider@gmail.com", "eAmazed14!");
                MailMessage msg = new MailMessage();
                msg.To.Add(emailAddress);
                msg.IsBodyHtml = true;
                msg.From = new MailAddress("GIS@TeaDecider.com");
                msg.Subject = "Attention! The Power is in your hands";
                msg.Body = "Hello " + name + "," + " <br /> <br /> The power is now in your hands the <u>GIS Tea decider</u> has picked your wildcard number so you now get to choose who makes the team a brew! Just forward the brew list over to the person that you choose to do your dirty work and await your service<br /> <br /><b>HERE'S THE BREW LIST</b> <br/> <br/> <strong>Paul Griffiths</strong> - Coffee, Green Milk (Normal), 1 Sugars <br/><strong>James Wright</strong> - Coffee, Red Milk (1/3 milk), 1 Sugar (Heaped) <br/><strong>James Wilkinson</strong> - Coffee, Green Milk (Normal), 2 Sugars <br/><strong>Paul Knight</strong> - Tea, Green Milk (small amount), No Sugars <br/><strong>Alessandro Scolozzi</strong> - Espresso out the machine (number 64) <br/> <strong>Dan Goodwin</strong> - Coffee, Green Milk (Normal), 1 Sugars <br/><strong>Charnelle</strong> - Decafe Tea, Red Milk (Normal), 0 Sugars <br/><strong>Amanda Follit</strong> - Tea, Green Milk (Normal), 0 Sugars <br/><strong>Tom Bodington</strong> - Tea, Green Milk (small amount), 1 1/2 Sugars <br/> <br/> GET YOUR ARSE TO THE KITCHEN!!!!";
                client.Send(msg);
                //if the email is successfull thaen set the isSuccess variable to true
                isSuccess = true;
            }
            catch (Exception ex)
            {
                //sending the email failed so the isSuccess variable remains false
            }

            return isSuccess;
        }
    }
}
