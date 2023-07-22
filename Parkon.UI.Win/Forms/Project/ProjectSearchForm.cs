using DevExpress.XtraEditors;
using Prkn.Data.Master;
using Prkn.Model;
using Prkn.Bll.Local.MirrorDataBll.Customer;
using Prkn.Bll.Local.MirrorDataBll.User;
using Prkn.Bll.Master.PrknDataBll.Project;
using Prkn.Bll.Settings;
using Prkn.Common.Design.Controls;
using Prkn.Common.Functions;
using Prkn.Common.Variables;
using Prkn.UI.Win.DBOrganizer;
using Prkn.UI.Win.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static Prkn.Common.Variables.Static;

namespace Prkn.UI.Win.Forms.Project
{
    public partial class ProjectSearchForm : DevExpress.XtraEditors.XtraForm
    {
        long _selectedCustomerId;
        long _selectedCustomerSectionId;
        long _SelectedProjectId;
        long _SelectedRevId;
        //List<Model.Customers> _customers;
        //List<Model.Customer_Contact> _customerContact;
        //List<Model.Customer_Section> _customerSection;
        //List<Model.Projects> _projects;
        //List<Model.Project_Rev> _project_Rev;

        public ProjectSearchForm()
        {
            InitializeComponent();
            Text = "Proje Sorgulama Paneli";
            MyLoad();
        }

        void MyLoad()
        {
            GetListData();
            LayoutEvents();
            CheckSelectLoad();
        }

        void LayoutEvents()
        {
            txtMyCustomerName.SelectedValueChanged              += TxtMyCustomerName_SelectedValueChanged;
            txtMyCustomerSectionName.SelectedValueChanged       += TxtMyCustomerSection_SelectedValueChanged;
            txtMyProjectName.TextChanged                        += TxtMyProjectName_TextChanged;
            txtMyRevName.SelectedValueChanged                   += TxtMyRevName_SelectedValueChanged;

            btnHepsiniSec.MouseUp                               += BtnHepsiniSec_MouseUp;
            btnTemizle.MouseUp                                  += BtnTemizle_MouseUp;
            btnAra.MouseUp                                      += BtnAra_MouseUp;
            btnDizinAc.MouseUp                                  += BtnDizinAc_MouseUp;
                                                                
            txtProjeDizini.TextChanged                          += TxtProjeDizini_TextChanged;

            //checkRefNoEnable.CheckedChanged                     += CheckRefNoEnable_CheckedChanged;
            //txtRefNo.TextChanged                                += TxtRefNo_TextChanged;
            //txtRevizyonNo.TextChanged                           += TxtRefNo_TextChanged;

            checkCodeEnbable.CheckedChanged                     += CheckCodeEnbable_CheckedChanged;
            //txtCheckCode.TextChanged                            += TxtCheckCode_TextChanged;
            txtCheckCode.KeyDown += TxtCheckCode_KeyDown;
            FlowLayoutPanel_Folders.ControlRemoved              += FlowLayoutPanel_Folders_ControlRemoved;
        }



        private void FlowLayoutPanel_Folders_ControlRemoved(object sender, ControlEventArgs e)
        {
            FlowLayoutPanel_Folders.Refresh();
        }

        #region Buttons
        private void BtnDizinAc_MouseUp(object sender, MouseEventArgs e)
        {
            if (Directory.Exists(txtProjeDizini.Text))
            {
                string myDocspath = txtProjeDizini.Text; // Buraya istediğimiz dosyanın yolunu yazıyorz
                string windir = Environment.GetEnvironmentVariable("WINDIR");
                System.Diagnostics.Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = windir + @"\explorer.exe";
                prc.StartInfo.Arguments = myDocspath;
                prc.Start();
            }
        }
        private void BtnAra_MouseUp(object sender, MouseEventArgs e)
        {
            Ara();

        }

        void Ara()
        {
            if (!checkCodeEnbable.Checked)
            {
                Form_Proje_Sorgula_Load();
            }
            else
            {
                var sts = GetProjectWithCode();
                if (sts)
                {
                    Form_Proje_Sorgula_Load();
                }

            }

        }

        private void BtnTemizle_MouseUp(object sender, MouseEventArgs e)
        {
            CheckBoxSate(false);
        }
        private void BtnHepsiniSec_MouseUp(object sender, MouseEventArgs e)
        {
            CheckBoxSate(true);
        }
        #endregion

        #region Check Project with RefNo
        private void CheckRefNoEnable_CheckedChanged(object sender, EventArgs e)
        {
            ProjectFindWithRefNo();
        }
        private void TxtRefNo_TextChanged(object sender, EventArgs e)
        {
            ProjectFindWithRefNo(); 
        }
        private void TxtMyRevName_SelectedValueChanged(object sender, EventArgs e)
        {
            var senderSelectItem = ((MyComboBoxEdit)sender).SelectedItem;
            _SelectedRevId = 0;
            if (senderSelectItem != null)
            {
                if (senderSelectItem != "")
                {
                    var senderSelectValue = ((ComboboxItem)senderSelectItem).Value;
                    long.TryParse(senderSelectValue.ToString(), out _SelectedRevId);

                    bool _status = false;
                    if (((MyComboBoxEdit)sender).Name != null)
                    {
                        _status = true;
                    }
                }

            }

            LayoutControllerEnableDisable();
        }
        #endregion

        #region Check Project With ProjectCode
        private void CheckCodeEnbable_CheckedChanged(object sender, EventArgs e)
        {
            ProjeKoduIleAramaEnb(checkCodeEnbable.Checked);
        }
        private void TxtCheckCode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFindWithCode(e);
        }

        #endregion

        private void TxtProjeDizini_TextChanged(object sender, EventArgs e)
        {
            if (txtProjeDizini.Text != "")
            {
                btnDizinAc.Enabled = true;
                txtProjeDizini.Enabled = true;
            }
            else
            {
                btnDizinAc.Enabled = false;
                txtProjeDizini.Enabled = false;
            }
        }
        private void TxtMyProjectName_TextChanged(object sender, EventArgs e)
        {
            var row = ((MyLookUpEdit)sender).GetSelectedDataRow();
            _SelectedProjectId = 0;
            if (row != null)
            {
                var _Code           = row.GetType().GetProperty("Code").GetValue(row);
                var _Comment        = row.GetType().GetProperty("Comment").GetValue(row);
                var _CreateUserId   = row.GetType().GetProperty("UserId").GetValue(row);

                if (_Code != null)          { txtCode.Text = _Code.ToString(); }                    else { txtCode.Text = ""; }
                if (_Comment != null)       { txtProjectComment.Text = _Comment.ToString(); }       else { txtProjectComment.Text = ""; }


                if (_CreateUserId != null)
                {
                    long.TryParse(_CreateUserId.ToString(), out long UId);
                    UserBll userBll = new UserBll();

                    var user = userBll.GetSingle(x => x.Id == UId, x => x);

                    if (user != null)
                    {
                        txtCreateUser.Text = user.NameFirst + " " + user.NameLast;
                    }
                    else
                    {
                        txtCreateUser.Text = "";
                    }

                }
                else
                {
                    txtCreateUser.Text = "";
                }

                    _SelectedProjectId = (long)((MyLookUpEdit)sender).EditValue;
                    ComboBoxProjectRevData(_SelectedProjectId);
                }

                LayoutControllerEnableDisable();
        }

        #region Customer Info  Customer / Section / Contact
        private void TxtMyCustomerName_SelectedValueChanged(object sender, EventArgs e)
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

                ComboBoxCustomerSectionData(_selectedCustomerId);
                ComboBoxProjectData(_selectedCustomerId, _selectedCustomerSectionId);
                ComboBoxProjectRevData(_SelectedProjectId);
            }

            LayoutControllerEnableDisable();
        }
        private void TxtMyCustomerSection_SelectedValueChanged(object sender, EventArgs e)
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
                    ComboBoxProjectRevData(_SelectedProjectId);
                }

            }

            LayoutControllerEnableDisable();
        }
        private void TxtCustomerContact_SelectedValueChanged(object sender, EventArgs e)
        {
            LayoutControllerEnableDisable();
        }
        #endregion


        void GetListData()
        {
            ComboBoxCustomerData();
        }
        void ComboBoxCustomerData()
        {
            CustomerBll customerBll = new CustomerBll();
            var listfilter = customerBll.ListRefresh(); 
            GeneralFunctions.ComboBoxDataFillingFromList(listfilter, txtMyCustomerName);
        }
        void ComboBoxCustomerSectionData(long customerId)
        {
            CustomerSectionBll customerSectionBll = new CustomerSectionBll();
            var listfilter = customerSectionBll.GetList(x => x.CustomerId == customerId, x => x).ToList();
            GeneralFunctions.ComboBoxDataFillingFromList(listfilter, txtMyCustomerSectionName);
        }
        void ComboBoxProjectData(long customerId, long customerSectionId)
        {
            ProjectBll projectBll = new ProjectBll();
            var listfilter = projectBll.GetList(x => x.CustomerId == customerId && x.CustomerSectionId == customerSectionId, x => new { x.Code, x.Name, x.DateStart, x.DateEnd, x.RefNo, x.Comment, x.UserId, x.Id }).ToList();
         //var listfilter = .Get_ProjectList().Where(x => x.CustomerId == customerId && x.CustomerSectionId == customerSectionId)
         //      .Select(x => new { x.Code, x.Name, x.DateStart, x.DateEnd, x.RefNo, x.Comment, x.UserId, x.Id}).ToList();
           
            var ShowValList = new string[] { "Code", "Name", "#         Proje Tarihi:", "DateStart", "#-", "DateEnd" };
            GeneralFunctions.LookUpEditDataFilling(listfilter, txtMyProjectName, ShowValList);

        }
        void ComboBoxProjectRevData(long projectId)
        {
            List<Model.Project_Rev> listfilter = new List<Model.Project_Rev>();

            Model.Project_Rev firstRev = new Model.Project_Rev();

            firstRev.Name = "REVIZYON YOK";
            firstRev.Id = 0;

            listfilter.Add(firstRev);

            ProjectRevBll projectRevBll = new ProjectRevBll();


            var listfilter2 = projectRevBll.GetList(x => x.ProjectId == projectId, x => x).ToList();
            listfilter.AddRange(listfilter2);


            txtMyRevName.Properties.Items.Clear();
            txtMyRevName.Text = "";
            if (projectId != 0)
            {
                if (listfilter.Count >= 1)
                {
                    GeneralFunctions.ComboBoxDataFillingFromList<Model.Project_Rev>(listfilter, txtMyRevName);
                    txtMyRevName.SelectedIndex = txtMyRevName.Properties.Items.Count - 1;
                }
                else
                {
           
                }

                ////txtMyRevName.Text = "REVIZYON YOK";
                //ComboboxItem itm = new ComboboxItem();
                //itm.Text = "REVIZYON YOK";
                //itm.Value = 0;
                //txtMyRevName.Properties.Items.Add(itm);
            }
          
           
        }

        void LayoutControllerEnableDisable()
        {
            if (string.IsNullOrEmpty(txtMyCustomerName.Text) || string.IsNullOrEmpty(txtMyCustomerSectionName.Text) || string.IsNullOrEmpty(txtMyProjectName.Text) || string.IsNullOrEmpty(txtMyRevName.Text))
            {
                btnAra.Enabled          = false;
                txtProjeDizini.Text     = "";
                txtCode.Text            = "";
                txtCreateUser.Text      = "";
            }
            else
            {
                btnAra.Enabled          = true;
                txtProjeDizini.Text     = CreateProjectPath();
            }
        }

        void ProjectFindWithRefNo()
        {
            //if (checkRefNoEnable.Checked)
            //{
            //    if (txtRefNo.Text.Length >= 16 && txtRevizyonNo.Text.Length >= 2)
            //    {
            //        //txtProjeDizini.Text = "";
            //        btnAra.Enabled = true;
            //    }
            //    else
            //    {
            //        txtProjeDizini.Text = "";
            //        btnAra.Enabled = false;
            //    }
            //}
        }
        void RefNoileAramaEnb(bool Checked)
        {
            txtCheckCode.Enabled                = !Checked;
            txtMyCustomerName.Enabled           = !Checked;
            txtMyCustomerSectionName.Enabled    = !Checked;
            txtMyProjectName.Enabled            = !Checked;
            txtMyRevName.Enabled                = !Checked;
        }


        void ProjectFindWithCode(KeyEventArgs Key)
        {
            if (txtCheckCode.Text.Length >= 7 && txtCheckCode.Text.StartsWith("P"))
            {
                var yil = txtCheckCode.Text.Remove(0, 1).Remove(2);
                var e = txtCheckCode.Text.Remove(0, 3).Remove(1);
                var no = txtCheckCode.Text.Remove(0, 4);
                if (int.TryParse(yil, out int o1) && e == "e" && int.TryParse(no, out int o2))
                {
                    btnAra.Enabled = true;

                    if (Key.KeyData == Keys.Enter)
                    {
                        Ara();
                    }
                 
                }

          
            }
            else
            {
                txtProjeDizini.Text = "";
                btnAra.Enabled = false;
            }

        }
        void ProjeKoduIleAramaEnb(bool Checked)
        {
            txtCheckCode.Enabled                = Checked;
            txtMyCustomerName.Enabled           = !Checked;
            txtMyCustomerSectionName.Enabled    = !Checked;
            txtMyProjectName.Enabled            = !Checked;
            txtMyRevName.Enabled                = !Checked;
        }
        bool GetProjectWithCode()
        {
            ProjectBll projectBll = new ProjectBll();
            var getProject = projectBll.GetSingle(x => x.Code == txtCheckCode.Text, x => x);

            if (getProject != null)
            {
                var ComboBoxList                = txtMyCustomerName.Properties.Items.Cast<ComboboxItem>().ToList();
                var FindItemResult              = ComboBoxList.FirstOrDefault(X => X.Value.ToString() == getProject.CustomerId.ToString());
                txtMyCustomerName.SelectedItem  = FindItemResult;

                var ComboBoxList2               = txtMyCustomerSectionName.Properties.Items.Cast<ComboboxItem>().ToList();
                var FindItemResult2             = ComboBoxList2.FirstOrDefault(X => X.Value.ToString() == getProject.CustomerSectionId.ToString());
                txtMyCustomerSectionName.SelectedItem = FindItemResult2;

                txtMyProjectName.EditValue      = getProject.Id;

                return true;
            }
            else
            {
                MessageBox.Show(txtCheckCode.Text + "  proje kodu ile herhangi bir proje bulunamadı! Lütfen proje kodunu kontrol edin.", "Hatalı Proje Kodu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }


        void Form_Proje_Sorgula_Load()
        {
            GC.SuppressFinalize(FlowLayoutPanel_Folders);
            FlowLayoutPanel_Folders.Controls.Clear();
            txtDurum.Text = "";
            bool checkControl = false;

            for (int i = 0; i < myDataLayoutControlParameters.Controls.Count; i++)
            {
                if (myDataLayoutControlParameters.Controls[i].Name.StartsWith("check"))
                {
                    if (((CheckEdit)myDataLayoutControlParameters.Controls[i]).Checked)
                    {
                        checkControl = true;
                    }
                   

                    var sts = ProjeSorgu.Sorgu((CheckEdit)myDataLayoutControlParameters.Controls[i]);
                    if (sts != "OK!")
                    {
                        txtDurum.Text = DateTime.Now.ToString() + "  -  " + sts;
                        //break;
                    }
                    else if (sts.StartsWith("Seçilen Revizyon dosyaları arşivlenmiş gözüküyor!"))
                    {
                        break;
                    }
                }
            }

            if (checkControl == false)
            {
                txtDurum.Text = DateTime.Now.ToString() + "  -  " + "Herhangi bir klasör seçimi yapılmadı. Lütfen görmek istediğiniz projenin klasör ya da klasörlerini seçiniz.";
            }
            CheckSelectSave();
        }
        string CreateProjectPath()
        {
            ProjectBll projectBll = new ProjectBll();

            var projeRefNo = projectBll.GetSingle(x => x.Id == _SelectedProjectId, x => x);
            if (projeRefNo != null)
            {
                int RevIndex = 0;
                if (txtMyRevName.SelectedIndex > 0)
                {
                    RevIndex = txtMyRevName.SelectedIndex;// + 1;
                }

                string RevNo = "";
                if (RevIndex < 10)
                {
                    RevNo = "R0" + RevIndex;
                }
                else
                {
                    RevNo = "R" + RevIndex;
                }

                var Anadizin = Global.ProjeDizin.ProjeAnadizin;
                var Anadizin1 = Anadizin + "\\" + txtMyCustomerName.Text;
                var Anadizin2 = Anadizin1 + "\\" + projeRefNo.RefNo;
                var Anadizin3 = Anadizin2 + "\\" + RevNo;


                ProjeSorgu.Panel = FlowLayoutPanel_Folders;
                ProjeSorgu.SadeceDoluKlasor = MycheckSadeceDoluKlasor;
                ProjeSorgu.AnaProjeDizini = Anadizin;
                ProjeSorgu.MusteriAdi = txtMyCustomerName.Text;
                ProjeSorgu.ProjeRefNo = projeRefNo.RefNo.ToString();
                ProjeSorgu.ProjeRevNo = RevNo;

                return Anadizin3;
            }
            else
            {
                return "";
            }
        }



        #region Serach CheckBox State
        void CheckBoxSate(bool Checked)
        {
            for (int i = 0; i < myDataLayoutControlParameters.Controls.Count; i++)
            {
                if (myDataLayoutControlParameters.Controls[i].Name.StartsWith("check"))
                {
                    ((CheckEdit)myDataLayoutControlParameters.Controls[i]).Checked = Checked;
                }
            }
        }
        void CheckSelectSave()
        {
            for (int i = 0; i < myDataLayoutControlParameters.Controls.Count; i++)
            {
                if (myDataLayoutControlParameters.Controls[i].GetType() == typeof(CheckEdit))
                {
                    var prmName = this.Name +"_" + myDataLayoutControlParameters.Controls[i].Name;
                    var prmVar = ((CheckEdit)(myDataLayoutControlParameters.Controls[i])).Checked.ToString();
                    SettingsBll.PostSelfSetting(prmName, prmVar);
                }
            }
        }
        void CheckSelectLoad()
        {
            for (int i = 0; i < myDataLayoutControlParameters.Controls.Count; i++)
            {
                if (myDataLayoutControlParameters.Controls[i].GetType() == typeof(CheckEdit))
                {
                    var prmName = this.Name + "_" + myDataLayoutControlParameters.Controls[i].Name;
                    bool.TryParse(SettingsBll.GetSelfSetting(prmName), out bool myprm);
                    ((CheckEdit)(myDataLayoutControlParameters.Controls[i])).Checked = myprm;
                }
            }
        }
        #endregion



        public void LookUp_Devices(MyLookUpEdit LookUpEdit)
        {
            //var MyList = _projects.Select(x => new { x.Name, x.Code, x.DateStart, x.DateEnd, x.RefNo, x.Id }).ToList();
            //var typs = MyList.GetType();
            //var ShowValList = new string[] { "Code", "Name", "DateStart", "#-", "DateEnd" };
            //GeneralFunctions.LookUpEditDataFilling(MyList, LookUpEdit, ShowValList);
            //txtOfferId.EditValue = null;
        }
        public static void ComboBoxDataFillingFromList<T>(List<T> myList, ComboBoxEdit comboBox)
        {
            comboBox.Text = string.Empty;
            comboBox.Properties.Items.Clear();
            if (myList != null)
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    ComboboxItem itm = new ComboboxItem();
                    itm.Text = myList[i].GetType().GetProperty("Name").GetValue(myList[i]).ToString();
                    itm.Value = myList[i].GetType().GetProperty("Id").GetValue(myList[i]).ToString();
                    comboBox.Properties.Items.Add(itm);
                }
            }
        }


    }
}