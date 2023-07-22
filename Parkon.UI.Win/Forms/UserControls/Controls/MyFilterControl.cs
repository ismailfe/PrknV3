using Emikon.Parkon.UI.Win.Forms.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace Emikon.Parkon.UI.Win.Forms.UserControls.Controls
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
