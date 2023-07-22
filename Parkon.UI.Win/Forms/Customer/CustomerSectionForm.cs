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
using Emikon.Parkon.Common.Variables;
using Emikon.Parkon.Common.Functions;
using Emikon.Parkon.UI.Win.Functions;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraBars;
using Emikon.Parkon.Common.Design.Controls;
using Emikon.Parkon.Common.Message;
using Emikon.Model;
using DevExpress.XtraEditors.Controls;
using Emikon.Parkon.Common;
using Emikon.Parkon.Common.Generate;
using static Emikon.Parkon.Common.Variables.Static;
using Emikon.Parkon.Bll.Customer;
using Emikon.Parkon.Bll.General;

namespace Emikon.Parkon.UI.Win.Forms.Customer
{
    public partial class CustomerSectionForm : BaseListEditFreeLayoutForm
    {
        private long _selectedCustomerId;
        private long _selectedZoneId;
        List<Model.Zone>        _zone;
        List<Model.Customers>   _customers;

        public CustomerSectionForm()
        {
            _userScreen = UserScreen.MusteriSorgula;
            Yukle();
            InitializeComponent();
            DataLayoutControl               = myDataLayoutControl1;
            Tablo                           = baseTablo;
            Navigator.NavigatableControl    = Tablo.GridControl;

            Text                            = "Müşteri Bölüm/Fabrika/Şube Verileri";
            Tablo.ViewCaption               = Text;

            EventsLoad();           // Ribbon
            EventsLoadForList();    // Ribbon

            LayoutEvents();
            GetListData();
            ListeRefresh();
        }
        void LayoutEvents()
        {
            btnUpdate.Visibility                    = BarItemVisibility.Always;

            txtName.KeyPress                        += TextCorrection.TextEdit_KeyPressForUpperEnglish;
            txtMyCustomerName.SelectedValueChanged  += TxtMyCustomerName_SelectedValueChanged;
            txtZoneId.SelectedValueChanged          += TxtZoneId_SelectedValueChanged;

            btnAddCustomer.Click                    += BtnAddCustomer_Click;
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            FormOpen.BtnAdd_Click(sender, e);
            GetListData();
        }

        private void LayoutControllerEnableDisable()
        {
            bool _status;
            if (string.IsNullOrEmpty(txtMyCustomerName.Text))
            {
                _status = false;
            }
            else
            {
                _status = true;
            }

                txtZoneId.Enabled           = _status;
                txtName.Enabled             = _status;
                txtCode.Enabled             = _status;
                //ratingScore.Enabled         = _status;
                txtComment.Enabled          = _status;
                txtInfo.Enabled             = _status;
                txtKeyword.Enabled          = _status;
                txtMaps.Enabled             = _status;
                txtAddress.Enabled          = _status;
                txtPhone1.Enabled           = _status;
                txtPhone2.Enabled           = _status;
                txtFax.Enabled              = _status;

                 txtZoneId.Text           = string.Empty;
                 txtName.Text             = string.Empty;
                 txtCode.Text             = string.Empty;
                 //ratingScore.Text         = string.Empty;
                 txtComment.Text          = string.Empty;
                 txtInfo.Text             = string.Empty;
                 txtKeyword.Text          = string.Empty;
                 txtMaps.Text             = string.Empty;
                 txtAddress.Text          = string.Empty;
                 txtPhone1.Text           = string.Empty;
                 txtPhone2.Text           = string.Empty;
                 txtFax.Text              = string.Empty;

            YapilacakIslem(IslemTuru.ListRefresh);
        }

        #region ComboBox & DataFilling
        protected override void VeriGuncelle()
        {
            GetListData();
        }
        void GetListData()
        {
            _zone       = ZoneBll.GetList<Model.Zone>();
            _customers  = CustomerBll.GetList<Model.Customers>();

            ComboBoxZoneData();
            ComboBoxCustomersData();
        }
        void ComboBoxCustomersData()
        {
            GeneralFunctions.ComboBoxDataFillingFromList(_customers, txtMyCustomerName);
        }
        void ComboBoxZoneData()
        {
            GeneralFunctions.ComboBoxDataFillingFromList(_zone, txtZoneId);
        }

        private void TxtZoneId_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _selectedZoneId = 0;

            if (senderSelectItem != null && senderSelectItem != "")
            {
                var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
                long.TryParse(senderSelectValue.ToString(), out _selectedZoneId);
            }
        }
        private void TxtMyCustomerName_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _selectedCustomerId = 0;

            if (senderSelectItem != null && senderSelectItem != "")
            {
                var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
                long.TryParse(senderSelectValue.ToString(), out _selectedCustomerId);

                LayoutControllerEnableDisable();
                YapilacakIslem(IslemTuru.ListRefresh);
            }
        }
        #endregion

        protected override void TableToPic(int idx, string ad)
        {
            var picName = Tablo.GetRowCellDisplayText(idx, ad);

            try
            {
                if (!string.IsNullOrEmpty(picName))
                {
                    Bitmap b = new Bitmap(Picture.GetImageSource(picName, PictureSource));
                    Bitmap c = new Bitmap(b); //, 50, 50);

                    pic1.Image = c;
                    pic1.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                }
                else
                {
                    pic1.Image = new Bitmap(Emikon.Parkon.UI.Win.Properties.Resources.ResimYok); //, new Size(30,30));
                }
            }
            catch (Exception HATA)
            {

            }

        }

        protected override void ListeRefresh()
        {
            YapilacakIslem(IslemTuru.ListRefresh);
        }
        protected override void EntityInsert()
        {
            YapilacakIslem(IslemTuru.Insert);
        }
        protected override void EntityUpdate()
        {
            YapilacakIslem(IslemTuru.Update);

        }
        protected override void EntityDelete()
        {
            YapilacakIslem(IslemTuru.Delete);
        }
        private void YapilacakIslem(IslemTuru islemturu)
        {
            var Data                        = new Model.Customer_Section();                    // Contollerdan gelen ve Fonksiyon içinde kullanılacak Data
            var _aktifDataFromTable         = new Model.Customer_Section();                    // Fonksiyon içinde kullanılacak Data
            var _propertyFilling            = GeneralFunctions.ClassPropertyFilling(AktifData, _aktifDataFromTable);
            long selectFocusId              = _selectedCustomerId;                             // İşlem yapıldıktan sonra focus olacak ID


            if (IslemTuru.ListRefresh != islemturu)
            {
                if (IslemTuru.Insert != islemturu)
                {
                    if (_propertyFilling)
                        Data = _aktifDataFromTable;

                    if (IslemTuru.Update == islemturu && !_propertyFilling) //Tablo boş ve gelen işlem Update ise Insert işlemine geç
                    {
                        islemturu = IslemTuru.Insert;
                    }
                }

                List<object> OutOfCheck = new List<object>
                {
                    txtCode,
                    txtFax,
                    txtPhone2,
                    txtComment,
                    txtKeyword,
                    txtInfo,
                    txtMaps
                };

                if (Checks.DataLayoutValueFillingOK(DataLayoutControl, OutOfCheck))
                {
                    Data.Id             = Generator.CreateId(islemturu, Data.Id);
                    Data.UserId         = Dynamic.OnlineUser.Id;
                    Data.CustomerId     = _selectedCustomerId;
                    Data.ZoneId         = _selectedZoneId;
                    Data.Name           = txtName.Text;
                    Data.Code           = txtCode.Text;
                    Data.Score          = ratingScore.Rating.ToString();
                    Data.Comment        = Crypto.Encrypt(txtComment.Text, Global.Str_ProjeCrypto);
                    Data.Info           = Crypto.Encrypt(txtInfo.Text, Global.Str_ProjeCrypto);
                    Data.Keyword        = Crypto.Encrypt(txtKeyword.Text, Global.Str_ProjeCrypto);
                    Data.Maps           = Crypto.Encrypt(txtMaps.Text, Global.Str_ProjeCrypto);
                    Data.Address        = Crypto.Encrypt(txtAddress.Text, Global.Str_ProjeCrypto);
                    Data.Phone1         = Crypto.Encrypt(txtPhone1.Text, Global.Str_ProjeCrypto);
                    Data.Phone2         = Crypto.Encrypt(txtPhone2.Text, Global.Str_ProjeCrypto);

                }
                else
                {
                    return;
                }
                selectFocusId = CustomerSectionBll.MyCrud(islemturu, Data);
            }

            var myList = CustomerSectionBll.ListRefresh(_selectedCustomerId, _zone, _customers);
            Tablo.GridControl.DataSource = myList;
            Tablo.RowFocus("Id", selectFocusId);
        }

    }
}

