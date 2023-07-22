﻿using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using Emikon.Parkon.UI.Win.test.DB_EMKPRKNEntitiesDataModel;
using Emikon.Parkon.UI.Win.test.Common;
using Emikon.Parkon.Model;

namespace Emikon.Parkon.UI.Win.test.ViewModels {

    /// <summary>
    /// Represents the Store_OutAction collection view model.
    /// </summary>
    public partial class Store_OutActionCollectionViewModel : CollectionViewModel<Store_OutAction, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Store_OutActionCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Store_OutActionCollectionViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Store_OutActionCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Store_OutActionCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Store_OutActionCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Store_OutActionCollectionViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Store_OutAction) {
        }
    }
}