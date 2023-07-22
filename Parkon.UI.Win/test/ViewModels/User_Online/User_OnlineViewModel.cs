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
    /// Represents the single User_Online object view model.
    /// </summary>
    public partial class User_OnlineViewModel : SingleObjectViewModel<User_Online, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of User_OnlineViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static User_OnlineViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new User_OnlineViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the User_OnlineViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the User_OnlineViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected User_OnlineViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.User_Online, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (User_OnlineViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }


        /// <summary>
        /// The view model for the User_OnlineUsers1 detail collection.
        /// </summary>
        public CollectionViewModelBase<Users, Users, long, IDB_EMKPRKNEntitiesUnitOfWork> User_OnlineUsers1Details {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (User_OnlineViewModel x) => x.User_OnlineUsers1Details,
                    getRepositoryFunc: x => x.Users,
                    foreignKeyExpression: x => x.OnlineId,
                    navigationExpression: x => x.User_Online1);
            }
        }
    }
}
