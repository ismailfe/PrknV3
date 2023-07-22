using Emikon.Parkon.UI.Win.Forms.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace Emikon.Parkon.UI.Win.Forms.UserControls.Controls
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
