using Prkn.Data.Master;
using Prkn.Common;
using Prkn.Common.Functions;
using Prkn.Common.Variables;
using Prkn.UI.Win.DBOrganizer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prkn.UI.Win.Functions.Check
{
    public static class Internet
    {
        public static bool InternetOK;
        public static bool LocalDBServerConnOK;
        public static string InternetIP;

        public static void Cycle_Check()
        {
            var sts2 = Check();
            //var sts3 = CheckDBSERVER();
        }
        public static string Check()
        {
            try
            {
                //Ping pingSender = new Ping();
                //string host = @"stackoverflow.com";
                //await Task.Run(() => {
                //    PingReply reply = pingSender.Send(host);
                //    if (reply.Status == IPStatus.Success)
                //    {
                //        Console.WriteLine("Address: {0}", reply.Address.ToString());
                //        Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                //        Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                //        Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                //        Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
                //    }
                //    else
                //    {
                //        Console.WriteLine("Address: {0}", reply.Status);
                //    }
                //});

                Ping myPing = new Ping();
                String host = "Prkn.com.tr"; // "google.com";
                byte[] buffer = new byte[1];
                int timeout = 10;
                PingOptions pingOptions = new PingOptions();
                pingOptions.Ttl = 2;
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);



                InternetOK = true;
                InternetBilgiGosterimi(true);
                return "OK!";
            }
            catch
            {
                InternetBilgiGosterimi(false);
                InternetOK = false;
                return "ERR!";
            }
        }

        public static string CheckDBSERVER()
        {
            DBServerConn conn = new DBServerConn();

            if (conn.DBServerPing())
            {
                LocalDBServerConnOK = true;
                DbConnBilgiGosterimi(true);
                return "OK!";
            }
            else
            {
                LocalDBServerConnOK = false;
                DbConnBilgiGosterimi(false);
                return "ERR!";
            }

            //string result   = "";
            //int cnt         = 0;
            //Thread th       = new Thread(DBServerControl);
            //th.Start();

            //while (true)
            //{
            //    if (DBServerConnStatus == "OK!")
            //    {
            //        result = DBServerConnStatus;
            //        break;
            //    }
            //    else if (!string.IsNullOrEmpty(DBServerConnStatus))
            //    {
            //        result = DBServerConnStatus;
            //        break;
            //    }

            //    cnt++;
            //    if (cnt >= 10)
            //    {
            //        result = "TimeOut";
            //        break;
            //    }
            //}

            //DBServerConnStatus = "";
            //return "OK!";



            // var connStr                = System.Configuration.ConfigurationManager.ConnectionStrings["PrknDataContext"].ConnectionString;
            //SqlConnection connection    = new SqlConnection(connStr);

            //try
            //{
            //    connection.Open();
            //    connection.Close();
            //    DbConnBilgiGosterimi(true);
            //    return "OK!";
            //}
            //catch (SqlException)
            //{
            //    DbConnBilgiGosterimi(false);
            //    return "ERR!";
            //}

            //try
            //{
            //    Ping myPing = new Ping();
            //    String host = "192.168.2.32"; // "google.com";
            //    byte[] buffer = new byte[1];
            //    int timeout = 10;
            //    PingOptions pingOptions = new PingOptions();
            //    pingOptions.Ttl = 2;
            //    var reply = myPing.Send(host, timeout); //, buffer, pingOptions); // (host, timeout, buffer, pingOptions);

            //    if (reply.Status == IPStatus.Success)
            //    {
            //        LocalDBServerConnOK = true;
            //        DbConnBilgiGosterimi(true);
            //        return "OK!";
            //    }
            //    else
            //    {
            //        LocalDBServerConnOK = false;
            //        DbConnBilgiGosterimi(false);
            //        return reply.Status.ToString();
            //    }

            //}
            //catch
            //{
            //    LocalDBServerConnOK = false;
            //    DbConnBilgiGosterimi(false);
            //    return "ERR!";
            //}
        }

        static string DBServerConnStatus;
        static void DBServerControl()
        {
            var connStr = System.Configuration.ConfigurationManager.ConnectionStrings["PrknDataContext"].ConnectionString;
            SqlConnection connection = new SqlConnection(connStr);

            try
            {
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            
                DbConnBilgiGosterimi(true);
                DBServerConnStatus = "OK!";
            }
            catch (SqlException)
            {
                DbConnBilgiGosterimi(false);
                DBServerConnStatus = "ERR!";
            }
        }


        static void InternetBilgiGosterimi(bool internetOK)
        {
            DevExpress.Utils.SuperToolTip tip = new DevExpress.Utils.SuperToolTip();

            string Title = "";
            string IPAdd = "";

            if (internetOK)
            {
                Title = "İnternet Bağlantısı Başarılı!";
                IPAdd = "IP Address: " + Get_IP();
                CLS.MainForm.B_InternetCon.ImageOptions.Image = Properties.Resources.bolocalization_16x16;
            }
            else
            {
                Title = "İnternet Bağlantısı yok!";
                IPAdd = "IP Address: " + Get_IP();
                tip.Items.Add("IP Address: " + Get_IP());
                CLS.MainForm.B_InternetCon.ImageOptions.Image = Properties.Resources.cancel_16x16;
            }

            tip.Items.AddTitle(Title);
            tip.Items.Add(IPAdd);
           
            CLS.MainForm.B_InternetCon.SuperTip = tip;
        }
        static void DbConnBilgiGosterimi(bool DBServerConOK)
        {
            var tip = new DevExpress.Utils.SuperToolTip();

            string Title = "";
            string IPAdd = "";

            if (DBServerConOK)
            {
                Title       = "DATABASE SERVER Bağlantısı kuruldu!";
                IPAdd       = "IP Address: " + Get_IP();
                CLS.MainForm.B_DBCon.ImageOptions.Image = Properties.Resources.database_16x16;

                //CLS.MainForm.B_DBOffline.Visible = false;
            }
            else
            {
                Title       = "DATABASE SERVER Bağlantısı HATASI! Bağlantı Kurulamadı.";
                IPAdd       = "IP Address: " + Get_IP();
                CLS.MainForm.B_DBCon.ImageOptions.Image = Properties.Resources.deletedatasource_16x16;

                //CLS.MainForm.B_DBOffline.Visible = true;
            }

            tip.Items.AddTitle(Title);
            tip.Items.Add(IPAdd);

            CLS.MainForm.B_DBCon.SuperTip = tip;
        }

        public static string Get_IP()
        {
            try
            {
                string IPadresim = new System.Net.WebClient().DownloadString("http://api.ipify.org");

                if (IPadresim.Length < 16)
                {
                    InternetIP = IPadresim;
                }
            }
            catch (Exception)
            {
                InternetIP = "0.0.0.0";
            }


            return InternetIP;
        }

    }
}
