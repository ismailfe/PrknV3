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
    /// Represents the single Title object view model.
    /// </summary>
    public partial class TitleViewModel : SingleObjectViewModel<Title, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of TitleViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TitleViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TitleViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the TitleViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TitleViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TitleViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Title, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Customer_Contact for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer_Contact> LookUpCustomer_Contact {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TitleViewModel x) => x.LookUpCustomer_Contact,
                    getRepositoryFunc: x => x.Customer_Contact);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Supplier_Contact for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Supplier_Contact> LookUpSupplier_Contact {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TitleViewModel x) => x.LookUpSupplier_Contact,
                    getRepositoryFunc: x => x.Supplier_Contact);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TitleViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }


        /// <summary>
        /// The view model for the TitleCustomer_Contact detail collection.
        /// </summary>
        public CollectionViewModelBase<Customer_Contact, Customer_Contact, long, IDB_EMKPRKNEntitiesUnitOfWork> TitleCustomer_ContactDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (TitleViewModel x) => x.TitleCustomer_ContactDetails,
                    getRepositoryFunc: x => x.Customer_Contact,
                    foreignKeyExpression: x => x.TitleId,
                    navigationExpression: x => x.Title);
            }
        }

        /// <summary>
        /// The view model for the TitleSupplier_Contact detail collection.
        /// </summary>
        public CollectionViewModelBase<Supplier_Contact, Supplier_Contact, long, IDB_EMKPRKNEntitiesUnitOfWork> TitleSupplier_ContactDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (TitleViewModel x) => x.TitleSupplier_ContactDetails,
                    getRepositoryFunc: x => x.Supplier_Contact,
                    foreignKeyExpression: x => x.TitleId,
                    navigationExpression: x => x.Title);
            }
        }

        /// <summary>
        /// The view model for the TitleUsers1 detail collection.
        /// </summary>
        public CollectionViewModelBase<Users, Users, long, IDB_EMKPRKNEntitiesUnitOfWork> TitleUsers1Details {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (TitleViewModel x) => x.TitleUsers1Details,
                    getRepositoryFunc: x => x.Users,
                    foreignKeyExpression: x => x.TitleId,
                    navigationExpression: x => x.Title1);
            }
        }
    }
}
