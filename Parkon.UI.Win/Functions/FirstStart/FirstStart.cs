using Prkn.Bll.Settings;
using Prkn.Common.Functions;
using Prkn.Common.Variables;
using Prkn.UI.Win.DBOrganizer;
using Prkn.UI.Win.Functions;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Prkn.UI.Win.Functions.Check
{
    public static class FirstStart
    {
        public static System.Timers.Timer Tmr = new System.Timers.Timer();
        public static bool FirstStart_Tamamlandi;
        public static bool FirstStart_Basladi;

        public static void Baslangic()
        {
            int sw = 0;
            int statusValue = 0;
            Stopwatch st = new Stopwatch();
            //CLS.Form_Starting.progressBarFirstStart.Maximum = 20;

            switch (sw)
            {
                case 0:
                    // ########## First Start Başladı ########## //
                    FirstStart_Basladi                  = true;
                    FirstStart_Tamamlandi               = false;
                    Program_Versiyon_Bilgilerini_Oku();
                    statusValue = 0;
                    goto case 1;
                case 1:
                    SQLCECheck.StartCheck();
                    DizinKontrolleri();

                    statusValue = 1;
                    goto case 2;
                case 2:
                    //AutoRunPrg.TaskStart("PrknV2");
                    AutoRunPrg.AddApplicationToStartup("PrknV2");
                    statusValue = 3;
                    goto case 3;
                case 3:


                    statusValue = 4;
                    goto case 4;
                case 4:
                    SettingsLoad();
                    //MachineFirstStart();

                    statusValue = 5;
                    goto case 5;
                case 5:
                    Internet.Cycle_Check();

                    //Thread.Sleep(20);
                    statusValue = 6;
                    goto case 6;
                case 6:

                    //if (Internet.InternetOK && Internet.LocalDBServerConnOK)
                    //{
                    //    DBMirrorDataUpdate.FirstLoad();

                    //    Thread TH = new Thread(DBMirrorDataUpdate.CycleUpdate);  //Periyodik Update Start
                    //    TH.Start();
                    //}

                    UserLoginLogout.Login_FirstStart();
                    statusValue     = 50;
                    int a1          = statusValue;
                    goto case 50;
                case 50:
                    FirstStart_Tamamlandi   = true;
                    FirstStart_Basladi      = false;

                    Thread.Sleep(10);
                    break;
            }
        }

        public static string DbLocalSettingsCheck()
        {
            if (!File.Exists(Global.ProgramDizin.LocalDB_Settings_Path))
            {
                // Folder.FileCopy(Global.ProgramDizin.AppFolder_Support_Path, Global.ProgramDizin.ProgramData_Path, Global.ProgramDizin.LocalDB_Settings_FileName);
            }

            return "OK!";
        }
        public static string LocalDbTempCheck()
        {
            if (!File.Exists(Global.ProgramDizin.LocalDB_Temp_Path))
            {
                //     Folder.FileCopy(Global.ProgramDizin.AppFolder_Support_Path, Global.ProgramDizin.ProgramData_Path, Global.ProgramDizin.LocalDB_Temp_FileName);
            }

            return "OK!";
        }
        public static string DizinKontrolleri()
        {
            if (!Directory.Exists(Global.ProgramDizin.ProgramData_Path))
            {
                Directory.CreateDirectory(Global.ProgramDizin.ProgramData_Path);
            }
            if (!Directory.Exists(Global.ProgramDizin.ProgramData_Path_Temp))
            {
                Directory.CreateDirectory(Global.ProgramDizin.ProgramData_Path_Temp);
            }
            if (!Directory.Exists(Global.ProgramDizin.ProgramData_Path_Temp_Img))
            {
                Directory.CreateDirectory(Global.ProgramDizin.ProgramData_Path_Temp_Img);
            }
            if (!Directory.Exists(Global.ProgramDizin.ProgramData_Path_Temp_TakeImg))
            {
                Directory.CreateDirectory(Global.ProgramDizin.ProgramData_Path_Temp_TakeImg);
            }
            return "OK!";
        }

        public static string SettingsLoad()
        {
            SettingsBll.FirstLoad();

            //ProgramParameters.SkinLoad();
            //Global.ProjeDizin.ProjeAnadizin = SettingsBll.GetMainProjectsPath();
            //Global.TeklifDizin.TeklifAnaDizin = SettingsBll.GetMainTeklifPath();
            return "OK!";
        }

        public static string Program_Versiyon_Bilgilerini_Oku()
        {
            try
            {
                FileVersionInfo fvi;
                System.Reflection.Assembly assembly;

                assembly = System.Reflection.Assembly.GetExecutingAssembly();
                fvi = FileVersionInfo.GetVersionInfo(assembly.Location);


                string Vers = "Proje Arşivleme ve Kontrol Sistemi V" + fvi.FileVersion;
                string Vers1 = "Ver: " + fvi.FileVersion;
                Global.Version.Ver = fvi.FileVersion;
                return Global.Version.Ver;
            }
            catch (Exception HATA)
            {
                return "ERR: " + HATA.ToString();
            }
        }
        public static string SayfaDuzen_Kontrolleri()
        {
            try
            {
                //#region MAIN TAB
                //string Page0 = "TabPage_ProjeSorgula";
                //string Page1 = "TabPage_ProjeYeni";
                //string Page2 = "TabPage_Servis";
                //string Page3 = "TabPage_Teklif";
                //string Page4 = "TabPage_Rapor";
                //string Page5 = "TabPage_Otomasyon";
                //string Page6 = "TabPage_Stok";
                //string Page7 = "TabPage_Ayarlar";

                ////CLS.Form_Main.Tab_Main.ShowToolTips = true;
                //CLS.Form_Main.Tab_Main.TabPages[Page0].ToolTipText = "Proje Sorgulama";
                //CLS.Form_Main.Tab_Main.TabPages[Page1].ToolTipText = "Yeni Proje Oluşturma";
                //CLS.Form_Main.Tab_Main.TabPages[Page2].ToolTipText = "Servis, Bakım, Eğitim Hizmetleri";
                //CLS.Form_Main.Tab_Main.TabPages[Page3].ToolTipText = "Fiyat Listeleri ve Teklif Oluşturma";
                //CLS.Form_Main.Tab_Main.TabPages[Page4].ToolTipText = "Çalışma ve Proje Raporları";
                //CLS.Form_Main.Tab_Main.TabPages[Page5].ToolTipText = "Otomasyoncunun Beslenme Çantası";
                //CLS.Form_Main.Tab_Main.TabPages[Page6].ToolTipText = "STOK KONTROL SİSTEMİ";
                //CLS.Form_Main.Tab_Main.TabPages[Page7].ToolTipText = "Extra Bilgiler ve Ayarlar";

                //CLS.Form_Main.Tab_Main.TabPages[Page0].Text = "";
                //CLS.Form_Main.Tab_Main.TabPages[Page1].Text = "";
                //CLS.Form_Main.Tab_Main.TabPages[Page2].Text = "";
                //CLS.Form_Main.Tab_Main.TabPages[Page3].Text = "";
                //CLS.Form_Main.Tab_Main.TabPages[Page4].Text = "";
                //CLS.Form_Main.Tab_Main.TabPages[Page5].Text = "";
                //CLS.Form_Main.Tab_Main.TabPages[Page6].Text = "";
                //CLS.Form_Main.Tab_Main.TabPages[Page7].Text = "";

                //ImageList ImgList_TabMain = new ImageList();
                //ImgList_TabMain.ImageSize = new Size(28, 28);
                //CLS.Form_Main.Tab_Main.ImageList = ImgList_TabMain;

                //ImgList_TabMain.Images.Add("key0", Properties.Resources.i119);
                //ImgList_TabMain.Images.Add("key1", Properties.Resources.i118);
                //ImgList_TabMain.Images.Add("key2", Properties.Resources.i114);
                //ImgList_TabMain.Images.Add("key3", Properties.Resources.i116);
                //ImgList_TabMain.Images.Add("key4", Properties.Resources.i131);
                //ImgList_TabMain.Images.Add("key5", Properties.Resources.i129);
                //ImgList_TabMain.Images.Add("key6", Properties.Resources.i160);
                //ImgList_TabMain.Images.Add("key7", Properties.Resources.i120);

                //CLS.Form_Main.Tab_Main.TabPages[Page0].ImageIndex = 0;
                //CLS.Form_Main.Tab_Main.TabPages[Page1].ImageIndex = 1;
                //CLS.Form_Main.Tab_Main.TabPages[Page2].ImageIndex = 2;
                //CLS.Form_Main.Tab_Main.TabPages[Page3].ImageIndex = 3;
                //CLS.Form_Main.Tab_Main.TabPages[Page4].ImageIndex = 4;
                //CLS.Form_Main.Tab_Main.TabPages[Page5].ImageIndex = 5;
                //CLS.Form_Main.Tab_Main.TabPages[Page6].ImageIndex = 6;
                //CLS.Form_Main.Tab_Main.TabPages[Page7].ImageIndex = 7;

                //CLS.Form_Main.Tab_Ayarlar.TabPages.Remove(CLS.Form_Main.TabPage_Admin);
                //#endregion
                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR: " + HATA.ToString();
            }
        }
        public static string LogFileOku()
        {
            try
            {
                //string cmd1 = CLS.Log.LogFileRead(CLS.Form_Main.RTB_LogsOp, CLS.ProgramData_Path + "Log_Op.txt");
                //string cmd2 = CLS.Log.LogFileRead(CLS.Form_Main.RTB_LogsHata, CLS.ProgramData_Path + "Log_Error.txt");
                //string cmd3 = CLS.Log.LogFileRead(CLS.Form_Main.RTB_AppStart, CLS.ProgramData_Path + "Log_AppStart.txt");
                //CLS.Form_Main.RTB_LogsOp.Visible = true;
                // CLS.Form_Main.RTB_LogsHata.Visible = true;
                // CLS.Form_Main.RTB_AppStart.Visible = true;

                return string.Empty;
            }
            catch (Exception HATA)
            {
                return HATA.ToString();
            }

        }

        public static string MachineFirstStart()
        {
            //Machine machine = new Machine();

            return "OK";
        }



    }
}
