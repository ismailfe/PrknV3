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
using Prkn.Common.Design.Controls;
using Prkn.Common.Design.Grid;
using DevExpress.XtraPrinting.Native;
using DevExpress.Utils.Extensions;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;
using Prkn.Common.Variables;
using Prkn.UI.Win.Functions;
using Prkn.Common.Enums;
using Prkn.Common.Message;
using Prkn.Common.Functions;
using Prkn.UI.Win.Functions;
using static Prkn.Common.Variables.Static;
using Prkn.UI.Win.Functions.Check;

namespace Prkn.UI.Win.Forms.Base
{
    public partial class BaseListEditForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Variables
        private bool _formSablonKayitEdilecek;
        private bool _tabloRowFocusDegisti;
        protected MyDataLayoutControl DataLayoutControl;
        protected MyDataLayoutControl[] DataLayoutControls;
        protected bool IsLoaded;
        protected bool KayitSonrasiFormuKapat = true;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected internal long Id;
        protected internal bool RefreshYapilacak;
        protected string[] PictureBoxIcindekiImgInfo = new string[2];
        protected UserScreen _userScreen;
        #endregion

        #region Variables - LIST
        protected bool _tabloSablonKayitEdilecek;
        protected internal GridView Tablo;
        protected ControlNavigator Navigator;
        protected object AktifData;
        protected long SeciliDataId;
        protected PictureSourceType PictureSource;
        #endregion
        public BaseListEditForm()
        {
            InitializeComponent();
            //Yukle();
            //Cursor.Current = Cursors.Default;
        }
        protected internal virtual void Yukle()
        {
            DataLayoutControl               = myDataLayoutControl;
            Tablo                           = baseTablo;
            Navigator                       = baseLongNavigator.Navigator;
            Navigator.NavigatableControl    = Tablo.GridControl;

            EventsLoadForList();

            UserAuthorization();
            InternetCheckForSave();
        }

        #region EDIT Bölümü
        protected void InternetCheckForSave()
        {
            if (!Internet.InternetOK)
            {
                foreach (var item in ribbonControl.Items)
                {
                    switch (item)
                    {
                        case BarItem button:
                            if (item == btnSave || item == btnSaveAs || item == btnNew || item == btnDelete)
                            {
                                button.Enabled = false;
                            }
                            break;
                    }
                }
            }
        }
        protected void UserAuthorization()
        {
            var Check = MyAuthorization.Control(_userScreen);
            StatusUserAccess.Caption = Check.ToString();
            switch (Check)
            {
                case UserAccess.Gizle:
                    break;
                case UserAccess.Full:
                    //btnSave.Enabled         = true;
                    //btnSaveAs.Enabled       = true;
                    //btnNew.Enabled          = true;
                    //btnDelete.Enabled       = true;
                    break;
                case UserAccess.Oku:
                    btnSave.Enabled         = false;
                    btnSaveAs.Enabled       = false;
                    btnNew.Enabled          = false;
                    btnDelete.Enabled       = false;
                    break;
                case UserAccess.OkuYaz:
                    //btnSave.Enabled         = true;
                    //btnSaveAs.Enabled       = true;
                    //btnNew.Enabled          = true;
                    btnDelete.Enabled       = false;
                    break;
                case UserAccess.SadeceDuzelt:
                    //btnSave.Enabled         = true;
                    btnSaveAs.Enabled       = false;
                    btnNew.Enabled          = false;
                    btnDelete.Enabled       = false;
                    break;
                case UserAccess.SadeceYeniEkle:
                    btnSave.Enabled         = false;
                    //btnSaveAs.Enabled       = true;
                    //btnNew.Enabled          = true;
                    btnDelete.Enabled       = false;
                    break;
                default:
                    break;
            }
            
        }

        protected void EventsLoad()
        {
            //Button Events
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarItem button:
                        button.ItemClick += Button_ItemClick; ;
                        break;
                }
            }

            //Form Events
            LocationChanged += BaseEditForm_LocationChanged;
            SizeChanged += BaseEditForm_SizeChanged;
            Load += BaseEditForm_Load;
            FormClosing += BaseEditForm_FormClosing;

            void ControlEvents(Control control)
            {
                control.KeyDown     += Control_KeyDown;
                control.GotFocus    += Control_GotFocus;
                control.Leave       += Control_Leave;

                switch (control)
                {
                    case PictureEdit edt:
                        edt.EditValueChanged        += Control_EditValueChanged;
                        
                        break;
                    case RatingControl edt:
                        edt.EditValueChanged        += Control_EditValueChanged;

                        break;
                    case FilterControl edt:
                        edt.FilterChanged           += Control_EditValueChanged;

                        break;
                    case MyComboBoxEdit edt:
                        edt.EditValueChanged        += Control_EditValueChanged; // Control_SelectedValueChanged;
                        edt.SelectedValueChanged    += Control_EditValueChanged; // Control_SelectedValueChanged;
                        break;
                    //Case sıralaması önemli! MyButtonEdit=> baseEdit türemektedir.
                    case MyButtonEdit edt:
                        edt.IdChanged               += Control_IdChanged;
                        edt.EnabledChange           += Control_EnabledChange;
                        edt.ButtonClick             += Control_ButtonClick;
                        edt.DoubleClick             += Control_DoubleClick;
                        break;
                    case BaseEdit edt: //kontrol içindeki değişikliği yakalamak için editvalchanged ataması

                        edt.EditValueChanged += Control_EditValueChanged;
                        break;
                }
            }

            //Layoutdaki konntrollere oluşturulan event lar eklenecek
            if (DataLayoutControls == null)
            {
                if (DataLayoutControl == null) return;

                foreach (Control ctrl in DataLayoutControl.Controls)
                {
                    ControlEvents(ctrl);
                }
            }
            else
            {
                foreach (var layout in DataLayoutControls)
                {
                    foreach (Control ctrl in layout.Controls)
                    {
                        ControlEvents(ctrl);
                    }
                }
            }
        }


        #region EDIT - Buton Fonksiyonları
        private void YeniEkle()
        {
            var Cevap = Messages.TemizleMesaj();

            switch (Cevap)
            {
                case DialogResult.Yes:
                    if (DataLayoutControl != null)
                    {
                        foreach (var item in DataLayoutControl.Controls)
                        {
                            if (item.GetType() == typeof(MyTextEdit))
                            {
                                ((MyTextEdit)item).Text = "";
                            }
                            if (item.GetType() == typeof(MyMemoEdit))
                            {
                                ((MyMemoEdit)item).Text = "";
                            }
                            if (item.GetType() == typeof(PictureEdit))
                            {
                                ((PictureEdit)item).Image = null;
                                PictureBoxIcindekiImgInfo[0] = "";
                                PictureBoxIcindekiImgInfo[1] = "";
                            }
                            if (item.GetType() == typeof(RatingControl))
                            {
                                ((RatingControl)item).EditValue = 4;
                            }
                            if (item.GetType() == typeof(MyComboBoxEdit))
                            {
                                ((MyComboBoxEdit)item).EditValue = "";
                            }
                        }
                    }
                    SeciliDataId = 0;
                    AktifData = null;
                    ButonEnabledDurumu(ButonDurumTuru.New);
                    break;
                case DialogResult.No:
                    break;
            }
        }
        private bool Kaydet(bool kapanis)
        {
            var Cevap = Messages.KayitMesaj();


            switch (Cevap)
            {
                case DialogResult.Yes:
                    EntityUpdate();
                    break;
                case DialogResult.No:


                    break;
            }

            return false;
        }
        private bool FarkliKaydet()
        {
            var Cevap = Messages.FarkliKayitMesaj();

            switch (Cevap)
            {
                case DialogResult.Yes:
                    EntityInsert();
                    break;
                case DialogResult.No:


                    break;
            }

            return false;
        }
        private void Sil()
        {
            var Cevap = Messages.SilMesaj("ekrandaki veri");

            switch (Cevap)
            {
                case DialogResult.Yes:
                    EntityDelete();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        protected virtual void EntityInsert() { }
        protected virtual void EntityUpdate() { }
        protected virtual void EntityDelete() { }
        //Print Yaparken Gerekli olan Butonlar
        protected virtual void BaskiOnizleme() { }
        protected virtual void Yazdir() { }
        protected virtual void SecimYap(object sender) { }
        #endregion

        #region EDIT - Fonksiyonlar
        private void ButonGizleGoster()
        {
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }
        protected internal virtual void ButonEnabledDurumu(ButonDurumTuru durum)
        {
            if (!IsLoaded) return;
            ButtonEnabledStatus(durum, btnNew, btnSave, btnSaveAs, btnUndo, btnDelete);
            UserAuthorization();
        }
        private void ButtonEnabledStatus(ButonDurumTuru Durum, BarButtonItem btnNew, BarButtonItem btnSave, BarButtonItem btnSaveAs, BarButtonItem btnUndo, BarButtonItem btnDelete, object[] Old = null, object[] New = null)
        {

            if (Durum == ButonDurumTuru.New)
            {
                bool butonEnabledStatus = false;
                btnSave.Enabled         = butonEnabledStatus;
                btnSaveAs.Enabled       = butonEnabledStatus;
                btnUndo.Enabled         = butonEnabledStatus;
                btnNew.Enabled          = butonEnabledStatus;
                btnDelete.Enabled       = butonEnabledStatus;
            }
            else if (Durum == ButonDurumTuru.Update)
            {
                bool butonEnabledStatus = false;
                btnSave.Enabled         = butonEnabledStatus;
                btnSaveAs.Enabled       = butonEnabledStatus;
                btnUndo.Enabled         = butonEnabledStatus;
                btnDelete.Enabled       = butonEnabledStatus;

                btnNew.Enabled          = !butonEnabledStatus;

            }
            else if (Durum == ButonDurumTuru.RowFocus)
            {
                bool butonEnabledStatus = false;
                btnSave.Enabled         = butonEnabledStatus;
                btnSaveAs.Enabled       = butonEnabledStatus;
                btnUndo.Enabled         = butonEnabledStatus;
                btnDelete.Enabled       = !butonEnabledStatus;
                btnNew.Enabled          = !butonEnabledStatus;
            }
            else if (Durum == ButonDurumTuru.ValueChange)
            {
                bool butonEnabledStatus = true;
                btnSave.Enabled         = butonEnabledStatus;
                btnSaveAs.Enabled       = butonEnabledStatus;
                btnUndo.Enabled         = butonEnabledStatus;

                if (SeciliDataId > 0)
                {
                    btnDelete.Enabled = butonEnabledStatus;
                }
               else
                {
                    btnDelete.Enabled = !butonEnabledStatus;
                }

                btnNew.Enabled          = !butonEnabledStatus;
            }


        }

        #region Sablon Fonksiyonları
        private void SablonYukle()
        {
            Name.FormSablonYukle(this);
        }
        protected void SablonKaydet()
        {
            if (_formSablonKayitEdilecek)
            {
                Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);
            }
        }
        #endregion

        #endregion

        #region EDIT - Events Ribbon Button / Form 
        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.Item == btnNew)
            {
                // Yetki Kontrolü
                YeniEkle();
            }
            else if (e.Item == btnSave)
            {
                Kaydet(false);
            }
            else if (e.Item == btnSaveAs)
            {
                //Yetki Kontrolü 

                FarkliKaydet();
            }
            else if (e.Item == btnUndo)
            {
                GeriAl();
            }
            else if (e.Item == btnDelete)
            {
                //Yetki Kontrolü
                Sil();
            }
            else if (e.Item == btnApply)
            {
                //Yetki Kontrolü

            }
            else if (e.Item == btnPrint)
            {
                //Yetki Kontrolü
                Yazdir();
            }
            else if (e.Item == btnPreviewPrint)
            {
                //Yetki Kontrolü
                BaskiOnizleme();
            }
            else if (e.Item == btnExit)
            {
                Close();
                //this.DialogResult = DialogResult.Cancel;
            }

            Cursor.Current = Cursors.Default;
        }
        private void BaseEditForm_LocationChanged(object sender, EventArgs e)
        {
            _formSablonKayitEdilecek = true;
        }
        private void BaseEditForm_SizeChanged(object sender, EventArgs e)
        {
            _formSablonKayitEdilecek = true;
        }
        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            IsLoaded = true;
            //GuncelNesneOlustur();
            SablonYukle();
            SablonYukleList();
            ButonGizleGoster();
            ButtonEnabledStatus(ButonDurumTuru.New, btnNew, btnSave, btnSaveAs, btnUndo, btnDelete);
        }
        private void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
            SablonKaydetList();
        }

        #endregion

        #region EDIT - Events Control

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if (sender is MyButtonEdit edt)
            {
                switch (e.KeyCode)
                {
                    case Keys.Delete when e.Control && e.Shift:
                        edt.Id = null;
                        edt.EditValue = null;
                        break;

                    case Keys.F4:
                    case Keys.Down when e.Modifiers == Keys.Alt:
                        SecimYap(edt);
                        break;
                }
            }
        }
        private void Control_GotFocus(object sender, EventArgs e)
        {
            var type = sender.GetType();

            if (type == typeof(MyButtonEdit) || type == typeof(MyGridView) || type == typeof(MyPictureEdit) || type == typeof(MyComboBoxEdit) || type == typeof(MyDateEdit))
            {
                StatusBar_Shortcut.Visibility = BarItemVisibility.Always;
                StatusBar_ShortcutComment.Visibility = BarItemVisibility.Always;

                //StatusBar_Comment.Caption = ((IStatusBarComment)sender).StatusBarComment;
                //StatusBar_Shortcut.Caption = ((IStatusBarShortcut)sender).StatusBarShortcut;
                //StatusBar_ShortcutComment.Caption = ((IStatusBarShortcut)sender).StatusBarShortcutComment;
            }
            //else if (sender is IStatusBarComment)
            //{
            //    StatusBar_Comment.Caption = ((IStatusBarComment)sender).StatusBarComment;
            //}
        }
        private void Control_Leave(object sender, EventArgs e)
        {
            StatusBar_Shortcut.Visibility = BarItemVisibility.Never;
            StatusBar_ShortcutComment.Visibility = BarItemVisibility.Never;
        }
        private void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;
            if (_tabloRowFocusDegisti)
            {
                _tabloRowFocusDegisti = false;
                return;
            }
            else
            {
                ButonEnabledDurumu(ButonDurumTuru.ValueChange);
            }
        }
        private void Control_IdChanged(object sender, IdChangedEventArgs e)
        {
            if (!IsLoaded) return;
            if (_tabloRowFocusDegisti)
            {
                _tabloRowFocusDegisti = false;
                return;
            }
            else
            {
                ButonEnabledDurumu(ButonDurumTuru.ValueChange);
            }
        }
        protected virtual void Control_SelectedValueChanged(object sender, EventArgs e) { }
        protected virtual void Control_EnabledChange(object sender, EventArgs e) { }
        private void Control_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SecimYap(sender);
        }
        private void Control_DoubleClick(object sender, EventArgs e)
        {
            SecimYap(sender);
        }

        #endregion

        #endregion

        #region LIST Bölümü
        protected void EventsLoadForList()
        {
            //Button Events
            foreach (var item in ribbonControlList.Items)
            {
                switch (item)
                {
                    case BarItem button:
                        button.ItemClick += ButtonList_ItemClick;
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
            Tablo.FocusedRowChanged += Tablo_FocusedRowChanged;
        }
        private void ButtonList_ItemClick(object sender, ItemClickEventArgs e)
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
                Tablo.TabloDisariAktar(DosyaTuru.ExcelStandart, e.Item.Caption, Text);
            }
            else if (e.Item == btnFormatliExcelDosyasi)
            {
                Tablo.TabloDisariAktar(DosyaTuru.ExcelFormatli, e.Item.Caption, Text);
            }
            else if (e.Item == btnFormatsizExcelDosyasi)
            {
                Tablo.TabloDisariAktar(DosyaTuru.ExcelFormatsiz, e.Item.Caption);
            }
            else if (e.Item == btnWordDosyasi)
            {
                Tablo.TabloDisariAktar(DosyaTuru.WordDosyasi, e.Item.Caption);
            }
            else if (e.Item == btnPDFDosyasi)
            {
                Tablo.TabloDisariAktar(DosyaTuru.PdfDosyasi, e.Item.Caption);
            }
            else if (e.Item == btnTxtDosyasi)
            {
                Tablo.TabloDisariAktar(DosyaTuru.TxtDosyasi, e.Item.Caption);
            }
            else if (e.Item == btnYeni)
            {
                //Yetki Kontrolü

                ShowEditFormList(-1);
            }
            else if (e.Item == btnDuzelt)
            {
                //       ShowEditForm(Tablo.GetRowId());
            }
            else if (e.Item == btnSil)
            {
                //Yetki Kontrolü

                EntityDeleteList();
            }
            else if (e.Item == btnSec)
            {
                SelectEntityList();
            }
            else if (e.Item == btnYenile)
            {
                ListeRefresh();
            }
            else if (e.Item == btnFiltrele)
            {
                FiltreSecList();
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
                BagliKartAcList();
            }
            else if (e.Item == btnYazdir)
            {
                YazirList();
            }
            else if (e.Item == btnExit)
            {
                Close();
            }
            else if (e.Item == btnAktifPasifKartlar)
            {
                //  AktifKartlariGoster = !AktifKartlariGoster;
                //FormCaptionAyarlaList();
            }


            Cursor.Current = DefaultCursor;
        }

        #region LIST - Fonksiyon
        private void SutunGizleGoster()
        {

        }
        private void SablonKaydetList()
        {
            //if (_formSablonKayitEdilecek)
            //{
            //    //    Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);
            //}

            if (_tabloSablonKayitEdilecek)
            {
                Tablo.TabloSablonKaydet(Name + "Tablosu");
            }
        }
        private void SablonYukleList()
        {
            Tablo.TabloSablonYukle(Name + "Tablosu");
        }
        private void FiltreSecList()
        {
            //var entity = (Filtre)ShowListForms<FilterListForm>.ShowDialogListForm(KartTuru.Filtre, _filtreId, BaseKartTuru, Tablo.GridControl);

            //if (entity == null) return;

            //_filtreId = entity.Id;
            //Tablo.ActiveFilterString = entity.FiltreMetni;
        }
        private void SelectEntityList()
        {
            //if (MultiSelect)
            //{
            //    //Güncellenecek
            //}
            //else
            //{
            //    //    SelectedEntity = Tablo.GetRow<BaseEntity>();
            //}

            DialogResult = DialogResult.OK;
            Close();
        }
        private void IslemTuruSecList()
        {
            //if (!IsMdiChild)
            //{
            //    //Güncellenecek
            //    SelectEntity();
            //}
            //else
            //{
            //    btnDuzelt.PerformClick();
            //}

        }
        private void ButonGizleGosterList()
        {
            //  //  btnSec.Visibility = AktifPasifButonGoster ? BarItemVisibility.Never : IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;

            //    //Yukarıdaki ifadenin açık hali
            //    //if (AktifPasifButonGoster || IsMdiChild)
            //    //{
            //    //    btnSec.Visibility = BarItemVisibility.Never;
            //    //}
            //    //else
            //    //{
            //    //    BarItemVisibility.Always;
            //    //}

            //    barSelect.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            //    barSelectComment.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            ////    btnAktifPasifKartlar.Visibility = AktifPasifButonGoster ? BarItemVisibility.Always : !IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;

            //    ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            //    HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }
        protected void ShowEditFormDefaultList(long id)
        {
            //   if (id <= 0) return;
            //   AktifKartlariGoster = true;
            //   FormCaptionAyarla();
            //    Tablo.RowFocus("Id", id);
        }
        protected virtual void DegiskenleriDoldurList() { }
        protected virtual void ShowEditFormList(long id)
        {
            //   var result = FormShow.ShowDialogEditForm(BaseKartTuru, id);
            //    ShowEditFormDefault(result);
        }
        protected virtual void EntityDeleteList()
        {
            //    var entity = Tablo.GetRow<BaseEntity>();
            //    if (entity == null) return;
            //    if (!((IBaseCommonBll)Bll).Delete(entity)) return;

            //    Tablo.DeleteSelectedRows();
            //    Tablo.RowFocus(Tablo.FocusedRowHandle);
        }
        protected virtual void ListeRefresh() { }
        protected virtual void YazirList()
        {
            TablePrintingFunctions.Yazdir(Tablo, Tablo.ViewCaption, "");
        }
        protected virtual void BagliKartAcList() { }
        protected internal void YukleList()
        {
            Cursor.Current = Cursors.WaitCursor;

            Cursor.Current = DefaultCursor;

        }
        //string FieldNameBul(string txt)
        //{
        //    return txt.Replace("txt", "");
        //}
        #endregion

        #region LIST - Tablo Events
        private void GeriAl()
        {
            for (int i = 0; i < Repo.Count; i++)
            {
                for (int j = 0; j < DataLayoutControl.Controls.Count; j++)
                {
                    var Ad = Repo[i].ControlName;
                    if (DataLayoutControl.Controls[j].Name == Ad)
                    {
                        DataLayoutControl.Controls[j].Text = Repo[i].Value;
                    }
                }
            }

            ButonEnabledDurumu(ButonDurumTuru.Update);
        }
        protected virtual void TableToPic(int inx, string ad) { }


        class DataRepo
        {
            public string ControlName { get; set; }
            public string Value { get; set; }
        }
        List<DataRepo> Repo = new List<DataRepo>();

        private void Tablo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var SecilenRowIndex = Tablo.GetSelectedRows();

            Repo.Clear();
            try
            {
                for (int i = 0; i < Tablo.Columns.Count; i++)
                {
                    var Ad = Tablo.Columns[i].FieldName;

                    for (int j = 0; j < DataLayoutControl.Controls.Count; j++)
                    {

                        if (GeneralFunctions.ControlNameToFieldName(DataLayoutControl.Controls[j].Name) == Ad)
                        {

                            if (DataLayoutControl.Controls[j].Name.StartsWith("rating"))//rating = control prefix
                            {
                                ((RatingControl)DataLayoutControl.Controls[j]).EditValue = Tablo.GetRowCellDisplayText(SecilenRowIndex[0], Ad);
                            }

                            else if (DataLayoutControl.Controls[j].Name.StartsWith("pic")) //Pic = Table Column Name 
                            {
                                TableToPic(SecilenRowIndex[0], "Pic");
                            }

                            else if (typeof(MyComboBoxEdit) == DataLayoutControl.Controls[j].GetType())
                            {

                                if (int.TryParse(Tablo.GetRowCellDisplayText(SecilenRowIndex[0], Ad), out int idx))
                                {
                                    var ComboBoxList = ((MyComboBoxEdit)DataLayoutControl.Controls[j]).Properties.Items.Cast<ComboboxItem>().ToList();
                                    var FindItemResult = ComboBoxList.Where(X => X.Value.ToString() == idx.ToString()).FirstOrDefault();

                                    ((MyComboBoxEdit)DataLayoutControl.Controls[j]).SelectedItem = FindItemResult;
                                }
                                else
                                {
                                    ((MyComboBoxEdit)DataLayoutControl.Controls[j]).SelectedIndex = -1;
                                }

                            }
                            else
                            {
                                DataLayoutControl.Controls[j].Text = Tablo.GetRowCellDisplayText(SecilenRowIndex[0], Ad);
                            }

                            DataRepo r = new DataRepo();
                            r.ControlName = DataLayoutControl.Controls[j].Name;
                            r.Value = Tablo.GetRowCellDisplayText(SecilenRowIndex[0], Ad);
                            Repo.Add(r);

                            _tabloRowFocusDegisti = true;
                        }

                    }
                }

                AktifData = Tablo.GetRow(SecilenRowIndex[0]);
                ButonEnabledDurumu(ButonDurumTuru.RowFocus);

                _tabloRowFocusDegisti = false;

            }
            catch (Exception HATA)
            {

            }
        }
        private void Tablo_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Cursor.Current = DefaultCursor;
        }
        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
        private void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            //var a = Tablo.GetSelectedRows();
            ////var b = Tablo.GetRowCellDisplayText(a[0], "Code");
            ////var c =
            //txtCode.Text = Tablo.GetRowCellDisplayText(a[0], "Code");
            //txtName.Text = Tablo.GetRowCellDisplayText(a[0], "Name");
            ////e.SagMenuGoster(sagMenu);
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
            // e.ShowFilterEditor = false;
            // ShowEditForms<FilterEditForm>.ShowDialogEditForm(KartTuru.Filtre, _filtreId, BaseKartTuru, Tablo.GridControl);
        }
        private void Tablo_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Tablo.ActiveFilterString))
            {
                //    _filtreId = 0;
            }
        }

        #endregion

        #endregion
    }
}