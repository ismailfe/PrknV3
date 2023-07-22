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
using Emikon.Parkon.Common;
using static Emikon.Parkon.Common.Variables.Static;
using Emikon.Parkon.Bll.General;
using Emikon.Parkon.Bll.Settings;
using Emikon.Parkon.Bll.User;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace Emikon.Parkon.UI.Win.Forms.User
{
    public partial class UsersForm : BaseListEditFreeLayoutForm
    {
        //long _selectedAuthorizationId;
        long _selectedTitleId;
        long _selectedDepartmentId;
        long _selectedRoleId;
        //long _selectedLevelId;
        //long _selectedOnlineId;

        List<Model.Title>               _title;
        List<Model.User_Department>     _department;
        List<ComboboxItem>              _role;
        List<Model.User_Authorization>  _Authorization;

        public UsersForm()
        {
            _userScreen = UserScreen.yonetim;
            Yukle();
            InitializeComponent();

            DataLayoutControl               = myDataLayoutControl1;
            Tablo                           = baseTablo;
            Navigator.NavigatableControl    = Tablo.GridControl;

            EventsLoad();
            EventsLoadForList();
         
            Text                            = "Sistem Kullanıcıları";
            Tablo.ViewCaption               = Text;
            PictureSource                   = PictureSourceType.User;

            PopupMenuPic();

            EventLoads();
            GetListData(); //Gerekli Dataları SQL den çek

            ListeRefresh();
        }

        void CreateObj()
        {
            //var listScreen = UserScreenBll.GetList<Model.User_Screen>();
            //var listAccess = UserAccessBll.GetList<Model.User_Access>();

            //myDataLayoutControl_Dynamic.BeginUpdate();
            //try
            //{
            //    myDataLayoutControl_Dynamic.Root.GroupBordersVisible = false;

            //    // Create a new Details group.
            //    LayoutControlGroup group1 = new LayoutControlGroup();
            //    group1.Name                 = "GroupDetails";
            //    group1.Text                 = "YETKİLENDİRME İŞLEMLERİ";

            //    List<LayoutControlItem> ListItem = new List<LayoutControlItem>();
            //    for (int i = 0; i < listScreen.Count(); i++)
            //    {
            //        MyComboBoxEdit mycombo          = new MyComboBoxEdit();
            //        GeneralFunctions.ComboBoxDataFillingFromList(listAccess, mycombo);
            //        mycombo.Name                    = "myCombo" + i.ToString();
            //        mycombo.SelectedIndex           = 0;


            //       // Create a layout item within the group.
            //       LayoutControlItem item1 = group1.AddItem(); //LayoutControlItem(myDataLayoutControl_Dynamic, mycombo); ;//

            //        item1.Control           = mycombo;
            //        item1.Text              = listScreen[i].Name;

            //        myDataLayoutControl_Dynamic.Root.Add(group1);

            //        if (i == 0)
            //        {
            //            layoutControlGroup_Dynamic.OptionsTableLayoutGroup.AddRow();
            //        }
                   
            //        //myDataLayoutControl_Dynamic.Root.OptionsTableLayoutGroup.AddRow();
            //    }

            //    // Hide the root group's border and caption.

            //    // Create a layout item that will display a date editor.
            //    //DateEdit dtEdit1            = new DateEdit();
            //    //dtEdit1.Name                = "dtEdit1";
            //    //LayoutControlItem item2     = new LayoutControlItem(myDataLayoutControl_Dynamic, dtEdit1);
            //    //item2.Text                  = "Date";

            //    // Position this item to the right of item1
            //    //item2.Move(item1, InsertType.Right);

            //    // Add the created group to the root group.

            //}
            //finally
            //{
            //    // Unlock and update the layout control.
            //    myDataLayoutControl_Dynamic.EndUpdate();
            //}





        }
        void EventLoads()
        {
            txtTitleId.SelectedValueChanged         += TxtTitleName_SelectedValueChanged;
            txtDepartmentId.SelectedValueChanged    += TxtDepartmentName_SelectedValueChanged;
            txtRole.SelectedValueChanged            += TxtRoleName_SelectedValueChanged;
        }

        private void TxtRoleName_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _selectedRoleId = 0;
            if (senderSelectItem != null)
            {
                if (senderSelectItem != "")
                {
                    var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
                    //long.TryParse(senderSelectValue.ToString(), out _selectedRoleId);

                    bool _status = false;
                    if (((MyComboBoxEdit)sender).Name != null)
                    {
                        _status = true;
                    }
                }
            }
        }
        private void TxtDepartmentName_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _selectedDepartmentId = 0;
            if (senderSelectItem != null)
            {
                if (senderSelectItem != "")
                {
                    var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
                    long.TryParse(senderSelectValue.ToString(), out _selectedDepartmentId);

                    bool _status = false;
                    if (((MyComboBoxEdit)sender).Name != null)
                    {
                        _status = true;
                    }
                }
            }
        }
        private void TxtTitleName_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _selectedTitleId = 0;
            if (senderSelectItem != null)
            {
                if (senderSelectItem != "")
                {
                    var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
                    long.TryParse(senderSelectValue.ToString(), out _selectedTitleId);

                    bool _status = false;
                    if (((MyComboBoxEdit)sender).Name != null)
                    {
                        _status = true;
                    }
                }
            }
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

        private void GetListData()
        {
            _title               = TitleBll.GetList<Model.Title>();
            _department          = UserDepartmentBll.GetList<Model.User_Department>();  //GeneralFunctions.ListDataFilling<Model.Customer_Section>(Var_JSON.URI.Customer_Section);
            _Authorization       = UserAuthorizationBll.GetList<Model.User_Authorization>();

            ComboBoxDepartment();
            ComboBoxTitle();
            ComboBoxRole();
        }
        private void ComboBoxDepartment()
        {
            GeneralFunctions.ComboBoxDataFillingFromList<Model.User_Department>(_department, txtDepartmentId);
        }
        private void ComboBoxTitle()
        {
            GeneralFunctions.ComboBoxDataFillingFromList<Model.Title>(_title, txtTitleId);
        }
        private void ComboBoxRole()
        {
            txtRole.Properties.Items.Clear();
            ComboboxItem itm1   = new ComboboxItem();
            itm1.Text           = "User";
            itm1.Value          = "User";
            txtRole.Properties.Items.Add(itm1);

            ComboboxItem itm2   = new ComboboxItem();
            itm2.Text           = "Admin";
            itm2.Value          = "User";
            txtRole.Properties.Items.Add(itm2);
        }

        protected override void TableToPic(int idx, string ad)
        {
            var picName = Tablo.GetRowCellDisplayText(idx, ad);
            if (!string.IsNullOrEmpty(picName))
            {
                try
                {
                    Bitmap b = new Bitmap(Picture.GetImageSource(picName, PictureSource));
                    Bitmap c = new Bitmap(b); //, 50, 50);

                    pic1.Image = c;
                    pic1.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                }
                catch (Exception)
                {
                    pic1.Image = new Bitmap(Emikon.Parkon.UI.Win.Properties.Resources.ResimYok); //, new Size(30,30));
                }

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
            string URIPicture           = Var_JSON.URI.Image_User; 
            var Data                    = new Model.Users();                  // Contollerdan gelen ve Fonksiyon içinde kullanılacak Data
            var _aktifDataFromTable     = new Model.Users();                  // Fonksiyon içinde kullanılacak Data
            var _propertyFilling        = GeneralFunctions.ClassPropertyFilling(AktifData, _aktifDataFromTable);
            long selectFocusId          = 0;                                  // İşlem yapıldıktan sonra focus olacak ID

            var DataAuthorization       = new Model.User_Authorization();       // Contollerdan gelen ve Fonksiyon içinde kullanılacak Data

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
                    var resultPic = Picture.PictureUpload(URIPicture, PictureBoxIcindekiImgInfo[0], PictureBoxIcindekiImgInfo[1]);
                    Data.Pic = PictureBoxIcindekiImgInfo[1];
                }
                else
                {
                    if (string.IsNullOrEmpty(Data.Pic))
                    {
                        Data.Pic = "";
                    }
                }

                if (Checks.DataLayoutValueFillingOK(DataLayoutControl))
                {
                    Data.UId                = Guid.Parse("68973480-8df4-4344-b08b-2a8635bae61b");
                    Data.Id                 = Generator.CreateId(islemturu, Data.Id);
                    Data.UserId             = Dynamic.OnlineUser.Id;
                    //Data.AutrizationId      = _selectedAuthorizationId;
                    //Data.LevelsId           = _selectedLevelId;
                    //Data.OnlineId           = _selectedOnlineId;
                    //Data.Pic                = "";
                    Data.DepartmentId       = _selectedDepartmentId;
                    Data.TitleId            = _selectedTitleId;
                    Data.Comment            = "";
                    
                    Data.Role               = txtRole.Text;
                    Data.BirthDate          = txtBirthDate.DateTime;
                    Data.NameFirst          = txtNameFirst.Text;
                    Data.NameLast           = txtNameLast.Text;
                    Data.Mail1              = Crypto.Encrypt(txtMail1.Text, Global.Str_ProjeCrypto);
                    Data.Mail2              = Crypto.Encrypt(txtMail2.Text, Global.Str_ProjeCrypto);
                    Data.Phone1             = Crypto.Encrypt(txtPhone1.Text, Global.Str_ProjeCrypto);
                    Data.Phone2             = Crypto.Encrypt(txtPhone2.Text, Global.Str_ProjeCrypto);
                    Data.UserName           = Crypto.Encrypt(txtUserName.Text, Global.Str_ProjeCrypto);
                    Data.Pass               = Crypto.Encrypt(txtPass.Text, Global.Str_ProjeCrypto);
                }
                else
                {
                    return;
                }

                if (islemturu == IslemTuru.Insert)
                {
                    DataAuthorization.Id = Generator.CreateId(islemturu, Data.Id);
                    DataAuthorization.C0 = 1;
                    DataAuthorization.C1 = 1;
                    DataAuthorization.C2 = 1;
                    DataAuthorization.C3 = 1;
                    DataAuthorization.C4 = 1;
                    DataAuthorization.C5 = 1;
                    DataAuthorization.C6 = 1;
                    DataAuthorization.C7 = 1;
                    DataAuthorization.C8 = 1;
                    DataAuthorization.C9 = 1;
                    DataAuthorization.C10 = 1;
                    DataAuthorization.C11 = 1;
                    DataAuthorization.C12 = 1;
                    DataAuthorization.C13 = 1;
                    DataAuthorization.C14 = 1;
                    DataAuthorization.C15 = 1;
                    DataAuthorization.C16 = 1;
                    DataAuthorization.C17 = 1;
                    DataAuthorization.C18 = 1;
                    DataAuthorization.C19 = 1;
                    DataAuthorization.C20 = 1;
                    DataAuthorization.C21 = 1;
                    DataAuthorization.C22 = 1;
                    DataAuthorization.C23 = 1;
                    DataAuthorization.C24 = 1;
                    DataAuthorization.C25 = 1;
                    DataAuthorization.C26 = 1;
                    DataAuthorization.C27 = 1;
                    DataAuthorization.C28 = 1;
                    DataAuthorization.C29 = 1;
                    DataAuthorization.C30 = 1;
                    DataAuthorization.C31 = 1;
                    DataAuthorization.C32 = 1;
                    DataAuthorization.C33 = 1;
                    DataAuthorization.C34 = 1;
                    DataAuthorization.C35 = 1;
                }

                selectFocusId = UserBll.MyCrud(islemturu, Data, DataAuthorization);
            }

            if (IslemTuru.Update == islemturu)
            {
                Check_OnlineUser_Update(Data.Id); //Aktif olan kullanıcıde değişiklik olacak ise tekrar login olmasını sağlar
            }

            var myList = UserBll.ListRefresh(_title, _department);
            Tablo.GridControl.DataSource = myList;
            Tablo.RowFocus("Id", selectFocusId);


        }

        private void Yenile()
        {
            //Tablo.GridControl.DataSource = null;

            //string URI                  = Var_JSON.URI.Users;
            //ConnWebAPI.SET_Get(URI, out string OutNewDataJson);
            //var JsonResult              = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Model.Users>>(OutNewDataJson);
            //List<ModelDataEdit> MyList  = new List<ModelDataEdit>();
            //if (JsonResult != null)
            //{
            //    for (int i = 0; i < JsonResult.Count; i++)
            //    {
            //        ModelDataEdit Data  = new ModelDataEdit();
            //        Data.Id             = JsonResult[i].Id;
            //        Data.SysCode        = JsonResult[i].SysCode;

            //        Data.CreateDate     = JsonResult[i].CreateDate;
            //        Data.UpdateDate     = JsonResult[i].UpdateDate;
            //        Data.DeleteDate     = JsonResult[i].DeleteDate;

            //        Data.UserId         = JsonResult[i].UserId;
            //        Data.VarStatus      = JsonResult[i].VarStatus;

            //        Data.Role           = JsonResult[i].Role;
            //        Data.UId            = JsonResult[i].UId;
            //        Data.UserId         = JsonResult[i].UserId;
            //        Data.AutrizationId  = JsonResult[i].AutrizationId;
            //        Data.LevelsId       = JsonResult[i].LevelsId;
            //        Data.OnlineId       = JsonResult[i].OnlineId;
            //        Data.DepartmentId   = JsonResult[i].DepartmentId;
            //        Data.TitleId        = JsonResult[i].TitleId;
            //        Data.Comment        = JsonResult[i].Comment;
            //        Data.Pic            = JsonResult[i].Pic;
            //        Data.BirthDate      = JsonResult[i].BirthDate;
            //        Data.NameFirst      = JsonResult[i].NameFirst;
            //        Data.NameLast       = JsonResult[i].NameLast;
            //        Data.Mail1          = Crypto.Decrypt(JsonResult[i].Mail1, Global.Str_ProjeCrypto);
            //        Data.Mail2          = Crypto.Decrypt(JsonResult[i].Mail2, Global.Str_ProjeCrypto); 
            //        Data.Phone1         = Crypto.Decrypt(JsonResult[i].Phone1, Global.Str_ProjeCrypto);
            //        Data.Phone2         = Crypto.Decrypt(JsonResult[i].Phone2, Global.Str_ProjeCrypto);
            //        Data.UserName       = Crypto.Decrypt(JsonResult[i].UserName, Global.Str_ProjeCrypto);
            //        Data.Pass           = Crypto.Decrypt(JsonResult[i].Pass, Global.Str_ProjeCrypto);

            //        var getTitleName    = _title.Where(x => x.Id == Data.TitleId).FirstOrDefault();
            //        if (getTitleName != null)
            //        {
            //            Data.TitleName = getTitleName.Name;
            //        }

            //        var getDeparmentName = _department.Where(x => x.Id == Data.DepartmentId).FirstOrDefault();
            //        if (getDeparmentName != null)
            //        {
            //            Data.DepartmentName = getDeparmentName.Name;
            //        }


            //        MyList.Add(Data);
            //    }

            //    Tablo.GridControl.DataSource = MyList;
            //}

        }


        private void Check_OnlineUser_Update(long ID)
        {
            if (Dynamic.OnlineUser.Id == ID)
            {
                //UserLoginLogout.ReLoginCheck(Dynamic.OnlineUser.UserName, Dynamic.OnlineUser.Pass);
            }
        }
    }
}


//            switch (islemturu)
//            {
//                case IslemTuru.Insert:
//                    if (_dataReadOk)
//                    {
//                        Var_JSON.Work_Support sup1 = new Var_JSON.Work_Support();
//sup1.JSon_URI               = URI;
//                        sup1.SelectDataID           = Data.Id.ToString();
//                        sup1.JsonSerializeObj       = Data;
//                        sup1.Islemturu              = IslemTuru.Insert;
//                        var Res1 = Var_JSON.Work(sup1);
//                        if (Res1 != null)
//                        {
//                            if (Res1 == "Created")
//                            {
//                            }
//                        }
//                    }
//                    goto case IslemTuru.ListRefresh;
//                case IslemTuru.Update:
//                    if (_dataReadOk)
//                    {
//                        Var_JSON.Work_Support sup2 = new Var_JSON.Work_Support();
//sup2.JSon_URI               = URI;
//                        sup2.SelectDataID           = Data.Id.ToString();
//                        sup2.JsonSerializeObj       = Data;
//                        sup2.Islemturu              = IslemTuru.Update;
//                        var Res2 = Var_JSON.Work(sup2);

//Check_OnlineUser_Update(Data.Id); //Aktif olan kullanıcıde değişiklik olacak ise tekrar login olmasını sağlar
//                    }
//                    goto case IslemTuru.ListRefresh;
//                case IslemTuru.Delete:
//                    Var_JSON.Work_Support sup3 = new Var_JSON.Work_Support();
//sup3.JSon_URI               = URI;
//                    sup3.SelectDataID           = Data.Id.ToString();
//                    sup3.JsonSerializeObj       = Data;
//                    sup3.Islemturu              = IslemTuru.Delete;
//                    var Res3 = Var_JSON.Work(sup3);

//                    goto case IslemTuru.ListRefresh;
//                case IslemTuru.ListRefresh:
//                    Yenile();
//                    break;
//            }