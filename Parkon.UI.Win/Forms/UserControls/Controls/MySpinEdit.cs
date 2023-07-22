using Emikon.Parkon.UI.Win.Forms.Interfaces;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;


namespace Emikon.Parkon.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MySpinEdit : SpinEdit, IStatusBarComment
    {
        public MySpinEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "d";
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarComment { get; set; } 
    }
}
