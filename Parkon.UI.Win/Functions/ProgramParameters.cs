using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Navigation;
using Prkn.Bll.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.UI.Win.Functions
{
    public class ProgramParameters
    {
        #region MENU STATUS Save / Load
        public static void MenuStatusSave(string PageName, AccordionControl accordionControl_MainMenu)
        {
            var elementCount = accordionControl_MainMenu.Elements.Count;

            for (int i = 0; i < elementCount; i++)
            {
                if (accordionControl_MainMenu.Elements[i].Style == ElementStyle.Group)
                {
                    var prm = AccordionControlElementPrm(PageName, accordionControl_MainMenu, i);
                    SettingsBll.PostSelfSetting(prm.Name, prm.Val);
                }
            }
        }
        public static void MenuStatusLoad(string PageName, AccordionControl accordionControl_MainMenu)
        {
            var elementCount = accordionControl_MainMenu.Elements.Count;

            for (int i = 0; i < elementCount; i++)
            {
                if (accordionControl_MainMenu.Elements[i].Style == ElementStyle.Group)
                {
                    var prm = AccordionControlElementPrm(PageName, accordionControl_MainMenu, i);
                    bool.TryParse(SettingsBll.GetSelfSetting(prm.Name), out bool expanded);
                    accordionControl_MainMenu.Elements[i].Expanded = expanded;
                }
            }

        }
        static SettingsBll.Parameter AccordionControlElementPrm(string PageName, AccordionControl accordionControl_MainMenu, int i)
        {
            SettingsBll.Parameter prm = new SettingsBll.Parameter();
            string prefix = PageName;
            prm.Name = PageName + "_" + accordionControl_MainMenu.Elements[i].Name;
            prm.Val = accordionControl_MainMenu.Elements[i].Expanded.ToString();

            return prm;
        }
        #endregion

        #region SKIN Save / Load
        public static void SkinLoad()
        {
            try
            {
                var prm = SkinPrm("");
                var SkinName = SettingsBll.GetSelfSetting(prm.Name);

                if (SkinName != null)
                {
                    UserLookAndFeel.Default.SkinName = SkinName; // "DevExpress Dark Style";
                }
            }
            catch (Exception)
            {
            }
        }
        public static void SkinSave(string SkinName)
        {
                var prm = SkinPrm(SkinName);
                SettingsBll.PostSelfSetting(prm.Name, prm.Val);

                //var name = CLS.MainForm.LookAndFeel.ActiveSkinName;
                //ActiveLookAndFeelStyle style = CLS.MainForm.LookAndFeel.ActiveStyle;
            //      U.SetSkinStyle.
            // Settings.Default["ApplicationSkinName"] = UserLookAndFeel.Default.SkinName;
            // Settings.Default.Save();
        }

        public static SettingsBll.Parameter SkinPrm(string SkinName)
        {
            SettingsBll.Parameter prm = new SettingsBll.Parameter();
            prm.Name = "Skin";
            prm.Val = SkinName;
            return prm;
        }
        #endregion

    }
}
