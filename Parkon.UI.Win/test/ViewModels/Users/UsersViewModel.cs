using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using Emikon.Parkon.UI.Win.test.DB_EMKPRKNEntitiesDataModel;
using Emikon.Parkon.UI.Win.test.Common;
using Emikon.Parkon.Model;

namespace Emikon.Parkon.UI.Win.test.ViewModels {

    /// <summary>
    /// Represents the single Users object view model.
    /// </summary>
    public partial class UsersViewModel : SingleObjectViewModel<Users, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of UsersViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static UsersViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new UsersViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the UsersViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the UsersViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected UsersViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Users, x => x.NameFirst) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Customer_Contact for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer_Contact> LookUpCustomer_Contact {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpCustomer_Contact,
                    getRepositoryFunc: x => x.Customer_Contact);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Customer_Type for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer_Type> LookUpCustomer_Type {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpCustomer_Type,
                    getRepositoryFunc: x => x.Customer_Type);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customers> LookUpCustomers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpCustomers,
                    getRepositoryFunc: x => x.Customers);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Keyword for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Keyword> LookUpKeyword {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpKeyword,
                    getRepositoryFunc: x => x.Keyword);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Licenses for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Licenses> LookUpLicenses {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpLicenses,
                    getRepositoryFunc: x => x.Licenses);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Project_Detail for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Project_Detail> LookUpProject_Detail {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpProject_Detail,
                    getRepositoryFunc: x => x.Project_Detail);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Project_Rev for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Project_Rev> LookUpProject_Rev {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpProject_Rev,
                    getRepositoryFunc: x => x.Project_Rev);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Projects for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Projects> LookUpProjects {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpProjects,
                    getRepositoryFunc: x => x.Projects);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_Address for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_Address> LookUpStore_Address {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpStore_Address,
                    getRepositoryFunc: x => x.Store_Address);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_AddressCol for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_AddressCol> LookUpStore_AddressCol {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpStore_AddressCol,
                    getRepositoryFunc: x => x.Store_AddressCol);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_AddressPos for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_AddressPos> LookUpStore_AddressPos {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpStore_AddressPos,
                    getRepositoryFunc: x => x.Store_AddressPos);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_AddressRow for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_AddressRow> LookUpStore_AddressRow {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpStore_AddressRow,
                    getRepositoryFunc: x => x.Store_AddressRow);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_AddressZone for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_AddressZone> LookUpStore_AddressZone {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpStore_AddressZone,
                    getRepositoryFunc: x => x.Store_AddressZone);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_Brand for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_Brand> LookUpStore_Brand {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpStore_Brand,
                    getRepositoryFunc: x => x.Store_Brand);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_Location for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_Location> LookUpStore_Location {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpStore_Location,
                    getRepositoryFunc: x => x.Store_Location);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_Logs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_Logs> LookUpStore_Logs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpStore_Logs,
                    getRepositoryFunc: x => x.Store_Logs);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_OutAction for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_OutAction> LookUpStore_OutAction {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpStore_OutAction,
                    getRepositoryFunc: x => x.Store_OutAction);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_Product for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_Product> LookUpStore_Product {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpStore_Product,
                    getRepositoryFunc: x => x.Store_Product);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_ProductGroup for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_ProductGroup> LookUpStore_ProductGroup {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpStore_ProductGroup,
                    getRepositoryFunc: x => x.Store_ProductGroup);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_ProductType for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_ProductType> LookUpStore_ProductType {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpStore_ProductType,
                    getRepositoryFunc: x => x.Store_ProductType);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_ProductUnit for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_ProductUnit> LookUpStore_ProductUnit {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpStore_ProductUnit,
                    getRepositoryFunc: x => x.Store_ProductUnit);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_Warehouse for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_Warehouse> LookUpStore_Warehouse {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpStore_Warehouse,
                    getRepositoryFunc: x => x.Store_Warehouse);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_WarehouseOut for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_WarehouseOut> LookUpStore_WarehouseOut {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpStore_WarehouseOut,
                    getRepositoryFunc: x => x.Store_WarehouseOut);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Supplier_Contact for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Supplier_Contact> LookUpSupplier_Contact {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpSupplier_Contact,
                    getRepositoryFunc: x => x.Supplier_Contact);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Supplier_Section for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Supplier_Section> LookUpSupplier_Section {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpSupplier_Section,
                    getRepositoryFunc: x => x.Supplier_Section);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Supplier_Type for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Supplier_Type> LookUpSupplier_Type {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpSupplier_Type,
                    getRepositoryFunc: x => x.Supplier_Type);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Suppliers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Suppliers> LookUpSuppliers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpSuppliers,
                    getRepositoryFunc: x => x.Suppliers);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Title for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Title> LookUpTitle {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpTitle,
                    getRepositoryFunc: x => x.Title);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of User_Access for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User_Access> LookUpUser_Access {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpUser_Access,
                    getRepositoryFunc: x => x.User_Access);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of User_Authorization for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User_Authorization> LookUpUser_Authorization {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpUser_Authorization,
                    getRepositoryFunc: x => x.User_Authorization);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of User_Department for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User_Department> LookUpUser_Department {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpUser_Department,
                    getRepositoryFunc: x => x.User_Department);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of User_Level for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User_Level> LookUpUser_Level {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpUser_Level,
                    getRepositoryFunc: x => x.User_Level);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of User_Logs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User_Logs> LookUpUser_Logs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpUser_Logs,
                    getRepositoryFunc: x => x.User_Logs);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of User_Online for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User_Online> LookUpUser_Online {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpUser_Online,
                    getRepositoryFunc: x => x.User_Online);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Zone for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Zone> LookUpZone {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UsersViewModel x) => x.LookUpZone,
                    getRepositoryFunc: x => x.Zone);
            }
        }


        /// <summary>
        /// The view model for the UsersCustomer_Contact detail collection.
        /// </summary>
        public CollectionViewModelBase<Customer_Contact, Customer_Contact, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersCustomer_ContactDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersCustomer_ContactDetails,
                    getRepositoryFunc: x => x.Customer_Contact,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersCustomer_Type detail collection.
        /// </summary>
        public CollectionViewModelBase<Customer_Type, Customer_Type, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersCustomer_TypeDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersCustomer_TypeDetails,
                    getRepositoryFunc: x => x.Customer_Type,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersCustomers detail collection.
        /// </summary>
        public CollectionViewModelBase<Customers, Customers, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersCustomersDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersCustomersDetails,
                    getRepositoryFunc: x => x.Customers,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersKeyword detail collection.
        /// </summary>
        public CollectionViewModelBase<Keyword, Keyword, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersKeywordDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersKeywordDetails,
                    getRepositoryFunc: x => x.Keyword,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersLicenses detail collection.
        /// </summary>
        public CollectionViewModelBase<Licenses, Licenses, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersLicensesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersLicensesDetails,
                    getRepositoryFunc: x => x.Licenses,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersProject_Detail detail collection.
        /// </summary>
        public CollectionViewModelBase<Project_Detail, Project_Detail, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersProject_DetailDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersProject_DetailDetails,
                    getRepositoryFunc: x => x.Project_Detail,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersProject_Rev detail collection.
        /// </summary>
        public CollectionViewModelBase<Project_Rev, Project_Rev, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersProject_RevDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersProject_RevDetails,
                    getRepositoryFunc: x => x.Project_Rev,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersProjects detail collection.
        /// </summary>
        public CollectionViewModelBase<Projects, Projects, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersProjectsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersProjectsDetails,
                    getRepositoryFunc: x => x.Projects,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersStore_Address detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_Address, Store_Address, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersStore_AddressDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersStore_AddressDetails,
                    getRepositoryFunc: x => x.Store_Address,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersStore_AddressCol detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_AddressCol, Store_AddressCol, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersStore_AddressColDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersStore_AddressColDetails,
                    getRepositoryFunc: x => x.Store_AddressCol,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersStore_AddressPos detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_AddressPos, Store_AddressPos, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersStore_AddressPosDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersStore_AddressPosDetails,
                    getRepositoryFunc: x => x.Store_AddressPos,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersStore_AddressRow detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_AddressRow, Store_AddressRow, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersStore_AddressRowDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersStore_AddressRowDetails,
                    getRepositoryFunc: x => x.Store_AddressRow,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersStore_AddressZone detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_AddressZone, Store_AddressZone, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersStore_AddressZoneDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersStore_AddressZoneDetails,
                    getRepositoryFunc: x => x.Store_AddressZone,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersStore_Brand detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_Brand, Store_Brand, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersStore_BrandDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersStore_BrandDetails,
                    getRepositoryFunc: x => x.Store_Brand,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersStore_Location detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_Location, Store_Location, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersStore_LocationDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersStore_LocationDetails,
                    getRepositoryFunc: x => x.Store_Location,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersStore_Logs detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_Logs, Store_Logs, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersStore_LogsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersStore_LogsDetails,
                    getRepositoryFunc: x => x.Store_Logs,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersStore_OutAction detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_OutAction, Store_OutAction, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersStore_OutActionDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersStore_OutActionDetails,
                    getRepositoryFunc: x => x.Store_OutAction,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersStore_Product detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_Product, Store_Product, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersStore_ProductDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersStore_ProductDetails,
                    getRepositoryFunc: x => x.Store_Product,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersStore_ProductGroup detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_ProductGroup, Store_ProductGroup, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersStore_ProductGroupDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersStore_ProductGroupDetails,
                    getRepositoryFunc: x => x.Store_ProductGroup,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersStore_ProductType detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_ProductType, Store_ProductType, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersStore_ProductTypeDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersStore_ProductTypeDetails,
                    getRepositoryFunc: x => x.Store_ProductType,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersStore_ProductUnit detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_ProductUnit, Store_ProductUnit, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersStore_ProductUnitDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersStore_ProductUnitDetails,
                    getRepositoryFunc: x => x.Store_ProductUnit,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersStore_Warehouse detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_Warehouse, Store_Warehouse, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersStore_WarehouseDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersStore_WarehouseDetails,
                    getRepositoryFunc: x => x.Store_Warehouse,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersStore_WarehouseOut detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_WarehouseOut, Store_WarehouseOut, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersStore_WarehouseOutDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersStore_WarehouseOutDetails,
                    getRepositoryFunc: x => x.Store_WarehouseOut,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersSupplier_Contact detail collection.
        /// </summary>
        public CollectionViewModelBase<Supplier_Contact, Supplier_Contact, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersSupplier_ContactDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersSupplier_ContactDetails,
                    getRepositoryFunc: x => x.Supplier_Contact,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersSupplier_Section detail collection.
        /// </summary>
        public CollectionViewModelBase<Supplier_Section, Supplier_Section, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersSupplier_SectionDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersSupplier_SectionDetails,
                    getRepositoryFunc: x => x.Supplier_Section,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersSupplier_Type detail collection.
        /// </summary>
        public CollectionViewModelBase<Supplier_Type, Supplier_Type, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersSupplier_TypeDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersSupplier_TypeDetails,
                    getRepositoryFunc: x => x.Supplier_Type,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersSuppliers detail collection.
        /// </summary>
        public CollectionViewModelBase<Suppliers, Suppliers, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersSuppliersDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersSuppliersDetails,
                    getRepositoryFunc: x => x.Suppliers,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersTitle detail collection.
        /// </summary>
        public CollectionViewModelBase<Title, Title, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersTitleDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersTitleDetails,
                    getRepositoryFunc: x => x.Title,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersUser_Access detail collection.
        /// </summary>
        public CollectionViewModelBase<User_Access, User_Access, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersUser_AccessDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersUser_AccessDetails,
                    getRepositoryFunc: x => x.User_Access,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersUser_Access1 detail collection.
        /// </summary>
        public CollectionViewModelBase<User_Access, User_Access, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersUser_Access1Details {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersUser_Access1Details,
                    getRepositoryFunc: x => x.User_Access,
                    foreignKeyExpression: x => x.SetUserId,
                    navigationExpression: x => x.Users1);
            }
        }

        /// <summary>
        /// The view model for the UsersUser_Authorization detail collection.
        /// </summary>
        public CollectionViewModelBase<User_Authorization, User_Authorization, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersUser_AuthorizationDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersUser_AuthorizationDetails,
                    getRepositoryFunc: x => x.User_Authorization,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersUser_Authorization1 detail collection.
        /// </summary>
        public CollectionViewModelBase<User_Authorization, User_Authorization, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersUser_Authorization1Details {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersUser_Authorization1Details,
                    getRepositoryFunc: x => x.User_Authorization,
                    foreignKeyExpression: x => x.SetUserId,
                    navigationExpression: x => x.Users1);
            }
        }

        /// <summary>
        /// The view model for the UsersUser_Department detail collection.
        /// </summary>
        public CollectionViewModelBase<User_Department, User_Department, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersUser_DepartmentDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersUser_DepartmentDetails,
                    getRepositoryFunc: x => x.User_Department,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersUser_Level detail collection.
        /// </summary>
        public CollectionViewModelBase<User_Level, User_Level, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersUser_LevelDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersUser_LevelDetails,
                    getRepositoryFunc: x => x.User_Level,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersUser_Logs detail collection.
        /// </summary>
        public CollectionViewModelBase<User_Logs, User_Logs, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersUser_LogsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersUser_LogsDetails,
                    getRepositoryFunc: x => x.User_Logs,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersUser_Online detail collection.
        /// </summary>
        public CollectionViewModelBase<User_Online, User_Online, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersUser_OnlineDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersUser_OnlineDetails,
                    getRepositoryFunc: x => x.User_Online,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }

        /// <summary>
        /// The view model for the UsersUsers1 detail collection.
        /// </summary>
        public CollectionViewModelBase<Users, Users, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersUsers1Details {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersUsers1Details,
                    getRepositoryFunc: x => x.Users,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users2);
            }
        }

        /// <summary>
        /// The view model for the UsersZone detail collection.
        /// </summary>
        public CollectionViewModelBase<Zone, Zone, long, IDB_EMKPRKNEntitiesUnitOfWork> UsersZoneDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UsersViewModel x) => x.UsersZoneDetails,
                    getRepositoryFunc: x => x.Zone,
                    foreignKeyExpression: x => x.UserId,
                    navigationExpression: x => x.Users);
            }
        }
    }
}
