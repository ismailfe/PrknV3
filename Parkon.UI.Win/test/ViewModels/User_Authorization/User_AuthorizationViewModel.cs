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
    /// Represents the single User_Authorization object view model.
    /// </summary>
    public partial class User_AuthorizationViewModel : SingleObjectViewModel<User_Authorization, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of User_AuthorizationViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static User_AuthorizationViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new User_AuthorizationViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the User_AuthorizationViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the User_AuthorizationViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected User_AuthorizationViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.User_Authorization, x => x.SysCode) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (User_AuthorizationViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }


        /// <summary>
        /// The view model for the User_AuthorizationUsers2 detail collection.
        /// </summary>
        public CollectionViewModelBase<Users, Users, long, IDB_EMKPRKNEntitiesUnitOfWork> User_AuthorizationUsers2Details {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (User_AuthorizationViewModel x) => x.User_AuthorizationUsers2Details,
                    getRepositoryFunc: x => x.Users,
                    foreignKeyExpression: x => x.AutrizationId,
                    navigationExpression: x => x.User_Authorization2);
            }
        }
    }
}
