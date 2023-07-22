using Emikon.Parkon.UI.Win.Forms.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace Emikon.Parkon.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MySingleButton : SimpleButton, IStatusBarComment
    {
        public MySingleButton()
        {
            Appearance.ForeColor = Color.Maroon;
        }

        public string StatusBarComment { get; set; }
    }
}
