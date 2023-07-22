﻿using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Native;
using DevExpress.Utils.Extensions;


namespace Prkn.UI.Win.Forms.BaseForms
{
    public partial class BaseListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Variables
        private long _filtreId;
        private bool _formSablonKayitEdilecek;
        private bool _tabloSablonKayitEdilecek;
        protected bool AktifKartlariGoster = true;
        protected ControlNavigator Navigator;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected internal GridView Tablo;
        protected internal bool AktifPasifButonGoster = false;
        protected internal bool MultiSelect;
        protected internal long? SeciliGelecekId;
        #endregion

        public BaseListForm()
        {
            InitializeComponent();
        }
        private void EventsLoad()
        {
            //Button Events
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarItem button:
                        button.ItemClick += Button_ItemClick;
                        break;
                }
            }

            //Table Events
            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.KeyDown += Tablo_KeyDown;
            Tablo.MouseUp += Tablo_MouseUp;
            Tablo.ColumnWidthChanged += Tablo_ColumnWidthChanged;
            Tablo.ColumnPositionChanged += Tablo_ColumnPositionChanged;
            Tablo.EndSorting += Tablo_EndSorting;
            Tablo.FilterEditorCreated += Tablo_FilterEditorCreated;
            Tablo.ColumnFilterChanged += Tablo_ColumnFilterChanged;

            //Form Events
            Shown += BaseListForm_Shown;
            Load += BaseListForm_Load;
            FormClosing += BaseListForm_FormClosing;
            LocationChanged += BaseListForm_LocationChanged;
            SizeChanged += BaseListForm_SizeChanged;
        }


        private void SutunGizleGoster()
        {

        }
        private void SablonKaydet()
        {
            if (_formSablonKayitEdilecek)
            {
            //    Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);
            }

            if (_tabloSablonKayitEdilecek)
            {
           //    Tablo.TabloSablonKaydet(IsMdiChild ? Name + "Tablosu" : Name + "TablosuMDI");
            }
        }
        private void SablonYukle()
        {
            if (IsMdiChild)
            {
            //    Tablo.TabloSablonYukle(Name + "Tablosu");
            }
            else
            {
            //    Name.FormSablonYukle(this);
            //    Tablo.TabloSablonYukle(Name + "TablosuMDI");
            }
        }
        private void FiltreSec()
        {
         //   var entity = (Filtre)ShowListForms<FilterListForm>.ShowDialogListForm(KartTuru.Filtre, _filtreId, BaseKartTuru, Tablo.GridControl);

            //if (entity == null) return;

            //_filtreId = entity.Id;
            //Tablo.ActiveFilterString = entity.FiltreMetni;
        }
        private void FormCaptionAyarla()
        {
            if (btnAktifPasifKartlar == null)
            {
                Listele();
                return;
            }

            if (AktifKartlariGoster)
            {
                btnAktifPasifKartlar.Caption = "Pasif Kartlar";
                Tablo.ViewCaption = Text;
            }
            else
            {
                btnAktifPasifKartlar.Caption = "Aktif Kartlar";
                Tablo.ViewCaption = Text + " - Pasif Kartlar";
            }

            Listele();
        }
        private void SelectEntity()
        {
            if (MultiSelect)
            {
                //Güncellenecek
            }
            else
            {
            //    SelectedEntity = Tablo.GetRow<BaseEntity>();
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        private void IslemTuruSec()
        {
            if (!IsMdiChild)
            {
                //Güncellenecek
                SelectEntity();
            }
            else
            {
                btnDuzelt.PerformClick();
            }

        }
        private void ButonGizleGoster()
        {
            btnSec.Visibility = AktifPasifButonGoster ? BarItemVisibility.Never : IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;

            //Yukarıdaki ifadenin açık hali
            //if (AktifPasifButonGoster || IsMdiChild)
            //{
            //    btnSec.Visibility = BarItemVisibility.Never;
            //}
            //else
            //{
            //    BarItemVisibility.Always;
            //}

            barSelect.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            barSelectComment.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            btnAktifPasifKartlar.Visibility = AktifPasifButonGoster ? BarItemVisibility.Always : !IsMdiChild ?  BarItemVisibility.Never : BarItemVisibility.Always;

            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }
        protected void ShowEditFormDefault(long id)
        {
            if (id <= 0) return;
            AktifKartlariGoster = true;
            FormCaptionAyarla();
        //    Tablo.RowFocus("Id", id);
        }
        protected virtual void DegiskenleriDoldur() { }
        protected virtual void ShowEditForm(long id)
        {
         //   var result = FormShow.ShowDialogEditForm(BaseKartTuru, id);
        //    ShowEditFormDefault(result);
        }
        protected virtual void EntityDelete()
        {
        //    var entity = Tablo.GetRow<BaseEntity>();
        //    if (entity == null) return;
        //    if (!((IBaseCommonBll)Bll).Delete(entity)) return;

        //    Tablo.DeleteSelectedRows();
        //    Tablo.RowFocus(Tablo.FocusedRowHandle);
        }
        protected virtual void Listele() { }
        protected virtual void Yazir()
        {
         //   TablePrintingFunctions.Yazdir(Tablo, Tablo.ViewCaption, MainForm.SubeAdi);
        }
        protected virtual void BagliKartAc() { }
        protected internal void Yukle()
        {
            Cursor.Current = Cursors.WaitCursor;

            DegiskenleriDoldur();
            EventsLoad();
            Navigator.NavigatableControl = Tablo.GridControl;

            Tablo.OptionsSelection.MultiSelect = MultiSelect;


            Listele();
            Cursor.Current = DefaultCursor;
            //Güncellenecek
        }


        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;


            if (e.Item == btnGonder)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item == btnStandartExcelDosyasi)
            {
         //       Tablo.TabloDisariAktar(DosyaTuru.ExcelStandart, e.Item.Caption, Text);
            }
            else if (e.Item == btnFormatliExcelDosyasi)
            {
         //       Tablo.TabloDisariAktar(DosyaTuru.ExcelFormatli, e.Item.Caption, Text);
            }
            else if (e.Item == btnFormatsizExcelDosyasi)
            {
         //       Tablo.TabloDisariAktar(DosyaTuru.ExcelFormatsiz, e.Item.Caption);
            }
            else if (e.Item == btnWordDosyasi)
            {
         //       Tablo.TabloDisariAktar(DosyaTuru.WordDosyasi, e.Item.Caption);
            }
            else if (e.Item == btnPDFDosyasi)
            {
         //       Tablo.TabloDisariAktar(DosyaTuru.PdfDosyasi, e.Item.Caption);
            }
            else if (e.Item == btnTxtDosyasi)
            {
        //        Tablo.TabloDisariAktar(DosyaTuru.TxtDosyasi, e.Item.Caption);
            }
            else if (e.Item == btnYeni)
            {
                //Yetki Kontrolü

                ShowEditForm(-1);
            }
            else if (e.Item == btnDuzelt)
            {
         //       ShowEditForm(Tablo.GetRowId());
            }
            else if (e.Item == btnSil)
            {
                //Yetki Kontrolü

                EntityDelete();
            }
            else if (e.Item == btnSec)
            {
                SelectEntity();
            }
            else if (e.Item == btnYenile)
            {
                Listele();
            }
            else if (e.Item == btnFiltrele)
            {
                FiltreSec();
            }
            else if (e.Item == btnKolonlar)
            {
                if (Tablo.CustomizationForm == null)
                {
                    Tablo.ShowCustomization();
                }
                else
                {
                    Tablo.HideCustomization();
                }
            }
            else if (e.Item == btnBagliKartlar)
            {
                BagliKartAc();
            }
            else if (e.Item == btnYazdir)
            {
                Yazir();
            }
            else if (e.Item == btnExit)
            {
                Close();
            }
            else if (e.Item == btnAktifPasifKartlar)
            {
                AktifKartlariGoster = !AktifKartlariGoster;
                FormCaptionAyarla();
            }


            Cursor.Current = DefaultCursor;
        }
        private void Tablo_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            IslemTuruSec();
            Cursor.Current = DefaultCursor;
        }
        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    IslemTuruSec();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
        private void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
        //    e.SagMenuGoster(sagMenu);
        }
        private void Tablo_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }
        private void Tablo_ColumnPositionChanged(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }
        private void Tablo_EndSorting(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }
        private void Tablo_FilterEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.FilterControlEventArgs e)
        {
        //    e.ShowFilterEditor = false;
        //    ShowEditForms<FilterEditForm>.ShowDialogEditForm(KartTuru.Filtre, _filtreId, BaseKartTuru, Tablo.GridControl);
        }
        private void Tablo_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Tablo.ActiveFilterString))
            {
                _filtreId = 0;
            }
        }
        private void BaseListForm_Shown(object sender, EventArgs e)
        {
            Tablo.Focus();
            ButonGizleGoster();
            SutunGizleGoster();
            if (IsMdiChild || SeciliGelecekId == null) return;
        //    Tablo.RowFocus("Id", SeciliGelecekId);
        }
        private void BaseListForm_Load(object sender, EventArgs e)
        {
            SablonYukle();
        }
        private void BaseListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (true)
            {
                SablonKaydet();
            }
        }
        private void BaseListForm_LocationChanged(object sender, EventArgs e)
        {
            if (!IsMdiChild)
            {
                _formSablonKayitEdilecek = true;
            }
        }
        private void BaseListForm_SizeChanged(object sender, EventArgs e)
        {
            if (!IsMdiChild)
            {
                _formSablonKayitEdilecek = true;
            }

        }

    }
}