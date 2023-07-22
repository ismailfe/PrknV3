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
    /// Represents the single Customer_Section object view model.
    /// </summary>
    public partial class Customer_SectionViewModel : SingleObjectViewModel<Customer_Section, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Customer_SectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Customer_SectionViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Customer_SectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Customer_SectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Customer_SectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Customer_SectionViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Customer_Section, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customers> LookUpCustomers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Customer_SectionViewModel x) => x.LookUpCustomers,
                    getRepositoryFunc: x => x.Customers);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Zone for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Zone> LookUpZone {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Customer_SectionViewModel x) => x.LookUpZone,
                    getRepositoryFunc: x => x.Zone);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Projects for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Projects> LookUpProjects {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Customer_SectionViewModel x) => x.LookUpProjects,
                    getRepositoryFunc: x => x.Projects);
            }
        }


        /// <summary>
        /// The view model for the Customer_SectionProjects detail collection.
        /// </summary>
        public CollectionViewModelBase<Projects, Projects, long, IDB_EMKPRKNEntitiesUnitOfWork> Customer_SectionProjectsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Customer_SectionViewModel x) => x.Customer_SectionProjectsDetails,
                    getRepositoryFunc: x => x.Projects,
                    foreignKeyExpression: x => x.CustomerSectionId,
                    navigationExpression: x => x.Customer_Section);
            }
        }
    }
}
