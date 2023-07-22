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
using Prkn.UI.Win.Dokum.ModelBase;

namespace Prkn.UI.Win.Forms.Base
{
    public partial class BaseEditForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Variables
        private bool _formSablonKayitEdilecek;
        protected MyDataLayoutControl DataLayoutControl;
        protected MyDataLayoutControl[] DataLayoutControls;
        protected bool IsLoaded;
        protected bool KayitSonrasiFormuKapat = true;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected internal long Id;
        protected internal bool RefreshYapilacak; 
        #endregion


        public BaseEditForm()
        {
            InitializeComponent();
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
            SizeChanged     += BaseEditForm_SizeChanged;
            Load            += BaseEditForm_Load;
            FormClosing     += BaseEditForm_FormClosing;

            void ControlEvents(Control control)
            {
                control.KeyDown         += Control_KeyDown;
                control.GotFocus        += Control_GotFocus;
                control.Leave           += Control_Leave;

                switch (control)
                {
                    case FilterControl edt:
                        edt.FilterChanged           += Control_EditValueChanged;
                        break;

                    case ComboBoxEdit edt:
                        edt.EditValueChanged        += Control_SelectedValueChanged;
                        edt.SelectedValueChanged    += Control_SelectedValueChanged;
                        break;
                    //Case sıralaması önemli! MyButtonEdit=> baseEdit türemektedir.
                    case MyButtonEdit edt:
                        edt.IdChanged               += Control_IdChanged;
                        edt.EnabledChange           += Control_EnabledChange;
                        edt.ButtonClick             += Control_ButtonClick;
                        edt.DoubleClick             += Control_DoubleClick;
                        break;

                    case BaseEdit edt: //kontrol içindeki değişikliği yakalamak için editvalchanged ataması

                        edt.EditValueChanged        += Control_EditValueChanged;
                        break;
                }
            }

            //Layoutdaki konntrollere oluşturulan event lar eklenecek
            if(DataLayoutControls == null)
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

   
        private void EntityDelete()
        {
         //   if (!((IBaseCommonBll)Bll).Delete(OldEntity)) return;
            RefreshYapilacak = true;
            Close();
        }
        private void ButonGizleGoster()
        {
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }
        private void GeriAl()
        {
            //if (Messages.EvetSeciliEvetHayir("Değişiklikler geri alınacaktır. Onaylıyor musunuz?", "Geri Al Onay") != DialogResult.Yes) return;

            //if (BaseIslemTuru == IslemTuru.EntityUpdate)
            //    Yukle();
           // else
           //     Close();
        }
        private bool Kaydet(bool kapanis)
        {



            return false;
        }
        private void SablonYukle()
        {
          //  Name.FormSablonYukle(this);
        }
        private void FarkliKaydet()
        {
            //if (Messages.EvetSeciliEvetHayir("Bu filtre referans alınarak yeni bir filtre oluşturulacaktır. Onaylıyor musunuz?", "Kayıt Onayı") != DialogResult.Yes) return;

            //BaseIslemTuru = IslemTuru.EntityInsert;
            //Yukle();
            //if (Kaydet(true))
            //{
            //    Close();
            //}


        }
        protected void SablonKaydet()
        {
            //if (_formSablonKayitEdilecek)
            //{
            //    Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);
            //}
        }
        protected virtual void FiltreUygula() { }
        protected virtual void BaskiOnizleme() { }
        protected virtual void Yazdir() { }
        protected virtual void SecimYap(object sender) { }
        protected virtual bool EntityInsert()
        {
            return false; // ((IBaseGenelBll)Bll).Insert(CurrentEntity);
        }
        protected virtual bool EntityUpdate()
        {
            return false; //((IBaseGenelBll)Bll).Update(OldEntity, CurrentEntity);
        }
        protected virtual void NesneyiKontrollereBagla() { }
        protected virtual void GuncelNesneOlustur() { }
        protected internal virtual void Yukle() { }
        protected internal virtual IBaseEntity ReturnEntity() { return null; }
        protected internal virtual void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

         //   GeneralFunctions.ButtonEnabledStatus(btnNew, btnSave, btnUndo, btnDelete, OldEntity, CurrentEntity);
        }



        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.Item == btnNew)
            {
                // Yetki Kontrolü
            //    BaseIslemTuru = IslemTuru.EntityInsert;
                Yukle();
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
                EntityDelete();
            }
            else if (e.Item == btnApply)
            {
                //Yetki Kontrolü
                FiltreUygula();
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
            GuncelNesneOlustur();
            SablonYukle();
            ButonGizleGoster();
            //Id = BaseIslemTuru.IdOlustur(OldEntity); ilgili formlara eklendi. Burada ihtiyaç kalmadı.

            //Güncelleme Yapılacak
        }
        private void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
            if (btnSave.Visibility == BarItemVisibility.Never || !btnSave.Enabled) return;

            if (!Kaydet(true))
            {
                e.Cancel = true;
            }
        }
        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if(sender is MyButtonEdit edt)
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

            //if (type == typeof(MyButtonEdit) || type == typeof(MyGridView) || type == typeof(MyPictureEdit) || type == typeof(MyComboBoxEdit) || type == typeof(MyDateEdit))
            //{
            //    StatusBar_Shortcut.Visibility = BarItemVisibility.Always;
            //    StatusBar_ShortcutComment.Visibility = BarItemVisibility.Always;

            //    //StatusBar_Comment.Caption = ((IStatusBarComment)sender).StatusBarComment;
            //    //StatusBar_Shortcut.Caption = ((IStatusBarShortcut)sender).StatusBarShortcut;
            //    //StatusBar_ShortcutComment.Caption = ((IStatusBarShortcut)sender).StatusBarShortcutComment;
            //}
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
            GuncelNesneOlustur();
        }
        protected virtual void Control_SelectedValueChanged(object sender, EventArgs e) { }
        private void Control_IdChanged(object sender, IdChangedEventArgs e)
        {
            if (!IsLoaded) return;
            GuncelNesneOlustur();
        }
        protected virtual void Control_EnabledChange(object sender, EventArgs e)  { }
        private void Control_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SecimYap(sender);
        }
        private void Control_DoubleClick(object sender, EventArgs e)
        {
            SecimYap(sender);
        }



    }
}