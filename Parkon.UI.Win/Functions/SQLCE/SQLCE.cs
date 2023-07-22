using Prkn.Common.Variables;
using System;
using System.Linq;

namespace Prkn.UI.Win
{
    public static class SQLCE
    {
        public static void FirstLoad()
        {
            //string settingsDB_Path = CLS.ProgramData_Path + "\\";
            //string SettingsDB = "db.sdf";

            string ConnectionPath = "Data Source=\"" + Global.ProgramDizin.LocalDB_Settings_Path + "\";Password=x";    
                                                                                                                         

            //ConnectionTest();
            //MasterData_Read();
            //CLS.Form_Main.B_VeriOkunuyor.Visible = false;
        }
        public static string ConnectionTest()
        {
            string Status = string.Empty;
            //  Status = DateTime.Now + " - " + CLS.MySQLCE.ConnectionTest();
            return Status;
        }
    }
}
