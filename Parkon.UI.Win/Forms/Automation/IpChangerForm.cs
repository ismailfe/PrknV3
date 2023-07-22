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
using Emikon.Parkon.UI.Win.Functions;
using Emikon.Model;
using DevExpress.XtraEditors.Controls;
using Emikon.Parkon.Common;
using Emikon.Parkon.Common.Generate;
using static Emikon.Parkon.Common.Variables.Static;
using Emikon.Parkon.Bll.General;
using Emikon.Parkon.Bll.Customer;

namespace Emikon.Parkon.UI.Win.Forms.Customer
{
    public partial class IpChangerForm : BaseListEditFreeLayoutForm
    {
        private long _selectedCustomerTypeId;
        private long _selectedZoneId;

        List<Model.Customer_Type> _customerType;
        List<Model.Zone> _zone;

        public IpChangerForm()
        {
            _userScreen = UserScreen.MusteriSorgula;
            Yukle();
            InitializeComponent();
            DataLayoutControl               = myDataLayoutControl1;
            Tablo                           = baseTablo;
            Navigator.NavigatableControl    = Tablo.GridControl;
            Text                            = "Müşteri Verileri";
            Tablo.ViewCaption               = Text;
            PictureSource                   = PictureSourceType.Customer;

            EventsLoad();           // Ribbon
            EventsLoadForList();    // Ribbon

            PopupMenuPic();
            LayoutEvents();
            GetListData();
            ListeRefresh();
        }

        #region Picture Event / Popup
        private void PopupMenuPic()
        {
            var a = popupMenuPic.Manager.Items[2].Name;
            //Button Events
            foreach (var item in popupMenuPic.Manager.Items)
            {
                switch (item)
                {
                    case BarItem button:
                        button.ItemClick += PicPopupMenuButton_ItemClick;
                        break;
                }
            }
        }
        private void PicPopupMenuButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            //PictureEdit Target = pic1;
            //string[] info;

            //if (e.Item == btnPicFotoEkle)
            //{
            //    Target.Image = Picture.PictureSelectWithDialog(out info);
            //    PictureBoxIcindekiImgInfo[0] = info[0];
            //    PictureBoxIcindekiImgInfo[1] = info[1];
            //}
            //else if (e.Item == btnPicFotoCek)
            //{
            //    string[] result = Picture.TakePicture();
            //    Target.Image = Picture.PictureSelect(result[1], out info);

            //    PictureBoxIcindekiImgInfo[0] = info[0];
            //    PictureBoxIcindekiImgInfo[1] = info[1];
            //}
            //else if (e.Item == btnPicFotoSil)
            //{
            //    Target.Image = null;

            //    PictureBoxIcindekiImgInfo[0] = "";
            //    PictureBoxIcindekiImgInfo[1] = "";
            //}
        }
        #endregion

        void LayoutEvents()
        {
            btnUpdate.Visibility                    = BarItemVisibility.Always;

            //txtName.KeyPress                        += TextCorrection.TextEdit_KeyPressForUpperEnglish;
            //txtCustomerTypeId.SelectedValueChanged  += TxtCustomerTypeId_SelectedValueChanged;
            //txtZoneId.SelectedValueChanged          += TxtZoneId_SelectedValueChanged;

            //txtSectionName.TextChanged              += TxtSectionName_TextChanged;
            //checkSectionNameChange.CheckedChanged   += CheckSectionNameChange_CheckedChanged;
        }

        private void TxtSectionName_TextChanged(object sender, EventArgs e)
        {
            if (((TextEdit)sender).Text == "" )
            {
                ((TextEdit)sender).Text = "MERKEZ";
            }
        }

        private void CheckSectionNameChange_CheckedChanged(object sender, EventArgs e)
        {
         //   txtSectionName.Enabled = checkSectionNameChange.Checked;
        }

        #region ComboBox & DataFilling
        protected override void VeriGuncelle()
        {
            GetListData();
        }
        void GetListData()
        {
            _zone                           = ZoneBll.GetList<Model.Zone>();
            _customerType                   = CustomerTypeBll.GetList<Model.Customer_Type>();

            ComboBoxZoneData();
            ComboBoxCustomerTypeData();
        }
        void ComboBoxCustomerTypeData()
        {
           // GeneralFunctions.ComboBoxDataFillingFromList(_customerType, txtCustomerTypeId);
        }
        void ComboBoxZoneData()
        {
          //  GeneralFunctions.ComboBoxDataFillingFromList(_zone, txtZoneId);
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
        private void TxtCustomerTypeId_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _selectedCustomerTypeId = 0;

            if (senderSelectItem != null && senderSelectItem != "")
            {
                var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
                long.TryParse(senderSelectValue.ToString(), out _selectedCustomerTypeId);
            }
        }
        #endregion

        protected override void TableToPic(int idx, string ad)
        {
            var picName = Tablo.GetRowCellDisplayText(idx, ad);

            try
            {
                //if (!string.IsNullOrEmpty(picName))
                //{
                //    Bitmap b = new Bitmap(Picture.GetImageSource(picName, PictureSource));
                //    Bitmap c = new Bitmap(b); //, 50, 50);

                //    pic1.Image = c;
                //    pic1.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                //}
                //else
                //{
                //    pic1.Image = new Bitmap(Emikon.Parkon.UI.Win.Properties.Resources.ResimYok); //, new Size(30,30));
                //}
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
            var Data                        = new Model.Customers();                    // Contollerdan gelen ve Fonksiyon içinde kullanılacak Data
            var _aktifDataFromTable         = new Model.Customers();                    // Fonksiyon içinde kullanılacak Data
            var _propertyFilling            = GeneralFunctions.ClassPropertyFilling(AktifData, _aktifDataFromTable);
            long selectFocusId              = 0;                                        // İşlem yapıldıktan sonra focus olacak ID

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

                if (!string.IsNullOrEmpty(PictureBoxIcindekiImgInfo[0]) && !string.IsNullOrEmpty(PictureBoxIcindekiImgInfo[1]))
                {
                    var resultPic   = CustomerBll.PicUpload(PictureBoxIcindekiImgInfo[0], PictureBoxIcindekiImgInfo[1]);
                    Data.Pic        = PictureBoxIcindekiImgInfo[1];
                }
                else
                {
                    if (string.IsNullOrEmpty(Data.Pic))
                    {
                        Data.Pic = "";
                    }
                }

                List<object> OutOfCheck = new List<object>
                {
                    //txtCode,
                    //txtFax,
                    //txtPhone2,
                    //txtComment,
                    //txtKeyword,
                    //txtInfo,
                    //txtMaps
                };

                if (Checks.DataLayoutValueFillingOK(DataLayoutControl, OutOfCheck))
                {
                    //Data.Id             = Generator.CreateId(islemturu, Data.Id);
                    //Data.UserId         = Dynamic.OnlineUser.Id;
                    //Data.CustomerTypeId = _selectedCustomerTypeId;  
                    //Data.ZoneId         = _selectedZoneId;          
                    //Data.Name           = txtName.Text;
                    //Data.Code           = txtCode.Text;
                    //Data.Score          = ratingScore.Rating.ToString();
                    //Data.Comment        = Crypto.Encrypt(txtComment.Text, Global.Str_ProjeCrypto);
                    //Data.Info           = Crypto.Encrypt(txtInfo.Text, Global.Str_ProjeCrypto);
                    //Data.Keyword        = Crypto.Encrypt(txtKeyword.Text, Global.Str_ProjeCrypto);
                    //Data.Maps           = Crypto.Encrypt(txtMaps.Text, Global.Str_ProjeCrypto);
                    //Data.Address        = Crypto.Encrypt(txtAddress.Text, Global.Str_ProjeCrypto);
                    //Data.Phone1         = Crypto.Encrypt(txtPhone1.Text, Global.Str_ProjeCrypto);
                    //Data.Phone2         = Crypto.Encrypt(txtPhone2.Text, Global.Str_ProjeCrypto);
                    //Data.Fax            = Crypto.Encrypt(txtFax.Text, Global.Str_ProjeCrypto);
                }
                else
                {
                    return;
                }
         //       selectFocusId   = CustomerBll.MyCrud(islemturu, Data, txtSectionName.Text);
            }

            var myList = CustomerBll.ListRefresh(_zone, _customerType);
            Tablo.GridControl.DataSource = myList;
            Tablo.RowFocus("Id", selectFocusId);
        }

    }
}

