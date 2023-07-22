using Prkn.Common.Variables;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prkn.Common.Functions
{
    public class Mail
    {
       static string smtpServer     = "x";
       static string yourMailAdd    = "x";
       static string yourMailPass   = "x";

        public static string Send(string toAddress, string subject, string body, object ekDosya = null)
        {
            string gonderimSonucu   = "";
            int mailAdresiSayisi    = Regex.Matches(toAddress, ";").Count + 1;
            SmtpClient client       = new SmtpClient("smtp.yandex.com.tr", 587);
            MailMessage mail        = new MailMessage();
            mail.From               = new MailAddress(yourMailAdd, "Prkn"); //gönderici olarak görünen mail bilgileri
            mail.Priority           = MailPriority.High;
            mail.Subject            = subject;

            if (mailAdresiSayisi > 1)
            {
                string[] aliciPostaAdresleri = toAddress.Split(';');
                for (int i = 0; i < mailAdresiSayisi; i++)
                {
                    string aliciPostaAdresi = aliciPostaAdresleri[i];
                    mail.To.Add(new MailAddress(aliciPostaAdresi, ""));
                }
            }
            else
            {
                mail.To.Add(new MailAddress(toAddress, ""));
            }

            mail.Body = body;
            mail.IsBodyHtml = true;

            if (ekDosya != null)
            {
                mail.Attachments.Add(new Attachment(ekDosya.ToString()));
            }

            NetworkCredential girisIzni         = new NetworkCredential(yourMailAdd, yourMailPass);
            client.UseDefaultCredentials        = false;
            client.EnableSsl                    = true;
            client.Credentials                  = girisIzni;
            try
            {
                client.Send(mail);
                gonderimSonucu = "OK";
                return gonderimSonucu;
            }
            catch (Exception ex)
            {
                gonderimSonucu = ex.Message;
                return gonderimSonucu;
            }
        }


    }
}
