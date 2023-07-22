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
    /// Represents the single Projects object view model.
    /// </summary>
    public partial class ProjectsViewModel : SingleObjectViewModel<Projects, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ProjectsViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ProjectsViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ProjectsViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ProjectsViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ProjectsViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ProjectsViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Projects, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Project_Rev for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Project_Rev> LookUpProject_Rev {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ProjectsViewModel x) => x.LookUpProject_Rev,
                    getRepositoryFunc: x => x.Project_Rev);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Customer_Contact for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer_Contact> LookUpCustomer_Contact {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ProjectsViewModel x) => x.LookUpCustomer_Contact,
                    getRepositoryFunc: x => x.Customer_Contact);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Customer_Section for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer_Section> LookUpCustomer_Section {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ProjectsViewModel x) => x.LookUpCustomer_Section,
                    getRepositoryFunc: x => x.Customer_Section);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customers> LookUpCustomers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ProjectsViewModel x) => x.LookUpCustomers,
                    getRepositoryFunc: x => x.Customers);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Project_Detail for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Project_Detail> LookUpProject_Detail {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ProjectsViewModel x) => x.LookUpProject_Detail,
                    getRepositoryFunc: x => x.Project_Detail);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ProjectsViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }


        /// <summary>
        /// The view model for the ProjectsProject_Rev detail collection.
        /// </summary>
        public CollectionViewModelBase<Project_Rev, Project_Rev, long, IDB_EMKPRKNEntitiesUnitOfWork> ProjectsProject_RevDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ProjectsViewModel x) => x.ProjectsProject_RevDetails,
                    getRepositoryFunc: x => x.Project_Rev,
                    foreignKeyExpression: x => x.ProjectId,
                    navigationExpression: x => x.Projects);
            }
        }
    }
}
