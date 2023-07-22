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
    /// Represents the single Customer_Type object view model.
    /// </summary>
    public partial class Customer_TypeViewModel : SingleObjectViewModel<Customer_Type, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Customer_TypeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Customer_TypeViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Customer_TypeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Customer_TypeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Customer_TypeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Customer_TypeViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Customer_Type, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Customer_TypeViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customers> LookUpCustomers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Customer_TypeViewModel x) => x.LookUpCustomers,
                    getRepositoryFunc: x => x.Customers);
            }
        }


        /// <summary>
        /// The view model for the Customer_TypeCustomers detail collection.
        /// </summary>
        public CollectionViewModelBase<Customers, Customers, long, IDB_EMKPRKNEntitiesUnitOfWork> Customer_TypeCustomersDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Customer_TypeViewModel x) => x.Customer_TypeCustomersDetails,
                    getRepositoryFunc: x => x.Customers,
                    foreignKeyExpression: x => x.CustomerTypeId,
                    navigationExpression: x => x.Customer_Type);
            }
        }
    }
}
