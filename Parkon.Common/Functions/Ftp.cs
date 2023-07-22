using Prkn.Common.Variables;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prkn.Common.Functions
{
    public class Ftp
    {
        static FtpWebRequest request;
        static string _yuklenenDosya;

        public static void FirstLoad()
        {

            FtpVar.Status.StatusInfo    = "";
            FtpVar.Status.ByteSend      = "";
            FtpVar.Status.ByteTotal     = "";
            FtpVar.Status.UploadPercent = "";
            FtpVar.Status.UploadOk      = false;
            FtpVar.Status.UploadError   = false;

            //FtpVar.VerFile.LocalPath    = Global.ProgramDizin.ProgramData_Path;
            FtpVar.VerFile.FileName     = "ver.txt";
            FtpVar.SetupFile.FileName   = "PrknSetup.msi";


            //public static string NewVersion             = "";
            //public static string VerFileLocalPath       = Global.ProgramDizin.ProgramData_Path;
            //public static string VerFileServerPath      = "";
            //public static string VerFileName            = "ver.txt";

            //public static string SetupFileLocalPath     = Global.ProgramDizin.ProgramData_Path;
            //public static string SetupFileServerPath    = "";
            //public static string SetupFileName          = "PrknSetup.msi";
        }
        static FtpWebRequest ConnString()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(FtpVar.ServerAdress);
                request.Credentials = new NetworkCredential(FtpVar.UserName, FtpVar.Password);
            }
            catch (Exception)
            {

            }


            return request;
        }
        public static string ConnTest()
        {
            try
            {
                var req = ConnString();
                req.Method = WebRequestMethods.Ftp.ListDirectory;

                WebResponse response = req.GetResponse();
                response.Close();
                return DateTime.Now.ToString() + " OK - " + response.ResponseUri;
            }
            catch (Exception HATA)
            {
                return DateTime.Now.ToString() + " " + HATA.Message.ToString();
            }
        }
        public static List<string> DirectoryListOfFtp()
        {
            List<string> directories = new List<string>();
            try
            {
                var req = ConnString();
                req.Method = WebRequestMethods.Ftp.ListDirectory;
                FtpWebResponse response = (FtpWebResponse)req.GetResponse();
                StreamReader streamReader = new StreamReader(response.GetResponseStream());

                string line = streamReader.ReadLine();
                while (!string.IsNullOrEmpty(line))
                {
                    directories.Add(line);
                    line = streamReader.ReadLine();
                }

                streamReader.Close();
            }
            catch (Exception)
            {

            }
     

            return directories;
        }


        #region UPLOAD - Setup Files
        public static void Upload_SetupFile()
        {
            string localPath        = FtpVar.SetupFile.LocalPath;
            string serverPath       = FtpVar.SetupFile.ServerPath + "/" + FtpVar.SetupFile.FileName;

            request                 = (FtpWebRequest)WebRequest.Create(serverPath);
            request.Credentials     = new NetworkCredential(FtpVar.UserName, FtpVar.Password);
            request.Method          = WebRequestMethods.Ftp.UploadFile;

            try
            {
                WebResponse response = request.GetResponse();
                FileTransfer(localPath, serverPath);
                _yuklenenDosya = "Setup Dosyası";
            }
            catch (Exception HATA)
            {
                FtpVar.Status.StatusInfo = HATA.Message;
            }
        }
        #endregion

        #region UPLOAD - Versiyon Text Files
        public static void CreateVer_Text()
        {
            var ver = FtpVar.Ver.New;
            using (StreamWriter sw = File.CreateText(FtpVar.VerFile.LocalPath))
            {
                sw.WriteLine(ver);
            }
        }
        public static void Upload_VerFile(string Version)
        {
            CreateVer_Text();

            string localPath    = FtpVar.VerFile.LocalPath;
            string serverPath   = FtpVar.VerFile.ServerPath + "/" + FtpVar.VerFile.FileName;

            request             = (FtpWebRequest)WebRequest.Create(serverPath);
            request.Credentials = new NetworkCredential(FtpVar.UserName, FtpVar.Password);
            request.Method      = WebRequestMethods.Ftp.UploadFile;
            try
            {
                WebResponse response = request.GetResponse();
                FileTransfer(localPath, serverPath);
                _yuklenenDosya = "Versiyon Dosyası";
            }
            catch (Exception HATA)
            {
                FtpVar.Status.StatusInfo = HATA.Message;
            }
        }
        #endregion
    
        #region File Transfer
        static void FileTransfer(string FileLocalPath, string FileServerPath)
        {
            using (var client = new WebClient())
            {
                client.UploadProgressChanged    += FileUploadProgressChanged;
                client.UploadFileCompleted      += Client_UploadFileCompleted;
                client.Credentials              = new NetworkCredential(FtpVar.UserName, FtpVar.Password);
                client.UploadFileAsync (new Uri(FileServerPath), WebRequestMethods.Ftp.UploadFile, FileLocalPath);
            }
        }
        private static void Client_UploadFileCompleted(object sender, UploadFileCompletedEventArgs e)
        {
            if (FtpVar.Status.StatusInfo.StartsWith("Setup"))
            {
                FtpVar.Status.UploadOk = true;
                FtpVar.Status.StatusInfo = _yuklenenDosya + " için yükleme işlemi Tamamlandı " + DateTime.Now.ToString();
            }
        }
        private static void FileUploadProgressChanged(object sender, UploadProgressChangedEventArgs e)
        {
            FtpVar.Status.StatusInfo = _yuklenenDosya + " Yükleniyor..."; //  Top: %" + e.ProgressPercentage;
            FtpVar.Status.ByteSend = (e.BytesSent).ToString();
            FtpVar.Status.ByteTotal = (e.TotalBytesToSend).ToString();
            FtpVar.Status.UploadPercent = (e.BytesSent * 100 / e.TotalBytesToSend).ToString();
        }
        #endregion
    }
}
