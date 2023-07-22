using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Prkn.Dal.Functions
{
    public class ToolAppConfig
    {
        public static void EncryptConfigFile(string configFileName, params string[] sectionName)
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(configFileName); // (ConfigurationUserLevel.None) => yol göstermeden direkt appConfig otomatik bulunur.

            foreach (var x in sectionName)
            {
                var section = configuration.GetSection(x);

                if (section.SectionInformation.IsProtected)
                {
                    return;
                }
                else
                {
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }

                section.SectionInformation.ForceSave = true;
                configuration.Save();
            }
        }
    }
}
