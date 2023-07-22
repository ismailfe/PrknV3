using Prkn.Data.Local.Migrations;
using Prkn.Model.Mirror;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.Data.Local
{
    public class MirrorDataContext : DbContext
    {
        public MirrorDataContext() : base("name=MirrorDataContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MirrorDataContext, MirrorDataConfig>("MirrorDataContext"));
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Customer_Contact> Customer_Contact { get; set; }
        public virtual DbSet<Customer_Section> Customer_Section { get; set; }
        public virtual DbSet<Customer_Type> Customer_Type { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Keyword> Keyword { get; set; }
        public virtual DbSet<Meeting_Content> Meeting_Content { get; set; }
        public virtual DbSet<Meeting_JoinUser> Meeting_JoinUser { get; set; }
        public virtual DbSet<Meeting_Status> Meeting_Status { get; set; }
        public virtual DbSet<Meeting_Type> Meeting_Type { get; set; }
        public virtual DbSet<Meetings> Meetings { get; set; }
        public virtual DbSet<Project_Detail> Project_Detail { get; set; }
        public virtual DbSet<Project_Rev> Project_Rev { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<Store_Address> Store_Address { get; set; }
        public virtual DbSet<Store_AddressCol> Store_AddressCol { get; set; }
        public virtual DbSet<Store_AddressPos> Store_AddressPos { get; set; }
        public virtual DbSet<Store_AddressRow> Store_AddressRow { get; set; }
        public virtual DbSet<Store_AddressZone> Store_AddressZone { get; set; }
        public virtual DbSet<Store_Brand> Store_Brand { get; set; }
        public virtual DbSet<Store_Location> Store_Location { get; set; }
        public virtual DbSet<Store_Logs> Store_Logs { get; set; }
        public virtual DbSet<Store_OutAction> Store_OutAction { get; set; }
        public virtual DbSet<Store_Product> Store_Product { get; set; }
        public virtual DbSet<Store_ProductBlock> Store_ProductBlock { get; set; }
        public virtual DbSet<Store_ProductGroup> Store_ProductGroup { get; set; }
        public virtual DbSet<Store_ProductType> Store_ProductType { get; set; }
        public virtual DbSet<Store_ProductUnit> Store_ProductUnit { get; set; }
        public virtual DbSet<Store_Warehouse> Store_Warehouse { get; set; }
        public virtual DbSet<Store_WarehouseOut> Store_WarehouseOut { get; set; }
        public virtual DbSet<Supplier_Contact> Supplier_Contact { get; set; }
        public virtual DbSet<Supplier_Section> Supplier_Section { get; set; }
        public virtual DbSet<Supplier_Type> Supplier_Type { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<Task_Priority> Task_Priority { get; set; }
        public virtual DbSet<Task_Status> Task_Status { get; set; }
        public virtual DbSet<Task_SubjectPrefix> Task_SubjectPrefix { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<Title> Title { get; set; }
        public virtual DbSet<User_Access> User_Access { get; set; }
        public virtual DbSet<User_Authorization> User_Authorization { get; set; }
        public virtual DbSet<User_Department> User_Department { get; set; }
        public virtual DbSet<User_Level> User_Level { get; set; }
        public virtual DbSet<User_Logs> User_Logs { get; set; }
        public virtual DbSet<User_Online> User_Online { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Zone> Zone { get; set; }
        public virtual DbSet<User_Screen> User_Screen { get; set; }
        public virtual DbSet<Task_Type> Task_Type { get; set; }
        public virtual DbSet<SoftwareVersion> SoftwareVersion { get; set; }
               
        public virtual DbSet<Offers> Offers { get; set; }
        public virtual DbSet<Offer_Details> Offer_Details { get; set; }
        public virtual DbSet<Offer_RequestType> Offer_RequestType { get; set; }
        public virtual DbSet<Offer_RequestSource> Offer_RequestSource { get; set; }
        public virtual DbSet<Offer_Status> Offer_Status { get; set; }
        public virtual DbSet<Offer_Type> Offer_Type { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }


    }
}
