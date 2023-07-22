using Prkn.Common.Design.Interfaces;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;
using System.Drawing;

namespace Prkn.Common.Design.Controls
{
   public class MyCheckedComboBoxEdit : CheckedComboBoxEdit, IStatusBarShortcut
    {
        [ToolboxItem(true)]
        public MyCheckedComboBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
          //  Properties.TextEditStyle = TextEditStyles.DisableTextEditor; Default değeri disable
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarShortcut { get; set; } = "F4 :";
        public string StatusBarShortcutComment { get; set; }
        public string StatusBarComment { get; set; }
    
    }
}
