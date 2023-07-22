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
    /// Represents the single Store_Location object view model.
    /// </summary>
    public partial class Store_LocationViewModel : SingleObjectViewModel<Store_Location, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Store_LocationViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Store_LocationViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Store_LocationViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Store_LocationViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Store_LocationViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Store_LocationViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Store_Location, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_LocationViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Store_Product for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_Product> LookUpStore_Product {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_LocationViewModel x) => x.LookUpStore_Product,
                    getRepositoryFunc: x => x.Store_Product);
            }
        }


        /// <summary>
        /// The view model for the Store_LocationStore_Product detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_Product, Store_Product, long, IDB_EMKPRKNEntitiesUnitOfWork> Store_LocationStore_ProductDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Store_LocationViewModel x) => x.Store_LocationStore_ProductDetails,
                    getRepositoryFunc: x => x.Store_Product,
                    foreignKeyExpression: x => x.LocationId,
                    navigationExpression: x => x.Store_Location);
            }
        }
    }
}
