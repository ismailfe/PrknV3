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
    /// Represents the single Store_ProductBlock object view model.
    /// </summary>
    public partial class Store_ProductBlockViewModel : SingleObjectViewModel<Store_ProductBlock, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Store_ProductBlockViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Store_ProductBlockViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Store_ProductBlockViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Store_ProductBlockViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Store_ProductBlockViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Store_ProductBlockViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Store_ProductBlock, x => x.SysCode) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Store_Warehouse for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_Warehouse> LookUpStore_Warehouse {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_ProductBlockViewModel x) => x.LookUpStore_Warehouse,
                    getRepositoryFunc: x => x.Store_Warehouse);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_WarehouseOut for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_WarehouseOut> LookUpStore_WarehouseOut {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_ProductBlockViewModel x) => x.LookUpStore_WarehouseOut,
                    getRepositoryFunc: x => x.Store_WarehouseOut);
            }
        }


        /// <summary>
        /// The view model for the Store_ProductBlockStore_Warehouse detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_Warehouse, Store_Warehouse, long, IDB_EMKPRKNEntitiesUnitOfWork> Store_ProductBlockStore_WarehouseDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Store_ProductBlockViewModel x) => x.Store_ProductBlockStore_WarehouseDetails,
                    getRepositoryFunc: x => x.Store_Warehouse,
                    foreignKeyExpression: x => x.BlockId,
                    navigationExpression: x => x.Store_ProductBlock);
            }
        }

        /// <summary>
        /// The view model for the Store_ProductBlockStore_WarehouseOut detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_WarehouseOut, Store_WarehouseOut, long, IDB_EMKPRKNEntitiesUnitOfWork> Store_ProductBlockStore_WarehouseOutDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Store_ProductBlockViewModel x) => x.Store_ProductBlockStore_WarehouseOutDetails,
                    getRepositoryFunc: x => x.Store_WarehouseOut,
                    foreignKeyExpression: x => x.BlockId,
                    navigationExpression: x => x.Store_ProductBlock);
            }
        }
    }
}
