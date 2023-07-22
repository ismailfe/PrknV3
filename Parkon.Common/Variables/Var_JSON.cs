using Prkn.Common.Enums;
using Prkn.Common.Functions;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;

namespace Prkn.Common.Variables
{
    public static class Var_JSON
    {

        public static string APIKey { get; set; } = string.Empty;
        public static string TokenKey { get; set; } = string.Empty;

        //Fix Values
        public static class URI
        {
            public static string domain                 = "http://xxx.xxx.com/";
         //    public static string domain               = "http://localhost:50107/";



            //Admin - Safety
            public static string Token { get; set; }            = domain + "token";

            // Admin - Version Update
            public static string SoftwareVersion { get; set; }  = domain + "api/SoftwareVersion";
            public static string Version { get; set; }          = domain + "software/ver.txt";
            public static string SetupDownload { get; set; }    = domain + "software/setup/PrknSetup.msi";

            // USER
            public static string Users { get; set; }                    = domain + "api/Users";
            public static string User_Department { get; set; }          = domain + "api/User_Department";
            public static string User_Level { get; set; }               = domain + "api/User_Level";
            public static string User_Logs { get; set; }                = domain + "api/User_Logs";
            public static string User_Access { get; set; }              = domain + "api/User_Access";
            public static string User_Authorization { get; set; }       = domain + "api/User_Authorization";
            public static string User_Screen { get; set; }              = domain + "api/User_Screen";
            public static string User_Online_Authorization { get; set; } = domain + "api/User_Authorization/act";
            public static string User_Online { get; set; }              = domain + "api/User_Online";
            public static string ClientCheck { get; set; }              = domain + "api/ClientCheck"; //Online User Check

            // COMMMON
            public static string Currency { get; set; }         = domain + "api/Currency";
            public static string Keyword { get; set; }          = domain + "api/keyword";
            public static string Zone { get; set; }             = domain + "api/zone";
            public static string Title { get; set; }            = domain + "api/title";
            public static string Licenses { get; set; }         = domain + "api/Licenses";

            // STORE
            public static string Store_ProductGroup { get; set; }       = domain + "api/Store_ProductGroup";
            public static string Store_ProductType { get; set; }        = domain + "api/Store_ProductType";
            public static string Store_Location { get; set; }           = domain + "api/Store_Location";
            public static string Store_Brand { get; set; }              = domain + "api/Store_Brand";
            public static string Store_Address { get; set; }            = domain + "api/Store_Address";
            public static string Store_Product { get; set; }            = domain + "api/Store_Product";
            public static string Store_ProductUnit { get; set; }        = domain + "api/Store_ProductUnit";
            public static string Store_OutAction { get; set; }          = domain + "api/Store_OutAction";
            public static string Store_ProductBlock { get; set; }       = domain + "api/Store_ProductBlock";
            public static string Store_Warehouse { get; set; }          = domain + "api/Store_Warehouse";
            public static string Store_WarehouseOut { get; set; }       = domain + "api/Store_WarehouseOut";
            public static string Store_Logs { get; set; }               = domain + "api/Store_Logs";
            public static string Store_AddressZone { get; set; }        = domain + "api/Store_AddressZone";
            public static string Store_AddressRow { get; set; }         = domain + "api/Store_AddressRow";
            public static string Store_AddressCol { get; set; }         = domain + "api/Store_AddressCol";
            public static string Store_AddressPos { get; set; }         = domain + "api/Store_AddressPos";

            // CUSTOMER
            public static string Customer_Type { get; set; }    = domain + "api/Customer_Type";
            public static string Customer_Contact { get; set; } = domain + "api/Customer_Contact";
            public static string Customer_Section { get; set; } = domain + "api/Customer_Section";
            public static string Customers { get; set; }        = domain + "api/Customers";

            // SUPPLIER
            public static string Supplier_Type { get; set; }            = domain + "api/Supplier_Type";
            public static string Supplier_Contact { get; set; }         = domain + "api/Supplier_Contact";
            public static string Supplier_Section { get; set; }         = domain + "api/Supplier_Section";
            public static string Suppliers { get; set; }                = domain + "api/Suppliers";

            // PROJECT
            public static string Projects { get; set; }             = domain + "api/Projects";
            public static string Project_Detail { get; set; }       = domain + "api/Project_Detail";
            public static string Project_GetCode { get; set;  }     = domain + "api/Projects/GetCode";
            public static string Project_CheckCode { get; set; }    = domain + "api/Projects/CheckCode";

            // RPOJECT REV
            public static string Project_Rev { get; set; }                  = domain + "api/Project_Rev";
            public static string Project_Rev_GetCode { get; set; }          = domain + "api/Project_Rev/GetCode";
            public static string Project_Rev_CheckCode { get; set; }     = domain + "api/Project_Rev/CheckCode";
            public static string Project_Rev_RevNoCount { get; set; }       = domain + "api/Project_Rev/GetRevNoCount"; //api/Project_Rev/GetRevNoCount/{PrjId}

            // TASK
            public static string Task_Status { get; set; }      = domain + "api/Task_Status";
            public static string Task_Type { get; set; }        = domain + "api/Task_Type";
            public static string Task_Priority { get; set; }    = domain + "api/Task_Priority";
            public static string Tasks { get; set; }            = domain + "api/Tasks";

            // OFFER
            public static string Offers             { get; set; }   = domain + "api/Offers";
            //public static string OffersOnlyOpen { get; set; }       = domain + "api/Offers/GetOffersOnlyOpen";
            public static string Offer_Type         { get; set; }   = domain + "api/Offer_Type";
            public static string Offer_RequestType  { get; set; }   = domain + "api/Offer_RequestType";
            public static string Offer_RequestSource { get; set; }  = domain + "api/Offer_RequestSource";
            public static string Offer_Status       { get; set; }   = domain + "api/Offer_Status";
            public static string Offer_Details      { get; set; }   = domain + "api/Offer_Details";
            public static string Offer_GetCode { get; set; }        = domain + "api/Offers/GetCode"; //api/Offers/GetCode
            public static string Offer_CheckCode { get; set; }      = domain + "api/Offers/CheckCode"; //api/Offers/CheckCode/{Code}
            public static string Offer_GetVerCode { get; set; }     = domain + "api/Offers/GetVerCode"; //api/Offers/GetVerCode/{Code}/{VerCodePrefix}
            public static string Offer_CheckVerCode { get; set; }   = domain + "api/Offers/CheckVerCode"; //api/Offers/CheckVerCode/{Code}/{VerCode}
            // MEETING
            public static string Meeting_JoinUser { get; set; } = domain + "api/Meeting_JoinUser";
            public static string Meeting_Content { get; set; } = domain + "api/Meeting_Content";
            public static string Meeting_Status { get; set; } = domain + "api/Meeting_Status";
            public static string Meeting_Type { get; set; } = domain + "api/Meeting_Type";
            public static string Meetings { get; set; } = domain + "api/Meetings";

            // IMAGES                  
            public static string Image_User { get; set; } = domain + "api/image/user";
            public static string Image_User_Download { get; set; } = domain + "api/image/user/d";
            public static string Image_Brand { get; set; } = domain + "api/image/brand";
            public static string Image_Brand_Download { get; set; } = domain + "api/image/brand/d";
            public static string Image_Customer { get; set; } = domain + "api/image/customer";
            public static string Image_Customer_Download { get; set; } = domain + "api/image/customer/d";
            public static string Image_Product { get; set; } = domain + "api/image/product";
            public static string Image_Product_Download { get; set; } = domain + "api/image/product/d";
            public static string Image_Supplier { get; set; } = domain + "api/image/supplier";
            public static string Image_Supplier_Download { get; set; } = domain + "api/image/supplier/d";

        }
        public static class ContentType
        {
            public static string ForToken { get; set; } = "application/x-www-form-urlencoded";
            public static string ForMethodGet { get; set; } = string.Empty;
            public static string ForMethodPost { get; set; } = string.Empty;
        }

        public static string Work(Work_Support Support)
        {
            string ResultText               = "";
            IslemTuru sw                   = Support.Islemturu;
            Support.ReturnResult            = null;

            switch (sw) 
            {
                case IslemTuru.Insert:
                    string  JsonText1       = Newtonsoft.Json.JsonConvert.SerializeObject(Support.JsonSerializeObj);
                    dynamic JsonObj1        = Newtonsoft.Json.JsonConvert.DeserializeObject(JsonText1);
                    JsonObj1["CreateDate"]  = DateTime.Now;
                    string JsonText1_Ok     = Newtonsoft.Json.JsonConvert.SerializeObject(JsonObj1);
                    string Result1 = ConnWebAPI.SET_Post(Support.JSon_URI, JsonText1_Ok, out string ResultJSon1);
                    var GetResult1 = Newtonsoft.Json.JsonConvert.DeserializeAnonymousType(ResultJSon1, Support.JsonSerializeObj);
                    ResultText = Result1;
                    Support.ReturnResult = GetResult1;
                    Support.ReturnResultJson = ResultJSon1;


                    break;
                case IslemTuru.Update:
                    string JsonText2        = Newtonsoft.Json.JsonConvert.SerializeObject(Support.JsonSerializeObj);
                    dynamic JsonObj2        = Newtonsoft.Json.JsonConvert.DeserializeObject(JsonText2);
                    JsonObj2["UpdateDate"]  = DateTime.Now;
                    string JsonText2_Ok     = Newtonsoft.Json.JsonConvert.SerializeObject(JsonObj2);
                    string Result2          = ConnWebAPI.SET_Put(Support.JSon_URI + "/" + Support.SelectDataID, JsonText2_Ok);
                    var GetResult2          = Newtonsoft.Json.JsonConvert.DeserializeAnonymousType(JsonText2, Support.JsonSerializeObj);
                    ResultText              = Result2;
                    Support.ReturnResult    = GetResult2;
           
                    break;
                case IslemTuru.Delete:
                    string JsonText3        = Newtonsoft.Json.JsonConvert.SerializeObject(Support.JsonSerializeObj);
                    dynamic JsonObj3        = Newtonsoft.Json.JsonConvert.DeserializeObject(JsonText3);
                    JsonObj3["VarStatus"]   = "Deleted";
                    JsonObj3["DeleteDate"]  = DateTime.Now;
                    string JsonText3_Ok     = Newtonsoft.Json.JsonConvert.SerializeObject(JsonObj3);
                    string Result3          = ConnWebAPI.SET_Put(Support.JSon_URI + "/" + Support.SelectDataID, JsonText3_Ok);
                    var GetResult3          = Newtonsoft.Json.JsonConvert.DeserializeAnonymousType(JsonText3, Support.JsonSerializeObj);
                    Support.ReturnResult    = GetResult3;
                    ResultText              = Result3;
       
                    //string JsonText3_Ok     = JsonText3.Replace("\"VarStatus\":null,", "\"VarStatus\":\"Deleted\",");
                    break;
                default:

                    ResultText = "Operation Error";
                    break;
            }

            return ResultText;


            //if (Mode == "Create")
            //{


            //    return Result;
            //}
            //else if (Mode == "Update")
            //{
            //    customers.UpdateDate = CLS.Now();
            //    Json = Newtonsoft.Json.JsonConvert.SerializeObject(customers);
            //    return ConnWebAPI.SET_Put(Var_JSON.URI.Customers + "/" + Select_Data.Id.ToString(), Json);
            //}
            //else if (Mode == "Delete")
            //{
            //    customers.DeleteDate = CLS.Now();
            //    customers.VarStatus = "Deleted";
            //    Json = Newtonsoft.Json.JsonConvert.SerializeObject(customers);
            //    return ConnWebAPI.SET_Put(Var_JSON.URI.Customers + "/" + Select_Data.Id.ToString(), Json);
            //}
            //else
            //{
            //    return "No Type Select";
            //}
        }
        public class Work_Support
        {
            public IslemTuru Islemturu;
            public object JsonSerializeObj;
            public string JSon_URI;
            public string SelectDataID;
            public object ReturnResult { get; set; }
            public string ReturnResultJson { get; set; }
            public string InsertValId { get; set; }
        }

    }
}
