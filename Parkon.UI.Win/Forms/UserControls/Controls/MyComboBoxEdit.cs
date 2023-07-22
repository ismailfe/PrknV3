

using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using Emikon.Parkon.UI.Win.Forms.Interfaces;
using System.ComponentModel;

namespace Emikon.Parkon.UI.Win.Forms.UserControls.Controls
{
   public class MyComboBoxEdit : ComboBoxEdit, IStatusBarShortcut
    {
        [ToolboxItem(true)]
        public MyComboBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarShortcut { get; set; } = "F4 :";
        public string StatusBarShortcutComment { get; set; }
        public string StatusBarComment { get; set; }
    }
}
