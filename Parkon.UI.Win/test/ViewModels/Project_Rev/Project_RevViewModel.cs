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
    /// Represents the single Project_Rev object view model.
    /// </summary>
    public partial class Project_RevViewModel : SingleObjectViewModel<Project_Rev, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Project_RevViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Project_RevViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Project_RevViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Project_RevViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Project_RevViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Project_RevViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Project_Rev, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Customer_Contact for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer_Contact> LookUpCustomer_Contact {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Project_RevViewModel x) => x.LookUpCustomer_Contact,
                    getRepositoryFunc: x => x.Customer_Contact);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Projects for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Projects> LookUpProjects {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Project_RevViewModel x) => x.LookUpProjects,
                    getRepositoryFunc: x => x.Projects);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Project_RevViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }

    }
}
