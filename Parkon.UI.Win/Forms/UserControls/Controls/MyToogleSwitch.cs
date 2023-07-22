using Emikon.Parkon.UI.Win.Forms.Interfaces;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;


namespace Emikon.Parkon.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyToogleSwitch : ToggleSwitch, IStatusBarComment
    {
        public MyToogleSwitch()
        {
            Name                            = "TGL_Status";
            Properties.OffText              = "Pasif";
            Properties.OnText               = "Aktif";
            Properties.AutoHeight           = false;
            Properties.AutoWidth            = true;
            Properties.GlyphAlignment       = HorzAlignment.Far;
            Properties.Appearance.ForeColor = Color.Maroon;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarComment { get; set; } = "Kullanım durumunu seçiniz.";
    }
}
