using DevExpress.Utils;
using System.ComponentModel;
using System.Drawing;

namespace Prkn.Common.Design.Controls
{
    [ToolboxItem(true)]
    public class MyCodeTextEdit : MyTextEdit
    {
        public MyCodeTextEdit()
        {
            Properties.Appearance.BackColor                 = Color.PaleGoldenrod;
            Properties.Appearance.TextOptions.HAlignment    = HorzAlignment.Center;
            Properties.MaxLength                            = 20;
            StatusBarComment                                = "Kod giriniz.";
        }
    }
}
