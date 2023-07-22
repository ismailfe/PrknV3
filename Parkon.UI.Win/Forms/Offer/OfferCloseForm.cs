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
using Emikon.Parkon.UI.Win.Forms.Base;
using Emikon.Parkon.Common.Enums;
using Emikon.Parkon.Common.Design.Grid;
using DevExpress.XtraGrid.Columns;
using Emikon.Model;
using static Emikon.Parkon.Common.Variables.Static;
using Emikon.Parkon.Bll.Offer;
using Emikon.Parkon.Bll.Customer;
using Emikon.Parkon.Common.Functions;
using Emikon.Parkon.Common.Design.Controls;
using Emikon.Parkon.Common.Generate;
using Emikon.Parkon.Common.Variables;
using System.Threading;
using Emikon.Parkon.UI.Win.Forms.General;
using Emikon.Parkon.Bll.General;
using System.IO;

namespace Emikon.Parkon.UI.Win.Forms.Offer
{
    public partial class OfferCloseForm : BaseListEditFreeLayoutForm, IDisposable
    {
        //        private UserAccess SayfaYetkisi;
        //        private long _selectedCustomerId;
        //        private long _selectedCustomerSectionId;
        //        private long _selectedCustomerContactId;

        //        private long _selectedOfferId;
        //        private long _selectedOfferTypeId;
        //        private long _selectedOfferRequestSourceId;
        //        private long _selectedOfferRequestTypeId;
        //        private long _selectedOfferStatusId;

        //        private long _selectedModeId;
        //        private long _selectedCurrencyId;

        //        private bool _teklifDurumuAcik = true;

        //        private Model.Offers _selectedOffer;

        //        List<Model.Customers> _customers;
        //        List<Model.Customer_Section> _customer_Section;
        //        List<Model.Customer_Contact> _customer_Contact;

        //        List<Model.Offers> _offers;
        //        List<Model.Offer_Type> _offer_Type;
        //        List<Model.Offer_RequestSource> _offer_RequestSource;
        //        List<Model.Offer_RequestType> _offer_RequestType;
        //        List<Model.Offer_Status> _offer_Status;
        //        List<Model.Currency> _currency;
        //        //List<OfferBll.ModelDataMode> _mode;

                public OfferCloseForm()
                {
        //            _userScreen         = UserScreen.TeklifDuzelt;
        //            SayfaYetkisi        = MyAuthorization.Control(_userScreen);
        //            Yukle();

                   InitializeComponent();
        //            DataLayoutControl               = myDataLayoutControl1;
        //            Tablo                           = baseTablo;
        //            Navigator.NavigatableControl    = Tablo.GridControl;

        //            Text                    = "Teklif Düzenleme Listesi";
        //            Tablo.ViewCaption       = Text;

        //            EventsLoad();           // Ribbon
        //            EventsLoadForList();    // Ribbon

        //            LayoutEvents();
        //            GetListData();
        //            ListeRefresh();

        //            LayoutControllerEnableDisable(SayfaYetkisi);
                }
        //        void LayoutEvents()
        //        {
        //            btnUpdate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        //            //btnSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        //            //btnUndo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        //            btnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        //            btnSaveAs.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        //            btnNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

        //            //txtMode.SelectedValueChanged                += TxtMode_SelectedValueChanged;

        //            txtCustomerId.SelectedValueChanged          += TxtCustomerId_SelectedValueChanged;
        //            txtCustomerSectionId.SelectedValueChanged   += TxtCustomerSectionId_SelectedValueChanged;
        //            txtCustomerContactId.SelectedValueChanged   += TxtCustomerContactId_SelectedValueChanged;

        //            txtOfferRequestTypeId.SelectedValueChanged      += TxtOfferRequestTypeId_SelectedValueChanged;
        //            txtOfferRequestSourceId.SelectedValueChanged    += TxtOfferRequestSourceId_SelectedValueChanged;
        //            txtOfferStatusId.EditValueChanged += TxtOfferStatusId_EditValueChanged;
        //            txtOfferTypeId.SelectedValueChanged             += TxtOfferTypeId_SelectedValueChanged;
        //            //txtOfferId.SelectedValueChanged                 += TxtOfferId_SelectedValueChanged;


        //            btnCodeCopyToBoard.Click += BtnCodeCopyToBoard_Click;
        //            //btnRefreshAllCode.Click += BtnRefreshAllCode_Click;

        //            //txtOfferId.EditValueChanged += TxtOfferId_EditValueChanged;

        //            txtCurrencyId.EditValueChanged += TxtCurrencyId_EditValueChanged;

        //            txtKeyword.ValidateToken += GeneralFunctions.Keywords_ValidateToken;

        //            btnKlasorAc.Click += BtnKlasorAc_Click;

        //            baseTablo.RowClick += BaseTablo_RowClick;
        //        }

        //        private void BaseTablo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        //        {
        //            GetOfferDirectoryPath();
        //        }
        //        private void BtnKlasorAc_Click(object sender, EventArgs e)
        //        {
        //            OpenFolder(txtOfferDirectory.Text);
        //        }
        //        private void BtnRefreshAllCode_Click(object sender, EventArgs e)
        //        {
        //            Cursor = Cursors.WaitCursor;
        //            GenerateCodes();
        //            Cursor = Cursors.Default;
        //        }
        //        private void BtnCodeCopyToBoard_Click(object sender, EventArgs e)
        //        {
        //            if (string.IsNullOrEmpty(txtCode.Text) && string.IsNullOrEmpty(txtVerCode.Text))
        //            {
        //                MessageBox.Show("Kodlar oluşturulmamış, kodları oluşturup tekrar deneyin.");
        //                return;
        //            }

        //            Cursor = Cursors.WaitCursor;

        //            var _code = txtCode.Text + "" + txtVerCode.Text;
        //            Clipboard.SetText(_code);

        //            Thread.Sleep(300);

        //            Cursor = Cursors.Default;
        //        }

        //        private void TxtCurrencyId_EditValueChanged(object sender, EventArgs e)
        //        {
        //            if (((LookUpEdit)sender).EditValue != null)
        //            {
        //                _selectedCurrencyId = (long)((LookUpEdit)sender).EditValue;
        //                txtCurrencyCopy1.Text = ((LookUpEdit)sender).Text;
        //                txtCurrencyCopy2.Text = ((LookUpEdit)sender).Text;
        //            }
        //        }
        //        private void TxtOfferId_EditValueChanged(object sender, EventArgs e)
        //        {
        //            if(((LookUpEdit)sender).EditValue != null)
        //            {
        //                _selectedOfferId = (long)((LookUpEdit)sender).EditValue;
        //                GetSelectedOffer();
        //                GenerateCodes();
        //            }
        //        }
        //        private void TxtMode_SelectedValueChanged(object sender, EventArgs e)
        //        {
        //            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
        //            _selectedModeId = 0;
        //            if (senderSelectItem != null && senderSelectItem != "")
        //            {
        //                var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
        //                long.TryParse(senderSelectValue.ToString(), out _selectedModeId);

        //                if (((MyComboBoxEdit)sender).Name != null)
        //                {
        //                }
        //            }

        //            ClearCodes();
        //            LayoutControllerEnableDisable(SayfaYetkisi);
        //        }
        //        private void TxtCustomerId_SelectedValueChanged(object sender, EventArgs e)
        //        {
        //            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
        //            _selectedCustomerId = 0;
        //            if (senderSelectItem != null && senderSelectItem != "")
        //            {
        //                var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
        //                long.TryParse(senderSelectValue.ToString(), out _selectedCustomerId);

        //                if (((MyComboBoxEdit)sender).Name != null)
        //                {
        //                }

        //                _selectedCustomerContactId = 0;
        //                _selectedCustomerSectionId = 0;

        //                ComboBoxCustomerSectionData(_selectedCustomerId);
        //                ComboBoxCustomerContactData(_selectedCustomerId);
        //            }

        //            LayoutControllerEnableDisable(SayfaYetkisi);
        //            //ComboBoxCheckAndListRefresh();
        //        }
        //        private void TxtCustomerContactId_SelectedValueChanged(object sender, EventArgs e)
        //        {
        //            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
        //            _selectedCustomerContactId = 0;
        //            if (senderSelectItem != null && senderSelectItem != "")
        //            {
        //                var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
        //                long.TryParse(senderSelectValue.ToString(), out _selectedCustomerContactId);

        //                if (((MyComboBoxEdit)sender).Name != null)
        //                {
        //                }
        //            }
        //        }
        //        private void TxtCustomerSectionId_SelectedValueChanged(object sender, EventArgs e)
        //        {
        //            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
        //            _selectedCustomerSectionId = 0;
        //            if (senderSelectItem != null && senderSelectItem != "")
        //            {
        //                var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
        //                long.TryParse(senderSelectValue.ToString(), out _selectedCustomerSectionId);

        //                if (((MyComboBoxEdit)sender).Name != null)
        //                {
        //                }
        //            }
        //        }
        //        private void TxtOfferTypeId_SelectedValueChanged(object sender, EventArgs e)
        //        {
        //            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
        //            _selectedOfferTypeId = 0;
        //            if (senderSelectItem != null && senderSelectItem != "")
        //            {
        //                var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
        //                long.TryParse(senderSelectValue.ToString(), out _selectedOfferTypeId);

        //                if (((MyComboBoxEdit)sender).Name != null)
        //                {
        //                }
        //            }
        //        }
        //        private void TxtOfferStatusId_EditValueChanged(object sender, EventArgs e)
        //        {
        //            if (((LookUpEdit)sender).EditValue != null)
        //            {
        //                _selectedOfferStatusId = (long)((LookUpEdit)sender).EditValue;
        //                object data = ((LookUpEdit)sender).GetSelectedDataRow();
        //                if (data.GetType().GetProperty("Code").GetValue(data).ToString() == "KAPALI")
        //                {
        //                    _teklifDurumuAcik = false;
        //                }
        //                else
        //                {
        //                    _teklifDurumuAcik = true;
        //                }


        //                LayoutControllerEnableDisable(SayfaYetkisi);
        //            }

        //        }
        //        private void TxtOfferRequestSourceId_SelectedValueChanged(object sender, EventArgs e)
        //        {
        //            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
        //            _selectedOfferRequestSourceId = 0;
        //            if (senderSelectItem != null && senderSelectItem != "")
        //            {
        //                var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
        //                long.TryParse(senderSelectValue.ToString(), out _selectedOfferRequestSourceId);

        //                if (((MyComboBoxEdit)sender).Name != null)
        //                {
        //                }
        //            }
        //        }
        //        private void TxtOfferRequestTypeId_SelectedValueChanged(object sender, EventArgs e)
        //        {
        //            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
        //            _selectedOfferRequestTypeId = 0;
        //            if (senderSelectItem != null && senderSelectItem != "")
        //            {
        //                var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
        //                long.TryParse(senderSelectValue.ToString(), out _selectedOfferRequestTypeId);

        //                if (((MyComboBoxEdit)sender).Name != null)
        //                {
        //                }
        //            }

        //            GenerateCodes();
        //        }

        //        private void OpenFolder(string Path)
        //        {
        //            Cursor = Cursors.WaitCursor;
        //            if (!string.IsNullOrEmpty(Path))
        //            {
        //                if (Directory.Exists(Path))
        //                {
        //                    string myDocspath = txtOfferDirectory.Text; // Buraya istediğimiz dosyanın yolunu yazıyorz
        //                    string windir = Environment.GetEnvironmentVariable("WINDIR");
        //                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
        //                    prc.StartInfo.FileName = windir + @"\explorer.exe";
        //                    prc.StartInfo.Arguments = myDocspath;
        //                    prc.Start();
        //                }
        //                else
        //                {
        //                    MessageBox.Show("İlgili Klasör yolu bulunamadı. Birden çok sebebi olabilir. Oluşturulan proje, görev Server'a senkrol edilmemiş ya da bilgisayarınız senkron olmayabilir.", "Klasör Bulunamadı");
        //                }
        //            }
        //            Cursor = Cursors.Default;
        //        }
        //        private void GetOfferDirectoryPath()
        //        {
        //            var Anadizin = Global.TeklifDizin.TeklifAnaDizin;
        //            var Anadizin1 = Anadizin + "\\" + txtCustomerId.Text;
        //            var Anadizin2 = Anadizin1 + "\\" + txtRefNo.Text;
        //            var Anadizin3 = Anadizin2 + "\\" + txtVerCode.Text;

        //            if (!string.IsNullOrEmpty(Anadizin) &&
        //                !string.IsNullOrEmpty(txtCustomerId.Text) &&
        //                !string.IsNullOrEmpty(txtRefNo.Text) &&
        //                !string.IsNullOrEmpty(txtVerCode.Text))
        //            {
        //                txtOfferDirectory.Text = Anadizin3;
        //            }
        //            else
        //            {
        //                txtOfferDirectory.Text = "";
        //            }

        //        }
        //        private void GetSelectedOffer()
        //        {
        //            //var data = _offers.FirstOrDefault(x => x.Id == _selectedOfferId);
        //            //_selectedOffer = OfferBll.DataCrypto(data, true);

        //            //if (_selectedOffer != null)
        //            //{
        //            //    txtName.Text                = _selectedOffer.Name;
        //            //    txtPreparationDate.DateTime = _selectedOffer.PreparationDate.Value;
        //            //    txtValidityPeriodWeek.Value = _selectedOffer.ValidityPeriodWeek.Value;
        //            //    txtOfferContent.Text        = _selectedOffer.OfferContent;
        //            //    txtRefNo.Text               = _selectedOffer.RefNo.ToString();
        //            //    txtPrice.Text               = _selectedOffer.Price;
        //            //    txtRealCost.Text            = _selectedOffer.RealCost;
        //            //    txtTargetCost.Text          = _selectedOffer.TargetCost;
        //            //    txtKeyword.EditValue        = _selectedOffer.Keyword;


        //            //    //var list_txtCurrentcyId = _currency.FirstOrDefault(x => x.Id == _selectedOffer.CurrencyId);
        //            //    //txtCurrencyId.EditValue = list_txtCurrentcyId.Id;

        //            //    //var Find_txtOfferTypeId = list_txtCurrentcyId.Where(X => X.Value.ToString() == _selectedOffer.OfferTypeId.ToString()).FirstOrDefault();
        //            //    //txtOfferTypeId.SelectedItem = Find_txtOfferTypeId;

        //            //    var list_txtOfferTypeId             = txtOfferTypeId.Properties.Items.Cast<ComboboxItem>().ToList();
        //            //    var Find_txtOfferTypeId             = list_txtOfferTypeId.Where(X => X.Value.ToString() == _selectedOffer.OfferTypeId.ToString()).FirstOrDefault();
        //            //    txtOfferTypeId.SelectedItem         = Find_txtOfferTypeId;

        //            //    var list_txtOfferStatusId           = txtOfferStatusId.Properties.Items.Cast<ComboboxItem>().ToList();
        //            //    var Find_txtOfferStatusId           = list_txtOfferStatusId.Where(X => X.Value.ToString() == _selectedOffer.OfferStatusId.ToString()).FirstOrDefault();
        //            //    txtOfferStatusId.SelectedItem       = Find_txtOfferStatusId;

        //            //    var list_txtCustomerId              = txtCustomerId.Properties.Items.Cast<ComboboxItem>().ToList();
        //            //    var Find_txtCustomerId              = list_txtCustomerId.Where(X => X.Value.ToString() == _selectedOffer.CustomerId.ToString()).FirstOrDefault();
        //            //    txtCustomerId.SelectedItem          = Find_txtCustomerId;

        //            //    var list_txtCustomerContactId       = txtCustomerContactId.Properties.Items.Cast<ComboboxItem>().ToList();
        //            //    var Find_txtCustomerContactId       = list_txtCustomerContactId.Where(X => X.Value.ToString() == _selectedOffer.CustomerContactId.ToString()).FirstOrDefault();
        //            //    txtCustomerContactId.SelectedItem   = Find_txtCustomerContactId;

        //            //    var list_txtCustomerSectionId       = txtCustomerSectionId.Properties.Items.Cast<ComboboxItem>().ToList();
        //            //    var Find_txtCustomerSectionId       = list_txtCustomerSectionId.Where(X => X.Value.ToString() == _selectedOffer.CustomerSectionId.ToString()).FirstOrDefault();
        //            //    txtCustomerSectionId.SelectedItem   = Find_txtCustomerSectionId;

        //            //    var list_txtOfferRequestSourceId    = txtOfferRequestSourceId.Properties.Items.Cast<ComboboxItem>().ToList();
        //            //    var Find_txtOfferRequestSourceId    = list_txtOfferRequestSourceId.Where(X => X.Value.ToString() == _selectedOffer.OfferRequestSourceId.ToString()).FirstOrDefault();
        //            //    txtOfferRequestSourceId.SelectedItem = Find_txtOfferRequestSourceId;

        //            //    var list_txtOfferRequestTypeId      = txtOfferRequestTypeId.Properties.Items.Cast<ComboboxItem>().ToList();
        //            //    var Find_txtOfferRequestTypeId      = list_txtOfferRequestTypeId.Where(X => X.Value.ToString() == _selectedOffer.OfferRequestTypeId.ToString()).FirstOrDefault();
        //            //    txtOfferRequestTypeId.SelectedItem  = Find_txtOfferRequestTypeId;

        //            //    var selectReqType                   = _offer_RequestType.FirstOrDefault(x => x.Id == _selectedOffer.OfferRequestTypeId);

        //            //    if (selectReqType.Code == "V") //SatınAlma teklifi son versiyon ise bütce teklifi seçimi engellenir.
        //            //    {
        //            //        txtOfferRequestTypeId.ReadOnly = true;
        //            //    }
        //            //    else
        //            //    {
        //            //        txtOfferRequestTypeId.ReadOnly = false;
        //            //    }
        //            //}
        //        }
        //        void GenerateCodes()
        //        {
        //            string prefix = string.Empty;
        //            string RefNo = string.Empty;
        //            string Code = string.Empty;
        //            string VerCode = string.Empty;

        //            try
        //            {
        //                var prefixVal = _offer_RequestType.FirstOrDefault(x => x.Id == _selectedOfferRequestTypeId);

        //                //if (prefixVal != null)
        //                //{
        //                //    prefix = prefixVal.Code;

        //                //    if (_selectedModeId == 2) //Version Teklifi = 2
        //                //    {
        //                //        var selectOffer = _offers.FirstOrDefault(x => x.Id == _selectedOfferId);
        //                //        Code = selectOffer.Code;
        //                //        VerCode = OfferBll.VerCode(Code, prefix);
        //                //    }
        //                //    else //Yeni Teklif = 1
        //                //    {
        //                //        var year = txtPreparationDate.DateTime.Year;
        //                //        Code = OfferBll.Code(year);
        //                //        VerCode = OfferBll.VerCode(Code, prefix);
        //                //    }

        //                //    RefNo = Generator.CreateRefNo(IslemTuru.Insert, 0).ToString();

        //                //    txtRefNo.Text = RefNo;
        //                //    txtCode.Text = Code;
        //                //    txtVerCode.Text = VerCode;
        //                }

        //            }
        //            catch (Exception)
        //            {

        //            }
        //        }
        //        private void ClearCodes()
        //        {
        //            txtRefNo.Text = string.Empty;
        //            txtCode.Text = string.Empty;
        //            txtVerCode.Text = string.Empty;
        //        }
        //        private void LayoutControllerClear()
        //        {

        //        }
        //        private void LayoutControllerEnableDisable(UserAccess Check)
        //        {
        //            bool _ModeSecilmedi     = false;
        //            bool _verTeklifi        = true;

        //            bool Yetki_OkuYaz       = true;
        //            bool Oku                = true;

        //            bool TeklifAcik         = _teklifDurumuAcik;

        //            switch (Check)
        //            {
        //                case UserAccess.Gizle:
        //                    break;
        //                case UserAccess.Full:
        //                    Oku = false;
        //                    Yetki_OkuYaz = false;
        //                    break;
        //                case UserAccess.Oku:
        //                    Oku = true;
        //                    Yetki_OkuYaz = false;
        //                    break;
        //                case UserAccess.OkuYaz:

        //                    Yetki_OkuYaz = true;
        //                    Oku = false;
        //                    break;
        //                case UserAccess.SadeceDuzelt:
        //                    break;
        //                case UserAccess.SadeceYeniEkle:
        //                    break;
        //                default:
        //                    break;
        //            }


        //            //if (string.IsNullOrEmpty(txtMode.Text))
        //            //{
        //            //    _ModeSecilmedi = true;
        //            //}
        //            //else
        //            //{
        //            //    _ModeSecilmedi = false;
        //            //}

        //            //if (_selectedModeId == 2) //Version Teklifi = 2
        //            //{
        //            //    OfferSelectedBox.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        //            //    _verTeklifi = true;
        //            //}
        //            //else
        //            //{
        //            //    OfferSelectedBox.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        //            //    _verTeklifi = false;
        //            //}

        //            txtName.ReadOnly                    = Oku || (Yetki_OkuYaz);
        //            txtCustomerId.ReadOnly              = Oku || (Yetki_OkuYaz);
        //            txtCustomerSectionId.ReadOnly       = Oku || (Yetki_OkuYaz);
        //            txtOfferContent.ReadOnly            = Oku || (Yetki_OkuYaz); 
        //            txtCustomerContactId.ReadOnly       = Oku || (Yetki_OkuYaz); 

        //            txtOfferRequestSourceId.ReadOnly    = Oku || (Yetki_OkuYaz);
        //            txtOfferRequestTypeId.ReadOnly      = Oku || (Yetki_OkuYaz); 
        //            txtOfferStatusId.ReadOnly           = Oku;
        //            txtOfferTypeId.ReadOnly             = Oku || (Yetki_OkuYaz); 
        //            txtPreparationDate.ReadOnly         = Oku || (Yetki_OkuYaz);
        //            txtRefNo.ReadOnly                   = true; // Oku || (Yetki_OkuYaz); 
        //            txtCode.ReadOnly                    = true; // Oku || (Yetki_OkuYaz); 
        //            txtVerCode.ReadOnly                 = true; // Oku || (Yetki_OkuYaz); 
        //            txtValidityPeriodWeek.ReadOnly      = Oku || (Yetki_OkuYaz); 
        //            txtKeyword.ReadOnly                 = Oku;
        //            txtPrice.ReadOnly                   = Oku;
        //            txtTargetCost.ReadOnly              = Oku;
        //            txtRealCost.ReadOnly                = Oku;
        //            txtResultDate.ReadOnly              = Oku  || TeklifAcik;
        //            txtResultComment.ReadOnly           = Oku;
        //            //txtMode.ReadOnly                    = _ModeSecilmedi;
        //            //txtOfferId.ReadOnly                 = _ModeSecilmedi;
        //            //txtCurrencyId.ReadOnly              = _ModeSecilmedi;
        //            //txtOfferId.ReadOnly                 = _ModeSecilmedi;
        //        }

        //        #region ComboBox & DataFilling
        //        void GetListData()
        //        {
        //            _mode                       = OfferBll.GetListMode();
        //            _currency                   = CurrencyBll.GetList<Model.Currency>();

        //            _customers                  = CustomerBll.GetList<Model.Customers>();
        //            _customer_Section           = CustomerSectionBll.GetList<Model.Customer_Section>();
        //            _customer_Contact           = CustomerContactBll.GetList<Model.Customer_Section>();

        //            _offers                     = OfferBll.GetList<Model.Offers>("Active eq 'true'");
        //            _offer_Type                 = OfferTypeBll.GetList<Model.Offer_Type>();
        //            _offer_RequestSource        = OfferRequestSourceBll.GetList<Model.Offer_RequestSource>();
        //            _offer_RequestType          = OfferRequestTypeBll.GetList<Model.Offer_RequestType>();
        //            _offer_Status               = OfferStatusBll.GetList<Model.Offer_Status>();

        //            ComboBoxCustomerData();
        //            ComboBoxCustomerSectionData(0);
        //            ComboBoxCustomerContactData(0);

        //            ComboBoxOfferData();
        //            ComboBoxOfferTypeData();
        //            ComboBoxOfferRequestTypeData();
        //            ComboBoxOfferRequestSourceData();
        //            ComboBoxOfferStatusData();

        //            ComboBoxModeData();
        //            ComboBoxCurrency();
        //        }
        //        void ComboBoxCustomerData()
        //        {
        //            GeneralFunctions.ComboBoxDataFillingFromList(_customers, txtCustomerId);
        //        }
        //        void ComboBoxCustomerSectionData(long customerId)
        //        {
        //            var mylist = _customer_Section.Where(x => x.CustomerId == customerId).ToList();
        //            GeneralFunctions.ComboBoxDataFillingFromList(mylist, txtCustomerSectionId);
        //        }
        //        void ComboBoxCustomerContactData(long customerId)
        //        {
        //            var mylist = _customer_Contact.Where(x => x.CustomerId == customerId).ToList();
        //            GeneralFunctions.ComboBoxDataFillingFromListForContact(mylist, txtCustomerContactId);
        //        }
        //        void ComboBoxOfferData()
        //        {
        //            //_offers = OfferBll.GetList<Model.Offers>("Active eq 'true'");

        //            //var MyList = _offers.Select(x => new { x.Name, x.Code, x.VerCode, x.Id }).ToList();
        //            //var typs = MyList.GetType();
        //            //GeneralFunctions.LookUpEditDataFilling(MyList, txtOfferId, LookUpEditTuru.Offer);
        //        }
        //        void ComboBoxOfferTypeData()
        //        {
        //            GeneralFunctions.ComboBoxDataFillingFromList(_offer_Type, txtOfferTypeId);
        //        }
        //        void ComboBoxOfferRequestTypeData()
        //        {
        //            GeneralFunctions.ComboBoxDataFillingFromList(_offer_RequestType, txtOfferRequestTypeId);
        //        }
        //        void ComboBoxOfferRequestSourceData()
        //        {
        //            GeneralFunctions.ComboBoxDataFillingFromList(_offer_RequestSource, txtOfferRequestSourceId);
        //        }
        //        void ComboBoxOfferStatusData()
        //        {
        //            var MyList = _offer_Status.Select(x => new { x.Name, x.Code, x.Id }).ToList();
        //            var typs = MyList.GetType();
        //            var ShowValList = new string[] { "Name", "Code"};
        //            GeneralFunctions.LookUpEditDataFilling(MyList, txtOfferStatusId, ShowValList);
        //            //GeneralFunctions.ComboBoxDataFillingFromList(_offer_Status, txtOfferStatusId);
        //            //txtOfferStatusId.SelectedIndex = 0;
        //        }
        //        void ComboBoxModeData()
        //        {
        //            //if (txtMode.Properties.Items.Count < 1)
        //            //{
        //            //    for (int i = 0; i < _mode.Count; i++)
        //            //    {
        //            //        ComboboxItem itm = new ComboboxItem();
        //            //        itm.Text = _mode[i].Name;
        //            //        itm.Value = _mode[i].Id;
        //            //        txtMode.Properties.Items.Add(itm);
        //            //    }
        //            //}
        //        }
        //        void ComboBoxCurrency()
        //        {
        //            var MyList = _currency.Select(x => new { x.Name, x.Code, x.Id }).ToList();

        //            var typs = MyList.GetType();
        //            var ShowValList = new string[] { "Code" };
        //            GeneralFunctions.LookUpEditDataFilling(MyList, txtCurrencyId, ShowValList);
        //        }
        //        #endregion

        //        protected override void FiltreTemizle()
        //        {
        //            SablonSilList();
        //        }
        //        protected override void VeriGuncelle()
        //        {
        //            GetListData();
        //        }
        //        protected override void ListeRefresh()
        //        {
        //            YapilacakIslem(IslemTuru.ListRefresh);
        //        }
        //        protected override void EntityInsert()
        //        {
        //            YapilacakIslem(IslemTuru.Insert);
        //        }
        //        protected override void EntityUpdate()
        //        {
        //            YapilacakIslem(IslemTuru.Update);
        //        }
        //        protected override void EntityDelete()
        //        {
        //            YapilacakIslem(IslemTuru.Delete);
        //        }

        //        private void YapilacakIslem(IslemTuru islemturu)
        //        {
        //            var Data                        = new Model.Offers();                    // Contollerdan gelen ve Fonksiyon içinde kullanılacak Data
        //            var _aktifDataFromTable         = new Model.Offers();                    // Fonksiyon içinde kullanılacak Data
        //            var _propertyFilling            = GeneralFunctions.ClassPropertyFilling(AktifData, _aktifDataFromTable);
        //            long selectFocusId              = 0;                                       // İşlem yapıldıktan sonra focus olacak ID

        //            if (IslemTuru.ListRefresh != islemturu)
        //            {
        //                if (IslemTuru.Insert != islemturu)
        //                {
        //                    if (_propertyFilling)
        //                        Data = _aktifDataFromTable;

        //                    if (IslemTuru.Update == islemturu && !_propertyFilling) //Tablo boş ve gelen işlem Update ise Insert işlemine geç
        //                    {
        //                        islemturu = IslemTuru.Insert;
        //                    }
        //                }

        //                List<object> OutOfCheck = new List<object>
        //                {
        //                    //txtKeyword,
        //                    //txtComment,
        //                    //txtCode,
        //                    //txtOfferId
        //                    //txtResultDate,
        //                    txtResultComment,
        //                    txtPrice,
        //                    txtRealCost,
        //                    txtTargetCost,
        //                    txtCurrencyCopy1,
        //                    txtCurrencyCopy2
        //                };

        //                if (_teklifDurumuAcik)
        //                {
        //                    OutOfCheck.Add(txtResultDate);
        //                }

        //                if (Checks.DataLayoutValueFillingOK(DataLayoutControl, OutOfCheck))
        //                {

        //                    if (IslemTuru.Insert == islemturu)
        //                    {
        //                        GenerateCodes();
        //                        Data.Active = "true";
        //                    }

        //                    Data.Id                     = Generator.CreateId(islemturu, Data.Id);
        //                    //Data.UserId                 = Dynamic.OnlineUser.Id;
        //                    Data.CustomerContactId      = Checks.IdCheckNullOrResult(_selectedCustomerContactId);  
        //                    Data.CustomerId             = Checks.IdCheckNullOrResult(_selectedCustomerId);
        //                    Data.CustomerSectionId      = Checks.IdCheckNullOrResult(_selectedCustomerSectionId);

        //                    Data.OfferRequestSourceId   = Checks.IdCheckNullOrResult(_selectedOfferRequestSourceId);
        //                    Data.OfferRequestTypeId     = Checks.IdCheckNullOrResult(_selectedOfferRequestTypeId);
        //                    Data.OfferTypeId            = Checks.IdCheckNullOrResult(_selectedOfferTypeId);
        //                    Data.OfferStatusId          = Checks.IdCheckNullOrResult(_selectedOfferStatusId);
        //                    Data.CurrencyId             = Checks.IdCheckNullOrResult(_selectedCurrencyId);
        //                    Data.Code                   = txtCode.Text;
        //                    Data.VerCode                = txtVerCode.Text;

        //                    int.TryParse(txtValidityPeriodWeek.Text, out int periodWeek);
        //                    Data.ValidityPeriodWeek     = periodWeek;
        //                    Data.PreparationDate        = txtPreparationDate.DateTime;

        //                    Data.SysCode                = null;
        //                    Data.Name                   = txtName.Text;
        //                    Data.OfferContent           = txtOfferContent.Text;
        //                    Data.Keyword                = txtKeyword.EditValue.ToString();

        //                    Data.ResultComment          = txtResultComment.Text;
        //                    Data.ResultDate             = Checks.DateTimeCheckNullOrResult(txtResultDate.DateTime);

        //                    Data.Price                  = txtPrice.Text;
        //                    Data.TargetCost             = txtTargetCost.Text;
        //                    Data.RealCost               = txtRealCost.Text;

        //                    if(_selectedModeId == 2) //Versiyon oluştururken RefNo oluşturulmaz!
        //                    {
        //                        txtRefNo.Text = _selectedOffer.RefNo.ToString();// Generator.CreateRefNo(IslemTuru.Update, _aktifDataFromTable.RefNo).ToString();
        //                    }
        //                    else // Yeni ekleme işleminde refno oluştur
        //                    {
        //                        txtRefNo.Text = Generator.CreateRefNo(islemturu, _aktifDataFromTable.RefNo).ToString();
        //                    }

        //                    if (long.TryParse(txtRefNo.Text, out long refNo))
        //                        Data.RefNo              = refNo;

        //                    if (string.IsNullOrEmpty(Data.Code) || string.IsNullOrEmpty(Data.VerCode))
        //                    {
        //                        MessageBox.Show("Kod oluşturulurken bir hata meydana geldi. Lütfen sayfayı kapatıp bilgileri yeniden girin.", "Kod Oluşturma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                        return;
        //                    }

        //                }
        //                else
        //                {
        //                    return;
        //                }

        //                selectFocusId = OfferBll.MyCrud(islemturu, Data);

        //                var detay = "Teklif Adı:    " + txtName.Text + Environment.NewLine +
        //                "Açıklama:                  " + txtOfferContent.Text + Environment.NewLine +
        //                "Teklif Kodu:               " + Data.Code + Data.VerCode + Environment.NewLine +
        //                "Teklif Türü:               " + txtOfferTypeId.Text + Environment.NewLine + Environment.NewLine +
        //                "Müşteri Adı:               " + txtCustomerId.Text + Environment.NewLine +
        //                "Müşteri Bölüm              " + txtCustomerSectionId.Text + Environment.NewLine +
        //                "Müşteri Sorumlu Kişi:      " + txtCustomerContactId.Text + Environment.NewLine;

        //                IslemOkForm islemOkForm = new IslemOkForm(detay);
        //                islemOkForm.ShowDialog();
        //            }

        //            Tablo.ClearSelection();
        //            var myList = OfferBll.ListRefresh(_customers, _customer_Contact, _customer_Section, _offer_RequestSource, _offer_RequestType, _offer_Status, _offer_Type, _currency);
        //            Tablo.GridControl.DataSource = myList;

        //            if (selectFocusId > 0)
        //            {
        //                Tablo.RowFocus("Id", selectFocusId);
        //            }
        //            else
        //            {
        //                Tablo.FocusedRowHandle = -2147483646; //Filtre satırını seçmek için bu değer gönderilir.
        //            }

        //            OfferBll.StatusTxt(islemturu, Data, barStaticStatusInfo);

        //            GetOfferDirectoryPath();
        //            ComboBoxOfferData();
        //        }


    }
}