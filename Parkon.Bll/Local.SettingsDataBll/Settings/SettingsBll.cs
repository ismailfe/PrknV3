using DevExpress.XtraEditors;
using Prkn.Bll.Base;
using Prkn.Bll.Interfaces;
using Prkn.Common;
using Prkn.Common.Design.Controls;
using Prkn.Common.Enums;
using Prkn.Common.Functions;
using Prkn.Common.Variables;
using Prkn.Model;
using Prkn.Model.DbSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prkn.Model.DbSettings.Entities;
using Prkn.Data.Local;
using System.IO;

namespace Prkn.Bll.Settings
{
    public class SettingsBll 
    {
        public SettingsBll()
        {
        }

        //public static DB_LOCALSETTINGSEntities DB = new DB_LOCALSETTINGSEntities();
        public static List<CLS_Data> Data = new List<CLS_Data>();
        public static string[] name;
        public class CLS_Data
        {
            public int No { get; set; }
            public string Name { get; set; }
            public string Val { get; set; }
        }

        public class Parameter
        {
            public string Name { get; set; }
            public string Val { get; set; }
        }
        #region BASE Methods
        public static void FirstLoad()
        {
            try
            {
                CreateValues();
                CreateData();
            }
            catch (Exception)
            {
                var uri = Global.ProgramDizin.LocalDB_Settings_Path;

                if (File.Exists(uri))
                {
                    File.Delete(uri);
                    CreateValues();
                    CreateData();
                }
            }
     
        }
        public static void CreateValues()
        {
            name = new string[10];
            name[0] = "skin";
            name[1] = "uname";
            name[2] = "upass";
            name[3] = "rememberMe";
            name[4] = "mainProjectsPath";
            name[5] = "mainTeklifPath";
            name[6] = "MirrorDBLastUpdate";
            name[7] = string.Empty;
            name[8] = string.Empty;
            name[9] = string.Empty;
        }
        public static void CheckData()
        {
            SettingsDataContext Db = new SettingsDataContext();
            var d = Db.Prg.ToList();


            for (int i = 0; i < d.Count; i++)
            {

            }

        }
        public static void CreateData()
        {
            //MirrorDataContext db2 = new MirrorDataContext();
            //var dene = db2.Keyword.ToList();

            SettingsDataContext Db = new SettingsDataContext();
            var GetTableData = Db.Prg.ToList();

            if (GetTableData != null)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    string actname = name[i];

                    if (actname != string.Empty)
                    {
                        var datacheck = Db.Prg.Where(x => x.Name == actname).Count<Prg>();
                        if (datacheck == 0)
                        {
                            Prg prg = new Prg();
                            prg.Name = name[i];
                            prg.Type = string.Empty;
                            prg.Value = string.Empty;

                            Db.Prg.Add(prg);
                            Db.SaveChanges();
                        }
                    }

                }
            }

            for (int i = 0; i < name.Count(); i++)
            {
                if (name != null)
                {
                    CLS_Data NewData = new CLS_Data();
                    NewData.No = i;
                    NewData.Name = name[i];
                    Data.Add(NewData);

                    Prg prg = new Prg();

                    prg.Name = name[i];
                    prg.Type = string.Empty;
                    prg.Value = string.Empty;


                    Db.Prg.Add(prg);

                }
            }
        }

        static string GetValue(string ParameterName)
        {
            SettingsDataContext Db = new SettingsDataContext();
            string result = string.Empty;
            string actname = ParameterName;
            var val = Db.Prg.Where(x => x.Name == actname).FirstOrDefault();

            if (val != null)
            {
                result = val.Value;
            }
            else
            {
                result = string.Empty;
            }

            return result;
        }
        static string PostValue(string ParameterName, string NewValue)
        {
            string result = string.Empty;
            string ActName = ParameterName;

            using (var mydb = new SettingsDataContext())
            {
                var val = mydb.Prg.SingleOrDefault(b => b.Name == ActName);
                if (val != null)
                {
                    val.UpdateDate  = Static.DateTimeNow();
                    val.Value       = NewValue;
                    result          = mydb.SaveChanges().ToString();
                }
                else
                {
                    Prg newprg = new Prg
                    {
                        Name = ParameterName,
                        Value = NewValue
                    };

                    mydb.Prg.Add(newprg);
                    result = mydb.SaveChanges().ToString();
                }
            }

            return result;
        }
        #endregion

        #region GETSettings
        public static string GetSkin()
        {
            return GetValue(name[0]);
        }
        public static string GetUname()
        {
            return GetValue(name[1]);
        }
        public static string GetUpass()
        {
            return GetValue(name[2]);
        }
        public static string GetRememberMe()
        {
            return GetValue(name[3]);
        }
        public static string GetMainProjectsPath()
        {
            return GetValue(name[4]);
        }
        public static string GetMainTeklifPath()
        {
            return GetValue(name[5]);
        }
        public static string GetSelfSetting(string PrmName)
        {
            return GetValue(PrmName);
        }
        public static string GetMirrorDBLastUpdate()
        {
            return GetValue(name[6]);
        }
        #endregion

        #region POSTSettings
        public static string PostSkin(string NewValue)
        {
            string result = string.Empty;
            string ActName = name[0];

            return PostValue(ActName, NewValue);
        }
        public static string PostUname(string NewValue)
        {
            string result = string.Empty;
            string ActName = name[1];

            return PostValue(ActName, NewValue);
        }
        public static string PostUpass(string NewValue)
        {
            string result = string.Empty;
            string ActName = name[2];

            return PostValue(ActName, NewValue);
        }
        public static string PostRememberMe(string NewValue)
        {
            string result = string.Empty;
            string ActName = name[3];

            return PostValue(ActName, NewValue);
        }
        public static string PostMainProjectsPath(string NewValue)
        {
            string result = string.Empty;
            string ActName = name[4];

            return PostValue(ActName, NewValue);
        }
        public static string PostMainTeklifPath(string NewValue)
        {
            string result = string.Empty;
            string ActName = name[5];

            return PostValue(ActName, NewValue);
        }
        public static string PostSelfSetting(string PrmName, string Val)
        {
            return PostValue(PrmName, Val);
        }
        public static string PostMirrorDBLastUpdate(string NewValue)
        {
            string result = string.Empty;
            string ActName = name[6];

            return PostValue(ActName, NewValue);
        }
        #endregion







        #region MODEL CLASS
        public class ModelDataEdit : Model.DbSettings.Entities.Prg
        {
        }
        #endregion

        #region WORK AREA
        private static List<Prg> GetData(bool remoteOrLocal)
        {
            if (remoteOrLocal)
            {
                //var uri = Var_JSON.URI.User_Department;
                //ConnWebAPI.SET_Get(uri, out string json);
                //var JsonResult = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Model.User_Department>>(json);
                //return JsonResult;
                List<Prg> a = new List<Prg>();
                return a;
            }
            else
            {
                SettingsDataContext db = new SettingsDataContext();
                return db.Prg.ToList();
            }
        }
        public static List<ModelDataEdit> ListRefresh()
        {
            var getDataResult = GetData(false);

            List<ModelDataEdit> MyList = new List<ModelDataEdit>();

            if (getDataResult != null)
            {
                for (int i = 0; i < getDataResult.Count; i++)
                {
                    ModelDataEdit Data      = new ModelDataEdit();
                    Data.Id                 = getDataResult[i].Id;
                    Data.UpdateDate         = getDataResult[i].UpdateDate;
                    Data.Name               = getDataResult[i].Name;
                    Data.Type               = getDataResult[i].Type;
                    Data.Value              = getDataResult[i].Value;
                    Data.Comment            = getDataResult[i].Comment;
                   

                    MyList.Add(Data);
                }
            }

            return MyList;
        }
        public static long MyCrud(IslemTuru islemturu, string paramName, string value)
        {
            SettingsDataContext db = new SettingsDataContext();

            Prg myPram = new Prg();

            var data = db.Prg.Where(x => x.Name == paramName).FirstOrDefault();

            data.UpdateDate = DateTime.Now;
            data.Name = paramName;
            data.Value = value;

            db.SaveChanges();

            return data.Id;
        }


        //public static long MyCrud(IslemTuru islemturu, Model.User_Department Data)
        //{
        //    long InsertNewId            = Data.Id;
        //    Var_JSON.Work_Support sup1  = new Var_JSON.Work_Support();
        //    sup1.JSon_URI               = _uri;
        //    sup1.SelectDataID           = Data.Id.ToString();
        //    sup1.JsonSerializeObj       = Data;
        //    sup1.Islemturu              = islemturu;
        //    var Res1                    = Var_JSON.Work(sup1);

        //    if (IslemTuru.Insert == islemturu)
        //    {
        //        if (Res1 != null)
        //        {
        //            if (Res1 == "Created")
        //            {
        //                var newVal = Newtonsoft.Json.JsonConvert.DeserializeObject<Model.User_Department>(sup1.ReturnResultJson);
        //                InsertNewId = ((Model.User_Department)newVal).Id;
        //            }
        //        }
        //    }

        //    return InsertNewId;
        //}
        #endregion
    }
}
