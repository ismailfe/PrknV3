﻿using System;
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
    /// Represents the single Store_ProductGroup object view model.
    /// </summary>
    public partial class Store_ProductGroupViewModel : SingleObjectViewModel<Store_ProductGroup, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Store_ProductGroupViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Store_ProductGroupViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Store_ProductGroupViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Store_ProductGroupViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Store_ProductGroupViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Store_ProductGroupViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Store_ProductGroup, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Store_Product for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Store_Product> LookUpStore_Product {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_ProductGroupViewModel x) => x.LookUpStore_Product,
                    getRepositoryFunc: x => x.Store_Product);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Store_ProductGroupViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }


        /// <summary>
        /// The view model for the Store_ProductGroupStore_Product detail collection.
        /// </summary>
        public CollectionViewModelBase<Store_Product, Store_Product, long, IDB_EMKPRKNEntitiesUnitOfWork> Store_ProductGroupStore_ProductDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Store_ProductGroupViewModel x) => x.Store_ProductGroupStore_ProductDetails,
                    getRepositoryFunc: x => x.Store_Product,
                    foreignKeyExpression: x => x.GroupId,
                    navigationExpression: x => x.Store_ProductGroup);
            }
        }
    }
}
