using Emikon.Parkon.UI.Win.Forms.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace Emikon.Parkon.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public partial class MyMemoEdit : MemoEdit, IStatusBarComment
    {
        public MyMemoEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 500;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarComment { get; set; } = "Açıklama giriniz.";
    }
}
