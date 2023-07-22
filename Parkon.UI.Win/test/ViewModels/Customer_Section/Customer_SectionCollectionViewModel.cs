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
    /// Represents the Customer_Section collection view model.
    /// </summary>
    public partial class Customer_SectionCollectionViewModel : CollectionViewModel<Customer_Section, long, IDB_EMKPRKNEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Customer_SectionCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Customer_SectionCollectionViewModel Create(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Customer_SectionCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Customer_SectionCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Customer_SectionCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Customer_SectionCollectionViewModel(IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Customer_Section) {
        }
    }
}