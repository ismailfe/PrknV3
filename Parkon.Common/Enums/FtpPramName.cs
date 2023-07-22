using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.Common.Enums
{
    public enum FtpPramName : int //Ftp ayarlarını db ye kaydederken bu isimlerle kaydet
    {
        FtpServeName,
        FtpUserName,
        FtpPassword,
        FtpSetupServerPath,
        FtpSetupLocalPath,
        FtpVertxtServerPath,
        FtpVertxtLocalPath
    }
}
