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
using Emikon.Parkon.Bll.Task;
using Emikon.Parkon.Common.Design.Controls;
using Emikon.Model;
using Emikon.Parkon.Bll.General;
using Emikon.Parkon.Bll.Project;
using static Emikon.Parkon.Common.Variables.Static;
using Emikon.Parkon.Common.Variables;
using Emikon.Parkon.Common.Generate;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Emikon.Parkon.Bll.User;
using Emikon.Parkon.Common.Design.Grid;
using Emikon.Parkon.Bll.Settings;
using System.Threading;

namespace Emikon.Parkon.UI.Win.Forms.Task
{
    public partial class TaskForm : BaseListEditFreeLayoutForm
    {
        long _selectedAssingedUserId;
        long _selectedManagerUserId;
        long _selectedProjectId;
        long _selectedStatusId;
        long _selectedPriorityId;
        long _selectedSubjectPrefixId;

        List<Model.Users> _users = new List<Users>();
        List<Model.Projects> _projects = new List<Projects>();
        List<Model.Task_Status> _task_Status = new List<Task_Status>();
        List<Model.Task_Priority> _task_Priority = new List<Task_Priority>();
        List<Model.Task_Type> _Task_Type = new List<Task_Type>();

        public TaskForm()
        {
            _userScreen = UserScreen.Gorevler;
            Yukle();
            InitializeComponent();
              
            DataLayoutControl               = myDataLayoutControl1;
            Tablo                           = baseTablo;
            Navigator.NavigatableControl    = Tablo.GridControl;

            Text                            = "GÖREVLER";
            Tablo.ViewCaption               = Text;

            EventsLoad();           // Ribbon
            EventsLoadForList();    // Ribbon

            LayoutEvents();
            GetListData();
            ListeRefresh();
            TabloCellImage();

        }
        void LayoutEvents()
        {
            txtAssingedUserId.SelectedValueChanged      += TxtAssingedUserId_SelectedValueChanged;
            txtManagerUserId.SelectedValueChanged       += TxtManagerUserId_SelectedValueChanged;
            txtPriorityId.SelectedValueChanged          += TxtPriorityId_SelectedValueChanged;
            txtStatusId.SelectedValueChanged            += TxtStatusId_SelectedValueChanged;

            Tablo.RowCellStyle                          += Tablo_RowCellStyle;
            Tablo.RowStyle                              += Tablo_RowStyle;
            Tablo.ColumnFilterChanged                   += Tablo_ColumnFilterChanged;

            btnBanaAitGorevler.Click                    += BtnBanaAitGorevler_Click;   

            txtSubject.KeyPress                         += TextCorrection.TextEdit_KeyPressForUpperEnglish;

            btnGorevGoruldu.Click += BtnGorevGoruldu_Click;
        }

        private void BtnGorevGoruldu_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Yeni eklenen görevi 'Görüldü' olarak işaretleyip bekleme durumuna alınacak Onaylıyor musunuz?", "Yeni Görev Görüldü İşlemi", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                var ComboBoxList = txtStatusId.Properties.Items.Cast<ComboboxItem>().ToList();
                var FindItemResult = ComboBoxList.Where(X => X.Text.ToString() == "BEKLEMEDE").FirstOrDefault();
                txtStatusId.SelectedItem = FindItemResult;
                YapilacakIslem(IslemTuru.Update);
            }
        }

        private void BtnBanaAitGorevler_Click(object sender, EventArgs e)
        {
            var Myfilter                = Tablo.ActiveFilterString;
            var adsoyad                 = Dynamic.OnlineUser.NameFirst + " " + Dynamic.OnlineUser.NameLast;
            Tablo.ActiveFilterString    = "[AssingedUserName] = '" + adsoyad + "'";
        }

        private void Tablo_ColumnFilterChanged(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
        }

        protected override void FiltreTemizle()
        {
            Tablo.ActiveFilterString = "";
        }

        private void TxtStatusId_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _selectedStatusId = 0;

            if (senderSelectItem != null && senderSelectItem != "")
            {
                var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
                long.TryParse(senderSelectValue.ToString(), out _selectedStatusId);
            }
            else
            {
                ((MyComboBoxEdit)sender).SelectedIndex = 1;
            }
        }
        private void TxtPriorityId_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _selectedPriorityId = 0;

            if (senderSelectItem != null && senderSelectItem != "")
            {
                var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
                long.TryParse(senderSelectValue.ToString(), out _selectedPriorityId);
            }
            else
            {
                ((MyComboBoxEdit)sender).SelectedIndex = 3;
            }
        }
        private void TxtManagerUserId_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _selectedManagerUserId = 0;

            if (senderSelectItem != null && senderSelectItem != "")
            {
                var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
                long.TryParse(senderSelectValue.ToString(), out _selectedManagerUserId);
            }
        }
        private void TxtAssingedUserId_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _selectedAssingedUserId = 0;

            if (senderSelectItem != null && senderSelectItem != "")
            {
                var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
                long.TryParse(senderSelectValue.ToString(), out _selectedAssingedUserId);
            }
        }

        void GetListData()
        {
            _users              = UserBll.GetList<Model.Users>();
            _projects           = ProjectBll.GetList<Model.Projects>();
            _task_Status        = TaskStatusBll.GetList<Model.Task_Status>();
            _task_Priority      = TaskPriorityBll.GetList<Model.Task_Priority>();
            _Task_Type          = TaskTypeBll.GetList<Model.Task_Type>();

            ComboBoxAssingedUserData();
            ComboBoxManagerUserData();
            ComboBoxTaskStatusData();
            ComboBoxTaskPriorityData();
        }

        void ComboBoxAssingedUserData()
        {
            GeneralFunctions.ComboBoxDataFillingFromListForUser(_users, txtAssingedUserId);
        }
        void ComboBoxManagerUserData()
        {
            GeneralFunctions.ComboBoxDataFillingFromListForUser(_users, txtManagerUserId);
        }
        void ComboBoxTaskStatusData()
        {
            GeneralFunctions.ComboBoxDataFillingFromList(_task_Status, txtStatusId);
        }
        void ComboBoxTaskPriorityData()
        {
            GeneralFunctions.ComboBoxDataFillingFromList(_task_Priority, txtPriorityId);
        }
        void ComboBoxTaskTypeData()
        {
            GeneralFunctions.ComboBoxDataFillingFromList(_Task_Type, txtPriorityId);
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
            Cursor.Current = Cursors.WaitCursor;
            bool _dataReadOk            = false;
            var Data                    = new Model.Tasks();                  // Contollerdan gelen ve Fonksiyon içinde kullanılacak Data
            var _aktifDataFromTable     = new Model.Tasks();                  // Fonksiyon içinde kullanılacak Data
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


                if (islemturu == IslemTuru.Insert)
                {
                    if (_selectedManagerUserId == _selectedAssingedUserId)
                    {
                        var ComboBoxList = txtStatusId.Properties.Items.Cast<ComboboxItem>().ToList();
                        var FindItemResult = ComboBoxList.Where(X => X.Text.ToString() == "BEKLEMEDE").FirstOrDefault();
                        txtStatusId.SelectedItem = FindItemResult;
                    }
                    else
                    {
                        var ComboBoxList = txtStatusId.Properties.Items.Cast<ComboboxItem>().ToList();
                        var FindItemResult = ComboBoxList.Where(X => X.Text.ToString() == "YENI").FirstOrDefault();
                        txtStatusId.SelectedItem = FindItemResult;
                    }
          
                }

                List<object> list = new List<object>();
                //list.Add(txtSubject);
                //list.Add(txtPriorityId);
                list.Add(txtEndDate);
                //list.Add(txtStartDate);
                //list.Add(txtStatusId);

                if (Checks.DataLayoutValueFillingOK(myDataLayoutControl1, list))
                {
                    Data.Id                 = Generator.CreateId(islemturu, Data.Id);
                    Data.UserId             = Dynamic.OnlineUser.Id;
                    Data.AssingedUserId     = Checks.IdCheckNullOrResult(_selectedAssingedUserId);
                    Data.ManagerUserId      = Checks.IdCheckNullOrResult(_selectedManagerUserId);
                    Data.ProjectId          = Checks.IdCheckNullOrResult(_selectedProjectId);
                    Data.SubjectPrefixId    = Checks.IdCheckNullOrResult(_selectedSubjectPrefixId);
                    Data.StatusId           = Checks.IdCheckNullOrResult(_selectedStatusId);
                    Data.PriorityId         = Checks.IdCheckNullOrResult(_selectedPriorityId);
                    Data.StartDate          = Checks.DateTimeCheckNullOrResult(txtStartDate.DateTime);
                    Data.EndDate            = Checks.DateTimeCheckNullOrResult(txtEndDate.DateTime);
                    Data.Subject            = Crypto.Encrypt(txtSubject.Text, Global.Str_ProjeCrypto);
                    Data.Description        = Crypto.Encrypt(txtDescription.Text, Global.Str_ProjeCrypto);

                    _dataReadOk     = true;
                }
                else
                {
                    return;
                }
                selectFocusId = TaskBll.MyCrud(islemturu, Data);
            }


            var myList = TaskBll.ListRefresh(_users, _projects, _task_Status, _Task_Type, _task_Priority);
            Tablo.GridControl.DataSource = myList;
            Tablo.RowFocus("Id", selectFocusId);

            FormEditEnableDisableTxt();

            Cursor.Current = Cursors.Default;
        }

        void TabloCellImage()
        {
            RepositoryItemImageComboBox imageCombo = Tablo.GridControl.RepositoryItems.Add("ImageComboBoxEdit") as RepositoryItemImageComboBox;
            DevExpress.Utils.ImageCollection images = new DevExpress.Utils.ImageCollection();
            images.AddImage(Properties.Resources.Alert16x16);
            images.AddImage(Properties.Resources.bonote_16x16);
            images.AddImage(Properties.Resources.newfeed_16x16);
            images.AddImage(Properties.Resources.status_16x16);

            imageCombo.SmallImages = images;
            imageCombo.LargeImages = images;
            imageCombo.Items.Add(new ImageComboBoxItem("ACIL", "ACIL", 0));
            imageCombo.Items.Add(new ImageComboBoxItem("GELECEK", "GELECEK", 1));
            imageCombo.Items.Add(new ImageComboBoxItem("GUN ICINDE", "GUN ICINDE", 2));
            imageCombo.Items.Add(new ImageComboBoxItem("NORMAL", "NORMAL", 3));
            //repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            Tablo.Columns["PriorityName"].ColumnEdit = imageCombo;
            Tablo.GridControl.RepositoryItems.Add(imageCombo);


            RepositoryItemImageComboBox imageCombo2 = Tablo.GridControl.RepositoryItems.Add("ImageComboBoxEdit") as RepositoryItemImageComboBox;
            DevExpress.Utils.ImageCollection images2 = new DevExpress.Utils.ImageCollection();
            images2.AddImage(Properties.Resources.newtask_16x16);
            images2.AddImage(Properties.Resources.formatnumbertime_16x16);
            images2.AddImage(Properties.Resources.redo_16x16);
            images2.AddImage(Properties.Resources.technology_16x16);
            images2.AddImage(Properties.Resources.apply_16x161);
            images2.AddImage(Properties.Resources.question_16x16);

            imageCombo2.SmallImages = images2;
            imageCombo2.LargeImages = images2;
            imageCombo2.Items.Add(new ImageComboBoxItem("YENI", "YENI", 0));
            imageCombo2.Items.Add(new ImageComboBoxItem("BEKLEMEDE", "BEKLEMEDE", 1));
            imageCombo2.Items.Add(new ImageComboBoxItem("ERTELENDI", "ERTELENDI", 2));
            imageCombo2.Items.Add(new ImageComboBoxItem("ISLEME ALINDI", "ISLEME ALINDI", 3));
            imageCombo2.Items.Add(new ImageComboBoxItem("TAMAMLANDI", "TAMAMLANDI", 4));
            imageCombo2.Items.Add(new ImageComboBoxItem("ASKIDA", "ASKIDA", 5));

            Tablo.Columns["StatusName"].ColumnEdit = imageCombo2;
            Tablo.GridControl.RepositoryItems.Add(imageCombo2);
        }

        protected override void FormEditEnableDisableTxt()
        {
            if (_selectedManagerUserId > 0)
            {
                if (_selectedManagerUserId != Dynamic.OnlineUser.Id)
                {
                    txtSubject.ReadOnly         = true;
                    txtPriorityId.ReadOnly      = true;
                    txtStartDate.ReadOnly       = true;
                    txtAssingedUserId.ReadOnly  = true;
                    txtManagerUserId.ReadOnly   = true;

                    btnDelete.Enabled           = false;
                    btnSaveAs.Enabled           = false;
                    btnGorevGoruldu.Enabled     = false;

                }
                else
                {
                    txtSubject.ReadOnly         = false;
                    txtPriorityId.ReadOnly      = false;
                    txtStartDate.ReadOnly       = false;
                    txtAssingedUserId.ReadOnly  = false;
                    txtManagerUserId.ReadOnly   = false;

                    txtStatusId.Enabled         = true;
                    txtDescription.Enabled      = true;
                    txtEndDate.Enabled          = true;
                    btnSaveAs.Enabled           = true;
                }


                if (_selectedAssingedUserId != Dynamic.OnlineUser.Id && _selectedManagerUserId != Dynamic.OnlineUser.Id)
                {
                    txtStatusId.ReadOnly        = true;
                    txtDescription.ReadOnly     = true;
                    txtEndDate.ReadOnly         = true;

                    btnGorevGoruldu.Enabled     = false;
                }
                else
                {
                    txtStatusId.ReadOnly        = false;
                    txtDescription.ReadOnly     = false;
                    txtEndDate.ReadOnly         = false;

                    if (_selectedAssingedUserId != Dynamic.OnlineUser.Id)
                    {
                        btnGorevGoruldu.Enabled = false;
                    }
                    else
                    {
                        if (txtStatusId.Text == "YENI")
                        {
                            btnGorevGoruldu.Enabled = true;
                        }
                        else
                        {
                            btnGorevGoruldu.Enabled = false;
                        }
                    }
                
                }
            }
            else
            {
                txtSubject.ReadOnly             = false;
                txtPriorityId.ReadOnly          = false;
                txtStartDate.ReadOnly           = false;
                txtAssingedUserId.ReadOnly      = false;
                txtManagerUserId.ReadOnly       = false;

                txtStatusId.ReadOnly            = false;
                txtDescription.ReadOnly         = false;
                txtEndDate.ReadOnly             = false;

                btnSaveAs.Enabled               = true;
                btnGorevGoruldu.Enabled         = false;
            }
        }


        private void Tablo_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.Column.FieldName == "PriorityName")
            {
                string priority = View.GetRowCellDisplayText(e.RowHandle, View.Columns["PriorityName"]);
                if (priority == "ACIL")
                {
                    e.Appearance.BackColor = Color.FromArgb(70, Color.LightCoral);
                    e.Appearance.BackColor2 = Color.White;
                    e.Appearance.FontStyleDelta = FontStyle.Bold;
                }
            }
        }
        private void Tablo_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
      
            if (e.RowHandle >= 0)
            {
                if (View.Columns["PriorityName"] != null)
                {
                    string priority = View.GetRowCellDisplayText(e.RowHandle, View.Columns["PriorityName"]);
                    string status = View.GetRowCellDisplayText(e.RowHandle, View.Columns["StatusName"]);
                    if (status == "ISLEME ALINDI")
                    {
                        e.Appearance.BackColor = Color.FromArgb(70, Color.Yellow);
                        e.Appearance.BackColor2 = Color.White;
                    }

                    if (status == "TAMAMLANDI")
                    {
                        e.Appearance.BackColor = Color.FromArgb(70, Color.Lime);
                        e.Appearance.BackColor2 = Color.White;


                        //e.Appearance.FontStyleDelta = FontStyle.Strikeout;
                    }
                }


    
            }
        }

        //private void Tablo_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        //{
        //    ColumnView view = sender as ColumnView;


        //    if (true)
        //    {
        //        string currencyType = (string)view.GetListSourceRowCellValue(e.ListSourceRowIndex, "PriorityName");

        //        switch (currencyType)
        //        {
        //            case "ACIL": e.get
        //            default:
        //                break;
        //        }
        //    }

        //    if (e.Column.FieldName == "Price" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
        //    {
        //        int currencyType = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, "PriorityName");
        //        decimal price = Convert.ToDecimal(e.Value);
        //        switch (currencyType)
        //        {
        //            case 0: e.DisplayText = string.Format(ciUSA, "{0:c}", price); break;
        //            case 1: e.DisplayText = string.Format(ciEUR, "{0:c}", price); break;
        //        }
        //    }
        //}



    }
}