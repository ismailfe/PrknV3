using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using Emikon.Parkon.UI.Win.test.DB_EMKPRKNEntitiesDataModel;
using Emikon.Parkon.UI.Win.test.Common;
using Emikon.Parkon.Model;

namespace Emikon.Parkon.UI.Win.test.ViewModels {

    /// <summary>
    /// Represents the User_Authorization collection view model.
    /// </summary>
    public partial class User_AuthorizationCollectionViewModel : CollectionViewModel<User_Authorization, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of User_AuthorizationCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static User_AuthorizationCollectionViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new User_AuthorizationCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the User_AuthorizationCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the User_AuthorizationCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected User_AuthorizationCollectionViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.User_Authorization) {
        }
    }
}