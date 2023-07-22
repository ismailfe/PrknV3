using Prkn.Common.Enums;
using Prkn.UI.Win.Dokum.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.UI.Win.Dokum
{
    public class DokumParametreleri : IBaseEntity
    {
        public string RaporBaslik { get; set; }
        public EvetHayir BaslikEkle { get; set; }
        public DokumKagidaSigdirmaTuru DokumKagidaSigdir { get; set; }
        public DokumYazdirmaYonu DokumYazdirmaYonu { get; set; }
        public EvetHayir YatayCizgileriGoster { get; set; }
        public EvetHayir DikeyCizgileriGoster { get; set; }
        public EvetHayir SutunBasliklariniGoster { get; set; }
        public string YaziciAdi { get; set; }
        public int YazdirilacakAdet { get; set; }
        public DokumSekli DokumSekli { get; set; }
    }
}
