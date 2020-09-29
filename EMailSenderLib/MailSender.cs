using System;
using System.Net;
using System.Net.Mail;

namespace EMailSenderLib
{
    public class MailSender
    {
        public string Send(string user, string password, string subject, string body, string reciver)
        {
            string from = user;
            string to = reciver;

            MailMessage mm = new MailMessage(from, to);


            mm.Subject = subject;
            mm.Body = body;
            mm.IsBodyHtml = false;

            SmtpClient sc = new SmtpClient("smtp.yandex.ru", 25);
            sc.EnableSsl = true;
            sc.DeliveryMethod = SmtpDeliveryMethod.Network;
            sc.UseDefaultCredentials = false;
            sc.Credentials = new NetworkCredential(user, password);
            

            try
            {

                sc.Send(mm);
                return "Письмо отправленно";
            }
            catch(Exception ex)
            {
                return "Не удалось отправить письмо" + ex.ToString();
            }

        }

    }
}
