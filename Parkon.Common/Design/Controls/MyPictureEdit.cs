﻿using Prkn.Common.Design.Interfaces;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;
using System.Drawing;


namespace Prkn.Common.Design.Controls
{
    [ToolboxItem(true)]
    public class MyPictureEdit : PictureEdit, IStatusBarShortcut
    {
        public MyPictureEdit()
        {
            Properties.AppearanceFocused.BackColor  = Color.LightCyan;
            Properties.Appearance.ForeColor         = Color.Maroon;
            Properties.NullText                     = "Resim Yok";
            Properties.SizeMode                     = PictureSizeMode.Stretch;
            Properties.ShowMenu                     = false;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarShortcut { get; set; } = "F4 :";
        public string StatusBarShortcutComment { get; set; }
        public string StatusBarComment { get; set; }
    }
}
