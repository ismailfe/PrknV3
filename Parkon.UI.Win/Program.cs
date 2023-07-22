using DevExpress.Skins;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Prkn.UI.Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.UserSkins.BonusSkins.Register(); //For Save Skin
            SkinManager.EnableFormSkins();              //For Save Skin
            Application.Run(new MainForm());
        }
    }
}