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
    /// Represents the single Store_AddressRow object view model.
    /// </summary>
    public partial class Store_AddressRowViewModel : SingleObjectViewModel<Store_AddressRow, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Store_AddressRowViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Store_AddressRowViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Store_AddressRowViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Store_AddressRowViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Store_AddressRowViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Store_AddressRowViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Store_AddressRow, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Store_Address for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_Address> LookUpStore_Address {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_AddressRowViewModel x) => x.LookUpStore_Address,
                    getRepositoryFunc: x => x.Store_Address);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_AddressRowViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }


        /// <summary>
        /// The view model for the Store_AddressRowStore_Address detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_Address, Store_Address, long, IDB_EMKPRKNEntitiesUnitOfWork> Store_AddressRowStore_AddressDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Store_AddressRowViewModel x) => x.Store_AddressRowStore_AddressDetails,
                    getRepositoryFunc: x => x.Store_Address,
                    foreignKeyExpression: x => x.RowId,
                    navigationExpression: x => x.Store_AddressRow);
            }
        }
    }
}
