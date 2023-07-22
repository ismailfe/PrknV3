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
    /// Represents the single Store_ProductUnit object view model.
    /// </summary>
    public partial class Store_ProductUnitViewModel : SingleObjectViewModel<Store_ProductUnit, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Store_ProductUnitViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Store_ProductUnitViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Store_ProductUnitViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Store_ProductUnitViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Store_ProductUnitViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Store_ProductUnitViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Store_ProductUnit, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Store_Product for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_Product> LookUpStore_Product {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_ProductUnitViewModel x) => x.LookUpStore_Product,
                    getRepositoryFunc: x => x.Store_Product);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_ProductUnitViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }


        /// <summary>
        /// The view model for the Store_ProductUnitStore_Product detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_Product, Store_Product, long, IDB_EMKPRKNEntitiesUnitOfWork> Store_ProductUnitStore_ProductDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Store_ProductUnitViewModel x) => x.Store_ProductUnitStore_ProductDetails,
                    getRepositoryFunc: x => x.Store_Product,
                    foreignKeyExpression: x => x.UnitId,
                    navigationExpression: x => x.Store_ProductUnit);
            }
        }
    }
}
