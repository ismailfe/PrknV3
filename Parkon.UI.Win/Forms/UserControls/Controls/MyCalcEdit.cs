using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.Utils;
using Emikon.Parkon.UI.Win.Forms.Interfaces;
using System.ComponentModel;

namespace Emikon.Parkon.UI.Win.Forms.UserControls.Controls
{
   public class MyCalcEdit : CalcEdit, IStatusBarShortcut
    {
        [ToolboxItem(true)]
        public MyCalcEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False; //Boş değer almaması için
            Properties.EditMask = "n2"; //123.254,01
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarComment { get; set; }
        public string StatusBarShortcut { get; set; } = "F4 :";
        public string StatusBarShortcutComment { get; set; } = "Hesap Makinesi";
    }
}
