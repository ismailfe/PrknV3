using Prkn.Common.Design.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace Prkn.Common.Design.Controls
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
