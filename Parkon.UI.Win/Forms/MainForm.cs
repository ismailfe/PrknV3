using CefSharp;
using CefSharp.WinForms;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using Prkn.Common.Functions;
using Prkn.Common.Variables;
using Prkn.UI.Win.DBOrganizer;
using Prkn.UI.Win.Forms;
using Prkn.UI.Win.Forms.Base;
using Prkn.UI.Win.Forms.Deneme;
using Prkn.UI.Win.Forms.Project;
using Prkn.UI.Win.Functions;
using Prkn.UI.Win.Functions.Check;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Prkn.UI.Win
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        #region Form Methods
        public static StartupForm frm = new StartupForm();
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls         = false;
            CLS.MainForm                            = this;
            FirstStart.Baslangic();

            Yukle();

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            e.Cancel = true;

            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        public void APPCLOSE(bool AskMe)
        {
            if (AskMe)
            {
                DialogResult r = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "Gidiyorsun Galiba... :(", MessageBoxButtons.YesNo);

                if (r == DialogResult.Yes)
                {
                    ProgramParameters.MenuStatusSave(Name, accordionControl_MainMenu);
                    Environment.Exit(0);
                }
            }
            else
            {
                ProgramParameters.MenuStatusSave(Name, accordionControl_MainMenu);
                Environment.Exit(0);
            }
        }

        #endregion

        #region SKIN Change
        private void MainForm_StyleChanged(object sender, EventArgs e)
        {
            ProgramParameters.SkinSave(UserLookAndFeel.DefaultSkinName);
        }
        private void Default_StyleChanged(object sender, EventArgs e)
        {
            string NewSkinName = sender.ToString();
            if (sender.ToString().StartsWith("UseDefault;Skin: "))
            {
                NewSkinName = sender.ToString().Replace("UseDefault;Skin: ", string.Empty);
            }
            ProgramParameters.SkinSave(NewSkinName);
        }
        private void skinDropDownButtonItem1_ItemPress(object sender, ItemClickEventArgs e)
        {
            object objName = e.Item.Name;
            ProgramParameters.SkinSave(objName.ToString());
            this.LookAndFeel.ResetParentLookAndFeel();
        }
        #endregion

        private void Yukle()
        {
            UserLookAndFeel.Default.StyleChanged    += Default_StyleChanged;

            ControlEvents();
            VersiyonKontrolleri();

            System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();
            tmr.Tick += Tmr_Tick;
            tmr.Interval = 1000;
            tmr.Start();

        }
        void ControlEvents()
        {
            accordionControl_MainMenu.ElementClick      += new ElementClickEventHandler(Control_Button_Click);
            xtraTabbedMdiManager1.SelectedPageChanged   += XtraTabbedMdiManager1_SelectedPageChanged;
            xtraTabbedMdiManager1.PageRemoved           += XtraTabbedMdiManager1_PageRemoved;

            btnInfo.ItemClick                           += BtnInfo_ItemClick;
            btnExit.Click                               += BtnExit_Click;
            btnUserLogin.ItemClick                      += BtnUserLogin_ItemClick;
            btnNewVersionDownload.ItemClick             += BtnNewVersionDownload_ItemClick;
            btnDbStatus.ItemClick                       += BtnDbStatus_ItemClick;
       
            B_InternetCon.ItemClick                     += B_InternetCon_ItemClick;
            B_DBCon.ItemClick                           += B_DBCon_ItemClick;
            //B_DBOffline.Click                           += B_DBOffline_Click;
            //B_DBOffline.VisibleChanged                  += B_DBOffline_VisibleChanged;


            Cef.Initialize(new CefSettings());
            btnPrknWeb.ItemClick += BtnPrknWeb_ItemClick;
        }

        private void BtnPrknWeb_ItemClick(object sender, ItemClickEventArgs e)
        {
            PrknWebForm frm = new PrknWebForm();
            FormuMdiUzerindeAc(frm);
        }

        private void B_DBOffline_VisibleChanged(object sender, EventArgs e)
        {
            //btnRevOlustur.Enabled   = !B_DBOffline.Visible;
            //btnProjeOluştur.Enabled = !B_DBOffline.Visible;
        }







        #region Buttons & Choses
        private void B_DBCon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Check_InternetAndDBServerConn();
        }
        private void B_DBOffline_Click(object sender, EventArgs e)
        {
            Check_InternetAndDBServerConn();
        }
        private void BtnDbStatus_ItemClick(object sender, ItemClickEventArgs e)
        {
            Check_InternetAndDBServerConn();
            DBMirrorDataUpdate.FirstLoad(); // Butona basıldığında Tek seferlik update yap!
        }
        private void B_InternetCon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Check_InternetAndDBServerConn();
        }

        void Check_InternetAndDBServerConn()
        {
            Cursor.Current = Cursors.WaitCursor;
            Internet.Check();
            Internet.CheckDBSERVER();
            Cursor.Current = Cursors.Default;
        }
        private void XtraTabbedMdiManager1_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            if (xtraTabbedMdiManager1.Pages.Count > 0)
            {
                pictureMainBackground.SendToBack();
            }
            else
            {
                pictureMainBackground.BringToFront();
            }
        }
        private void XtraTabbedMdiManager1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (xtraTabbedMdiManager1.Pages.Count > 0)
            {
                pictureMainBackground.SendToBack();
            }
            else
            {
                pictureMainBackground.BringToFront();
            }
        }

        private void BtnUserLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserLoginForm Form_User_Login = new UserLoginForm();
            Form_User_Login.ShowDialog();
        }
        private void BtnNewVersionDownload_ItemClick(object sender, ItemClickEventArgs e)
        {
            Functions.Check.Update.Indir();
        }
        private void BtnInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
         //   VersionForm frm = new VersionForm();
        //    frm.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            APPCLOSE(true);
        }
        private void Control_Button_Click(object sender, ElementClickEventArgs e)
        {
            var obj = e.Element;
            var click = e.MouseButton;
            Cursor.Current = Cursors.WaitCursor;
            if (click == MouseButtons.Left)
            {
                //// KULLANICI
                if (obj == btnProfilYonetimi)
                {
                //    UserProfileForm frm = new UserProfileForm();
                //    FormuMdiUzerindeAc(frm);
                }
                else if (obj == btnOturumKapat)
                {
                    UserLoginForm Form_User_Login = new UserLoginForm();
                    Form_User_Login.ShowDialog();
                }
                else if(obj == btnDosyaSenk)
                {
                    ThirdPartyPrg.OpenGoodSync();
                }
                else if(obj == btnExcelApp)
                {
  
                    OfisExcel frm = new OfisExcel();
                    FormuMdiUzerindeAc(frm);
                }
                else if(obj == btnWordApp)
                {
                    OfisWord frm = new OfisWord();
                    FormuMdiUzerindeAc(frm);
                }
                // Proje
                else if (obj == btnProjeOluştur)
                {
                    ProjectCreateForm frm = new ProjectCreateForm();
                    FormuMdiUzerindeAc(frm);
                }
                //else if (obj == btnRevOlustur)
                //{
                //    RevCreateForm frm = new RevCreateForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                else if (obj == btnProjeSorgula)
                {
                    ProjectSearchForm frm = new ProjectSearchForm();
                    FormuMdiUzerindeAc(frm);
                }
                else if (obj == btnProjeListele)
                {
                    ProjectListForm frm = new ProjectListForm();
                    FormuMdiUzerindeAc(frm);
                }
                //else if (obj == btnUserSystemLog)
                //{
                //    UserSystemLogsForm frm = new UserSystemLogsForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnTakvim)
                //{
                //    UserScheduleForm frm = new UserScheduleForm();
                //    FormuMdiUzerindeAc(frm);
                //}

                //// Müşteri
                //else if (obj == btnMusteriDuzenle)
                //{
                //    CustomerForm frm = new CustomerForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnMusteriBolumDuzenle)
                //{
                //    CustomerSectionForm frm = new CustomerSectionForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnMusteriRehber)
                //{
                //    CustomerContactForm frm = new CustomerContactForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnMusteriTuru)
                //{
                //    CustomerTypeForm frm = new CustomerTypeForm();
                //    FormuMdiUzerindeAc(frm);
                //}

                //// Tedarikçi
                //else if (obj == btnTedarikciDuzenle)
                //{
                //    SupplierForm frm = new SupplierForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnTedarikciBolumDuzenle)
                //{
                //    SupplierSectionForm frm = new SupplierSectionForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnTedarikciRehber)
                //{
                //    SupplierContactForm frm = new SupplierContactForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnTedarikciTuru)
                //{
                //    SupplierTypeForm frm = new SupplierTypeForm();
                //    FormuMdiUzerindeAc(frm);
                //}

                //// YÖNETİCİ
                //else if (obj == btnDepartman)
                //{
                //    UserDepartmentForm frm = new UserDepartmentForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnTitle)
                //{
                //    TitleForm frm = new TitleForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnKeyword)
                //{
                //    KeywordForm frm = new KeywordForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnKullaniciYeni)
                //{
                //    UsersForm frm = new UsersForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnKullaniciEkranlari)
                //{
                //    UserScreenForm frm = new UserScreenForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnKullanıciYetkiSeviyeleri)
                //{
                //    UserAccessForm frm = new UserAccessForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnKullaniciYetkilendirme)
                //{
                //    UserAuthorizationForm frm = new UserAuthorizationForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnAdresBolge)
                //{
                //    ZoneForm frm = new ZoneForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnAdministrator)
                //{
                //    AdministratorForm frm = new AdministratorForm();
                //    FormuMdiUzerindeAc(frm);
                //}

                //// Stok
                //else if (obj == btnStokDepoBolgesi)
                //{
                //    StoreLocationForm frm = new StoreLocationForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnStokUrunGrubu)
                //{
                //    StoreProductGroupForm frm = new StoreProductGroupForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnStokUrunTuru)
                //{
                //    StoreProductTypeForm frm = new StoreProductTypeForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnStokUrunCikisAksiyon)
                //{
                //    StoreOutActionForm frm = new StoreOutActionForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnStokAdresAlan)
                //{
                //    StoreAddressZoneForm frm = new StoreAddressZoneForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnStokAdresSatir)
                //{
                //    StoreAddressRowForm frm = new StoreAddressRowForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnStokAdresSutun)
                //{
                //    StoreAddressColForm frm = new StoreAddressColForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnStokAdresPozisyon)
                //{
                //    StoreAddressPosForm frm = new StoreAddressPosForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnStokUrunMarka)
                //{
                //    StoreBrandForm frm = new StoreBrandForm();
                //    FormuMdiUzerindeAc(frm);
                //}



                //// Ayarlar
                //else if (obj == btnAyarlarKlasorYapisi)
                //{
                //    SettingsForm frm = new SettingsForm();
                //    FormuMdiUzerindeAc(frm);
                //}

                //// Görevler
                //else if (obj == btnGorevler)
                //{
                //    TaskForm frm = new TaskForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnGorevDurumAyarlari)
                //{
                //    TaskStatusForm frm = new TaskStatusForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnGorevlerOncelikAyarlari)
                //{
                //    TaskPriorityForm frm = new TaskPriorityForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnGorevOnEkAyarlari)
                //{
                //    TaskTypeForm frm = new TaskTypeForm();
                //    FormuMdiUzerindeAc(frm);
                //}

                //// Toplantı
                //else if (obj == btnToplantiDurumAyarlari)
                //{
                //    MeetingStatusForm frm = new MeetingStatusForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnToplantiTuruAyarlari)
                //{
                //    MeetingTypeForm frm = new MeetingTypeForm();
                //    FormuMdiUzerindeAc(frm);
                //}
                //else if (obj == btnToplantiNotlari)
                //{
                //    MeetingForm frm = new MeetingForm();
                //    FormuMdiUzerindeAc(frm);
                //}

                //else if (obj == btnTeklifOlustur)
                //{
                //    OfferCreateForm frm = new OfferCreateForm();
                //    FormuMdiUzerindeAc(frm);
                //}

                //else if (obj == btnTeklifTuru)
                //{
                //    OfferTypeForm frm = new OfferTypeForm();
                //    FormuMdiUzerindeAc(frm);
                //}

                //else if (obj == btnTeklifTalepTuru)
                //{
                //    OfferRequestTypeForm frm = new OfferRequestTypeForm();
                //    FormuMdiUzerindeAc(frm);
                //}

                //else if (obj == btnTeklifTalepKaynagi)
                //{
                //    OfferRequestSourceForm frm = new OfferRequestSourceForm();
                //    FormuMdiUzerindeAc(frm);
                //}

                //else if (obj == btnTeklifDurum)
                //{
                //    OfferStatusForm frm = new OfferStatusForm();
                //    FormuMdiUzerindeAc(frm);
                //}

                //else if (obj == btnTeklifListele)
                //{
                //    OfferListForm frm = new OfferListForm();
                //    FormuMdiUzerindeAc(frm);
                //}


                //else if (obj == btnTeklifDuzelt)
                //{
                //    OfferCloseForm frm = new OfferCloseForm();
                //    FormuMdiUzerindeAc(frm);
                //}

                //else if (obj == btnCurrency)
                //{
                //    CurrencyForm frm = new CurrencyForm();
                //    FormuMdiUzerindeAc(frm);
                //}
            }

            Cursor.Current = Cursors.Default;
        }
        public void FormuMdiUzerindeAc(Form frm)
        {
            bool IsOpened = false;

            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (item.Name == frm.Name)
                    {
                        xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                        IsOpened = true;
                        GC.SuppressFinalize(frm);
                        break;
                    }
                }
            }

            if (IsOpened) return;
            frm.MdiParent = this;
            frm.Show();
        }
        #endregion

        #region Functions
        private void Tmr_Tick(object sender, EventArgs e)
        {
            btnDateTime.Caption                 = DateTime.Now.ToString();
        }
        void LokalDbTempCheckCreate()
        {
         //   DbLocalTempFilling.MyStart(btnDbStatus);
        }
        void VersiyonKontrolleri()
        {
            Functions.Check.Update._newVersionButton = btnNewVersionDownload;
            Functions.Check.Update.VerCheck(ref btnNewVersionDownload);
            txtVersion.Text = "Version:" + Global.Version.Ver;
        }

        #endregion

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnNewVersionDownload_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }
    }
}
