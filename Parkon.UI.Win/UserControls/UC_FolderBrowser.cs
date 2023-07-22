using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Prkn.UI.Win
{
    public partial class UC_FolderBrowser : DevExpress.XtraEditors.XtraUserControl
    {
        public string BrowserYol;

        public UC_FolderBrowser()
        {
            InitializeComponent();
            if (BrowserYol != null)
            {
                WebBrowser.Url = new Uri(BrowserYol);// String.Format("file:///{0}/my_html.html", curDir));
            }
         
        }

        public Button XID_B_Ac
        {
            get { return B_Ac; }
            set { B_Ac = value; }
        }

        public WebBrowser XID_WBrowser
        {
            get { return WebBrowser; }
            set { WebBrowser = value; }
        }

        public PictureBox XID_Picture
        {
            get { return Pic_Sembol; }
            set { Pic_Sembol = value; }
        }

        public Button XID_B_Geri
        {
            get { return B_Geri; }
            set { B_Geri = value; }
        }

        public Button XID_B_LinkCopy
        {
            get { return B_Link; }
            set { B_Link = value; }
        }

        public Label XID_LB_Baslik
        {
            get { return LB_Baslik; }
            set { LB_Baslik = value; }
        }

        public Panel PanelBackGround
        {
            get { return Panel; }
            set { Panel = value; }
        }

        private void B_Link_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(BrowserYol);
        }


        private void B_Ac_Click(object sender, EventArgs e)
        {
            OpenWindow(BrowserYol);
        }

        public void OpenWindow(string Path)
        {
            string windir = Environment.GetEnvironmentVariable("WINDIR");
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = windir + @"\explorer.exe";
            prc.StartInfo.Arguments = Path;
            prc.Start();
        }
        private void B_Geri_Click(object sender, EventArgs e)
        {
            if (BrowserYol != null)
            {
                WebBrowser.Url = new Uri(BrowserYol);
            }

            //if (WebBrowser.CanGoBack)
            //{
            //    WebBrowser.GoBack();
            //}
        }

        private void LB_Baslik_TextChanged(object sender, EventArgs e)
        {
            if (LB_Baslik.Text.EndsWith("!"))
            {
                Panel.BackColor = Color.Silver;
            }
            else
            {
                Panel.BackColor = Color.Ivory;
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Dispose(true);
            //DestroyHandle();
            //Parent.Refresh();
            //Parent.Update();
            //Parent.
        }
    }
}
