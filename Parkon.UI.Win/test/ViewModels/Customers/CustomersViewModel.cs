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
    /// Represents the single Customers object view model.
    /// </summary>
    public partial class CustomersViewModel : SingleObjectViewModel<Customers, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CustomersViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CustomersViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CustomersViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CustomersViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CustomersViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CustomersViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Customers, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Customer_Contact for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer_Contact> LookUpCustomer_Contact {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CustomersViewModel x) => x.LookUpCustomer_Contact,
                    getRepositoryFunc: x => x.Customer_Contact);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Customer_Section for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer_Section> LookUpCustomer_Section {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CustomersViewModel x) => x.LookUpCustomer_Section,
                    getRepositoryFunc: x => x.Customer_Section);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Customer_Type for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer_Type> LookUpCustomer_Type {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CustomersViewModel x) => x.LookUpCustomer_Type,
                    getRepositoryFunc: x => x.Customer_Type);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customers> LookUpCustomers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CustomersViewModel x) => x.LookUpCustomers,
                    getRepositoryFunc: x => x.Customers);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CustomersViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Zone for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Zone> LookUpZone {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CustomersViewModel x) => x.LookUpZone,
                    getRepositoryFunc: x => x.Zone);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Projects for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Projects> LookUpProjects {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CustomersViewModel x) => x.LookUpProjects,
                    getRepositoryFunc: x => x.Projects);
            }
        }


        /// <summary>
        /// The view model for the CustomersCustomer_Contact detail collection.
        /// </summary>
        public CollectionViewModelBase<Customer_Contact, Customer_Contact, long, IDB_EMKPRKNEntitiesUnitOfWork> CustomersCustomer_ContactDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (CustomersViewModel x) => x.CustomersCustomer_ContactDetails,
                    getRepositoryFunc: x => x.Customer_Contact,
                    foreignKeyExpression: x => x.CustomerId,
                    navigationExpression: x => x.Customers);
            }
        }

        /// <summary>
        /// The view model for the CustomersCustomer_Section detail collection.
        /// </summary>
        public CollectionViewModelBase<Customer_Section, Customer_Section, long, IDB_EMKPRKNEntitiesUnitOfWork> CustomersCustomer_SectionDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (CustomersViewModel x) => x.CustomersCustomer_SectionDetails,
                    getRepositoryFunc: x => x.Customer_Section,
                    foreignKeyExpression: x => x.CustomerId,
                    navigationExpression: x => x.Customers);
            }
        }

        /// <summary>
        /// The view model for the CustomersProjects detail collection.
        /// </summary>
        public CollectionViewModelBase<Projects, Projects, long, IDB_EMKPRKNEntitiesUnitOfWork> CustomersProjectsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (CustomersViewModel x) => x.CustomersProjectsDetails,
                    getRepositoryFunc: x => x.Projects,
                    foreignKeyExpression: x => x.CustomerId,
                    navigationExpression: x => x.Customers);
            }
        }
    }
}
