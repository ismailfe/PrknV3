using Prkn.Common.Design.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace Prkn.Common.Design.Controls
{
    [ToolboxItem(true)]
   public class MyFilterControl : FilterControl, IStatusBarComment
    {
        public MyFilterControl()
        {
            ShowGroupCommandsIcon = true;
        }

        public string StatusBarComment { get; set; } = "Filtre metni giriniz.";
    }
}
