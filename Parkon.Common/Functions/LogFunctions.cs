using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Prkn.Common.Variables;
using Prkn.Model;
using Prkn.Model.DbSettings.Entities;

namespace Prkn.Common.Functions
{
    public class LogFunctions
    {
        //private static void LogSave(Logs myLogs)
        //{
        //    SettingsDataContext db = new SettingsDataContext();

        //    myLogs.CreateDate       = DateTime.Now;
        //    myLogs.OnlineUser       = Dynamic.OnlineUser.NameFirst + " " + Dynamic.OnlineUser.NameLast;

        //    db.Logs.Add(myLogs);
        //    db.SaveChanges();
        //}


        //public static void Save(string workArea, string job, string newVal,string status = null, string oldVal = null, string messages = null)
        //{
        //    Logs myLogs = new Logs
        //    {
        //        WorkArea    = workArea,
        //        Job         = job,
        //        NewVal      = newVal,
        //        OldVal      = oldVal,
        //        Status      = status,
        //        Messages    = messages
    
        //    };

        //    LogSave(myLogs);
        //}

    }
}
