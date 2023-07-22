using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.Common.Enums
{
    //Buradaki Sırılama Önemlidir Foreign Key sebebiyle tablo bağlantıları, Tablolar oluşturulurken dikkat edilmesi gerekir.
    public enum DbTabloAdi : int
    {

        Title              , // = 1,
        User_Authorization , // = 2,
        User_Level         , // = 3,
        User_Online        , // = 4,
        User_Department    , // = 5,
        Users              , // = 6,
        User_Logs          , // = 7,
        User_Access        , // = 8,
        User_Screen        , // = 9,
                  
        //Referans Tablolar, //
        Keyword            , // = 10,
        Zone               , // = 11,
        
        // STORE           , //
        Store_Brand        , // = 30,
        Store_ProductGroup , // = 31,
        Store_ProductType  , // = 32,
        Store_Location     , // = 33,
        Store_AddressZone  , // = 34,
        Store_AddressCol   , // = 35,
        Store_AddressRow   , // = 36,
        Store_AddressPos   , // = 37,
        Store_Address      , // = 38,
        Store_Product      , // = 39,
        Store_ProductUnit  , // = 40,
        Store_OutAction    , // = 41,
        Store_ProductBlock , // = 42,
        Store_Warehouse    , // = 43,
        Store_WarehouseOut , // = 44,
        Store_Logs         , // = 45,
                  
        // Customer        , //
        Customer_Type      , // = 50,
        Customers          , // = 51,
        Customer_Section   , // = 52,
        Customer_Contact   , // = 53,
                      
        Supplier_Type      , // = 61,
        Suppliers          , // = 62,
        Supplier_Section   , // = 63,
        Supplier_Contact   , // = 64,
                         
        Projects           , // = 36,
        Project_Rev        , // = 37,
        Project_Detail     , // = 38,
                        
        Task_Status        , // = 39,
        Task_SubjectPrefix , // = 40,
        Task_Priority      , // = 41,
        Tasks              , // = 42,
                       
        Meeting_JoinUser   , // = 43,
        Meeting_Content    , // = 44,
        Meeting_Status     , // = 45,
        Meeting_Type       , // = 46,
        Meetings           , // = 47,
                         
        Licenses           , // = 48




    }
}
