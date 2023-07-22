using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.UI.Win.Functions.Check
{
    class Machine
    {
        public Machine()
        {
            SystemEvents.PowerModeChanged += OnPowerChange;
        }

        private void OnPowerChange(object s, PowerModeChangedEventArgs e)
        {
            switch (e.Mode)
            {
                case PowerModes.Resume:
                    break;
                case PowerModes.Suspend:
                   // Internet.Get_OnlineAPI();
                    break;
            }
        }
    }
}
