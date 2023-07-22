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
    /// Represents the single Supplier_Type object view model.
    /// </summary>
    public partial class Supplier_TypeViewModel : SingleObjectViewModel<Supplier_Type, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Supplier_TypeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Supplier_TypeViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Supplier_TypeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Supplier_TypeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Supplier_TypeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Supplier_TypeViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Supplier_Type, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Supplier_TypeViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Suppliers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Suppliers> LookUpSuppliers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Supplier_TypeViewModel x) => x.LookUpSuppliers,
                    getRepositoryFunc: x => x.Suppliers);
            }
        }


        /// <summary>
        /// The view model for the Supplier_TypeSuppliers detail collection.
        /// </summary>
        public CollectionViewModelBase<Suppliers, Suppliers, long, IDB_EMKPRKNEntitiesUnitOfWork> Supplier_TypeSuppliersDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Supplier_TypeViewModel x) => x.Supplier_TypeSuppliersDetails,
                    getRepositoryFunc: x => x.Suppliers,
                    foreignKeyExpression: x => x.SupplierTypeId,
                    navigationExpression: x => x.Supplier_Type);
            }
        }
    }
}
