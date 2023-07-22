namespace Prkn.Data.Local.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "UserPrkn.Currency",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Customer_Contact",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        CustomerId = c.Long(),
                        TitleId = c.Long(),
                        No = c.Int(),
                        Job = c.String(maxLength: 4000),
                        NameFirst = c.String(maxLength: 4000),
                        NameLast = c.String(maxLength: 4000),
                        Phone1 = c.String(maxLength: 4000),
                        Phone2 = c.String(maxLength: 4000),
                        Mail1 = c.String(maxLength: 4000),
                        Mail2 = c.String(maxLength: 4000),
                        Gender = c.Int(),
                        Pic = c.String(maxLength: 4000),
                        Score = c.String(maxLength: 4000),
                        Info = c.String(maxLength: 4000),
                        Keyword = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Customer_Section",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        CustomerId = c.Long(),
                        ZoneId = c.Long(),
                        No = c.Int(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                        Address = c.String(maxLength: 4000),
                        Maps = c.String(maxLength: 4000),
                        Phone1 = c.String(maxLength: 4000),
                        Phone2 = c.String(maxLength: 4000),
                        Fax = c.String(maxLength: 4000),
                        Pic = c.String(maxLength: 4000),
                        Score = c.String(maxLength: 4000),
                        Info = c.String(maxLength: 4000),
                        Keyword = c.String(maxLength: 4000),
                        Customers_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("UserPrkn.Customers", t => t.Customers_Id)
                .ForeignKey("UserPrkn.Zone", t => t.ZoneId)
                .Index(t => t.ZoneId)
                .Index(t => t.Customers_Id);
            
            CreateTable(
                "UserPrkn.Customers",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        CustomerTypeId = c.Long(),
                        ZoneId = c.Long(),
                        No = c.Int(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(nullable: false, maxLength: 4000),
                        Address = c.String(maxLength: 4000),
                        Maps = c.String(maxLength: 4000),
                        Phone1 = c.String(maxLength: 4000),
                        Phone2 = c.String(maxLength: 4000),
                        Fax = c.String(maxLength: 4000),
                        Pic = c.String(maxLength: 4000),
                        Score = c.String(maxLength: 4000),
                        Info = c.String(maxLength: 4000),
                        Keyword = c.String(maxLength: 4000),
                        Customer_Type_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("UserPrkn.Customer_Type", t => t.Customer_Type_Id)
                .Index(t => t.Customer_Type_Id);
            
            CreateTable(
                "UserPrkn.Offers",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        CustomerId = c.Long(),
                        CustomerSectionId = c.Long(),
                        CustomerContactId = c.Long(),
                        OfferTypeId = c.Long(),
                        OfferRequestTypeId = c.Long(),
                        OfferRequestSourceId = c.Long(),
                        OfferStatusId = c.Long(),
                        OfferDetailsId = c.Long(),
                        RefNo = c.Long(),
                        Code = c.String(maxLength: 4000),
                        VerCode = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                        PreparationDate = c.DateTime(),
                        ValidityPeriodWeek = c.Int(),
                        OfferContent = c.String(maxLength: 4000),
                        ResultComment = c.String(maxLength: 4000),
                        ResultDate = c.DateTime(),
                        Price = c.Double(),
                        TargetCost = c.Double(),
                        RealCost = c.Double(),
                        ExchangeRate = c.Double(),
                        ExchangeRateDate = c.DateTime(),
                        CurrencyId = c.Long(),
                        Keyword = c.String(maxLength: 4000),
                        Active = c.String(maxLength: 4000),
                        Customer_Section_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("UserPrkn.Customer_Section", t => t.Customer_Section_Id)
                .Index(t => t.Customer_Section_Id);
            
            CreateTable(
                "UserPrkn.Projects",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        ProjectDetailId = c.Long(),
                        CustomerId = c.Long(),
                        CustomerSectionId = c.Long(),
                        CustomerContactId = c.Long(),
                        RefNoOld = c.String(maxLength: 4000),
                        RefNo = c.Long(),
                        PeriodMonth = c.Int(),
                        PeriodYear = c.Int(),
                        DateStart = c.DateTime(),
                        DateEnd = c.DateTime(),
                        No = c.String(maxLength: 4000),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                        Keyword = c.String(maxLength: 4000),
                        Customer_Section_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("UserPrkn.Customer_Section", t => t.Customer_Section_Id)
                .Index(t => t.Customer_Section_Id);
            
            CreateTable(
                "UserPrkn.Zone",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                        PhoneCode = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Customer_Type",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                        Users_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("UserPrkn.Users", t => t.Users_Id)
                .Index(t => t.Users_Id);
            
            CreateTable(
                "UserPrkn.Users",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        UId = c.Guid(),
                        AutrizationId = c.Long(),
                        LevelsId = c.Long(),
                        OnlineId = c.Long(),
                        DepartmentId = c.Long(),
                        TitleId = c.Long(),
                        Role = c.String(maxLength: 4000),
                        Pic = c.String(maxLength: 4000),
                        BirthDate = c.DateTime(),
                        NameFirst = c.String(maxLength: 4000),
                        NameLast = c.String(maxLength: 4000),
                        Mail1 = c.String(maxLength: 4000),
                        Mail2 = c.String(maxLength: 4000),
                        Phone1 = c.String(maxLength: 4000),
                        Phone2 = c.String(maxLength: 4000),
                        UserName = c.String(maxLength: 4000),
                        Pass = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Keyword",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Meeting_Content",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Meeting_JoinUser",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Meeting_Status",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Meeting_Type",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Meetings",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Offer_Details",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Offer_RequestSource",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Offer_RequestType",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Offer_Status",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Offer_Type",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Project_Detail",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Project_Rev",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        ProjectId = c.Long(),
                        CustomerContactId = c.Long(),
                        PeriodMonth = c.Int(),
                        PeriodYear = c.Int(),
                        DateStart = c.DateTime(),
                        DateEnd = c.DateTime(),
                        RefNo = c.Long(),
                        No = c.Int(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                        Keyword = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.SoftwareVersion",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Platform = c.String(maxLength: 4000),
                        VerNo = c.String(maxLength: 4000),
                        VerInfo = c.String(maxLength: 4000),
                        VerTitle = c.String(maxLength: 4000),
                        VerContent = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Store_Address",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        ZoneId = c.Long(),
                        ColId = c.Long(),
                        RowId = c.Long(),
                        PosId = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Store_AddressCol",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Store_AddressPos",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Store_AddressRow",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Store_AddressZone",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Store_Brand",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                        Origin = c.String(maxLength: 4000),
                        Pic = c.String(maxLength: 4000),
                        Score = c.String(maxLength: 4000),
                        Info = c.String(maxLength: 4000),
                        Keyword = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Store_Location",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Store_Logs",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Store_OutAction",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Store_Product",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        BrandId = c.Long(),
                        GroupId = c.Long(),
                        TypeId = c.Long(),
                        LocationId = c.Long(),
                        AddressId = c.Long(),
                        UnitId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Status = c.String(maxLength: 4000),
                        ProductCodeFirstChar = c.String(maxLength: 4000),
                        ProductCodeEndChar = c.String(maxLength: 4000),
                        ProductIDFirstChar = c.String(maxLength: 4000),
                        ProductIDEndChar = c.String(maxLength: 4000),
                        Barcode = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                        Features = c.String(maxLength: 4000),
                        Pic = c.String(maxLength: 4000),
                        Score = c.String(maxLength: 4000),
                        Info = c.String(maxLength: 4000),
                        Keyword = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Store_ProductBlock",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        ProductId = c.Long(),
                        DateStart = c.DateTime(),
                        DateEnd = c.DateTime(),
                        Info = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Store_ProductGroup",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Store_ProductType",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Store_ProductUnit",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                        Symbol = c.String(maxLength: 4000),
                        Factor = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Store_Warehouse",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        ProductId = c.Long(),
                        BlockId = c.Long(),
                        SerialNo = c.String(maxLength: 4000),
                        RefNo = c.String(maxLength: 4000),
                        StockNo = c.String(maxLength: 4000),
                        StockNoAux = c.String(maxLength: 4000),
                        Status = c.String(maxLength: 4000),
                        PriceList = c.String(maxLength: 4000),
                        PriceListCurrency = c.String(maxLength: 4000),
                        PricePurchase = c.String(maxLength: 4000),
                        PricePurchaseCurrency = c.String(maxLength: 4000),
                        PriceSale = c.String(maxLength: 4000),
                        PriceSaleCurrency = c.String(maxLength: 4000),
                        PercentageTax = c.String(maxLength: 4000),
                        PercentageDiscount = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Store_WarehouseOut",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        ProductId = c.Long(),
                        BlockId = c.Long(),
                        SerialNo = c.String(maxLength: 4000),
                        RefNo = c.String(maxLength: 4000),
                        StockNo = c.String(maxLength: 4000),
                        StockNoAux = c.String(maxLength: 4000),
                        Status = c.String(maxLength: 4000),
                        PriceList = c.String(maxLength: 4000),
                        PriceListCurrency = c.String(maxLength: 4000),
                        PricePurchase = c.String(maxLength: 4000),
                        PricePurchaseCurrency = c.String(maxLength: 4000),
                        PriceSale = c.String(maxLength: 4000),
                        PriceSaleCurrency = c.String(maxLength: 4000),
                        PercentageTax = c.String(maxLength: 4000),
                        PercentageDiscount = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Supplier_Contact",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        SupplierId = c.Long(),
                        TitleId = c.Long(),
                        No = c.Int(),
                        Job = c.String(maxLength: 4000),
                        NameFirst = c.String(maxLength: 4000),
                        NameLast = c.String(maxLength: 4000),
                        Phone1 = c.String(maxLength: 4000),
                        Phone2 = c.String(maxLength: 4000),
                        Mail1 = c.String(maxLength: 4000),
                        Mail2 = c.String(maxLength: 4000),
                        Gender = c.Int(),
                        Pic = c.String(maxLength: 4000),
                        Score = c.String(maxLength: 4000),
                        Info = c.String(maxLength: 4000),
                        Keyword = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Supplier_Section",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        SupplierId = c.Long(),
                        ZoneId = c.Long(),
                        No = c.Int(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                        Address = c.String(maxLength: 4000),
                        Maps = c.String(maxLength: 4000),
                        Phone1 = c.String(maxLength: 4000),
                        Phone2 = c.String(maxLength: 4000),
                        Fax = c.String(maxLength: 4000),
                        Pic = c.String(maxLength: 4000),
                        Score = c.String(maxLength: 4000),
                        Info = c.String(maxLength: 4000),
                        Keyword = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Supplier_Type",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Suppliers",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        SupplierTypeId = c.Long(),
                        ZoneId = c.Long(),
                        No = c.Int(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                        Address = c.String(maxLength: 4000),
                        Maps = c.String(maxLength: 4000),
                        Phone1 = c.String(maxLength: 4000),
                        Phone2 = c.String(maxLength: 4000),
                        Fax = c.String(maxLength: 4000),
                        Pic = c.String(maxLength: 4000),
                        Score = c.String(maxLength: 4000),
                        Info = c.String(maxLength: 4000),
                        Keyword = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Task_Priority",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Task_Status",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Task_SubjectPrefix",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Task_Type",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Tasks",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        ProjectId = c.Long(),
                        SubjectPrefixId = c.Long(),
                        StatusId = c.Long(),
                        PriorityId = c.Long(),
                        TypeId = c.Long(),
                        AssingedUserId = c.Long(),
                        ManagerUserId = c.Long(),
                        Subject = c.String(maxLength: 4000),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        Description = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.Title",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.User_Access",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.User_Authorization",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        SetUserId = c.Long(),
                        C0 = c.Long(),
                        C1 = c.Long(),
                        C2 = c.Long(),
                        C3 = c.Long(),
                        C4 = c.Long(),
                        C5 = c.Long(),
                        C6 = c.Long(),
                        C7 = c.Long(),
                        C8 = c.Long(),
                        C9 = c.Long(),
                        C10 = c.Long(),
                        C11 = c.Long(),
                        C12 = c.Long(),
                        C13 = c.Long(),
                        C14 = c.Long(),
                        C15 = c.Long(),
                        C16 = c.Long(),
                        C17 = c.Long(),
                        C18 = c.Long(),
                        C19 = c.Long(),
                        C20 = c.Long(),
                        C21 = c.Long(),
                        C22 = c.Long(),
                        C23 = c.Long(),
                        C24 = c.Long(),
                        C25 = c.Long(),
                        C26 = c.Long(),
                        C27 = c.Long(),
                        C28 = c.Long(),
                        C29 = c.Long(),
                        C30 = c.Long(),
                        C31 = c.Long(),
                        C32 = c.Long(),
                        C33 = c.Long(),
                        C34 = c.Long(),
                        C35 = c.Long(),
                        C36 = c.Long(),
                        C37 = c.Long(),
                        C38 = c.Long(),
                        C39 = c.Long(),
                        C40 = c.Long(),
                        C41 = c.Long(),
                        C42 = c.Long(),
                        C43 = c.Long(),
                        C44 = c.Long(),
                        C45 = c.Long(),
                        C46 = c.Long(),
                        C47 = c.Long(),
                        C48 = c.Long(),
                        C49 = c.Long(),
                        C50 = c.Long(),
                        C51 = c.Long(),
                        C52 = c.Long(),
                        C53 = c.Long(),
                        C54 = c.Long(),
                        C55 = c.Long(),
                        C56 = c.Long(),
                        C57 = c.Long(),
                        C58 = c.Long(),
                        C59 = c.Long(),
                        C60 = c.Long(),
                        C61 = c.Long(),
                        C62 = c.Long(),
                        C63 = c.Long(),
                        C64 = c.Long(),
                        C65 = c.Long(),
                        C66 = c.Long(),
                        C67 = c.Long(),
                        C68 = c.Long(),
                        C69 = c.Long(),
                        C70 = c.Long(),
                        C71 = c.Long(),
                        C72 = c.Long(),
                        C73 = c.Long(),
                        C74 = c.Long(),
                        C75 = c.Long(),
                        C76 = c.Long(),
                        C77 = c.Long(),
                        C78 = c.Long(),
                        C79 = c.Long(),
                        C80 = c.Long(),
                        C81 = c.Long(),
                        C82 = c.Long(),
                        C83 = c.Long(),
                        C84 = c.Long(),
                        C85 = c.Long(),
                        C86 = c.Long(),
                        C87 = c.Long(),
                        C88 = c.Long(),
                        C89 = c.Long(),
                        C90 = c.Long(),
                        C91 = c.Long(),
                        C92 = c.Long(),
                        C93 = c.Long(),
                        C94 = c.Long(),
                        C95 = c.Long(),
                        C96 = c.Long(),
                        C97 = c.Long(),
                        C98 = c.Long(),
                        C99 = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.User_Department",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.User_Level",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Level1 = c.String(maxLength: 4000),
                        Level2 = c.String(maxLength: 4000),
                        Level3 = c.String(maxLength: 4000),
                        Level4 = c.String(maxLength: 4000),
                        Level5 = c.String(maxLength: 4000),
                        Level6 = c.String(maxLength: 4000),
                        Level7 = c.String(maxLength: 4000),
                        Level8 = c.String(maxLength: 4000),
                        Level9 = c.String(maxLength: 4000),
                        Level10 = c.String(maxLength: 4000),
                        Level11 = c.String(maxLength: 4000),
                        Level12 = c.String(maxLength: 4000),
                        Level13 = c.String(maxLength: 4000),
                        Level14 = c.String(maxLength: 4000),
                        Level15 = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.User_Logs",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.User_Online",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "UserPrkn.User_Screen",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SysCode = c.String(maxLength: 4000),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        VarStatus = c.String(maxLength: 4000),
                        Comment = c.String(maxLength: 4000),
                        UserId = c.Long(),
                        Code = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                        SetUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("UserPrkn.Customer_Type", "Users_Id", "UserPrkn.Users");
            DropForeignKey("UserPrkn.Customers", "Customer_Type_Id", "UserPrkn.Customer_Type");
            DropForeignKey("UserPrkn.Customer_Section", "ZoneId", "UserPrkn.Zone");
            DropForeignKey("UserPrkn.Projects", "Customer_Section_Id", "UserPrkn.Customer_Section");
            DropForeignKey("UserPrkn.Offers", "Customer_Section_Id", "UserPrkn.Customer_Section");
            DropForeignKey("UserPrkn.Customer_Section", "Customers_Id", "UserPrkn.Customers");
            DropIndex("UserPrkn.Customer_Type", new[] { "Users_Id" });
            DropIndex("UserPrkn.Projects", new[] { "Customer_Section_Id" });
            DropIndex("UserPrkn.Offers", new[] { "Customer_Section_Id" });
            DropIndex("UserPrkn.Customers", new[] { "Customer_Type_Id" });
            DropIndex("UserPrkn.Customer_Section", new[] { "Customers_Id" });
            DropIndex("UserPrkn.Customer_Section", new[] { "ZoneId" });
            DropTable("UserPrkn.User_Screen");
            DropTable("UserPrkn.User_Online");
            DropTable("UserPrkn.User_Logs");
            DropTable("UserPrkn.User_Level");
            DropTable("UserPrkn.User_Department");
            DropTable("UserPrkn.User_Authorization");
            DropTable("UserPrkn.User_Access");
            DropTable("UserPrkn.Title");
            DropTable("UserPrkn.Tasks");
            DropTable("UserPrkn.Task_Type");
            DropTable("UserPrkn.Task_SubjectPrefix");
            DropTable("UserPrkn.Task_Status");
            DropTable("UserPrkn.Task_Priority");
            DropTable("UserPrkn.Suppliers");
            DropTable("UserPrkn.Supplier_Type");
            DropTable("UserPrkn.Supplier_Section");
            DropTable("UserPrkn.Supplier_Contact");
            DropTable("UserPrkn.Store_WarehouseOut");
            DropTable("UserPrkn.Store_Warehouse");
            DropTable("UserPrkn.Store_ProductUnit");
            DropTable("UserPrkn.Store_ProductType");
            DropTable("UserPrkn.Store_ProductGroup");
            DropTable("UserPrkn.Store_ProductBlock");
            DropTable("UserPrkn.Store_Product");
            DropTable("UserPrkn.Store_OutAction");
            DropTable("UserPrkn.Store_Logs");
            DropTable("UserPrkn.Store_Location");
            DropTable("UserPrkn.Store_Brand");
            DropTable("UserPrkn.Store_AddressZone");
            DropTable("UserPrkn.Store_AddressRow");
            DropTable("UserPrkn.Store_AddressPos");
            DropTable("UserPrkn.Store_AddressCol");
            DropTable("UserPrkn.Store_Address");
            DropTable("UserPrkn.SoftwareVersion");
            DropTable("UserPrkn.Project_Rev");
            DropTable("UserPrkn.Project_Detail");
            DropTable("UserPrkn.Offer_Type");
            DropTable("UserPrkn.Offer_Status");
            DropTable("UserPrkn.Offer_RequestType");
            DropTable("UserPrkn.Offer_RequestSource");
            DropTable("UserPrkn.Offer_Details");
            DropTable("UserPrkn.Meetings");
            DropTable("UserPrkn.Meeting_Type");
            DropTable("UserPrkn.Meeting_Status");
            DropTable("UserPrkn.Meeting_JoinUser");
            DropTable("UserPrkn.Meeting_Content");
            DropTable("UserPrkn.Keyword");
            DropTable("UserPrkn.Users");
            DropTable("UserPrkn.Customer_Type");
            DropTable("UserPrkn.Zone");
            DropTable("UserPrkn.Projects");
            DropTable("UserPrkn.Offers");
            DropTable("UserPrkn.Customers");
            DropTable("UserPrkn.Customer_Section");
            DropTable("UserPrkn.Customer_Contact");
            DropTable("UserPrkn.Currency");
        }
    }
}
