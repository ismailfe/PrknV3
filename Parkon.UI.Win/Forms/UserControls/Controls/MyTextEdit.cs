﻿using Emikon.Parkon.UI.Win.Forms.Interfaces;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emikon.Parkon.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)] 
   public class MyTextEdit : TextEdit, IStatusBarComment
    {
        public MyTextEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 50;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarComment { get; set; }

    }
}
