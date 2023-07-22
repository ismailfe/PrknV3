using Prkn.Common.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.Common.Functions
{
    public static class FtpVar
    {
        #region VARIABLES
        public static string ServerAdress           = "";
        public static string UserName               = "";
        public static string Password               = "";

        public static FileInfoData VerFile          = new FileInfoData();
        public static FileInfoData SetupFile        = new FileInfoData();

        public static Version Ver                   = new Version();

        public static class Status
        {
            public static string ByteSend { get; set; }
            public static string ByteTotal { get; set; }
            public static string UploadPercent { get; set; }
            public static bool UploadError { get; set; }
            public static bool UploadOk { get; set; }
            public static string StatusInfo { get; set; }
        }

        #endregion
    }

    public class FileInfoData
    {
        public string FileName { get; set; }
        public string LocalPath { get; set; }
        public string ServerPath { get; set; }
    }
    public class Version
    {
        public string New { get; set; } //Yeni oluşturulacak VerNo
        public string Last { get; set; } //Son oluşturulmuş VerNo
    }


}
