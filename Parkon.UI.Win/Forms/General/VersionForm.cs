using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Prkn.Common.Variables;
using Prkn.Common.Functions;

namespace Prkn.UI.Win.Forms.General
{
    public partial class VersionForm : DevExpress.XtraEditors.XtraForm
    {
        Timer tmr = new Timer();
        int cnt = 0;

        public VersionForm()
        {
            InitializeComponent();

            txtVer.Text = Global.Version.Ver;
        }

        public VersionForm(object newVersion, object newVersionNo)
        {
            InitializeComponent();
            Yukle(newVersion, newVersionNo);
        }


        void Yukle(object newVersion, object newVersionNo)
        {

            txtVer.Text = Global.Version.Ver;

            if ((bool)newVersion == true)
            {
                label3.Visible = true;
                label4.Visible = true;
                txtYuzde.Visible = true;
                txtNewVersion.Visible = true;
                txtNewVersion.Text = (string)newVersionNo;
                marqueeProgressBarControl1.Visible = true;
            }


            tmr.Start();
            tmr.Interval = 1000;
            tmr.Tick += Tmr_Tick;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            if (cnt <= 1000 )
            {
                txtYuzde.Text = "%" + Functions.Check.Update.DownloadYuzde.ToString();
                progressBarControl1.EditValue = Functions.Check.Update.DownloadYuzde.ToString();

                if (Functions.Check.Update.DownloadOK)
                {
                    label3.Text = "Yeni güncelleme indirildi.";
                    tmr.Stop();
                }
            }
        }

        private void VersionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmr.Stop();
        }
    }
}