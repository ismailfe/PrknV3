using System;
using System.Collections.Generic;
using System.Drawing;
using Emikon.Parkon.UI.Win.Forms.Base;
using Emikon.Parkon.Common.Enums;
using Emikon.Parkon.Common.Variables;
using Emikon.Parkon.Common.Functions;
using Emikon.Parkon.UI.Win.Functions;
using DevExpress.XtraBars;
using Emikon.Parkon.Common.Design.Controls;
using Emikon.Parkon.Common.Generate;
using static Emikon.Parkon.Common.Functions.GeneralFunctions;
using static Emikon.Parkon.Common.Variables.Static;
using Emikon.Parkon.Bll.General;
using Emikon.Parkon.Bll.Customer;
using static Emikon.Parkon.Bll.Customer.CustomerContactBll;

namespace Emikon.Parkon.UI.Win.Forms.Customer
{
    public partial class CustomerContactForm : BaseListEditFreeLayoutForm
    {
        private long _selectedCustomerId;
        private long _selectedTitleId;
        private int  _selectedGenderId;
        List<Model.Title>       _title;
        List<Model.Customers>   _customers;
     //   List<Gender>            _gender;

        public CustomerContactForm()
        {
            _userScreen = UserScreen.MusteriSorgula;
            Yukle();

            InitializeComponent();
            DataLayoutControl               = myDataLayoutControl1;
            Tablo                           = baseTablo;
            Navigator.NavigatableControl    = Tablo.GridControl;

            Text                            = "Müşteri Kişi Rehberi";
            Tablo.ViewCaption               = Text;

            EventsLoad();           // Ribbon
            EventsLoadForList();    // Ribbon

            LayoutEvents();
            GetListData();
            ListeRefresh();
        }

        void LayoutEvents()
        {
            btnUpdate.Visibility                        = BarItemVisibility.Always;
            txtJob.KeyPress                             += TextCorrection.TextEdit_KeyPressForUpperEnglish;
            txtMyCustomerName.SelectedValueChanged      += TxtMyCustomerName_SelectedValueChanged;
            txtTitleId.SelectedValueChanged             += TxtTitleId_SelectedValueChanged;
            txtGender.SelectedValueChanged              += TxtGender_SelectedValueChanged;

            btnAddCustomer.Click    += BtnAdd_Click;
            btnAddTitle.Click       += BtnAdd_Click;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
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

            txtTitleId.Enabled      = _status;
            txtNameFirst.Enabled    = _status;
            txtNameLast.Enabled     = _status;
            txtComment.Enabled      = _status;
            txtInfo.Enabled         = _status;
            txtKeyword.Enabled      = _status;
            txtJob.Enabled          = _status;
            txtPhone1.Enabled       = _status;
            txtPhone2.Enabled       = _status;
            txtMail1.Enabled        = _status;
            txtMail2.Enabled        = _status;
            txtGender.Enabled       = _status;

            txtTitleId.Text         = string.Empty;
            txtNameFirst.Text       = string.Empty;
            txtNameLast.Text        = string.Empty;
            txtComment.Text         = string.Empty;
            txtInfo.Text            = string.Empty;
            txtKeyword.Text         = string.Empty;
            txtJob.Text             = string.Empty;
            txtPhone1.Text          = string.Empty;
            txtPhone2.Text          = string.Empty;
            txtMail1.Text           = string.Empty;
            txtMail2.Text           = string.Empty;
            txtGender.Text          = string.Empty;

        }

        #region ComboBox & DataFilling
        protected override void VeriGuncelle()
        {
            GetListData();
        }
        void GetListData()
        {
            //_title      = TitleBll.GetList<Model.Title>();
            //_gender     = CustomerContactBll.GetListGender();
            //_customers  = CustomerBll.GetList<Model.Customers>();

            ComboBoxTitleData();
            ComboBoxGenderData();
            ComboBoxCustomersData();
        }
        void ComboBoxTitleData()
        {
            GeneralFunctions.ComboBoxDataFillingFromList(_title, txtTitleId);
        }
        void ComboBoxGenderData()
        {
            //if (txtGender.Properties.Items.Count < 1)
            //{
            //    for (int i = 0; i < _gender.Count; i++)
            //    {
            //        ComboboxItem itm = new ComboboxItem();
            //        itm.Text = _gender[i].Name;
            //        itm.Value = _gender[i].Id;
            //        txtGender.Properties.Items.Add(itm);
            //    }
            //}
        }
        void ComboBoxCustomersData()
        {
            GeneralFunctions.ComboBoxDataFillingFromList(_customers, txtMyCustomerName);
        }


        private void TxtGender_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _selectedGenderId = 0;

            if (senderSelectItem != null && senderSelectItem != "")
            {
                var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
                int.TryParse(senderSelectValue.ToString(), out _selectedGenderId);
            }
        }
        private void TxtTitleId_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _selectedTitleId = 0;

            if (senderSelectItem != null && senderSelectItem != "")
            {
                var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
                long.TryParse(senderSelectValue.ToString(), out _selectedTitleId);
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
            var Data                        = new Model.Customer_Contact();                    // Contollerdan gelen ve Fonksiyon içinde kullanılacak Data
            var _aktifDataFromTable         = new Model.Customer_Contact();                    // Fonksiyon içinde kullanılacak Data
            var _propertyFilling            = GeneralFunctions.ClassPropertyFilling(AktifData, _aktifDataFromTable);
            long selectFocusId              = 0;                             // İşlem yapıldıktan sonra focus olacak ID

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
                    txtInfo,
                    txtComment,
                    txtPhone2,
                    txtMail2,
                    txtKeyword,
                };

                if (Checks.DataLayoutValueFillingOK(DataLayoutControl, OutOfCheck))
                {
                    Data.Id             = Generator.CreateId(islemturu, Data.Id);
                    Data.UserId         = Dynamic.OnlineUser.Id;
                    Data.CustomerId     = _selectedCustomerId; // (txtMyCustomerName.SelectedItem as dynamic).Value;
                    Data.TitleId        = _selectedTitleId; // (txtTitleId.SelectedItem as dynamic).Value;

                    Data.Gender         = _selectedGenderId; // (txtGender.SelectedItem as dynamic).Value;
                    Data.NameFirst      = txtNameFirst.Text;
                    Data.NameLast       = txtNameLast.Text;
                    Data.Score          = ratingScore.Rating.ToString();
                    Data.Comment        = Crypto.Encrypt(txtComment.Text, Global.Str_ProjeCrypto);
                    Data.Info           = Crypto.Encrypt(txtInfo.Text, Global.Str_ProjeCrypto);
                    Data.Keyword        = Crypto.Encrypt(txtKeyword.Text, Global.Str_ProjeCrypto);
                    Data.Phone1         = Crypto.Encrypt(txtPhone1.Text, Global.Str_ProjeCrypto);
                    Data.Phone2         = Crypto.Encrypt(txtPhone2.Text, Global.Str_ProjeCrypto);
                    Data.Mail1          = Crypto.Encrypt(txtMail1.Text, Global.Str_ProjeCrypto);
                    Data.Mail2          = Crypto.Encrypt(txtMail2.Text, Global.Str_ProjeCrypto);
                    Data.Job            = Crypto.Encrypt(txtJob.Text, Global.Str_ProjeCrypto);
                }
                else
                {
                    return;
                }

            //    selectFocusId = CustomerContactBll.MyCrud(islemturu, Data);
            }


         //   var myList = CustomerContactBll.ListRefresh(_selectedCustomerId, _title, _customers, _gender);
         //   Tablo.GridControl.DataSource = myList;
         //   Tablo.RowFocus("Id", selectFocusId);
        }

    }
}