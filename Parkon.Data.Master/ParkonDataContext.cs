using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Prkn.Model;
using Prkn.Data.Master.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure;

namespace Prkn.Data.Master
{
    public partial class PrknDataContext : DbContext
    {
        public PrknDataContext() : base("name=PrknDataContext")//AppConfig //WebConfig deki connectionString Name'den gelir.
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PrknDataContext, Configuration>("PrknDataContext"));
            this.Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = false;
            //this.Database.CommandTimeout = 3;
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 3; // seconds
        }

        public DbSet<Users> Users { get; set; }

        public DbSet<Customer_Contact> Customer_Contact { get; set; }
        public DbSet<Customer_Section> Customer_Section { get; set; }
        public DbSet<Customer_Type> Customer_Type { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Keyword> Keyword { get; set; }
        public DbSet<Meeting_Content> Meeting_Content { get; set; }
        public DbSet<Meeting_JoinUser> Meeting_JoinUser { get; set; }
        public DbSet<Meeting_Status> Meeting_Status { get; set; }
        public DbSet<Meeting_Type> Meeting_Type { get; set; }
        public DbSet<Meetings> Meetings { get; set; }
        public DbSet<Project_Detail> Project_Detail { get; set; }
        public DbSet<Project_Rev> Project_Rev { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Store_Address> Store_Address { get; set; }
        public DbSet<Store_AddressCol> Store_AddressCol { get; set; }
        public DbSet<Store_AddressPos> Store_AddressPos { get; set; }
        public DbSet<Store_AddressRow> Store_AddressRow { get; set; }
        public DbSet<Store_AddressZone> Store_AddressZone { get; set; }
        public DbSet<Store_Brand> Store_Brand { get; set; }
        public DbSet<Store_Location> Store_Location { get; set; }
        public DbSet<Store_Logs> Store_Logs { get; set; }
        public DbSet<Store_OutAction> Store_OutAction { get; set; }
        public DbSet<Store_Product> Store_Product { get; set; }
        public DbSet<Store_ProductBlock> Store_ProductBlock { get; set; }
        public DbSet<Store_ProductGroup> Store_ProductGroup { get; set; }
        public DbSet<Store_ProductType> Store_ProductType { get; set; }
        public DbSet<Store_ProductUnit> Store_ProductUnit { get; set; }
        public DbSet<Store_Warehouse> Store_Warehouse { get; set; }
        public DbSet<Store_WarehouseOut> Store_WarehouseOut { get; set; }
        public DbSet<Supplier_Contact> Supplier_Contact { get; set; }
        public DbSet<Supplier_Section> Supplier_Section { get; set; }
        public DbSet<Supplier_Type> Supplier_Type { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Task_Priority> Task_Priority { get; set; }
        public DbSet<Task_Status> Task_Status { get; set; }
        public DbSet<Task_SubjectPrefix> Task_SubjectPrefix { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Title> Title { get; set; }
        public DbSet<User_Access> User_Access { get; set; }
        public DbSet<User_Authorization> User_Authorization { get; set; }
        public DbSet<User_Department> User_Department { get; set; }
        public DbSet<User_Level> User_Level { get; set; }
        public DbSet<User_Logs> User_Logs { get; set; }
        public DbSet<User_Online> User_Online { get; set; }

        public DbSet<Zone> Zone { get; set; }
        public DbSet<User_Screen> User_Screen { get; set; }
        public DbSet<Task_Type> Task_Type { get; set; }
        public DbSet<SoftwareVersion> SoftwareVersion { get; set; }

        public DbSet<Offers> Offers { get; set; }
        public DbSet<Offer_Details> Offer_Details { get; set; }
        public DbSet<Offer_RequestType> Offer_RequestType { get; set; }
        public DbSet<Offer_RequestSource> Offer_RequestSource { get; set; }
        public DbSet<Offer_Status> Offer_Status { get; set; }
        public DbSet<Offer_Type> Offer_Type { get; set; }
        public DbSet<Currency> Currency { get; set; }


        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //    modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        //    modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        //}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();


            modelBuilder.Entity<Customer_Contact>()
            .HasMany(e => e.Project_Rev)
            .WithOptional(e => e.Customer_Contact)
            .HasForeignKey(e => e.CustomerContactId);

            modelBuilder.Entity<Customer_Contact>()
                .HasMany(e => e.Projects)
                .WithOptional(e => e.Customer_Contact)
                .HasForeignKey(e => e.CustomerContactId);

            modelBuilder.Entity<Customer_Section>()
                .HasMany(e => e.Projects)
                .WithOptional(e => e.Customer_Section)
                .HasForeignKey(e => e.CustomerSectionId);

            modelBuilder.Entity<Customer_Type>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.Customer_Type)
                .HasForeignKey(e => e.CustomerTypeId);

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.Customer_Contact)
                .WithOptional(e => e.Customers)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.Customer_Section)
                .WithOptional(e => e.Customers)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.Projects)
                .WithOptional(e => e.Customers)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<Project_Detail>()
                .HasMany(e => e.Projects)
                .WithOptional(e => e.Project_Detail)
                .HasForeignKey(e => e.ProjectDetailId);

            modelBuilder.Entity<Projects>()
                .HasMany(e => e.Project_Rev)
                .WithOptional(e => e.Projects)
                .HasForeignKey(e => e.ProjectId);

            modelBuilder.Entity<Projects>()
                .HasMany(e => e.Tasks)
                .WithOptional(e => e.Projects)
                .HasForeignKey(e => e.ProjectId);

            modelBuilder.Entity<Store_Address>()
                .HasMany(e => e.Store_Product)
                .WithOptional(e => e.Store_Address)
                .HasForeignKey(e => e.AddressId);

            modelBuilder.Entity<Store_AddressCol>()
                .Property(e => e.SysCode)
                .IsFixedLength();

            modelBuilder.Entity<Store_AddressCol>()
                .HasMany(e => e.Store_Address)
                .WithOptional(e => e.Store_AddressCol)
                .HasForeignKey(e => e.ColId);

            modelBuilder.Entity<Store_AddressPos>()
                .Property(e => e.SysCode)
                .IsFixedLength();

            modelBuilder.Entity<Store_AddressPos>()
                .HasMany(e => e.Store_Address)
                .WithOptional(e => e.Store_AddressPos)
                .HasForeignKey(e => e.PosId);

            modelBuilder.Entity<Store_AddressRow>()
                .Property(e => e.SysCode)
                .IsFixedLength();

            modelBuilder.Entity<Store_AddressRow>()
                .HasMany(e => e.Store_Address)
                .WithOptional(e => e.Store_AddressRow)
                .HasForeignKey(e => e.RowId);

            modelBuilder.Entity<Store_AddressZone>()
                .Property(e => e.SysCode)
                .IsFixedLength();

            modelBuilder.Entity<Store_AddressZone>()
                .HasMany(e => e.Store_Address)
                .WithOptional(e => e.Store_AddressZone)
                .HasForeignKey(e => e.ZoneId);

            modelBuilder.Entity<Store_Location>()
                .HasMany(e => e.Store_Product)
                .WithOptional(e => e.Store_Location)
                .HasForeignKey(e => e.LocationId);

            modelBuilder.Entity<Store_Product>()
                .HasMany(e => e.Store_Warehouse)
                .WithOptional(e => e.Store_Product)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<Store_Product>()
                .HasMany(e => e.Store_WarehouseOut)
                .WithOptional(e => e.Store_Product)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<Store_ProductBlock>()
                .HasMany(e => e.Store_Warehouse)
                .WithOptional(e => e.Store_ProductBlock)
                .HasForeignKey(e => e.BlockId);

            modelBuilder.Entity<Store_ProductBlock>()
                .HasMany(e => e.Store_WarehouseOut)
                .WithOptional(e => e.Store_ProductBlock)
                .HasForeignKey(e => e.BlockId);

            modelBuilder.Entity<Store_ProductGroup>()
                .HasMany(e => e.Store_Product)
                .WithOptional(e => e.Store_ProductGroup)
                .HasForeignKey(e => e.GroupId);

            modelBuilder.Entity<Store_ProductType>()
                .Property(e => e.SysCode)
                .IsFixedLength();

            modelBuilder.Entity<Store_ProductType>()
                .HasMany(e => e.Store_Product)
                .WithOptional(e => e.Store_ProductType)
                .HasForeignKey(e => e.TypeId);

            modelBuilder.Entity<Store_ProductUnit>()
                .HasMany(e => e.Store_Product)
                .WithOptional(e => e.Store_ProductUnit)
                .HasForeignKey(e => e.UnitId);

            modelBuilder.Entity<Supplier_Type>()
                .HasMany(e => e.Suppliers)
                .WithOptional(e => e.Supplier_Type)
                .HasForeignKey(e => e.SupplierTypeId);

            modelBuilder.Entity<Suppliers>()
                .HasMany(e => e.Supplier_Contact)
                .WithOptional(e => e.Suppliers)
                .HasForeignKey(e => e.SupplierId);

            modelBuilder.Entity<Suppliers>()
                .HasMany(e => e.Supplier_Section)
                .WithOptional(e => e.Suppliers)
                .HasForeignKey(e => e.SupplierId);

            modelBuilder.Entity<Task_Priority>()
                .HasMany(e => e.Tasks)
                .WithOptional(e => e.Task_Priority)
                .HasForeignKey(e => e.PriorityId);

            modelBuilder.Entity<Task_Status>()
                .HasMany(e => e.Tasks)
                .WithOptional(e => e.Task_Status)
                .HasForeignKey(e => e.StatusId);

            modelBuilder.Entity<Task_SubjectPrefix>()
                .HasMany(e => e.Tasks)
                .WithOptional(e => e.Task_SubjectPrefix)
                .HasForeignKey(e => e.SubjectPrefixId);


            modelBuilder.Entity<Task_Type>()
                .HasMany(e => e.Tasks)
                .WithOptional(e => e.Task_Type)
                .HasForeignKey(e => e.TypeId);

            modelBuilder.Entity<Title>()
                .HasMany(e => e.Users1)
                .WithOptional(e => e.Title1)
                .HasForeignKey(e => e.TitleId);

            modelBuilder.Entity<User_Authorization>()
                .HasMany(e => e.Users2)
                .WithOptional(e => e.User_Authorization2)
                .HasForeignKey(e => e.AutrizationId);

            modelBuilder.Entity<User_Department>()
                .HasMany(e => e.Users1)
                .WithOptional(e => e.User_Department1)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<User_Level>()
                .HasMany(e => e.Users1)
                .WithOptional(e => e.User_Level1)
                .HasForeignKey(e => e.LevelsId);

            modelBuilder.Entity<User_Online>()
                .HasMany(e => e.Users1)
                .WithOptional(e => e.User_Online1)
                .HasForeignKey(e => e.OnlineId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Customer_Contact)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Customer_Type)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);



            modelBuilder.Entity<Users>()
                .HasMany(e => e.Keyword)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Meeting_Content)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Meeting_JoinUser)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Meeting_Status)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Meeting_Type)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Meetings)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Project_Detail)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Project_Rev)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Projects)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Store_Address)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Store_AddressCol)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Store_AddressPos)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Store_AddressRow)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Store_AddressZone)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Store_Brand)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Store_Location)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Store_Logs)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Store_OutAction)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Store_Product)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Store_ProductGroup)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Store_ProductType)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Store_ProductUnit)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Store_Warehouse)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Store_WarehouseOut)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Supplier_Contact)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Supplier_Section)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Supplier_Type)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Suppliers)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Task_Priority)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Task_Status)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Task_SubjectPrefix)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Tasks)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Tasks1)
                .WithOptional(e => e.Users1)
                .HasForeignKey(e => e.AssingedUserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Tasks2)
                .WithOptional(e => e.Users2)
                .HasForeignKey(e => e.ManagerUserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Task_Type)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Title)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.User_Access)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.User_Authorization)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.User_Authorization1)
                .WithOptional(e => e.Users1)
                .HasForeignKey(e => e.SetUserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.User_Department)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.User_Level)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.User_Logs)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.User_Online)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Users1)
                .WithOptional(e => e.Users2)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Zone)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.User_Screen)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Offer_Type)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Offer_Status)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Offer_RequestType)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Offer_RequestSource)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Offer_Details)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.SoftwareVersion)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Currency)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            //###################################//
            //###################################//
            //###################################//

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.Customers)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<Customer_Section>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.Customer_Section)
                .HasForeignKey(e => e.CustomerSectionId);

            modelBuilder.Entity<Customer_Contact>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.Customer_Contact)
                .HasForeignKey(e => e.CustomerContactId);

            modelBuilder.Entity<Offer_Details>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.Offer_Details)
                .HasForeignKey(e => e.OfferDetailsId);

            modelBuilder.Entity<Offer_RequestType>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.Offer_RequestType)
                .HasForeignKey(e => e.OfferRequestTypeId);


            modelBuilder.Entity<Offer_RequestSource>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.Offer_RequestSource)
                .HasForeignKey(e => e.OfferRequestSourceId);

            modelBuilder.Entity<Offer_Status>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.Offer_Status)
                .HasForeignKey(e => e.OfferStatusId);

            modelBuilder.Entity<Offer_Type>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.Offer_Type)
                .HasForeignKey(e => e.OfferTypeId);

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.Currency)
                .HasForeignKey(e => e.CurrencyId);
        }
    }
}
