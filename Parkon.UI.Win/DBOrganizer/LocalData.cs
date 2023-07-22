using Prkn.Model;
using Prkn.Bll.Settings;
using Prkn.UI.Win.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.UI.Win.DBOrganizer
{
    public static class LocalData
    {
        public static List<Model.Users> Users                        = new List<Model.Users>();
        public static List<Model.Projects> Projects                  = new List<Model.Projects>();
        public static List<Model.Project_Rev> Project_Rev            = new List<Model.Project_Rev>();
        public static List<Model.Customers> Customers                = new List<Model.Customers>();
        public static List<Model.Customer_Section> Customer_Section  = new List<Model.Customer_Section>();
        public static List<Model.Customer_Contact> Customer_Contact  = new List<Model.Customer_Contact>();

        public static void Refresh()
        {
            TableFilling_Users();
            TableFilling_Projects();
            TableFilling_Project_Rev();

            TableFilling_Customers();
            TableFilling_Customer_Section();
            TableFilling_Customer_Contact();

            var updateDT = SettingsBll.GetMirrorDBLastUpdate();
            CLS.MainForm.btnDbStatus.Caption = "DB Update:  " + updateDT + "";
        }

        static void TableFilling_Users()
        {
            Bll.Local.MirrorDataBll.User.UserBll Local_Bll  = new Bll.Local.MirrorDataBll.User.UserBll();
            var localList                                   = Local_Bll.ListRefresh();
            for (int i = 0; i < localList.Count(); i++)
            {
                Users data = new Users();

                data.AutrizationId      = localList[i].AutrizationId;
                data.BirthDate          = localList[i].BirthDate;
                data.Comment            = localList[i].Comment;
                data.CreateDate         = localList[i].CreateDate;
                data.DeleteDate         = localList[i].DeleteDate;
                data.DepartmentId       = localList[i].DepartmentId;
                data.Id                 = localList[i].Id;
                data.LevelsId           = localList[i].LevelsId;
                data.Mail1              = localList[i].Mail1; 
                data.Mail2              = localList[i].Mail2;
                data.NameFirst          = localList[i].NameFirst;
                data.NameLast           = localList[i].NameLast;
                data.OnlineId           = localList[i].OnlineId;
                data.Pass               = localList[i].Pass;
                data.Phone1             = localList[i].Phone1;
                data.Phone2             = localList[i].Phone2;
                data.Pic                = localList[i].Pic;
                data.Role               = localList[i].Role;
                data.SysCode            = localList[i].SysCode;
                data.TitleId            = localList[i].TitleId;
                data.UId                = localList[i].UId;
                data.UpdateDate         = localList[i].UpdateDate;
                data.UserId             = localList[i].UserId;
                data.UserName           = localList[i].UserName;
                data.VarStatus          = localList[i].VarStatus;

                Users.Add(data);
            }
        }
        static void TableFilling_Projects()
        {
            Bll.Local.MirrorDataBll.Project.ProjectBll Local_Bll    = new Bll.Local.MirrorDataBll.Project.ProjectBll();
            var localList                                           = Local_Bll.ListRefresh();
            for (int i = 0; i < localList.Count(); i++)
            {
                Projects data = new Projects();

                data.Code               = localList[i].Code;
                data.Comment            = localList[i].Comment;
                data.CreateDate         = localList[i].CreateDate;
                data.CustomerContactId  = localList[i].CustomerContactId;
                data.CustomerId         = localList[i].CustomerId;
                data.CustomerSectionId  = localList[i].CustomerSectionId;
                data.DateEnd            = localList[i].DateEnd;
                data.DateStart          = localList[i].DateStart;
                data.DeleteDate         = localList[i].DeleteDate;
                data.Id                 = localList[i].Id;
                data.Keyword            = localList[i].Keyword;
                data.Name               = localList[i].Name;
                data.No                 = localList[i].No;
                data.PeriodMonth        = localList[i].PeriodMonth;
                data.PeriodYear         = localList[i].PeriodYear;
                data.ProjectDetailId    = localList[i].ProjectDetailId;
                data.RefNo              = localList[i].RefNo;
                data.RefNoOld           = localList[i].RefNoOld;
                data.SysCode            = localList[i].SysCode;
                data.UpdateDate         = localList[i].UpdateDate;
                data.UserId             = localList[i].UserId;
                data.VarStatus          = localList[i].VarStatus;

                Projects.Add(data);
            }
        }
        static void TableFilling_Project_Rev()
        {
            Bll.Local.MirrorDataBll.Project.ProjectRevBll Local_Bll = new Bll.Local.MirrorDataBll.Project.ProjectRevBll();
            var localList = Local_Bll.ListRefresh();
            for (int i = 0; i < localList.Count(); i++)
            {
                Project_Rev data = new Project_Rev();

                data.Code               = localList[i].Code;
                data.Comment            = localList[i].Comment;
                data.CreateDate         = localList[i].CreateDate;
                data.CustomerContactId  = localList[i].CustomerContactId;
                data.DateEnd            = localList[i].DateEnd;
                data.DateStart          = localList[i].DateStart;
                data.DeleteDate         = localList[i].DeleteDate;
                data.Id                 = localList[i].Id;
                data.Keyword            = localList[i].Keyword;
                data.Name               = localList[i].Name;
                data.No                 = localList[i].No;
                data.PeriodMonth        = localList[i].PeriodMonth;
                data.PeriodYear         = localList[i].PeriodYear;
                data.RefNo              = localList[i].RefNo;
                data.SysCode            = localList[i].SysCode;
                data.UpdateDate         = localList[i].UpdateDate;
                data.UserId             = localList[i].UserId;
                data.VarStatus          = localList[i].VarStatus;
                data.ProjectId          = localList[i].ProjectId;
                Project_Rev.Add(data);
            }
        }

        static void TableFilling_Customers()
        {
            Bll.Local.MirrorDataBll.Customer.CustomerBll Local_Bll = new Bll.Local.MirrorDataBll.Customer.CustomerBll();
            var localList = Local_Bll.ListRefresh();
            for (int i = 0; i < localList.Count(); i++)
            {
                Customers data = new Customers();

                data.Address            = localList[i].Address;
                data.Code               = localList[i].Code;
                data.Comment            = localList[i].Comment;
                data.CreateDate         = localList[i].CreateDate;
                data.CustomerTypeId     = localList[i].CustomerTypeId;
                data.DeleteDate         = localList[i].DeleteDate;
                data.Fax                = localList[i].Fax;
                data.Id                 = localList[i].Id;
                data.Info               = localList[i].Info;
                data.Keyword            = localList[i].Keyword;
                data.Maps               = localList[i].Maps;
                data.Name               = localList[i].Name;
                data.No                 = localList[i].No;
                data.Phone1             = localList[i].Phone1;
                data.Phone2             = localList[i].Phone2;
                data.Pic                = localList[i].Pic;
                data.Score              = localList[i].Score;
                data.SysCode            = localList[i].SysCode;
                data.UpdateDate         = localList[i].UpdateDate;
                data.UserId             = localList[i].UserId;
                data.VarStatus          = localList[i].VarStatus;
                data.ZoneId             = localList[i].ZoneId;

                Customers.Add(data);
            }
        }
        static void TableFilling_Customer_Section()
        {
            Bll.Local.MirrorDataBll.Customer.CustomerSectionBll Local_Bll = new Bll.Local.MirrorDataBll.Customer.CustomerSectionBll();
            var localList = Local_Bll.ListRefresh();
            for (int i = 0; i < localList.Count; i++)
            {
                Customer_Section data = new Customer_Section();

                data.Address            = localList[i].Address;
                data.Code               = localList[i].Code;
                data.Comment            = localList[i].Comment;
                data.CreateDate         = localList[i].CreateDate;
                data.CustomerId         = localList[i].CustomerId;
                data.DeleteDate         = localList[i].DeleteDate;
                data.Fax                = localList[i].Fax;
                data.Id                 = localList[i].Id;
                data.Info               = localList[i].Info;
                data.Keyword            = localList[i].Keyword;
                data.Maps               = localList[i].Maps;
                data.Name               = localList[i].Name;
                data.No                 = localList[i].No;
                data.Phone1             = localList[i].Phone1;
                data.Phone2             = localList[i].Phone2;
                data.Pic                = localList[i].Pic;
                data.Score              = localList[i].Score;
                data.SysCode            = localList[i].SysCode;
                data.UpdateDate         = localList[i].UpdateDate;
                data.UserId             = localList[i].UserId;
                data.VarStatus          = localList[i].VarStatus;
                data.ZoneId             = localList[i].ZoneId;

                Customer_Section.Add(data);
            }
        }
        static void TableFilling_Customer_Contact()
        {
            Bll.Local.MirrorDataBll.Customer.CustomerContactBll Local_Bll = new Bll.Local.MirrorDataBll.Customer.CustomerContactBll();
            var localList = Local_Bll.ListRefresh();
            for (int i = 0; i < localList.Count; i++)
            {
                Customer_Contact data = new Customer_Contact();

                data.Comment            = localList[i].Comment;
                data.CreateDate         = localList[i].CreateDate;
                data.CustomerId         = localList[i].CustomerId;
                data.DeleteDate         = localList[i].DeleteDate;
                data.Gender             = localList[i].Gender;
                data.Id                 = localList[i].Id;
                data.Info               = localList[i].Info;
                data.Keyword            = localList[i].Keyword;
                data.Job                = localList[i].Job;
                data.Mail1              = localList[i].Mail1;
                data.Mail2              = localList[i].Mail2;
                data.NameFirst          = localList[i].NameFirst;
                data.NameLast           = localList[i].NameLast;
                data.No                 = localList[i].No;
                data.Phone1             = localList[i].Phone1;
                data.Phone2             = localList[i].Phone2;
                data.Pic                = localList[i].Pic;
                data.Score              = localList[i].Score;
                data.SysCode            = localList[i].SysCode;
                data.TitleId            = localList[i].TitleId;
                data.UpdateDate         = localList[i].UpdateDate;
                data.UserId             = localList[i].UserId;
                data.VarStatus          = localList[i].VarStatus;

                Customer_Contact.Add(data);
            }
        }

    }
}
