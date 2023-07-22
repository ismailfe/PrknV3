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
using Emikon.Parkon.Common.Functions;
using Emikon.Parkon.Common.Variables;
using Emikon.Model;
using Emikon.Parkon.Common.Design.Controls;
using static Emikon.Parkon.Common.Variables.Static;
using Emikon.Parkon.Common.Message;
using Emikon.Parkon.Common.Generate;
using Emikon.Parkon.UI.Win.Functions;
using DevExpress.XtraLayout.HitInfo;
using DevExpress.XtraLayout;
using DevExpress.XtraBars;
using Emikon.Parkon.Bll.General;
using Emikon.Parkon.Bll.Customer;
using Emikon.Parkon.Bll.Project;

namespace Emikon.Parkon.UI.Win.Forms.Project
{
    public partial class RevCreateForm : BaseListEditFreeLayoutForm
    {
        long _selectedCustomerId;
        long _selectedCustomerSectionId;
        long _selectedCustomerContactId;
        long _selectedProjectId;
        bool _layout_ControllerFull_OK = false;
        int _lastDateStart;
       List<Model.Customers> _customers;
       List<Model.Customer_Contact> _customerContact;
       List<Model.Customer_Section> _customerSection;
       List<Model.Projects> _projects;

        ShowDialogFormSec _popupShowDialogSecimi;

        public RevCreateForm()
        {
            _userScreen = UserScreen.ProjeYeniRev;
            Yukle();
            InitializeComponent();
              
            DataLayoutControl               = myDataLayoutControl1;
            Tablo                           = baseTablo;
            Navigator.NavigatableControl    = Tablo.GridControl;

            EventsLoad();
            EventsLoadForList();
            ListeRefresh();

            Text                            = "REVİZYONLAR";
            Tablo.ViewCaption               = Text;
            PictureSource                   = PictureSourceType.Customer;

            LayoutEvents();
    

            PopupMenuEditLoad();

            GetListData(); //Gerekli Dataları SQL den çek
        }


        void LayoutEvents()
        {
            txtMyCustomerName.SelectedValueChanged          += TxtCustomer_SelectedValueChanged;
            txtMyCustomerSectionName.SelectedValueChanged   += TxtCustomerSection_SelectedValueChanged;
            txtCustomerContactId.SelectedValueChanged       += TxtCustomerContact_SelectedValueChanged;
            txtMyProjectName.SelectedValueChanged           += TxtMyProjectName_SelectedValueChanged;
            txtName.TextChanged                             += TxtName_TextChanged;
            txtDateStart.EditValueChanged                   += TxtDateStart_EditValueChanged;

            txtMyCustomerName.MouseDown                     += Txt_MouseDown;
            txtMyProjectName.MouseDown                      += Txt_MouseDown;
            txtMyCustomerSectionName.MouseDown              += Txt_MouseDown;

            txtName.KeyPress                                += TextCorrection.TextEdit_KeyPressForUpperEnglish;
        }

        private void TxtDateStart_EditValueChanged(object sender, EventArgs e)
        {
            if (txtDateStart.EditValue == null || txtDateStart.DateTime.Year < 1900)
            {
                txtDateStart.EditValue = DateTime.Now;
            }

            GetProjectCode();

            LayoutControllerEnableDisable();
        }

        private void PopupMenuEditLoad()
        {
            //Button Events
            foreach (var item in popMenuEdit.Manager.Items)
            {
                switch (item)
                {
                    case BarItem button:
                        button.ItemClick += PopMenuEdit_ItemClick;
                        break;
                }
            }
        }
        private void PopMenuEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnEdit)
            {
                FormOpen.PopMenuEdit_ItemClick(_popupShowDialogSecimi);
            }
        }
        private void Txt_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (sender == txtMyCustomerName)
                {
                    _popupShowDialogSecimi = ShowDialogFormSec.CustomerForm;
                }
                else if(sender == txtMyCustomerSectionName)
                {
                    _popupShowDialogSecimi = ShowDialogFormSec.CustomerSectionForm;
                }
                else if (sender == txtMyProjectName)
                {
                    _popupShowDialogSecimi = ShowDialogFormSec.CreateProjectFrom;
                }
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            GetProjectCode();
        }

        void GetProjectCode()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                txtRefNo.Text = string.Empty;
                txtCode.Text = string.Empty;
            }
            else
            {
                if (string.IsNullOrEmpty(txtRefNo.Text))
                {
                    txtRefNo.Text = Generator.CreateRefNo(IslemTuru.Insert, 0).ToString();
                }

                if (string.IsNullOrEmpty(txtCode.Text))
                {
                    txtCode.Text = ProjectBll.Code(txtDateStart.DateTime.Year);
                }

                if (_lastDateStart != txtDateStart.DateTime.Year)
                {
                    txtRefNo.Text = Generator.CreateRefNo(IslemTuru.Insert, 0).ToString();
                    txtCode.Text = ProjectBll.Code(txtDateStart.DateTime.Year);
                }
            }
        }


        private void LayoutControllerEnableDisable()
        {
            if (string.IsNullOrEmpty(txtMyCustomerName.Text) || string.IsNullOrEmpty(txtMyCustomerSectionName.Text) || string.IsNullOrEmpty(txtCustomerContactId.Text))
            {
                txtDateStart.Enabled = false;
            }
            else
            {
                txtDateStart.Enabled = true;
            }

            if (string.IsNullOrEmpty(txtMyCustomerName.Text) || string.IsNullOrEmpty(txtMyCustomerSectionName.Text) || string.IsNullOrEmpty(txtCustomerContactId.Text)
            || string.IsNullOrEmpty(txtDateStart.Text))
            {
                txtName.Enabled = false;
                txtComment.Enabled = false;
                txtRefNo.Enabled = false;
                //txtDateStart.Enabled            = false;
                //txtProjectCode.Enabled             = false;
                txtKeyword.Enabled = false;
                //myCheckRefNoOldEnable.Enabled   = false;
            }
            else
            {
                txtName.Enabled = true;
                txtComment.Enabled = true;
                txtRefNo.Enabled = true;
                //txtDateStart.Enabled            = true;
                txtKeyword.Enabled = true;
                //myCheckRefNoOldEnable.Enabled   = true;
                //txtRefNoOld.Enabled = myCheckRefNoOldEnable.Checked;
            }


        }

        void ComboBoxCheckAndListRefresh()
        {
            if (!string.IsNullOrEmpty(txtMyCustomerName.Text) && !string.IsNullOrEmpty(txtMyCustomerSectionName.Text) && !string.IsNullOrEmpty(txtMyProjectName.Text))
            {
                YapilacakIslem(IslemTuru.ListRefresh);
            }
            else
            {
                Tablo.GridControl.DataSource = null;
            }
        }

        private void GetListData()
        {
            _customers          = CustomerBll.GetList<Model.Customers>();
            _customerSection    = CustomerSectionBll.GetList<Model.Customer_Section>();  //GeneralFunctions.ListDataFilling<Model.Customer_Section>(Var_JSON.URI.Customer_Section);
            _customerContact    = CustomerContactBll.GetList<Model.Customer_Contact>();  //GeneralFunctions.ListDataFilling<Model.Customer_Contact>(Var_JSON.URI.Customer_Contact);
            _projects           = ProjectBll.GetList<Model.Projects>();                  //GeneralFunctions.ListDataFilling<Model.Projects>(Var_JSON.URI.Projects);

            ComboBoxCustomerData();
        }
        private void ComboBoxCustomerData()
        {
            GeneralFunctions.ComboBoxDataFillingFromList(_customers, txtMyCustomerName);
        }
        private void ComboBoxCustomerSectionData(long customerId)
        {
            var listfilter = _customerSection.Where(x => x.CustomerId == customerId).ToList();
            GeneralFunctions.ComboBoxDataFillingFromList(listfilter, txtMyCustomerSectionName);
        }
        private void ComboBoxCustomerContactData(long customerId)
        {
            var listfilter = _customerContact.Where(x => x.CustomerId == customerId).ToList();
            GeneralFunctions.ComboBoxDataFillingFromListForContact(listfilter, txtCustomerContactId);
        }
        private void ComboBoxProjectData(long customerId, long customerSectionId)
        {
            var listfilter = _projects.Where(x => x.CustomerId == customerId && x.CustomerSectionId == customerSectionId).ToList();
            GeneralFunctions.ComboBoxDataFillingFromList(listfilter, txtMyProjectName);
            YapilacakIslem(IslemTuru.ListRefresh);
        }

        private void TxtMyProjectName_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _selectedProjectId = 0;
            if (senderSelectItem != null)
            {
                if (senderSelectItem != "")
                {
                    var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
                    long.TryParse(senderSelectValue.ToString(), out _selectedProjectId);

                    bool _status = false;
                    if (((MyComboBoxEdit)sender).Name != null)
                    {
                        _status = true;
                    }
                }

            }

            LayoutControllerEnableDisable();
            ComboBoxCheckAndListRefresh();
        }
        private void TxtCustomerContact_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _selectedCustomerContactId = 0;
            if (senderSelectItem != null)
            {
                if (senderSelectItem != "")
                {
                    var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
                    long.TryParse(senderSelectValue.ToString(), out _selectedCustomerContactId);

                    bool _status = false;
                    if (((MyComboBoxEdit)sender).Name != null)
                    {
                        _status = true;
                    }
                }
            }

            LayoutControllerEnableDisable();
        }
        private void TxtCustomerSection_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _selectedCustomerSectionId = 0;
            if (senderSelectItem != null)
            {
                if (senderSelectItem != "")
                {
                    var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
                    long.TryParse(senderSelectValue.ToString(), out _selectedCustomerSectionId);

                    bool _status = false;
                    if (((MyComboBoxEdit)sender).Name != null)
                    {
                        _status = true;
                    }
                    ComboBoxProjectData(_selectedCustomerId, _selectedCustomerSectionId);
                }
            }

            LayoutControllerEnableDisable();
            ComboBoxCheckAndListRefresh();
        }
        private void TxtCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _selectedCustomerId = 0;
            if (senderSelectItem != null)
            {
                var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
                long.TryParse(senderSelectValue.ToString(), out _selectedCustomerId);

                bool _status = false;
                if (((MyComboBoxEdit)sender).Name != null)
                {
                    _status = true;
                }

                _selectedCustomerContactId = 0;
                _selectedCustomerSectionId = 0;
                _selectedProjectId = 0;
                
                ComboBoxCustomerSectionData(_selectedCustomerId);
                ComboBoxCustomerContactData(_selectedCustomerId);
                ComboBoxProjectData(_selectedCustomerId, _selectedCustomerSectionId);
            }
            LayoutControllerEnableDisable();
            ComboBoxCheckAndListRefresh();
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
            Cursor.Current                  = Cursors.WaitCursor;
            bool _dataReadOk                = false;
            string URI                      = Var_JSON.URI.Project_Rev;
            var Data                        = new Model.Project_Rev();                 // Contollerdan gelen ve Fonksiyon içinde kullanılacak Data
            var _aktifDataFromTable         = new Model.Project_Rev();                 // Fonksiyon içinde kullanılacak Data
            var _propertyFilling            = GeneralFunctions.ClassPropertyFilling(AktifData, _aktifDataFromTable);
            long selectFocusId              = 0;                                       // İşlem yapıldıktan sonra focus olacak ID
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
                    //txtKeyword,
                    //txtComment,
                    //txtCode,
                };

                if (Checks.DataLayoutValueFillingOK(DataLayoutControl, OutOfCheck))
                {
                    Data.Id                     = Generator.CreateId(islemturu, Data.Id);
                    Data.UserId                 = Dynamic.OnlineUser.Id;

                    //long.TryParse((txtCustomerContactId.SelectedItem as dynamic).Value, out long customerContactId);
                    Data.CustomerContactId      = _selectedCustomerContactId;

                    //long.TryParse((txtMyProjectName.SelectedItem as dynamic).Value, out long projectId);
                    Data.ProjectId              = _selectedProjectId;

                    //long.TryParse((txtMyCustomerName.SelectedItem as dynamic).Value, out long customerId);
                    //Data.CustomerId             = customerId;
                    //long.TryParse((txtMyCustomerSectionName.SelectedItem as dynamic).Value, out long customerSectionId);
                    //Data.CustomerSectionId      = customerSectionId;

                    Data.SysCode                = "";
                    Data.Code                   = "";
                    Data.Name                   = txtName.Text;
                    Data.Comment                = txtComment.Text;

                    txtRefNo.Text               = Generator.CreateRefNo(islemturu, _aktifDataFromTable.RefNo).ToString();
                    if (long.TryParse(txtRefNo.Text, out long refNo))
                        Data.RefNo                  = refNo;

                    string prjCode = "";

                    if (islemturu == IslemTuru.Insert)
                    {
                        prjCode = ProjectBll.Code(txtDateStart.DateTime.Year);
                        txtCode.Text = prjCode;
                        Data.Code = prjCode;
                    }
                    else
                    {
                        Data.Code = txtCode.Text;
                    }

                    if (string.IsNullOrEmpty(Data.Code))
                    {
                        MessageBox.Show("Proje Kodu oluşturulurken bir hata meydana geldi. Lütfen sayfayı kapatıp bilgileri yeniden girin.", "Proje Kodu Oluşturma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    Data.DateStart              = txtDateStart.DateTime;
                    //Data.DateEnd                = DateTime.Now;
                    _dataReadOk         = true;
                }
                else
                {
                    return;
                }

                selectFocusId = ProjectRevBll.MyCrud(islemturu, Data, _projects, txtMyCustomerName.Text, Tablo.RowCount);
            }


            var myList = ProjectRevBll.ListRefresh(_selectedProjectId, _projects, _customerContact, txtMyCustomerName.Text, txtMyCustomerSectionName.Text, txtCustomerContactId.Text);
            Tablo.GridControl.DataSource = myList;
            Tablo.RowFocus("Id", selectFocusId);
            ProjectRevBll.StatusTxt(islemturu, Data, barStaticStatusInfo);

            //            StatusTxt(islemturu, (Project_Rev)AktifData);
            //            Tablo.RowFocus("Id", Data.Id);

            Cursor.Current = Cursors.Default;
        }



//                    switch (islemturu)
//            {
//                case IslemTuru.Insert:
//                    if (_dataReadOk)
//                    {
//                        Var_JSON.Work_Support sup1 = new Var_JSON.Work_Support();
//        sup1.JSon_URI               = URI;
//                        sup1.SelectDataID           = Data.Id.ToString();
//                        sup1.JsonSerializeObj       = Data;
//                        sup1.Islemturu              = IslemTuru.Insert;
//                        var Res1 = Var_JSON.Work(sup1);
//                        if (Res1 != null)
//                        {
//                            if (Res1 == "Created")
//                            {
//                                var newVal = Newtonsoft.Json.JsonConvert.DeserializeObject<Model.Project_Rev>(sup1.ReturnResultJson);
//        AktifData = (Model.Project_Rev) newVal;
//        CreateProjectFolder(newVal); //Local PC de Dizin Oluştur.
//    }
//}
                
//                    }
//                    goto case IslemTuru.ListRefresh;
//                case IslemTuru.Update:
//                    if(_dataReadOk)
//                    { 
//                        Var_JSON.Work_Support sup2 = new Var_JSON.Work_Support();
//sup2.JSon_URI               = URI;
//                        sup2.SelectDataID           = Data.Id.ToString();
//                        sup2.JsonSerializeObj       = Data;
//                        sup2.Islemturu              = IslemTuru.Update;
//                        var Res2 = Var_JSON.Work(sup2);
//                    }
//                    goto case IslemTuru.ListRefresh;
//                case IslemTuru.Delete:
//                    Var_JSON.Work_Support sup3 = new Var_JSON.Work_Support();
//sup3.JSon_URI                   = URI;
//                    sup3.SelectDataID               = Data.Id.ToString();
//                    sup3.JsonSerializeObj           = Data;
//                    sup3.Islemturu                  = IslemTuru.Delete;
//                    var Res3 = Var_JSON.Work(sup3);

//                    goto case IslemTuru.ListRefresh;
//                case IslemTuru.ListRefresh:
//                    Yenile(_SelectedProjectId);
//                    break;
//            }
//        private void CreateProjectFolder(Project_Rev InsertDataInfo)
//        {
//            //var _uri                = Var_JSON.URI.Customers + @"?$filter=Id eq " + InsertDataInfo.CustomerId + "L";
//            //var customer            = GeneralFunctions.ListDataFilling<Model.Customers>(_uri);
//            //var getCustomerName     = customer.Where(x => x.Id == InsertDataInfo.CustomerId).FirstOrDefault();
//            //string _customerName    = string.Empty;
//            //if (getCustomerName != null)
//            //    _customerName = getCustomerName.Name;


//            var project = _projects.Where(x => x.Id == InsertDataInfo.ProjectId).FirstOrDefault();

//            var projectId = project.Id;
//            var projectName = project.Name;
//            var projectRefNo = project.RefNo;

//            var customerName = txtMyCustomerName.Text;
//            var revCount = (Tablo.RowCount + 1).ToString();

//            var refNo       = InsertDataInfo.RefNo.ToString();
//            var revName     = InsertDataInfo.Name;
//            var createDate  = InsertDataInfo.CreateDate.ToString();
//            var updateDate  = InsertDataInfo.UpdateDate.ToString();
//            var comment     = InsertDataInfo.Comment;
//            var revId       = InsertDataInfo.Id.ToString();
//            var user        = Dynamic.OnlineUser.NameFirst + " " + Dynamic.OnlineUser.NameLast;

//            var revInfo     =   "Proje Referans No:      " + projectRefNo  + Environment.NewLine +
//                                "Proje Adı:              " + projectName   + Environment.NewLine + 
//                                "Proje Id:               " + projectId     + Environment.NewLine + Environment.NewLine +

//                                "Revizyon Referans No:   " + refNo         + Environment.NewLine +
//                                "Revizyon Adı:           " + revName       + Environment.NewLine +
//                                "Revizyon Id:            " + revId         + Environment.NewLine +
//                                "Açıklama:               " + comment       + Environment.NewLine + Environment.NewLine +

//                                "Oluşturma Tarihi:       " + createDate    + Environment.NewLine +
//                                "Kullanıcı:              " + user          + Environment.NewLine;
                       

//            DirectoryOrganizer.CreateFolderRev(customerName, project.RefNo.ToString(), revName, revInfo, revCount, out string Status);
//        }

//        private void StatusTxt(IslemTuru islemturu, Project_Rev rev)
//        {
//            switch (islemturu)
//            {
//                case IslemTuru.Insert:

//                    barStaticStatusInfo.Caption = "Son İşlem: " + DateTime.Now.ToString() + "  ''" 
//                                                + rev.Name + "'' adında yeni bir Revizyon oluşturuldu. Referans No: P" + rev.RefNo;
//                    break;
//                case IslemTuru.Update:
//                    barStaticStatusInfo.Caption = "Son İşlem: " + DateTime.Now.ToString() + "  ''"
//                                                + rev.Name + "'' adındaki Revizyon güncellendi. Referans No: R" + rev.RefNo;
//                    break;
//                case IslemTuru.Delete:
//                    break;
//                case IslemTuru.ListRefresh:

//                    barStaticStatusInfo.Caption = "Son İşlem: " + DateTime.Now.ToString() + "  " + "Liste yenilendi.";
//                    break;
//                default:
//                    break;
//            }
//        }

    }
}