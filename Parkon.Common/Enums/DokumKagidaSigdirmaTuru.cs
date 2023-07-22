using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.Common.Enums
{
    public enum DokumKagidaSigdirmaTuru : byte
    {
        [Description("Sutunları Daraltarak Sığdır")]
        SutunlariDaraltarakSigdir = 1,
        [Description("Yazı Boyutunu Küçülterek Sığdır")]
        YaziBoyutunuKuculterekSigdir = 2,
        [Description("İşlem Yapma (Değişiklik yok)")]
        IslemYapma = 3
    }
}
