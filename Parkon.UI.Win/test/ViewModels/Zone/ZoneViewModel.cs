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
    /// Represents the single Zone object view model.
    /// </summary>
    public partial class ZoneViewModel : SingleObjectViewModel<Zone, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ZoneViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ZoneViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ZoneViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ZoneViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ZoneViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ZoneViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Zone, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Customer_Section for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer_Section> LookUpCustomer_Section {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ZoneViewModel x) => x.LookUpCustomer_Section,
                    getRepositoryFunc: x => x.Customer_Section);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customers> LookUpCustomers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ZoneViewModel x) => x.LookUpCustomers,
                    getRepositoryFunc: x => x.Customers);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Supplier_Section for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Supplier_Section> LookUpSupplier_Section {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ZoneViewModel x) => x.LookUpSupplier_Section,
                    getRepositoryFunc: x => x.Supplier_Section);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Suppliers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Suppliers> LookUpSuppliers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ZoneViewModel x) => x.LookUpSuppliers,
                    getRepositoryFunc: x => x.Suppliers);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ZoneViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }


        /// <summary>
        /// The view model for the ZoneCustomer_Section detail collection.
        /// </summary>
        public CollectionViewModelBase<Customer_Section, Customer_Section, long, IDB_EMKPRKNEntitiesUnitOfWork> ZoneCustomer_SectionDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ZoneViewModel x) => x.ZoneCustomer_SectionDetails,
                    getRepositoryFunc: x => x.Customer_Section,
                    foreignKeyExpression: x => x.ZoneId,
                    navigationExpression: x => x.Zone);
            }
        }

        /// <summary>
        /// The view model for the ZoneCustomers detail collection.
        /// </summary>
        public CollectionViewModelBase<Customers, Customers, long, IDB_EMKPRKNEntitiesUnitOfWork> ZoneCustomersDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ZoneViewModel x) => x.ZoneCustomersDetails,
                    getRepositoryFunc: x => x.Customers,
                    foreignKeyExpression: x => x.ZoneId,
                    navigationExpression: x => x.Zone);
            }
        }

        /// <summary>
        /// The view model for the ZoneSupplier_Section detail collection.
        /// </summary>
        public CollectionViewModelBase<Supplier_Section, Supplier_Section, long, IDB_EMKPRKNEntitiesUnitOfWork> ZoneSupplier_SectionDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ZoneViewModel x) => x.ZoneSupplier_SectionDetails,
                    getRepositoryFunc: x => x.Supplier_Section,
                    foreignKeyExpression: x => x.ZoneId,
                    navigationExpression: x => x.Zone);
            }
        }

        /// <summary>
        /// The view model for the ZoneSuppliers detail collection.
        /// </summary>
        public CollectionViewModelBase<Suppliers, Suppliers, long, IDB_EMKPRKNEntitiesUnitOfWork> ZoneSuppliersDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ZoneViewModel x) => x.ZoneSuppliersDetails,
                    getRepositoryFunc: x => x.Suppliers,
                    foreignKeyExpression: x => x.ZoneId,
                    navigationExpression: x => x.Zone);
            }
        }
    }
}
