using DevExpress.Mvvm.DataModel;
using Emikon.Parkon.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Emikon.Parkon.UI.Win.test.DB_EMKPRKNEntitiesDataModel {

    /// <summary>
    /// IDB_EMKPRKNEntitiesUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IDB_EMKPRKNEntitiesUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Customer_Contact entities repository.
        /// </summary>
		IRepository<Customer_Contact, long> Customer_Contact { get; }
        
        /// <summary>
        /// The Customer_Section entities repository.
        /// </summary>
		IRepository<Customer_Section, long> Customer_Section { get; }
        
        /// <summary>
        /// The Customer_Type entities repository.
        /// </summary>
		IRepository<Customer_Type, long> Customer_Type { get; }
        
        /// <summary>
        /// The Customers entities repository.
        /// </summary>
		IRepository<Customers, long> Customers { get; }
        
        /// <summary>
        /// The Keyword entities repository.
        /// </summary>
		IRepository<Keyword, long> Keyword { get; }
        
        /// <summary>
        /// The Licenses entities repository.
        /// </summary>
		IRepository<Licenses, long> Licenses { get; }
        
        /// <summary>
        /// The Project_Detail entities repository.
        /// </summary>
		IRepository<Project_Detail, long> Project_Detail { get; }
        
        /// <summary>
        /// The Project_Rev entities repository.
        /// </summary>
		IRepository<Project_Rev, long> Project_Rev { get; }
        
        /// <summary>
        /// The Projects entities repository.
        /// </summary>
		IRepository<Projects, long> Projects { get; }
        
        /// <summary>
        /// The Store_Address entities repository.
        /// </summary>
		IRepository<Store_Address, long> Store_Address { get; }
        
        /// <summary>
        /// The Store_AddressCol entities repository.
        /// </summary>
		IRepository<Store_AddressCol, long> Store_AddressCol { get; }
        
        /// <summary>
        /// The Store_AddressPos entities repository.
        /// </summary>
		IRepository<Store_AddressPos, long> Store_AddressPos { get; }
        
        /// <summary>
        /// The Store_AddressRow entities repository.
        /// </summary>
		IRepository<Store_AddressRow, long> Store_AddressRow { get; }
        
        /// <summary>
        /// The Store_AddressZone entities repository.
        /// </summary>
		IRepository<Store_AddressZone, long> Store_AddressZone { get; }
        
        /// <summary>
        /// The Store_Brand entities repository.
        /// </summary>
		IRepository<Store_Brand, long> Store_Brand { get; }
        
        /// <summary>
        /// The Store_Location entities repository.
        /// </summary>
		IRepository<Store_Location, long> Store_Location { get; }
        
        /// <summary>
        /// The Store_Logs entities repository.
        /// </summary>
		IRepository<Store_Logs, long> Store_Logs { get; }
        
        /// <summary>
        /// The Store_OutAction entities repository.
        /// </summary>
		IRepository<Store_OutAction, long> Store_OutAction { get; }
        
        /// <summary>
        /// The Store_Product entities repository.
        /// </summary>
		IRepository<Store_Product, long> Store_Product { get; }
        
        /// <summary>
        /// The Store_ProductBlock entities repository.
        /// </summary>
		IRepository<Store_ProductBlock, long> Store_ProductBlock { get; }
        
        /// <summary>
        /// The Store_ProductGroup entities repository.
        /// </summary>
		IRepository<Store_ProductGroup, long> Store_ProductGroup { get; }
        
        /// <summary>
        /// The Store_ProductType entities repository.
        /// </summary>
		IRepository<Store_ProductType, long> Store_ProductType { get; }
        
        /// <summary>
        /// The Store_ProductUnit entities repository.
        /// </summary>
		IRepository<Store_ProductUnit, long> Store_ProductUnit { get; }
        
        /// <summary>
        /// The Store_Warehouse entities repository.
        /// </summary>
		IRepository<Store_Warehouse, long> Store_Warehouse { get; }
        
        /// <summary>
        /// The Store_WarehouseOut entities repository.
        /// </summary>
		IRepository<Store_WarehouseOut, long> Store_WarehouseOut { get; }
        
        /// <summary>
        /// The Supplier_Contact entities repository.
        /// </summary>
		IRepository<Supplier_Contact, long> Supplier_Contact { get; }
        
        /// <summary>
        /// The Supplier_Section entities repository.
        /// </summary>
		IRepository<Supplier_Section, long> Supplier_Section { get; }
        
        /// <summary>
        /// The Supplier_Type entities repository.
        /// </summary>
		IRepository<Supplier_Type, long> Supplier_Type { get; }
        
        /// <summary>
        /// The Suppliers entities repository.
        /// </summary>
		IRepository<Suppliers, long> Suppliers { get; }
        
        /// <summary>
        /// The test entities repository.
        /// </summary>
		IRepository<Model.test, long> test { get; }
        
        /// <summary>
        /// The Title entities repository.
        /// </summary>
		IRepository<Title, long> Title { get; }
        
        /// <summary>
        /// The User_Access entities repository.
        /// </summary>
		IRepository<User_Access, long> User_Access { get; }
        
        /// <summary>
        /// The User_Authorization entities repository.
        /// </summary>
		IRepository<User_Authorization, long> User_Authorization { get; }
        
        /// <summary>
        /// The User_Department entities repository.
        /// </summary>
		IRepository<User_Department, long> User_Department { get; }
        
        /// <summary>
        /// The User_Level entities repository.
        /// </summary>
		IRepository<User_Level, long> User_Level { get; }
        
        /// <summary>
        /// The User_Logs entities repository.
        /// </summary>
		IRepository<User_Logs, long> User_Logs { get; }
        
        /// <summary>
        /// The User_Online entities repository.
        /// </summary>
		IRepository<User_Online, long> User_Online { get; }
        
        /// <summary>
        /// The Users entities repository.
        /// </summary>
		IRepository<Users, long> Users { get; }
        
        /// <summary>
        /// The Zone entities repository.
        /// </summary>
		IRepository<Zone, long> Zone { get; }
    }
}
