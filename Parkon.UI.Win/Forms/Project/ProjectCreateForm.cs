using DevExpress.XtraBars;
using Prkn.Bll.FileDirectory;
using Prkn.Bll.Master.PrknDataBll.Customer;
using Prkn.Bll.Master.PrknDataBll.Project;
using Prkn.Common.Design.Controls;
using Prkn.Common.Enums;
using Prkn.Common.Functions;
using Prkn.Common.Generate;
using Prkn.Common.Variables;
using Prkn.UI.Win.DBOrganizer;
using Prkn.UI.Win.Forms.Base;
using Prkn.UI.Win.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using static Prkn.Common.Variables.Static;

namespace Prkn.UI.Win.Forms.Project
{
    public partial class ProjectCreateForm : BaseListEditFreeLayoutForm
    {
        long _selectedCustomerId;
        long _selectedCustomerSectionId;
        long _selectedCustomerContactId;
        bool _layout_ControllerFull_OK = false;
        int _lastDateStart;
        int _tabloFocusRow;
        List<Model.Customers> _customers;
        List<Model.Customer_Section> _customerSection;
        List<Model.Customer_Contact> _customerContact;

        ShowDialogFormSec _popupShowDialogSecimi;

        public ProjectCreateForm()
        {
            _userScreen = UserScreen.yonetim;
            Yukle();

            InitializeComponent();

            DataLayoutControl = myDataLayoutControl1;
            Tablo = baseTablo;
            Navigator.NavigatableControl = Tablo.GridControl;

            Text = "PROJELER";
            Tablo.ViewCaption = Text;
            PictureSource = PictureSourceType.Customer;


            EventsLoad();
            EventsLoadForList();
            ListeRefresh();

            LayoutEvents();
            GetListData();
        }
        void LayoutEvents()
        {
            txtMyCustomerName.SelectedValueChanged          += TxtCustomer_SelectedValueChanged;
            txtMyCustomerSectionName.SelectedValueChanged   += TxtCustomerSection_SelectedValueChanged;
            txtCustomerContactId.SelectedValueChanged       += TxtCustomerContact_SelectedValueChanged;
            txtName.TextChanged                             += TxtName_TextChanged;
            txtDateStart.EditValueChanged                   += TxtDateStart_EditValueChanged;
            btnAddCustomer.Click                            += BtnAddCustomer_Click;
            btnAddCustomerContact.Click                     += BtnAddCustomerContact_Click;
            btnAddCustomerSection.Click                     += BtnAddCustomerSection_Click;

            txtName.KeyPress                                += TextCorrection.TextEdit_KeyPressForUpperEnglish;
            txtKeyword.ValidateToken                        += GeneralFunctions.Keywords_ValidateToken;

            Tablo.FocusedRowChanged                         += Tablo_FocusedRowChanged;
        }

        private void BtnAddCustomerSection_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://192.168.2.31/Musteri/MusteriBolumuEdit/Insert/0");
            Process.Start(sInfo);
        }
        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {

            ProcessStartInfo sInfo = new ProcessStartInfo("http://192.168.2.31/Musteri/MusteriKisiEdit/Insert/0");
            Process.Start(sInfo);
        }
        private void BtnAddCustomerContact_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://192.168.2.31/Musteri/MusteriRehberiEdit/Insert/0");
            Process.Start(sInfo);
        }

        private void Tablo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _tabloFocusRow = Tablo.FocusedRowHandle;
        }

        private void TxtDateStart_EditValueChanged(object sender, EventArgs e)
        {
            if (txtDateStart.EditValue == null || txtDateStart.DateTime.Year < 1900)
            {
                txtDateStart.EditValue = DateTime.Now;
            }

            //GetProjectCode();
            LayoutControllerEnableDisable();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            //GetProjectCode();
        }

        void GetProjectCode()
        {
            if (_tabloFocusRow == Tablo.FocusedRowHandle)
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
                    }

                    if (_lastDateStart != txtDateStart.DateTime.Year)
                    {
                        txtRefNo.Text = Generator.CreateRefNo(IslemTuru.Insert, 0).ToString();
                    }
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
                txtKeyword.Enabled = false;
            }
            else
            {
                txtName.Enabled = true;
                txtComment.Enabled = true;
                txtRefNo.Enabled = true;
                txtKeyword.Enabled = true;
            }


        }
        void ComboBoxCheckAndListRefresh()
        {
            if (!string.IsNullOrEmpty(txtMyCustomerName.Text) && !string.IsNullOrEmpty(txtMyCustomerSectionName.Text))
            {
                YapilacakIslem(IslemTuru.ListRefresh);
            }
            else
            {
                Tablo.GridControl.DataSource = null;
            }
        }


        #region ComboBox & DataFilling
        void GetListData()
        {
            FillingList();
            ComboBoxCustomerData();
        }

        void FillingList()
        {





        }

        private void ComboBoxCustomerData()
        {
            CustomerBll customerBll = new CustomerBll();
            _customers = customerBll.GetList(null, x => x).OrderBy(x => x.Name).ToList();

            GeneralFunctions.ComboBoxDataFillingFromList(_customers, txtMyCustomerName);
        }
        private void ComboBoxCustomerSectionData(long customerId)
        {
            CustomerSectionBll customerSectionBll = new CustomerSectionBll();
            _customerSection = customerSectionBll.ListRefresh();

            var mylist = _customerSection.Where(x => x.CustomerId == customerId).OrderBy(x => x.Name).ToList();
            GeneralFunctions.ComboBoxDataFillingFromList(mylist, txtMyCustomerSectionName);
        }
        private void ComboBoxCustomerContactData(long customerId)
        {
            CustomerContactBll customerContactBll = new CustomerContactBll();
            _customerContact = customerContactBll.ListRefresh();

            var mylist = _customerContact.Where(x => x.CustomerId == customerId).OrderBy(x => x.NameFirst).ToList();
            GeneralFunctions.ComboBoxDataFillingFromListForContact(mylist, txtCustomerContactId);
        }

        private void TxtCustomerContact_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _selectedCustomerContactId = 0;

            if (senderSelectItem != null && senderSelectItem != "")
            {
                var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
                long.TryParse(senderSelectValue.ToString(), out _selectedCustomerContactId);

                LayoutControllerEnableDisable();
            }

            LayoutControllerEnableDisable();
        }
        private void TxtCustomerSection_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _selectedCustomerSectionId = 0;

            if (senderSelectItem != null && senderSelectItem != "")
            {
                var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
                long.TryParse(senderSelectValue.ToString(), out _selectedCustomerSectionId);

                LayoutControllerEnableDisable();
            }

            ComboBoxCustomerContactData(_selectedCustomerId);
            LayoutControllerEnableDisable();
            ComboBoxCheckAndListRefresh();
        }
        private void TxtCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _selectedCustomerId = 0;
            if (senderSelectItem != null && senderSelectItem != "")
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

                ComboBoxCustomerSectionData(_selectedCustomerId);
                ComboBoxCustomerContactData(_selectedCustomerId);
            }

            LayoutControllerEnableDisable();
            ComboBoxCheckAndListRefresh();
        }
        #endregion

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
            var Data                    = new Model.Projects();                             // Contollerdan gelen ve Fonksiyon içinde kullanılacak Data
            var _aktifDataFromTable     = new Model.Projects();                             // Fonksiyon içinde kullanılacak Data
            var _propertyFilling        = GeneralFunctions.ClassPropertyFilling(AktifData, _aktifDataFromTable);
            long selectFocusId          = 0;                                                // İşlem yapıldıktan sonra focus olacak ID

            if (IslemTuru.ListRefresh != islemturu)
            {
                if (IslemTuru.Insert != islemturu)
                {
                    if (_propertyFilling)
                    {
                        Data = _aktifDataFromTable;
                    }

                    if (IslemTuru.Update == islemturu && !_propertyFilling)             //Tablo boş ve gelen işlem Update ise Insert işlemine geç
                    {
                        islemturu = IslemTuru.Insert;
                    }
                }


                List<object> OutOfCheck = new List<object>
                {
                    txtCode,
                    txtComment,
                    txtRefNo
                };

                if (Checks.DataLayoutValueFillingOK(DataLayoutControl, OutOfCheck))
                {
                    Dynamic.OnlineUser.Id   = 1;
                    Data.Id                 = Generator.CreateId(islemturu, Data.Id);
                    Data.UserId             = Dynamic.OnlineUser.Id;
                    Data.CustomerContactId  = _selectedCustomerContactId;
                    Data.CustomerId         = _selectedCustomerId;
                    Data.CustomerSectionId  = _selectedCustomerSectionId;

                    Data.SysCode            = "";
                    Data.Code               = "";
                    Data.No                 = "";
                    Data.Name               = txtName.Text;
                    Data.Comment            = txtComment.Text;
                    Data.Keyword            = txtKeyword.EditValue.ToString();
                    txtRefNo.Text           = Generator.CreateRefNo(islemturu, _aktifDataFromTable.RefNo).ToString();

                    if (long.TryParse(txtRefNo.Text, out long refNo))
                    {
                        Data.RefNo = refNo;
                    }
                    else
                    {
                        MessageBox.Show("Proje Referans No oluşturulurken bir hata meydana geldi. Lütfen sayfayı kapatıp bilgileri yeniden girin.", "Proje Referans No Oluşturma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    string prjCode = "";
                    if (islemturu == IslemTuru.Insert)
                    {
                        prjCode = CodeGet(txtDateStart.DateTime.Year);
                        DialogResult r = MessageBox.Show("Oluşturulan proje için yeni üretilen proje kodu: " + prjCode, "Proje Kodu Kontrolü", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (r == DialogResult.Cancel)
                        {
                            return;
                        }

                        txtCode.Text = prjCode;
                        Data.Code = prjCode;
                        Data.DateStart = txtDateStart.DateTime;
                        Data.CreateDate = DateTime.Now;

                        CreateProjectFolder(Data);
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

                    Data.DateStart = txtDateStart.DateTime;
                }
                else
                {
                    return;
                }

                if (islemturu != IslemTuru.ListRefresh)
                {
                    //if (!CLS.MainForm.B_DBOffline.Visible)
                    //{
                    //    ProjectBll projectBll = new ProjectBll();
                    //    selectFocusId = projectBll.MyCrud(islemturu, Data);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Prkn DB Server ile bağlantı kurmadan kayıt işlemi yapamaz! Bağlantınızı kontrol ederek tekrar deneyin.", "Prkn - DB Server Bağlantı Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}
                }

            
            }


            TableListRefresh();
            if (selectFocusId > 0)
            {
                Tablo.RowFocus("Id", selectFocusId);
            }
            else
            {
                Tablo.FocusedRowHandle = -2147483646; //Filtre satırını seçmek için bu değer gönderilir.
            }

            StatusTxt(islemturu, Data, barStaticStatusInfo);
        }


        void TableListRefresh()
        {
            ProjectBll projectBll = new ProjectBll();
            var myList = projectBll.GetList(x => x.CustomerId == _selectedCustomerId && x.CustomerSectionId == _selectedCustomerSectionId, x => x).ToList();

            List<ProjectListTable> DataTableList = new List<ProjectListTable>();

            for (int i = 0; i < myList.Count(); i++)
            {
                ProjectListTable data = new ProjectListTable();

                data.Code               = myList[i].Code;
                data.Comment            = myList[i].Comment;
                data.CreateDate         = myList[i].CreateDate;
                data.CustomerContactId  = myList[i].CustomerContactId;
                data.CustomerId         = myList[i].CustomerId;
                data.Customers          = myList[i].Customers;
                data.CustomerSectionId  = myList[i].CustomerSectionId;
                data.Customer_Contact   = myList[i].Customer_Contact;
                data.Customer_Section   = myList[i].Customer_Section;
                data.DateEnd            = myList[i].DateEnd;
                data.DateStart          = myList[i].DateStart;
                data.DeleteDate         = myList[i].DeleteDate;
                data.Id                 = myList[i].Id;
                data.Keyword            = myList[i].Keyword;
                data.Name               = myList[i].Name;
                data.No                 = myList[i].No;
                data.PeriodMonth        = myList[i].PeriodMonth;
                data.PeriodYear         = myList[i].PeriodYear;
                data.ProjectDetailId    = myList[i].ProjectDetailId;
                data.Project_Detail     = myList[i].Project_Detail;
                data.Project_Rev        = myList[i].Project_Rev;
                data.RefNo              = myList[i].RefNo;
                data.RefNoOld           = myList[i].RefNoOld;
                data.SysCode            = myList[i].SysCode;
                data.Tasks              = myList[i].Tasks;
                data.UpdateDate         = myList[i].UpdateDate;
                data.UserId             = myList[i].UserId;
                data.Users              = myList[i].Users;
                data.VarStatus          = myList[i].VarStatus;

                if (myList[i].CustomerId != null)
                {
                    var Customer  = _customers.Where(x => x.Id == myList[i].CustomerId).FirstOrDefault();
                    if (Customer != null)
                    {
                        data.CustomerName = Customer.Name;
                    }
                    
                }
              

                if (myList[i].CustomerSectionId != null)
                {
                    var CustomerSection = _customerSection.Where(x => x.Id == myList[i].CustomerSectionId).FirstOrDefault();
                    if (CustomerSection != null)
                    {
                        data.CustomerSectionName = CustomerSection.Name;
                    }
             
                }
             

                if (myList[i].CustomerContactId != null)
                {
                    var contactFullName = _customerContact.Where(x => x.Id == myList[i].CustomerContactId).FirstOrDefault();

                    if (contactFullName != null)
                    {
                        data.CustomerContactName = contactFullName.NameFirst + " " + contactFullName.NameLast;
                    }
              
                }
        
                DataTableList.Add(data);
            }
            Tablo.ClearSelection();
            Tablo.GridControl.DataSource = DataTableList;
        }

        string CodeGet(int ProjectYear)
        {
            ProjectBll projectBll   = new ProjectBll();
            var ProjectList         = projectBll.ListRefresh();
            var getVal              = ProjectList.Count(x => x.DateStart.Value.Year == ProjectYear && x.VarStatus != "Deleted");
            var NewCount            = getVal + 1;
            var year                = ProjectYear.ToString().Remove(0, 2);
            return "P" + year + "e" + UcBasamakYap(NewCount.ToString());
        }
        string UcBasamakYap(string val)
        {
            switch (val.Length)
            {
                case 1:
                    return "00" + val;
                case 2:
                    return "0" + val;
            }
            return val;
        }




        private static void CreateProjectFolder(Model.Projects InsertDataInfo)
        {
            CustomerBll customerBll     = new CustomerBll();
            string customerName         = customerBll.GetSingle(x => x.Id == InsertDataInfo.CustomerId, x => x).Name;

            var refNo                   = InsertDataInfo.RefNo.ToString();
            var projectName             = InsertDataInfo.Name;
            var projectStartDate        = InsertDataInfo.DateStart.ToString();

            var createDate              = InsertDataInfo.CreateDate.ToString();
            var updateDate              = InsertDataInfo.UpdateDate.ToString();
            var comment                 = InsertDataInfo.Comment;
            var projectId               = InsertDataInfo.Id.ToString();
            var user                    = CLS.OnlineUser.NameFirst + " " + CLS.OnlineUser.NameLast;

            var projectInfo = "Proje Referans No: "   + refNo               + Environment.NewLine +
                                "Proje Adı:         " + projectName         + Environment.NewLine +
                                "Proje Id:          " + projectId           + Environment.NewLine +
                                "Proje Baş.Tarihi:  " + projectStartDate    + Environment.NewLine +
                                "Açıklama:          " + comment             + Environment.NewLine + Environment.NewLine +
                                "Oluşturma Tarihi:  " + createDate          + Environment.NewLine +
                                "Kullanıcı:         " + user                + Environment.NewLine;

            DirectoryBll.CreateFolderProject(customerName, refNo, projectName, projectInfo);
        }
        public static void StatusTxt(IslemTuru islemturu, Model.Projects projects, BarStaticItem barStaticStatusInfo)
        {
            switch (islemturu)
            {
                case IslemTuru.Insert:

                    barStaticStatusInfo.Caption = "Son İşlem: " + DateTime.Now.ToString() + "  ''"
                                                + projects.Name + "'' adında yeni bir proje oluşturuldu. Referans No: P" + projects.RefNo;
                    break;
                case IslemTuru.Update:
                    barStaticStatusInfo.Caption = "Son İşlem: " + DateTime.Now.ToString() + "  ''"
                                                + projects.Name + "'' adındaki proje güncellendi. Referans No: P" + projects.RefNo;
                    break;
                case IslemTuru.Delete:

                    break;
                case IslemTuru.ListRefresh:
                    barStaticStatusInfo.Caption = "Son İşlem: " + DateTime.Now.ToString() + "  " + "Liste yenilendi.";

                    break;
                default:
                    break;
            }
        }



        class ProjectListTable : Model.Projects
        {
            public string CustomerName { get; set; }
            public string CustomerSectionName { get; set; }
            public string CustomerContactName { get; set; }
        }
}
}