using Prkn.Common.Design.Interfaces;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace Prkn.Common.Design.Controls
{
    [ToolboxItem(true)]
    public partial class MyMemoEdit : MemoEdit, IStatusBarComment
    {
        public MyMemoEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 1050;
        }

        public override bool EnterMoveNextControl { get; set; } = false;
        public string StatusBarComment { get; set; } = "Açıklama giriniz.";
    }
}
