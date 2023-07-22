using Prkn.Data.Local;
using Prkn.Model.Base;
using Prkn.Bll.Master.PrknDataBll.Customer;
using Prkn.Bll.Master.PrknDataBll.General;
using Prkn.Bll.Master.PrknDataBll.Project;
using Prkn.Bll.Master.PrknDataBll.User;
using Prkn.Bll.Settings;
using Prkn.UI.Win.Functions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Prkn.UI.Win.DBOrganizer
{
    public static class DBMirrorDataUpdate
    {
        public static void FirstLoad()
        {
            Thread TH = new Thread(Update);
            TH.Start();
        }
        public static void CycleUpdate()
        {
            while (true)
            {
                Thread.Sleep(60000 * 30); //30Dk
                Thread TH = new Thread(Update);
                TH.Start();
            }
        }
        static void Update()
        {
            var updateDT = DateTime.Now.ToString();
            SettingsBll.PostMirrorDBLastUpdate(updateDT);
            CLS.MainForm.btnDbStatus.Caption ="DB Update:  " + updateDT + "";

            TableCopy_Currency();
            TableCopy_Zone();
            TableCopy_Users();
            TableCopy_Projects();
            TableCopy_Project_Rev();
            TableCopy_Customers();
            TableCopy_CustomerSection();
            TableCopy_CustomerContact();

            //Her güncellemede program içindeki listeleri güncellemesi için refresh yap!
            LocalData.Refresh();
        }

       static void TableCopy_Currency()
        {
            MirrorDataContext MirrorData = new MirrorDataContext();

            MirrorData.DeleteTable<Model.Mirror.Currency>();
            CurrencyBll bll = new CurrencyBll();
            var listData = MirrorData.Currency.ToList();

            var list = ListCopy(bll.ListRefresh(), listData);
            MirrorData.Currency.AddRange(list);

            MirrorData.SaveChanges();
        }
       static void TableCopy_Zone()
        {
            MirrorDataContext MirrorData = new MirrorDataContext();
            MirrorData.DeleteTable<Model.Mirror.Zone>();
            ZoneBll bll             = new ZoneBll();
            var listData            = MirrorData.Zone.ToList();

            MirrorData.Zone.AddRange(ListCopy(bll.ListRefresh(), listData));

            MirrorData.SaveChanges();
        }
        static void TableCopy_Users()
        {
            MirrorDataContext MirrorData = new MirrorDataContext();
            MirrorData.DeleteTable<Model.Mirror.Users>();
            UserBll bll                 = new UserBll();
            var listData                = MirrorData.Users.ToList();
            MirrorData.Users.AddRange(ListCopy(bll.ListRefresh(), listData));

            MirrorData.SaveChanges();
        }
        
       static void TableCopy_Projects()
        {
            MirrorDataContext MirrorData = new MirrorDataContext();
            MirrorData.DeleteTable<Model.Mirror.Projects>();
            ProjectBll bll          = new ProjectBll();
            var listData            = MirrorData.Projects.ToList();

            MirrorData.Projects.AddRange(ListCopy(bll.ListRefresh(), listData));

            MirrorData.SaveChanges();
        }
        static void TableCopy_Project_Rev()
        {
            MirrorDataContext MirrorData = new MirrorDataContext();

            MirrorData.DeleteTable<Model.Mirror.Project_Rev>();
            ProjectRevBll bll           = new ProjectRevBll();
            var listData                = MirrorData.Project_Rev.ToList();

            MirrorData.Project_Rev.AddRange(ListCopy(bll.ListRefresh(), listData));
            MirrorData.SaveChanges();
        }
        
       static void TableCopy_Customers()
        {
            MirrorDataContext MirrorData = new MirrorDataContext();

            MirrorData.DeleteTable<Model.Mirror.Customers>();
            CustomerBll bll             = new CustomerBll();
            var listData                = MirrorData.Customers.ToList();

            MirrorData.Customers.AddRange(ListCopy(bll.ListRefresh(), listData));
            MirrorData.SaveChanges();
        }
       static void TableCopy_CustomerSection()
        {
            MirrorDataContext MirrorData = new MirrorDataContext();

            MirrorData.DeleteTable<Model.Mirror.Customer_Section>();
            CustomerSectionBll bll = new CustomerSectionBll();
            var listData = MirrorData.Customer_Section.ToList();

            MirrorData.Customer_Section.AddRange(ListCopy(bll.ListRefresh(), listData));
            MirrorData.SaveChanges();
        }
       static void TableCopy_CustomerContact()
        {
            MirrorDataContext MirrorData = new MirrorDataContext();

            MirrorData.DeleteTable<Model.Mirror.Customer_Contact>();
            CustomerContactBll bll = new CustomerContactBll();
            var listData = MirrorData.Customer_Contact.ToList();

            MirrorData.Customer_Contact.AddRange(ListCopy(bll.ListRefresh(), listData));
            MirrorData.SaveChanges();
        }
        
        public static List<T2> ListCopy<T1, T2>(List<T1> MainTable, List<T2> MirrorTable) where T1 : class where T2: class
        {
            var CntProperties       = typeof(T2).GetProperties().Count();
            var PropertiesList      = typeof(T2).GetProperties().ToList(); // .GetProperties().ToList();
            
            for (int i = 0; i < MainTable.Count; i++)
            {
                var data = (T2)Activator.CreateInstance(typeof(T2));

                for (int K = 0; K < CntProperties; K++)
                {
                    try
                    {
                        var propName = PropertiesList[K].Name;
                        var getProp = MainTable[i].GetType().GetProperty(propName);


                        var getPropVal = getProp.GetValue(MainTable[i]);
                        var getMirrorProp = data.GetType().GetProperty(propName);

                        getMirrorProp.SetValue(data, getPropVal);
                    }
                    catch (Exception)
                    {
                    }
                }

                MirrorTable.Add(data);
            }

            return MirrorTable;
        }
    }


    

    public static class ContextExtensions
    {
        public static void DeleteTable<T>(this DbContext _context) where T : class
        {

           string TableName = _context.GetTableName<T>();

            //FOR SQLCE
            try
            {

                var constr = _context.Database.Connection.ConnectionString;
                _context.Database.ExecuteSqlCommand($"DELETE FROM {TableName}");
                Table_AutoNumber_Reset(TableName, "0");

                SqlCeConnection DBConnection;
                SqlCeConnection Connect()
                {
                    DBConnection = new SqlCeConnection(constr);
                    if (DBConnection.State != System.Data.ConnectionState.Open)
                    {
                        try
                        {
                            DBConnection.Open();
                        }
                        catch
                        {
                        }
                    }
                    // Database Aç

                    return DBConnection;
                }
                string Table_AutoNumber_Reset(string tableName, string FirstAutoNumber)
                {
                    try
                    {
                        string StringCMD = "ALTER TABLE " + tableName + " ALTER COLUMN " + "ID" + " IDENTITY (1,1)";
                        SqlCeCommand Cmd = new SqlCeCommand(StringCMD, Connect()); // "DBCC CHECKIDENT ('" + tableName + "', RESEED," + FirstAutoNumber + ")", Connect());
                        Cmd.ExecuteNonQuery();
                        Cmd.Connection.Close();
                        return " 1 OK";
                    }
                    catch (Exception Hata)
                    {
                        return "-1 ERR: " + Hata.ToString();
                    }

                }
            }
            catch (Exception hata)
            {
                var a = hata.ToString();
            }
        }


        public static string GetTableName<T>(this DbContext context) where T : class
        {
            ObjectContext objectContext = ((IObjectContextAdapter)context).ObjectContext;

            return objectContext.GetTableName<T>();
        }

        public static string GetTableName<T>(this ObjectContext context) where T : class
        {
            string table = "";
            try
            {
                string sql = context.CreateObjectSet<T>().ToTraceString();
                Regex regex = new Regex("FROM (?<table>.*) AS");
                Match match = regex.Match(sql);

                table = match.Groups["table"].Value;
            }
            catch (Exception)
            {
            }

            return table;
        }
    }
}
