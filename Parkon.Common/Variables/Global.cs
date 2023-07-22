using Prkn.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prkn.Common.Variables
{
    public static class Global
    {
        public static string Str_ProjeCrypto    = "x";
        public static string Str_StokCrypto     = "xx";
        public static string Str_TeklifCrypto   = "xx";
        public static string DateTimeString()
        {
            string SifirEkle(string val)
            {
                if (val.Length == 1) return "0" + val;
                return val;
            }

            string UcBasamakYap(string val)
            {

                switch (val.Length)
                {
                    case 1:
                        return "00" + val;
                    case 2:
                        return "0" + val;
                }
                return val;
            }

            string time()
            {
                var yil         = SifirEkle(DateTime.Now.ToString("yy"));
                var ay          = SifirEkle(DateTime.Now.Month.ToString());
                var gun         = SifirEkle(DateTime.Now.Day.ToString());
                var saat        = SifirEkle(DateTime.Now.Hour.ToString());
                var dakika      = SifirEkle(DateTime.Now.Minute.ToString());
                var saniye      = SifirEkle(DateTime.Now.Second.ToString());
                //var milisaniye  = UcBasamakYap(DateTime.Now.Millisecond.ToString());
                //var random      = SifirEkle(new Random().Next(0, 99).ToString());
                //20 06 15 21 41 51 582  // yıl + ay + gün saat + dk + sn + ms
                return yil + ay + gun + "_" + saat + dakika + saniye;// + milisaniye; //+ gun + random  

            }
            return time();
        }

        public static class ProjeDizin
        {
            #region PROJE KLASÖR YAPISI ve KLASÖRLERİ

            public static string ProjeAnadizin  = @"D:\Prkn-Projeler";
            public static string ProjeIcerik_D1 = "D1";                       // Müşteri İlişkileri Gelenler/Teklifler=> Onaylanan/Verilen
            public static string ProjeIcerik_D2 = "D2";                       // Malzeme listesi
            public static string ProjeIcerik_D3 = "D3";                       // Elektrik Projesi ve Malzeme listesi
            public static string ProjeIcerik_D4 = "D4";                       // PLC, HMI-SCADA, Diger
            public static string ProjeIcerik_D5 = "D5";                       // Cihaz, Cizim, Form, Diger
            public static string ProjeIcerik_D6 = "D6";                       // Fotograf Video
            public static string ProjeIcerik_D7 = "D7";                       // İş Zaman Planı

            // D1 İÇİN OLUŞTURULACAK ALT KLASÖRLER //
            public static string AltKlasor_D1_1     = "Gelenler";                 // = "Gelenler";
            public static string AltKlasor_D1_2     = "Teklifler";                // = "Teklifler";
            public static string AltKlasor_D1_2_1   = "Teklif - Verilen";       // = "Teklif Verilenler";
            public static string AltKlasor_D1_2_2   = "Teklif - Onaylanan";     // = "Teklif Onaylanan";

            // D4 İÇİN OLUŞTURULACAK ALT KLASÖRLER //
            public static string AltKlasor_D4_1 = "PLC";                      // = "PLC";
            public static string AltKlasor_D4_2 = "HMI";                      // = "HMI SCADA";
            public static string AltKlasor_D4_3 = "PC";                       // = "PC";
            public static string AltKlasor_D4_4 = "Diger";                    // = "Diger";

            // D5 İÇİN OLUŞTURULACAK ALT KLASÖRLER //
            public static string AltKlasor_D5_1 = "Cihazlar";                 // = "Cihazlar";
            public static string AltKlasor_D5_2 = "Cizimler";                 // = "Cizim";
            public static string AltKlasor_D5_3 = "Diger";                    // = "Diger";
            public static string AltKlasor_D5_4 = "Formlar";                  // = "Formlar";

            #endregion
        }

        public static class TeklifDizin
        {
            public static string TeklifAnaDizin; //  = @"C:\Prkn-PROJELER";
        }
        public static class ProgramDizin
        {
            static string ProgramData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

            public static string AppDataFolderName                  = "Prkn-V3";
            public static string AppDataUpdateFolderName            = AppDataFolderName + "-Update";
            public static string LocalDB_Settings_FileName          = "Settings.sdf";
            public static string LocalDB_Temp_FileName              = "Db.sdf";

            // STANDART PROGRAM DOSYASI YOLLARI
            public static string App_Path                           = Application.ExecutablePath;                       // App. exe yolu
            public static string AppFolder_Path                     = Application.StartupPath;                          // App. exe klasör yolu
            public static string AppFolder_Support_Path             = AppFolder_Path + "\\Support\\";

            public static string ProgramData_Path                   = ProgramData + "\\" + AppDataFolderName + "\\";          //        +  "C:\\ProgramData"
            public static string ProgramData_Update_Path            = ProgramData + "\\" + AppDataUpdateFolderName + "\\";

            public static string ProgramData_Path_SablonDosyalari   = ProgramData_Path + "FormTemplateFile\\";
            public static string ProgramData_Path_ExportFile        = ProgramData_Path + "ExportFile\\";
            //public static string ProgramData_Update_Path            = ProgramData_Path + "Update\\";
            public static string ProgramData_Path_Temp              = ProgramData_Path + "Temp" + "\\";                 //        +  "C:\\ProgramData\\Temp"
            public static string ProgramData_Path_Temp_Img          = ProgramData_Path_Temp + "Img" + "\\";             //        +  "C:\\ProgramData\\Temp\\Img"
            public static string ProgramData_Path_Temp_TakeImg      = ProgramData_Path_Temp + "TakeImg" + "\\";         //        +  "C:\\ProgramData\\Temp\\Img"
            public static string LocalDB_Settings_Path              = ProgramData_Path + LocalDB_Settings_FileName;
            public static string LocalDB_Temp_Path                  = ProgramData_Path + LocalDB_Temp_FileName;
        }
        public static class Version
        {
            public static string Ver;
        }

    }


}
