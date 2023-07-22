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
    /// Represents the single User_Level object view model.
    /// </summary>
    public partial class User_LevelViewModel : SingleObjectViewModel<User_Level, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of User_LevelViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static User_LevelViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new User_LevelViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the User_LevelViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the User_LevelViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected User_LevelViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.User_Level, x => x.SysCode) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (User_LevelViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }


        /// <summary>
        /// The view model for the User_LevelUsers1 detail collection.
        /// </summary>
        public CollectionViewModelBase<Users, Users, long, IDB_EMKPRKNEntitiesUnitOfWork> User_LevelUsers1Details {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (User_LevelViewModel x) => x.User_LevelUsers1Details,
                    getRepositoryFunc: x => x.Users,
                    foreignKeyExpression: x => x.LevelsId,
                    navigationExpression: x => x.User_Level1);
            }
        }
    }
}
