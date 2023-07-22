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
    /// Represents the single Suppliers object view model.
    /// </summary>
    public partial class SuppliersViewModel : SingleObjectViewModel<Suppliers, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of SuppliersViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SuppliersViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SuppliersViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SuppliersViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SuppliersViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SuppliersViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Suppliers, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Supplier_Contact for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Supplier_Contact> LookUpSupplier_Contact {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SuppliersViewModel x) => x.LookUpSupplier_Contact,
                    getRepositoryFunc: x => x.Supplier_Contact);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Supplier_Section for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Supplier_Section> LookUpSupplier_Section {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SuppliersViewModel x) => x.LookUpSupplier_Section,
                    getRepositoryFunc: x => x.Supplier_Section);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Supplier_Type for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Supplier_Type> LookUpSupplier_Type {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SuppliersViewModel x) => x.LookUpSupplier_Type,
                    getRepositoryFunc: x => x.Supplier_Type);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SuppliersViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Zone for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Zone> LookUpZone {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SuppliersViewModel x) => x.LookUpZone,
                    getRepositoryFunc: x => x.Zone);
            }
        }


        /// <summary>
        /// The view model for the SuppliersSupplier_Contact detail collection.
        /// </summary>
        public CollectionViewModelBase<Supplier_Contact, Supplier_Contact, long, IDB_EMKPRKNEntitiesUnitOfWork> SuppliersSupplier_ContactDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (SuppliersViewModel x) => x.SuppliersSupplier_ContactDetails,
                    getRepositoryFunc: x => x.Supplier_Contact,
                    foreignKeyExpression: x => x.SupplierId,
                    navigationExpression: x => x.Suppliers);
            }
        }

        /// <summary>
        /// The view model for the SuppliersSupplier_Section detail collection.
        /// </summary>
        public CollectionViewModelBase<Supplier_Section, Supplier_Section, long, IDB_EMKPRKNEntitiesUnitOfWork> SuppliersSupplier_SectionDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (SuppliersViewModel x) => x.SuppliersSupplier_SectionDetails,
                    getRepositoryFunc: x => x.Supplier_Section,
                    foreignKeyExpression: x => x.SupplierId,
                    navigationExpression: x => x.Suppliers);
            }
        }
    }
}
