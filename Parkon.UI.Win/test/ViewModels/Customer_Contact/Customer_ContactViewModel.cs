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
    /// Represents the single Customer_Contact object view model.
    /// </summary>
    public partial class Customer_ContactViewModel : SingleObjectViewModel<Customer_Contact, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Customer_ContactViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Customer_ContactViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Customer_ContactViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Customer_ContactViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Customer_ContactViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Customer_ContactViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Customer_Contact, x => x.NameFirst) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customers> LookUpCustomers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Customer_ContactViewModel x) => x.LookUpCustomers,
                    getRepositoryFunc: x => x.Customers);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Title for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Title> LookUpTitle {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Customer_ContactViewModel x) => x.LookUpTitle,
                    getRepositoryFunc: x => x.Title);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Customer_ContactViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Project_Rev for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Project_Rev> LookUpProject_Rev {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Customer_ContactViewModel x) => x.LookUpProject_Rev,
                    getRepositoryFunc: x => x.Project_Rev);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Projects for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Projects> LookUpProjects {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Customer_ContactViewModel x) => x.LookUpProjects,
                    getRepositoryFunc: x => x.Projects);
            }
        }


        /// <summary>
        /// The view model for the Customer_ContactProject_Rev detail collection.
        /// </summary>
        public CollectionViewModelBase<Project_Rev, Project_Rev, long, IDB_EMKPRKNEntitiesUnitOfWork> Customer_ContactProject_RevDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Customer_ContactViewModel x) => x.Customer_ContactProject_RevDetails,
                    getRepositoryFunc: x => x.Project_Rev,
                    foreignKeyExpression: x => x.CustomerContactId,
                    navigationExpression: x => x.Customer_Contact);
            }
        }

        /// <summary>
        /// The view model for the Customer_ContactProjects detail collection.
        /// </summary>
        public CollectionViewModelBase<Projects, Projects, long, IDB_EMKPRKNEntitiesUnitOfWork> Customer_ContactProjectsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Customer_ContactViewModel x) => x.Customer_ContactProjectsDetails,
                    getRepositoryFunc: x => x.Projects,
                    foreignKeyExpression: x => x.CustomerContactId,
                    navigationExpression: x => x.Customer_Contact);
            }
        }
    }
}
