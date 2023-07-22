using Prkn.Model;
using Prkn.Bll.Master.PrknDataBll.Customer;
using Prkn.Bll.Master.PrknDataBll.General;
using Prkn.Bll.Master.PrknDataBll.Offer;
using Prkn.Bll.Master.PrknDataBll.User;
using Prkn.Common.Enums;
using Prkn.Common.Functions;
using Prkn.Common.Generate;
using Prkn.UI.Web.Models.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Prkn.UI.Web.Functions
{
    public class ViewFunction
    {
        #region Listeleme sayfalarında kullanmak için ID si gönderilen satırı getiriyor
        public static DropDownModel getOfferStatus(long Id)
        {
            var getBll = new OfferStatusBll();
            var getData = getBll.GetSingle(x => x.Id == Id, x => x);

            DropDownModel prm = new DropDownModel();
            prm.Name = getData.Name;
            prm.Id = getData.Id;
            return (prm);
        }
        public static DropDownModel getOfferType(long Id)
        {
            var getBll = new OfferTypeBll();
            var getData = getBll.GetSingle(x => x.Id == Id, x => x);

            DropDownModel prm = new DropDownModel();
            prm.Name = getData.Name;
            prm.Id = getData.Id;
            return (prm);
        }
        public static DropDownModel getCurrency(long Id)
        {
            var getBll = new CurrencyBll();
            var getData = getBll.GetSingle(x => x.Id == Id, x => x);

            DropDownModel prm = new DropDownModel();
            prm.Name = getData.Name;
            prm.Id = getData.Id;
            return (prm);
        }
        public static DropDownModel getUser(long Id)
        {
            var getBll = new UserBll();
            var getData = getBll.GetSingle(x => x.Id == Id, x => x);

            DropDownModel prm = new DropDownModel();

            if (getData != null)
            {
                prm.Name = getData.NameFirst + " " + getData.NameLast;
                prm.Id = getData.Id;
            }
            else
            {   prm.Name = "-"; //User Viewleri daha oluşturulmadığı için
                prm.Id = 1; }
            return (prm);
        }
        public static DropDownModel getCustomerSection(long Id)
        {
            var getBll = new CustomerSectionBll();
            var getData = getBll.GetSingle(x => x.Id == Id, x => x);

            DropDownModel prm = new DropDownModel();

            if (getData != null)
            {
                prm.Name = getData.Name;
                prm.Id = getData.Id;
            }
            else
            {
                prm.Name = null;
                prm.Id = null;
            }
            return (prm);
        }
        public static DropDownModel getCustomer(long Id)
        {
            var getBll = new CustomerBll();
            var getData = getBll.GetSingle(x => x.Id == Id, x => x);

            DropDownModel prm = new DropDownModel();

            if (getData != null)
            {
                prm.Name = getData.Name;
                prm.Id = getData.Id;
            }
            else
            {
                prm.Name = null;
                prm.Id = null;
            }
            return (prm);
        }
        public static DropDownModel getTitle(long Id)
        {
            var getBll = new TitleBll();

            var getData = getBll.GetSingle(x => x.Id == Id, x => x);

            DropDownModel prm = new DropDownModel();
            prm.Name = getData.Name;
            prm.Id = getData.Id;
            return (prm);
        }
        public static DropDownModel GetZone(long? zoneId)
        {
            ZoneBll zoneBll = new ZoneBll();

            DropDownModel prm = new DropDownModel();

            var getZoneData = zoneBll.GetSingle(x => x.Id == zoneId, x => x);

            if (getZoneData != null)
            {
                prm.Id = zoneId;
                prm.Name = getZoneData.Name;
                //
            }
            return prm;
        }
        public static DropDownModel GetCustomerType(long? customertypeId)
        {
            CustomerTypeBll customerTypeBll = new CustomerTypeBll();

            DropDownModel prm = new DropDownModel();

            var getCustomerTypeData = customerTypeBll.GetSingle(x => x.Id == customertypeId, x => x);

            if (getCustomerTypeData != null)
            {
                prm.Id = customertypeId;
                prm.Name = getCustomerTypeData.Name;
                //
            }
            return prm;
        }

        public static DropDownModel getDepartment(long departmentId)
        {
            UserDepartmentBll departmentBll = new UserDepartmentBll();

            DropDownModel prm = new DropDownModel();

            var getDepartmentData = departmentBll.GetSingle(x => x.Id == departmentId, x => x);

            if (getDepartmentData != null)
            {
                prm.Id = departmentId;
                prm.Name = getDepartmentData.Name;
                //
            }
            return prm;
        }
        #endregion

        public static List<DropDownModelJson> DDLFillingJson(List<DropDownModel> getData)
        {
            var jsonList = new List<DropDownModelJson>();
            for (int i = 0; i < getData.Count; i++)
            {
                DropDownModelJson jsondata = new DropDownModelJson();
                jsondata.Id = getData[i].Id.ToString();
                jsondata.Name = getData[i].Name;
                jsonList.Add(jsondata);
            }
            return jsonList;
        }

        public static ParametersEdit ModelToParameterEdit<T>(T myModel, long Id, IslemTuru islemturu) where T : class
        {
            var parametersEdit = new ParametersEdit();
            if (myModel != null)
            {
                parametersEdit.Prm = new Prm();
                parametersEdit.Prm.Id = (long)myModel.GetType().GetProperty("Id").GetValue(myModel);
                parametersEdit.Prm.Code = (string)myModel.GetType().GetProperty("Code").GetValue(myModel);
                parametersEdit.Prm.Name = (string)myModel.GetType().GetProperty("Name").GetValue(myModel);
                parametersEdit.Prm.Comment = (string)myModel.GetType().GetProperty("Comment").GetValue(myModel);
            }
            else
            {
                parametersEdit.Prm = new Prm();
                parametersEdit.Prm.Id = 0;
                parametersEdit.Prm.Code = "";
                parametersEdit.Prm.Name = "";
                parametersEdit.Prm.Comment = "";
            }
            parametersEdit.IslemTuru = islemturu;

            return parametersEdit;
        }

      //  public static string parametrePath = "{islemturu}/{Id}";
        public static T ParametersEditToModel<T, TBll>  (ParametersEdit parametersEdit, T myModel, TBll getBll) where T : class where TBll : class
        {

            var code        = myModel.GetType().GetProperty("Code");
            var name        = myModel.GetType().GetProperty("Name");
            var comment     = myModel.GetType().GetProperty("Comment");
            var id          = myModel.GetType().GetProperty("Id");
      //      var userId      = myModel.GetType().GetProperty("UserId");

            code.SetValue(myModel, parametersEdit.Prm.Code);
            name.SetValue(myModel, parametersEdit.Prm.Name);
            comment.SetValue(myModel, parametersEdit.Prm.Comment);
     //       userId.SetValue(myModel, );
            var getId = Generator.CreateId(parametersEdit.IslemTuru, parametersEdit.Prm.Id);
            id.SetValue(myModel, getId);

            if (parametersEdit.IslemTuru == IslemTuru.Insert)
            {
                var GetMetod = getBll.GetType().GetMethod("Insert");

                if (GetMetod != null)
                {
                    object[] prm = new object[1];
                    prm[0] = myModel;

                    var Method = GetMetod.Invoke(getBll, prm); // Values Null değilse Method Invoke

                    parametersEdit.JobStatus = DateTime.Now + " - Yeni Kayıt işlemi " + Method;
                }

                //parametersEdit.JobStatus = DateTime.Now + " - Yeni Kayıt işlemi " + insert.;
            }
            else if (parametersEdit.IslemTuru == IslemTuru.Update)
            {
                var GetMetod = getBll.GetType().GetMethod("Update");

                if (GetMetod != null)
                {
                    object[] prm = new object[1];
                    prm[0] = myModel;

                    var Method = GetMetod.Invoke(getBll, prm); // Values Null değilse Method Invoke

                    parametersEdit.JobStatus = DateTime.Now + " - Kayıt Düzenleme işlemi " + Method;
                }

                //parametersEdit.JobStatus = DateTime.Now + " - Kayıt Düzenleme işlemi " + getBll.Update(myModel);
            }
            else if (parametersEdit.IslemTuru == IslemTuru.Delete)
            {
                var GetMetod = getBll.GetType().GetMethod("Delete");

                if (GetMetod != null)
                {
                    object[] prm = new object[1];
                    prm[0] = myModel;

                    var Method = GetMetod.Invoke(getBll, prm); // Values Null değilse Method Invoke

                    parametersEdit.JobStatus = DateTime.Now + " - Kayıt Silme işlemi " + Method;
                }
                //parametersEdit.JobStatus = DateTime.Now + " - Kayıt silme işlemi " + getBll.DeleteSoft(myModel);
            }

            var result = myModel;

            return result;
        }

        public static string modalstatus = null;
        public static List<DropDownModel> PreparingTypeFilling()
        {
            //---Hazırlama modu için Yeni veya Versiyon
            List<DropDownModel> preparingtype = new List<DropDownModel>();
            DropDownModel prepatingtype_data = new DropDownModel();
            prepatingtype_data.Id = 1;
            prepatingtype_data.Name = "Yeni Teklif Oluştur";
            preparingtype.Add(prepatingtype_data);
            prepatingtype_data.Id = 2;
            prepatingtype_data = new DropDownModel();
            prepatingtype_data.Name = "Versiyon Oluştur";
            preparingtype.Add(prepatingtype_data);
            
            //-- Hazırlama modu oluşturma bitiş 
            return (preparingtype);
        }
        

        public static List<DropDownModel> CustomerContact_DDLFilling(long id)//Bu fonksiyonu eklemiçim fakat gerekli şekilde kullanmamışım
        {
            CustomerContactBll customerContactBll = new CustomerContactBll();

            var getData = customerContactBll.GetList(x => x.CustomerId == id, x => x).ToList();

            List<DropDownModel> DDlist = new List<DropDownModel>();

            for (int i = 0; i < getData.Count; i++)
            {
                DropDownModel ddlModel = new DropDownModel();
                ddlModel.Id = getData[i].Id;
                ddlModel.Name = getData[i].NameFirst + " " + getData[i].NameLast + " | " + getData[i].Job;
                DDlist.Add(ddlModel);
            }

            /*
            var getData = DropDownModelFilling(customerContactBll, "CustomerId", id, null, 0, "NameFirst");
            //Customer Contact tablosunda name yerine NameFirst var bu sebeple son parametre hangi alanın verilerini getireceğimizi söyleyecek
            var getData2 = DropDownModelFilling(customerContactBll, "CustomerId", id, null, 0, "NameLast");
            var getData3 = DropDownModelFilling(customerContactBll, "CustomerId", id, null, 0, "Job");

            for (int i = 0; i < getData11.Count; i++)
            {
                getData[i].Name = getData[i].Name.ToString() + " " + getData2[i].Name.ToString() + " -|- " + getData3[i].Name.ToString();
                //Burda kişinin Adı ve soyadını birleştirip gönderiyoruz
            }
            */
            return DDlist;
        }

        public static List<DropDownModel> DropDownModelFilling<T>(T getBll, string FindIdCol1 = null, long FindId1 = 0, string FindIdCol2 = null, long FindId2 = 0, string whichColName=null) where T : class
        {
                List<DropDownModel> DDlist = new List<DropDownModel>();
            try
            {
                var GetMetod            = getBll.GetType().GetMethod("ListRefresh");
                var getData             = GetMetod.Invoke(getBll, null); // Values Null değilse Method Invoke
                IList getDataList       = getData as IList;

                if (getDataList != null)
                {
                    for (int i = 0; i < getDataList.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(FindIdCol1))
                        {
                            var idCol1 = getDataList[i].GetType().GetProperty(FindIdCol1);
                            if (idCol1 != null)
                            {
                                var CheckId1 = (long)getDataList[i].GetType().GetProperty(FindIdCol1).GetValue(getDataList[i]);
                                if (CheckId1 == FindId1)
                                {
                                    if (whichColName==null) //Name colonundaki bilgeleri çekmek istemezsek else ye girecek
                                    {
                                        DropDownModel data = new DropDownModel();
                                        data.Name = (string)getDataList[i].GetType().GetProperty("Name").GetValue(getDataList[i]);
                                        data.Id = (long)getDataList[i].GetType().GetProperty("Id").GetValue(getDataList[i]);
                                        data.Code = (string)getDataList[i].GetType().GetProperty("Code").GetValue(getDataList[i]);
                                        DDlist.Add(data);

                                    }
                                    else //whichName olarak gönderdiğimiz kolon adını ve id sini döndürecek
                                    {
                                        DropDownModel data = new DropDownModel();
                                        data.Name = (string)getDataList[i].GetType().GetProperty(whichColName).GetValue(getDataList[i]);
                                        data.Id = (long)getDataList[i].GetType().GetProperty("Id").GetValue(getDataList[i]);
                                        DDlist.Add(data);
                                    }  
                                }
                            }
                        }
                        
                        else
                        {
                            DropDownModel data = new DropDownModel();
                            data.Name = (string)getDataList[i].GetType().GetProperty("Name").GetValue(getDataList[i]);
                            data.Id = (long)getDataList[i].GetType().GetProperty("Id").GetValue(getDataList[i]);
                            data.Code = (string)getDataList[i].GetType().GetProperty("Code").GetValue(getDataList[i]);
                            DDlist.Add(data);
                        }        
                    }
                }
            }
            catch (Exception)
            {
            }
            return DDlist;
        }

        public static string CreateCode(IslemTuru islemTuru,string code, int ver,DateTime? preparationdate)
        {
            if (islemTuru==IslemTuru.Insert && ver!=1 && preparationdate!=null)
            {
                OfferBll offerBll = new OfferBll();

                var offerList = offerBll.ListRefresh();
                var yil = preparationdate.Value.Year;
                var offercount = offerList.Where(x => x.PreparationDate.Value.Year == yil && x.VarStatus == null).GroupBy(x => x.Code).Count();
                var newcount = offercount + 1;
                string yilsoniki = yil.ToString().Remove(0, 2);
                return "T" + yilsoniki + "e" + UcBasamakYap(newcount.ToString());
            }
            return code;
        }

        public static DateTime? GetResultDate(long? offerStatusId)
        {
            OfferStatusBll offerStatusBll = new OfferStatusBll();

            var getOfferStatusData = offerStatusBll.GetSingle(x => x.Id == offerStatusId, x => x);
            
            if (getOfferStatusData != null)
            {
               string offerStatusName = getOfferStatusData.Code; //
              //  offerStatusName = offerStatusName.Substring(0,5);//Yani Durum Sonuç ile başlıyorsa sonuç tarihi gönder
                if (offerStatusName == "KAPALI")
                {
                    return DateTime.Now;
                } 
            }
            return null;
        }



        public static string GetActive(IslemTuru islemTuru, int versiyon, DateTime? resultdate)
        {
            string active = null;
            if ((islemTuru==IslemTuru.Insert || versiyon==1 || islemTuru==IslemTuru.Update) && resultdate==null)
            {
                active = "true";
            }
            return active;
        }

        public static string CreateVerCode(IslemTuru islemTuru, int versiyon, long? offerRequestTypeId, string code, string vercode)
        {
            if (islemTuru == IslemTuru.Insert || versiyon == 1)
            {
                return GetVerCode(offerRequestTypeId, code);
            }
            else
            {
                return vercode;
            }
        }
        public static string GetRequestTypeCode(long? id=1)
        {
            OfferRequestTypeBll offerRequestTypeBll = new OfferRequestTypeBll();

            var getOfferRequestData = offerRequestTypeBll.GetSingle(x => x.Id == id, x => x);

            string offerrequesttypeCode = "V";
            if (getOfferRequestData != null)
            {
                offerrequesttypeCode = getOfferRequestData.Code; //Versiyon Kodunun 1.Değeri V yada B
            }
            
            return offerrequesttypeCode;
        }
        public static string GetVerCode(long? offerRequestTypeId, string offerCode)
        {       
            OfferBll offerBll = new OfferBll();

            string offerrequesttypeCode = GetRequestTypeCode(offerRequestTypeId);

            var offerList = offerBll.ListRefresh();
            var getCount = offerList.Where(x => x.Code == offerCode && x.OfferRequestTypeId == offerRequestTypeId).Count();
            var newCount = getCount + 1;

            return offerrequesttypeCode + IkiBasamakYap(newCount.ToString());
        }
        public static string UcBasamakYap(string val)
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
        public static string IkiBasamakYap(string val)
        {
            switch (val.Length)
            {
                case 1:
                    return "0" + val;
            }
            return val;
        }

        internal static bool SetOfferActive(long Id, string active)
        {
            //--Model ve Model Tanımlama
            OfferBll getBll = new OfferBll();

            var getData = getBll.GetSingle(x => x.Id == Id, x => x);

            //--
            getData.Active = active; //Burda parametre olarak gönderdiğimiz değeri active sütunua yazıyoruz.
            //--

            string JobStatus= getBll.Update(getData); //burda eski Versiyonu ID değişmeden active alanını kapalı yapıyoruz
            if (JobStatus=="OK")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}