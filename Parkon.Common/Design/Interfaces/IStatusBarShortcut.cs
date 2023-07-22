namespace Prkn.Common.Design.Interfaces
{
    public interface IStatusBarShortcut : IStatusBarComment
    {
        string StatusBarShortcut { get; set; }
        string StatusBarShortcutComment { get; set; }
    }
}
