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
using Prkn.UI.Win.DBOrganizer;

namespace Prkn.UI.Win.Forms.Project
{
    public partial class ProjectListForm : DevExpress.XtraEditors.XtraForm
    {
        public ProjectListForm()
        {
            InitializeComponent();

            Text = "PROJELER LİSTESİ";
            baseTablo.ViewCaption = Text;

            TableListRefresh();
        }

        void TableUpdate()
        {
            
        }

        void TableListRefresh()
        {
            var myList = DataSelector.Get_ProjectList().ToList();

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
                    var Customer  = LocalData.Customers.FirstOrDefault(x => x.Id == myList[i].CustomerId);
                    if (Customer != null)
                    {
                        data.CustomerName = Customer.Name;
                    }
                    
                }
              

                if (myList[i].CustomerSectionId != null)
                {
                    var CustomerSection = LocalData.Customer_Section.FirstOrDefault(x => x.Id == myList[i].CustomerSectionId);
                    if (CustomerSection != null)
                    {
                        data.CustomerSectionName = CustomerSection.Name;
                    }
             
                }
             

                if (myList[i].CustomerContactId != null)
                {
                    var contactFullName = LocalData.Customer_Contact.FirstOrDefault(x => x.Id == myList[i].CustomerContactId);

                    if (contactFullName != null)
                    {
                        data.CustomerContactName = contactFullName.NameFirst + " " + contactFullName.NameLast;
                    }
              
                }
        
                DataTableList.Add(data);
            }
            baseTablo.ClearSelection();
            baseTablo.GridControl.DataSource = DataTableList;
        }


        class ProjectListTable : Model.Projects
        {
            public string CustomerName { get; set; }
            public string CustomerSectionName { get; set; }
            public string CustomerContactName { get; set; }
        }


    }
}