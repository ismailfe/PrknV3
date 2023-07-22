using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace Emikon.Parkon.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyTCKimlikNoTextEdit : MyTextEdit
    {
        public MyTCKimlikNoTextEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"\d?\d?\d? \d?\d?\d? \d?\d?\d? \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarComment = "TC kimlik no giriniz.";
        }
    }
}
