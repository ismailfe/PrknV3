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
using Emikon.Parkon.Common.Generate;
using Emikon.Parkon.Bll.Store;

namespace Emikon.Parkon.UI.Win.Forms.Store
{
    public partial class StoreBrandForm : BaseListEditFreeLayoutForm
    {
        public StoreBrandForm()
        {
            _userScreen = UserScreen.StokAyarlar;
            Yukle();
            InitializeComponent();

            DataLayoutControl               = myDataLayoutControl1;
            Tablo                           = baseTablo;
            Navigator.NavigatableControl    = Tablo.GridControl;
            Text                            = "Ürün Markası";
            Tablo.ViewCaption               = Text;
            PictureSource                   = PictureSourceType.Brand;

            PopupMenuPic();
            EventsLoad();
            EventsLoadForList();
            ListeRefresh();
        }

        private void PopupMenuPic()
        {
            var a  = popupMenuPic.Manager.Items[2].Name;
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
            PictureEdit Target = pic1;
            string[] info;

            if (e.Item == btnPicFotoEkle)
            {
                Target.Image = Picture.PictureSelectWithDialog(out info);
                PictureBoxIcindekiImgInfo[0] = info[0];
                PictureBoxIcindekiImgInfo[1] = info[1];
            }
            else if (e.Item == btnPicFotoCek)
            {
                string[] result = Picture.TakePicture();
                Target.Image = Picture.PictureSelect(result[1], out info);

                PictureBoxIcindekiImgInfo[0] = info[0];
                PictureBoxIcindekiImgInfo[1] = info[1];
            }
            else if (e.Item == btnPicFotoSil)
            {
                Target.Image = null;

                PictureBoxIcindekiImgInfo[0] = "";
                PictureBoxIcindekiImgInfo[1] = "";
            }
        }

        protected override void TableToPic(int idx, string ad)
        {
            var picName = Tablo.GetRowCellDisplayText(idx, ad);
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
            var Data                    = new Model.Store_Brand();                  // Contollerdan gelen ve Fonksiyon içinde kullanılacak Data
            var _aktifDataFromTable     = new Model.Store_Brand();                  // Fonksiyon içinde kullanılacak Data
            var _propertyFilling        = GeneralFunctions.ClassPropertyFilling(AktifData, _aktifDataFromTable);
            long selectFocusId          = 0;                                        // İşlem yapıldıktan sonra focus olacak ID

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
                    StoreBrandBll.PicUpload(PictureBoxIcindekiImgInfo[0], PictureBoxIcindekiImgInfo[1]);
                    Data.Pic = PictureBoxIcindekiImgInfo[1];
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
                    txtCode,
                    txtComment,
                    txtInfo,
                    txtKeyword
                };

                if (Checks.DataLayoutValueFillingOK(DataLayoutControl, OutOfCheck))
                {
                    Data.Id         = Generator.CreateId(islemturu, Data.Id);
                    Data.UserId     = Dynamic.OnlineUser.Id;
                    Data.Name       = txtName.Text;
                    Data.Code       = txtCode.Text;
                    Data.Origin     = txtOrigin.Text;
                    Data.Info       = txtInfo.Text;
                    Data.Keyword    = txtKeyword.Text;
                    Data.Score      = ratingScore.EditValue.ToString();
                    Data.Comment    = txtComment.Text;
                }
                else
                {
                    return;
                }
                selectFocusId = StoreBrandBll.MyCrud(islemturu, Data);
            }

            var myList = StoreBrandBll.ListRefresh();
            Tablo.GridControl.DataSource = myList;
            Tablo.RowFocus("Id", selectFocusId);
        }

    }
}