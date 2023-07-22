using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prkn.UI.Win.Forms
{
    public partial class PrknWebForm : Form
    {
        public ChromiumWebBrowser browser;
        public PrknWebForm()
        {
            InitializeComponent();
            BrowserInitialize();
        }


        void BrowserInitialize()
        {
            CefSharpSettings.ShutdownOnExit = false;

            browser             = new ChromiumWebBrowser("http://192.168.2.31");
            this.Controls.Add(browser);
            browser.BringToFront();
            browser.Dock        = DockStyle.Fill;
          
            //browser.ExecuteScriptAsync("document.body.style.background = 'red';");
            //browser.ExecuteScriptAsyncWhenPageLoaded("");
            browser.LoadingStateChanged += Browser_LoadingStateChanged;
        }

        private void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            var host = ((ChromiumWebBrowser)sender);
            if (e.IsLoading == false)
            {
                try
                {
                    browser.ExecuteScriptAsync("document.getElementById(\"username\").value = 'id';");
                    browser.ExecuteScriptAsync("document.getElementById(\"password\").value = 'id';");

                    //browser.ExecuteScriptAsync("document.getElementById(\"password\").value = 'id';");

                    browser.ExecuteScriptAsync("document.getElementById(\"btn_submit\").click();");
                    //.GetElementById("MainContent_ButtonSearchDates").InvokeMember("click");
                    //if (host.RequestContext)
                    //{
                    //}
                    // browser.ExecuteScriptAsync("alert('All Resources Have Loaded');");
                }
                catch (Exception)
                {

                }

            }
        }
        private void PrknWebForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Cef.Shutdown();
        }
    }
}
