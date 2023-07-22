using Prkn.Common.Variables;
using Prkn.Model;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prkn.Model.DbSettings.Entities;


namespace Prkn.Bll.FileDirectory
{
    public class DirectoryBll
    {
        // Global.ProjeDizin.ProjeAnadizin
        public static string CreateFolderCustomer(string customerName)
        {
            try
            {
                string path = Global.ProjeDizin.ProjeAnadizin + "\\" + customerName;

                if (CreateDirectory(path))
                {

                }

                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }
        }
        public static string CreateFolderProject(string customerName, string projectRefNo, string projectName, string projectInfo)
        {
            //try
            //{
            string path = Global.ProjeDizin.ProjeAnadizin + "\\" + customerName + "\\" + projectRefNo;
            if (CreateDirectory(path))
            {
                string pathFirstDirectoryRev = path + "\\" + "R00";
                CreateDirectory(pathFirstDirectoryRev);
                CreateProjectInfoTxt(pathFirstDirectoryRev, projectName, projectInfo);
                CreateFolderProjectContent(pathFirstDirectoryRev);
            }

            return "OK!";
            //}
            //catch (Exception HATA)
            //{
            //    return "ERR! - " + HATA.ToString();
            //}
        }
        public static string CreateFolderProjectContent(string pathFirstDirectoryRev)
        {

            try
            {
                if (Directory.Exists(pathFirstDirectoryRev))
                {
                    Directory.CreateDirectory(pathFirstDirectoryRev + "\\" + Global.ProjeDizin.ProjeIcerik_D1);
                    Directory.CreateDirectory(pathFirstDirectoryRev + "\\" + Global.ProjeDizin.ProjeIcerik_D2);
                    Directory.CreateDirectory(pathFirstDirectoryRev + "\\" + Global.ProjeDizin.ProjeIcerik_D3);
                    Directory.CreateDirectory(pathFirstDirectoryRev + "\\" + Global.ProjeDizin.ProjeIcerik_D4);
                    Directory.CreateDirectory(pathFirstDirectoryRev + "\\" + Global.ProjeDizin.ProjeIcerik_D5);
                    Directory.CreateDirectory(pathFirstDirectoryRev + "\\" + Global.ProjeDizin.ProjeIcerik_D6);
                    Directory.CreateDirectory(pathFirstDirectoryRev + "\\" + Global.ProjeDizin.ProjeIcerik_D7);

                    Directory.CreateDirectory(pathFirstDirectoryRev + "\\" + Global.ProjeDizin.ProjeIcerik_D1 + "\\" + Global.ProjeDizin.AltKlasor_D1_1);
                    Directory.CreateDirectory(pathFirstDirectoryRev + "\\" + Global.ProjeDizin.ProjeIcerik_D1 + "\\" + Global.ProjeDizin.AltKlasor_D1_2);
                    Directory.CreateDirectory(pathFirstDirectoryRev + "\\" + Global.ProjeDizin.ProjeIcerik_D1 + "\\" + Global.ProjeDizin.AltKlasor_D1_2 + "\\" + Global.ProjeDizin.AltKlasor_D1_2_1);
                    Directory.CreateDirectory(pathFirstDirectoryRev + "\\" + Global.ProjeDizin.ProjeIcerik_D1 + "\\" + Global.ProjeDizin.AltKlasor_D1_2 + "\\" + Global.ProjeDizin.AltKlasor_D1_2_2);

                    Directory.CreateDirectory(pathFirstDirectoryRev + "\\" + Global.ProjeDizin.ProjeIcerik_D4 + "\\" + Global.ProjeDizin.AltKlasor_D4_1);
                    Directory.CreateDirectory(pathFirstDirectoryRev + "\\" + Global.ProjeDizin.ProjeIcerik_D4 + "\\" + Global.ProjeDizin.AltKlasor_D4_2);
                    Directory.CreateDirectory(pathFirstDirectoryRev + "\\" + Global.ProjeDizin.ProjeIcerik_D4 + "\\" + Global.ProjeDizin.AltKlasor_D4_3);
                    Directory.CreateDirectory(pathFirstDirectoryRev + "\\" + Global.ProjeDizin.ProjeIcerik_D4 + "\\" + Global.ProjeDizin.AltKlasor_D4_4);

                    Directory.CreateDirectory(pathFirstDirectoryRev + "\\" + Global.ProjeDizin.ProjeIcerik_D5 + "\\" + Global.ProjeDizin.AltKlasor_D5_1);
                    Directory.CreateDirectory(pathFirstDirectoryRev + "\\" + Global.ProjeDizin.ProjeIcerik_D5 + "\\" + Global.ProjeDizin.AltKlasor_D5_2);
                    Directory.CreateDirectory(pathFirstDirectoryRev + "\\" + Global.ProjeDizin.ProjeIcerik_D5 + "\\" + Global.ProjeDizin.AltKlasor_D5_3);
                    Directory.CreateDirectory(pathFirstDirectoryRev + "\\" + Global.ProjeDizin.ProjeIcerik_D5 + "\\" + Global.ProjeDizin.AltKlasor_D5_4);
                }
                return "OK!";
            }
            catch (Exception HATA)
            {
                //MessageBox.Show(HATA.Message.ToString(), "HATA");
                return "ERR! - " + HATA.ToString();
            }
        }
        public static string CreateFolderRev(string customerName, string projectRefNo, string projectName, string projectInfo, string RevCountWithNewRev, out string status)
        {
            status = string.Empty;
            string OncekiRevKlasor_Yolu = string.Empty;
            string YeniRevKlasor_Yolu = string.Empty;
            string ArsivKayit_Yolu = string.Empty;
            string ProjeKlasor_Yolu = string.Empty;
            string CopKlasoru_Yolu = string.Empty;
            string Str_OncekiRevNo = string.Empty;
            string YeniRevNo = string.Empty;
            string RevNo = string.Empty;
            int value = 0;
            try
            {
                switch (value)
                {
                    //Önemli Not: Revizyon No'su kendinden önceki Noya bakarak oluşturulur.

                    case 0:
                        status = "Yeni Revizyon oluşturma işlemi Başladı. Önceki Revizyon No'u aranıyor...";

                        string _revCountWithNewRev;
                        if (RevCountWithNewRev.Length < 2)
                        {
                            _revCountWithNewRev = "R0" + RevCountWithNewRev;
                        }
                        else
                        {
                            _revCountWithNewRev = "R" + RevCountWithNewRev;
                        }

                        // Önceki Revizyon No'su Hesapla
                        RevNo = RevCountWithNewRev; //.Substring(1, 2);
                        YeniRevNo = _revCountWithNewRev;
                        int OncekiRevNo = int.Parse(RevNo) - 1;

                        if (OncekiRevNo < 10)
                        {
                            Str_OncekiRevNo = "R0" + OncekiRevNo.ToString();
                        }
                        else
                        {
                            Str_OncekiRevNo = "R" + OncekiRevNo.ToString();
                        }

                       // UserLogsBll.Save("DirectoryOrganizer", "CreateFolderRev", Str_OncekiRevNo, "OK", null, "Rev No bulundu.");
                        goto case 1;
                    case 1:
                        status = "Gerekli değişkenler oluşturuluyor.";
                        ProjeKlasor_Yolu = Global.ProjeDizin.ProjeAnadizin + "\\" + customerName + "\\" + projectRefNo;
                        OncekiRevKlasor_Yolu = Global.ProjeDizin.ProjeAnadizin + "\\" + customerName + "\\" + projectRefNo + "\\" + Str_OncekiRevNo.ToString();
                        YeniRevKlasor_Yolu = Global.ProjeDizin.ProjeAnadizin + "\\" + customerName + "\\" + projectRefNo + "\\" + YeniRevNo;
                        ArsivKayit_Yolu = Global.ProjeDizin.ProjeAnadizin + "\\" + customerName + "\\" + projectRefNo + "\\" + Str_OncekiRevNo.ToString() + ".zip";
                        CopKlasoru_Yolu = Global.ProjeDizin.ProjeAnadizin + "9999 COP\\" + projectRefNo + " - " + Str_OncekiRevNo.ToString() + "\\" + Str_OncekiRevNo.ToString();

                        var logNewVal = "# " + ProjeKlasor_Yolu + " # " + OncekiRevKlasor_Yolu +
                                        " # " + YeniRevKlasor_Yolu + " # " + ArsivKayit_Yolu + " # " +
                                        CopKlasoru_Yolu;
                        //UserLogsBll.Save("DirectoryOrganizer", "CreateFolderRev-Case1", logNewVal, "OK", null, "Gerekli Vars / paths oluşturuldu.");
                        goto case 2;
                    case 2:
                        if (!Directory.Exists(YeniRevKlasor_Yolu))
                        {
                            var sts = Directory.CreateDirectory(YeniRevKlasor_Yolu);

                            DirectoryCopy(OncekiRevKlasor_Yolu, YeniRevKlasor_Yolu, true);
                            status = "Yeni Revizyon klasörü oluşturuldu. İşlem tamamlandı.";
                            //UserLogsBll.Save("DirectoryOrganizer", "CreateFolderRev-Case2", sts.ToString(), "OK", null, "Yeni Rev klasörü oluşturuldu.");
                        }


                        goto case 3;
                    case 3:
                        status = "Bir önceki revizyon dosyaları arşivleniyor.";
                        ZipFile.CreateFromDirectory(OncekiRevKlasor_Yolu, ArsivKayit_Yolu, CompressionLevel.Optimal, true);//, CompressionLevel.Optimal, false);
                        status = "Arşivleme işlemi tamamlandı. Dosyalar kaldırılıyor.";

                        var logNewVal2 = "# " + OncekiRevKlasor_Yolu + " # " + ArsivKayit_Yolu;
                      //  UserSystemLogsBll.Save("DirectoryOrganizer", "CreateFolderRev-Case3", logNewVal2, "OK", null, "Arşivleme işlemi tamamlandı.");
                        goto case 4;
                    case 4:

                        FileSystem.DeleteDirectory(OncekiRevKlasor_Yolu, UIOption.AllDialogs, RecycleOption.SendToRecycleBin);
                        var logNewVal3 = "# " + OncekiRevKlasor_Yolu;
 
                        goto case 5;
                    case 5:
                        Directory.CreateDirectory(OncekiRevKlasor_Yolu);



                        goto case 6;
                    case 6:
                        var oncekiRevDosyasi = OncekiRevKlasor_Yolu + "\\" + Str_OncekiRevNo.ToString();
                        File.Move(ArsivKayit_Yolu, oncekiRevDosyasi + ".zip");

                        var logNewVal4 = "# " + ArsivKayit_Yolu + " => " + oncekiRevDosyasi;
                      //  UserSystemLogsBll.Save("DirectoryOrganizer", "CreateFolderRev-Case6", logNewVal4, "OK", null, "Önceki Rev arşivi Rev klasörüne taşındı.");
                        status = "Arşivleme işlemi tamamlandı";
                        goto case 7;
                    case 7:
                        if (!Directory.Exists(YeniRevKlasor_Yolu))
                        {
                            Directory.CreateDirectory(YeniRevKlasor_Yolu);
                            status = "Yeni Revizyon klasörü oluşturuldu. İşlem tamamlandı.";
                        }

                        goto case 8;
                    case 8:
                        var logNewVal5 = CreateProjectInfoTxt(YeniRevKlasor_Yolu, projectName, projectInfo);
                   //     UserSystemLogsBll.Save("DirectoryOrganizer", "CreateFolderRev-Case8", logNewVal5, "OK", null, "Yeni Prroje info Txt oluşturuldu. Arşivleme tamamlandı.");
                        status = "Arşivleme işlemi tamamlandı";
                        goto case 50;
                    case 50:
                        break;
                }



                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }
        }

        private static string CreateProjectInfoTxt(string projectPath, string projectName, string projectInfo)
        {
            try
            {
                string path = projectPath + "\\" + Global.DateTimeString() + "_" + projectName + ".txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    string createText = projectInfo;
                    File.WriteAllText(path, createText, Encoding.UTF8);
                }
                return "OK;";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }
        }
        private static bool CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                var sts = Directory.CreateDirectory(path);
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the file contents of the directory to copy.
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                // Create the path to the new copy of the file.
                string temppath = Path.Combine(destDirName, file.Name);

                // Copy the file.
                file.CopyTo(temppath, false);
            }

            // If copySubDirs is true, copy the subdirectories.
            if (copySubDirs)
            {

                foreach (DirectoryInfo subdir in dirs)
                {
                    // Create the subdirectory.
                    string temppath = Path.Combine(destDirName, subdir.Name);

                    // Copy the subdirectories.
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
        private static void FileCopy(string sourceDirName, string destDirName, string FileName)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }


            // Get the file contents of the directory to copy.
            FileInfo[] files = dir.GetFiles(FileName);


            // Create the path to the new copy of the file.
            string temppath = Path.Combine(destDirName, files[0].Name);

            // Copy the file.
            // files[0].SetAccessControl()

            //                      dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            //    dInfo.SetAccessControl(dSecurity);


            files[0].CopyTo(temppath, false);

            // Read the current ACL details for the file
            var fileSecurity = File.GetAccessControl(temppath);

            // Create a new rule set, based on "Everyone"
            var fileAccessRule = new FileSystemAccessRule(new NTAccount(string.Empty, "Everyone"),
                  FileSystemRights.FullControl,
                  AccessControlType.Allow);

            // Append the new rule set to the file
            fileSecurity.AddAccessRule(fileAccessRule);

            // And persist it to the filesystem
            File.SetAccessControl(temppath, fileSecurity);
        }
        private static void FileMove(string sourceDirName, string destDirName, string FileName)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }


            // Get the file contents of the directory to copy.
            FileInfo[] files = dir.GetFiles(FileName);

            // Create the path to the new copy of the file.
            string temppath = Path.Combine(destDirName, files[0].Name);
            // Copy the file.
            files[0].MoveTo(temppath);


            // Read the current ACL details for the file
            var fileSecurity = File.GetAccessControl(temppath);

            // Create a new rule set, based on "Everyone"
            var fileAccessRule = new FileSystemAccessRule(new NTAccount(string.Empty, "Everyone"),
                  FileSystemRights.FullControl,
                  AccessControlType.Allow);

            // Append the new rule set to the file
            fileSecurity.AddAccessRule(fileAccessRule);

            // And persist it to the filesystem
            File.SetAccessControl(temppath, fileSecurity);
        }



        public class CreateTeklifFolderData
        {
            public string CustomerName { get; set; }
            public string TeklifRefNo { get; set; }
            public string TeklifName { get; set; }
            public string TeklifKodu { get; set; }
            public string TeklifTurKodu { get; set; }
        }

       public static string CreateFolderTeklif(string customerName, string teklifRefNo, string teklifName, string teklifTurKodu, string teklifInfo)
        {
            string path = Global.TeklifDizin.TeklifAnaDizin + "\\" + customerName + "\\" + teklifRefNo;

            if (Directory.Exists(path))
            {
                CreateDirectory(path);
            }

            string pathFirstDirectoryRev = path + "\\" + teklifTurKodu;
                CreateDirectory(pathFirstDirectoryRev);
                CreateProjectInfoTxt(pathFirstDirectoryRev, teklifName, teklifInfo);
                //CreateFolderProjectContent(pathFirstDirectoryRev);

            return "OK!";
        }


        //########################//
        public static string MusteriFirma_ExcelDosyasiOlustur(string MusteriKlasorPath, string müsteriNo, string MusteriAdi, string Notlar, string Detaylar)
        {
            try
            {
                //CLS.Form_Main.DGV_TempForExl.Columns.Add("Id", "Id");
                //CLS.Form_Main.DGV_TempForExl.Columns.Add("KayitTarih", "KayitTarih");
                //CLS.Form_Main.DGV_TempForExl.Columns.Add("KayitUser", "KayitUser");
                //CLS.Form_Main.DGV_TempForExl.Columns.Add("Notlar", "Notlar");
                //CLS.Form_Main.DGV_TempForExl.Columns.Add("Islem", "Islem");
                //CLS.Form_Main.DGV_TempForExl.Columns.Add("Detaylar", "Detaylar");
                //CLS.Form_Main.DGV_TempForExl.Rows.Add();

                //CLS.Form_Main.DGV_TempForExl.Rows[0].Cells[0].Value = 1;
                //CLS.Form_Main.DGV_TempForExl.Rows[0].Cells[1].Value = DateTime.Now.ToString();
                //CLS.Form_Main.DGV_TempForExl.Rows[0].Cells[2].Value = CLS.Form_Main.LB_UserName.Text;
                //CLS.Form_Main.DGV_TempForExl.Rows[0].Cells[3].Value = Notlar;
                //CLS.Form_Main.DGV_TempForExl.Rows[0].Cells[4].Value = "Yeni bir müşteri firma oluşturuldu.";
                //CLS.Form_Main.DGV_TempForExl.Rows[0].Cells[5].Value = Detaylar;
                //string ProjeKuneyesiYolu = MusteriKlasorPath + "\\" + müsteriNo + " " + MusteriAdi + " - MÜŞTERİ KUNYESI.xls";

                //string a = CLS.EXL.WRITE_DGVToExcelSave(CLS.Form_Main.DGV_TempForExl, ProjeKuneyesiYolu, false);

                //CLS.Form_Main.DGV_TempForExl.Columns.Clear();

                return "OK!";
            }
            catch (Exception HATA)
            {
                // CLS.LocalDB.LogsERR(HATA.ToString(), "", "");
                return "ERR!";
            }

        }
        private static string ToEnglish(string kelimecik)
        {
            kelimecik = kelimecik.Replace('ö', 'o');
            kelimecik = kelimecik.Replace('ü', 'u');
            kelimecik = kelimecik.Replace('ğ', 'g');
            kelimecik = kelimecik.Replace('ş', 's');
            kelimecik = kelimecik.Replace('ı', 'i');
            kelimecik = kelimecik.Replace('ç', 'c');
            kelimecik = kelimecik.Replace('Ö', 'O');
            kelimecik = kelimecik.Replace('Ü', 'U');
            kelimecik = kelimecik.Replace('Ğ', 'G');
            kelimecik = kelimecik.Replace('Ş', 'S');
            kelimecik = kelimecik.Replace('İ', 'I');
            kelimecik = kelimecik.Replace('Ç', 'C');

            return kelimecik;
        }
    }
}
