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
    /// Represents the single Project_Detail object view model.
    /// </summary>
    public partial class Project_DetailViewModel : SingleObjectViewModel<Project_Detail, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Project_DetailViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Project_DetailViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Project_DetailViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Project_DetailViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Project_DetailViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Project_DetailViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Project_Detail, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Project_DetailViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Projects for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Projects> LookUpProjects {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Project_DetailViewModel x) => x.LookUpProjects,
                    getRepositoryFunc: x => x.Projects);
            }
        }


        /// <summary>
        /// The view model for the Project_DetailProjects detail collection.
        /// </summary>
        public CollectionViewModelBase<Projects, Projects, long, IDB_EMKPRKNEntitiesUnitOfWork> Project_DetailProjectsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Project_DetailViewModel x) => x.Project_DetailProjectsDetails,
                    getRepositoryFunc: x => x.Projects,
                    foreignKeyExpression: x => x.ProjectDetailId,
                    navigationExpression: x => x.Project_Detail);
            }
        }
    }
}
