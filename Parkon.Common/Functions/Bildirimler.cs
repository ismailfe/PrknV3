using System;
using System.Linq;

namespace Prkn.Common.Functions
{
    public static class Bildirimler
    {
        public static bool internetBaglantisiERR;
        public static string InternetIP;

        public static string SelamMesaji()
        {
            //try
            //{
            //    if (DateTime.Now.Hour >= 5 && DateTime.Now.Hour < 11)
            //    {
            //        CLS.Form_Main.LB_Selamlama.Text = "Günaydın!";
            //        return "Günaydın!";
            //    }
            //    else if (DateTime.Now.Hour >= 11 && DateTime.Now.Hour < 18)
            //    {
            //        CLS.Form_Main.LB_Selamlama.Text = "İyi Günler!";
            //        return "İyi Günler!";
            //    }
            //    else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 23)
            //    {
            //        CLS.Form_Main.LB_Selamlama.Text = "İyi Akşamlar!";
            //        return "İyi Akşamlar!";
            //    }
            //    else // (DateTime.Now.Hour >= 23 && DateTime.Now.Hour < 5)
            //    {
            //        CLS.Form_Main.LB_Selamlama.Text = "İyi Geceler!";
            //        return "İyi Geceler!";
            //    }
            //}
            //catch (Exception HATA)
            //{
            //    CLS.Form_Main.LB_Selamlama.Text = "Merhaba";
            //    CLS.LocalDB.LogsERR(HATA.ToString(), "", "");
            //    return "Merhaba";
            //}

            return "ERR!";

        }
        public static string Notify_Start()
        {
            //    try
            //    {
            //        //// Backround Work
            //        if(!CLS.FirstStart.FirstStart_Basladi)
            //        {
            //            CLS.Form_Main.Notify_Prkn.BalloonTipText = "Hi! Prkn is running. Have a nice day!";
            //            CLS.Form_Main.Notify_Prkn.BalloonTipTitle = "Prkn - Proje Arşivleme ve Kontrol";
            //            CLS.Form_Main.Notify_Prkn.ShowBalloonTip(800);
            //            CLS.Form_Main.Notify_Prkn.Visible = true;
            //        }

            //        return "OK!";
            //    }
            //    catch (Exception HATA)
            //    {
            //        CLS.LocalDB.LogsERR(HATA.ToString(), "", "");
            //        return "ERR " + HATA.ToString();
            //    }

            //}
            //public string Notify_Bilgi_Uyari()
            //{
            //    try
            //    {
            //        if (DateTime.Now.ToLongTimeString() == "14:30:02")
            //        {
            //            //// Backround Work
            //            CLS.Form_Main.Notify_Prkn.BalloonTipText = "Bir fincan kahve içmenin tam zamanı...";
            //            CLS.Form_Main.Notify_Prkn.BalloonTipTitle = "Prkn - Proje Arşivleme ve Kontrol";
            //            // this.WindowState = FormWindowState.Minimized;
            //            CLS.Form_Main.ShowInTaskbar = false;
            //            CLS.Form_Main.Notify_Prkn.Visible = true;
            //            CLS.Form_Main.Notify_Prkn.ShowBalloonTip(800);
            //            CLS.Form_Main.ShowInTaskbar = false;
            //            CLS.Form_Main.Notify_Prkn.Visible = true;
            //            CLS.Form_Main.Notify_Prkn.ShowBalloonTip(1000);
            //            string[] Rdata;
            //            CLS.AutoUpdate.VerCheck(out Rdata);
            //        }

            //        if (DateTime.Now.ToLongTimeString() == "17:00:02")
            //        {
            //            //// Backround Work
            //            CLS.Form_Main.Notify_Prkn.BalloonTipText = "Sıcak bir fincan kahve daha? ";
            //            CLS.Form_Main.Notify_Prkn.BalloonTipTitle = "Prkn - Proje Arşivleme ve Kontrol";
            //            // this.WindowState = FormWindowState.Minimized;
            //            CLS.Form_Main.ShowInTaskbar = false;
            //            CLS.Form_Main.Notify_Prkn.Visible = true;
            //            CLS.Form_Main.Notify_Prkn.ShowBalloonTip(800);
            //            CLS.Form_Main.ShowInTaskbar = false;
            //            CLS.Form_Main.Notify_Prkn.Visible = true;
            //            CLS.Form_Main.Notify_Prkn.ShowBalloonTip(1000);
            //            string[] Rdata;
            //            CLS.AutoUpdate.VerCheck(out Rdata);
            //        }

            //        return "OK!";
            //    }
            //    catch (Exception HATA)
            //    {
            //        CLS.LocalDB.LogsERR(HATA.ToString(), "", "");
            //        return "ERR " + HATA.ToString(); ;
            //    }

            //}
            //public string Notify_VersiyonBilgi(string Baslik, string Mesaj)
            //{
            //    try
            //    {
            //        if (CLS.Form_Main.LB_Gosterge_Internet.BackColor == Color.Lime)
            //        {
            //            CLS.Form_Main.Notify_Prkn.BalloonTipText = Mesaj;
            //            CLS.Form_Main.Notify_Prkn.BalloonTipTitle = Baslik;
            //            CLS.Form_Main.Notify_Prkn.Visible = true;
            //            CLS.Form_Main.Notify_Prkn.ShowBalloonTip(10000);
            //        }
            //        return "OK!";
            //    }
            //    catch
            //    {
            //        return "ERR!";
            //    }
            //}
            //public string Notify_Internet_Yok()
            //{
            //    try
            //    {
            //        //// Backround Work
            //        CLS.Form_Main.Notify_Prkn.BalloonTipText  = "Bilgisayarda internet bağlantısı olmadığı algılandı. Prkn çalışmaya ''Local Database'' ile devam edecek.";
            //        CLS.Form_Main.Notify_Prkn.BalloonTipTitle = "Prkn - Proje Arşivleme ve Kontrol";
            //        CLS.Form_Main.Notify_Prkn.Visible         = true;
            //        CLS.Form_Main.Notify_Prkn.ShowBalloonTip(1000);

            //        return "OK!";
            //    }
            //    catch (Exception HATA)
            //    {
            //        CLS.LocalDB.LogsERR(HATA.ToString(), "", "");
            //        return "ERR";
            //    }
            //}
            //public string NetKontrol()
            //{
            //    try
            //    {
            //        Ping myPing = new Ping();
            //        String host = "google.com";
            //        byte[] buffer = new byte[32];
            //        int timeout = 1;
            //        PingOptions pingOptions = new PingOptions();
            //        pingOptions.Ttl = 1;
            //        PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);

            //        CLS.Form_Main.InternetDurumunaGoreGostergeler(true);
            //        internetBaglantisiERR = false;

            //        string IPadresim = new System.Net.WebClient().DownloadString("http://api.ipify.org");

            //        if (IPadresim.Length < 16)
            //        {
            //            InternetIP = IPadresim;
            //        }

            //        return "OK!";
            //    }
            //    catch
            //    {
            //        CLS.Form_Main.InternetDurumunaGoreGostergeler(false);
            //        internetBaglantisiERR = true;
            //        if (!internetBaglantisiERR)
            //        {
            //            CLS.Bildirimler.Notify_Internet_Yok();
            //        }
            //        CLS.Form_Main.CHB_OnlineDataBase.Checked = false;
            //       return "ERR!";
            //    }
            return "ERR!";
        }


    }
}
