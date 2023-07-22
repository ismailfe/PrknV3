namespace Prkn.UI.Win.Forms.Interfaces
{
    public interface IStatusBarShortcut : IStatusBarComment
    {
        string StatusBarShortcut { get; set; }
        string StatusBarShortcutComment { get; set; }
    }
}
