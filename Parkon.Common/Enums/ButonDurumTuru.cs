using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.Common.Enums
{
    public enum ButonDurumTuru : byte 
    {
        FirstLoad   = 0,
        New         = 1,
        Update      = 2,
        RowFocus    = 3,
        ValueChange = 4
    }
}
