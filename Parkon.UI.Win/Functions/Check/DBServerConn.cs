using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prkn.UI.Win.Functions.Check
{
    public class DBServerConn
    {

        public bool DBServerPing()
        {
            try
            {
                Ping myPing             = new Ping();
                String host             = "192.168.2.32"; // "google.com";
                byte[] buffer           = new byte[1];
                int timeout             = 200;
                PingOptions pingOptions = new PingOptions();
                pingOptions.Ttl         = 1;
                var reply               = myPing.Send(host, timeout, buffer, pingOptions); // (host, timeout, buffer, pingOptions);

                if (reply.Status == IPStatus.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }






        public bool PingStatus;
        private static string BaseIP = "192.168.2.";
        private static int StartIP = 32;
        private static int StopIP = 32;
        private static string ip;

        private static int timeout = 10;
        private static int nFound = 0;

        static object lockObj = new object();
        static Stopwatch stopWatch = new Stopwatch();
        static TimeSpan ts;


        public async void Ping()
        {
            nFound = 0;
            stopWatch.Start();
            //var tasks = new List<Task>();



            //for (int i = StartIP; i <= StopIP; i++)
            //{
            //    ip = BaseIP + i.ToString();

            //    System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
            //    var task = PingAndUpdateAsync(p, ip);
            //    tasks.Add(task);
            //}
            //await Task.WhenAll(tasks).ContinueWith(t =>
            //{
            //    stopWatch.Stop();
            //    ts = stopWatch.Elapsed;
            //    MessageBox.Show(nFound.ToString() + " devices found! Elapsed time: " + ts.ToString(), "Asynchronous");
            //});



            ip = "192.168.2.32";
            System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
            PingAndUpdateAsync(p, ip);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;

            if (nFound > 0)
            {
                PingStatus = true;
          
            }
            else
            {
                PingStatus = false;
            }

        }
        private void PingAndUpdateAsync(System.Net.NetworkInformation.Ping ping, string ip)
        {
            var reply = ping.Send(ip, timeout);

            if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
            {
                lock (lockObj)
                {
                    nFound++;
                }
            }
        }



    }
}
