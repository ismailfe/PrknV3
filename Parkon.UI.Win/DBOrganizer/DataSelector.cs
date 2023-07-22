using Prkn.Model;
using Prkn.UI.Win.Functions.Check;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prkn.UI.Win.DBOrganizer
{
    public static class DataSelector
    {
        static string ConnStatus;
        static int cnt;
        // Check Connection Status
        static string CheckConnStatus()
        {
            Cursor.Current = Cursors.WaitCursor;

            string result = "";
            var sts = checkConn();

            if (sts == "OK!")
            {
                result = "PrknDB";
            }
            else
            {
                result = "MirrorDB";
            }




            //Thread TH = new Thread(checkConn);
            //TH.Start();
            //while (true)
            //{
            //    if (ConnStatus == "OK!")
            //    {
            //        result      = "PrknDB";
            //        ConnStatus  = "";
            //        break;
            //    }
            //    else if (ConnStatus != "")
            //    {
            //        result      = "MirrorDB";
            //        ConnStatus  = "";
            //        break;
            //    }

            //    Thread.Sleep(10);
        
            //    cnt++;
            //    if (cnt >= 10)
            //    {
            //        ConnStatus  = "OverTime";
            //        cnt         = 0;
            //    }
            //}

        
            return result;

           Cursor.Current = Cursors.Default;
        }

        static string checkConn()
        {
            return  Internet.CheckDBSERVER();
        }


        // Customer
        public static List<Customers> Get_CustomerList()
        {
            switch (CheckConnStatus())
            {
                case "PrknDB":
                    Bll.Master.PrknDataBll.Customer.CustomerBll Master_Bll = new Bll.Master.PrknDataBll.Customer.CustomerBll();
                    return Master_Bll.ListRefresh();
                case "MirrorDB":
                   return LocalData.Customers;
                default:
                    return new List<Customers>();
            }
        }
        public static List<Customer_Section> Get_CustomerSectionList()
        {
            switch (CheckConnStatus())
            {
                case "PrknDB":
                    Bll.Master.PrknDataBll.Customer.CustomerSectionBll Master_Bll = new Bll.Master.PrknDataBll.Customer.CustomerSectionBll();
                   return Master_Bll.ListRefresh();
                case "MirrorDB":
                    return LocalData.Customer_Section;
                default:
                    return new List<Customer_Section>();
            }
        }
        public static List<Customer_Contact> Get_CustomerContactList()
        {
            switch (CheckConnStatus())
            {
                case "PrknDB":
                    Bll.Master.PrknDataBll.Customer.CustomerContactBll Master_Bll = new Bll.Master.PrknDataBll.Customer.CustomerContactBll();
                    return Master_Bll.ListRefresh();
                case "MirrorDB":
                    return LocalData.Customer_Contact;
                default:
                    return new List<Customer_Contact>();
            }
        }

        // Project
        public static List<Projects> Get_ProjectList()
        {
            List<Projects> result = new List<Projects>();

            switch (CheckConnStatus())
            {
                case "PrknDB":
                    Bll.Master.PrknDataBll.Project.ProjectBll Master_Bll = new Bll.Master.PrknDataBll.Project.ProjectBll();
                    result = Master_Bll.ListRefresh();
                    break;
                case "MirrorDB":
                    result = LocalData.Projects;
                    break;
            }

            return result;
        }
        public static List<Project_Rev> Get_Project_RevList()
        {
            switch (CheckConnStatus())
            {
                case "PrknDB":
                    Bll.Master.PrknDataBll.Project.ProjectRevBll Master_Bll = new Bll.Master.PrknDataBll.Project.ProjectRevBll();
                    return Master_Bll.ListRefresh();
                case "MirrorDB":
                    return LocalData.Project_Rev;
                default:
                    return new List<Project_Rev>();
            }
        }

        // User
        public static List<Users> Get_UserList()
        {
            switch (CheckConnStatus())
            {
                case "PrknDB":
                    Bll.Master.PrknDataBll.User.UserBll Master_Bll = new Bll.Master.PrknDataBll.User.UserBll();
                    return Master_Bll.ListRefresh();
                case "MirrorDB":
                    return LocalData.Users;
                default:
                    return new List<Users>();

            }
        }
    }
}
