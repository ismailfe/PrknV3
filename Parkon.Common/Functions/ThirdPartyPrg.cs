using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prkn.Common.Functions
{
    public class ThirdPartyPrg
    {

        public static void OpenGoodSync()
        {
            Cursor.Current = Cursors.WaitCursor;
            string myPath = @"C:\Program Files\Siber Systems\GoodSync\GoodSync.exe";
            if (File.Exists(myPath))
            {
                System.Diagnostics.Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = myPath;
                prc.Start();
            }
            else
            {
                MessageBox.Show("Galiba GoodSync programı bilgisayarınızda yüklü değil. Programı yükledikten sonra tekrar deneyin.", "Bir şeyler Ters gitti :/");
            }

            Cursor.Current = Cursors.Default;
        }


    }
}
