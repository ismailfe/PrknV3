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
using Emikon.Parkon.Bll.User;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace Emikon.Parkon.UI.Win.Forms.User
{
    public partial class UserAuthorizationForm : BaseListEditFreeLayoutForm
    {
        long _selectedUser;
        List<Model.Users> _users;
        List<Model.User_Access> _userAccess;

        public UserAuthorizationForm()
        {
            _userScreen = UserScreen.yonetim;
            Yukle();

            InitializeComponent();

            DataLayoutControl               = myDataLayoutControl1;
            Tablo                           = baseTablo;
            Navigator.NavigatableControl    = Tablo.GridControl;
            Text                            = "Kullanıcı Yetkilendirme / Ekran İzin Seçimi";
            Tablo.ViewCaption               = Text;
            PictureSource                   = PictureSourceType.Brand;

            GetListData();

            EventsLoad();
            EventsLoadForList();
            ListeRefresh();

            LayoutEvents();
        }

        void LayoutEvents()
        {
            txtHepsiniSec.SelectedIndexChanged += TxtHepsiniSec_SelectedIndexChanged;
        }
        private void TxtHepsiniSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idx = ((MyComboBoxEdit)sender).SelectedIndex;
            ComboBoxUserAccessData(idx);
        }
        void GetListData()
        {
            _users = UserBll.GetList<Model.Users>();
            _userAccess = UserAccessBll.GetList<Model.User_Access>();
            ComboBoxUserData();
            ComboBoxUserAccessData(-1);
        }
        private void ComboBoxUserData()
        {
            UserBll.GetComboBox(txtSetUserId);
        }
        private void ComboBoxUserAccessData(int SelectedIndex)
        {

            for (int i = 0; i < DataLayoutControl.Controls.Count; i++)
            {
                if (DataLayoutControl.Controls[i].Name.StartsWith("txtC"))
                {
                    GeneralFunctions.ComboBoxDataFillingFromList(_userAccess, (ComboBoxEdit)DataLayoutControl.Controls[i]);
                    if (SelectedIndex > -1)
                    {
                        if (!DataLayoutControl.Controls[i].Name.StartsWith("txtC0"))
                        {
                            ((ComboBoxEdit)DataLayoutControl.Controls[i]).SelectedIndex = SelectedIndex;
                        }
                    }
                }

                if ((SelectedIndex == -1) && (i == 0))
                {
                    GeneralFunctions.ComboBoxDataFillingFromList(_userAccess, txtHepsiniSec);
                }
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
            var Data                    = new Model.User_Authorization();                  // Contollerdan gelen ve Fonksiyon içinde kullanılacak Data
            var _aktifDataFromTable     = new Model.User_Authorization();                  // Fonksiyon içinde kullanılacak Data
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

                List<Object> obj = new List<object>();
                obj.Add(txtHepsiniSec);

                if (Checks.DataLayoutValueFillingOK(DataLayoutControl, obj))
                {
                    Data.Id         = Generator.CreateId(islemturu, Data.Id);
                    Data.UserId     = Dynamic.OnlineUser.Id;
                    Data.SetUserId  = GeneralFunctions.GetComboBoxVal<long>(txtSetUserId.SelectedItem); 
                    Data.C0 = GeneralFunctions.GetComboBoxVal<long>(txtC0.SelectedItem);
                    Data.C1 = GeneralFunctions.GetComboBoxVal<long>(txtC1.SelectedItem);
                    Data.C2 = GeneralFunctions.GetComboBoxVal<long>(txtC2.SelectedItem);
                    Data.C3 = GeneralFunctions.GetComboBoxVal<long>(txtC3.SelectedItem);
                    Data.C4 = GeneralFunctions.GetComboBoxVal<long>(txtC4.SelectedItem);
                    Data.C5 = GeneralFunctions.GetComboBoxVal<long>(txtC5.SelectedItem);
                    Data.C6 = GeneralFunctions.GetComboBoxVal<long>(txtC6.SelectedItem);
                    Data.C7 = GeneralFunctions.GetComboBoxVal<long>(txtC7.SelectedItem);
                    Data.C8 = GeneralFunctions.GetComboBoxVal<long>(txtC8.SelectedItem);
                    Data.C9 = GeneralFunctions.GetComboBoxVal<long>(txtC9.SelectedItem);
                    Data.C10 = GeneralFunctions.GetComboBoxVal<long>(txtC10.SelectedItem);
                    Data.C11 = GeneralFunctions.GetComboBoxVal<long>(txtC11.SelectedItem);
                    Data.C12 = GeneralFunctions.GetComboBoxVal<long>(txtC12.SelectedItem);
                    Data.C13 = GeneralFunctions.GetComboBoxVal<long>(txtC13.SelectedItem);
                    Data.C14 = GeneralFunctions.GetComboBoxVal<long>(txtC14.SelectedItem);
                    Data.C15 = GeneralFunctions.GetComboBoxVal<long>(txtC15.SelectedItem);
                    Data.C16 = GeneralFunctions.GetComboBoxVal<long>(txtC16.SelectedItem);
                    Data.C17 = GeneralFunctions.GetComboBoxVal<long>(txtC17.SelectedItem);
                    Data.C18 = GeneralFunctions.GetComboBoxVal<long>(txtC18.SelectedItem);
                    Data.C19 = GeneralFunctions.GetComboBoxVal<long>(txtC19.SelectedItem);
                    Data.C20 = GeneralFunctions.GetComboBoxVal<long>(txtC20.SelectedItem);
                    Data.C21 = GeneralFunctions.GetComboBoxVal<long>(txtC21.SelectedItem);
                    Data.C22 = GeneralFunctions.GetComboBoxVal<long>(txtC22.SelectedItem);
                    Data.C23 = GeneralFunctions.GetComboBoxVal<long>(txtC23.SelectedItem);
                    Data.C24 = GeneralFunctions.GetComboBoxVal<long>(txtC24.SelectedItem);
                    Data.C25 = GeneralFunctions.GetComboBoxVal<long>(txtC25.SelectedItem);
                    Data.C26 = GeneralFunctions.GetComboBoxVal<long>(txtC26.SelectedItem);
                    Data.C27 = GeneralFunctions.GetComboBoxVal<long>(txtC27.SelectedItem);
                    Data.C28 = GeneralFunctions.GetComboBoxVal<long>(txtC28.SelectedItem);
                    //Data.C29 = GeneralFunctions.GetComboBoxVal<long>(txtC29.SelectedItem);
                    //Data.C30 = GeneralFunctions.GetComboBoxVal<long>(txtC30.SelectedItem);
                    //Data.C31 = GeneralFunctions.GetComboBoxVal<long>(txtC31.SelectedItem);
                }
                else
                {
                    return;
                }
                selectFocusId =  UserAuthorizationBll.MyCrud(islemturu, Data);
            }

            var myList = UserAuthorizationBll.ListRefresh(_users);
            Tablo.GridControl.DataSource = myList;
            Tablo.RowFocus("Id", selectFocusId);
        }
    }
}