using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace Prkn.Common.Design.Controls
{
   public class MyCardEdit : MyTextEdit //Oluşturulan MyTextEditten türeyecek
    {
        [ToolboxItem(true)]
        public MyCardEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType        = MaskType.Regular;
            Properties.Mask.EditMask        = @"\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?-\d?\d?\d?\d?"; // Kredi kart formatı 1234-1234-1234-1234
            Properties.Mask.AutoComplete    = AutoCompleteType.None; // Girdiği otomatik tamamlama istenmiyor. Aski durumda kalan girdiler 0 olarak doldurulur.
            StatusBarComment                = "Kart no giriniz.";
            Properties.MaxLength            = 16;
        }
    }
}
