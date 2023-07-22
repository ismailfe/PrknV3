using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using Prkn.Common.Design.Interfaces;
using System.ComponentModel;

namespace Prkn.Common.Design.Controls
{
    public class MyLookUpEdit : LookUpEdit, IStatusBarShortcut
    {
        [ToolboxItem(true)]
        public MyLookUpEdit()
        {
            Properties.AppearanceFocused.BackColor  = Color.LightCyan;
            Properties.TextEditStyle                = TextEditStyles.DisableTextEditor;
            Properties.NullText                     = "---";
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarShortcut { get; set; } = "F4 :";
        public string StatusBarShortcutComment { get; set; }
        public string StatusBarComment { get; set; }
    }
}
