using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using Prkn.UI.Win.Forms.Base;
using Prkn.Common.Enums;
using Prkn.Common.Enums.Functions;
using Prkn.UI.Win.Functions;
using Prkn.UI.Win.Dokum.ModelBase;
using Prkn.UI.Win.Dokum;
using Prkn.Common.Functions;

namespace Prkn.UI.Win.Forms.Dokum
{
    public partial class TabloDokumParametreleri : BaseEditForm
    {
        #region Variables

        private DokumSekli _dokumSekli;
        private readonly string _raporBaslik;
        #endregion
        public TabloDokumParametreleri(params object[] prm)
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl2;
            HideItems = new BarItem[] {btnNew, btnSave, btnDelete, btnUndo };
            ShowItems = new BarItem[] {btnPreviewPrint, btnPrint };
            EventsLoad();

            _raporBaslik = prm[0].ToString();
        }

        protected internal override void Yukle()
        {
            txtRaporBasligi.Text = _raporBaslik;
            txtBaslikEkle.Properties.Items.AddRange(EnumFuctions.GetEnumDescriptionList<EvetHayir>());
            txtRaporuKagidaSigdir.Properties.Items.AddRange(EnumFuctions.GetEnumDescriptionList<DokumKagidaSigdirmaTuru>());
            txtYazdirmaYonu.Properties.Items.AddRange(EnumFuctions.GetEnumDescriptionList<DokumYazdirmaYonu>());
            txtYatayCizgileriGoster.Properties.Items.AddRange(EnumFuctions.GetEnumDescriptionList<EvetHayir>());
            txtDikeyCizgileriGoster.Properties.Items.AddRange(EnumFuctions.GetEnumDescriptionList<EvetHayir>());
            txtSutunBasliklariniGoster.Properties.Items.AddRange(EnumFuctions.GetEnumDescriptionList<EvetHayir>());
            txtYaziciAdi.Properties.Items.AddRange(GeneralFunctions.YazicilariListele());

            txtBaslikEkle.SelectedItem = EvetHayir.Evet.ToName();
            txtRaporuKagidaSigdir.SelectedItem = DokumKagidaSigdirmaTuru.YaziBoyutunuKuculterekSigdir.ToName();
            txtYazdirmaYonu.SelectedItem = DokumYazdirmaYonu.Otomatik.ToName();
            txtYatayCizgileriGoster.SelectedItem = EvetHayir.Evet.ToName();
            txtDikeyCizgileriGoster.SelectedItem = EvetHayir.Evet.ToName();
            txtSutunBasliklariniGoster.SelectedItem = EvetHayir.Evet.ToName();
            txtYaziciAdi.SelectedItem = GeneralFunctions.DefaultYazici();
        }

        protected internal override IBaseEntity ReturnEntity()
        {
            var entity = new DokumParametreleri
            {
                RaporBaslik = txtRaporBasligi.Text,
                BaslikEkle = txtBaslikEkle.Text.GetEnum<EvetHayir>(),
                DokumKagidaSigdir = txtRaporuKagidaSigdir.Text.GetEnum<DokumKagidaSigdirmaTuru>(),
                DokumYazdirmaYonu = txtYazdirmaYonu.Text.GetEnum<DokumYazdirmaYonu>(),
                YatayCizgileriGoster = txtYatayCizgileriGoster.Text.GetEnum<EvetHayir>(),
                DikeyCizgileriGoster = txtDikeyCizgileriGoster.Text.GetEnum<EvetHayir>(),
                SutunBasliklariniGoster = txtSutunBasliklariniGoster.Text.GetEnum<EvetHayir>(),
                YaziciAdi = txtYaziciAdi.Text,
                YazdirilacakAdet = (int)txtYazdirilacakAdet.Value,
                DokumSekli = _dokumSekli
            };

            return entity;
        }

        protected override void Yazdir()
        {
            _dokumSekli = DokumSekli.TabloYazdir;
            Close();
        }

        protected override void BaskiOnizleme()
        {
            _dokumSekli = DokumSekli.TabloBaskiOnizleme;
            Close();
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != txtBaslikEkle) return;
            txtRaporBasligi.Enabled = txtBaslikEkle.Text.GetEnum<EvetHayir>() == EvetHayir.Evet;
        }
    }
}