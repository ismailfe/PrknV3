using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using Prkn.Common.Design.Interfaces;
using System.ComponentModel;

namespace Prkn.Common.Design.Controls
{
   public class MyDateEdit : DateEdit, IStatusBarShortcut
    {
        [ToolboxItem(true)]
        public MyDateEdit()
        {
            Properties.AppearanceFocused.BackColor                 = Color.LightCyan;
            Properties.AllowNullInput                       = DefaultBoolean.False;
            Properties.Appearance.TextOptions.HAlignment    = HorzAlignment.Near;
            Properties.Mask.MaskType                        = MaskType.DateTimeAdvancingCaret;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarShortcut { get; set; } = "F4 :";
        public string StatusBarShortcutComment { get; set; } = "Tarih seç";
        public string StatusBarComment { get; set; }
    }
}
