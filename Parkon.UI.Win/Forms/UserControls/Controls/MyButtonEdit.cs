using Emikon.Parkon.UI.Win.Forms.Interfaces;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using System.Drawing;

namespace Emikon.Parkon.UI.Win.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyButtonEdit : ButtonEdit, IStatusBarShortcut
    {
        public MyButtonEdit()
        {
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarComment { get; set; }
        public string StatusBarShortcut { get; set; } = "F4";
        public string StatusBarShortcutComment { get; set; }

        #region Events
        private long? _id;
        //Seçim değiştiğinde 
        //Eski seçilen ID ile yeni seçilen ID tespit etmek için
        [Browsable(false)] // Properties bölümünde gizle
        public long? Id
        {
            get => _id;
            set
            {
                var oldValue = _id;
                var newValue = value;

                if (newValue == oldValue)
                {
                    return;
                }
                else
                {
                    _id = value;
                    if (IdChanged == null)
                    {
                        return;
                    }

                    IdChanged(this, new IdChangedEventArgs(oldValue, newValue));
                    EnabledChange(this, EventArgs.Empty);
                }
            }
        }
        //Event Handler
        public event EventHandler<IdChangedEventArgs> IdChanged = delegate { };

        public event EventHandler EnabledChange = delegate { };
        #endregion
    }

    public class IdChangedEventArgs : EventArgs
    {
        public IdChangedEventArgs(long? oldValue, long? newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }

        public long? OldValue { get; }
        public long? NewValue { get; }
    }

}
