using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using Emikon.Parkon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Emikon.Parkon.UI.Win.test.DB_EMKPRKNEntitiesDataModel {

    /// <summary>
    /// A DB_EMKPRKNEntitiesUnitOfWork instance that represents the run-time implementation of the IDB_EMKPRKNEntitiesUnitOfWork interface.
    /// </summary>
    public class DB_EMKPRKNEntitiesUnitOfWork : DbUnitOfWork<DB_EMKPRKNEntities>, IDB_EMKPRKNEntitiesUnitOfWork {

        public DB_EMKPRKNEntitiesUnitOfWork(Func<DB_EMKPRKNEntities> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Customer_Contact, long> IDB_EMKPRKNEntitiesUnitOfWork.Customer_Contact {
            get { return GetRepository(x => x.Set<Customer_Contact>(), (Customer_Contact x) => x.Id); }
        }

        IRepository<Customer_Section, long> IDB_EMKPRKNEntitiesUnitOfWork.Customer_Section {
            get { return GetRepository(x => x.Set<Customer_Section>(), (Customer_Section x) => x.Id); }
        }

        IRepository<Customer_Type, long> IDB_EMKPRKNEntitiesUnitOfWork.Customer_Type {
            get { return GetRepository(x => x.Set<Customer_Type>(), (Customer_Type x) => x.Id); }
        }

        IRepository<Customers, long> IDB_EMKPRKNEntitiesUnitOfWork.Customers {
            get { return GetRepository(x => x.Set<Customers>(), (Customers x) => x.Id); }
        }

        IRepository<Keyword, long> IDB_EMKPRKNEntitiesUnitOfWork.Keyword {
            get { return GetRepository(x => x.Set<Keyword>(), (Keyword x) => x.Id); }
        }

        IRepository<Licenses, long> IDB_EMKPRKNEntitiesUnitOfWork.Licenses {
            get { return GetRepository(x => x.Set<Licenses>(), (Licenses x) => x.Id); }
        }

        IRepository<Project_Detail, long> IDB_EMKPRKNEntitiesUnitOfWork.Project_Detail {
            get { return GetRepository(x => x.Set<Project_Detail>(), (Project_Detail x) => x.Id); }
        }

        IRepository<Project_Rev, long> IDB_EMKPRKNEntitiesUnitOfWork.Project_Rev {
            get { return GetRepository(x => x.Set<Project_Rev>(), (Project_Rev x) => x.Id); }
        }

        IRepository<Projects, long> IDB_EMKPRKNEntitiesUnitOfWork.Projects {
            get { return GetRepository(x => x.Set<Projects>(), (Projects x) => x.Id); }
        }

        IRepository<Store_Address, long> IDB_EMKPRKNEntitiesUnitOfWork.Store_Address {
            get { return GetRepository(x => x.Set<Store_Address>(), (Store_Address x) => x.Id); }
        }

        IRepository<Store_AddressCol, long> IDB_EMKPRKNEntitiesUnitOfWork.Store_AddressCol {
            get { return GetRepository(x => x.Set<Store_AddressCol>(), (Store_AddressCol x) => x.Id); }
        }

        IRepository<Store_AddressPos, long> IDB_EMKPRKNEntitiesUnitOfWork.Store_AddressPos {
            get { return GetRepository(x => x.Set<Store_AddressPos>(), (Store_AddressPos x) => x.Id); }
        }

        IRepository<Store_AddressRow, long> IDB_EMKPRKNEntitiesUnitOfWork.Store_AddressRow {
            get { return GetRepository(x => x.Set<Store_AddressRow>(), (Store_AddressRow x) => x.Id); }
        }

        IRepository<Store_AddressZone, long> IDB_EMKPRKNEntitiesUnitOfWork.Store_AddressZone {
            get { return GetRepository(x => x.Set<Store_AddressZone>(), (Store_AddressZone x) => x.Id); }
        }

        IRepository<Store_Brand, long> IDB_EMKPRKNEntitiesUnitOfWork.Store_Brand {
            get { return GetRepository(x => x.Set<Store_Brand>(), (Store_Brand x) => x.Id); }
        }

        IRepository<Store_Location, long> IDB_EMKPRKNEntitiesUnitOfWork.Store_Location {
            get { return GetRepository(x => x.Set<Store_Location>(), (Store_Location x) => x.Id); }
        }

        IRepository<Store_Logs, long> IDB_EMKPRKNEntitiesUnitOfWork.Store_Logs {
            get { return GetRepository(x => x.Set<Store_Logs>(), (Store_Logs x) => x.Id); }
        }

        IRepository<Store_OutAction, long> IDB_EMKPRKNEntitiesUnitOfWork.Store_OutAction {
            get { return GetRepository(x => x.Set<Store_OutAction>(), (Store_OutAction x) => x.Id); }
        }

        IRepository<Store_Product, long> IDB_EMKPRKNEntitiesUnitOfWork.Store_Product {
            get { return GetRepository(x => x.Set<Store_Product>(), (Store_Product x) => x.Id); }
        }

        IRepository<Store_ProductBlock, long> IDB_EMKPRKNEntitiesUnitOfWork.Store_ProductBlock {
            get { return GetRepository(x => x.Set<Store_ProductBlock>(), (Store_ProductBlock x) => x.Id); }
        }

        IRepository<Store_ProductGroup, long> IDB_EMKPRKNEntitiesUnitOfWork.Store_ProductGroup {
            get { return GetRepository(x => x.Set<Store_ProductGroup>(), (Store_ProductGroup x) => x.Id); }
        }

        IRepository<Store_ProductType, long> IDB_EMKPRKNEntitiesUnitOfWork.Store_ProductType {
            get { return GetRepository(x => x.Set<Store_ProductType>(), (Store_ProductType x) => x.Id); }
        }

        IRepository<Store_ProductUnit, long> IDB_EMKPRKNEntitiesUnitOfWork.Store_ProductUnit {
            get { return GetRepository(x => x.Set<Store_ProductUnit>(), (Store_ProductUnit x) => x.Id); }
        }

        IRepository<Store_Warehouse, long> IDB_EMKPRKNEntitiesUnitOfWork.Store_Warehouse {
            get { return GetRepository(x => x.Set<Store_Warehouse>(), (Store_Warehouse x) => x.Id); }
        }

        IRepository<Store_WarehouseOut, long> IDB_EMKPRKNEntitiesUnitOfWork.Store_WarehouseOut {
            get { return GetRepository(x => x.Set<Store_WarehouseOut>(), (Store_WarehouseOut x) => x.Id); }
        }

        IRepository<Supplier_Contact, long> IDB_EMKPRKNEntitiesUnitOfWork.Supplier_Contact {
            get { return GetRepository(x => x.Set<Supplier_Contact>(), (Supplier_Contact x) => x.Id); }
        }

        IRepository<Supplier_Section, long> IDB_EMKPRKNEntitiesUnitOfWork.Supplier_Section {
            get { return GetRepository(x => x.Set<Supplier_Section>(), (Supplier_Section x) => x.Id); }
        }

        IRepository<Supplier_Type, long> IDB_EMKPRKNEntitiesUnitOfWork.Supplier_Type {
            get { return GetRepository(x => x.Set<Supplier_Type>(), (Supplier_Type x) => x.Id); }
        }

        IRepository<Suppliers, long> IDB_EMKPRKNEntitiesUnitOfWork.Suppliers {
            get { return GetRepository(x => x.Set<Suppliers>(), (Suppliers x) => x.Id); }
        }

        IRepository<Model.test, long> IDB_EMKPRKNEntitiesUnitOfWork.test {
            get { return GetRepository(x => x.Set<Model.test>(), (Model.test x) => x.Id); }
        }

        IRepository<Title, long> IDB_EMKPRKNEntitiesUnitOfWork.Title {
            get { return GetRepository(x => x.Set<Title>(), (Title x) => x.Id); }
        }

        IRepository<User_Access, long> IDB_EMKPRKNEntitiesUnitOfWork.User_Access {
            get { return GetRepository(x => x.Set<User_Access>(), (User_Access x) => x.Id); }
        }

        IRepository<User_Authorization, long> IDB_EMKPRKNEntitiesUnitOfWork.User_Authorization {
            get { return GetRepository(x => x.Set<User_Authorization>(), (User_Authorization x) => x.Id); }
        }

        IRepository<User_Department, long> IDB_EMKPRKNEntitiesUnitOfWork.User_Department {
            get { return GetRepository(x => x.Set<User_Department>(), (User_Department x) => x.Id); }
        }

        IRepository<User_Level, long> IDB_EMKPRKNEntitiesUnitOfWork.User_Level {
            get { return GetRepository(x => x.Set<User_Level>(), (User_Level x) => x.Id); }
        }

        IRepository<User_Logs, long> IDB_EMKPRKNEntitiesUnitOfWork.User_Logs {
            get { return GetRepository(x => x.Set<User_Logs>(), (User_Logs x) => x.Id); }
        }

        IRepository<User_Online, long> IDB_EMKPRKNEntitiesUnitOfWork.User_Online {
            get { return GetRepository(x => x.Set<User_Online>(), (User_Online x) => x.Id); }
        }

        IRepository<Users, long> IDB_EMKPRKNEntitiesUnitOfWork.Users {
            get { return GetRepository(x => x.Set<Users>(), (Users x) => x.Id); }
        }

        IRepository<Zone, long> IDB_EMKPRKNEntitiesUnitOfWork.Zone {
            get { return GetRepository(x => x.Set<Zone>(), (Zone x) => x.Id); }
        }
    }
}
