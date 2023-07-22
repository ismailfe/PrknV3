using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.Common.Design.Controls
{
    [ToolboxItem(true)]
    public class MyPhoneNoEdit : MyTextEdit
    {
        public MyPhoneNoEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"\d?\d?\d?\d?  (\d?\d?\d?) \d?\d?\d? \d?\d? \d?\d?";
            StatusBarComment = "Telefon no giriniz.";
        }
    }
}
