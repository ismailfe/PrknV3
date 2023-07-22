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
using System.Windows.Forms;
using System.Net;

namespace Prkn.Common.Functions
{
    public class MailJob
    {
        public static string YeniGorevMailiGonder(MailModel.GorevMaili gorev)
        {
            string uri      = gorev.HtmlFilePath; // Global.ProgramDizin.AppFolder_Path + "\\formail.html";
                                                  // string htmlFile = GetHtmlDocument(uri).ToString();// File.ReadAllText(uri);
            WebClient articlePage = new WebClient { Encoding = System.Text.Encoding.UTF8 };
            string htmlFile = articlePage.DownloadString(uri);


            string address      = Crypto.Decrypt(gorev.ToAddress, Global.Str_ProjeCrypto);
            string talepEden    = gorev.TalepEden;
            string oncelik      = gorev.Oncelik;
            string konu         = Crypto.Decrypt(gorev.Konu, Global.Str_ProjeCrypto);
            string aciklama     = Crypto.Decrypt(gorev.Aciklama, Global.Str_ProjeCrypto);
            string mailTitle    = "Yeni Görev | Talep Eden: " + talepEden;

            string body = htmlFile
                .Replace("xc0", talepEden)
                .Replace("xc1", oncelik)
                .Replace("xc2", konu)
                .Replace("xc3", aciklama);

            return Mail.Send(address, mailTitle, body);
        }

        public class MailModel
        {
            public class GorevMaili
            {
                public string HtmlFilePath { get; set; }
                public string ToAddress { get; set; }
                public string TalepEden { get; set; }
                public string Oncelik { get; set; }
                public string Konu { get; set; }
                public string Aciklama { get; set; }
            }
        }

    }
}
