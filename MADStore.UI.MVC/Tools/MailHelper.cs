using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace MADStore.UI.MVC.Tools
{
    public class MailHelper
    {

        public static bool ApprovedRegisterMail(string email)
        {
            bool result = false;

            MailMessage message = new MailMessage();
            message.To.Add(email);
            message.Subject = "MAD Store";
            message.IsBodyHtml = true;
            message.Body = "Tebrikler, kayıt işlemi başarılı. Lütfen giriş için onay mailimizi bekleyiniz.";
            message.From = new MailAddress("madstorecompany@gmail.com");

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;

            NetworkCredential credential = new NetworkCredential("madstorecompany@gmail.com", "Bilge1530insan.");
            smtpClient.Credentials = credential;

            try
            {
                smtpClient.Send(message); //gmail yolu ile mesajı at dedik.
                result = true; //Mesaj gönderildiği için sonucuda true döndürdük.
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }


        public static bool SendRegisterMail(string email)
        {
            bool result = false;

            MailMessage message = new MailMessage();
            message.To.Add(email);
            message.Subject = "MAD Store Company";
            message.IsBodyHtml = true;
            message.Body = "MAD Store ailesine hoşgeldiniz. Bize katıldığınız için teşekkür ederiz. Keyifli alışverişler dileriz. MAD Store";
            message.From = new MailAddress("madstorecompany@gmail.com");

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;

            NetworkCredential credential = new NetworkCredential("madstorecompany@gmail.com", "Bilge1530insan.");
            smtpClient.Credentials = credential;

            try
            {
                smtpClient.Send(message); //gmail yolu ile mesajı at dedik.
                result = true; //Mesaj gönderildiği için sonucuda true döndürdük.
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
    }
}