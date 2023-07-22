using Prkn.Common.Variables;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prkn.UI.Win.Functions.Check
{
    class SQLCECheck
    {
        public static bool StartCheck()
        {
            bool TespitOK = false;
            string Pfiles1 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string Pfiles2 = Pfiles1 + @"\Microsoft SQL Server Compact Edition\v4.0";
            string File1 = Pfiles2 + @"\sqlceca40.dll";
            string File2 = Pfiles2 + @"\sqlcecompact40.dll";
            string File3 = Pfiles2 + @"\sqlcese40.dll";
            string File4 = Pfiles2 + @"\sqlceqp40.dll";

            if (Directory.Exists(Pfiles2) && File.Exists(File1) && File.Exists(File2) && File.Exists(File3) && File.Exists(File4))
            {
                TespitOK = true;
            }


            if (!TespitOK)
            {
                DialogResult res = MessageBox.Show("'Microsoft SQL CE' uygulaması eksik görünüyor. Programın çalışması için eksik uygulamların yüklenmesi gerekmekte. Eksik uygulamaların yüklemesi başlatılacak!", "Sistemde eksik tespit edildi.", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);

                if (res == DialogResult.OK)
                {
                    string sMSIPath = "";
                    if (Environment.Is64BitOperatingSystem)
                    {
                        sMSIPath = Global.ProgramDizin.AppFolder_Support_Path + "SSCERuntime_x64-TRK.exe";
                    }
                    else
                    {
                        sMSIPath = Global.ProgramDizin.AppFolder_Support_Path + "SSCERuntime_x86-TRK.exe";
                    }

                    System.Diagnostics.Process.Start(sMSIPath);
                    CLS.MainForm.APPCLOSE(false);
                    //Process process = new Process();
                    //process.StartInfo.FileName = "msiexec.exe";
                    //process.StartInfo.Arguments = string.Format(" /qb /i \"{0}\" ALLUSERS=1", sMSIPath);
                    //process.Start();
                }
                else
                {
                    MessageBox.Show("Bu eklenti yüklenmediği için Uygulama kapatılacak", "Uygulama Kapat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CLS.MainForm.APPCLOSE(false);
                }
            }

            return TespitOK;
        }
    }
}
