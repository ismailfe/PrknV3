using DevExpress.XtraBars;
using Prkn.Common.Variables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prkn.UI.Win.Functions.Check
{
    public class Update
    {
        #region VARIABLES

        public static string URL = "http://192.168.2.31/software";

        public static BarButtonItem _newVersionButton;
        public static int DownloadYuzde;
        public static bool DownloadOK;
        public static string NewVersion;
        ProgressBar progressBar1 = new ProgressBar();
        static string DownloadAdd;
        static string SaveAdd;
        static bool _onemliGuncellemeVar;
        static Label _labelDownload = new Label();
        #endregion

        public static string VerCheck(ref BarButtonItem NewVer)
        {
            try
            {
                if (VerCompare())
                {
                    NewVer.Visibility = BarItemVisibility.Always;

                    if (_onemliGuncellemeVar)
                    {
                        DialogResult r = MessageBox.Show("Önemli bir güncelleme yayımlandı. 'OK' butonuna basarak güncellemeyi indirip kurulumu başlatınız.", "Prkn - Önemli Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (r == DialogResult.OK)
                        {
                            Indir();
                            //VersionForm frm = new VersionForm(true, NewVersion);
                            //frm.ShowDialog();
                        }
                    }
                }

                

                //if (YeniVersiyonBulundu)
                //{
                //    CLS.Form_Main.B_YeniVerBulundu.Visible = true;
                //    if (DB_VerOkumaOK)
                //    {
                //        CLS.Bildirimler.Notify_VersiyonBilgi(OkunanBilgi[7], OkunanBilgi[8]);
                //        Indir(OkunanBilgi[4], OkunanBilgi[5]);
                //    }
                //    else
                //    {
                //        CLS.Bildirimler.Notify_VersiyonBilgi(OkunanBilgi[7], OkunanBilgi[8]);
                //        Indir("http://Prkn.net/software/Prkn_Setup.msi", CLS.Form_VersiyonYukle.LB_GuncelVersiyon.Text);
                //    }


                //}
                //else
                //{
                //    CLS.Form_Main.B_YeniVerBulundu.Visible = false;
                //}
                //CLS.Form_Main.DGV_PrknUpdate.DataSource = DS.Tables[0];


                return "OK!";
            }
            catch (Exception HATA)
            {
                //CLS.LocalDB.LogsERR(HATA.ToString(), "", "");
                return "ERR! " + HATA.ToString();
            }
        }

        static bool VerCompare()
        {
            try
            {
                string[] OkunanVer = "0.0.0.0".Split('.');
                string[] PrgVer = Global.Version.Ver.Split('.'); //CLS.fvi.FileVersion.Split('.');

                WebClient Cl = new WebClient();
                string read = Cl.DownloadString(URL + "/ver.txt");
                NewVersion = read;
                OkunanVer = read.Split('.');

                int MV0 = int.Parse(PrgVer[0]);
                int MV1 = int.Parse(PrgVer[1]);
                int MV2 = int.Parse(PrgVer[2]);
                int MV3 = int.Parse(PrgVer[3]);

                int RV0 = int.Parse(OkunanVer[0]);
                int RV1 = int.Parse(OkunanVer[1]);
                int RV2 = int.Parse(OkunanVer[2]);
                int RV3 = int.Parse(OkunanVer[3]);

                bool YeniVersiyonBulundu = false;

                if (MV0 >= RV0)
                {
                    if (MV0 >= RV0 && MV1 >= RV1)
                    {
                        if (MV1 >= RV1 && MV2 >= RV2)
                        {
                            if (MV2 >= RV2 && MV3 < RV3)
                            {
                                YeniVersiyonBulundu = true;
                            }
                        }
                        else
                        {
                            YeniVersiyonBulundu = true;
                            _onemliGuncellemeVar = true;
                        }
                    }
                    else
                    {
                        YeniVersiyonBulundu = true;
                        _onemliGuncellemeVar = true;
                    }
                }
                else
                {
                    YeniVersiyonBulundu = true;
                    _onemliGuncellemeVar = true;
                }

                return YeniVersiyonBulundu;
            }
            catch (Exception HATA)
            {
                //CLS.LocalDB.LogsERR(HATA.ToString(), "", "");
                return false;
            }

        }
        public static string Indir()
        {
            try
            {
                if (!Directory.Exists(Global.ProgramDizin.ProgramData_Update_Path))
                {
                    Directory.CreateDirectory(Global.ProgramDizin.ProgramData_Update_Path);
                }

                WebClient Cl = new WebClient();
                string VerRead = Cl.DownloadString(Var_JSON.URI.Version).Replace("\r", "").Replace("\n", "");

                DownloadAdd = URL + "/PrknSetup.msi";
                SaveAdd = Global.ProgramDizin.ProgramData_Update_Path + "PrknSetupV" + VerRead + ".msi";

                using (WebClient wc = new WebClient())
                {
                    //wc.DownloadFile(DownloadAdd, SaveAdd);
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
                    wc.DownloadFileCompleted += comp;

                    // Start downloading the file
                    wc.DownloadFileAsync(new System.Uri(DownloadAdd), SaveAdd);
                }
                _newVersionButton.Caption = "V" + NewVersion + " indiriliyor";
                return "OK!";
            }
            catch (Exception HATA)
            {
                //CLS.LocalDB.LogsERR(HATA.ToString(), "", "");
                return "ERR! " + HATA.ToString();
            }
        }
        private static void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                _newVersionButton.Caption = "V" + NewVersion + " indiriliyor %" + e.ProgressPercentage;
                DownloadYuzde = e.ProgressPercentage;
                _labelDownload.Text = _newVersionButton.Caption;
                _labelDownload.Update();
                //CLS.Form_VersiyonYukle.progressBar1.Visible     = true;
                //CLS.Form_VersiyonYukle.progressBar1.Value       = e.ProgressPercentage;
                //progressBar1.Visible = true;
                //progressBar1.Value = e.ProgressPercentage;
            }
            catch (Exception)
            {
            }
        }
        static void comp(object sender, AsyncCompletedEventArgs e)
        {
            //       AutoInstall AutoInst = new AutoInstall();
            //        AutoInst.RunInstallMSI(SaveAdd);

            // //Old
            //System.Diagnostics.Process.Start(SaveAdd);
            //CLS.Form_Main.APPCLOSE();
            // this.Close();
            DownloadOK = true;

            Thread.Sleep(2000);

            RunInstallMSI(SaveAdd);
        }
        public static bool RunInstallMSI(string sMSIPath)
        {
            try
            {
                Console.WriteLine("Starting to install application");
                Process process = new Process();
                process.StartInfo.FileName = "msiexec.exe";
                process.StartInfo.Arguments = string.Format(" /qb /i \"{0}\" ALLUSERS=1", sMSIPath);
                process.Start();
                bool ProStartOK = process.Responding;
                if (ProStartOK)
                {
                    CLS.MainForm.APPCLOSE(false);
                }
                Console.WriteLine("Application installed successfully!");
                return true; //Return True if process ended successfully
            }
            catch (Exception HATA)
            {
                //CLS.LocalDB.LogsERR(HATA.ToString(), "", "");
                Console.WriteLine("There was a problem installing the application!");
                return false;  //Return False if process ended unsuccessfully
            }
        }

    }
}
