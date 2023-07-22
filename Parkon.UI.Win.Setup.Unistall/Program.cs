using Parkon.Common.Variables;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkon.UI.Win.Setup.Unistall
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = Global.ProgramDizin.ProgramData_Path;

            if (Directory.Exists(uri))
            {
                Directory.Delete(uri,true);
                Directory.CreateDirectory(uri);
            }

        }
    }
}
