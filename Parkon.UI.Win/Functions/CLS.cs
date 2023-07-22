using DevExpress.LookAndFeel;
using Prkn.Bll.Settings;
using Prkn.Common.Enums;
using Prkn.Common.Functions;
using Prkn.Common.Variables;
using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Prkn.UI.Win.Functions
{
    //Main Form üzerinden çağırılan ve Classların hepsini bir araya getiren classtır.
    public static class CLS 
    {
        #region Forms
        public static MainForm MainForm;
        public static Model.Users OnlineUser;
        public static bool UserLoginOK;
       // User
       //public static UserLoginForm Form_User_Login                     = new UserLoginForm();
       //public static Form_User_PassGenerator Form_User_PassGenerator   = new Form_User_PassGenerator();
       //// Common

       //// Customer
       ////public static Form_Customer Form_Customer                       = new Form_Customer();
       //public static Form_Admin_Test Form_Admin_Test                   = new Form_Admin_Test();
        #endregion


        static string getSettingsFilePath()
        {
            var path = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath;
            return path;
        }

 

    }
}
