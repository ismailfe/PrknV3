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
    /// Represents the single Store_Address object view model.
    /// </summary>
    public partial class Store_AddressViewModel : SingleObjectViewModel<Store_Address, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Store_AddressViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Store_AddressViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Store_AddressViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Store_AddressViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Store_AddressViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Store_AddressViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Store_Address, x => x.SysCode) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Store_AddressCol for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_AddressCol> LookUpStore_AddressCol {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_AddressViewModel x) => x.LookUpStore_AddressCol,
                    getRepositoryFunc: x => x.Store_AddressCol);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_AddressPos for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_AddressPos> LookUpStore_AddressPos {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_AddressViewModel x) => x.LookUpStore_AddressPos,
                    getRepositoryFunc: x => x.Store_AddressPos);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_AddressRow for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_AddressRow> LookUpStore_AddressRow {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_AddressViewModel x) => x.LookUpStore_AddressRow,
                    getRepositoryFunc: x => x.Store_AddressRow);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_AddressZone for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_AddressZone> LookUpStore_AddressZone {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_AddressViewModel x) => x.LookUpStore_AddressZone,
                    getRepositoryFunc: x => x.Store_AddressZone);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_AddressViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_Product for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_Product> LookUpStore_Product {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_AddressViewModel x) => x.LookUpStore_Product,
                    getRepositoryFunc: x => x.Store_Product);
            }
        }


        /// <summary>
        /// The view model for the Store_AddressStore_Product detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_Product, Store_Product, long, IDB_EMKPRKNEntitiesUnitOfWork> Store_AddressStore_ProductDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Store_AddressViewModel x) => x.Store_AddressStore_ProductDetails,
                    getRepositoryFunc: x => x.Store_Product,
                    foreignKeyExpression: x => x.AddressId,
                    navigationExpression: x => x.Store_Address);
            }
        }
    }
}
