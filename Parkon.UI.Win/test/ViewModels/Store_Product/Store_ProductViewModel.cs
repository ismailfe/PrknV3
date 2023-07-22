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
    /// Represents the single Store_Product object view model.
    /// </summary>
    public partial class Store_ProductViewModel : SingleObjectViewModel<Store_Product, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Store_ProductViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Store_ProductViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Store_ProductViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Store_ProductViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Store_ProductViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Store_ProductViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Store_Product, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Store_Address for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_Address> LookUpStore_Address {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_ProductViewModel x) => x.LookUpStore_Address,
                    getRepositoryFunc: x => x.Store_Address);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_Location for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_Location> LookUpStore_Location {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_ProductViewModel x) => x.LookUpStore_Location,
                    getRepositoryFunc: x => x.Store_Location);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_ProductGroup for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_ProductGroup> LookUpStore_ProductGroup {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_ProductViewModel x) => x.LookUpStore_ProductGroup,
                    getRepositoryFunc: x => x.Store_ProductGroup);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_ProductType for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_ProductType> LookUpStore_ProductType {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_ProductViewModel x) => x.LookUpStore_ProductType,
                    getRepositoryFunc: x => x.Store_ProductType);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_ProductUnit for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_ProductUnit> LookUpStore_ProductUnit {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_ProductViewModel x) => x.LookUpStore_ProductUnit,
                    getRepositoryFunc: x => x.Store_ProductUnit);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_ProductViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_Warehouse for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_Warehouse> LookUpStore_Warehouse {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_ProductViewModel x) => x.LookUpStore_Warehouse,
                    getRepositoryFunc: x => x.Store_Warehouse);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_WarehouseOut for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_WarehouseOut> LookUpStore_WarehouseOut {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_ProductViewModel x) => x.LookUpStore_WarehouseOut,
                    getRepositoryFunc: x => x.Store_WarehouseOut);
            }
        }


        /// <summary>
        /// The view model for the Store_ProductStore_Warehouse detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_Warehouse, Store_Warehouse, long, IDB_EMKPRKNEntitiesUnitOfWork> Store_ProductStore_WarehouseDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Store_ProductViewModel x) => x.Store_ProductStore_WarehouseDetails,
                    getRepositoryFunc: x => x.Store_Warehouse,
                    foreignKeyExpression: x => x.ProductId,
                    navigationExpression: x => x.Store_Product);
            }
        }

        /// <summary>
        /// The view model for the Store_ProductStore_WarehouseOut detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_WarehouseOut, Store_WarehouseOut, long, IDB_EMKPRKNEntitiesUnitOfWork> Store_ProductStore_WarehouseOutDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Store_ProductViewModel x) => x.Store_ProductStore_WarehouseOutDetails,
                    getRepositoryFunc: x => x.Store_WarehouseOut,
                    foreignKeyExpression: x => x.ProductId,
                    navigationExpression: x => x.Store_Product);
            }
        }
    }
}
