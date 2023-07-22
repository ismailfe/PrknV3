using Prkn.Common.Design.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace Prkn.Common.Design.Controls
{
   public class MyCheckEdit : CheckEdit, IStatusBarComment
    {
        [ToolboxItem(true)]
        public MyCheckEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.Transparent;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarComment { get; set; }
    }
}
